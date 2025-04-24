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
    public partial class GameWindow : Form
    {
        public GameWindow()
        {
            InitializeComponent();
        }

        private void SendMessage(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ChatTextBox.Text)) return;

            ChatPanel.Controls.Add(new Label
            {
                Text = $"[Você]: {ChatTextBox.Text}",
                AutoSize = true,
            });

            ChatTextBox.Clear();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
