using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeegaUI.Args;
using Sockets;

namespace SeegaUI
{
    public partial class ConfigWindow : Form
    {
        public bool isServer = true;

        public event EventHandler<ServerEventArgs>? HostGame;
        public event EventHandler<ClientEventArgs>? JoinGame;

        public ConfigWindow(bool isServer)
        {
            InitializeComponent();

            this.isServer = isServer;

            if (isServer)
            {
                this.connectButton.Text = "Host";
            }
            else if (!isServer)
            {
                this.connectButton.Text = "Join";
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (isServer)
            {
                // CÓDIGO DE PRODUÇÃO - USAR NO PROJETO FINAL

                /*
                Server host = new Server(
                    IPAddress.Parse(ipAddressTextBox.Text),
                    int.Parse(portTextBox.Text)
                    );
                */

                // DEBUG - SERVIDOR LOCAL PRÉ-CONFIGURADO
                Server host = new Server(IPAddress.Loopback, 12345);

                ServerEventArgs connectionOptions = new ServerEventArgs(host);

                HostGame?.Invoke(this, connectionOptions);

            }
            else if (!isServer)
            {
                // CÓDIGO DE PRODUÇÃO - USAR NO PROJETO FINAL

                /*
                Client client = new Client(
                    IPAddress.Parse(ipAddressTextBox.Text),
                    int.Parse(portTextBox.Text)
                    );
                */

                // DEBUG - CLIENTE LOCAL PRÉ-CONFIGURADO
                Client client = new Client(IPAddress.Loopback, 12345);

                ClientEventArgs connectionOptions = new ClientEventArgs(client);

                JoinGame?.Invoke(this, connectionOptions);
            }
        }
    }
}
