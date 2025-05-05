using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeegaUI;
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
            ConfigWindow hostConfigWindow = new ConfigWindow(true);

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
            ConfigWindow clientConfigWindow = new ConfigWindow(false);

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
            GameWindow serverGameWindow = new GameWindow(host, 1);

            serverGameWindow.FormClosed += (s, args) => this.Close();
            serverGameWindow.Show();
        }

        private void ShowClientGameWindow(Client client)
        {
            GameWindow clientGameWindow = new GameWindow(client, 2);

            clientGameWindow.FormClosed += (s, args) => this.Close();
            clientGameWindow.Show();
        }
    }
}
