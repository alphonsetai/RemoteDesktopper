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
        private string _sshKeyFolder = string.Empty;

        private string _rdpExe = @"C:\Windows\System32\mstsc.exe";
        private string _puttyExe = @"C:\Program Files (x86)\PuTTY\putty.exe";
        private string _winscpExe = @"C:\Program Files (x86)\WinSCP\winscp.com";
        private string _rdpTemplate;
        private bool _moreMode = true;
        private FormWindowState _lastState;
        private List<BLL.FavoriteMachine> _favoriteMachines;

        public MainForm()
        {
            InitializeComponent();
            _lastState = this.WindowState;
            SystemEvents.DisplaySettingsChanged += SystemEvents_DisplaySettingsChanged;
            _rdpTemplate = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Template.rdp");
            _sshKeyFolder = GetSshKeyFolder();
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
            InitFavoriteGroupsComboBox();
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
            if (!string.IsNullOrWhiteSpace(uxFavoriteMachineComboBox.SelectedValue.ToString()))
                uxFavoriteRadioButton.Checked = true;
        }

        private void uxPasteServerNameLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var s = Clipboard.GetText();
            uxServerNameTextBox.Text = s;
        }

        private void uxRequeryFavoritesLinkLabel_Click(object sender, EventArgs e)
        {
            InitFavoriteGroupsComboBox();
        }

        private void uxFavoriteGroupsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshFavoriteMachinesComboBox();
        }

        /*-- Private Methods --------------------------------------------------------------------------------------------------*/
        private Command BuildCommand()
        {
            var args = string.Empty;
            var usePutty = false;
            var isValid = true;
            var errorMessage = string.Empty;

            if (uxRdpFileRadioButton.Checked)
            {
                args += "\"" + Path.Combine(_rdpFolder, uxRdpFileComboBox.Text) + ".rdp\" ";
            }
            else if (uxServerRadioButton.Checked)
            {
                args += "/v:" + uxServerNameTextBox.Text;
            }
            else
            {
                var selectedFavorite = ((FavoriteMachine)uxFavoriteMachineComboBox.SelectedValue);

                if (selectedFavorite.Platform == "Windows")
                {
                    var targetFileName = CleanFileName(selectedFavorite.MachineName + " - " + selectedFavorite.GroupName);
                    var targetFullName = Path.Combine(_rdpFolder, "Temp", targetFileName);
                    File.Copy(_rdpTemplate, targetFullName, true);
                    args += "\"" + targetFullName + "\" ";
                    args += "/v: " + selectedFavorite.MachineAddress;
                }
                else // assume Linux
                {
                    usePutty = true;
                    var keyFolder = Path.Combine(_sshKeyFolder, selectedFavorite.GroupName);
                    var ppkFile = Path.Combine(keyFolder, selectedFavorite.KeyName) + ".ppk";
                    var pemFile = Path.Combine(keyFolder, selectedFavorite.KeyName) + ".pem";
                    // TODO: If PPK file not found, but PEM file is, offer to convert it via the following command
                    // winscp.com /keygen {pemFile} /output={ppkFile}

                    if (File.Exists(ppkFile))
                    {
                        var user = "ec2-user"; // assumed
                        var port = 22; // assumed
                        args = string.Format("-ssh {0}@{1} -P {2} -i \"{3}\"", "ec2-user", selectedFavorite.MachineAddress, port, ppkFile);
                    }
                    else
                    {
                        isValid = false;
                        errorMessage = string.Format("PPK file '{0}' not found.", ppkFile);
                    }

                }
            }

            if (!usePutty)
            {
                args += " ";

                if (uxFullScreenSizeRadioButton.Checked)
                {
                    args += uxFullScreenSizeRadioButton.Tag.ToString();
                }
                else if (uxFullScreenWindowRadioButton.Checked)
                {
                    args += ((ScreenSize)uxFullScreenWindowComboBox.SelectedItem).Value.ToString();
                }
                else if (uxLargestWindowRadioButton.Checked)
                {
                    args += ((ScreenSize)uxLargestWindowComboBox.SelectedItem).Value.ToString();
                }
            }

            return new Command
            {
                Arguments = args,
                UsePutty = usePutty,
                IsValid = isValid,
                ErrorMessage = errorMessage
            };
        }

        private void Connect(bool minimizeFirst)
        {
            var cmd = BuildCommand();

            if (minimizeFirst && !cmd.UsePutty)
                this.WindowState = FormWindowState.Minimized;

            var p = new Process();
            var si = p.StartInfo;
            si.FileName = cmd.UsePutty ? _puttyExe : _rdpExe;
            si.Arguments = cmd.Arguments;
            p.Start();
        }

        private void InitRdpFileComboBox()
        {
            var items = Directory.GetFiles(_rdpFolder, "*.rdp", SearchOption.TopDirectoryOnly).OrderBy(o => o);
            uxRdpFileComboBox.Items.Clear();

            foreach (var item in items)
                uxRdpFileComboBox.Items.Add(Path.GetFileNameWithoutExtension(item));
        }

        private void InitFavoriteGroupsComboBox()
        {
            /*--- Inits ---*/
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var xmlFile = Path.Combine(path, @"..\..\FavoriteMachines.xml");

            if (!File.Exists(xmlFile))
            {
                MessageBox.Show("Favorites file not found.\n\n" + xmlFile, this.Text, 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            /*--- Update Timestamp Label ---*/
            var lbl = uxFavoritesTimestampLabel;
            var dt = File.GetLastWriteTime(xmlFile);
            var isOld = (DateTime.Now.Subtract(dt).TotalHours > 24.0);

            lbl.Text = dt.ToString("MM/dd/yy h:mm tt");
            lbl.ForeColor = isOld ? Color.Red : SystemColors.ControlText;
            lbl.BackColor = isOld ? Color.Yellow : SystemColors.Control;

            /*--- Load Favorites from XML file ---*/

            using (var sr = new StreamReader(xmlFile))
            {
                var xs = new XmlSerializer(typeof(List<BLL.FavoriteMachine>));
                _favoriteMachines = (List<BLL.FavoriteMachine>)xs.Deserialize(sr);
                sr.Close();
            }
            _favoriteMachines.Insert(0, new FavoriteMachine { DisplayName = string.Empty, MachineAddress = string.Empty, GroupName = string.Empty, MachineName = string.Empty });

            /*--- Bind Favorite Groups ComboBox ---*/
            uxFavoriteGroupsComboBox.DataSource = _favoriteMachines.Select(a => a.GroupName).Distinct().OrderBy(a => a).ToList();
            RefreshFavoriteMachinesComboBox();
        }

        private void RefreshFavoriteMachinesComboBox()
        {
            var groupName = uxFavoriteGroupsComboBox.SelectedValue.ToString();
            uxFavoriteMachineComboBox.DataSource = _favoriteMachines.Where(a => a.GroupName == groupName).ToList(); ;
            uxFavoriteMachineComboBox.DisplayMember = "DisplayName";
            uxFavoriteMachineComboBox.ValueMember = null;// Bind to the object "MachineAddress";
        }

        private void UpdateState()
        {
            if (this.WindowState != _lastState && this.WindowState == FormWindowState.Normal)
            {
                MoveToSouthwest();
            }
            _lastState = this.WindowState;

            var enabled = (uxRdpFileRadioButton.Checked && !string.IsNullOrWhiteSpace(uxRdpFileComboBox.Text)) 
                || (uxServerRadioButton.Checked && !string.IsNullOrWhiteSpace(uxServerNameTextBox.Text))
                || (uxFavoriteRadioButton.Checked && !string.IsNullOrWhiteSpace(uxFavoriteMachineComboBox.SelectedValue.ToString()))
                ;

            uxConnectButton.Enabled = enabled;
            //uxMinimizeAndConnectButton.Enabled = enabled;
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

        private string CleanFileName(string input)
        {
            var illegalCharacters = "\\/:*?\"<>|";
            var imax = illegalCharacters.Length - 1;
            var result = input;

            for (var i = 0; i <= imax; i++)
                result = result.Replace(illegalCharacters.Substring(i, 1), "~");
            
            return result;
        }

        private string GetSshKeyFolder()
        {
            var subKeyName = @"SOFTWARE\Jasinski\Remote Desktopper";
            var valueName = "SSH Key Folder";

            var subKey = Registry.CurrentUser.OpenSubKey(subKeyName);

            if (subKey == null)
            {
                var msg = string.Format("Couldn't determine SSH Key Folder.\n\nRegistry Key 'HKCU\\{0}' not found.\n\nYou will not be able to connect to servers over SSH.", 
                    subKeyName);

                MessageBox.Show(msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return string.Empty;
            }
            
            var value = subKey.GetValue(valueName);

            if (value == null)
            {
                var msg = string.Format("Couldn't determine SSH Key Folder.\n\nRegistry Value 'HKCU\\{0}\\[{1}]' not found.\n\nYou will not be able to connect to servers over SSH.", 
                    subKeyName, valueName);

                MessageBox.Show(msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return string.Empty;
            }

            var result = value.ToString();
            return result;
        }
    }
}
