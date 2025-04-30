using System;
using SeegaLogic;
using Sockets;

namespace SeegaLogic.Network
{
    public class ServerHandler
    {
        private Game game;
        private Server server;

        public event Action<string> ChatReceived;
        public event Action BoardUpdated;

        public ServerHandler(Game game, Server server)
        {
            this.game = game;
            this.server = server;
        }

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
            this.server.SendMessage("CHAT:" + text);
        }

        public void SendMove(int row, int col)
        {
            this.server.SendMessage($"MOVE:{row},{col}");
        }
    }
}
