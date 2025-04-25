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
using SeegaLogic;
using SeegaUI.Args;
using Sockets;

namespace SeegaUI
{
    public partial class ClientConfigWindow : Form
    {
        public event EventHandler<ClientEventArgs> JoinGame;

        public ClientConfigWindow()
        {
            InitializeComponent();
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            Player player = new Player(nameTextBox.Text, Color.Blue);

            TCPClient client = new TCPClient(
                IPAddress.Parse(ipAddressTextBox.Text),
                int.Parse(portTextBox.Text)
                );

            ClientEventArgs connectionOptions = new ClientEventArgs(player, client);

            JoinGame?.Invoke(this, connectionOptions);
        }
    }
}
