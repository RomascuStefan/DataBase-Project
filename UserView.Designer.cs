namespace ProiectBD
{
    partial class UserView
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
            ChangeTrainer = new Button();
            TrainersListCheckBox = new CheckedListBox();
            AddBalanceButton = new Button();
            BuySessionsButton = new Button();
            SeeEquipmentButton = new Button();
            AvailableEquipmentList = new ListBox();
            StartSoloTrainButton = new Button();
            SuspendLayout();
            // 
            // ChangeTrainer
            // 
            ChangeTrainer.Location = new Point(12, 12);
            ChangeTrainer.Name = "ChangeTrainer";
            ChangeTrainer.Size = new Size(114, 48);
            ChangeTrainer.TabIndex = 0;
            ChangeTrainer.Text = "Change Trainer";
            ChangeTrainer.UseVisualStyleBackColor = true;
            ChangeTrainer.Click += ChangeTrainerButton_Click;
            // 
            // TrainersListCheckBox
            // 
            TrainersListCheckBox.FormattingEnabled = true;
            TrainersListCheckBox.Location = new Point(12, 79);
            TrainersListCheckBox.Name = "TrainersListCheckBox";
            TrainersListCheckBox.Size = new Size(234, 364);
            TrainersListCheckBox.TabIndex = 1;
            TrainersListCheckBox.SelectedIndexChanged += TraintersListCheckBox_SelectedIndexChanged;
            // 
            // AddBalanceButton
            // 
            AddBalanceButton.Location = new Point(132, 12);
            AddBalanceButton.Name = "AddBalanceButton";
            AddBalanceButton.Size = new Size(114, 48);
            AddBalanceButton.TabIndex = 2;
            AddBalanceButton.Text = "Add Balance";
            AddBalanceButton.UseVisualStyleBackColor = true;
            AddBalanceButton.Click += AddBalanceButton_Click;
            // 
            // BuySessionsButton
            // 
            BuySessionsButton.Location = new Point(252, 12);
            BuySessionsButton.Name = "BuySessionsButton";
            BuySessionsButton.Size = new Size(114, 48);
            BuySessionsButton.TabIndex = 3;
            BuySessionsButton.Text = "Buy Sessions";
            BuySessionsButton.UseVisualStyleBackColor = true;
            BuySessionsButton.Click += BuySessionsButton_Click;
            // 
            // SeeEquipmentButton
            // 
            SeeEquipmentButton.Location = new Point(372, 12);
            SeeEquipmentButton.Name = "SeeEquipmentButton";
            SeeEquipmentButton.Size = new Size(123, 48);
            SeeEquipmentButton.TabIndex = 4;
            SeeEquipmentButton.Text = "See Available Equipment";
            SeeEquipmentButton.UseVisualStyleBackColor = true;
            SeeEquipmentButton.Click += SeeAvailableEquipmentButton_Click;
            // 
            // AvailableEquipmentList
            // 
            AvailableEquipmentList.FormattingEnabled = true;
            AvailableEquipmentList.ItemHeight = 15;
            AvailableEquipmentList.Location = new Point(252, 79);
            AvailableEquipmentList.Name = "AvailableEquipmentList";
            AvailableEquipmentList.Size = new Size(243, 364);
            AvailableEquipmentList.TabIndex = 5;
            AvailableEquipmentList.SelectedIndexChanged += AvailableEquipmentList_SelectedIndexChanged;
            // 
            // StartSoloTrainButton
            // 
            StartSoloTrainButton.Location = new Point(501, 12);
            StartSoloTrainButton.Name = "StartSoloTrainButton";
            StartSoloTrainButton.Size = new Size(123, 48);
            StartSoloTrainButton.TabIndex = 6;
            StartSoloTrainButton.Text = "Start Training Solo";
            StartSoloTrainButton.UseVisualStyleBackColor = true;
            StartSoloTrainButton.Click += StartSoloTrainButton_Click;
            // 
            // UserView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 458);
            Controls.Add(StartSoloTrainButton);
            Controls.Add(AvailableEquipmentList);
            Controls.Add(SeeEquipmentButton);
            Controls.Add(BuySessionsButton);
            Controls.Add(AddBalanceButton);
            Controls.Add(TrainersListCheckBox);
            Controls.Add(ChangeTrainer);
            Name = "UserView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserView";
            Load += UserView_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button ChangeTrainer;
        private CheckedListBox TrainersListCheckBox;
        private Button AddBalanceButton;
        private Button BuySessionsButton;
        private Button SeeEquipmentButton;
        private ListBox AvailableEquipmentList;
        private Button StartSoloTrainButton;
    }
}