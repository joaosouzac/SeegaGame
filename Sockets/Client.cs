using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Sockets
{
    // Represents the client-side of a TCP connection
    // Inherits send/receive functionality from TCPConnection
    public class Client : TCPConnection
    {
        // The TCP client that will be used to connect to the server
        private TcpClient client;

        // Background thread used to receive data from the server
        private Thread receiveThread;

        // Initializes the client with an IP address and port
        public Client(IPAddress ip, int port)
        {
            this.ip = ip;
            this.port = port;
        }

        // Main method that connect to a server, and begins receiving data
        public void Connect()
        {
            // Create a TCP Client to connect to the server
            this.client = new TcpClient();

            // Connect to the host with matching IP and port
            this.client.Connect(this.ip, this.port);

            // Get the network stream to send/receive data
            this.stream = this.client.GetStream();

            // Create and start a background thread to listen for incoming messages
            // IsBackground ensures the thread will not block application while waiting for a message
            this.receiveThread = new Thread(this.ReceiveData);
            this.receiveThread.IsBackground = true;
            this.receiveThread.Start();
        }

        // Safely disconnect from server
        private void Disconnect()
        {
            // To be implemented
        }
    }
}
