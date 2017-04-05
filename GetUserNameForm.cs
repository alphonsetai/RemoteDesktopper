using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteDesktopper
{
    public partial class GetUserNameForm : Form
    {
        public GetUserNameForm()
        {
            InitializeComponent();
        }

        private void GetUserNameForm_Load(object sender, EventArgs e)
        {

        }

        public string GetUserName(string initialValue)
        {
            uxUserNameTextBox.Text = initialValue;
            this.ShowDialog();
            return uxUserNameTextBox.Text;
        }

        private void uxLoginButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
