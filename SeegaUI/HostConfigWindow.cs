using SeegaUI.Args;
using SeegaLogic;
using Sockets;
using System.Net;

namespace SeegaUI
{
    public partial class HostConfigWindow : Form
    {
        public event EventHandler<ServerEventArgs> HostGame;
        public HostConfigWindow()
        {
            InitializeComponent();
        }

        private void hostButton_Click(object sender, EventArgs e)
        {

            //Player player = new Player(nameTextBox.Text, Color.Red);

            Server host = new Server(
                IPAddress.Parse(ipAddressTextBox.Text),
                int.Parse(portTextBox.Text)
                );

            ServerEventArgs connectionOptions = new ServerEventArgs(host);

            HostGame?.Invoke(this, connectionOptions);

        }
    }
}
