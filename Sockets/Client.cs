using System.Net;
using System.Net.Sockets;

namespace Sockets
{
    public class TCPClient(IPAddress ip, int port)
    {
        public IPAddress ip = ip;
        public int port = port;

        public TcpClient connection = new TcpClient();

        public NetworkStream stream;

        public void RequestConnection()
        {
            Console.WriteLine("Solicitação de conexão enviada. Aguardando resposta do servidor...");
            connection.Connect(ip, port);

            Console.WriteLine("Conexão TCP estabelecida com sucesso!");

            stream = connection.GetStream();
            Console.WriteLine("Stream de dados instaciado com sucesso!");

        }

        public void CloseConnection()
        {
            stream.Close();

            connection.Close();

            Console.WriteLine("Conexão encerrada com sucesso!");

            Console.WriteLine();
        }
    }
}
