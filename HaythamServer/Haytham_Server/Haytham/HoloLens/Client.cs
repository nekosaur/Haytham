using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Haytham.HoloLens
{
    class Client
    {
        Socket socket;
        Server server;
        NetworkStream stream;

        BinaryWriter writer;
        BinaryReader reader;

        int screenWidth;
        int screenHeight;

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
                            this.StartCalibration();
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

        private void StartCalibration()
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

        internal async Task Send(string message)
        {
            await Task.Run(() =>
            {
                this.writer.Write(message);
            });
        }
    }
}
