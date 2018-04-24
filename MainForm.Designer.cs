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
            this.uxRdpFileComboBox.Location = new System.Drawing.Point(3, 21);
            this.uxRdpFileComboBox.Name = "uxRdpFileComboBox";
            this.uxRdpFileComboBox.Size = new System.Drawing.Size(606, 21);
            this.uxRdpFileComboBox.TabIndex = 1;
            this.uxRdpFileComboBox.SelectedIndexChanged += new System.EventHandler(this.uxRdpFileComboBox_SelectedIndexChanged);
            // 
            // uxConnectButton
            // 
            this.uxConnectButton.Location = new System.Drawing.Point(356, 93);
            this.uxConnectButton.Name = "uxConnectButton";
            this.uxConnectButton.Size = new System.Drawing.Size(138, 23);
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
            this.uxFavoritePropertiesLinkLabel.Location = new System.Drawing.Point(561, 7);
            this.uxFavoritePropertiesLinkLabel.Name = "uxFavoritePropertiesLinkLabel";
            this.uxFavoritePropertiesLinkLabel.Size = new System.Drawing.Size(54, 13);
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
            this.uxFavoritesSplitContainer.Location = new System.Drawing.Point(3, 24);
            this.uxFavoritesSplitContainer.Name = "uxFavoritesSplitContainer";
            // 
            // uxFavoritesSplitContainer.Panel1
            // 
            this.uxFavoritesSplitContainer.Panel1.Controls.Add(this.uxFavoriteGroupsComboBox);
            // 
            // uxFavoritesSplitContainer.Panel2
            // 
            this.uxFavoritesSplitContainer.Panel2.Controls.Add(this.uxFavoriteMachineComboBox);
            this.uxFavoritesSplitContainer.Size = new System.Drawing.Size(612, 23);
            this.uxFavoritesSplitContainer.SplitterDistance = 161;
            this.uxFavoritesSplitContainer.TabIndex = 5;
            // 
            // uxFavoriteGroupsComboBox
            // 
            this.uxFavoriteGroupsComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxFavoriteGroupsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxFavoriteGroupsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFavoriteGroupsComboBox.FormattingEnabled = true;
            this.uxFavoriteGroupsComboBox.Location = new System.Drawing.Point(0, 0);
            this.uxFavoriteGroupsComboBox.Name = "uxFavoriteGroupsComboBox";
            this.uxFavoriteGroupsComboBox.Size = new System.Drawing.Size(161, 21);
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
            this.uxFavoriteMachineComboBox.Name = "uxFavoriteMachineComboBox";
            this.uxFavoriteMachineComboBox.Size = new System.Drawing.Size(447, 21);
            this.uxFavoriteMachineComboBox.TabIndex = 4;
            this.uxFavoriteMachineComboBox.SelectedIndexChanged += new System.EventHandler(this.uxFavoriteComboBox_SelectedIndexChanged);
            // 
            // uxFavoritesTimestampLabel
            // 
            this.uxFavoritesTimestampLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxFavoritesTimestampLabel.Location = new System.Drawing.Point(401, 7);
            this.uxFavoritesTimestampLabel.Name = "uxFavoritesTimestampLabel";
            this.uxFavoritesTimestampLabel.Size = new System.Drawing.Size(101, 14);
            this.uxFavoritesTimestampLabel.TabIndex = 9;
            this.uxFavoritesTimestampLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // uxRequeryFavoritesLinkLabel
            // 
            this.uxRequeryFavoritesLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxRequeryFavoritesLinkLabel.AutoSize = true;
            this.uxRequeryFavoritesLinkLabel.Location = new System.Drawing.Point(508, 7);
            this.uxRequeryFavoritesLinkLabel.Name = "uxRequeryFavoritesLinkLabel";
            this.uxRequeryFavoritesLinkLabel.Size = new System.Drawing.Size(47, 13);
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
            this.uxPasteServerNameLabel.Location = new System.Drawing.Point(575, 5);
            this.uxPasteServerNameLabel.Name = "uxPasteServerNameLabel";
            this.uxPasteServerNameLabel.Size = new System.Drawing.Size(34, 13);
            this.uxPasteServerNameLabel.TabIndex = 7;
            this.uxPasteServerNameLabel.TabStop = true;
            this.uxPasteServerNameLabel.Text = "Paste";
            this.uxPasteServerNameLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uxPasteServerNameLabel_LinkClicked);
            // 
            // uxRequeryRdpLinkLabel
            // 
            this.uxRequeryRdpLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxRequeryRdpLinkLabel.AutoSize = true;
            this.uxRequeryRdpLinkLabel.Location = new System.Drawing.Point(562, 5);
            this.uxRequeryRdpLinkLabel.Name = "uxRequeryRdpLinkLabel";
            this.uxRequeryRdpLinkLabel.Size = new System.Drawing.Size(47, 13);
            this.uxRequeryRdpLinkLabel.TabIndex = 2;
            this.uxRequeryRdpLinkLabel.TabStop = true;
            this.uxRequeryRdpLinkLabel.Text = "Requery";
            this.uxRequeryRdpLinkLabel.Click += new System.EventHandler(this.uxRequeryRdpLinkLabel_Click);
            // 
            // uxServerNameTextBox
            // 
            this.uxServerNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxServerNameTextBox.Location = new System.Drawing.Point(3, 21);
            this.uxServerNameTextBox.Name = "uxServerNameTextBox";
            this.uxServerNameTextBox.Size = new System.Drawing.Size(606, 20);
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
            this.uxConnectSplitButton});
            this.uxToolStrip.Location = new System.Drawing.Point(0, 0);
            this.uxToolStrip.Name = "uxToolStrip";
            this.uxToolStrip.Size = new System.Drawing.Size(624, 27);
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
            this.uxOptionMenu.Size = new System.Drawing.Size(62, 24);
            this.uxOptionMenu.Text = "Favorite";
            // 
            // uxFavoriteMenuItem
            // 
            this.uxFavoriteMenuItem.Checked = true;
            this.uxFavoriteMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uxFavoriteMenuItem.Name = "uxFavoriteMenuItem";
            this.uxFavoriteMenuItem.Size = new System.Drawing.Size(117, 22);
            this.uxFavoriteMenuItem.Text = "Favorite";
            this.uxFavoriteMenuItem.Click += new System.EventHandler(this.uxOptionMenuItem_Click);
            // 
            // uxRdpFileMenuItem
            // 
            this.uxRdpFileMenuItem.Name = "uxRdpFileMenuItem";
            this.uxRdpFileMenuItem.Size = new System.Drawing.Size(117, 22);
            this.uxRdpFileMenuItem.Text = "RDP File";
            this.uxRdpFileMenuItem.Click += new System.EventHandler(this.uxOptionMenuItem_Click);
            // 
            // uxManualMenuItem
            // 
            this.uxManualMenuItem.Name = "uxManualMenuItem";
            this.uxManualMenuItem.Size = new System.Drawing.Size(117, 22);
            this.uxManualMenuItem.Text = "Manual";
            this.uxManualMenuItem.Click += new System.EventHandler(this.uxOptionMenuItem_Click);
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
            this.uxConnectSplitButton.Size = new System.Drawing.Size(88, 24);
            this.uxConnectSplitButton.Text = "Connect";
            this.uxConnectSplitButton.ButtonClick += new System.EventHandler(this.uxConnectSplitButton_ButtonClick);
            // 
            // uxFullScreenMenuItem
            // 
            this.uxFullScreenMenuItem.Name = "uxFullScreenMenuItem";
            this.uxFullScreenMenuItem.Size = new System.Drawing.Size(178, 22);
            this.uxFullScreenMenuItem.Text = "Full Screen";
            this.uxFullScreenMenuItem.Click += new System.EventHandler(this.uxScreenSizeMenuItem_Click);
            // 
            // uxAllMonitorsMenuItem
            // 
            this.uxAllMonitorsMenuItem.Name = "uxAllMonitorsMenuItem";
            this.uxAllMonitorsMenuItem.Size = new System.Drawing.Size(178, 22);
            this.uxAllMonitorsMenuItem.Text = "All Monitors";
            this.uxAllMonitorsMenuItem.Click += new System.EventHandler(this.uxScreenSizeMenuItem_Click);
            // 
            // uxLargestWindowMenuItem
            // 
            this.uxLargestWindowMenuItem.Checked = true;
            this.uxLargestWindowMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uxLargestWindowMenuItem.Name = "uxLargestWindowMenuItem";
            this.uxLargestWindowMenuItem.Size = new System.Drawing.Size(178, 22);
            this.uxLargestWindowMenuItem.Tag = "Largest Window";
            this.uxLargestWindowMenuItem.Text = "Largest Window";
            this.uxLargestWindowMenuItem.Click += new System.EventHandler(this.uxScreenSizeMenuItem_Click);
            // 
            // uxFullScreenWindowMenuItem
            // 
            this.uxFullScreenWindowMenuItem.Name = "uxFullScreenWindowMenuItem";
            this.uxFullScreenWindowMenuItem.Size = new System.Drawing.Size(178, 22);
            this.uxFullScreenWindowMenuItem.Tag = "Full Screen Window";
            this.uxFullScreenWindowMenuItem.Text = "Full Screen Window";
            this.uxFullScreenWindowMenuItem.Click += new System.EventHandler(this.uxScreenSizeMenuItem_Click);
            // 
            // uxFavoritePanel
            // 
            this.uxFavoritePanel.Controls.Add(this.uxFavoritesTimestampLabel);
            this.uxFavoritePanel.Controls.Add(this.uxFavoritesSplitContainer);
            this.uxFavoritePanel.Controls.Add(this.uxFavoritePropertiesLinkLabel);
            this.uxFavoritePanel.Controls.Add(this.uxRequeryFavoritesLinkLabel);
            this.uxFavoritePanel.Location = new System.Drawing.Point(3, 28);
            this.uxFavoritePanel.Name = "uxFavoritePanel";
            this.uxFavoritePanel.Size = new System.Drawing.Size(618, 50);
            this.uxFavoritePanel.TabIndex = 7;
            // 
            // uxRdpFilePanel
            // 
            this.uxRdpFilePanel.Controls.Add(this.uxRdpFileComboBox);
            this.uxRdpFilePanel.Controls.Add(this.uxRequeryRdpLinkLabel);
            this.uxRdpFilePanel.Location = new System.Drawing.Point(6, 136);
            this.uxRdpFilePanel.Name = "uxRdpFilePanel";
            this.uxRdpFilePanel.Size = new System.Drawing.Size(618, 47);
            this.uxRdpFilePanel.TabIndex = 8;
            this.uxRdpFilePanel.Visible = false;
            // 
            // uxManualPanel
            // 
            this.uxManualPanel.Controls.Add(this.uxPasteServerNameLabel);
            this.uxManualPanel.Controls.Add(this.uxServerNameTextBox);
            this.uxManualPanel.Location = new System.Drawing.Point(6, 199);
            this.uxManualPanel.Name = "uxManualPanel";
            this.uxManualPanel.Size = new System.Drawing.Size(618, 45);
            this.uxManualPanel.TabIndex = 9;
            this.uxManualPanel.Visible = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.uxConnectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 81);
            this.Controls.Add(this.uxManualPanel);
            this.Controls.Add(this.uxRdpFilePanel);
            this.Controls.Add(this.uxFavoritePanel);
            this.Controls.Add(this.uxToolStrip);
            this.Controls.Add(this.uxConnectButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(3000, 120);
            this.MinimumSize = new System.Drawing.Size(438, 120);
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
    }
}

