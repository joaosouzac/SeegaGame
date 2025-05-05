using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Sockets;
using static System.Net.Mime.MediaTypeNames;

namespace SeegaLogic.Network
{
    public class MessageHandler
    {
        public bool isServer = false;

        private Game game;

        private Server? server;
        private Client? client;

        public event Action<string> ChatReceived;
        public event Action BoardUpdated;

        public MessageHandler(Game game, Server server)
        {
            this.game = game;
            this.server = server;

            this.isServer = true;
        }

        public MessageHandler(Game game, Client client)
        {
            this.game = game;
            this.client = client;

            this.isServer = false;
        }
        
        /*
        public void HandleMessage(string message)
        {
            if (message.StartsWith("CHAT:"))
            {
                string chatText = message.Substring(5);
                ChatReceived?.Invoke(chatText);
            }
            else if (message.StartsWith("MOVE:"))
            {
                string[] parts = message.Substring(5).Split(',');
                int row = int.Parse(parts[0]);
                int col = int.Parse(parts[1]);

                if (game.Phase == GamePhase.Placement)
                {
                    game.PlacePiece(row, col);
                }
                else
                {
                    if (!game.SelectPiece(row, col))
                        game.MoveSelectedPiece(row, col);
                }

                BoardUpdated?.Invoke();
            }
        }

        public void SendChat(string text)
        {
            if (this.isServer)
            {
                this.server.SendMessage("CHAT:" + text);
            }
            else if (!this.isServer)
            {
                this.client.SendMessage("CHAT:" + text);
            }
                
        }

        public void SendMove(int row, int col)
        {
            if (this.isServer)
            {
                this.server.SendMessage($"MOVE:{row},{col}");
            }
            else if (!this.isServer)
            {
                this.client.SendMessage($"MOVE:{row},{col}");
            }
        }
        */

        
        public void HandleMessage(string json)
        {
            MessageType? message = JsonSerializer.Deserialize<MessageType>(json);

            if (message.Type == "chat")
            {
                ChatReceived?.Invoke(message.Chat);
            }
            else if (message.Type == "move")
            {
                if (this.game.Phase == GamePhase.Placement)
                {
                    this.game.PlacePiece(message.Row, message.Col);
                    
                }
                else
                {
                    if (!this.game.SelectPiece(message.Row, message.Col))
                    {
                        this.game.MoveSelectedPiece(message.Row, message.Col);
                    }
                }

                this.BoardUpdated?.Invoke();
            }
        }

        public void SendChat(string text)
        {
            MessageType message = new MessageType
            {
                Type = "chat",
                Chat = text
            };

            if (this.isServer)
            { this.server.SendMessage(message); }
            else if (!this.isServer)
            { this.client.SendMessage(message); }
        }

        public void SendMove(int row, int col)
        {
            MessageType message = new MessageType
            {
                Type = "move",
                Row = row,
                Col = col
            };

            if (this.isServer)
            { this.server.SendMessage(message); }
            else if (!this.isServer)
            { this.client.SendMessage(message); }
        }

    }

}
