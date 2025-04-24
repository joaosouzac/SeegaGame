using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SeegaUI.Args
{
    public class ConnectionEventArgs : EventArgs
    {
        public string PlayerName { get; }
        public IPAddress IpAddress { get; }
        public int Port { get; }

        public ConnectionEventArgs(string name, string ipAddress, string port)
        {
            PlayerName = name;
            IpAddress = IPAddress.Parse(ipAddress);
            Port = int.Parse(port);
        }
    }
}
