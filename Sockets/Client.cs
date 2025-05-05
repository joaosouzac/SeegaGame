using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Sockets
{
    public class Client : TCPConnection
    {
        private TcpClient client;

        private Thread receiveThread;

        public Client(IPAddress ip, int port)
        {
            this.ip = ip;
            this.port = port;
        }

        public void Connect()
        {
            this.client = new TcpClient();
            this.client.Connect(this.ip, this.port);
            this.stream = this.client.GetStream();

            this.receiveThread = new Thread(this.ReceiveData);
            this.receiveThread.IsBackground = true;
            this.receiveThread.Start();
        }
    }
}
