using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haytham.HoloLens
{
    public class Client
    {
        Socket socket;
        Server server;
        NetworkStream stream;

        BinaryWriter writer;
        BinaryReader reader;

        int screenWidth;
        int screenHeight;

        bool isTransferringEyeData;

        string logName;
        string fileName;
        string logPath;

        public Client(Socket socket, Server server)
        {
            this.socket = socket;
            this.server = server;
            this.stream = new NetworkStream(socket);

            this.reader = new BinaryReader(this.stream);
            this.writer = new BinaryWriter(this.stream);
        }

        public async Task Run()
        {
            try
            {
                this.screenWidth = await this.ReadInt();
                this.screenHeight = await this.ReadInt();

                int message = await this.ReadInt();

                while (true)
                {
                     switch (message)
                    {
                        case MessageType.StartCalibration:
                            this.StartCalibration(false);
                            break;

                        case MessageType.StartEyeDataTransfer:
                            this.StartEyeDataTransfer();
                            break;

                        case MessageType.StopEyeDataTransfer:
                            this.StopEyeDataTransfer();
                            break;

                        case MessageType.FinishedExperiment:
                            string fileName = await this.ReadString();
                            string log = await this.ReadString();

                            this.SaveLogFile(fileName, log);
                            break;

                        case MessageType.SendTrialData:
                            string data = await this.ReadString();

                            this.SaveTrialData(data);
                            break;

                        default:
                            break;
                    }

                    message = await this.ReadInt();
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null && ex.InnerException is SocketException)
                {
                    SocketException se = (SocketException)ex.InnerException;

                    switch (se.SocketErrorCode)
                    {
                        case SocketError.ConnectionReset:
                            Console.WriteLine("Connection was reset");
                            break;
                        default:
                            break;
                    }
                } else
                {
                    Console.WriteLine(ex);
                }
            }
        }

        internal void SaveCalibrationData(Point point)
        {
            StringBuilder sb = new StringBuilder();
            AForge.Point eyePos = CalculateEyePosition();

            sb.Append(DateTime.Now.ToString("HH:mm:ss.FFF"))
                .Append(",CalibrationData")
                .Append(",screenX=").Append(point.X)
                .Append(",screenY=").Append(point.Y)
                .Append(",eyeX=").Append(eyePos.X)
                .Append(",eyeY=").Append(eyePos.Y).AppendLine();

            using (StreamWriter file = new StreamWriter(logPath, true))
            {
                file.WriteLine(sb.ToString());
            }
        }

        public async void TriggerStartCalibration(double distance)
        {
            await this.Send(MessageType.StartCalibration);
            await this.Send(distance);
        }

        public async void StartExperiment()
        {
            await this.Send(MessageType.StartExperiment);
            await this.Send(logName); 
        }

        public async void AbortExperiment()
        {
            await this.Send(MessageType.AbortExperiment);
        }

        public void CreateLogFile(string logName)
        {
            this.logName = logName;
            this.fileName = logName + "_" + DateTime.Now.ToString("dd_MM_yyyy") + ".log";
            this.logPath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

            /*
            using (StreamWriter file = new StreamWriter(logPath))
            {

            }
            */
        }

        public void SaveTrialData(string data)
        {
            using (StreamWriter file = new StreamWriter(logPath, true))
            {
                file.WriteLine(data);
            }
        }

        public async void StopExperiment()
        {
            await this.Send(MessageType.StopExperiment);
        }

        public async void ToggleGaze(bool enabled)
        {
            await this.Send(MessageType.ToggleGaze);
            await this.Send(enabled ? 1 : 0);
        }

        public async void ToggleScreen(bool enabled)
        {
            await this.Send(MessageType.ToggleScreen);
            await this.Send(enabled ? 1 : 0);
        }

        public async void LoadExperiment(int distance, int alignment, int choices)
        {
            if (logName == null || logName.Equals(""))
            {
                MessageBox.Show("NO CURRENT PARTICIPANT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await this.Send(MessageType.LoadExperiment);
            await this.Send(distance);
            await this.Send(alignment);
            await this.Send(choices);
            await this.Send(logName);
        }

        public async void LoadSandbox(int distance, int alignment, int choices)
        {
            await this.Send(MessageType.LoadSandbox);
            await this.Send(distance);
            await this.Send(alignment);
            await this.Send(choices);
        }

        public void StartCalibration(bool initFromServer)
        {
            METState.Current.EyeToDisplay_Mapping.GazeErrorX = 0;
            METState.Current.EyeToDisplay_Mapping.GazeErrorY = 0;
            METState.Current.EyeToDisplay_Mapping.CalibrationTarget = 0;
            METState.Current.EyeToDisplay_Mapping.Calibrated = false;
            METState.Current.EyeToDisplay_Mapping.CalibrationType = Haytham.Calibration.calibration_type.calib_Polynomial;

            Rectangle rect = new Rectangle(0, 0, this.screenWidth, this.screenHeight);

            Calibration calibration = new Calibration(this, 3, 3, rect, Calibration.TaskType.CalibrateDisplay);
            METState.Current.RemoteCalibration = calibration;

            calibration.Start();
            
            // METState.Current.server.Send("Commands", new string[] { "CalibrationFinished" });
        }

        public AForge.Point CalculateEyePosition()
        {
            METState.Current.Gaze_RGT = METState.Current.EyeToDisplay_Mapping.Map(METState.Current.eyeFeature.X, METState.Current.eyeFeature.Y, METState.Current.EyeToDisplay_Mapping.GazeErrorX, METState.Current.EyeToDisplay_Mapping.GazeErrorY);
            METState.Current.Gaze_RGT = new AForge.Point((int)METState.Current.Gaze_RGT.X, (int)METState.Current.Gaze_RGT.Y);

            if (METState.Current.RemoteCalibration != null)
                METState.Current.Gaze_RGT = AForge.Point.Subtract(METState.Current.Gaze_RGT, new AForge.Point(METState.Current.RemoteCalibration.PresentationScreen.Left, METState.Current.RemoteCalibration.PresentationScreen.Top));

            return METState.Current.Gaze_RGT;
        }

        private void StartEyeDataTransfer()
        {
            isTransferringEyeData = true;

            Task.Run(async () =>
            {
                while (isTransferringEyeData)
                {
                    AForge.Point eyePos = CalculateEyePosition();
                    /*
                    if (METState.Current.Gaze_RGT.X >= 0 && METState.Current.Gaze_RGT.X <= screenWidth
                        && METState.Current.Gaze_RGT.Y >= 0 && METState.Current.Gaze_RGT.Y <= screenHeight)
                    {
                    }
                    */

                    await this.Send(MessageType.EyePositionData);
                    await this.Send((int)eyePos.X);
                    await this.Send((int)eyePos.Y);

                    await Task.Delay(10);
                }
            });
        }

        private void SaveLogFile(string fileName, string log)
        {
            File.WriteAllText(fileName, log);

            MessageBox.Show("Log file saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void StopEyeDataTransfer()
        {
            isTransferringEyeData = false;
        }

        private async Task<string> ReadString()
        {
            string s = await Task.Run<string>(() =>
            {
                return this.reader.ReadString();
            });

            return s;
        }

        private async Task<int> ReadInt()
        {
            int i = await Task.Run<int>(() =>
            {
                return this.reader.ReadInt32();
            });

            return i;
        }

        internal async Task Send(int message)
        {
            await Task.Run(() =>
            {
                this.writer.Write(message);
            });
        }

        internal async Task Send(double value)
        {
            await Task.Run(() =>
            {
                this.writer.Write(value);
            });
        }

        internal async Task Send(string message)
        {
            await Task.Run(() =>
            {
                this.writer.Write(message);
            });
        }
    }
}
