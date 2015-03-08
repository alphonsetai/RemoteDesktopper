using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteDesktopper
{
    public partial class MainForm : Form
    {
        private string rdpFolder = @"C:\Data\Remote Desktop";
        private string rdpExe = @"C:\Windows\System32\mstsc.exe";

        public MainForm()
        {
            InitializeComponent();
        }

        /*-- Event Handlers ---------------------------------------------------------------------------------------------------*/
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitRdpFileComboBox();
            //InitOtherSizeComboBox();
            uxStateTimer.Enabled = true;
            InitScreenOption();
            CalculateBestScreenSize();
            MoveToSouthwest();
        }

        private void uxOtherSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxOtherSizeRadioButton.Checked = true;
        }

        private void uxConnectButton_Click(object sender, EventArgs e)
        {
            var p = new Process();
            var si = p.StartInfo;
            si.FileName = rdpExe;
            si.Arguments = BuildCommandArgs();
            p.Start();
            //InitScreenOption();
        }

        private void uxRequeryLinkLabel_Click(object sender, EventArgs e)
        {
            InitRdpFileComboBox();
        }

        private void uxRdpFileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxRdpFileRadioButton.Checked = true;
        }

        private void uxServerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            uxServerRadioButton.Checked = true;
        }

        private void uxStateTimer_Tick(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void uxRecalculateLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CalculateBestScreenSize();
        }

        /*-- Private Methods --------------------------------------------------------------------------------------------------*/
        private string BuildCommandArgs()
        {
            var result = string.Empty;

            if (uxRdpFileRadioButton.Checked)
                result += "\"" + Path.Combine(rdpFolder, uxRdpFileComboBox.Text) + ".rdp\"";
            else
                result += "/v:" + uxServerNameTextBox.Text;

            result += " ";

            if (uxFullScreenSizeRadioButton.Checked)
            {
                result += uxFullScreenSizeRadioButton.Tag.ToString();
            }
            else if (uxScreenSize1680x1050RadioButton.Checked)
            {
                result += uxScreenSize1680x1050RadioButton.Tag.ToString();
            }
            else if (uxBestSizeRadioButton.Checked)
            {
                result += uxBestSizeRadioButton.Tag.ToString();
            }
            else
            {
                result += uxOtherSizeRadioButton.Tag.ToString();
            }
            return result;
        }

        private ScreenMode GetScreenMode()
        {
            if (Screen.AllScreens.Count() == 2)
                return ScreenMode.DualScreen;

            if (!SystemInformation.TerminalServerSession)
                return ScreenMode.SingleScreenLocal;

            return ScreenMode.Other;
        }

        private void InitRdpFileComboBox()
        {
            var items = Directory.GetFiles(rdpFolder, "*.rdp", SearchOption.TopDirectoryOnly).OrderBy(o => o);
            uxRdpFileComboBox.Items.Clear();

            foreach (var item in items)
                uxRdpFileComboBox.Items.Add(Path.GetFileNameWithoutExtension(item));
        }

        private void InitScreenOption()
        {
            switch (GetScreenMode())
            {
                case ScreenMode.DualScreen:
                    this.uxScreenSize1680x1050RadioButton.Checked = true;
                    break;
                case ScreenMode.SingleScreenLocal:
                    this.uxFullScreenSizeRadioButton.Checked = true;
                    break;
                case ScreenMode.Other:
                    this.uxOtherSizeRadioButton.Checked = true;
                    break;
            }
        }

        private void UpdateState()
        {
            var enabled = (uxRdpFileRadioButton.Checked && !string.IsNullOrWhiteSpace(uxRdpFileComboBox.Text)) 
                || (uxServerRadioButton.Checked && !string.IsNullOrWhiteSpace(uxServerNameTextBox.Text));

            uxConnectButton.Enabled = enabled;
        }

        private void CalculateBestScreenSize()
        {
            var clientSize = this.ClientSize;
            var formSize = this.Size;

            // These buffers are for the RDP window border and title bar
            int heightBuffer = formSize.Height - clientSize.Height;
            int widthBuffer = formSize.Width - clientSize.Width;

            var biggestScreenSize = Screen.AllScreens
                .Select(o => o.WorkingArea)
                .OrderByDescending(o => o.Height)
                .ThenByDescending(o => o.Width)
                .Select(o => new Size
                {
                    Height = o.Height - heightBuffer,
                    Width = o.Width - widthBuffer
                })
                .First();

            var screenSizes = new Size[]{
                new Size(1920, 1080),
                new Size(1680, 1050),
                new Size(1440, 1050),
                new Size(1440,  900),
                new Size(1366,  768),
                new Size(1280, 1024),
                new Size(1280,  800),
                new Size(1280,  768),
                new Size(1280,  720),
                new Size(1024,  768),
                new Size( 800,  600),
                new Size( 640,  480)
            };

            var possibleScreenSizes = screenSizes.Where(o =>
                    o.Width < biggestScreenSize.Width
                    && o.Height < biggestScreenSize.Height)
                .OrderByDescending(o => o.Height)
                .ThenByDescending(o => o.Width)
                .ToList();

            var bestScreenSize = possibleScreenSizes.FirstOrDefault();

            if (bestScreenSize == null)
            {
                uxBestSizeRadioButton.Visible = false;
                return;
            }

            uxBestSizeRadioButton.Tag = string.Format("/w:{0} /h:{1}", bestScreenSize.Width, bestScreenSize.Height);
            uxBestSizeRadioButton.Text = string.Format("{0} x {1}", bestScreenSize.Width, bestScreenSize.Height);
            uxBestSizeRadioButton.Checked = true;
        }

        private void MoveToSouthwest()
        {
            var gap = 5;
            this.Left = gap;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height - gap;
        }


    }
}
