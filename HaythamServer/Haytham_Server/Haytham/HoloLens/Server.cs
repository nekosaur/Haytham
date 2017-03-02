using Haytham.Forms;
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
            METState.Current.METCoreObject.SendToForm("Server IP : " + ip + "\r\n", "tbHoloLensServer");

            IPAddress localIP = IPAddress.Parse(ip);
            TcpListener tcpListener = new TcpListener(localIP, serverPort);
            tcpListener.Start();

            METState.Current.METCoreObject.SendToForm("Running server...", "tbHoloLensServer");
            METState.Current.METCoreObject.SendToForm("Waiting....\r\n", "tbHoloLensServer");

            Socket socket = await tcpListener.AcceptSocketAsync();

            if (socket == null)
            {
                throw new Exception("Problem connecting to device!");
            }

            holoLensClient = new Client(socket, this);

            clientThread = new Thread(new ThreadStart(holoLensClient.Run));
            clientThread.Start();

            METState.Current.METCoreObject.SendToForm("HoloLens connected", "tbHoloLensServer");
        }

        public string GetIP()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            string[] ips = host.AddressList.Select(address => address.ToString()).ToArray();
            string ip = DropdownPrompt.ShowDialog<string>("Select IP to bind server to", ips);

            return ip;
        }
    }
}
