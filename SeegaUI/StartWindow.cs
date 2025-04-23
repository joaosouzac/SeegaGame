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
        public StartWindow()
        {
            InitializeComponent();
        }

        private void hostButton_Click(object sender, EventArgs e)
        {
            HostConfigWindow hostConfigWindow = new HostConfigWindow();

            hostConfigWindow.Show();

            this.Close();
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir tela de configuração de cliente!");
        }
    }
}
