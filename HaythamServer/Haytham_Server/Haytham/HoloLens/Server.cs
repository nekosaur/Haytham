using Haytham.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        public Client Client;
        MainForm mainForm;
        TcpListener tcpListener;

        int serverPort = 60000;

        public Server(MainForm m)
        {
            this.mainForm = m;
        }

        public async Task Start()
        {
            Thread.Sleep(1000);
            string ip = GetIP();
            METState.Current.METCoreObject.SendToForm("Server IP : " + ip + "\r\n", "tbHoloLensServer");

            IPAddress localIP = IPAddress.Parse(ip);
            tcpListener = new TcpListener(localIP, serverPort);
            tcpListener.Start();

            METState.Current.METCoreObject.SendToForm("Waiting....\r\n", "tbHoloLensServer");

            await Task.Run(async () =>
            {
                while (true)
                {
                    await this.LookForClient();
                }
            });
        }

        /// <summary>
        /// Listens on TCP socket for incoming client. Creates and runs a new Client class when a connection is made.
        /// </summary>
        /// <returns></returns>
        public async Task LookForClient()
        {
            Socket socket = await tcpListener.AcceptSocketAsync();

            if (Client != null)
            {
                METState.Current.METCoreObject.SendToForm("HoloLens already connected, discarding connection attempt", "tbHoloLensServer");
                return;
            }

            if (socket == null)
            {
                throw new Exception("Problem connecting to device!");
            }

            Client = new Client(socket, this);

            Task.Run(async () =>
            {
                await Client.Run();

                this.Client = null;
                METState.Current.METCoreObject.SendToForm("HoloLens disconnected", "tbHoloLensServer");
                METState.Current.METCoreObject.SendToForm(false, "gbHoloLensExperiment");
                METState.Current.METCoreObject.SendToForm("NO CURRENT PARTICIPANT", "lblHoloLensCurrentParticipant");
                METState.Current.METCoreObject.SendToForm(Color.Transparent, "btnHoloLensShowGaze");
                METState.Current.METCoreObject.SendToForm(Color.Transparent, "btnHoloLensExperimentShowScreen");
            });

            METState.Current.METCoreObject.SendToForm(true, "gbHoloLensExperiment");

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
