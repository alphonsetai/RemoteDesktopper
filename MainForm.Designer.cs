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
            this.uxOtherSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.uxConnectButton = new System.Windows.Forms.Button();
            this.uxServerFrame = new System.Windows.Forms.GroupBox();
            this.uxServerNameTextBox = new System.Windows.Forms.TextBox();
            this.uxServerRadioButton = new System.Windows.Forms.RadioButton();
            this.uxRdpFileRadioButton = new System.Windows.Forms.RadioButton();
            this.uxWindowSizeFrame = new System.Windows.Forms.GroupBox();
            this.uxBestSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.uxScreenSize1680x1050RadioButton = new System.Windows.Forms.RadioButton();
            this.uxStateTimer = new System.Windows.Forms.Timer(this.components);
            this.uxRequeryLinkLabel = new System.Windows.Forms.LinkLabel();
            this.uxRecalculateLabel = new System.Windows.Forms.LinkLabel();
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
            this.uxRdpFileComboBox.Location = new System.Drawing.Point(92, 18);
            this.uxRdpFileComboBox.Name = "uxRdpFileComboBox";
            this.uxRdpFileComboBox.Size = new System.Drawing.Size(374, 21);
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
            // uxOtherSizeRadioButton
            // 
            this.uxOtherSizeRadioButton.AutoSize = true;
            this.uxOtherSizeRadioButton.Checked = true;
            this.uxOtherSizeRadioButton.Location = new System.Drawing.Point(104, -2);
            this.uxOtherSizeRadioButton.Name = "uxOtherSizeRadioButton";
            this.uxOtherSizeRadioButton.Size = new System.Drawing.Size(78, 17);
            this.uxOtherSizeRadioButton.TabIndex = 10;
            this.uxOtherSizeRadioButton.TabStop = true;
            this.uxOtherSizeRadioButton.Tag = "/w:1280 /h:720";
            this.uxOtherSizeRadioButton.Text = "1280 x 720";
            this.uxOtherSizeRadioButton.UseVisualStyleBackColor = true;
            this.uxOtherSizeRadioButton.Visible = false;
            // 
            // uxConnectButton
            // 
            this.uxConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxConnectButton.Location = new System.Drawing.Point(601, 14);
            this.uxConnectButton.Name = "uxConnectButton";
            this.uxConnectButton.Size = new System.Drawing.Size(75, 23);
            this.uxConnectButton.TabIndex = 11;
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
            this.uxServerFrame.Size = new System.Drawing.Size(472, 77);
            this.uxServerFrame.TabIndex = 1;
            this.uxServerFrame.TabStop = false;
            this.uxServerFrame.Text = "Server";
            // 
            // uxServerNameTextBox
            // 
            this.uxServerNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxServerNameTextBox.Location = new System.Drawing.Point(92, 45);
            this.uxServerNameTextBox.Name = "uxServerNameTextBox";
            this.uxServerNameTextBox.Size = new System.Drawing.Size(374, 20);
            this.uxServerNameTextBox.TabIndex = 6;
            this.uxServerNameTextBox.TextChanged += new System.EventHandler(this.uxServerNameTextBox_TextChanged);
            // 
            // uxServerRadioButton
            // 
            this.uxServerRadioButton.AutoSize = true;
            this.uxServerRadioButton.Location = new System.Drawing.Point(6, 46);
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
            // uxWindowSizeFrame
            // 
            this.uxWindowSizeFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxWindowSizeFrame.Controls.Add(this.uxRecalculateLabel);
            this.uxWindowSizeFrame.Controls.Add(this.uxBestSizeRadioButton);
            this.uxWindowSizeFrame.Controls.Add(this.uxFullScreenSizeRadioButton);
            this.uxWindowSizeFrame.Location = new System.Drawing.Point(490, 12);
            this.uxWindowSizeFrame.Name = "uxWindowSizeFrame";
            this.uxWindowSizeFrame.Size = new System.Drawing.Size(105, 77);
            this.uxWindowSizeFrame.TabIndex = 7;
            this.uxWindowSizeFrame.TabStop = false;
            this.uxWindowSizeFrame.Text = "Window Size";
            // 
            // uxBestSizeRadioButton
            // 
            this.uxBestSizeRadioButton.AutoSize = true;
            this.uxBestSizeRadioButton.Checked = true;
            this.uxBestSizeRadioButton.Location = new System.Drawing.Point(12, 42);
            this.uxBestSizeRadioButton.Name = "uxBestSizeRadioButton";
            this.uxBestSizeRadioButton.Size = new System.Drawing.Size(78, 17);
            this.uxBestSizeRadioButton.TabIndex = 11;
            this.uxBestSizeRadioButton.TabStop = true;
            this.uxBestSizeRadioButton.Tag = "/w:1280 /h:720";
            this.uxBestSizeRadioButton.Text = "1280 x 720";
            this.uxBestSizeRadioButton.UseVisualStyleBackColor = true;
            // 
            // uxScreenSize1680x1050RadioButton
            // 
            this.uxScreenSize1680x1050RadioButton.AutoSize = true;
            this.uxScreenSize1680x1050RadioButton.Location = new System.Drawing.Point(188, -2);
            this.uxScreenSize1680x1050RadioButton.Name = "uxScreenSize1680x1050RadioButton";
            this.uxScreenSize1680x1050RadioButton.Size = new System.Drawing.Size(84, 17);
            this.uxScreenSize1680x1050RadioButton.TabIndex = 9;
            this.uxScreenSize1680x1050RadioButton.Tag = "/w:1680 /h:1050";
            this.uxScreenSize1680x1050RadioButton.Text = "1680 x 1050";
            this.uxScreenSize1680x1050RadioButton.UseVisualStyleBackColor = true;
            this.uxScreenSize1680x1050RadioButton.Visible = false;
            // 
            // uxStateTimer
            // 
            this.uxStateTimer.Tick += new System.EventHandler(this.uxStateTimer_Tick);
            // 
            // uxRequeryLinkLabel
            // 
            this.uxRequeryLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxRequeryLinkLabel.AutoSize = true;
            this.uxRequeryLinkLabel.Location = new System.Drawing.Point(419, 2);
            this.uxRequeryLinkLabel.Name = "uxRequeryLinkLabel";
            this.uxRequeryLinkLabel.Size = new System.Drawing.Size(47, 13);
            this.uxRequeryLinkLabel.TabIndex = 7;
            this.uxRequeryLinkLabel.TabStop = true;
            this.uxRequeryLinkLabel.Text = "Requery";
            this.uxRequeryLinkLabel.Click += new System.EventHandler(this.uxRequeryLinkLabel_Click);
            // 
            // uxRecalculateLabel
            // 
            this.uxRecalculateLabel.AutoSize = true;
            this.uxRecalculateLabel.Location = new System.Drawing.Point(9, 64);
            this.uxRecalculateLabel.Name = "uxRecalculateLabel";
            this.uxRecalculateLabel.Size = new System.Drawing.Size(64, 13);
            this.uxRecalculateLabel.TabIndex = 12;
            this.uxRecalculateLabel.TabStop = true;
            this.uxRecalculateLabel.Text = "Recalculate";
            this.uxRecalculateLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uxRecalculateLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AcceptButton = this.uxConnectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 101);
            this.Controls.Add(this.uxWindowSizeFrame);
            this.Controls.Add(this.uxScreenSize1680x1050RadioButton);
            this.Controls.Add(this.uxServerFrame);
            this.Controls.Add(this.uxConnectButton);
            this.Controls.Add(this.uxOtherSizeRadioButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(3000, 220);
            this.MinimumSize = new System.Drawing.Size(438, 128);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Desktopper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.uxServerFrame.ResumeLayout(false);
            this.uxServerFrame.PerformLayout();
            this.uxWindowSizeFrame.ResumeLayout(false);
            this.uxWindowSizeFrame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uxRdpFileComboBox;
        private System.Windows.Forms.RadioButton uxFullScreenSizeRadioButton;
        private System.Windows.Forms.RadioButton uxOtherSizeRadioButton;
        private System.Windows.Forms.Button uxConnectButton;
        private System.Windows.Forms.GroupBox uxServerFrame;
        private System.Windows.Forms.TextBox uxServerNameTextBox;
        private System.Windows.Forms.RadioButton uxServerRadioButton;
        private System.Windows.Forms.RadioButton uxRdpFileRadioButton;
        private System.Windows.Forms.GroupBox uxWindowSizeFrame;
        private System.Windows.Forms.RadioButton uxScreenSize1680x1050RadioButton;
        private System.Windows.Forms.Timer uxStateTimer;
        private System.Windows.Forms.RadioButton uxBestSizeRadioButton;
        private System.Windows.Forms.LinkLabel uxRequeryLinkLabel;
        private System.Windows.Forms.LinkLabel uxRecalculateLabel;
    }
}

