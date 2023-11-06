namespace ProiectBD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.process1 = new System.Diagnostics.Process();
            this.LogInButton = new System.Windows.Forms.Button();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserInputTextBox = new System.Windows.Forms.TextBox();
            this.PasswordInputTextBox = new System.Windows.Forms.TextBox();
            this.ViewPasswordCheckButton = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardInputEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(452, 523);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(152, 53);
            this.LogInButton.TabIndex = 0;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(367, 196);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(34, 15);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "USER";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(367, 257);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(68, 15);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "PASSWORD";
            // 
            // UserInputTextBox
            // 
            this.UserInputTextBox.Location = new System.Drawing.Point(452, 188);
            this.UserInputTextBox.Name = "UserInputTextBox";
            this.UserInputTextBox.Size = new System.Drawing.Size(180, 23);
            this.UserInputTextBox.TabIndex = 3;
            this.UserInputTextBox.TextChanged += new System.EventHandler(this.UserTextBox_TextChanged);
            // 
            // PasswordInputTextBox
            // 
            this.PasswordInputTextBox.Location = new System.Drawing.Point(452, 249);
            this.PasswordInputTextBox.Name = "PasswordInputTextBox";
            this.PasswordInputTextBox.PasswordChar = '*';
            this.PasswordInputTextBox.Size = new System.Drawing.Size(180, 23);
            this.PasswordInputTextBox.TabIndex = 4;
            this.PasswordInputTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // ViewPasswordCheckButton
            // 
            this.ViewPasswordCheckButton.AutoSize = true;
            this.ViewPasswordCheckButton.Location = new System.Drawing.Point(638, 251);
            this.ViewPasswordCheckButton.Name = "ViewPasswordCheckButton";
            this.ViewPasswordCheckButton.Size = new System.Drawing.Size(53, 19);
            this.ViewPasswordCheckButton.TabIndex = 5;
            this.ViewPasswordCheckButton.Text = "VIEW";
            this.ViewPasswordCheckButton.UseVisualStyleBackColor = true;
            this.ViewPasswordCheckButton.CheckedChanged += new System.EventHandler(this.PasswordView_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 588);
            this.Controls.Add(this.ViewPasswordCheckButton);
            this.Controls.Add(this.PasswordInputTextBox);
            this.Controls.Add(this.UserInputTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.LogInButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.Process process1;
        private Button LogInButton;
        private Label PasswordLabel;
        private Label UserLabel;
        private TextBox UserInputTextBox;
        private TextBox PasswordInputTextBox;
        private CheckBox ViewPasswordCheckButton;
    }
}