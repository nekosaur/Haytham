
//<copyright file="Server.cs" company="ITU">
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
    public class Server
    {
        public Dictionary<string, Client> clients = new Dictionary<string, Client>();
        public Dictionary<string, Thread> clientThreads = new Dictionary<string, Thread>();

        // private Client[] clients;
        // private Thread[] clientThreads; // Threads for client interaction
        private TcpListener listener; // listen for client connection
        private Thread getClientThread;
        internal bool disconnected = false; // true if the server closes
        public string activeScreen = "";
        public string ForcedActiveScreen = "";

        //delete

        public bool connected = false;


        // initialize variables and thread for receiving clients
        public Server()
        {

            // clients = new Client[2];
            //clientThreads = new Thread[2];

            // accept connections on a different thread
            getClientThread = new Thread(new ThreadStart(getClient));
            getClientThread.Start();
        }//end Server

        public void DisplayMessage(string message)
        {
            try
            {
                METState.Current.METCoreObject.SendToForm(message, "TextBoxServer");
            }
            catch (Exception e) { }

        } //end displayMessage

        private void getClient()
        {
            string ip = getip();
            METState.Current.METCoreObject.SendToForm("Server IP : " + ip, "lblIP");

            DisplayMessage("Server IP : " + ip + "\r\n");
            DisplayMessage("Waiting for connection\r\n");

            // set up Socket
            IPAddress localip = IPAddress.Parse(getip());//"192.168.50.176"

            listener = new TcpListener(localip, 50000);
            listener.Start();
            DisplayMessage("Waiting....\r\n");

            while (!disconnected)
            {

                Client tempClient;

                tempClient = new Client(listener.AcceptSocket(), this);
                if (tempClient.ClientName != "")
                {

                    //make a known client
                    if (clients.ContainsKey(tempClient.ClientName)) { clients[tempClient.ClientName] = tempClient; }
                    else { clients.Add(tempClient.ClientName, tempClient); }

                    //make a thread for this client
                    if (clientThreads.ContainsKey(tempClient.ClientName))
                    {
                        //stop prevous thread!!how?!!
                        //
                        clientThreads[tempClient.ClientName] = new Thread(new ThreadStart(clients[tempClient.ClientName].Run));
                    }
                    else { clientThreads.Add(tempClient.ClientName, new Thread(new ThreadStart(clients[tempClient.ClientName].Run))); }
                    clientThreads[tempClient.ClientName].Start();
                    //DisplayMessage("one client connected \r\n");
                    DisplayMessage(tempClient.ClientName + "    ");
                    DisplayMessage(tempClient.Width + "x" + tempClient.Height + "\r\n");
                    METState.Current.METCoreObject.SendToForm(tempClient.ClientName, "PanelClients_Add");
                }
            }

        }//end getClient

        public string DetermineClientName(string msg, string type)
        {
            string name = "";


            if (msg.StartsWith("?"))
            {
                for (int i = 1; i < 10; i++)
                {
                    if (clients.ContainsKey(type + i) == true)
                    {

                    }
                    else
                    {
                        name = type + i;
                        break;
                    }
                }
            }
            else
            {
                name = msg;
            }




            return name;
        }

        public string getip()
        {
            string localIP = "?";

            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();

                }
            }



            return localIP;

        }//end getip

        public void RemoveClient(string name)
        {
            if (clients.ContainsKey(name))
            {

                METState.Current.METCoreObject.SendToForm(name, "PanelClients_Remove");

                clients[name] = null;
                clients.Remove(name);
                //clientThreads[name].Suspend();
                clientThreads.Remove(name);
                Thread.CurrentThread.Abort();
            }
        }//end RemoveClient
        public bool GetCondition(string clientName, string condition)
        {
            bool temp = false;
            //try
            //{
            condition = "_" + condition;
            if (clients.ContainsKey(clientName) )
            {
                temp = clients[clientName].status.ContainsKey( condition) ? clients[clientName].status[condition] : false;
            }
            //}
            //catch (Exception e)
            //{ }
            return temp;
        }
        public void SendToClient(string message, string NameType, bool forceSend, bool condition)
        {//  
            // 
            //      activeScreen = "Monitor1";//MOVAGHAT
            ///
            //

            //
            try
            {
                if (clients.Count() > 0 & condition == true)
                {

                    if (!forceSend)
                    {
                        switch (NameType)
                        {

                            case "AllMonitors":
                                foreach (KeyValuePair<string, Client> kvp in METState.Current.server.clients)
                                {
                                    if (kvp.Value.ClientType == "Monitor") clients[kvp.Value.ClientName].writer.Write(message); ;
                                }
                                break;
                            case "Monitor":

                                if (clients.ContainsKey(activeScreen) == true & clients[activeScreen].ClientType == "Monitor")
                                {
                                    clients[activeScreen].writer.Write(message);

                                }
                                break;
                            case "TV":
                                if (message.StartsWith("Volume"))
                                {
                                    // DisplayMessage(message);
                                }
                                if (clients.ContainsKey(activeScreen) == true & clients[activeScreen].ClientType == "TV")
                                {
                                    clients[activeScreen].writer.Write(message);

                                }
                                break;
                          
                        }
                    }
                    else
                    {
                        clients[NameType].writer.Write((string)message); //+ "\r\n"
                    }
                }

            }
            catch (Exception e)
            { }
        }







        public void MonitorCursor(string go)
        {
            // send the text to the client
            //try
            //{

            //    writer.Write("SERVER>>> " + go);

            //    // if the user at the server signaled termination
            //    // sever the connection to the client
            //    if (go == "TERMINATE")
            //        connection.Close();


            //} // end try
            //catch (SocketException)
            //{
            //    DisplayMessage("\nError writing object");
            //} // end catch
        }
        public void Close()
        {
            try
            {
                getClientThread.Abort();
                System.Environment.Exit(System.Environment.ExitCode);
            }
            catch (Exception ee)
            { }
        }
        public int CountRectangleClients()
        {
            int i = 0;
            foreach (KeyValuePair<string, Client> kvp in clients)
            {
                if (kvp.Value.ClientType == "Monitor" | kvp.Value.ClientType == "TV") i++;
            }
            return i;
        }
        public int CountTVClients()
        {
            int i = 0;
            foreach (KeyValuePair<string, Client> kvp in clients)
            {
                if (kvp.Value.ClientType == "TV") i++;
            }
            return i;
        }
        public int CountMonitorClients()
        {
            int i = 0;
            foreach (KeyValuePair<string, Client> kvp in clients)
            {
                if (kvp.Value.ClientType == "Monitor") i++;
            }
            return i;
        }


    }
}
