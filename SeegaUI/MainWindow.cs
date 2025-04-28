using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeegaUI.GameWindow;
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
                //args.Host.StartConnection();
                
                hostConfigWindow.Hide();

                ShowServerGameWindow(args.Host);

            };

            hostConfigWindow.FormClosed += (s, args) => this.Close();
            hostConfigWindow.Show();
        }

        private void ShowClientConfigWindow()
        {
            ClientConfigWindow clientConfigWindow = new ClientConfigWindow();

            clientConfigWindow.JoinGame += (s, args) =>
            {
                //args.Client.RequestConnection();

                clientConfigWindow.Hide();

                ShowClientGameWindow(args.Client);
            };

            clientConfigWindow.FormClosed += (s, args) => this.Close();
            clientConfigWindow.Show();
        }

        private void ShowServerGameWindow(Server host)
        {
            ServerGameWindow serverGameWindow = new ServerGameWindow(host);

            serverGameWindow.FormClosed += (s, args) => this.Close();
            serverGameWindow.Show();
        }

        private void ShowClientGameWindow(Client client)
        {
            ClientGameWindow clientGameWindow = new ClientGameWindow(client);

            clientGameWindow.FormClosed += (s, args) => this.Close();
            clientGameWindow.Show();
        }
    }
}
