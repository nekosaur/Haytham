using System;
using System.Collections.Generic;
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

        string clientName;
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

        public async void Run()
        {
            try
            {
                await this.ReadString();
                this.screenWidth = await this.ReadInt();
                this.screenHeight = await this.ReadInt();
            }
            catch (Exception ex)
            {
                throw;
            }

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

        private async void Send(int message)
        {
            await Task.Run(() =>
            {
                this.writer.Write(message);
            });
        }
    }
}
