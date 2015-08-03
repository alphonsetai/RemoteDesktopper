﻿using System;
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
using Microsoft.Win32;
using RemoteDesktopper.BLL;

namespace RemoteDesktopper
{
    public partial class MainForm : Form
    {
        private string _rdpFolder = @"C:\Data\Remote Desktop";
        private string _rdpExe = @"C:\Windows\System32\mstsc.exe";
        private bool _moreMode = true;
        private FormWindowState _lastState;

        public MainForm()
        {
            InitializeComponent();
            _lastState = this.WindowState;
            SystemEvents.DisplaySettingsChanged += SystemEvents_DisplaySettingsChanged;
        }

        void SystemEvents_DisplaySettingsChanged(object sender, EventArgs e)
        {
            MoveToSouthwest();
            CalculateScreenSizes();
        }

        /*-- Event Handlers ---------------------------------------------------------------------------------------------------*/
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitRdpFileComboBox();
            //InitOtherSizeComboBox();
            uxStateTimer.Enabled = true;
            InitScreenOption();
            CalculateScreenSizes();
            _moreMode = true;
            //ToggleMoreMode();
            MoveToSouthwest();
        }

        //private void uxOtherSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    uxMediumSizeRadioButton.Checked = true;
        //}

        private void uxConnectButton_Click(object sender, EventArgs e)
        {
            Connect(false);
        }

        private void uxMinimizeAndConnectButton_Click(object sender, EventArgs e)
        {
            Connect(true);
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
            CalculateScreenSizes();
        }

        private void uxMoreButton_Click(object sender, EventArgs e)
        {
            ToggleMoreMode();
        }

        private void uxStoredServerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var o = uxStoredServerComboBox.SelectedItem as RdpServer;

