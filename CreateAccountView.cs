using System.Data.SQLite;

namespace ProiectBD
{
    public partial class CreateAccountView : Form
    {
        SQLiteConnection conn;
        public CreateAccountView(SQLiteConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void CreateAccountView_Load(object sender, EventArgs e)
        {
            this.PasswordTextbox.PasswordChar = '*';
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            SQLiteTransaction transaction = null;

            try
            {
                if (FirstNameTextBox.Text.Trim() == "" || PasswordTextbox.Text.Trim() == "" || PhoneNumberTextbox.Text.Trim() == "" || lastNameTextBox.Text.Trim() == "")
                {
                    MessageBox.Show("Missing Information", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    transaction = conn.BeginTransaction();

                    string insertQueryUsers = "INSERT INTO Users (username, password, type) VALUES (@Username, @Password, @Type)";
                    string insertQueryMembers = "INSERT INTO Members (ID, full_name, phone_number, balance, session_number, coach_id) VALUES ((SELECT MAX(ID) FROM Users), @FullName, @PhoneNumber, 0, 0, NULL)";

                    // User
                    {
                        string Username = GetFormattedName(FirstNameTextBox.Text, lastNameTextBox.Text);
                        SQLiteCommand cmd = new SQLiteCommand(insertQueryUsers, conn, transaction);
                        cmd.Parameters.AddWithValue("@Username", Username);
                        cmd.Parameters.AddWithValue("@Password", PasswordTextbox.Text);
                        cmd.Parameters.AddWithValue("@Type", "M");

                        cmd.ExecuteNonQuery();
                    }

                    // Member
                    {
                        string fullname = $"{FirstNameTextBox.Text} {lastNameTextBox.Text}";
                        SQLiteCommand cmd = new SQLiteCommand(insertQueryMembers, conn, transaction);
                        cmd.Parameters.AddWithValue("@FullName", fullname);
                        cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTextbox.Text);

                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show("Account created!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                transaction?.Rollback();

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                transaction?.Dispose();
            }
        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneNumberTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ViewPasswordCheckBox.Checked)
                this.PasswordTextbox.PasswordChar = '\0';
            else
                this.PasswordTextbox.PasswordChar = '*';
        }

        string GetFormattedName(string firstName,string lastName)
        {
            return $"{firstName}.{lastName}";
        }

        private void FullNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

