using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Sockets
{
    public class Server : TCPConnection
    {
        private TcpListener server;
        private TcpClient client;

        private Thread receiveThread;

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

    }
}
