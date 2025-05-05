using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Sockets
{
    public abstract class TCPConnection
    {
        protected IPAddress ip;
        protected int port;

        protected NetworkStream stream;

        public event Action<string> MessageReceived;

        public void SendMessage(MessageType message)
        {
            string json = JsonSerializer.Serialize(message) + "\n";

            if (this.stream != null && this.stream.CanWrite)
            {
                byte[] data = Encoding.UTF8.GetBytes(json);

                this.stream.Write(data, 0, data.Length);
            }
        }

        protected void ReceiveData()
        {
            byte[] buffer = new byte[4096];
            StringBuilder sb = new StringBuilder();

            try
            {
                while (true)
                {
                    int bytesRead = this.stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead > 0)
                    {
                        string part = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        sb.Append(part);

                        string all = sb.ToString();
                        string[] messages = all.Split('\n');

                        sb.Clear();
                        if (!all.EndsWith("\n"))
                            sb.Append(messages[^1]);

                        for (int i = 0; i < messages.Length - 1; i++)
                        {
                            string json = messages[i].Trim();
                            if (!string.IsNullOrEmpty(json))
                                this.MessageReceived?.Invoke(json);
                        }
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
