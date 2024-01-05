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
        private bool isShownAddSection = false;
        private bool isShownPersonList = false;
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
            this.SmallStartButton.Hide();

            isShownAddSection = false;
            isShownPersonList = false;
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
            if (!isShownPersonList)
            {
                HideAll();

                isShownPersonList = true;
                this.PersonListTraining.Show();
                this.SmallStartButton.Show();
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
        }

        private void ViewPeopleButtonClick(object sender, EventArgs e)
        {
            HideAll();
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
                    else if(PhoneNumberTextBox.Text.Trim() == "")
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

        }
    }
}
