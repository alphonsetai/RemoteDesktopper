namespace RemoteDesktopper
{
    partial class FavoriteMachineForm
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
            this.lblIpAddress = new System.Windows.Forms.Label();
            this.uxIpAddressTextBox = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.uxPortTextBox = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.uxUsernameTextBox = new System.Windows.Forms.TextBox();
            this.lblPemFile = new System.Windows.Forms.Label();
            this.uxPemFileTextBox = new System.Windows.Forms.TextBox();
            this.uxCopyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.AutoSize = true;
            this.lblIpAddress.Location = new System.Drawing.Point(12, 18);
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Size = new System.Drawing.Size(58, 13);
            this.lblIpAddress.TabIndex = 0;
            this.lblIpAddress.Text = "IP Address";
            // 
            // uxIpAddressTextBox
            // 
            this.uxIpAddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uxIpAddressTextBox.Location = new System.Drawing.Point(81, 18);
            this.uxIpAddressTextBox.Name = "uxIpAddressTextBox";
            this.uxIpAddressTextBox.ReadOnly = true;
            this.uxIpAddressTextBox.Size = new System.Drawing.Size(296, 13);
            this.uxIpAddressTextBox.TabIndex = 1;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(12, 42);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port";
            // 
            // uxPortTextBox
            // 
            this.uxPortTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uxPortTextBox.Location = new System.Drawing.Point(81, 42);
            this.uxPortTextBox.Name = "uxPortTextBox";
            this.uxPortTextBox.ReadOnly = true;
            this.uxPortTextBox.Size = new System.Drawing.Size(296, 13);
            this.uxPortTextBox.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 68);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // uxUsernameTextBox
            // 
            this.uxUsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uxUsernameTextBox.Location = new System.Drawing.Point(81, 68);
            this.uxUsernameTextBox.Name = "uxUsernameTextBox";
            this.uxUsernameTextBox.ReadOnly = true;
            this.uxUsernameTextBox.Size = new System.Drawing.Size(296, 13);
            this.uxUsernameTextBox.TabIndex = 5;
            // 
            // lblPemFile
            // 
            this.lblPemFile.AutoSize = true;
            this.lblPemFile.Location = new System.Drawing.Point(12, 94);
            this.lblPemFile.Name = "lblPemFile";
            this.lblPemFile.Size = new System.Drawing.Size(46, 13);
            this.lblPemFile.TabIndex = 6;
            this.lblPemFile.Text = "PEM file";
            // 
            // uxPemFileTextBox
            // 
            this.uxPemFileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uxPemFileTextBox.Location = new System.Drawing.Point(81, 94);
            this.uxPemFileTextBox.Name = "uxPemFileTextBox";
            this.uxPemFileTextBox.ReadOnly = true;
            this.uxPemFileTextBox.Size = new System.Drawing.Size(296, 13);
            this.uxPemFileTextBox.TabIndex = 7;
            // 
            // uxCopyButton
            // 
            this.uxCopyButton.Location = new System.Drawing.Point(302, 113);
            this.uxCopyButton.Name = "uxCopyButton";
            this.uxCopyButton.Size = new System.Drawing.Size(75, 23);
            this.uxCopyButton.TabIndex = 8;
            this.uxCopyButton.Text = "Copy";
            this.uxCopyButton.UseVisualStyleBackColor = true;
            this.uxCopyButton.Click += new System.EventHandler(this.uxCopyButton_Click);
            // 
            // FavoriteMachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 151);
            this.Controls.Add(this.uxCopyButton);
            this.Controls.Add(this.uxPemFileTextBox);
            this.Controls.Add(this.lblPemFile);
            this.Controls.Add(this.uxUsernameTextBox);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.uxPortTextBox);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.uxIpAddressTextBox);
            this.Controls.Add(this.lblIpAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FavoriteMachineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Machine Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIpAddress;
        private System.Windows.Forms.TextBox uxIpAddressTextBox;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox uxPortTextBox;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox uxUsernameTextBox;
        private System.Windows.Forms.Label lblPemFile;
        private System.Windows.Forms.TextBox uxPemFileTextBox;
        private System.Windows.Forms.Button uxCopyButton;
    }
}