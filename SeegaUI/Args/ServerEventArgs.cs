using SeegaLogic;
using System.Net;
using Sockets;

namespace SeegaUI.Args
{
    public class ServerEventArgs : EventArgs
    {
        //public Player Player { get; set; }
        public Server Host { get; set; }
        public Player Player { get; set; }

        public ServerEventArgs(Server host, Player player)
        {
            this.Host = host;
            this.Player = player;
        }
    }
}
