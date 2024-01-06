using System;
using System.Collections;
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
    public partial class AdminView : Form
    {
        private bool isShownAddSection = false; //AD PERSON
        private bool isShownPersonList = false; //VIEW PEOPLE
        private bool isShownTraining = false;   //START TRAINING
        SQLiteConnection conn;

        public AdminView(SQLiteConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void HideAll()
        {
            this.FullNameLabel.Hide();
            this.FullNameTextBox.Hide();
            this.PhoneNumberLabel.Hide();
            this.PhoneNumberTextBox.Hide();
            this.DoneButton.Hide();

            this.PersonListTraining.Hide();
            for (int i = 0; i < PersonListTraining.Items.Count; i++)
            {
                PersonListTraining.SetItemChecked(i, false);
            }
            this.SmallStartButton.Hide();

            this.dataGridView1.Hide();

            isShownAddSection = false;
            isShownPersonList = false;
            isShownTraining = false;
        }

        private void ShowAddPersonSection()
        {
            if (!isShownAddSection)
            {
                HideAll();

                isShownAddSection = true;

                this.FullNameLabel.Show();
                this.FullNameTextBox.Show();
                this.PhoneNumberLabel.Show();
                this.PhoneNumberTextBox.Show();
                this.DoneButton.Show();
            }
        }

        private void ShowPersonListTraining()
        {
            if (!isShownTraining)
            {
                HideAll();

                isShownTraining = true;

                this.PersonListTraining.Show();
                this.SmallStartButton.Show();
            }
        }

        private void ShowViewPeople()
        {
            if (!isShownPersonList)
            {
                HideAll();

                this.dataGridView1.Show();
            }
        }

        private void AdminView_Load(object sender, EventArgs e)
        {

            HideAll();
            ClearTextBoxes();

        }

        private void AddPersonButtonClick(object sender, EventArgs e)
        {
            if (!isShownAddSection)
                ClearTextBoxes();
            ShowAddPersonSection();
        }



        private void ClearTextBoxes()
        {
            this.FullNameTextBox.Clear();
            this.PhoneNumberTextBox.Clear();

        }

        private void StartSessionButtonClick(object sender, EventArgs e)
        {
            ShowPersonListTraining();

            string selectQuery = "SELECT * FROM Members WHERE SESSION_NUMBER > 0 AND COACH_ID = @CoachID";
            SQLiteCommand selectCmd = new SQLiteCommand(selectQuery, conn);
            selectCmd.Parameters.AddWithValue("@CoachID", LogInView.LoggedInID);

            DataTable dataTable = new DataTable();
            SQLiteDataAdapter adapter = null;

            adapter = new SQLiteDataAdapter(selectCmd);
            adapter.Fill(dataTable);

            // Display the results in a CheckedListBox
            PersonListTraining.DataSource = dataTable;
            PersonListTraining.DisplayMember = "full_name"; 
            PersonListTraining.ValueMember = "ID";

            adapter?.Dispose();


        }

        private void ViewPeopleButtonClick(object sender, EventArgs e)
        {
            ShowViewPeople();
            this.isShownPersonList = true;

            string selectQuery = "SELECT ID, full_name 'FULL NAME',session_number 'SESSION NUMBER' FROM Members WHERE COACH_ID = @CoachID";

            SQLiteCommand selectCmd = new SQLiteCommand(selectQuery, conn);
            selectCmd.Parameters.AddWithValue("@CoachID", LogInView.LoggedInID);

            DataTable dataTable = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectCmd);

            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void FullNameTextBoxChanged(object sender, EventArgs e)
        {

        }
        private void PhoneNumberTextBoxChanged(object sender, EventArgs e)
        {

        }

        private void DoneButtonClick(object sender, EventArgs e)
        {
            int rowsAffected = 0;

            if (FullNameTextBox.Text.Trim() == "" && PhoneNumberTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Missing Information", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string selectQuery;

                if (FullNameTextBox.Text.Trim() == "")
                {
                    selectQuery = "SELECT COUNT(*) FROM Members WHERE PHONE_NUMBER = @Phonenumber";
                }
                else
                {
                    selectQuery = "SELECT COUNT(*) FROM Members WHERE full_name = @full_name";
                }

                // verifica daca exista persoana
                SQLiteCommand selectCmd = new SQLiteCommand(selectQuery, conn);
                selectCmd.Parameters.AddWithValue("@Phonenumber", PhoneNumberTextBox.Text);
                selectCmd.Parameters.AddWithValue("@full_name", FullNameTextBox.Text);

                int recordCount = Convert.ToInt32(selectCmd.ExecuteScalar());

                if (recordCount > 0)
                {
                    if (FullNameTextBox.Text.Trim() == "") //cautare dupa telefon
                    {
                        string updateMember = "UPDATE Members SET COACH_ID= @LoggedInID WHERE PHONE_NUMBER = @Phonenumber";

                        SQLiteCommand cmd = new SQLiteCommand(updateMember, conn);
                        cmd.Parameters.AddWithValue("@LoggedInID", LogInView.LoggedInID);
                        cmd.Parameters.AddWithValue("@Phonenumber", PhoneNumberTextBox.Text);

                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                    else if (PhoneNumberTextBox.Text.Trim() == "")
                    {
                        string updateMember = "UPDATE Members SET COACH_ID= @LoggedInID WHERE full_name = @full_name";

                        SQLiteCommand cmd = new SQLiteCommand(updateMember, conn);
                        cmd.Parameters.AddWithValue("@LoggedInID", LogInView.LoggedInID);
                        cmd.Parameters.AddWithValue("@full_name", FullNameTextBox.Text);

                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        string updateMember = "UPDATE Members SET COACH_ID= @LoggedInID WHERE full_name = @full_name AND PHONE_NUMBER = @Phonenumber";

                        SQLiteCommand cmd = new SQLiteCommand(updateMember, conn);
                        cmd.Parameters.AddWithValue("@LoggedInID", LogInView.LoggedInID);
                        cmd.Parameters.AddWithValue("@full_name", FullNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@Phonenumber", PhoneNumberTextBox.Text);

                        rowsAffected = cmd.ExecuteNonQuery();
                    }

                    if (rowsAffected == 0)
                        MessageBox.Show("Nothing could be changed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("" + rowsAffected + "changes done", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record not found. Nothing could be changed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        private void SelectPersonTraining_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StartButtonSmall_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE Members SET SESSION_NUMBER = SESSION_NUMBER - 1 WHERE ID = @MemberID";
            SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, conn);
            if (PersonListTraining.CheckedItems.Count > 0)
            {
                foreach (DataRowView selectedItem in PersonListTraining.CheckedItems)
                {
                    int memberID = Convert.ToInt32(selectedItem["ID"]);

                    updateCmd.Parameters.Clear();
                    updateCmd.Parameters.AddWithValue("@MemberID", memberID);
                    updateCmd.ExecuteNonQuery();
                }
                MessageBox.Show("Sessions started for selected members.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HideAll();
            }
            else
                MessageBox.Show("No members selected.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
