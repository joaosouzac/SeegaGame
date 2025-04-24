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
    public partial class StartWindow : Form
    {
        public event EventHandler OpenHostWindow;
        public event EventHandler OpenClientWindow;

        public StartWindow()
        {
            InitializeComponent();
        }

        private void hostButton_Click(object sender, EventArgs e)
        {
            OpenHostWindow?.Invoke(this, EventArgs.Empty);
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            OpenClientWindow?.Invoke(this, EventArgs.Empty);
        }
    }
}
