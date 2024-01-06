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
            FirstNameTextBox = new TextBox();
            PhoneNumberTextbox = new TextBox();
            PasswordTextbox = new TextBox();
            FullNameLabel = new Label();
            PhoneNumberLabel = new Label();
            PasswordLabel = new Label();
            ViewPasswordCheckBox = new CheckBox();
            label1 = new Label();
            lastNameTextBox = new TextBox();
            SuspendLayout();
            // 
            // CreateAccountButton
            // 
            CreateAccountButton.Location = new Point(155, 221);
            CreateAccountButton.Name = "CreateAccountButton";
            CreateAccountButton.Size = new Size(139, 52);
            CreateAccountButton.TabIndex = 0;
            CreateAccountButton.Text = "Create Account";
            CreateAccountButton.UseVisualStyleBackColor = true;
            CreateAccountButton.Click += CreateAccountButton_Click;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(109, 77);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(185, 23);
            FirstNameTextBox.TabIndex = 1;
            FirstNameTextBox.TextChanged += NameTextbox_TextChanged;
            // 
            // PhoneNumberTextbox
            // 
            PhoneNumberTextbox.Location = new Point(109, 135);
            PhoneNumberTextbox.Name = "PhoneNumberTextbox";
            PhoneNumberTextbox.Size = new Size(261, 23);
            PhoneNumberTextbox.TabIndex = 2;
            PhoneNumberTextbox.TextChanged += PhoneNumberTextbox_TextChanged;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Location = new Point(109, 164);
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.Size = new Size(261, 23);
            PasswordTextbox.TabIndex = 3;
            PasswordTextbox.TextChanged += PasswordTextbox_TextChanged;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(19, 80);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(64, 15);
            FullNameLabel.TabIndex = 4;
            FullNameLabel.Text = "First Name";
            FullNameLabel.Click += FullNameLabel_Click;
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(19, 138);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(88, 15);
            PhoneNumberLabel.TabIndex = 5;
            PhoneNumberLabel.Text = "Phone Number";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(19, 167);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 6;
            PasswordLabel.Text = "Password";
            // 
            // ViewPasswordCheckBox
            // 
            ViewPasswordCheckBox.AutoSize = true;
            ViewPasswordCheckBox.Location = new Point(376, 168);
            ViewPasswordCheckBox.Name = "ViewPasswordCheckBox";
            ViewPasswordCheckBox.Size = new Size(51, 19);
            ViewPasswordCheckBox.TabIndex = 7;
            ViewPasswordCheckBox.Text = "View";
            ViewPasswordCheckBox.UseVisualStyleBackColor = true;
            ViewPasswordCheckBox.CheckedChanged += ViewPasswordCheckbox_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 109);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 8;
            label1.Text = "Last Name";
            label1.Click += label1_Click;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(109, 106);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(185, 23);
            lastNameTextBox.TabIndex = 9;
            lastNameTextBox.TextChanged += LastNameTextBox_TextChanged;
            // 
            // CreateAccountView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 285);
            Controls.Add(lastNameTextBox);
            Controls.Add(label1);
            Controls.Add(ViewPasswordCheckBox);
            Controls.Add(PasswordLabel);
            Controls.Add(PhoneNumberLabel);
            Controls.Add(FullNameLabel);
            Controls.Add(PasswordTextbox);
            Controls.Add(PhoneNumberTextbox);
            Controls.Add(FirstNameTextBox);
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
        private TextBox FirstNameTextBox;
        private TextBox PhoneNumberTextbox;
        private TextBox PasswordTextbox;
        private Label FullNameLabel;
        private Label PhoneNumberLabel;
        private Label PasswordLabel;
        private CheckBox ViewPasswordCheckBox;
        private Label label1;
        private TextBox lastNameTextBox;
    }
}