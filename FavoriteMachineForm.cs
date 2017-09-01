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
        private FavoriteMachine _machine;

        public FavoriteMachineForm()
        {
            InitializeComponent();
        }

        public void ShowDialog(FavoriteMachine m)
        {
            _machine = m;

            uxServerNameTextBox.Text = _machine.MachineName;
            uxIpAddressTextBox.Text = _machine.MachineAddress;
            uxPortTextBox.Text = _machine.SshPort.ToString();
            uxUsernameTextBox.Text = _machine.SshUser;
            uxPemFileTextBox.Text = _machine.GroupName + @"\" + _machine.KeyName + ".pem";

            lblPort.Visible = _machine.UsesSsh;
            uxPortTextBox.Visible = _machine.UsesSsh;
            lblUsername.Visible = _machine.UsesSsh;
            uxUsernameTextBox.Visible = _machine.UsesSsh;
            lblPemFile.Visible = _machine.UsesSsh;
            uxPemFileTextBox.Visible = _machine.UsesSsh;

            ShowDialog();
        }

        private void uxCopyButton_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();

            sb.Append("Server: ");
            sb.AppendLine(uxServerNameTextBox.Text);

            sb.Append("IP Address: ");
            sb.AppendLine(uxIpAddressTextBox.Text);

            if (_machine.UsesSsh)
            {
                sb.Append("Port: ");
                sb.AppendLine(uxPortTextBox.Text);

                sb.Append("Username: ");
                sb.AppendLine(uxUsernameTextBox.Text);

                sb.Append("PEM File: ");
                sb.AppendLine(uxPemFileTextBox.Text);
            }

            Clipboard.SetText(sb.ToString());
        }

        private void uxCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
