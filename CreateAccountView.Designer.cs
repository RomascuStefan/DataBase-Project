namespace ProiectBD
{
    partial class CreateAccountView
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
            CreateAccountButton = new Button();
            NameTextbox = new TextBox();
            PhoneNumberTextbox = new TextBox();
            PasswordTextbox = new TextBox();
            FullNameLabel = new Label();
            PhoneNumberLabel = new Label();
            PasswordLabel = new Label();
            ViewPasswordCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // CreateAccountButton
            // 
            CreateAccountButton.Location = new Point(164, 178);
            CreateAccountButton.Name = "CreateAccountButton";
            CreateAccountButton.Size = new Size(139, 52);
            CreateAccountButton.TabIndex = 0;
            CreateAccountButton.Text = "Create Account";
            CreateAccountButton.UseVisualStyleBackColor = true;
            CreateAccountButton.Click += CreateAccountButton_Click;
            // 
            // NameTextbox
            // 
            NameTextbox.Location = new Point(106, 22);
            NameTextbox.Name = "NameTextbox";
            NameTextbox.Size = new Size(261, 23);
            NameTextbox.TabIndex = 1;
            NameTextbox.TextChanged += NameTextbox_TextChanged;
            // 
            // PhoneNumberTextbox
            // 
            PhoneNumberTextbox.Location = new Point(106, 68);
            PhoneNumberTextbox.Name = "PhoneNumberTextbox";
            PhoneNumberTextbox.Size = new Size(261, 23);
            PhoneNumberTextbox.TabIndex = 2;
            PhoneNumberTextbox.TextChanged += PhoneNumberTextbox_TextChanged;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Location = new Point(106, 114);
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.Size = new Size(261, 23);
            PasswordTextbox.TabIndex = 3;
            PasswordTextbox.TextChanged += PasswordTextbox_TextChanged;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(39, 25);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(61, 15);
            FullNameLabel.TabIndex = 4;
            FullNameLabel.Text = "Full Name";
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(12, 71);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(88, 15);
            PhoneNumberLabel.TabIndex = 5;
            PhoneNumberLabel.Text = "Phone Number";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(43, 117);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 6;
            PasswordLabel.Text = "Password";
            // 
            // ViewPasswordCheckBox
            // 
            ViewPasswordCheckBox.AutoSize = true;
            ViewPasswordCheckBox.Location = new Point(373, 116);
            ViewPasswordCheckBox.Name = "ViewPasswordCheckBox";
            ViewPasswordCheckBox.Size = new Size(51, 19);
            ViewPasswordCheckBox.TabIndex = 7;
            ViewPasswordCheckBox.Text = "View";
            ViewPasswordCheckBox.UseVisualStyleBackColor = true;
            ViewPasswordCheckBox.CheckedChanged += ViewPasswordCheckbox_CheckedChanged;
            // 
            // CreateAccountView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 242);
            Controls.Add(ViewPasswordCheckBox);
            Controls.Add(PasswordLabel);
            Controls.Add(PhoneNumberLabel);
            Controls.Add(FullNameLabel);
            Controls.Add(PasswordTextbox);
            Controls.Add(PhoneNumberTextbox);
            Controls.Add(NameTextbox);
            Controls.Add(CreateAccountButton);
            Name = "CreateAccountView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateAccountView";
            Load += CreateAccountView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateAccountButton;
        private TextBox NameTextbox;
        private TextBox PhoneNumberTextbox;
        private TextBox PasswordTextbox;
        private Label FullNameLabel;
        private Label PhoneNumberLabel;
        private Label PasswordLabel;
        private CheckBox ViewPasswordCheckBox;
    }
}