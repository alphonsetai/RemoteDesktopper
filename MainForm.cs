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
        private FormWindowState _lastState;
        private List<BLL.FavoriteMachine> _favoriteMachines;

        public MainForm()
        {
            InitializeComponent();

            uxFavoritePanel.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));

            uxRdpFilePanel.Location = uxFavoritePanel.Location;
            uxRdpFilePanel.Anchor = uxFavoritePanel.Anchor;

            uxManualPanel.Location = uxFavoritePanel.Location;
            uxManualPanel.Anchor = uxFavoritePanel.Anchor;

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

        /*-- Private Methods --------------------------------------------------------------------------------------------------*/
        private Command BuildCommand(bool fromMenuItems = false)
        {
            var args = string.Empty;
            var usePutty = false;
            var isValid = true;
            var errorMessage = string.Empty;

            /*--- Determin Remote Server ---*/
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

                if (!selectedFavorite.UsesSsh)
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

                    /*--- If PPK file not found, but PEM file is, offer to convert it ---*/
                    if (!File.Exists(ppkFile) && File.Exists(pemFile))
                    {
                        var msg = string.Format("PPK file was not found.\n{0}.\n\nPEM file was found. Convert it? \n\n{1}", ppkFile, pemFile);

                        if (DialogResult.Yes == MessageBox.Show(msg, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            ConvertPemFileToPpk(pemFile);
                        }
                    }

                    if (File.Exists(ppkFile))
                    {
                        var user = selectedFavorite.SshUser;
                        var port = selectedFavorite.SshPort;
                        args = string.Format("-ssh {0}@{1} -P {2} -i \"{3}\"", user, selectedFavorite.MachineAddress, port, ppkFile);
                    }
                    else
                    {
                        isValid = false;
                        errorMessage = string.Format("PPK file '{0}' not found.", ppkFile);
                    }

                }
            }

            /*--- Determine Window Size ---*/
            if (!usePutty)
            {
                args += " ";

                if ((!fromMenuItems && uxFullScreenSizeRadioButton.Checked) || (fromMenuItems && uxFullScreenMenuItem.Checked))
                {
                    args += uxFullScreenSizeRadioButton.Tag.ToString();
                }
                else if ((!fromMenuItems && uxAllMonitorsRadioButton.Checked) || (fromMenuItems && uxAllMonitorsMenuItem.Checked))
                {
                    args += uxAllMonitorsRadioButton.Tag.ToString();
                }
                else if (!fromMenuItems && uxFullScreenWindowRadioButton.Checked)
                {
                    args += ((ScreenSize)uxFullScreenWindowComboBox.SelectedItem).Value.ToString();
                }
                else if (fromMenuItems && uxFullScreenWindowMenuItem.Checked)
                {
                    var checkedChild = GetFirstCheckedChild(uxFullScreenWindowMenuItem);
                    var ss = checkedChild.Tag as ScreenSize;
                    args += ss.Value;
                }
                else if (!fromMenuItems && uxLargestWindowRadioButton.Checked)
                {
                    args += ((ScreenSize)uxLargestWindowComboBox.SelectedItem).Value.ToString();
                }
                else if (fromMenuItems && uxLargestWindowMenuItem.Checked)
                {
                    var checkedChild = GetFirstCheckedChild(uxLargestWindowMenuItem);
                    var ss = checkedChild.Tag as ScreenSize;
                    args += ss.Value;
                }
            }

            /*--- Return Result ---*/
            return new Command
            {
                Arguments = args,
                UsePutty = usePutty,
                IsValid = isValid,
                ErrorMessage = errorMessage
            };
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
            uxLargestWindowMenuItem.DropDownItems.Clear();
            var first = true;

            foreach (var item in largestWindows)
            {
                var ss = new ScreenSize(item);

                var menuItem = new ToolStripMenuItem
                {
                    Text = ss.DisplayText,
                    Tag = ss,
                    Checked = first
                };

                menuItem.Click += uxWindowSizeMenuItem_Click;

                uxLargestWindowMenuItem.DropDownItems.Add(menuItem);

                uxLargestWindowComboBox.Items.Add(ss);

                if (first)
                    HandleWindowSizeMenuItemClick(menuItem);

                first = false;
            }

            uxLargestWindowComboBox.SelectedIndex = 0;

            //uxLargestWindowRadioButton.Checked = true;

            /*--- Fill Full-Screen-Window ComboBox (?)---*/
            var useEnableFullScreenWindows = (screenSizes.Count() > 1);

            if (useEnableFullScreenWindows)
            {   
                uxFullScreenWindowComboBox.Items.Clear();
                uxFullScreenWindowMenuItem.DropDownItems.Clear();

                foreach (var item in screenSizes)
                {
                    var ss = new ScreenSize(item);

                    var menuItem = new ToolStripMenuItem
                    {
                        Text = ss.DisplayText,
                        Tag = ss
                    };

                    menuItem.Click += uxWindowSizeMenuItem_Click;

                    uxFullScreenWindowMenuItem.DropDownItems.Add(menuItem);

                    uxFullScreenWindowComboBox.Items.Add(ss);
                    
                }

                uxFullScreenWindowComboBox.SelectedIndex = 0;
                //uxFullScreenWindowRadioButton.Checked = true;
            }
            uxFullScreenWindowComboBox.Visible = useEnableFullScreenWindows;
            uxFullScreenWindowRadioButton.Visible = useEnableFullScreenWindows;
            uxFullScreenWindowMenuItem.Visible = useEnableFullScreenWindows;
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

        private void Connect(bool fromMenuItems = false)
        {
            var cmd = BuildCommand(fromMenuItems);

            if (!cmd.IsValid)
            {
                MessageBox.Show(cmd.ErrorMessage, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var p = new Process();
            var si = p.StartInfo;
            si.FileName = cmd.UsePutty ? _puttyExe : _rdpExe;
            si.Arguments = cmd.Arguments;
            p.Start();
        }

        private void ConvertPemFileToPpk(string pemFile)
        {
            // Assumption: pemKeyFile exists

            // winscp.com /keygen {pemFile} /output={ppkFile}

            var ppkFile = Path.Combine(Path.GetDirectoryName(pemFile), Path.GetFileNameWithoutExtension(pemFile)) + ".ppk";

            var args = string.Format("/keygen \"{0}\" /output=\"{1}\"", pemFile, ppkFile);

            var p = new Process();
            var si = p.StartInfo;
            si.FileName = _winscpExe;
            si.Arguments = args;
            
            p.Start();
            p.WaitForExit();
        }

        private ToolStripMenuItem GetFirstCheckedChild(ToolStripDropDownItem parent)
        {
            foreach (var item in parent.DropDownItems)
            {
                var menuItem = item as ToolStripMenuItem;

                if (menuItem == null)
                    continue;

                if (menuItem.Checked)
                    return menuItem;
            }

            return null;
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

        private RadioMenuItem HandleRadioMenuItem(object sender)
        {
            var senderMenuItem = sender as ToolStripMenuItem;

            if (senderMenuItem == null)
                return null;

            var parentMenuItem = senderMenuItem.OwnerItem as ToolStripMenuItem;

            var parentSplitButton = senderMenuItem.OwnerItem as ToolStripSplitButton;

            if (parentMenuItem != null)
            {
                foreach (var menuItem in parentMenuItem.DropDownItems)
                    (menuItem as ToolStripMenuItem).Checked = false;
                
                parentMenuItem.Text = senderMenuItem.Text;
            }

            else if (parentSplitButton != null)
            {
                foreach (var menuItem in parentSplitButton.DropDownItems)
                    (menuItem as ToolStripMenuItem).Checked = false;

                parentSplitButton.Text = senderMenuItem.Text;
            }

            senderMenuItem.Checked = true;

            return new RadioMenuItem
            {
                Child = senderMenuItem,
                ParentSplitButton = parentSplitButton,
                ParentMenuItem = parentMenuItem
            };
        }

        private void HandleWindowSizeMenuItemClick(object sender)
        {
            var rmi = HandleRadioMenuItem(sender);

            if (rmi == null)
                return;

            rmi.ParentMenuItem.Checked = true;
            rmi.ParentMenuItem.Text = $"{rmi.ParentMenuItem.Tag} - {rmi.Child.Text}";
            uxConnectSplitButton.Text = $"Connect ({rmi.ParentMenuItem.Tag} - {rmi.Child.Text})";
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

        private void MoveToSouthwest()
        {
            var gap = 5;
            this.Left = gap;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height - gap;
            this.Left = gap;
        }

        private void RefreshFavoriteMachinesComboBox()
        {
            if (uxFavoriteGroupsComboBox.SelectedValue == null)
                return;

            var groupName = uxFavoriteGroupsComboBox.SelectedValue.ToString();
            uxFavoriteMachineComboBox.DataSource = _favoriteMachines.Where(a => a.GroupName == groupName).ToList(); ;
            uxFavoriteMachineComboBox.DisplayMember = "DisplayName";
            uxFavoriteMachineComboBox.ValueMember = null;// Bind to the object "MachineAddress";
        }

        private string SelectedFavoriteMachine
        {
            get
            {
                var fm = uxFavoriteMachineComboBox.SelectedValue as FavoriteMachine;

                var s = fm == null ? string.Empty : fm.DisplayName;

                return s;
            }
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
                || (uxFavoriteRadioButton.Checked && !string.IsNullOrWhiteSpace(SelectedFavoriteMachine));

            uxConnectButton.Enabled = enabled;
            uxConnectSplitButton.Enabled = enabled;
            //uxMinimizeAndConnectButton.Enabled = enabled;
        }

        /*-- Event Handlers ---------------------------------------------------------------------------------------------------*/
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemEvents.DisplaySettingsChanged -= SystemEvents_DisplaySettingsChanged;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MoveToSouthwest();
            InitFavoriteGroupsComboBox();
            InitRdpFileComboBox();
            CalculateScreenSizes();
            uxStateTimer.Enabled = true;
        }

        private void uxConnectButton_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void uxConnectSplitButton_ButtonClick(object sender, EventArgs e)
        {
            Connect(true);
        }

        private void uxFavoriteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(uxFavoriteMachineComboBox.SelectedValue.ToString()))
                uxFavoriteRadioButton.Checked = true;
        }

        private void uxFavoriteGroupsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshFavoriteMachinesComboBox();
        }

        private void uxFavoritePropertiesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var selectedFavorite = ((FavoriteMachine)uxFavoriteMachineComboBox.SelectedValue);
            var frm = new FavoriteMachineForm();
            frm.ShowDialog(selectedFavorite);
        }

        private void uxOptionMenuItem_Click(object sender, EventArgs e)
        {
            var rmi = HandleRadioMenuItem(sender);

            if (rmi == null)
                return;

            if (rmi.Child == uxFavoriteMenuItem)
            {
                uxFavoriteRadioButton.Checked = true;
                uxFavoritePanel.Visible = true;
                uxRdpFilePanel.Visible = false;
                uxManualPanel.Visible = false;
            }
            else if (rmi.Child == uxRdpFileMenuItem)
            {
                uxRdpFileRadioButton.Checked = true;
                uxFavoritePanel.Visible = false;
                uxRdpFilePanel.Visible = true;
                uxManualPanel.Visible = false;
            }
            else if (rmi.Child == uxManualMenuItem)
            {
                uxServerRadioButton.Checked = true;
                uxFavoritePanel.Visible = false;
                uxRdpFilePanel.Visible = false;
                uxManualPanel.Visible = true;
            }
        }

        private void uxPasteServerNameLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var s = Clipboard.GetText();
            uxServerNameTextBox.Text = s;
        }

        private void uxRecalculateLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CalculateScreenSizes();
        }
        
        private void uxRequeryFavoritesLinkLabel_Click(object sender, EventArgs e)
        {
            InitFavoriteGroupsComboBox();
        }

        private void uxRequeryFavoritesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefreshFavoriteMachinesComboBox();
        }

        private void uxRequeryRdpLinkLabel_Click(object sender, EventArgs e)
        {
            InitRdpFileComboBox();
        }

        private void uxRdpFileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxRdpFileRadioButton.Checked = true;
        }

        private void uxScreenSizeMenuItem_Click(object sender, EventArgs e)
        {
            var rmi = HandleRadioMenuItem(sender);

            if (rmi == null)
                return;

            uxConnectSplitButton.Text = $"Connect ({rmi.Child.Text})";
        }

        private void uxServerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            uxServerRadioButton.Checked = true;
        }

        private void uxStateTimer_Tick(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void uxWindowSizeMenuItem_Click(object sender, EventArgs e)
        {
            var senderMenuItem = sender as ToolStripMenuItem;
            HandleWindowSizeMenuItemClick(senderMenuItem);
        }

    }

    public class RadioMenuItem
    {
        public ToolStripMenuItem Child { get; set; }
        public ToolStripMenuItem ParentMenuItem { get; set; }
        public ToolStripSplitButton ParentSplitButton { get; set; }
    }
}
