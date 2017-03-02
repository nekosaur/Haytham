
namespace myGlass
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Net.Sockets;
    using System.Text;
    using System.Net;
    using Haytham;
    using System.Linq;
    using Haytham.FXPAL;
    using System.Threading;
    using System.Web.Script.Serialization;
    
    using Haytham.Glass.Experiments;
    using System.Security.Cryptography;

    /// <summary>
    /// </summary>
    public class Client
    {
        #region Fields

        byte[] headerBytes = new byte[22];
        byte[] digest = new byte[16];
        public double progressData_Total = 0;
        public double progressData_Remaining = 0;
        public ImageProcessing_Emgu EmgImgProcssing = new ImageProcessing_Emgu();

        int headerIndex = 0;

        //byte[] buf = new byte[8192];
        byte[] result = new byte[1];
        int count = 0;

        System.IO.MemoryStream dataOutputStream = new MemoryStream();
     
        public Calibration tempCalibration;
        public Image bitmap;

        enum Mode : int { None = 0, MainLoop = 1, WaitingForHeader = 2, WaitingForPicture = 3, FXPAL = 4, WaitingForJSONSize = 5, waitingForJSON = 6 };
        Mode mode = Mode.MainLoop;

        public enum Ready_State : int { No = 0, Yes = 1 ,Error=-1};
        public Ready_State myGlassReady_State = Ready_State.No;
        private Boolean snapshot = false;
        public Calibration_Scene myCalibration_Scene=new Calibration_Scene();
        public Image currentImage = null;

        /// <summary>
        ///   Socket for accepting a connection
        /// </summary>
        public readonly TcpClient tcpClient;

        /// <summary>
        ///   The socket network data stream
        /// </summary>
        public readonly NetworkStream socketStream;

        /// <summary>
        ///   The reference to server
        /// </summary>
        private readonly Server server;
        public string glassIP = "";
        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="socket">
        /// The socket.
        /// </param>
        /// <param name="serverValue">
        /// The server value.
        /// </param>
        public Client(TcpClient socket, Server serverValue)
        {
            this.server = serverValue;

            finish("New Connection established!");
            this.tcpClient = socket;

            // create NetworkStream object for Socket
            this.socketStream = this.tcpClient.GetStream();
        }
        #endregion

        public void ServerThread()
        {
            try
            {
                System.Net.Sockets.UdpClient udpClient = new System.Net.Sockets.UdpClient(constants.SERVER_PORT_UDP);
                IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);

                byte[] data = new byte[1024];
                data = udpClient.Receive(ref sender);
                udpClient.Close();
                string stringData = Encoding.ASCII.GetString(data, 0, data.Length);

                server.GlassIP = sender.Address.ToString();
                server.udpServer = new UdpClient(constants.SERVER_PORT_UDP_GAZE);
                server.remoteEP = new IPEndPoint(IPAddress.Parse(server.GlassIP), constants.SERVER_PORT_UDP_GAZE);
                server.sendSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                METState.Current.METCoreObject.SendToForm("Glass IP: " + server.GlassIP + "\r\n", "tbOutput");
            }
            catch (Exception e) { }
        }

        /// <summary>
        ///   Runs this instance.
        /// </summary>
        public void Run()
        {
            METState.Current.METCoreObject.SendToForm(0, "progressbar");

            ////UDP
            int cnt = 0;
            byte[] message;
            string msg = "";
            byte[] received;

            METState.Current.GlassServer.Send(myGlass.MessageType.toGLASS_WHAT_IS_YOUR_IP);

            Thread thdUDPServer = new Thread(new ThreadStart(ServerThread));
            thdUDPServer.Start();

            Thread.Sleep(500);

            do
            {
                try
                {
                    switch (mode)
                    {
                        case Mode.MainLoop:
                            {
                                received = new byte[constants.MSG_SIZE];
                                //socketStream.ReadTimeout = 10000;
                                int tmp = socketStream.Read(received, 0, received.Length);

                                if (tmp <= 0)
                                {
                                    cnt++;
                                    break;

                                }
                                else if (tmp == 12)
                                {
                                    //msg = System.Text.Encoding.UTF8.GetString(received, 0, tmp);//.TrimEnd('\0');
                                    //String received_MSG = myGlass.MessageType.commands.SingleOrDefault(x => x.Value == GetIndicator(received)).Key;
                                    //METState.Current.METCoreObject.SendToForm("Received msg: " + received_MSG, "tbOutput");

                                    interpretMSG(received);
                                }
                            }
                            break;

                        case Mode.WaitingForJSONSize:
                            {
                                byte[] buffer = new byte[4];
                                //updateUI("Waiting for data.  Expecting " + progressData_Remaining + " more bytes.");
                                int bytesRead = METState.Current.GlassServer.client.socketStream.Read(buffer, 0, buffer.Length);
                                if (bytesRead == 4)
                                {
                                    progressData_Total = byteArrayToInt(buffer);
                                    progressData_Remaining = progressData_Total;
                                    dataOutputStream = new MemoryStream();

                                    mode = Mode.waitingForJSON;
                                }
                                else mode = Mode.MainLoop;

                            }
                            break;

                        case Mode.waitingForJSON:
                            {
                                int prg = getJson();

                                if (prg == 1)
                                {
                                    mode = Mode.MainLoop;
                                    METState.Current.GlassServer.Send(MessageType.toGLASS_DataReceived);
                                }
                                else if (prg == -1)
                                {
                                    mode = Mode.MainLoop;
                                }
                            }
                            break;

                        case Mode.WaitingForHeader:
                            {
                                int prg = getHeader();

                                if (prg == -1)
                                {
                                    mode = Mode.MainLoop;
                                    //Calibration terminated!
                                    server.Send(myGlass.MessageType.toGLASS_Calibrate_Scene, new Point(-3, -3));//point x (th) of y (total)
                                }

                                else if (prg == 1)
                                    mode = Mode.WaitingForPicture;
                            }
                            break;

                        case Mode.WaitingForPicture:
                            {
                                int prg = getPicture();

                                if (prg == 1)
                                {
                                    if (snapshot)
                                    {
                                        mode = Mode.MainLoop;

                                        #region Draw gaze  on image
                                        if (METState.Current.ShowGaze)
                                        {
                                            //This will show the gaze obtained from eyeToScene when taking the snapshot

                                            EmgImgProcssing.DrawCircle((Bitmap)bitmap,

                                            Convert.ToInt32(METState.Current.Gaze_SnapShot_Glass.X), Convert.ToInt32(METState.Current.Gaze_SnapShot_Glass.Y), System.Drawing.Color.LightGreen);


                                            FXPAL_Utils.UpdateUI();


                                        }
                                        #endregion Draw gaze cross on image

                                        //METState.Current.METCoreObject.SendToForm(bitmap, "imScene");
                                        //METState.Current.METCoreObject.SendToForm("", "Update Glass Picturebox");    

                                        METState.Current.GlassFrontView_Resolution = new Size(bitmap.Width, bitmap.Height);

                                        currentImage = bitmap;


                                        snapshot = false;
                                    }
                                   
                                    else if  (CalibExp.scene_is_sampling)
                                    {

                                        mode = Mode.MainLoop;
   currentImage =new Bitmap( bitmap);//This will be automatically shown in the form

                                        CalibExp.mySampling_Scene.ProcessImg(bitmap);

                                     
                                        METState.Current.GlassFrontView_Resolution = new Size(bitmap.Width, bitmap.Height);


                                         

                                    }
                                    else if (myCalibration_Scene.is_sampling)//calibration
                                    {
                                        mode = Mode.MainLoop;
  currentImage =new Bitmap( bitmap);//This will be automatically shown in the form

                                        myCalibration_Scene.ProcessImg(bitmap);

                                      
                                        METState.Current.GlassFrontView_Resolution = new Size(bitmap.Width, bitmap.Height);


                                    
                                          
                                      
                                    }
                                          

                                }
                                else if (prg == -1)
                                {

                                    mode = Mode.MainLoop;
                                }



                            }
                            break;
                    }


                }
                catch (IOException exception)
                {

                    break;

                }
            }
            while (cnt == 0 && !msg.StartsWith("CLIENT>>> TERMINATE") && tcpClient.Client.Connected); //cnt < 10 &&

            // close the socket connection
            finish("Client has disconnected!!!!");

            METState.Current.METCoreObject.SendToForm("*********************************************\r\n", "tbOutput");


        }

        private void finish(String msg)
        {
            try
            {
                METState.Current.METCoreObject.SendToForm(msg, "tbOutput");



                //server.remoteEP = null;
                // server.sendSocket.Disconnect(true);
                //server.sendSocket.Close();
                server.udpServer.Close();
                // server.udpServer = null;

            }
            catch (Exception e)
            { }

            try
            {
                tcpClient.Client.Close();
                // socketStream.Close();
                tcpClient.Close();
            }
            catch (Exception e)
            { }
        }

        int wait = 4000;

        private void interpretMSG(byte[] msg)
        {
            // we can insure that this is a correct msg by if(GetIndicator(msg)==GetX(msg))
            int indicator = GetIndicator(msg);
            switch (indicator)
            {

                case MessageType.toHAYTHAM_READY:
                    {
                        myGlassReady_State = Ready_State.Yes;

                        //Experiment
                        if (CalibExp.scene_is_sampling)
                        {
                            CalibExp.mySampling_Scene.UserIsReady();
                            myGlassReady_State = Ready_State.No;
                        }
                        else if ( myCalibration_Scene.is_sampling)
                        {


                            myCalibration_Scene.UserIsReady();
                            myGlassReady_State = Ready_State.No;
                        }
                    }

                    break;
                case MessageType.toHAYTHAM_Calibrate_Display_Finished:
                    {
                        myGlassReady_State = Ready_State.Error;

                    }

                    break;
                case MessageType.toHAYTHAM_Calibrate_Display:
                    {
                        myGlassReady_State = Ready_State.No;
                        int n;
                        METState.Current.EyeToEye_Mapping.Calibrated = false;
                        n = 3;
                        METState.Current.EyeToDisplay_Mapping.CalibrationType = Calibration.calibration_type.calib_Polynomial;


                        METState.Current.GlassServer.Send(myGlass.MessageType.toGLASS_Calibrate_Display, new Point(-1, -1));//only show the msg to the user not the point
                        Thread.Sleep(3000);//??


                        METState.Current.EyeToDisplay_Mapping.GazeErrorX = 0;
                        METState.Current.EyeToDisplay_Mapping.GazeErrorY = 0;


                        METState.Current.EyeToDisplay_Mapping.CalibrationTarget = 0;
                        METState.Current.EyeToDisplay_Mapping.Calibrated = false;



                        Rectangle rect = new Rectangle(0, 0, myGlass.constants.display_W, myGlass.constants.display_H);

                        METState.Current.remoteCalibration = new RemoteCalibration(n, n, rect, RemoteCalibration.Task.CalibrateDisplay); ;



                    }
                    break;

                case MessageType.toHAYTHAM_Calibrate_ReUse:
                    {
                        myGlassReady_State = Ready_State.No;
                        METState.Current.EyeToDisplay_Mapping.GazeErrorX = 0;
                        METState.Current.EyeToDisplay_Mapping.GazeErrorY = 0;
                        METState.Current.EyeToScene_Mapping.GazeErrorX = 0;
                        METState.Current.EyeToScene_Mapping.GazeErrorY = 0;



                        int n;
                        if (METState.Current.EyeToDisplay_Mapping.Calibrated)
                        {


                            CalibExp.EyeToDisplay_Mapping_4points.GazeErrorX = 0;
                            CalibExp.EyeToDisplay_Mapping_4points.GazeErrorY = 0;
                            CalibExp.EyeToDisplay_Mapping_4points.Calibrated = false;
                            CalibExp.EyeToDisplay_Mapping_4points.CalibrationType = Calibration.calibration_type.calib_Homography;



                            METState.Current.EyeToEye_Mapping.Calibrated = false;
                            n = 3;
                            METState.Current.EyeToEye_Mapping.CalibrationType = Calibration.calibration_type.calib_Polynomial;

                            METState.Current.EyeToEye_Mapping.CalibrationTarget = 0;

                            if (METState.Current.EyeToDisplay_Mapping.CalibrationTarget == 8)
                            {

                                //METState.Current.EyeToEye_Mapping.Destination[0, 0] = METState.Current.EyeToDisplay_Mapping.Source[0, 0];
                                //METState.Current.EyeToEye_Mapping.Destination[1, 0] = METState.Current.EyeToDisplay_Mapping.Source[1, 0];

                                //METState.Current.EyeToEye_Mapping.Destination[0, 1] = METState.Current.EyeToDisplay_Mapping.Source[0, 2];
                                //METState.Current.EyeToEye_Mapping.Destination[1, 1] = METState.Current.EyeToDisplay_Mapping.Source[1, 2];

                                //METState.Current.EyeToEye_Mapping.Destination[0, 2] = METState.Current.EyeToDisplay_Mapping.Source[0, 6];
                                //METState.Current.EyeToEye_Mapping.Destination[1, 2] = METState.Current.EyeToDisplay_Mapping.Source[1, 6];

                                //METState.Current.EyeToEye_Mapping.Destination[0, 3] = METState.Current.EyeToDisplay_Mapping.Source[0, 8];
                                //METState.Current.EyeToEye_Mapping.Destination[1, 3] = METState.Current.EyeToDisplay_Mapping.Source[1, 8];

                                METState.Current.EyeToEye_Mapping.Destination = METState.Current.EyeToDisplay_Mapping.Source;


                            }
                            else if (METState.Current.EyeToDisplay_Mapping.CalibrationTarget == 3)
                            {

                                METState.Current.EyeToEye_Mapping.Destination[0, 0] = METState.Current.EyeToDisplay_Mapping.Source[0, 0];
                                METState.Current.EyeToEye_Mapping.Destination[1, 0] = METState.Current.EyeToDisplay_Mapping.Source[1, 0];

                                METState.Current.EyeToEye_Mapping.Destination[0, 1] = METState.Current.EyeToDisplay_Mapping.Source[0, 1];
                                METState.Current.EyeToEye_Mapping.Destination[1, 1] = METState.Current.EyeToDisplay_Mapping.Source[1, 1];

                                METState.Current.EyeToEye_Mapping.Destination[0, 2] = METState.Current.EyeToDisplay_Mapping.Source[0, 2];
                                METState.Current.EyeToEye_Mapping.Destination[1, 2] = METState.Current.EyeToDisplay_Mapping.Source[1, 2];

                                METState.Current.EyeToEye_Mapping.Destination[0, 3] = METState.Current.EyeToDisplay_Mapping.Source[0, 3];
                                METState.Current.EyeToEye_Mapping.Destination[1, 3] = METState.Current.EyeToDisplay_Mapping.Source[1, 3];
                            }


                            METState.Current.GlassServer.Send(myGlass.MessageType.toGLASS_Calibrate_Display, new Point(-1, -1));//only show the msg to the user not the point
                            Thread.Sleep(3000);//??

                            Rectangle rect = new Rectangle(0, 0, myGlass.constants.display_W, myGlass.constants.display_H);

                            METState.Current.remoteCalibration = new RemoteCalibration(n, n, rect, RemoteCalibration.Task.EyeToEye);

                        }
                        else
                        {
                            METState.Current.GlassServer.Send(myGlass.MessageType.toGLASS_ERROR_MasterNOTFound);

                        }

                    }
                    break;
                case MessageType.toHAYTHAM_Calibrate_Display_Correct:
                    {

                        if (METState.Current.EyeToDisplay_Mapping.Calibrated )
                        {

                            //METState.Current.GlassServer.Send(myGlass.MessageType.toGLASS_Calibrate_Display, new Point(-3, -3));//Look at the white circle


                            //Thread.Sleep(4000);//??


                            //if (METState.Current.EyeToDisplay_Mapping.Calibrated)
                            //{
                            //    AForge.Point Gaze = METState.Current.EyeToDisplay_Mapping.Map(METState.Current.eyeFeature.X, METState.Current.eyeFeature.Y, myGlass.constants.display_W / 2, myGlass.constants.display_H / 2);

                            //    METState.Current.EyeToDisplay_Mapping.GazeErrorX = Gaze.X;// 
                            //    METState.Current.EyeToDisplay_Mapping.GazeErrorY = Gaze.Y;//
                            //}
                            //if (METState.Current.EyeToDisplay_Master_Mapping.Calibrated)
                            //{
                            //    AForge.Point normalizedEye = METState.Current.EyeToEye_Mapping.Calibrated ? METState.Current.EyeToEye_Mapping.Map(METState.Current.eyeFeature.X, METState.Current.eyeFeature.Y, 0, 0) : METState.Current.eyeFeature;

                            //    AForge.Point Gaze = METState.Current.EyeToDisplay_Master_Mapping.Map(normalizedEye.X, normalizedEye.Y, myGlass.constants.display_W / 2, myGlass.constants.display_H / 2);

                            //    METState.Current.EyeToDisplay_Master_Mapping.GazeErrorX = Gaze.X;// 
                            //    METState.Current.EyeToDisplay_Master_Mapping.GazeErrorY = Gaze.Y;//
                            //}


                            //METState.Current.GlassServer.Send(myGlass.MessageType.toGLASS_Calibrate_Display, new Point(-3, -4));//done!
                        }
                        else
                        {
                            METState.Current.GlassServer.Send(myGlass.MessageType.toGLASS_ERROR_NOTCalibrated);

                        }

                    }
                    break;
                case MessageType.toHAYTHAM_SceneCalibration_Start:
                    {




                        int n = (int)Math.Sqrt(myCalibration_Scene.numberOfPictures);
                        myCalibration_Scene = new Calibration_Scene(n, n);


                        myGlassReady_State = Ready_State.No;
                        myCalibration_Scene.is_sampling = true;
                        

                    }
                    break;
                case MessageType.toHAYTHAM_Calibrate_Scene:
                    {


                        //This is needed here
                        myCalibration_Scene.numberOfPictures =9;

                        METState.Current.GlassServer.Send(myGlass.MessageType.toGLASS_Calibrate_Scene, new Point(-1, -1));
                        

                    }
                    break;
             
                case MessageType.toHAYTHAM_Calibrate_Scene_Correct:
                    {

                        //correctOffset_Scene = true;


                        //METState.Current.GlassServer.client.numberOfPictures = 1;

                        //METState.Current.GlassServer.Send(myGlass.MessageType.toGLASS_Calibrate_Scene, new Point(-6, -6));//start correct offset activity in glass
                        //Thread.Sleep(2000);//??

                    }
                    break;
                
                case MessageType.toHAYTHAM_SnapshotComming:
                    {
                        METState.Current.Gaze_SnapShot_Glass = METState.Current.Gaze_HMGT;
                       

                        #region ready to get the picture
                        snapshot = true;


                        #endregion

                    }
                    break;
                case MessageType.toHAYTHAM_JsonComming:
                    {
                        #region ready to get the picture

                        METState.Current.METCoreObject.SendToForm(0, "progressbar");

                        dataOutputStream = new MemoryStream();

                        mode = Mode.WaitingForJSONSize;

                        #endregion

                    }
                    break;
                case MessageType.toHAYTHAM_HeadderComming:
                    {
                        #region ready to get the picture
                        ////Reset varables
                        headerBytes = new byte[22];
                        digest = new byte[16];
                        headerIndex = 0;
                        result = new byte[1];
                        count = 0;
                        METState.Current.METCoreObject.SendToForm(0, "progressbar");

                        dataOutputStream = new MemoryStream();
                        //message = Encoding.ASCII.GetBytes("PauseGeneralReceive");
                        //socketStream.Write(message,0,message.Length);

                        mode = Mode.WaitingForHeader;

                        #endregion

                    }
                    break;
                case MessageType.toHAYTHAM_Experiment_display_Start:
                    {

                        int n;
                       
                        n = 3;
                        myGlassReady_State = Ready_State.No;


                        Rectangle rect = new Rectangle(0, 0, myGlass.constants.display_W, myGlass.constants.display_H);

                        CalibExp .mySampling_Display = new Sampling_Display(n, n, rect); 

                    }
                    break;
                case MessageType.toHAYTHAM_Experiment_scene_Start:
                    {

                        myGlassReady_State = Ready_State.No;

                        CalibExp.mySampling_Scene = new Sampling_Scene(3, 3);//CURRENTLY ONLY WORKS WITH 9 POINTS
                        CalibExp.scene_is_sampling = true;

                    }
                    break; 

                case MessageType.toHAYTHAM_StreamGaze_RGT_START:
                    {
                        METState.Current.GlassServer.gazeStream_RGT = myGlass.Server.GazeStream.RGT;
                    }
                    break;
                case MessageType.toHAYTHAM_StreamGaze_HMGT_START:
                    {
                        METState.Current.GlassServer.gazeStream_HMGT = myGlass.Server.GazeStream.HMGT;
                    }
                    break;
                case MessageType.toHAYTHAM_StreamGaze_HMGT_STOP:
                    {
                        METState.Current.GlassServer.gazeStream_HMGT = myGlass.Server.GazeStream.NoStreaming;
                    }
                    break;
                case MessageType.toHAYTHAM_StreamGaze_RGT_STOP:
                    {
                        METState.Current.GlassServer.gazeStream_RGT = myGlass.Server.GazeStream.NoStreaming;
                    }
                    break;
                default:
                    {




                    }
                    break;
            }




        }


        public void Calibrate_DisplayshownInSceneMapping(Point[] result)
        {

            METState.Current.DisplayShownInScene_Mapping.GazeErrorX = 0;
            METState.Current.DisplayShownInScene_Mapping.GazeErrorY = 0;

            METState.Current.DisplayShownInScene_Mapping.CalibrationType = Calibration.calibration_type.calib_Homography;
            METState.Current.DisplayShownInScene_Mapping.Calibrated = false;



            METState.Current.DisplayShownInScene_Mapping.Destination[0, 0] = result[0].X;
            METState.Current.DisplayShownInScene_Mapping.Destination[1, 0] = result[0].Y;
            METState.Current.DisplayShownInScene_Mapping.Destination[0, 1] = result[1].X;
            METState.Current.DisplayShownInScene_Mapping.Destination[1, 1] = result[1].Y;
            METState.Current.DisplayShownInScene_Mapping.Destination[0, 2] = result[2].X;
            METState.Current.DisplayShownInScene_Mapping.Destination[1, 2] = result[2].Y;
            METState.Current.DisplayShownInScene_Mapping.Destination[0, 3] = result[3].X;
            METState.Current.DisplayShownInScene_Mapping.Destination[1, 3] = result[3].Y;

            METState.Current.DisplayShownInScene_Mapping.Source[0, 0] = 0;
            METState.Current.DisplayShownInScene_Mapping.Source[1, 0] = 0;
            METState.Current.DisplayShownInScene_Mapping.Source[0, 1] = myGlass.constants.display_W;
            METState.Current.DisplayShownInScene_Mapping.Source[1, 1] = 0;
            METState.Current.DisplayShownInScene_Mapping.Source[0, 2] = 0;
            METState.Current.DisplayShownInScene_Mapping.Source[1, 2] = myGlass.constants.display_H;
            METState.Current.DisplayShownInScene_Mapping.Source[0, 3] = myGlass.constants.display_W;
            METState.Current.DisplayShownInScene_Mapping.Source[1, 3] = myGlass.constants.display_H;

            METState.Current.DisplayShownInScene_Mapping.Calibrate();
            METState.Current.DisplayShownInScene_Mapping.Calibrated = true;

        }


        
        private int getHeader()
        {
            int progress = 0;//0:progress 1:successfuly finished  -1:Failed

            try
            {
                //handle server connection
                byte[] received = new byte[1];
                socketStream.Read(received, 0, received.Length);

                headerBytes[headerIndex] = received[0];


                METState.Current.METCoreObject.SendToForm("Header Received: " + headerIndex + "bytes", "tbOutput");
                headerIndex = headerIndex + 1;
                if (headerIndex >= 22)
                {
                    if ((ToHex(headerBytes[0]) == constants.HEADER_MSB) && (ToHex(headerBytes[1]) == constants.HEADER_LSB))
                    {


                        GetProgressData(headerBytes);

                        digest = GetDigest(headerBytes);

                        METState.Current.METCoreObject.SendToForm("Total ProgressData:" + progressData_Total, "tbOutput");

                        progress = 1;
                    }
                    else
                    {
                        progress = -1;
                        METState.Current.METCoreObject.SendToForm("Did not receive correct header.  Closing socket", "tbOutput");

                        //Handle invalid header hear. 
                        // message = Encoding.ASCII.GetBytes(MessageType.INVALID_HEADER);
                        //mStream.Write(message, 0, message.Length);

                    }


                }


            }
            catch (IOException e)
            {
                progress = -1;

            }
            return progress;
        }

        private int getPicture()
        {
            int progress = 0;//0:progress 1:successfuly finished  -1:Failed

            try
            {
                //// Read the data from the stream in chunks
                byte[] buffer = new byte[constants.CHUNK_SIZE];
                //updateUI("Waiting for data.  Expecting " + progressData_Remaining + " more bytes.");
                int bytesRead = socketStream.Read(buffer, 0, buffer.Length);

                count++;
                int prg = 100 - (int)((progressData_Remaining / progressData_Total) * 100.0);

                METState.Current.METCoreObject.SendToForm("(" + prg + "%) : Read " + bytesRead + " bytes into buffer", "tbOutput");
                METState.Current.METCoreObject.SendToForm(prg, "progressbar");


                dataOutputStream.Write(buffer, 0, bytesRead);

                //dataOutputStream.WriteByte(buffer);


                progressData_Remaining -= bytesRead;

                if (progressData_Remaining <= 0)
                {
                    // check the integrity of the data
                    byte[] data = dataOutputStream.ToArray();

                    byte[] receivedDigest = GetMd5Hash(data);
                    socketStream.Write(receivedDigest, 0, receivedDigest.Length);
                    socketStream.Flush();

                    // check the integrity of the data
                    if (digestMatch(receivedDigest, digest))
                    {

                        METState.Current.METCoreObject.SendToForm("Picture received", "tbOutput");
                        METState.Current.METCoreObject.SendToForm(0, "progressbar");

                        bitmap = Image.FromStream(dataOutputStream);

                        FXPAL_Utils.SetupHyperImage(bitmap);

                        string folder = @"fromGlass\Images\";

                        if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);

                        String photoTime = DateTime.Now.ToString("hh.mm.ss");
                        String SuspiciousPath = Path.Combine(folder, photoTime + ".jpg");
                       // bitmap.Save(SuspiciousPath);


                        dataOutputStream.Flush();
                        dataOutputStream.Close();
                        progress = 1;


                    }
                    else
                    {

                        METState.Current.METCoreObject.SendToForm("Data NOT received completely!", "tbOutput");

                        progress = -1;
                    }


                }
            }
            catch (IOException e)
            {
                progress = -1;
            }
            return progress;
        }

        private int getJson()
        {
            int progress = 0;//0:progress 1:successfuly finished  -1:Failed

            try
            {
                //// Read the data from the stream in chunks
                byte[] buffer = new byte[constants.CHUNK_SIZE];
                //updateUI("Waiting for data.  Expecting " + progressData_Remaining + " more bytes.");
                int bytesRead = socketStream.Read(buffer, 0, buffer.Length);


                int prg = 100 - (int)((progressData_Remaining / progressData_Total) * 100.0);

                METState.Current.METCoreObject.SendToForm("(" + prg + "%) : Read " + bytesRead + " bytes into buffer", "tbOutput");
                METState.Current.METCoreObject.SendToForm(prg, "progressbar");

                progressData_Remaining -= bytesRead;

                if (progressData_Remaining >= 0) dataOutputStream.Write(buffer, 0, bytesRead);
                else dataOutputStream.Write(buffer, 0, (int)(bytesRead - Math.Abs(progressData_Remaining)));

                //dataOutputStream.WriteByte(buffer);



                if (progressData_Remaining <= 0)
                {
                    // check the integrity of the data
                    byte[] data = dataOutputStream.ToArray();

                    String jsonString = Encoding.UTF8.GetString(data);//didn't help     .TrimEnd('\0');                    

                    var json_serializer = new JavaScriptSerializer();

                    string folder = @"fromGlass\Jsons\";
                    if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);

                    {//MagicPointing
                      



                        //myJsonClass mjson = new myJsonClass();
                        //mjson = json_serializer.Deserialize<myJsonClass>(jsonString);
                        //myJsonClass_test temp = new myJsonClass_test(mjson);
                        //System.IO.StreamWriter file = new System.IO.StreamWriter(folder + temp.name + ".csv");
                        //file.Write(temp.text);

                        //file.Close();
                    }
                    {
                        Bitmap keptImage = new Bitmap(10, 10);
                        if (FXPAL_Utils.mHyperImage != null) keptImage = new Bitmap(FXPAL_Utils.mHyperImage.img);
                        FXPAL_Utils.mHyperImage = json_serializer.Deserialize<HyperImage>(jsonString);
                        if (FXPAL_Utils.mHyperImage.img == null) FXPAL_Utils.mHyperImage.img = keptImage;
                        String SuspiciousPath = Path.Combine(folder, FXPAL_Utils.mHyperImage.name + ".jpg");
                        FXPAL_Utils.mHyperImage.img.Save(SuspiciousPath);
                        HyperImage_without_image temp = new HyperImage_without_image(FXPAL_Utils.mHyperImage);
                        System.Web.Script.Serialization.JavaScriptSerializer jSearializer =
                        new System.Web.Script.Serialization.JavaScriptSerializer();
                        String s = jSearializer.Serialize(temp);
                        System.IO.File.WriteAllText(Path.Combine(folder, temp.name + ".txt"), s);
                        FXPAL_Utils.UpdateUI();
                    }
                    {//calib experiment

                        //myJsonClass mjson = new myJsonClass();
                        //mjson = json_serializer.Deserialize<myJsonClass>(jsonString);


                        //    // ProcessJson_test(mjson);
                        //    CalibExp.ProcessJson(mjson);
                    }


                    METState.Current.METCoreObject.SendToForm("Picture received", "tbOutput");
                    METState.Current.METCoreObject.SendToForm(0, "progressbar");




                    dataOutputStream.Flush();
                    dataOutputStream.Close();
                    progress = 1;



                }
            }
            catch (IOException e)
            {
                progress = -1;
            }
            return progress;
        }

        public void ProcessJson_test(myJsonClass mjson)
        {


            string folder = @"fromGlass\Jsons\";

            if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);


            if (mjson.img != null)
            {
                String SuspiciousPath = Path.Combine(folder, mjson.name + ".jpg");
                mjson.img.Save(SuspiciousPath);
            }
            myJsonClass_test temp = new myJsonClass_test(mjson);
           

            System.Web.Script.Serialization.JavaScriptSerializer jSearializer =
            new System.Web.Script.Serialization.JavaScriptSerializer();
            String s = jSearializer.Serialize(temp);
            System.IO.File.WriteAllText(Path.Combine(folder, temp.name + ".txt"), s);

            METState.Current.METCoreObject.SendToForm(mjson.img, "imScene");
            METState.Current.METCoreObject.SendToForm("", "Update Glass Picturebox");

        
        }
        public int GetIndicator(byte[] a)
        {
            byte[] ret = new byte[4];
            Array.Copy(a, 0, ret, 0, 4);
            return byteArrayToInt(ret);
        }
        public int GetX(byte[] a)
        {
            byte[] ret = new byte[4];
            Array.Copy(a, 4, ret, 0, 4);
            return byteArrayToInt(ret);
        }

        public int GetY(byte[] a)
        {
            byte[] ret = new byte[4];
            Array.Copy(a, 8, ret, 0, 4);
            return byteArrayToInt(ret);
        }
        public int GetIP(byte[] a)
        {
            byte[] ret = new byte[8];
            Array.Copy(a, 4, ret, 0, 8);
            return byteArrayToInt(ret);
        }

        public int byteArrayToInt(byte[] b)
        {
            if (BitConverter.IsLittleEndian) Array.Reverse(b);

            return BitConverter.ToInt32(b, 0);
        }
        public bool digestMatch(byte[] digestData2, byte[] digestData)
        {
            return Enumerable.SequenceEqual(digestData2, digestData);
        }
        public byte[] GetMd5Hash(byte[] input)
        {
            MD5 md5Hash = MD5.Create();
            // Convert the input string to a byte array and compute the hash.
            byte[] digest = md5Hash.ComputeHash(input);

            return digest;
        }
        private void GetProgressData(byte[] received)
        {
            var subset = new byte[6 - 2];
            Array.Copy(received, 2, subset, 0, 6 - 2);
            Array.Reverse(subset);
            progressData_Total = BitConverter.ToInt32(subset, 0);
            progressData_Remaining = BitConverter.ToInt32(subset, 0);
            Console.WriteLine(progressData_Total);
        }
        private byte[] GetDigest(byte[] received)
        {
            var subset = new byte[22 - 6];
            Array.Copy(received, 6, subset, 0, 22 - 6);
            //Array.Reverse(subset);
            return subset;


        }

        private static string ToHex(int value)
        {
            return String.Format("0x{0:X}", value);
        }

        private static int IDFromHex(string HexID)
        {
            return int.Parse(HexID, System.Globalization.NumberStyles.HexNumber);
        }

        

    }
}