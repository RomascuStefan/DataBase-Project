namespace ProiectBD
{
    partial class LogInView
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
            process1 = new System.Diagnostics.Process();
            LogInButton = new Button();
            UserLabel = new Label();
            PasswordLabel = new Label();
            UserInputTextBox = new TextBox();
            PasswordInputTextBox = new TextBox();
            ViewPasswordCheckButton = new CheckBox();
            CreateAccountButton = new Button();
            SuspendLayout();
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // LogInButton
            // 
            LogInButton.Location = new Point(106, 210);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(152, 53);
            LogInButton.TabIndex = 0;
            LogInButton.Text = "Log In";
            LogInButton.UseVisualStyleBackColor = true;
            LogInButton.Click += LogInButton_Click;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Location = new Point(106, 86);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(34, 15);
            UserLabel.TabIndex = 1;
            UserLabel.Text = "USER";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(106, 134);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(68, 15);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "PASSWORD";
            // 
            // UserInputTextBox
            // 
            UserInputTextBox.Location = new Point(191, 83);
            UserInputTextBox.Name = "UserInputTextBox";
            UserInputTextBox.Size = new Size(180, 23);
            UserInputTextBox.TabIndex = 3;
            UserInputTextBox.TextChanged += UserTextBox_TextChanged;
            // 
            // PasswordInputTextBox
            // 
            PasswordInputTextBox.Location = new Point(191, 126);
            PasswordInputTextBox.Name = "PasswordInputTextBox";
            PasswordInputTextBox.PasswordChar = '*';
            PasswordInputTextBox.Size = new Size(180, 23);
            PasswordInputTextBox.TabIndex = 4;
            PasswordInputTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // ViewPasswordCheckButton
            // 
            ViewPasswordCheckButton.AutoSize = true;
            ViewPasswordCheckButton.Location = new Point(377, 128);
            ViewPasswordCheckButton.Name = "ViewPasswordCheckButton";
            ViewPasswordCheckButton.Size = new Size(53, 19);
            ViewPasswordCheckButton.TabIndex = 5;
            ViewPasswordCheckButton.Text = "VIEW";
            ViewPasswordCheckButton.UseVisualStyleBackColor = true;
            ViewPasswordCheckButton.CheckedChanged += PasswordView_CheckedChanged;
            // 
            // CreateAccountButton
            // 
            CreateAccountButton.Location = new Point(278, 210);
            CreateAccountButton.Name = "CreateAccountButton";
            CreateAccountButton.Size = new Size(152, 53);
            CreateAccountButton.TabIndex = 6;
            CreateAccountButton.Text = "Create Account";
            CreateAccountButton.UseVisualStyleBackColor = true;
            CreateAccountButton.Click += CreateAccountButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 275);
            Controls.Add(CreateAccountButton);
            Controls.Add(ViewPasswordCheckButton);
            Controls.Add(PasswordInputTextBox);
            Controls.Add(UserInputTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UserLabel);
            Controls.Add(LogInButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Diagnostics.Process process1;
        private Button LogInButton;
        private Label PasswordLabel;
        private Label UserLabel;
        private TextBox UserInputTextBox;
        private TextBox PasswordInputTextBox;
        private CheckBox ViewPasswordCheckButton;
        private Button CreateAccountButton;
    }
}