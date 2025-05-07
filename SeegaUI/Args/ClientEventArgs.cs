using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeegaLogic;
using Sockets;

namespace SeegaUI.Args
{
    public class ClientEventArgs : EventArgs
    {
        public Client Client { get; set; }
        public Player Player { get; set; }

        public ClientEventArgs(Client client, Player player)
        {
            
            this.Client = client;
            this.Player = player;
        }
    }
}
