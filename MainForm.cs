using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
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
            MoveToSouthwest();
            InitFavoritesComboBox();
            InitRdpFileComboBox();
            //InitScreenOption();
            CalculateScreenSizes();
            _moreMode = true;
            uxStateTimer.Enabled = true;
        }

        private void uxConnectButton_Click(object sender, EventArgs e)
        {
            Connect(false);
        }

        private void uxMinimizeAndConnectButton_Click(object sender, EventArgs e)
        {
            Connect(true);
        }

        private void uxRequeryRdpLinkLabel_Click(object sender, EventArgs e)
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemEvents.DisplaySettingsChanged -= SystemEvents_DisplaySettingsChanged;
        }

        private void uxFavoriteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(uxFavoriteComboBox.SelectedValue.ToString()))
                uxFavoriteRadioButton.Checked = true;
        }

        private void uxPasteServerNameLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var s = Clipboard.GetText();
            uxServerNameTextBox.Text = s;
        }

        /*-- Private Methods --------------------------------------------------------------------------------------------------*/
        private string BuildCommandArgs()
        {
            var result = string.Empty;

            if (uxRdpFileRadioButton.Checked)
                result += "\"" + Path.Combine(_rdpFolder, uxRdpFileComboBox.Text) + ".rdp\"";
            else if (uxFavoriteRadioButton.Checked)
                result += "/v: " + uxFavoriteComboBox.SelectedValue.ToString();
            else
                result += "/v:" + uxServerNameTextBox.Text;

            result += " ";

            if (uxFullScreenSizeRadioButton.Checked)

                result += uxFullScreenSizeRadioButton.Tag.ToString();

            else if (uxFullScreenWindowRadioButton.Checked)

                result += ((ScreenSize)uxFullScreenWindowComboBox.SelectedItem).Value.ToString();

            else if (uxLargestWindowRadioButton.Checked)

                result += ((ScreenSize)uxLargestWindowComboBox.SelectedItem).Value.ToString();

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

        //private ScreenMode GetScreenMode()
        //{
        //    if (Screen.AllScreens.Count() >= 2)
        //        return ScreenMode.MultiScreen;

        //    if (!SystemInformation.TerminalServerSession)
        //        return ScreenMode.SingleScreenLocal;

        //    return ScreenMode.Other;
        //}

        private void InitRdpFileComboBox()
        {
            var items = Directory.GetFiles(_rdpFolder, "*.rdp", SearchOption.TopDirectoryOnly).OrderBy(o => o);
            uxRdpFileComboBox.Items.Clear();

            foreach (var item in items)
                uxRdpFileComboBox.Items.Add(Path.GetFileNameWithoutExtension(item));
        }

        private void InitFavoritesComboBox()
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var xmlFile = Path.Combine(path, @"..\..\FavoriteMachines.xml");

            if (!File.Exists(xmlFile))
            {
                MessageBox.Show("Favorites file not found.\n\n" + xmlFile, this.Text, 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            var dt = File.GetLastWriteTime(xmlFile);
            uxFavoritesTimestampLabel.Text = dt.ToString("MM/dd/yy h:mm tt");

            List<BLL.FavoriteMachine> favorites;

            using (var sr = new StreamReader(xmlFile))
            {
                var xs = new XmlSerializer(typeof(List<BLL.FavoriteMachine>));
                favorites = (List<BLL.FavoriteMachine>)xs.Deserialize(sr);
                sr.Close();
            }

            favorites.Insert(0, new FavoriteMachine { DisplayName = string.Empty, MachineAddress = string.Empty });
            uxFavoriteComboBox.DataSource = favorites;
            uxFavoriteComboBox.DisplayMember = "DisplayName";
            uxFavoriteComboBox.ValueMember = "MachineAddress";
        }

        //private void InitScreenOption()
        //{
        //    switch (GetScreenMode())
        //    {
        //        case ScreenMode.MultiScreen:
        //            this.uxLargeSizeRadioButton.Checked = true;
        //            break;
        //        case ScreenMode.SingleScreenLocal:
        //            this.uxFullScreenSizeRadioButton.Checked = true;
        //            break;
        //        case ScreenMode.Other:
        //            this.uxLargeSizeRadioButton.Checked = true;
        //            break;
        //    }
        //}

        private void UpdateState()
        {
            if (this.WindowState != _lastState && this.WindowState == FormWindowState.Normal)
            {
                MoveToSouthwest();
            }
            _lastState = this.WindowState;

            var enabled = (uxRdpFileRadioButton.Checked && !string.IsNullOrWhiteSpace(uxRdpFileComboBox.Text)) 
                || (uxServerRadioButton.Checked && !string.IsNullOrWhiteSpace(uxServerNameTextBox.Text))
                || (uxFavoriteRadioButton.Checked && !string.IsNullOrWhiteSpace(uxFavoriteComboBox.SelectedValue.ToString()))
                ;

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

            /*--- Get List of All Full Size Windows ---*/
            var screenSizes = Screen.AllScreens
                .Select(o => o.WorkingArea)
                .OrderByDescending(o => o.Height)
                .ThenByDescending(o => o.Width)
                .Select(o => new Size
                {
                    Height = o.Height,
                    Width = o.Width
                })
                .Distinct()
                .ToList();

            var fullSizeBufferedWindows = screenSizes.Select(o => new Size
            {
                Height = o.Height - heightBuffer,
                Width = o.Width - widthBuffer
            });

            /*--- Build List of Largest Windows ---*/
            var largestWindows = new List<Size>();
            var screenNum = 0;
            var margin = 10;

            foreach (var screen in fullSizeBufferedWindows)
            {
                var bestScreenSize = screenResolutions.Where(o =>
                                                            o.Width < screen.Width - margin
                                                            && o.Height < screen.Height - margin)
                                                        .OrderByDescending(o => o.Height)
                                                        .ThenByDescending(o => o.Width)
                                                        .ToList()
                                                        .FirstOrDefault();

                if (!largestWindows.Any(o => o.Width == bestScreenSize.Width && o.Height == bestScreenSize.Height))
                { 
                    largestWindows.Add(bestScreenSize);
                    screenNum++;
                    if (screenNum > 3)
                        break;
                }
            }

            /*--- Fill Largest-Window ComboBox ---*/
            uxLargestWindowComboBox.Items.Clear();

            foreach (var item in largestWindows)
                uxLargestWindowComboBox.Items.Add(new ScreenSize(item));

            uxLargestWindowComboBox.SelectedIndex = 0;

            uxLargestWindowRadioButton.Checked = true;

            /*--- Fill Full-Screen-Window ComboBox (?)---*/
            var useEnableFullScreenWindows = (screenSizes.Count() > 1);

            if (useEnableFullScreenWindows)
            {
                uxFullScreenWindowComboBox.Items.Clear();

                foreach (var item in screenSizes)
                    uxFullScreenWindowComboBox.Items.Add(new ScreenSize(item));

                uxFullScreenWindowComboBox.SelectedIndex = 0;
                uxFullScreenWindowRadioButton.Checked = true;
            }
            uxFullScreenWindowComboBox.Visible = useEnableFullScreenWindows;
            uxFullScreenWindowRadioButton.Visible = useEnableFullScreenWindows;
        }

        private void MoveToSouthwest()
        {
            var gap = 5;
            this.Left = gap;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height - gap;
            this.Left = gap;
        }

        private void uxRequeryFavoritesLinkLabel_Click(object sender, EventArgs e)
        {
            InitFavoritesComboBox();
        }

    }
}
