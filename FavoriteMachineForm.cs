using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RemoteDesktopper.BLL;

namespace RemoteDesktopper
{
    public partial class FavoriteMachineForm : Form
    {
        public FavoriteMachineForm()
        {
            InitializeComponent();
        }

        public void ShowDialog(FavoriteMachine m)
        {
            uxServerNameTextBox.Text = m.MachineName;
            uxIpAddressTextBox.Text = m.MachineAddress;
            uxPortTextBox.Text = m.SshPort.ToString();
            uxUsernameTextBox.Text = m.SshUser;
            uxPemFileTextBox.Text = m.GroupName + @"\" + m.KeyName + ".pem";
            ShowDialog();
        }

        private void uxCopyButton_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();

            sb.Append("Server: ");
            sb.AppendLine(uxServerNameTextBox.Text);

            sb.Append("IP Address: ");
            sb.AppendLine(uxIpAddressTextBox.Text);

            sb.Append("Port: ");
            sb.AppendLine(uxPortTextBox.Text);

            sb.Append("Username: ");
            sb.AppendLine(uxUsernameTextBox.Text);

            sb.Append("PEM File: ");
            sb.AppendLine(uxPemFileTextBox.Text);

            Clipboard.SetText(sb.ToString());
        }
    }
}
