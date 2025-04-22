using System.Net;
using System.Net.Sockets;

namespace Sockets
{
    public class TCPClient()
    {
        public TcpClient connection = new TcpClient();

        public NetworkStream stream;

        public void RequestConnection(IPAddress ip, int port)
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
