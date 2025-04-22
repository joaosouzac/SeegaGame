using System.Net;
using Sockets;

namespace ServerSide
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TCPServer server = new TCPServer(
                IPAddress.Parse(args[0]),
                int.Parse(args[1])
                );

            server.StartConnection();
            server.StopConnection();
        }
    }
}
