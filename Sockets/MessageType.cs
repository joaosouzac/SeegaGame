using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sockets
{
    public class MessageType
    {
        public string Type { get; set; }   // "chat", "select", "move"
        public string Sender { get; set; } // Name of the player that send the message
        public string Chat { get; set; } // mensagem de chat
        public int Row { get; set; }        // jogada: linha
        public int Col { get; set; }        // jogada: coluna
    }
}
