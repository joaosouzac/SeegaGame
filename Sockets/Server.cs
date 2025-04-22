using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Sockets
{
    public class TCPServer(IPAddress ip, int port)
    {
        public IPAddress ip = ip;
        public int port = port;

        public TcpListener listener = new TcpListener(ip, port);

        public TcpClient client;

        public NetworkStream stream;

        // Inicia o servidor TCP
        public void StartConnection()
        {
            // Inicia o server TCP
            listener.Start();

            Console.WriteLine($"Servidor escutando na porta {port}...");

            // Aguarde e aceita uma conexão de um cliente TCP
            Console.WriteLine("Aguardando conexão com cliente...");

            client = listener.AcceptTcpClient();
            Console.WriteLine("Cliente conectado com sucesso!");

            // Estabelece um stream de dados para recebimento / envio
            stream = client.GetStream();

            Console.WriteLine("Stream instanciado com sucesso!");

            Console.WriteLine();
        }

        public void StopConnection()
        {
            // Encerra o stream de dados 
            stream.Close();
            Console.WriteLine("Stream encerrado com sucesso!");

            // Encerra a conexão TCP com cliente
            client.Close();
            Console.WriteLine("Cliente desconectado com sucesso!");

            // Para o servidor TCP
            listener.Stop();
            Console.WriteLine("Servidor desligado com sucesso!");

            Console.WriteLine();
        }
        
        
    }
}
