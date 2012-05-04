using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Haytham_Client
{

    public static class ClientStatus
    {
        public static Thread inputoutputThread; // Thread for receiving data from server
        public static IPAddress serverip;

        public static TcpClient client = new TcpClient();  // client to establish connection
        public static BinaryWriter writer; // facilitates writing to the stream
        public static BinaryReader reader; // facilitates reading from the strea  
        public static NetworkStream stream; // network data stream

        public static string clientName;
        public static int clientIndex;

        public static int ScreenWidth;
        public static int ScreenHeight;

        private static Dictionary<string, Boolean> status = new Dictionary<string, Boolean>()
	{

	    {"_Blink", false},
	    {"_Commands", false},
	    {"_Gaze", false},

	};



  
        public static bool Commands { get { return status["_Commands"]; } set { status["_Commands"] = value; UpdateServer(); } }
        public static bool Blink { get { return status["_Blink"]; } set { status["_Blink"] = value; UpdateServer(); } }
        public static bool Gaze { get { return status["_Gaze"]; } set { status["_Gaze"] = value; UpdateServer(); } }

        public static void UpdateServer()
        {
            //?? nemidoonam shayad vasate yeki azina ke server mob=ntazere badie yejaye dige az barname chize digeii befreste
            if (client.Connected)
            {

                writer.Write("Status_Commands"); writer.Write(status["_Commands"].ToString());
                writer.Write("Status_Blink"); writer.Write(status["_Blink"].ToString());
                writer.Write("Status_Gaze"); writer.Write(status["_Gaze"].ToString());

            }
        }
        public static void Reconnect(string type)
        {
            bool connected = false;

            do
            {
                try
                {
                    client = new TcpClient();

                    client.Connect(serverip, 50000);
                    stream = client.GetStream();
                    writer = new BinaryWriter(stream);
                    reader = new BinaryReader(stream);

                    //send name and type
                    writer.Write(type);//type
                    writer.Write(clientName);//name
                    writer.Write(ScreenWidth);//screen W
                    writer.Write(ScreenHeight);//screen H




                    clientName = reader.ReadString();//get approved name

                    UpdateServer();
                    connected = true;

                } // end try
                catch (Exception)
                {

                }
            } while ((!connected & clientName != "PauseReconnect"));
            if (clientName == "PauseReconnect")
            {
                client.Close();

                inputoutputThread.Abort();
            }

        }
        public static void Connect(string type)
        {

            stream = client.GetStream();
            writer = new BinaryWriter(stream);
            reader = new BinaryReader(stream);


            //send name and type
            writer.Write(type);//type
            writer.Write("?");//name
            writer.Write(ScreenWidth);//screen W
            writer.Write(ScreenHeight);//screen H
            clientName = reader.ReadString();//get approved name
            clientIndex = int.Parse(clientName.Remove(0, type.Length));//"remove Monitor"

        }


    }

}
