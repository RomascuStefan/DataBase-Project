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
            AddPersonToMe = new Button();
            ViewListOfPeople = new Button();
            FullNameLabel = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            FullNameTextBox = new TextBox();
            DoneButton = new Button();
            StartSessionButton = new Button();
            PersonListTraining = new CheckedListBox();
            SmallStartButton = new Button();
            PhoneNumberLabel = new Label();
            PhoneNumberTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // AddPersonToMe
            // 
            AddPersonToMe.Location = new Point(29, 58);
            AddPersonToMe.Name = "AddPersonToMe";
            AddPersonToMe.Size = new Size(172, 71);
            AddPersonToMe.TabIndex = 0;
            AddPersonToMe.Text = "Add Person";
            AddPersonToMe.UseVisualStyleBackColor = true;
            AddPersonToMe.Click += AddPersonButtonClick;
            // 
            // ViewListOfPeople
            // 
            ViewListOfPeople.Location = new Point(377, 58);
            ViewListOfPeople.Name = "ViewListOfPeople";
            ViewListOfPeople.Size = new Size(172, 71);
            ViewListOfPeople.TabIndex = 2;
            ViewListOfPeople.Text = "View People";
            ViewListOfPeople.UseVisualStyleBackColor = true;
            ViewListOfPeople.Click += ViewPeopleButtonClick;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(29, 204);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(61, 15);
            FullNameLabel.TabIndex = 3;
            FullNameLabel.Text = "Full Name";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(123, 201);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(272, 23);
            FullNameTextBox.TabIndex = 4;
            FullNameTextBox.TextChanged += FullNameTextBoxChanged;
            // 
            // DoneButton
            // 
            DoneButton.Location = new Point(29, 329);
            DoneButton.Name = "DoneButton";
            DoneButton.Size = new Size(88, 33);
            DoneButton.TabIndex = 7;
            DoneButton.Text = "DONE";
            DoneButton.UseVisualStyleBackColor = true;
            DoneButton.Click += DoneButtonClick;
            // 
            // StartSessionButton
            // 
            StartSessionButton.Location = new Point(746, 58);
            StartSessionButton.Name = "StartSessionButton";
            StartSessionButton.Size = new Size(172, 71);
            StartSessionButton.TabIndex = 8;
            StartSessionButton.Text = "Start Training";
            StartSessionButton.UseVisualStyleBackColor = true;
            StartSessionButton.Click += StartSessionButtonClick;
            // 
            // PersonListTraining
            // 
            PersonListTraining.FormattingEnabled = true;
            PersonListTraining.Location = new Point(746, 175);
            PersonListTraining.Name = "PersonListTraining";
            PersonListTraining.Size = new Size(172, 238);
            PersonListTraining.TabIndex = 9;
            PersonListTraining.SelectedIndexChanged += SelectPersonTraining_SelectedIndexChanged;
            // 
            // SmallStartButton
            // 
            SmallStartButton.Location = new Point(794, 419);
            SmallStartButton.Name = "SmallStartButton";
            SmallStartButton.Size = new Size(84, 31);
            SmallStartButton.TabIndex = 10;
            SmallStartButton.Text = "Start";
            SmallStartButton.UseVisualStyleBackColor = true;
            SmallStartButton.Click += StartButtonSmall_Click;
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(29, 269);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(88, 15);
            PhoneNumberLabel.TabIndex = 5;
            PhoneNumberLabel.Text = "Phone Number";
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(123, 266);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(272, 23);
            PhoneNumberTextBox.TabIndex = 6;
            PhoneNumberTextBox.TextChanged += PhoneNumberTextBoxChanged;
            // 
            // AdminView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 457);
            Controls.Add(SmallStartButton);
            Controls.Add(PersonListTraining);
            Controls.Add(StartSessionButton);
            Controls.Add(DoneButton);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(PhoneNumberLabel);
            Controls.Add(FullNameTextBox);
            Controls.Add(FullNameLabel);
            Controls.Add(ViewListOfPeople);
            Controls.Add(AddPersonToMe);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AdminView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminView";
            Load += AdminView_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddPersonToMe;
        private Button ViewListOfPeople;
        private Label FullNameLabel;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox FullNameTextBox;
        private Button DoneButton;
        private Button StartSessionButton;
        private CheckedListBox PersonListTraining;
        private Button SmallStartButton;
        private TextBox PhoneNumberTextBox;
        private Label PhoneNumberLabel;
    }
}