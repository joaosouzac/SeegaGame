using SeegaUI.Args;
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
    public partial class HostConfigWindow : Form
    {
        public event EventHandler<ConnectionEventArgs> ConnectionArgs;
        public HostConfigWindow()
        {
            InitializeComponent();
        }

        private void hostButton_Click(object sender, EventArgs e)
        {
            string playerNameText = nameTextBox.Text;
            string ipAddressText = ipAddressTextBox.Text;
            string portText = portTextBox.Text;

            ConnectionEventArgs connectionOptions = new ConnectionEventArgs(
                playerNameText,
                ipAddressText,
                portText
                );

            ConnectionArgs?.Invoke(this, connectionOptions);

        }
    }
}
