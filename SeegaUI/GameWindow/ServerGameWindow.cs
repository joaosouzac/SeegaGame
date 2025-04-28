using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sockets;

namespace SeegaUI.GameWindow
{
    public partial class ServerGameWindow : Form
    {
        private Server server;

        public ServerGameWindow(Server server)
        {
            InitializeComponent();

            this.server = server;
            this.server.MessageReceived += AddReceivedMessage;
        }

        private void ServerGameWindow_Load(object sender, EventArgs e)
        {
            this.server.Start();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string message = this.ChatTextbox.Text.Trim();

            if (!string.IsNullOrEmpty(message))
            {
                this.server.SendMessage(message);
                AddSentMessage("You: " + message);

                this.ChatTextbox.Clear();
            }
        }

        private void AddSentMessage(string text)
        {
            AddMessage(text, Color.LightGray);
        }

        private void AddReceivedMessage(string text)
        {
            AddMessage("Opponent: " + text, Color.LightBlue);
        }

        private void AddMessage(string text, Color backgroundColor)
        {
            if (this.ChatPanel.InvokeRequired)
            {
                this.ChatPanel.Invoke(new Action(() => AddMessage(text, backgroundColor)));
            }
            else
            {
                Label lbl = new Label();

                lbl.Text = text;
                //lbl.AutoSize = true;
                lbl.MaximumSize = new Size(this.ChatPanel.Width - 20, 0);
                lbl.BackColor = backgroundColor;
                //lbl.Padding = new Padding(5);

                this.ChatPanel.Controls.Add(lbl);
            }
        }
    }
}
