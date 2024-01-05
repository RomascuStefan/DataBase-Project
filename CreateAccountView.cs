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
            if (NameTextbox.Text.Trim() == "" || PasswordTextbox.Text.Trim() == "" || PhoneNumberTextbox.Text.Trim() == "")
            {
                MessageBox.Show("Missing Information", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string insertQueryUsers = "INSERT INTO Users (username, password, type) VALUES (@Username, @Password, @Type)";
                string insertQueryMembers = "INSERT INTO Members (ID, full_name, phone_number, balance, session_number, coach_id) VALUES ((SELECT MAX(ID) FROM Users), @FullName, @PhoneNumber, 0, 0, NULL)";

                //user
                {
                    string Username = GetFormattedName(NameTextbox.Text);
                    SQLiteCommand cmd = new SQLiteCommand(insertQueryUsers, conn);
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Password", PasswordTextbox.Text);
                    cmd.Parameters.AddWithValue("@Type", "M");

                    cmd.ExecuteNonQuery();
                }
                //member
                {
                    SQLiteCommand cmd = new SQLiteCommand(insertQueryMembers, conn);
                    cmd.Parameters.AddWithValue("@FullName", NameTextbox.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTextbox.Text);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Account created!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

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

        string GetFormattedName(string fullName)
        {
            string[] names = fullName.Split(' ');
            string firstName = names[0].ToLower();
            string lastName = names[1].ToLower();
            string formattedName = $"{firstName}.{lastName}";

            return formattedName;
        }

    }
}