            if (o != null)
            {
                this.uxStoredServerNameTextBox.Text = o.ServerName;
                uxLoginNameTextBox.Text = o.LoginName;
                uxPasswordTextBox.Text = o.Password;
            }
        }

        private void MainForm_ClientSizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState != _lastState && this.WindowState == FormWindowState.Normal)
            {                
                MoveToSouthwest();
            }
            _lastState = this.WindowState;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemEvents.DisplaySettingsChanged -= SystemEvents_DisplaySettingsChanged;
        }

        /*-- Private Methods --------------------------------------------------------------------------------------------------*/
        private string BuildCommandArgs()
        {
            var result = string.Empty;

            if (uxRdpFileRadioButton.Checked)
                result += "\"" + Path.Combine(_rdpFolder, uxRdpFileComboBox.Text) + ".rdp\"";
            else
                result += "/v:" + uxServerNameTextBox.Text;

            result += " ";

            if (uxFullScreenSizeRadioButton.Checked)
            {
                result += uxFullScreenSizeRadioButton.Tag.ToString();
            }
            else if (uxLargeSizeRadioButton.Checked)
            {
                result += uxLargeSizeRadioButton.Tag.ToString();
            }
            else if (uxMediumSizeRadioButton.Checked)
            {
                result += uxMediumSizeRadioButton.Tag.ToString();
            }
            else if (uxSmallSizeRadioButton.Checked)
            {
                result += uxSmallSizeRadioButton.Tag.ToString();
            }
            return result;
        }

        private void Connect(bool minimizeFirst)
        {
            if (minimizeFirst)
                this.WindowState = FormWindowState.Minimized;

            var p = new Process();
            var si = p.StartInfo;
            si.FileName = _rdpExe;
            si.Arguments = BuildCommandArgs();
            p.Start();
        }

        private ScreenMode GetScreenMode()
        {
            if (Screen.AllScreens.Count() >= 2)
                return ScreenMode.MultiScreen;

            if (!SystemInformation.TerminalServerSession)
                return ScreenMode.SingleScreenLocal;

            return ScreenMode.Other;
        }

        private void InitRdpFileComboBox()
        {
            var items = Directory.GetFiles(_rdpFolder, "*.rdp", SearchOption.TopDirectoryOnly).OrderBy(o => o);
            uxRdpFileComboBox.Items.Clear();

            foreach (var item in items)
                uxRdpFileComboBox.Items.Add(Path.GetFileNameWithoutExtension(item));
        }

        private void InitScreenOption()
        {
            switch (GetScreenMode())
            {
                case ScreenMode.MultiScreen:
                    this.uxLargeSizeRadioButton.Checked = true;
                    break;
                case ScreenMode.SingleScreenLocal:
                    this.uxFullScreenSizeRadioButton.Checked = true;
                    break;
                case ScreenMode.Other:
                    this.uxLargeSizeRadioButton.Checked = true;
                    break;
            }
        }

        private void UpdateState()
        {
            var enabled = (uxRdpFileRadioButton.Checked && !string.IsNullOrWhiteSpace(uxRdpFileComboBox.Text)) 
                || (uxServerRadioButton.Checked && !string.IsNullOrWhiteSpace(uxServerNameTextBox.Text));

            uxConnectButton.Enabled = enabled;
            uxMinimizeAndConnectButton.Enabled = enabled;
        }

        private void CalculateScreenSizes()
        {
            /*--- Inits ---*/
            var clientSize = this.ClientSize;
            var formSize = this.Size;

            // These buffers are for the RDP window border and title bar
            int heightBuffer = formSize.Height - clientSize.Height;
            int widthBuffer = formSize.Width - clientSize.Width;

            var screenResolutions = new Size[]{
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

            var screenSizeRadioButtons = new RadioButton[] { 
                uxLargeSizeRadioButton,
                uxMediumSizeRadioButton,
                uxSmallSizeRadioButton
            };

            /*--- Get List of All Screens ---*/
            var screens = Screen.AllScreens
                .Select(o => o.WorkingArea)
                .OrderByDescending(o => o.Height)
                .ThenByDescending(o => o.Width)
                .Select(o => new Size
                {
                    Height = o.Height - heightBuffer,
                    Width = o.Width - widthBuffer
                });

            /*--- Get Distinct Screen Sizes ---*/
            var screenSizes = new List<Size>();
            var screenNum = 0;

            foreach (var screen in screens)
            {
                var bestScreenSize = screenResolutions.Where(o =>
                                                            o.Width < screen.Width
                                                            && o.Height < screen.Height)
                                                        .OrderByDescending(o => o.Height)
                                                        .ThenByDescending(o => o.Width)
                                                        .ToList()
                                                        .FirstOrDefault();

                if (!screenSizes.Any(o => o.Width == bestScreenSize.Width && o.Height == bestScreenSize.Height))
                { 
                    screenSizes.Add(bestScreenSize);
                    screenNum++;
                    if (screenNum > 3)
                        break;
                }
            }


            /*--- Hide Radio Buttons ---*/
            for (int i = 0; i < 3; i++)
                screenSizeRadioButtons[i].Visible = false;

            /*--- Loop Through Screens ---*/
            screenNum = 0;

            foreach (var screenSize in screenSizes)
            {
                var rb = screenSizeRadioButtons[screenNum];
                rb.Tag = string.Format("/w:{0} /h:{1}", screenSize.Width, screenSize.Height);
                rb.Text = string.Format("{0} x {1}", screenSize.Width, screenSize.Height);
                rb.Visible = true;

                screenNum++;
            }
        }

        private void MoveToSouthwest()
        {
            var gap = 5;
            this.Left = gap;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height - gap;
            this.Left = gap;
        }

        private void uxStoredServerRadioButton_Click(object sender, EventArgs e)
        {
            InitStoredServerComboBox();
        }

        private void InitStoredServerComboBox()
        {
            uxStoredServerComboBox.DataSource = null;
            uxStoredServerComboBox.DataSource = new AppServerManager().GetRdpServers();
            uxStoredServerComboBox.DisplayMember = "Name";
        }

        private void ToggleMoreMode()
        {
            _moreMode = !_moreMode;
            Height = _moreMode ? 231 : 128;
            MoveToSouthwest();
            uxStoredServerPanel.Visible = _moreMode;
            uxMoreButton.Text = (_moreMode ? "Less" : "More");
        }


    }
}
