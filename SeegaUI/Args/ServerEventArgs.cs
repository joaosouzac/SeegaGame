using SeegaLogic;
using System.Net;
using Sockets;

namespace SeegaUI.Args
{
    public class ServerEventArgs : EventArgs
    {
        public Player Player { get; set; }
        public TCPServer Host { get; set; }

        public ServerEventArgs(Player player, TCPServer host)
        {
            this.Player = player;
            this.Host = host;
        }
    }
}
