using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeegaLogic;
using Sockets;

namespace SeegaUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Load += MainWindow_Load;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ShowStartWindow();

        }

        private void ShowStartWindow()
        {
            StartWindow startWindow = new StartWindow();

            startWindow.OpenHostWindow += (s, args) =>
            {
                startWindow.Hide();
                ShowHostConfigWindow();

            };

            startWindow.OpenClientWindow += (s, args) =>
            {
                startWindow.Hide();
                ShowClientConfigWindow();

            };

            startWindow.FormClosed += (s, args) => this.Close();
            startWindow.Show();
        }

        private void ShowHostConfigWindow()
        {
            HostConfigWindow hostConfigWindow = new HostConfigWindow();

            hostConfigWindow.HostGame += (s, args) =>
            {
                args.Host.StartConnection();
                
                hostConfigWindow.Hide();

                ShowGameWindow(args.Player, args.Host);

            };

            hostConfigWindow.FormClosed += (s, args) => this.Close();
            hostConfigWindow.Show();
        }

        private void ShowClientConfigWindow()
        {
            ClientConfigWindow clientConfigWindow = new ClientConfigWindow();

            clientConfigWindow.JoinGame += (s, args) =>
            {
                args.Client.RequestConnection();

                clientConfigWindow.Hide();

                ShowGameWindow(args.Player, args.Client);
            };

            clientConfigWindow.FormClosed += (s, args) => this.Close();
            clientConfigWindow.Show();
        }

        private void ShowGameWindow(Player player, TCPServer host)
        {
            GameWindow gameWindow = new GameWindow(player, host);

            gameWindow.FormClosed += (s, args) => this.Close();
            gameWindow.Show();
        }

        private void ShowGameWindow(Player player, TCPClient client)
        {
            GameWindow gameWindow = new GameWindow(player, client);

            gameWindow.FormClosed += (s, args) => this.Close();
            gameWindow.Show();
        }
    }
}
