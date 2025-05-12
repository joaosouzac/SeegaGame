using System;

namespace Sockets
{
    // Represents a structured message sent over the TCP connection
    // This class supports different types of messages such as chat and game actions
    public class MessageType
    {
        /*
            Defines the type of the message:
            "chat", for chat messages;
            "move", for selecting or moving game pieces
            "victory", for announcing a player's victory
            "forfeit", for announcing a player's forfeit
        */
        public string Type { get; set; }

        // Identifies the player who send the message
        public string Sender { get; set; }

        // Holds the actual chat text (used for "chat" messages)
        public string Chat { get; set; }

        // The row and column index on the board where an action is applied (used for "move" messages)
        public int Row { get; set; }    // Row index
        public int Col { get; set; }    // Column index
    }
}
