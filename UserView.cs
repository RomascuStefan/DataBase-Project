using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectBD
{

    public partial class UserView : Form
    {
        SQLiteConnection conn;
        private bool isChangeTrainerShown = false;
        private bool isSeeEquipmentShown = false;

        public UserView(SQLiteConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void hideButtons()
        {
            this.ChangeTrainer.Hide();
            this.AddBalanceButton.Hide();
            this.BuySessionsButton.Hide();
            this.SeeEquipmentButton.Hide();
            this.StartSoloTrainButton.Hide();
        }

        private void HideAll()
        {
            this.selectTrainerCombobox.Hide();
            this.AvailableEquipment.Hide();
            this.confirmStartTrainingButton.Hide();
            this.OkButton.Hide();
            this.endTrainingButton.Hide();



            isChangeTrainerShown = false;
            isSeeEquipmentShown = false;
        }

        private void UserView_Load(object sender, EventArgs e)
        {
            HideAll();
            LoadView();
        }

        private void ChangeTrainerButton_Click(object sender, EventArgs e)
        {
            if (!isChangeTrainerShown)
            {
                HideAll();

                isChangeTrainerShown = true;
                LoadTrainers();
                this.selectTrainerCombobox.Show();
                this.OkButton.Show();
            }
        }

        private void LoadTrainers()
        {
            string query = "SELECT id,full_name FROM Coaches";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            selectTrainerCombobox.DisplayMember = "full_name";
            selectTrainerCombobox.DataSource = dataTable;
        }

        private void AddBalanceButton_Click(object sender, EventArgs e)
        {
            HideAll();
            string input = Interaction.InputBox("Enter the balance:", "Add Balance", "");

            if (!string.IsNullOrEmpty(input))
            {
                if (int.TryParse(input, out int balance))
                {
                    string updateQuery = "UPDATE Members SET BALANCE = BALANCE + @Balance WHERE ID = @MemberID";
                    SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, conn);

                    updateCmd.Parameters.AddWithValue("@Balance", balance);
                    updateCmd.Parameters.AddWithValue("@MemberID", LogInView.LoggedInID);

                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show($"Balance added: {balance}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid balance format. Please enter a whole number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void BuySessionsButton_Click(object sender, EventArgs e)
        {

            int userBalance = GetUserBalanceFromDatabase();

            int sessionPrice = 25;
            int maxSessions = userBalance / sessionPrice;

            string inputText = Microsoft.VisualBasic.Interaction.InputBox($"Enter the number of sessions to buy (max: {maxSessions}):", "Buy Sessions", "");
            if (!string.IsNullOrEmpty(inputText))
            {
                if (int.TryParse(inputText, out int selectedSessions) && selectedSessions > 0 && selectedSessions <= maxSessions)
                {
                    int totalPrice = selectedSessions * sessionPrice;
                    UpdateMemberTable(selectedSessions, totalPrice);
                    MessageBox.Show($"Successfully bought {selectedSessions} sessions", "Purchase Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid input", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void UpdateMemberTable(int boughtSessions, int totalPrice)
        {
            string updateQuery = "UPDATE Members SET BALANCE = BALANCE - @TotalPrice, SESSION_NUMBER = SESSION_NUMBER + @BoughtSessions WHERE ID = @MemberID";
            SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, conn);

            updateCmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
            updateCmd.Parameters.AddWithValue("@BoughtSessions", boughtSessions);
            updateCmd.Parameters.AddWithValue("@MemberID", LogInView.LoggedInID);

            updateCmd.ExecuteNonQuery();
        }


        private int GetUserBalanceFromDatabase()
        {
            string query = "SELECT BALANCE FROM Members WHERE ID = @UserId";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", LogInView.LoggedInID);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }




        private void SeeAvailableEquipmentButton_Click(object sender, EventArgs e)
        {
            this.confirmStartTrainingButton.Hide();
            if (!isSeeEquipmentShown)
            {
                HideAll();

                isSeeEquipmentShown = true;
                this.AvailableEquipment.Show();
            }
            LoadAvailableEquipment();
        }

        private void AvailableEquipmentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private int GetSessionCount()
        {
            string selectQuery = "SELECT SESSION_NUMBER FROM Members WHERE ID = @MemberID";
            SQLiteCommand selectCmd = new SQLiteCommand(selectQuery, conn);
            selectCmd.Parameters.AddWithValue("@MemberID", LogInView.LoggedInID);

            object result = selectCmd.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out int sessionCount))
            {
                return sessionCount;
            }
            else
            {
                return 0;
            }
        }


        private void StartSoloTrainButton_Click(object sender, EventArgs e)
        {
            if (!isSeeEquipmentShown)
            {
                HideAll();

                isSeeEquipmentShown = true;
                this.AvailableEquipment.Show();
            }
            LoadAvailableEquipment();
            if (GetSessionCount() > 0)
            {
                confirmStartTrainingButton.Show();
            }
            else
            {
                confirmStartTrainingButton.Hide();
                MessageBox.Show("No Sessions Available", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void OkButtonTrainer_Click(object sender, EventArgs e)
        {
            DataRowView selectedTrainer = (DataRowView)selectTrainerCombobox.SelectedItem;

            if (selectedTrainer != null)
            {

                int selectedTrainerID = Convert.ToInt32(selectedTrainer["ID"]);

                MessageBox.Show($"Selected Trainer ID: {selectedTrainerID}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a trainer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            HideAll();
        }

        private void selectTrainerCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StartTrainingButton_Click(object sender, EventArgs e)
        {
            if (AvailableEquipment.SelectedItems.Count > 0)
            {
                List<string> selectedEquipmentList = new List<string>();

                foreach (object selectedItem in AvailableEquipment.SelectedItems)
                {
                    selectedEquipmentList.Add(selectedItem.ToString());

                    // -1 available equipment
                    string updateEquipmentQuery = "UPDATE Equipment SET AVAILABLE_NUMBER = AVAILABLE_NUMBER - 1 WHERE NAME = @EquipmentName";
                    SQLiteCommand updateEquipmentCmd = new SQLiteCommand(updateEquipmentQuery, conn);
                    updateEquipmentCmd.Parameters.AddWithValue("@EquipmentName", selectedItem.ToString());
                    updateEquipmentCmd.ExecuteNonQuery();
                }

                // Used_Equipment insert
                string insertUsedEquipmentQuery = "INSERT INTO Used_Equipment (NAME, MEMBER_ID) VALUES (@EquipmentName, @MemberID)";
                SQLiteCommand insertUsedEquipmentCmd = new SQLiteCommand(insertUsedEquipmentQuery, conn);

                foreach (string selectedEquipment in selectedEquipmentList)
                {
                    insertUsedEquipmentCmd.Parameters.Clear();
                    insertUsedEquipmentCmd.Parameters.AddWithValue("@MemberID", LogInView.LoggedInID);
                    insertUsedEquipmentCmd.Parameters.AddWithValue("@EquipmentName", selectedEquipment);
                    insertUsedEquipmentCmd.ExecuteNonQuery();
                }

                // isTraining=1
                string updateIsTrainingQuery = "UPDATE Members SET isTraining = 1 WHERE ID = @MemberID";
                SQLiteCommand updateIsTrainingCmd = new SQLiteCommand(updateIsTrainingQuery, conn);
                updateIsTrainingCmd.Parameters.AddWithValue("@MemberID", LogInView.LoggedInID);
                updateIsTrainingCmd.ExecuteNonQuery();

                // -1 session number
                string updateSessionQuery = "UPDATE Members SET SESSION_NUMBER = SESSION_NUMBER - 1 WHERE ID = @MemberID";
                SQLiteCommand command = new SQLiteCommand(updateSessionQuery, conn);
                command.Parameters.AddWithValue("@MemberID", LogInView.LoggedInID);
                command.ExecuteNonQuery();

                MessageBox.Show("Training started successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select at least one equipment before starting training.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadView();
        }



        private void AvailableEquipmentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadAvailableEquipment()
        {

            string query = "SELECT NAME FROM Equipment WHERE AVAILABLE_NUMBER > 0";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            AvailableEquipment.DataSource = dataTable;
            AvailableEquipment.DisplayMember = "NAME";
        }

        private void LoadView()
        {
   
            if (IsMemberTraining())
            {
                HideAll();
                hideButtons();
                this.endTrainingButton.Show();
            }
            else
            {
                LoadFullMenu();
            }
        }


        private void LoadFullMenu()
        {
            HideAll();
          
            ChangeTrainer.Show();
            AddBalanceButton.Show();
            BuySessionsButton.Show();
            SeeEquipmentButton.Show();
            StartSoloTrainButton.Show();
        }

        private bool IsMemberTraining()
        {
            string selectQuery = "SELECT isTraining FROM Members WHERE ID = @MemberID";
            SQLiteCommand selectCmd = new SQLiteCommand(selectQuery, conn);
            selectCmd.Parameters.AddWithValue("@MemberID", LogInView.LoggedInID);

            int isTrainingValue = Convert.ToInt32(selectCmd.ExecuteScalar());

            return (isTrainingValue == 1);
        }

        private void endTrainingButton_Click(object sender, EventArgs e)
        {
            EndTraining();
            LoadView();
        }

        private void EndTraining()
        {
            List<string> usedEquipment = GetUsedEquipment();

            foreach (string equipmentName in usedEquipment)
            {
                string updateEquipmentQuery = "UPDATE Equipment SET AVAILABLE_NUMBER = AVAILABLE_NUMBER + 1 WHERE NAME = @EquipmentName";
                SQLiteCommand updateEquipmentCmd = new SQLiteCommand(updateEquipmentQuery, conn);
                updateEquipmentCmd.Parameters.AddWithValue("@EquipmentName", equipmentName);
                updateEquipmentCmd.ExecuteNonQuery();
            }

            string deleteUsedEquipmentQuery = "DELETE FROM Used_Equipment WHERE MEMBER_ID = @MemberID";
            SQLiteCommand deleteUsedEquipmentCmd = new SQLiteCommand(deleteUsedEquipmentQuery, conn);
            deleteUsedEquipmentCmd.Parameters.AddWithValue("@MemberID", LogInView.LoggedInID);
            deleteUsedEquipmentCmd.ExecuteNonQuery();

            string updateIsTrainingQuery = "UPDATE Members SET isTraining = 0 WHERE ID = @MemberID";
            SQLiteCommand updateIsTrainingCmd = new SQLiteCommand(updateIsTrainingQuery, conn);
            updateIsTrainingCmd.Parameters.AddWithValue("@MemberID", LogInView.LoggedInID);
            updateIsTrainingCmd.ExecuteNonQuery();

            MessageBox.Show("Training ended successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private List<string> GetUsedEquipment()
        {
            List<string> usedEquipment = new List<string>();

            string selectQuery = "SELECT NAME FROM Used_Equipment WHERE MEMBER_ID = @MemberID";
            SQLiteCommand selectCmd = new SQLiteCommand(selectQuery, conn);
            selectCmd.Parameters.AddWithValue("@MemberID", LogInView.LoggedInID);

            using (SQLiteDataReader reader = selectCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    usedEquipment.Add(reader["NAME"].ToString());
                }
            }

            return usedEquipment;
        }

    }
}
