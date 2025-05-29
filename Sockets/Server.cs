using System;
using System.Net;
using System.Net.Sockets;

namespace Sockets
{
    // Represents the server-side of a TCP connection
    // Inherits send/receive functionality from TCPConnection
    public class Server : TCPConnection
    {
        // TCP listener that waits for incoming client connections
        private TcpListener server;

        // The TCP client that connects to this server (only one client is accepted)
        private TcpClient client;

        // Background thread used to receive data from the client
        private Thread receiveThread;

        // Initializes the server with an IP address and port
        public Server(IPAddress ip, int port)
        {
            this.ip = ip;
            this.port = port;
        }

        // Main method that starts the server, accepts a client, and begins receiving data
        public void Start()
        {
            // Create a TCP listener bound to the specified IP and port
            this.server = new TcpListener(this.ip, this.port);

            // Start listening for incoming client connections
            this.server.Start();

            // Accept the first client that connects
            this.client = this.server.AcceptTcpClient();

            // Get the network stream to send/receive data
            this.stream = this.client.GetStream();

            // Create and start a background thread to listen for incoming messages
            // IsBackground ensures the thread will not block application while waiting for a message
            this.receiveThread = new Thread(this.ReceiveData);
            this.receiveThread.IsBackground = true;
            this.receiveThread.Start();
        }

        // Safely stops the server and close all connections
        private void Stop()
        {
            // To be implemented
        }

    }
}
