namespace ProiectBD
{
    partial class AdminView
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
            this.AddPersonToMe = new System.Windows.Forms.Button();
            this.CreateNewAccount = new System.Windows.Forms.Button();
            this.ViewListOfPeople = new System.Windows.Forms.Button();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.StartSessionButton = new System.Windows.Forms.Button();
            this.PersonListTraining = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPersonToMe
            // 
            this.AddPersonToMe.Location = new System.Drawing.Point(243, 58);
            this.AddPersonToMe.Name = "AddPersonToMe";
            this.AddPersonToMe.Size = new System.Drawing.Size(172, 71);
            this.AddPersonToMe.TabIndex = 0;
            this.AddPersonToMe.Text = "Add Person";
            this.AddPersonToMe.UseVisualStyleBackColor = true;
            this.AddPersonToMe.Click += new System.EventHandler(this.AddPersonButtonClick);
            // 
            // CreateNewAccount
            // 
            this.CreateNewAccount.Location = new System.Drawing.Point(12, 58);
            this.CreateNewAccount.Name = "CreateNewAccount";
            this.CreateNewAccount.Size = new System.Drawing.Size(172, 71);
            this.CreateNewAccount.TabIndex = 1;
            this.CreateNewAccount.Text = "Create New Account";
            this.CreateNewAccount.UseVisualStyleBackColor = true;
            this.CreateNewAccount.Click += new System.EventHandler(this.CreateNewAccountButtonClick);
            // 
            // ViewListOfPeople
            // 
            this.ViewListOfPeople.Location = new System.Drawing.Point(487, 58);
            this.ViewListOfPeople.Name = "ViewListOfPeople";
            this.ViewListOfPeople.Size = new System.Drawing.Size(172, 71);
            this.ViewListOfPeople.TabIndex = 2;
            this.ViewListOfPeople.Text = "View People";
            this.ViewListOfPeople.UseVisualStyleBackColor = true;
            this.ViewListOfPeople.Click += new System.EventHandler(this.ViewPeopleButtonClick);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(29, 204);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(61, 15);
            this.FullNameLabel.TabIndex = 3;
            this.FullNameLabel.Text = "Full Name";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(123, 201);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(272, 23);
            this.FullNameTextBox.TabIndex = 4;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBoxChanged);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(29, 269);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(88, 15);
            this.PhoneNumberLabel.TabIndex = 5;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(123, 266);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(272, 23);
            this.PhoneNumberTextBox.TabIndex = 6;
            this.PhoneNumberTextBox.TextChanged += new System.EventHandler(this.PhoneNumberTextBoxChanged);
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(29, 329);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(88, 33);
            this.DoneButton.TabIndex = 7;
            this.DoneButton.Text = "DONE";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButtonClick);
            // 
            // StartSessionButton
            // 
            this.StartSessionButton.Location = new System.Drawing.Point(746, 58);
            this.StartSessionButton.Name = "StartSessionButton";
            this.StartSessionButton.Size = new System.Drawing.Size(172, 71);
            this.StartSessionButton.TabIndex = 8;
            this.StartSessionButton.Text = "Start Training";
            this.StartSessionButton.UseVisualStyleBackColor = true;
            this.StartSessionButton.Click += new System.EventHandler(this.StartSessionButtonClick);
            // 
            // PersonListTraining
            // 
            this.PersonListTraining.FormattingEnabled = true;
            this.PersonListTraining.Location = new System.Drawing.Point(746, 175);
            this.PersonListTraining.Name = "PersonListTraining";
            this.PersonListTraining.Size = new System.Drawing.Size(172, 238);
            this.PersonListTraining.TabIndex = 9;
            this.PersonListTraining.SelectedIndexChanged += new System.EventHandler(this.SelectPersonTraining_SelectedIndexChanged);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 457);
            this.Controls.Add(this.PersonListTraining);
            this.Controls.Add(this.StartSessionButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.ViewListOfPeople);
            this.Controls.Add(this.CreateNewAccount);
            this.Controls.Add(this.AddPersonToMe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdminView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminView";
            this.Load += new System.EventHandler(this.AdminView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddPersonToMe;
        private Button CreateNewAccount;
        private Button ViewListOfPeople;
        private Label FullNameLabel;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox FullNameTextBox;
        private TextBox PhoneNumberTextBox;
        private Label PhoneNumberLabel;
        private Button DoneButton;
        private Button StartSessionButton;
        private CheckedListBox PersonListTraining;
    }
}