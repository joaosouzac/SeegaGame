using System.Net;
using Sockets;

namespace ClientSide
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TCPClient client = new TCPClient();

            client.RequestConnection(
                IPAddress.Parse(args[0]),
                int.Parse(args[1])
                );

            client.CloseConnection();


        }
    }
}
