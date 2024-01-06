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
            AddBalanceButton = new Button();
            BuySessionsButton = new Button();
            SeeEquipmentButton = new Button();
            StartSoloTrainButton = new Button();
            OkButton = new Button();
            selectTrainerCombobox = new ComboBox();
            confirmStartTrainingButton = new Button();
            AvailableEquipment = new CheckedListBox();
            endTrainingButton = new Button();
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
            // OkButton
            // 
            OkButton.Location = new Point(189, 78);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(46, 23);
            OkButton.TabIndex = 7;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButtonTrainer_Click;
            // 
            // selectTrainerCombobox
            // 
            selectTrainerCombobox.FormattingEnabled = true;
            selectTrainerCombobox.Location = new Point(12, 79);
            selectTrainerCombobox.Name = "selectTrainerCombobox";
            selectTrainerCombobox.Size = new Size(171, 23);
            selectTrainerCombobox.TabIndex = 8;
            selectTrainerCombobox.SelectedIndexChanged += selectTrainerCombobox_SelectedIndexChanged;
            // 
            // confirmStartTrainingButton
            // 
            confirmStartTrainingButton.Location = new Point(469, 407);
            confirmStartTrainingButton.Name = "confirmStartTrainingButton";
            confirmStartTrainingButton.Size = new Size(86, 25);
            confirmStartTrainingButton.TabIndex = 9;
            confirmStartTrainingButton.Text = "Start Training";
            confirmStartTrainingButton.UseVisualStyleBackColor = true;
            confirmStartTrainingButton.Click += StartTrainingButton_Click;
            // 
            // AvailableEquipment
            // 
            AvailableEquipment.FormattingEnabled = true;
            AvailableEquipment.Location = new Point(372, 78);
            AvailableEquipment.Name = "AvailableEquipment";
            AvailableEquipment.Size = new Size(252, 292);
            AvailableEquipment.TabIndex = 10;
            AvailableEquipment.SelectedIndexChanged += AvailableEquipmentListBox_SelectedIndexChanged;
            // 
            // endTrainingButton
            // 
            endTrainingButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            endTrainingButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            endTrainingButton.Location = new Point(252, 371);
            endTrainingButton.Name = "endTrainingButton";
            endTrainingButton.Size = new Size(146, 61);
            endTrainingButton.TabIndex = 11;
            endTrainingButton.Text = "End Training";
            endTrainingButton.UseVisualStyleBackColor = true;
            endTrainingButton.Click += endTrainingButton_Click;
            // 
            // UserView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 458);
            Controls.Add(endTrainingButton);
            Controls.Add(AvailableEquipment);
            Controls.Add(confirmStartTrainingButton);
            Controls.Add(selectTrainerCombobox);
            Controls.Add(OkButton);
            Controls.Add(StartSoloTrainButton);
            Controls.Add(SeeEquipmentButton);
            Controls.Add(BuySessionsButton);
            Controls.Add(AddBalanceButton);
            Controls.Add(ChangeTrainer);
            Name = "UserView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserView";
            Load += UserView_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button ChangeTrainer;
        private Button AddBalanceButton;
        private Button BuySessionsButton;
        private Button SeeEquipmentButton;
        private Button StartSoloTrainButton;
        private Button OkButton;
        private ComboBox selectTrainerCombobox;
        private Button confirmStartTrainingButton;
        private CheckedListBox AvailableEquipment;
        private Button endTrainingButton;
    }
}