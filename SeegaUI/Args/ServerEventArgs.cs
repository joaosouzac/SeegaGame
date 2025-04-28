using SeegaLogic;
using System.Net;
using Sockets;

namespace SeegaUI.Args
{
    public class ServerEventArgs : EventArgs
    {
        //public Player Player { get; set; }
        public Server Host { get; set; }

        public ServerEventArgs(Server host)
        {
            this.Host = host;
        }
    }
}
