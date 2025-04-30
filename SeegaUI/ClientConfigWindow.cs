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
            //Player player = new Player(nameTextBox.Text, Color.LightBlue);

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
