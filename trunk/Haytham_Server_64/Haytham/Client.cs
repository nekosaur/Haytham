
//<copyright file="Client.cs" company="ITU">
//This file is part of Haytham 
//Copyright (C) 2012 Diako Mardanbegi
// ------------------------------------------------------------------------
//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with this program.  If not, see <http://www.gnu.org/licenses/>.
// ------------------------------------------------------------------------
// </copyright>
// <author>Diako Mardanbegi</author>
// <email>dima@itu.dk</email>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Haytham
{
    public class Client
    {
        internal Socket connection; // Socket for accepting a connection
        private NetworkStream socketStream; // network data stream
        public BinaryWriter writer; // facilitates writing to the stream
        private BinaryReader reader; // facilitates reading from the stream
        public string ClientType;
        public string ClientName;

        public Dictionary<string, Boolean> status = new Dictionary<string, Boolean>()
	{

	    {"_Commands", false},
	    {"_Gaze", false},
        {"_Volume", false},
        {"_VisualMarker", false},
	};


        private Server server; // reference to server
        public int Width;
        public int Height;
        public  Dictionary<string, string> userData = new Dictionary<string, string>();

        public Client(Socket socket, Server serverValue)
        {
            connection = socket;
            // create NetworkStream object for Socket
            socketStream = new NetworkStream(connection);
            // create Streams for reading/writing bytes
            writer = new BinaryWriter(socketStream);
            reader = new BinaryReader(socketStream);
            server = serverValue;


            try
            {
               
                ClientType = reader.ReadString();
                ClientName = reader.ReadString();

                ClientName = server.DetermineClientName(ClientName, ClientType);
            }
            catch (Exception)
            {
                ClientName = "";
            }

            if (ClientName == "")
            {
                writer.Write("ERROR");
            }
        } // end constructor

        private void getUserData(string msg)
        {

           
            string temp = "";
            List<string> msgArr = new List<string>();

            for (int i = 0; i < msg.Length; i++)
            {
                if (msg[i] == '|')
                {
                    msgArr.Add(temp);
                    temp = "";
                }
                else
                {
                    temp += msg[i];

                }

            }
            msgArr.RemoveAt(0);//remove the keyword from the begining

            if (userData.ContainsKey(msgArr[0])) userData[msgArr[0]] = msgArr[1];
            else userData.Add( msgArr[0], msgArr[1]);
      

        }
        public void Run()
        {

            writer.Write(ClientName);



            string theReply = "";
            do
            {
                try
                {
                    // read the string sent to the server
                    //wait for message

                    theReply = reader.ReadString();


                    if (theReply == "Status_Commands") status["_Commands"] = Convert.ToBoolean(reader.ReadString());
                    if (theReply == "Status_Gaze") status["_Gaze"] = Convert.ToBoolean(reader.ReadString());
                    if (theReply == "Status_Volume") status["_Volume"] = Convert.ToBoolean(reader.ReadString());
                    if (theReply == "Status_VisualMarker") status["_VisualMarker"] = Convert.ToBoolean(reader.ReadString());
                    if (theReply.StartsWith("UserData")) getUserData(theReply);


                    if (theReply == "Size")
                    {
                        Width = reader.ReadInt32();
                        Height = reader.ReadInt32();
                        server.DisplayMessage("\r\n resolusion of " + ClientName + ": " + Width + "x" + Height + "\r\n");
                    }




                } // end try
                catch (Exception)
                {
                    // handle exception if error reading data
                    break;
                } // end catch
            } while (theReply != "CLIENT>>> TERMINATE" && connection.Connected);

            // close the socket connection
            writer.Close();
            reader.Close();
            socketStream.Close();
            connection.Close();
            server.DisplayMessage("\r\n" + ClientName + " disconnected \r\n");
            server.RemoveClient(ClientName);

        } // end method Run
    }
}
