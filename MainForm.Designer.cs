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
            this.uxRdpFileComboBox = new System.Windows.Forms.ComboBox();
            this.uxFullScreenSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.uxMediumSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.uxConnectButton = new System.Windows.Forms.Button();
            this.uxServerFrame = new System.Windows.Forms.GroupBox();
            this.uxRequeryLinkLabel = new System.Windows.Forms.LinkLabel();
            this.uxServerNameTextBox = new System.Windows.Forms.TextBox();
            this.uxServerRadioButton = new System.Windows.Forms.RadioButton();
            this.uxRdpFileRadioButton = new System.Windows.Forms.RadioButton();
            this.uxStoredServerPanel = new System.Windows.Forms.Panel();
            this.uxStoredServerNameTextBox = new System.Windows.Forms.TextBox();
            this.uxStoredServerNameLabel = new System.Windows.Forms.Label();
            this.uxPasswordTextBox = new System.Windows.Forms.TextBox();
            this.uxLoginNameTextBox = new System.Windows.Forms.TextBox();
            this.uxPasswordLabel = new System.Windows.Forms.Label();
            this.uxLoginNameLabel = new System.Windows.Forms.Label();
            this.uxStoredServerRadioButton = new System.Windows.Forms.RadioButton();
            this.uxStoredServerComboBox = new System.Windows.Forms.ComboBox();
            this.uxWindowSizeFrame = new System.Windows.Forms.GroupBox();
            this.uxRecalculateLabel = new System.Windows.Forms.LinkLabel();
            this.uxLargeSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.uxSmallSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.uxStateTimer = new System.Windows.Forms.Timer(this.components);
            this.uxMoreButton = new System.Windows.Forms.Button();
            this.uxMinimizeAndConnectButton = new System.Windows.Forms.Button();
            this.uxServerFrame.SuspendLayout();
            this.uxStoredServerPanel.SuspendLayout();
            this.uxWindowSizeFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxRdpFileComboBox
            // 
            this.uxRdpFileComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxRdpFileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxRdpFileComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRdpFileComboBox.FormattingEnabled = true;
            this.uxRdpFileComboBox.Location = new System.Drawing.Point(26, 42);
            this.uxRdpFileComboBox.Name = "uxRdpFileComboBox";
            this.uxRdpFileComboBox.Size = new System.Drawing.Size(437, 21);
            this.uxRdpFileComboBox.TabIndex = 3;
            this.uxRdpFileComboBox.SelectedIndexChanged += new System.EventHandler(this.uxRdpFileComboBox_SelectedIndexChanged);
            // 
            // uxFullScreenSizeRadioButton
            // 
            this.uxFullScreenSizeRadioButton.AutoSize = true;
            this.uxFullScreenSizeRadioButton.Location = new System.Drawing.Point(12, 19);
            this.uxFullScreenSizeRadioButton.Name = "uxFullScreenSizeRadioButton";
            this.uxFullScreenSizeRadioButton.Size = new System.Drawing.Size(78, 17);
            this.uxFullScreenSizeRadioButton.TabIndex = 8;
            this.uxFullScreenSizeRadioButton.Tag = "/f";
            this.uxFullScreenSizeRadioButton.Text = "Full Screen";
            this.uxFullScreenSizeRadioButton.UseVisualStyleBackColor = true;
            // 
            // uxMediumSizeRadioButton
            // 
            this.uxMediumSizeRadioButton.AutoSize = true;
            this.uxMediumSizeRadioButton.Location = new System.Drawing.Point(12, 65);
            this.uxMediumSizeRadioButton.Name = "uxMediumSizeRadioButton";
            this.uxMediumSizeRadioButton.Size = new System.Drawing.Size(78, 17);
            this.uxMediumSizeRadioButton.TabIndex = 10;
            this.uxMediumSizeRadioButton.Tag = "/w:1280 /h:720";
            this.uxMediumSizeRadioButton.Text = "1280 x 720";
            this.uxMediumSizeRadioButton.UseVisualStyleBackColor = true;
            // 
            // uxConnectButton
            // 
            this.uxConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxConnectButton.Location = new System.Drawing.Point(598, 41);
            this.uxConnectButton.Name = "uxConnectButton";
            this.uxConnectButton.Size = new System.Drawing.Size(138, 23);
            this.uxConnectButton.TabIndex = 13;
            this.uxConnectButton.Text = "Connect";
            this.uxConnectButton.UseVisualStyleBackColor = true;
            this.uxConnectButton.Click += new System.EventHandler(this.uxConnectButton_Click);
            // 
            // uxServerFrame
            // 
            this.uxServerFrame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxServerFrame.Controls.Add(this.uxRequeryLinkLabel);
            this.uxServerFrame.Controls.Add(this.uxServerNameTextBox);
            this.uxServerFrame.Controls.Add(this.uxServerRadioButton);
            this.uxServerFrame.Controls.Add(this.uxRdpFileRadioButton);
            this.uxServerFrame.Controls.Add(this.uxRdpFileComboBox);
            this.uxServerFrame.Location = new System.Drawing.Point(12, 12);
            this.uxServerFrame.Name = "uxServerFrame";
            this.uxServerFrame.Size = new System.Drawing.Size(469, 128);
            this.uxServerFrame.TabIndex = 1;
            this.uxServerFrame.TabStop = false;
            this.uxServerFrame.Text = "Server";
            // 
            // uxRequeryLinkLabel
            // 
            this.uxRequeryLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxRequeryLinkLabel.AutoSize = true;
            this.uxRequeryLinkLabel.Location = new System.Drawing.Point(416, 21);
            this.uxRequeryLinkLabel.Name = "uxRequeryLinkLabel";
            this.uxRequeryLinkLabel.Size = new System.Drawing.Size(47, 13);
            this.uxRequeryLinkLabel.TabIndex = 7;
            this.uxRequeryLinkLabel.TabStop = true;
            this.uxRequeryLinkLabel.Text = "Requery";
            this.uxRequeryLinkLabel.Click += new System.EventHandler(this.uxRequeryLinkLabel_Click);
            // 
            // uxServerNameTextBox
            // 
            this.uxServerNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxServerNameTextBox.Location = new System.Drawing.Point(26, 92);
            this.uxServerNameTextBox.Name = "uxServerNameTextBox";
            this.uxServerNameTextBox.Size = new System.Drawing.Size(437, 20);
            this.uxServerNameTextBox.TabIndex = 6;
            this.uxServerNameTextBox.TextChanged += new System.EventHandler(this.uxServerNameTextBox_TextChanged);
            // 
            // uxServerRadioButton
            // 
            this.uxServerRadioButton.AutoSize = true;
            this.uxServerRadioButton.Location = new System.Drawing.Point(6, 69);
            this.uxServerRadioButton.Name = "uxServerRadioButton";
            this.uxServerRadioButton.Size = new System.Drawing.Size(80, 17);
            this.uxServerRadioButton.TabIndex = 5;
            this.uxServerRadioButton.Text = "This server:";
            this.uxServerRadioButton.UseVisualStyleBackColor = true;
            // 
            // uxRdpFileRadioButton
            // 
            this.uxRdpFileRadioButton.AutoSize = true;
            this.uxRdpFileRadioButton.Checked = true;
            this.uxRdpFileRadioButton.Location = new System.Drawing.Point(6, 19);
            this.uxRdpFileRadioButton.Name = "uxRdpFileRadioButton";
            this.uxRdpFileRadioButton.Size = new System.Drawing.Size(70, 17);
            this.uxRdpFileRadioButton.TabIndex = 2;
            this.uxRdpFileRadioButton.TabStop = true;
            this.uxRdpFileRadioButton.Text = "RDP File:";
            this.uxRdpFileRadioButton.UseVisualStyleBackColor = true;
            // 
            // uxStoredServerPanel
            // 
            this.uxStoredServerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxStoredServerPanel.Controls.Add(this.uxStoredServerNameTextBox);
            this.uxStoredServerPanel.Controls.Add(this.uxStoredServerNameLabel);
            this.uxStoredServerPanel.Controls.Add(this.uxPasswordTextBox);
            this.uxStoredServerPanel.Controls.Add(this.uxLoginNameTextBox);
            this.uxStoredServerPanel.Controls.Add(this.uxPasswordLabel);
            this.uxStoredServerPanel.Controls.Add(this.uxLoginNameLabel);
            this.uxStoredServerPanel.Controls.Add(this.uxStoredServerRadioButton);
            this.uxStoredServerPanel.Controls.Add(this.uxStoredServerComboBox);
            this.uxStoredServerPanel.Location = new System.Drawing.Point(518, 298);
            this.uxStoredServerPanel.Name = "uxStoredServerPanel";
            this.uxStoredServerPanel.Size = new System.Drawing.Size(457, 0);
            this.uxStoredServerPanel.TabIndex = 16;
            // 
            // uxStoredServerNameTextBox
            // 
            this.uxStoredServerNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxStoredServerNameTextBox.Location = new System.Drawing.Point(171, 29);
            this.uxStoredServerNameTextBox.Name = "uxStoredServerNameTextBox";
            this.uxStoredServerNameTextBox.Size = new System.Drawing.Size(286, 20);
            this.uxStoredServerNameTextBox.TabIndex = 23;
            // 
            // uxStoredServerNameLabel
            // 
            this.uxStoredServerNameLabel.AutoSize = true;
            this.uxStoredServerNameLabel.Location = new System.Drawing.Point(98, 32);
            this.uxStoredServerNameLabel.Name = "uxStoredServerNameLabel";
            this.uxStoredServerNameLabel.Size = new System.Drawing.Size(41, 13);
            this.uxStoredServerNameLabel.TabIndex = 22;
            this.uxStoredServerNameLabel.Text = "Server:";
            // 
            // uxPasswordTextBox
            // 
            this.uxPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxPasswordTextBox.Location = new System.Drawing.Point(171, 81);
            this.uxPasswordTextBox.Name = "uxPasswordTextBox";
            this.uxPasswordTextBox.PasswordChar = '*';
            this.uxPasswordTextBox.Size = new System.Drawing.Size(286, 20);
            this.uxPasswordTextBox.TabIndex = 21;
            // 
            // uxLoginNameTextBox
            // 
            this.uxLoginNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxLoginNameTextBox.Location = new System.Drawing.Point(171, 55);
            this.uxLoginNameTextBox.Name = "uxLoginNameTextBox";
            this.uxLoginNameTextBox.Size = new System.Drawing.Size(286, 20);
            this.uxLoginNameTextBox.TabIndex = 20;
            // 
            // uxPasswordLabel
            // 
            this.uxPasswordLabel.AutoSize = true;
            this.uxPasswordLabel.Location = new System.Drawing.Point(97, 84);
            this.uxPasswordLabel.Name = "uxPasswordLabel";
            this.uxPasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.uxPasswordLabel.TabIndex = 19;
            this.uxPasswordLabel.Text = "Password:";
            // 
            // uxLoginNameLabel
            // 
            this.uxLoginNameLabel.AutoSize = true;
            this.uxLoginNameLabel.Location = new System.Drawing.Point(98, 58);
            this.uxLoginNameLabel.Name = "uxLoginNameLabel";
            this.uxLoginNameLabel.Size = new System.Drawing.Size(67, 13);
            this.uxLoginNameLabel.TabIndex = 18;
            this.uxLoginNameLabel.Text = "Login Name:";
            // 
            // uxStoredServerRadioButton
            // 
            this.uxStoredServerRadioButton.AutoSize = true;
            this.uxStoredServerRadioButton.Location = new System.Drawing.Point(0, 3);
            this.uxStoredServerRadioButton.Name = "uxStoredServerRadioButton";
            this.uxStoredServerRadioButton.Size = new System.Drawing.Size(91, 17);
            this.uxStoredServerRadioButton.TabIndex = 16;
            this.uxStoredServerRadioButton.Text = "Stored server:";
            this.uxStoredServerRadioButton.UseVisualStyleBackColor = true;
            // 
            // uxStoredServerComboBox
            // 
            this.uxStoredServerComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxStoredServerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxStoredServerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStoredServerComboBox.FormattingEnabled = true;
            this.uxStoredServerComboBox.Location = new System.Drawing.Point(97, 2);
            this.uxStoredServerComboBox.Name = "uxStoredServerComboBox";
            this.uxStoredServerComboBox.Size = new System.Drawing.Size(360, 21);
            this.uxStoredServerComboBox.TabIndex = 17;
            // 
            // uxWindowSizeFrame
            // 
            this.uxWindowSizeFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxWindowSizeFrame.Controls.Add(this.uxRecalculateLabel);
            this.uxWindowSizeFrame.Controls.Add(this.uxLargeSizeRadioButton);
            this.uxWindowSizeFrame.Controls.Add(this.uxFullScreenSizeRadioButton);
            this.uxWindowSizeFrame.Controls.Add(this.uxSmallSizeRadioButton);
            this.uxWindowSizeFrame.Controls.Add(this.uxMediumSizeRadioButton);
            this.uxWindowSizeFrame.Location = new System.Drawing.Point(487, 12);
            this.uxWindowSizeFrame.Name = "uxWindowSizeFrame";
            this.uxWindowSizeFrame.Size = new System.Drawing.Size(105, 128);
            this.uxWindowSizeFrame.TabIndex = 7;
            this.uxWindowSizeFrame.TabStop = false;
            this.uxWindowSizeFrame.Text = "Window Size";
            // 
            // uxRecalculateLabel
            // 
            this.uxRecalculateLabel.AutoSize = true;
            this.uxRecalculateLabel.Location = new System.Drawing.Point(9, 115);
            this.uxRecalculateLabel.Name = "uxRecalculateLabel";
            this.uxRecalculateLabel.Size = new System.Drawing.Size(64, 13);
            this.uxRecalculateLabel.TabIndex = 12;
            this.uxRecalculateLabel.TabStop = true;
            this.uxRecalculateLabel.Text = "Recalculate";
            this.uxRecalculateLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uxRecalculateLabel_LinkClicked);
            // 
            // uxLargeSizeRadioButton
            // 
            this.uxLargeSizeRadioButton.AutoSize = true;
            this.uxLargeSizeRadioButton.Checked = true;
            this.uxLargeSizeRadioButton.Location = new System.Drawing.Point(12, 42);
            this.uxLargeSizeRadioButton.Name = "uxLargeSizeRadioButton";
            this.uxLargeSizeRadioButton.Size = new System.Drawing.Size(78, 17);
            this.uxLargeSizeRadioButton.TabIndex = 11;
            this.uxLargeSizeRadioButton.TabStop = true;
            this.uxLargeSizeRadioButton.Tag = "/w:1280 /h:720";
            this.uxLargeSizeRadioButton.Text = "1280 x 720";
            this.uxLargeSizeRadioButton.UseVisualStyleBackColor = true;
            // 
            // uxSmallSizeRadioButton
            // 
            this.uxSmallSizeRadioButton.AutoSize = true;
            this.uxSmallSizeRadioButton.Location = new System.Drawing.Point(12, 88);
            this.uxSmallSizeRadioButton.Name = "uxSmallSizeRadioButton";
            this.uxSmallSizeRadioButton.Size = new System.Drawing.Size(84, 17);
            this.uxSmallSizeRadioButton.TabIndex = 9;
            this.uxSmallSizeRadioButton.Tag = "/w:1680 /h:1050";
            this.uxSmallSizeRadioButton.Text = "1680 x 1050";
            this.uxSmallSizeRadioButton.UseVisualStyleBackColor = true;
            // 
            // uxStateTimer
            // 
            this.uxStateTimer.Tick += new System.EventHandler(this.uxStateTimer_Tick);
            // 
            // uxMoreButton
            // 
            this.uxMoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxMoreButton.Location = new System.Drawing.Point(598, 259);
            this.uxMoreButton.Name = "uxMoreButton";
            this.uxMoreButton.Size = new System.Drawing.Size(138, 23);
            this.uxMoreButton.TabIndex = 12;
            this.uxMoreButton.Text = "More";
            this.uxMoreButton.UseVisualStyleBackColor = true;
            this.uxMoreButton.Visible = false;
            this.uxMoreButton.Click += new System.EventHandler(this.uxMoreButton_Click);
            // 
            // uxMinimizeAndConnectButton
            // 
            this.uxMinimizeAndConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxMinimizeAndConnectButton.Location = new System.Drawing.Point(598, 12);
            this.uxMinimizeAndConnectButton.Name = "uxMinimizeAndConnectButton";
            this.uxMinimizeAndConnectButton.Size = new System.Drawing.Size(138, 23);
            this.uxMinimizeAndConnectButton.TabIndex = 12;
            this.uxMinimizeAndConnectButton.Text = "Minimize and Connect";
            this.uxMinimizeAndConnectButton.UseVisualStyleBackColor = true;
            this.uxMinimizeAndConnectButton.Click += new System.EventHandler(this.uxMinimizeAndConnectButton_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.uxMinimizeAndConnectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 151);
            this.Controls.Add(this.uxStoredServerPanel);
            this.Controls.Add(this.uxMinimizeAndConnectButton);
            this.Controls.Add(this.uxMoreButton);
            this.Controls.Add(this.uxWindowSizeFrame);
            this.Controls.Add(this.uxServerFrame);
            this.Controls.Add(this.uxConnectButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(3000, 3000);
            this.MinimumSize = new System.Drawing.Size(438, 27);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Desktopper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ClientSizeChanged += new System.EventHandler(this.MainForm_ClientSizeChanged);
            this.uxServerFrame.ResumeLayout(false);
            this.uxServerFrame.PerformLayout();
            this.uxStoredServerPanel.ResumeLayout(false);
            this.uxStoredServerPanel.PerformLayout();
            this.uxWindowSizeFrame.ResumeLayout(false);
            this.uxWindowSizeFrame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox uxRdpFileComboBox;
        private System.Windows.Forms.RadioButton uxFullScreenSizeRadioButton;
        private System.Windows.Forms.RadioButton uxMediumSizeRadioButton;
        private System.Windows.Forms.Button uxConnectButton;
        private System.Windows.Forms.GroupBox uxServerFrame;
        private System.Windows.Forms.TextBox uxServerNameTextBox;
        private System.Windows.Forms.RadioButton uxServerRadioButton;
        private System.Windows.Forms.RadioButton uxRdpFileRadioButton;
        private System.Windows.Forms.GroupBox uxWindowSizeFrame;
        private System.Windows.Forms.RadioButton uxSmallSizeRadioButton;
        private System.Windows.Forms.Timer uxStateTimer;
        private System.Windows.Forms.RadioButton uxLargeSizeRadioButton;
        private System.Windows.Forms.LinkLabel uxRequeryLinkLabel;
        private System.Windows.Forms.LinkLabel uxRecalculateLabel;
        private System.Windows.Forms.Panel uxStoredServerPanel;
        private System.Windows.Forms.TextBox uxStoredServerNameTextBox;
        private System.Windows.Forms.Label uxStoredServerNameLabel;
        private System.Windows.Forms.TextBox uxPasswordTextBox;
        private System.Windows.Forms.TextBox uxLoginNameTextBox;
        private System.Windows.Forms.Label uxPasswordLabel;
        private System.Windows.Forms.Label uxLoginNameLabel;
        private System.Windows.Forms.RadioButton uxStoredServerRadioButton;
        private System.Windows.Forms.ComboBox uxStoredServerComboBox;
        private System.Windows.Forms.Button uxMoreButton;
        private System.Windows.Forms.Button uxMinimizeAndConnectButton;
    }
}

