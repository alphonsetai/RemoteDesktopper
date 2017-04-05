namespace RemoteDesktopper
{
    partial class GetUserNameForm
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.uxUserNameTextBox = new System.Windows.Forms.TextBox();
            this.uxLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(13, 13);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(55, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Username";
            // 
            // uxUserNameTextBox
            // 
            this.uxUserNameTextBox.Location = new System.Drawing.Point(13, 30);
            this.uxUserNameTextBox.Name = "uxUserNameTextBox";
            this.uxUserNameTextBox.Size = new System.Drawing.Size(162, 20);
            this.uxUserNameTextBox.TabIndex = 1;
            // 
            // uxLoginButton
            // 
            this.uxLoginButton.Location = new System.Drawing.Point(197, 13);
            this.uxLoginButton.Name = "uxLoginButton";
            this.uxLoginButton.Size = new System.Drawing.Size(75, 23);
            this.uxLoginButton.TabIndex = 2;
            this.uxLoginButton.Text = "Login";
            this.uxLoginButton.UseVisualStyleBackColor = true;
            this.uxLoginButton.Click += new System.EventHandler(this.uxLoginButton_Click);
            // 
            // GetUserNameForm
            // 
            this.AcceptButton = this.uxLoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 76);
            this.Controls.Add(this.uxLoginButton);
            this.Controls.Add(this.uxUserNameTextBox);
            this.Controls.Add(this.lblUserName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetUserNameForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Desktopper - Login";
            this.Load += new System.EventHandler(this.GetUserNameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox uxUserNameTextBox;
        private System.Windows.Forms.Button uxLoginButton;
    }
}