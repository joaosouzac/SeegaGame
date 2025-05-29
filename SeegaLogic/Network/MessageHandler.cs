using System;
using System.Text;
using System.Text.Json;
using Sockets;

namespace SeegaLogic.Network
{
    // Handles incoming and outgoing messages between the client/server and the Game
    public class MessageHandler
    {
        // Indicates whether this handler is running on the server side
        // Default is running on the client side
        public bool isServer = false;

        // Reference to the Game's logic
        private Game game;

        // Optional references to either the server or the client connection
        // One must be non-null for the application to run
        private Server? server;
        private Client? client;

        // Event raised when a chat message is received
        public event Action<string, string> ChatReceived;

        // Event raised when the opponent wins the game
        public event Action<string> OpponentWon;

        // Event raised when the opponent forfeits the game
        public event Action<string> OpponentForfeit;

        // Event raised when the game board should be redrawn
        public event Action BoardUpdated;

        // Used for the server role
        public MessageHandler(Game game, Server server)
        {
            this.game = game;
            this.server = server;

            this.isServer = true;
        }

        // Used for the client role
        public MessageHandler(Game game, Client client)
        {
            this.game = game;
            this.client = client;

            this.isServer = false;
        }

        // Handles any incoming JSON message and executes the appropriate game action or event
        public void HandleMessage(string json)
        {
            // Deserialize the JSON string into a MessageType object
            MessageType? message = JsonSerializer.Deserialize<MessageType>(json);

            if (message.Type == "chat")
            {
                // Trigger the chat message event
                ChatReceived?.Invoke(message.Sender, message.Chat);
            }
            else if (message.Type == "move")
            {
                // Handle a move depending on the current game phase
                if (this.game.Phase == GamePhase.Placement)
                {
                    this.game.PlacePiece(message.Row, message.Col);
                    
                }
                else
                {
                    // First try to select a piece; if it fails, try to move
                    if (!this.game.SelectPiece(message.Row, message.Col))
                    {
                        this.game.MoveSelectedPiece(message.Row, message.Col);
                    }
                }

                // Notify the UI to update the board
                this.BoardUpdated?.Invoke();
            }
            else if (message.Type == "victory")
            {
                // Informs the game has ended
                this.game.isFinished = true;

                // Trigger the opponent's victory event
                OpponentWon?.Invoke(message.Sender);
            }
            else if (message.Type == "forfeit")
            {
                // Informs the game has ended
                this.game.isFinished = true;

                // Trigger the opponent's forfeit event
                OpponentForfeit?.Invoke(message.Sender);
            }
        }

        // Sends a chat message to the other player
        public void SendChat(string sender, string text)
        {
            MessageType message = new MessageType
            {
                Type = "chat",
                Sender = sender,
                Chat = text
            };

            // Use the correct communication channel depending on the role
            if (this.isServer)
            { this.server.SendMessage(message); }
            else if (!this.isServer)
            { this.client.SendMessage(message); }
        }

        // Sends a board move to the other player
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

        // Sends a victory notification to the opponent
        public void SendVictory(string sender)
        {
            MessageType message = new MessageType
            {
                Type = "victory",
                Sender = sender
            };

            if (this.isServer)
            { this.server.SendMessage(message); }
            else if (!this.isServer)
            { this.client.SendMessage(message); }
        }

        // Sends a forfeit notification to the opponent
        public void SendForfeit(string sender)
        {
            MessageType message = new MessageType
            {
                Type = "forfeit",
                Sender = sender
            };

            if (this.isServer)
            { this.server.SendMessage(message); }
            else if (!this.isServer)
            { this.client.SendMessage(message); }
        }

    }

}
