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
            this.uxConnectButton = new System.Windows.Forms.Button();
            this.uxServerFrame = new System.Windows.Forms.GroupBox();
            this.uxFavoriteGroupsComboBox = new System.Windows.Forms.ComboBox();
            this.uxFavoritesTimestampLabel = new System.Windows.Forms.Label();
            this.uxRequeryFavoritesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.uxPasteServerNameLabel = new System.Windows.Forms.LinkLabel();
            this.uxFavoriteMachineComboBox = new System.Windows.Forms.ComboBox();
            this.uxFavoriteRadioButton = new System.Windows.Forms.RadioButton();
            this.uxRequeryRdpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.uxServerNameTextBox = new System.Windows.Forms.TextBox();
            this.uxServerRadioButton = new System.Windows.Forms.RadioButton();
            this.uxRdpFileRadioButton = new System.Windows.Forms.RadioButton();
            this.uxWindowSizeFrame = new System.Windows.Forms.GroupBox();
            this.uxFullScreenWindowComboBox = new System.Windows.Forms.ComboBox();
            this.uxFullScreenWindowRadioButton = new System.Windows.Forms.RadioButton();
            this.uxLargestWindowComboBox = new System.Windows.Forms.ComboBox();
            this.uxLargestWindowRadioButton = new System.Windows.Forms.RadioButton();
            this.uxRecalculateLabel = new System.Windows.Forms.LinkLabel();
            this.uxStateTimer = new System.Windows.Forms.Timer(this.components);
            this.uxMinimizeAndConnectButton = new System.Windows.Forms.Button();
            this.uxServerFrame.SuspendLayout();
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
            this.uxRdpFileComboBox.Location = new System.Drawing.Point(25, 38);
            this.uxRdpFileComboBox.Name = "uxRdpFileComboBox";
            this.uxRdpFileComboBox.Size = new System.Drawing.Size(444, 21);
            this.uxRdpFileComboBox.TabIndex = 1;
            this.uxRdpFileComboBox.SelectedIndexChanged += new System.EventHandler(this.uxRdpFileComboBox_SelectedIndexChanged);
            // 
            // uxFullScreenSizeRadioButton
            // 
            this.uxFullScreenSizeRadioButton.AutoSize = true;
            this.uxFullScreenSizeRadioButton.Location = new System.Drawing.Point(6, 19);
            this.uxFullScreenSizeRadioButton.Name = "uxFullScreenSizeRadioButton";
            this.uxFullScreenSizeRadioButton.Size = new System.Drawing.Size(78, 17);
            this.uxFullScreenSizeRadioButton.TabIndex = 0;
            this.uxFullScreenSizeRadioButton.Tag = "/f";
            this.uxFullScreenSizeRadioButton.Text = "Full Screen";
            this.uxFullScreenSizeRadioButton.UseVisualStyleBackColor = true;
            // 
            // uxConnectButton
            // 
            this.uxConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxConnectButton.Location = new System.Drawing.Point(642, 41);
            this.uxConnectButton.Name = "uxConnectButton";
            this.uxConnectButton.Size = new System.Drawing.Size(138, 23);
            this.uxConnectButton.TabIndex = 4;
            this.uxConnectButton.Text = "Connect";
            this.uxConnectButton.UseVisualStyleBackColor = true;
            this.uxConnectButton.Click += new System.EventHandler(this.uxConnectButton_Click);
            // 
            // uxServerFrame
            // 
            this.uxServerFrame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxServerFrame.Controls.Add(this.uxFavoriteGroupsComboBox);
            this.uxServerFrame.Controls.Add(this.uxFavoritesTimestampLabel);
            this.uxServerFrame.Controls.Add(this.uxRequeryFavoritesLinkLabel);
            this.uxServerFrame.Controls.Add(this.uxPasteServerNameLabel);
            this.uxServerFrame.Controls.Add(this.uxFavoriteMachineComboBox);
            this.uxServerFrame.Controls.Add(this.uxFavoriteRadioButton);
            this.uxServerFrame.Controls.Add(this.uxRequeryRdpLinkLabel);
            this.uxServerFrame.Controls.Add(this.uxServerNameTextBox);
            this.uxServerFrame.Controls.Add(this.uxServerRadioButton);
            this.uxServerFrame.Controls.Add(this.uxRdpFileRadioButton);
            this.uxServerFrame.Controls.Add(this.uxRdpFileComboBox);
            this.uxServerFrame.Location = new System.Drawing.Point(12, 12);
            this.uxServerFrame.Name = "uxServerFrame";
            this.uxServerFrame.Size = new System.Drawing.Size(475, 177);
            this.uxServerFrame.TabIndex = 0;
            this.uxServerFrame.TabStop = false;
            this.uxServerFrame.Text = "Server";
            // 
            // uxFavoriteGroupsComboBox
            // 
            this.uxFavoriteGroupsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxFavoriteGroupsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxFavoriteGroupsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFavoriteGroupsComboBox.FormattingEnabled = true;
            this.uxFavoriteGroupsComboBox.Location = new System.Drawing.Point(25, 88);
            this.uxFavoriteGroupsComboBox.Name = "uxFavoriteGroupsComboBox";
            this.uxFavoriteGroupsComboBox.Size = new System.Drawing.Size(187, 21);
            this.uxFavoriteGroupsComboBox.TabIndex = 10;
            this.uxFavoriteGroupsComboBox.SelectedIndexChanged += new System.EventHandler(this.uxFavoriteGroupsComboBox_SelectedIndexChanged);
            // 
            // uxFavoritesTimestampLabel
            // 
            this.uxFavoritesTimestampLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxFavoritesTimestampLabel.Location = new System.Drawing.Point(315, 72);
            this.uxFavoritesTimestampLabel.Name = "uxFavoritesTimestampLabel";
            this.uxFavoritesTimestampLabel.Size = new System.Drawing.Size(101, 14);
            this.uxFavoritesTimestampLabel.TabIndex = 9;
            this.uxFavoritesTimestampLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // uxRequeryFavoritesLinkLabel
            // 
            this.uxRequeryFavoritesLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxRequeryFavoritesLinkLabel.AutoSize = true;
            this.uxRequeryFavoritesLinkLabel.Location = new System.Drawing.Point(422, 72);
            this.uxRequeryFavoritesLinkLabel.Name = "uxRequeryFavoritesLinkLabel";
            this.uxRequeryFavoritesLinkLabel.Size = new System.Drawing.Size(47, 13);
            this.uxRequeryFavoritesLinkLabel.TabIndex = 8;
            this.uxRequeryFavoritesLinkLabel.TabStop = true;
            this.uxRequeryFavoritesLinkLabel.Text = "Requery";
            this.uxRequeryFavoritesLinkLabel.Click += new System.EventHandler(this.uxRequeryFavoritesLinkLabel_Click);
            // 
            // uxPasteServerNameLabel
            // 
            this.uxPasteServerNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxPasteServerNameLabel.AutoSize = true;
            this.uxPasteServerNameLabel.Location = new System.Drawing.Point(435, 121);
            this.uxPasteServerNameLabel.Name = "uxPasteServerNameLabel";
            this.uxPasteServerNameLabel.Size = new System.Drawing.Size(34, 13);
            this.uxPasteServerNameLabel.TabIndex = 7;
            this.uxPasteServerNameLabel.TabStop = true;
            this.uxPasteServerNameLabel.Text = "Paste";
            this.uxPasteServerNameLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uxPasteServerNameLabel_LinkClicked);
            // 
            // uxFavoriteMachineComboBox
            // 
            this.uxFavoriteMachineComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxFavoriteMachineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxFavoriteMachineComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFavoriteMachineComboBox.FormattingEnabled = true;
            this.uxFavoriteMachineComboBox.Location = new System.Drawing.Point(218, 88);
            this.uxFavoriteMachineComboBox.Name = "uxFavoriteMachineComboBox";
            this.uxFavoriteMachineComboBox.Size = new System.Drawing.Size(251, 21);
            this.uxFavoriteMachineComboBox.TabIndex = 4;
            this.uxFavoriteMachineComboBox.SelectedIndexChanged += new System.EventHandler(this.uxFavoriteComboBox_SelectedIndexChanged);
            // 
            // uxFavoriteRadioButton
            // 
            this.uxFavoriteRadioButton.AutoSize = true;
            this.uxFavoriteRadioButton.Location = new System.Drawing.Point(6, 69);
            this.uxFavoriteRadioButton.Name = "uxFavoriteRadioButton";
            this.uxFavoriteRadioButton.Size = new System.Drawing.Size(86, 17);
            this.uxFavoriteRadioButton.TabIndex = 3;
            this.uxFavoriteRadioButton.Text = "This favorite:";
            this.uxFavoriteRadioButton.UseVisualStyleBackColor = true;
            // 
            // uxRequeryRdpLinkLabel
            // 
            this.uxRequeryRdpLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxRequeryRdpLinkLabel.AutoSize = true;
            this.uxRequeryRdpLinkLabel.Location = new System.Drawing.Point(422, 21);
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
            this.uxServerNameTextBox.Location = new System.Drawing.Point(25, 142);
            this.uxServerNameTextBox.Name = "uxServerNameTextBox";
            this.uxServerNameTextBox.Size = new System.Drawing.Size(444, 20);
            this.uxServerNameTextBox.TabIndex = 6;
            this.uxServerNameTextBox.TextChanged += new System.EventHandler(this.uxServerNameTextBox_TextChanged);
            // 
            // uxServerRadioButton
            // 
            this.uxServerRadioButton.AutoSize = true;
            this.uxServerRadioButton.Location = new System.Drawing.Point(6, 119);
            this.uxServerRadioButton.Name = "uxServerRadioButton";
            this.uxServerRadioButton.Size = new System.Drawing.Size(91, 17);
            this.uxServerRadioButton.TabIndex = 5;
            this.uxServerRadioButton.Text = "This machine:";
            this.uxServerRadioButton.UseVisualStyleBackColor = true;
            // 
            // uxRdpFileRadioButton
            // 
            this.uxRdpFileRadioButton.AutoSize = true;
            this.uxRdpFileRadioButton.Checked = true;
            this.uxRdpFileRadioButton.Location = new System.Drawing.Point(6, 19);
            this.uxRdpFileRadioButton.Name = "uxRdpFileRadioButton";
            this.uxRdpFileRadioButton.Size = new System.Drawing.Size(70, 17);
            this.uxRdpFileRadioButton.TabIndex = 0;
            this.uxRdpFileRadioButton.TabStop = true;
            this.uxRdpFileRadioButton.Text = "RDP File:";
            this.uxRdpFileRadioButton.UseVisualStyleBackColor = true;
            // 
            // uxWindowSizeFrame
            // 
            this.uxWindowSizeFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxWindowSizeFrame.Controls.Add(this.uxFullScreenWindowComboBox);
            this.uxWindowSizeFrame.Controls.Add(this.uxFullScreenWindowRadioButton);
            this.uxWindowSizeFrame.Controls.Add(this.uxLargestWindowComboBox);
            this.uxWindowSizeFrame.Controls.Add(this.uxFullScreenSizeRadioButton);
            this.uxWindowSizeFrame.Controls.Add(this.uxLargestWindowRadioButton);
            this.uxWindowSizeFrame.Controls.Add(this.uxRecalculateLabel);
            this.uxWindowSizeFrame.Location = new System.Drawing.Point(493, 12);
            this.uxWindowSizeFrame.Name = "uxWindowSizeFrame";
            this.uxWindowSizeFrame.Size = new System.Drawing.Size(143, 177);
            this.uxWindowSizeFrame.TabIndex = 1;
            this.uxWindowSizeFrame.TabStop = false;
            this.uxWindowSizeFrame.Text = "Window Size";
            // 
            // uxFullScreenWindowComboBox
            // 
            this.uxFullScreenWindowComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxFullScreenWindowComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxFullScreenWindowComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFullScreenWindowComboBox.FormattingEnabled = true;
            this.uxFullScreenWindowComboBox.Location = new System.Drawing.Point(23, 111);
            this.uxFullScreenWindowComboBox.Name = "uxFullScreenWindowComboBox";
            this.uxFullScreenWindowComboBox.Size = new System.Drawing.Size(113, 21);
            this.uxFullScreenWindowComboBox.TabIndex = 8;
            // 
            // uxFullScreenWindowRadioButton
            // 
            this.uxFullScreenWindowRadioButton.AutoSize = true;
            this.uxFullScreenWindowRadioButton.Location = new System.Drawing.Point(6, 92);
            this.uxFullScreenWindowRadioButton.Name = "uxFullScreenWindowRadioButton";
            this.uxFullScreenWindowRadioButton.Size = new System.Drawing.Size(123, 17);
            this.uxFullScreenWindowRadioButton.TabIndex = 7;
            this.uxFullScreenWindowRadioButton.Text = "Full Screen Window:";
            this.uxFullScreenWindowRadioButton.UseVisualStyleBackColor = true;
            // 
            // uxLargestWindowComboBox
            // 
            this.uxLargestWindowComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxLargestWindowComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxLargestWindowComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLargestWindowComboBox.FormattingEnabled = true;
            this.uxLargestWindowComboBox.Location = new System.Drawing.Point(23, 61);
            this.uxLargestWindowComboBox.Name = "uxLargestWindowComboBox";
            this.uxLargestWindowComboBox.Size = new System.Drawing.Size(113, 21);
            this.uxLargestWindowComboBox.TabIndex = 6;
            // 
            // uxLargestWindowRadioButton
            // 
            this.uxLargestWindowRadioButton.AutoSize = true;
            this.uxLargestWindowRadioButton.Checked = true;
            this.uxLargestWindowRadioButton.Location = new System.Drawing.Point(6, 42);
            this.uxLargestWindowRadioButton.Name = "uxLargestWindowRadioButton";
            this.uxLargestWindowRadioButton.Size = new System.Drawing.Size(105, 17);
            this.uxLargestWindowRadioButton.TabIndex = 5;
            this.uxLargestWindowRadioButton.TabStop = true;
            this.uxLargestWindowRadioButton.Text = "Largest Window:";
            this.uxLargestWindowRadioButton.UseVisualStyleBackColor = true;
            // 
            // uxRecalculateLabel
            // 
            this.uxRecalculateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxRecalculateLabel.AutoSize = true;
            this.uxRecalculateLabel.Location = new System.Drawing.Point(72, 149);
            this.uxRecalculateLabel.Name = "uxRecalculateLabel";
            this.uxRecalculateLabel.Size = new System.Drawing.Size(64, 13);
            this.uxRecalculateLabel.TabIndex = 4;
            this.uxRecalculateLabel.TabStop = true;
            this.uxRecalculateLabel.Text = "Recalculate";
            this.uxRecalculateLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uxRecalculateLabel_LinkClicked);
            // 
            // uxStateTimer
            // 
            this.uxStateTimer.Tick += new System.EventHandler(this.uxStateTimer_Tick);
            // 
            // uxMinimizeAndConnectButton
            // 
            this.uxMinimizeAndConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxMinimizeAndConnectButton.Location = new System.Drawing.Point(642, 12);
            this.uxMinimizeAndConnectButton.Name = "uxMinimizeAndConnectButton";
            this.uxMinimizeAndConnectButton.Size = new System.Drawing.Size(138, 23);
            this.uxMinimizeAndConnectButton.TabIndex = 2;
            this.uxMinimizeAndConnectButton.Text = "Minimize and Connect";
            this.uxMinimizeAndConnectButton.UseVisualStyleBackColor = true;
            this.uxMinimizeAndConnectButton.Click += new System.EventHandler(this.uxMinimizeAndConnectButton_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.uxMinimizeAndConnectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 202);
            this.Controls.Add(this.uxMinimizeAndConnectButton);
            this.Controls.Add(this.uxWindowSizeFrame);
            this.Controls.Add(this.uxServerFrame);
            this.Controls.Add(this.uxConnectButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(3000, 3000);
            this.MinimumSize = new System.Drawing.Size(438, 27);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Remote Desktopper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.uxServerFrame.ResumeLayout(false);
            this.uxServerFrame.PerformLayout();
            this.uxWindowSizeFrame.ResumeLayout(false);
            this.uxWindowSizeFrame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox uxRdpFileComboBox;
        private System.Windows.Forms.RadioButton uxFullScreenSizeRadioButton;
        private System.Windows.Forms.Button uxConnectButton;
        private System.Windows.Forms.GroupBox uxServerFrame;
        private System.Windows.Forms.TextBox uxServerNameTextBox;
        private System.Windows.Forms.RadioButton uxServerRadioButton;
        private System.Windows.Forms.RadioButton uxRdpFileRadioButton;
        private System.Windows.Forms.GroupBox uxWindowSizeFrame;
        private System.Windows.Forms.Timer uxStateTimer;
        private System.Windows.Forms.LinkLabel uxRequeryRdpLinkLabel;
        private System.Windows.Forms.LinkLabel uxRecalculateLabel;
        private System.Windows.Forms.Button uxMinimizeAndConnectButton;
        private System.Windows.Forms.ComboBox uxFavoriteMachineComboBox;
        private System.Windows.Forms.RadioButton uxFavoriteRadioButton;
        private System.Windows.Forms.LinkLabel uxPasteServerNameLabel;
        private System.Windows.Forms.RadioButton uxFullScreenWindowRadioButton;
        private System.Windows.Forms.ComboBox uxLargestWindowComboBox;
        private System.Windows.Forms.RadioButton uxLargestWindowRadioButton;
        private System.Windows.Forms.ComboBox uxFullScreenWindowComboBox;
        private System.Windows.Forms.LinkLabel uxRequeryFavoritesLinkLabel;
        private System.Windows.Forms.Label uxFavoritesTimestampLabel;
        private System.Windows.Forms.ComboBox uxFavoriteGroupsComboBox;
    }
}

