using System;
using System.Net;
using SeegaLogic;
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
                Server host = new Server(
                    IPAddress.Parse(ipAddressTextBox.Text),
                    int.Parse(portTextBox.Text)
                    );

                Player player = new Player(1, nameTextBox.Text, Color.Red);

                ServerEventArgs connectionOptions = new ServerEventArgs(host, player);

                HostGame?.Invoke(this, connectionOptions);


                // DEBUG ONLY CODE - PRECONFIGURED LOCAL HOST
                /*
                Server host = new Server(IPAddress.Loopback, 12345);

                Player player = new Player(1, "Host", Color.Red);

                ServerEventArgs connectionOptions = new ServerEventArgs(host, player);

                HostGame?.Invoke(this, connectionOptions);
                */

            }
            else if (!isServer)
            {
                Client client = new Client(
                    IPAddress.Parse(ipAddressTextBox.Text),
                    int.Parse(portTextBox.Text)
                    );

                Player player = new Player(2, nameTextBox.Text, Color.Blue);

                ClientEventArgs connectionOptions = new ClientEventArgs(client, player);

                JoinGame?.Invoke(this, connectionOptions);


                // DEBUG ONLY CODE - PRECONFIGURED LOCAL CLIENT
                /*
                Client client = new Client(IPAddress.Loopback, 12345);

                Player player = new Player(2, "Guest", Color.Blue);

                ClientEventArgs connectionOptions = new ClientEventArgs(client, player);

                JoinGame?.Invoke(this, connectionOptions);
                */
            }
        }
    }
}
