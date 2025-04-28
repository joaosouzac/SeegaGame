using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Sockets
{
    public class Server
    {
        private IPAddress ip;
        private int port;

        private TcpListener server;
        private TcpClient client;
        private NetworkStream stream;

        private Thread receiveThread;

        public event Action<string> MessageReceived;

        public Server(IPAddress ip, int port)
        {
            this.ip = ip;
            this.port = port;
        }

        public void Start()
        {
            this.server = new TcpListener(this.ip, this.port);
            this.server.Start();

            this.client = this.server.AcceptTcpClient();

            this.stream = this.client.GetStream();

            this.receiveThread = new Thread(this.ReceiveData);

            this.receiveThread.IsBackground = true;
            this.receiveThread.Start();
        }

        public void SendMessage(string message)
        {
            if (this.stream != null && this.stream.CanWrite)
            {
                byte[] data = Encoding.UTF8.GetBytes(message);

                this.stream.Write(data, 0, data.Length);
            }
        }

        private void ReceiveData()
        {
            byte[] buffer = new byte[1024];
            try
            {
                while (true)
                {
                    int bytesRead = this.stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead > 0)
                    {
                        string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                        this.MessageReceived?.Invoke(message);
                    }
                }
            }
            catch (Exception)
            {
                // conexão encerrada
            }
        }
    }
}
