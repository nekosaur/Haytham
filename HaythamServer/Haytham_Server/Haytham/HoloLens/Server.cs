using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Haytham.HoloLens
{
    public class Server
    {
        Client holoLensClient;
        Thread clientThread;
        MainForm mainForm;

        int serverPort = 60000;

        public Server(MainForm m)
        {
            this.mainForm = m;

            this.LookForClient();
        }

        public async void LookForClient()
        {
            Thread.Sleep(1000);
            string ip = GetIP();
            METState.Current.METCoreObject.SendToForm("Server IP : " + ip + "\r\n", "tbOutput");

            IPAddress localIP = IPAddress.Parse(ip);
            TcpListener tcpListener = new TcpListener(localIP, serverPort);
            tcpListener.Start();

            METState.Current.METCoreObject.SendToForm("Running server...", "tbOutput");
            METState.Current.METCoreObject.SendToForm("Waiting....\r\n", "tbOutput");

            Socket socket = await tcpListener.AcceptSocketAsync();

            if (socket == null)
            {
                throw new Exception("Problem connecting to device!");
            }

            holoLensClient = new Client(socket, this);

            clientThread = new Thread(new ThreadStart(holoLensClient.Run));
            clientThread.Start();

            METState.Current.METCoreObject.SendToForm("HoloLens connected", "tbOutput");
            METState.Current.METCoreObject.SendToForm("Hide", "IPform");
        }

        public string GetIP()
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
        }
    }
}
