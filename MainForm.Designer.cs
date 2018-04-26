namespace RemoteDesktopper
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.uxRdpFileComboBox = new System.Windows.Forms.ComboBox();
            this.uxConnectButton = new System.Windows.Forms.Button();
            this.uxFavoritePropertiesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.uxFavoritesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.uxFavoriteGroupsComboBox = new System.Windows.Forms.ComboBox();
            this.uxFavoriteMachineComboBox = new System.Windows.Forms.ComboBox();
            this.uxFavoritesTimestampLabel = new System.Windows.Forms.Label();
            this.uxRequeryFavoritesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.uxPasteServerNameLabel = new System.Windows.Forms.LinkLabel();
            this.uxRequeryRdpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.uxServerNameTextBox = new System.Windows.Forms.TextBox();
            this.uxStateTimer = new System.Windows.Forms.Timer(this.components);
            this.uxToolStrip = new System.Windows.Forms.ToolStrip();
            this.uxOptionMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.uxFavoriteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxRdpFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxManualMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxConnectSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.uxFullScreenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxAllMonitorsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxLargestWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxFullScreenWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxRequeryButton = new System.Windows.Forms.ToolStripButton();
            this.uxPropertiesButton = new System.Windows.Forms.ToolStripButton();
            this.uxPasteButton = new System.Windows.Forms.ToolStripButton();
            this.uxFavoritePanel = new System.Windows.Forms.Panel();
            this.uxRdpFilePanel = new System.Windows.Forms.Panel();
            this.uxManualPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.uxFavoritesSplitContainer)).BeginInit();
            this.uxFavoritesSplitContainer.Panel1.SuspendLayout();
            this.uxFavoritesSplitContainer.Panel2.SuspendLayout();
            this.uxFavoritesSplitContainer.SuspendLayout();
            this.uxToolStrip.SuspendLayout();
            this.uxFavoritePanel.SuspendLayout();
            this.uxRdpFilePanel.SuspendLayout();
            this.uxManualPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxRdpFileComboBox
            // 
            this.uxRdpFileComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxRdpFileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxRdpFileComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRdpFileComboBox.FormattingEnabled = true;
            this.uxRdpFileComboBox.Location = new System.Drawing.Point(8, 4);
            this.uxRdpFileComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.uxRdpFileComboBox.Name = "uxRdpFileComboBox";
            this.uxRdpFileComboBox.Size = new System.Drawing.Size(807, 25);
            this.uxRdpFileComboBox.TabIndex = 1;
            this.uxRdpFileComboBox.SelectedIndexChanged += new System.EventHandler(this.uxRdpFileComboBox_SelectedIndexChanged);
            // 
            // uxConnectButton
            // 
            this.uxConnectButton.Location = new System.Drawing.Point(291, 185);
            this.uxConnectButton.Margin = new System.Windows.Forms.Padding(4);
            this.uxConnectButton.Name = "uxConnectButton";
            this.uxConnectButton.Size = new System.Drawing.Size(184, 28);
            this.uxConnectButton.TabIndex = 4;
            this.uxConnectButton.Text = "Connect";
            this.uxConnectButton.UseVisualStyleBackColor = true;
            this.uxConnectButton.Visible = false;
            this.uxConnectButton.Click += new System.EventHandler(this.uxConnectButton_Click);
            // 
            // uxFavoritePropertiesLinkLabel
            // 
            this.uxFavoritePropertiesLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxFavoritePropertiesLinkLabel.AutoSize = true;
            this.uxFavoritePropertiesLinkLabel.Location = new System.Drawing.Point(740, 84);
            this.uxFavoritePropertiesLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxFavoritePropertiesLinkLabel.Name = "uxFavoritePropertiesLinkLabel";
            this.uxFavoritePropertiesLinkLabel.Size = new System.Drawing.Size(73, 17);
            this.uxFavoritePropertiesLinkLabel.TabIndex = 10;
            this.uxFavoritePropertiesLinkLabel.TabStop = true;
            this.uxFavoritePropertiesLinkLabel.Text = "Properties";
            this.uxFavoritePropertiesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uxFavoritePropertiesLinkLabel_LinkClicked);
            // 
            // uxFavoritesSplitContainer
            // 
            this.uxFavoritesSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxFavoritesSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.uxFavoritesSplitContainer.Location = new System.Drawing.Point(4, 4);
            this.uxFavoritesSplitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.uxFavoritesSplitContainer.Name = "uxFavoritesSplitContainer";
            // 
            // uxFavoritesSplitContainer.Panel1
            // 
            this.uxFavoritesSplitContainer.Panel1.Controls.Add(this.uxFavoriteGroupsComboBox);
            // 
            // uxFavoritesSplitContainer.Panel2
            // 
            this.uxFavoritesSplitContainer.Panel2.Controls.Add(this.uxFavoriteMachineComboBox);
            this.uxFavoritesSplitContainer.Size = new System.Drawing.Size(816, 28);
            this.uxFavoritesSplitContainer.SplitterDistance = 161;
            this.uxFavoritesSplitContainer.SplitterWidth = 5;
            this.uxFavoritesSplitContainer.TabIndex = 5;
            // 
            // uxFavoriteGroupsComboBox
            // 
            this.uxFavoriteGroupsComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxFavoriteGroupsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxFavoriteGroupsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFavoriteGroupsComboBox.FormattingEnabled = true;
            this.uxFavoriteGroupsComboBox.Location = new System.Drawing.Point(0, 0);
            this.uxFavoriteGroupsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.uxFavoriteGroupsComboBox.Name = "uxFavoriteGroupsComboBox";
            this.uxFavoriteGroupsComboBox.Size = new System.Drawing.Size(161, 25);
            this.uxFavoriteGroupsComboBox.TabIndex = 10;
            this.uxFavoriteGroupsComboBox.SelectedIndexChanged += new System.EventHandler(this.uxFavoriteGroupsComboBox_SelectedIndexChanged);
            // 
            // uxFavoriteMachineComboBox
            // 
            this.uxFavoriteMachineComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxFavoriteMachineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxFavoriteMachineComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFavoriteMachineComboBox.FormattingEnabled = true;
            this.uxFavoriteMachineComboBox.Location = new System.Drawing.Point(0, 0);
            this.uxFavoriteMachineComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.uxFavoriteMachineComboBox.Name = "uxFavoriteMachineComboBox";
            this.uxFavoriteMachineComboBox.Size = new System.Drawing.Size(650, 25);
            this.uxFavoriteMachineComboBox.TabIndex = 4;
            this.uxFavoriteMachineComboBox.SelectedIndexChanged += new System.EventHandler(this.uxFavoriteComboBox_SelectedIndexChanged);
            // 
            // uxFavoritesTimestampLabel
            // 
            this.uxFavoritesTimestampLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxFavoritesTimestampLabel.Location = new System.Drawing.Point(527, 84);
            this.uxFavoritesTimestampLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxFavoritesTimestampLabel.Name = "uxFavoritesTimestampLabel";
            this.uxFavoritesTimestampLabel.Size = new System.Drawing.Size(135, 17);
            this.uxFavoritesTimestampLabel.TabIndex = 9;
            this.uxFavoritesTimestampLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // uxRequeryFavoritesLinkLabel
            // 
            this.uxRequeryFavoritesLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxRequeryFavoritesLinkLabel.AutoSize = true;
            this.uxRequeryFavoritesLinkLabel.Location = new System.Drawing.Point(669, 84);
            this.uxRequeryFavoritesLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxRequeryFavoritesLinkLabel.Name = "uxRequeryFavoritesLinkLabel";
            this.uxRequeryFavoritesLinkLabel.Size = new System.Drawing.Size(62, 17);
            this.uxRequeryFavoritesLinkLabel.TabIndex = 8;
            this.uxRequeryFavoritesLinkLabel.TabStop = true;
            this.uxRequeryFavoritesLinkLabel.Text = "Requery";
            this.uxRequeryFavoritesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uxRequeryFavoritesLinkLabel_LinkClicked);
            this.uxRequeryFavoritesLinkLabel.Click += new System.EventHandler(this.uxRequeryFavoritesLinkLabel_Click);
            // 
            // uxPasteServerNameLabel
            // 
            this.uxPasteServerNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxPasteServerNameLabel.AutoSize = true;
            this.uxPasteServerNameLabel.Location = new System.Drawing.Point(763, 46);
            this.uxPasteServerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxPasteServerNameLabel.Name = "uxPasteServerNameLabel";
            this.uxPasteServerNameLabel.Size = new System.Drawing.Size(44, 17);
            this.uxPasteServerNameLabel.TabIndex = 7;
            this.uxPasteServerNameLabel.TabStop = true;
            this.uxPasteServerNameLabel.Text = "Paste";
            this.uxPasteServerNameLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uxPasteServerNameLabel_LinkClicked);
            // 
            // uxRequeryRdpLinkLabel
            // 
            this.uxRequeryRdpLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxRequeryRdpLinkLabel.AutoSize = true;
            this.uxRequeryRdpLinkLabel.Location = new System.Drawing.Point(745, 55);
            this.uxRequeryRdpLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxRequeryRdpLinkLabel.Name = "uxRequeryRdpLinkLabel";
            this.uxRequeryRdpLinkLabel.Size = new System.Drawing.Size(62, 17);
            this.uxRequeryRdpLinkLabel.TabIndex = 2;
            this.uxRequeryRdpLinkLabel.TabStop = true;
            this.uxRequeryRdpLinkLabel.Text = "Requery";
            this.uxRequeryRdpLinkLabel.Click += new System.EventHandler(this.uxRequeryRdpLinkLabel_Click);
            // 
            // uxServerNameTextBox
            // 
            this.uxServerNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxServerNameTextBox.Location = new System.Drawing.Point(8, 5);
            this.uxServerNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.uxServerNameTextBox.Name = "uxServerNameTextBox";
            this.uxServerNameTextBox.Size = new System.Drawing.Size(807, 22);
            this.uxServerNameTextBox.TabIndex = 6;
            this.uxServerNameTextBox.TextChanged += new System.EventHandler(this.uxServerNameTextBox_TextChanged);
            // 
            // uxStateTimer
            // 
            this.uxStateTimer.Tick += new System.EventHandler(this.uxStateTimer_Tick);
            // 
            // uxToolStrip
            // 
            this.uxToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uxToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOptionMenu,
            this.uxConnectSplitButton,
            this.uxRequeryButton,
            this.uxPropertiesButton,
            this.uxPasteButton});
            this.uxToolStrip.Location = new System.Drawing.Point(0, 0);
            this.uxToolStrip.Name = "uxToolStrip";
            this.uxToolStrip.Size = new System.Drawing.Size(832, 27);
            this.uxToolStrip.TabIndex = 5;
            this.uxToolStrip.Text = "Tool Strip";
            // 
            // uxOptionMenu
            // 
            this.uxOptionMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uxOptionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFavoriteMenuItem,
            this.uxRdpFileMenuItem,
            this.uxManualMenuItem});
            this.uxOptionMenu.Image = ((System.Drawing.Image)(resources.GetObject("uxOptionMenu.Image")));
            this.uxOptionMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxOptionMenu.Name = "uxOptionMenu";
            this.uxOptionMenu.Size = new System.Drawing.Size(75, 24);
            this.uxOptionMenu.Text = "Favorite";
            // 
            // uxFavoriteMenuItem
            // 
            this.uxFavoriteMenuItem.Name = "uxFavoriteMenuItem";
            this.uxFavoriteMenuItem.Size = new System.Drawing.Size(216, 26);
            this.uxFavoriteMenuItem.Text = "Favorite";
            this.uxFavoriteMenuItem.Click += new System.EventHandler(this.uxServerOptionMenuItem_Click);
            // 
            // uxRdpFileMenuItem
            // 
            this.uxRdpFileMenuItem.Name = "uxRdpFileMenuItem";
            this.uxRdpFileMenuItem.Size = new System.Drawing.Size(216, 26);
            this.uxRdpFileMenuItem.Text = "RDP File";
            this.uxRdpFileMenuItem.Click += new System.EventHandler(this.uxServerOptionMenuItem_Click);
            // 
            // uxManualMenuItem
            // 
            this.uxManualMenuItem.Name = "uxManualMenuItem";
            this.uxManualMenuItem.Size = new System.Drawing.Size(216, 26);
            this.uxManualMenuItem.Text = "Manual";
            this.uxManualMenuItem.Click += new System.EventHandler(this.uxServerOptionMenuItem_Click);
            // 
            // uxConnectSplitButton
            // 
            this.uxConnectSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFullScreenMenuItem,
            this.uxAllMonitorsMenuItem,
            this.uxLargestWindowMenuItem,
            this.uxFullScreenWindowMenuItem});
            this.uxConnectSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("uxConnectSplitButton.Image")));
            this.uxConnectSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxConnectSplitButton.Name = "uxConnectSplitButton";
            this.uxConnectSplitButton.Size = new System.Drawing.Size(102, 24);
            this.uxConnectSplitButton.Text = "Connect";
            this.uxConnectSplitButton.ButtonClick += new System.EventHandler(this.uxConnectSplitButton_ButtonClick);
            // 
            // uxFullScreenMenuItem
            // 
            this.uxFullScreenMenuItem.Name = "uxFullScreenMenuItem";
            this.uxFullScreenMenuItem.Size = new System.Drawing.Size(214, 26);
            this.uxFullScreenMenuItem.Text = "Full Screen";
            this.uxFullScreenMenuItem.Click += new System.EventHandler(this.uxScreenSizeMenuItem_Click);
            // 
            // uxAllMonitorsMenuItem
            // 
            this.uxAllMonitorsMenuItem.Name = "uxAllMonitorsMenuItem";
            this.uxAllMonitorsMenuItem.Size = new System.Drawing.Size(214, 26);
            this.uxAllMonitorsMenuItem.Text = "All Monitors";
            this.uxAllMonitorsMenuItem.Click += new System.EventHandler(this.uxScreenSizeMenuItem_Click);
            // 
            // uxLargestWindowMenuItem
            // 
            this.uxLargestWindowMenuItem.Checked = true;
            this.uxLargestWindowMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uxLargestWindowMenuItem.Name = "uxLargestWindowMenuItem";
            this.uxLargestWindowMenuItem.Size = new System.Drawing.Size(214, 26);
            this.uxLargestWindowMenuItem.Tag = "Largest Window";
            this.uxLargestWindowMenuItem.Text = "Largest Window";
            this.uxLargestWindowMenuItem.Click += new System.EventHandler(this.uxScreenSizeMenuItem_Click);
            // 
            // uxFullScreenWindowMenuItem
            // 
            this.uxFullScreenWindowMenuItem.Name = "uxFullScreenWindowMenuItem";
            this.uxFullScreenWindowMenuItem.Size = new System.Drawing.Size(214, 26);
            this.uxFullScreenWindowMenuItem.Tag = "Full Screen Window";
            this.uxFullScreenWindowMenuItem.Text = "Full Screen Window";
            this.uxFullScreenWindowMenuItem.Click += new System.EventHandler(this.uxScreenSizeMenuItem_Click);
            // 
            // uxRequeryButton
            // 
            this.uxRequeryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uxRequeryButton.Image = ((System.Drawing.Image)(resources.GetObject("uxRequeryButton.Image")));
            this.uxRequeryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxRequeryButton.Name = "uxRequeryButton";
            this.uxRequeryButton.Size = new System.Drawing.Size(24, 24);
            this.uxRequeryButton.Text = "Requery";
            this.uxRequeryButton.Click += new System.EventHandler(this.uxRequeryButton_Click);
            // 
            // uxPropertiesButton
            // 
            this.uxPropertiesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uxPropertiesButton.Image = ((System.Drawing.Image)(resources.GetObject("uxPropertiesButton.Image")));
            this.uxPropertiesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxPropertiesButton.Name = "uxPropertiesButton";
            this.uxPropertiesButton.Size = new System.Drawing.Size(24, 24);
            this.uxPropertiesButton.Text = "Properties";
            this.uxPropertiesButton.Click += new System.EventHandler(this.uxPropertiesButton_Click);
            // 
            // uxPasteButton
            // 
            this.uxPasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uxPasteButton.Image = ((System.Drawing.Image)(resources.GetObject("uxPasteButton.Image")));
            this.uxPasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxPasteButton.Name = "uxPasteButton";
            this.uxPasteButton.Size = new System.Drawing.Size(24, 24);
            this.uxPasteButton.Text = "Paste";
            this.uxPasteButton.Click += new System.EventHandler(this.uxPasteButton_Click);
            // 
            // uxFavoritePanel
            // 
            this.uxFavoritePanel.Controls.Add(this.uxFavoritesTimestampLabel);
            this.uxFavoritePanel.Controls.Add(this.uxFavoritesSplitContainer);
            this.uxFavoritePanel.Controls.Add(this.uxFavoritePropertiesLinkLabel);
            this.uxFavoritePanel.Controls.Add(this.uxRequeryFavoritesLinkLabel);
            this.uxFavoritePanel.Location = new System.Drawing.Point(4, 34);
            this.uxFavoritePanel.Margin = new System.Windows.Forms.Padding(4);
            this.uxFavoritePanel.Name = "uxFavoritePanel";
            this.uxFavoritePanel.Size = new System.Drawing.Size(824, 37);
            this.uxFavoritePanel.TabIndex = 7;
            // 
            // uxRdpFilePanel
            // 
            this.uxRdpFilePanel.Controls.Add(this.uxRdpFileComboBox);
            this.uxRdpFilePanel.Controls.Add(this.uxRequeryRdpLinkLabel);
            this.uxRdpFilePanel.Location = new System.Drawing.Point(8, 247);
            this.uxRdpFilePanel.Margin = new System.Windows.Forms.Padding(4);
            this.uxRdpFilePanel.Name = "uxRdpFilePanel";
            this.uxRdpFilePanel.Size = new System.Drawing.Size(824, 37);
            this.uxRdpFilePanel.TabIndex = 8;
            this.uxRdpFilePanel.Visible = false;
            // 
            // uxManualPanel
            // 
            this.uxManualPanel.Controls.Add(this.uxPasteServerNameLabel);
            this.uxManualPanel.Controls.Add(this.uxServerNameTextBox);
            this.uxManualPanel.Location = new System.Drawing.Point(8, 319);
            this.uxManualPanel.Margin = new System.Windows.Forms.Padding(4);
            this.uxManualPanel.Name = "uxManualPanel";
            this.uxManualPanel.Size = new System.Drawing.Size(824, 33);
            this.uxManualPanel.TabIndex = 9;
            this.uxManualPanel.Visible = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.uxConnectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 75);
            this.Controls.Add(this.uxManualPanel);
            this.Controls.Add(this.uxRdpFilePanel);
            this.Controls.Add(this.uxFavoritePanel);
            this.Controls.Add(this.uxToolStrip);
            this.Controls.Add(this.uxConnectButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(3994, 3679);
            this.MinimumSize = new System.Drawing.Size(578, 110);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Remote Desktopper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.uxFavoritesSplitContainer.Panel1.ResumeLayout(false);
            this.uxFavoritesSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxFavoritesSplitContainer)).EndInit();
            this.uxFavoritesSplitContainer.ResumeLayout(false);
            this.uxToolStrip.ResumeLayout(false);
            this.uxToolStrip.PerformLayout();
            this.uxFavoritePanel.ResumeLayout(false);
            this.uxFavoritePanel.PerformLayout();
            this.uxRdpFilePanel.ResumeLayout(false);
            this.uxRdpFilePanel.PerformLayout();
            this.uxManualPanel.ResumeLayout(false);
            this.uxManualPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uxRdpFileComboBox;
        private System.Windows.Forms.Button uxConnectButton;
        private System.Windows.Forms.TextBox uxServerNameTextBox;
        private System.Windows.Forms.Timer uxStateTimer;
        private System.Windows.Forms.LinkLabel uxRequeryRdpLinkLabel;
        private System.Windows.Forms.ComboBox uxFavoriteMachineComboBox;
        private System.Windows.Forms.LinkLabel uxPasteServerNameLabel;
        private System.Windows.Forms.LinkLabel uxRequeryFavoritesLinkLabel;
        private System.Windows.Forms.Label uxFavoritesTimestampLabel;
        private System.Windows.Forms.ComboBox uxFavoriteGroupsComboBox;
        private System.Windows.Forms.SplitContainer uxFavoritesSplitContainer;
        private System.Windows.Forms.LinkLabel uxFavoritePropertiesLinkLabel;
        private System.Windows.Forms.ToolStrip uxToolStrip;
        private System.Windows.Forms.ToolStripSplitButton uxConnectSplitButton;
        private System.Windows.Forms.ToolStripMenuItem uxFullScreenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxLargestWindowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxAllMonitorsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxFullScreenWindowMenuItem;
        private System.Windows.Forms.Panel uxFavoritePanel;
        private System.Windows.Forms.Panel uxRdpFilePanel;
        private System.Windows.Forms.Panel uxManualPanel;
        private System.Windows.Forms.ToolStripDropDownButton uxOptionMenu;
        private System.Windows.Forms.ToolStripMenuItem uxFavoriteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxRdpFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxManualMenuItem;
        private System.Windows.Forms.ToolStripButton uxRequeryButton;
        private System.Windows.Forms.ToolStripButton uxPropertiesButton;
        private System.Windows.Forms.ToolStripButton uxPasteButton;
    }
}

