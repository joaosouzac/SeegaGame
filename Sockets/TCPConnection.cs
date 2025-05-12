using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Text.Json;

namespace Sockets
{
    // Abstract base class for a TCP connection used by both clients and servers
    // Provides basic methods for sending and receiving JSON-formatted messages over a network stream
    public abstract class TCPConnection
    {
        // IP address and port used for the TCP connection
        protected IPAddress ip;
        protected int port;

        // The stream used to read from or write to the TCP connection
        protected NetworkStream stream;

        // Event triggered whenever a JSON message is received from the stream
        public event Action<string> MessageReceived;

        // Sends a JSON-encoded message to the connected peer
        public void SendMessage(MessageType message)
        {
            // Serialize the message to JSON and append a newline as a message delimiter
            string json = JsonSerializer.Serialize(message) + "\n";

            // Checks if the stream is open and writable
            if (this.stream != null && this.stream.CanWrite)
            {
                // Convert the JSON string to a byte array
                byte[] data = Encoding.UTF8.GetBytes(json);

                // Write the bytes to the network stream
                this.stream.Write(data, 0, data.Length);
            }
        }

        // Reads incoming data from the network stream and triggers the MessageReceived event
        // for each complete JSON message (split by newline '\n')
        protected void ReceiveData()
        {
            byte[] buffer = new byte[4096];             // Buffer to temporarily store incoming bytes
            StringBuilder sb = new StringBuilder();     // Accumulates partial messages between reads

            try
            {
                while (true)
                {
                    // Read data from the stream
                    int bytesRead = this.stream.Read(buffer, 0, buffer.Length);

                    if (bytesRead > 0)
                    {
                        // Convert received bytes into a UTF-8 string
                        string part = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                        // Append the new part to the string builder
                        sb.Append(part);

                        // Get the full string and split it into individual messages using newline
                        string all = sb.ToString();
                        string[] messages = all.Split('\n');

                        // Clear the builder and preserve the last partial message (if any)
                        sb.Clear();
                        if (!all.EndsWith("\n"))
                            sb.Append(messages[^1]);    // Keep the incomplete message fragment

                        // Loop through all complete messages and trigger the event
                        for (int i = 0; i < messages.Length - 1; i++)
                        {
                            string json = messages[i].Trim();

                            if (!string.IsNullOrEmpty(json))
                                this.MessageReceived?.Invoke(json); // Trigger the event with the received JSON string
                        }
                    }
                }
            }
            catch (Exception)
            {
                // The connection was closed or an error occurred.
            }
        }
    }
}
