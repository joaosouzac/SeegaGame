using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            hostConfigWindow.ConnectionArgs += (s, args) =>
            {
                MessageBox.Show($"{args.PlayerName} | {args.IpAddress}:{args.Port}");

            };

            hostConfigWindow.FormClosed += (s, args) => this.Close();
            hostConfigWindow.Show();
        }

        private void ShowClientConfigWindow()
        {
            // PENDENTE
        }

        private void ShowGameWindow()
        {
            GameWindow gameWindow = new GameWindow();

            gameWindow.FormClosed += (s, args) => this.Close();
            gameWindow.Show();
        }
    }
}
