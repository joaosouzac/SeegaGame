using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using SeegaLogic;
using Sockets;


namespace SeegaUI
{
    public partial class GameWindow : Form
    {
        public Player Player;
        private TCPServer Host;
        private TCPClient Client;

        public GameWindow(Player player, TCPServer host)
        {
            InitializeComponent();
            this.Player = player;
            this.Host = host;

            playerNameLabel.Text = Player.Name;
            playerNameLabel.ForeColor = Color.Red;

        }

        public GameWindow(Player player, TCPClient client)
        {
            InitializeComponent();
            this.Player = player;
            this.Client = client;

            playerNameLabel.Text = Player.Name;
            playerNameLabel.ForeColor = Player.Color;
        }

        private void SendMessage(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ChatTextBox.Text)) return;

            ChatPanel.Controls.Add(new Label
            {
                Text = $"{Player.Name}: {ChatTextBox.Text}",
                AutoSize = true,
            });

            ChatTextBox.Clear();
        }
    }
}
