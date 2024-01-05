using System.Data;
using System.Data.SQLite;

namespace ProiectBD
{

    public partial class LogInView : Form
    {
        AdminView adminView;
        UserView userView;
        CreateAccountView createAccountView;
        string connectionString;
        public LogInView()
        {
            InitializeComponent();
            connectionString = "Data Source=FinalDB.db;Version=3;";
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (UserInputTextBox.Text == "" && PasswordInputTextBox.Text == "")
            {
                MessageBox.Show("user or password empty", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                string query = "SELECT type FROM Users WHERE username=@Username AND password=@Password";

                SQLiteConnection conn = new SQLiteConnection(connectionString);
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@Username", UserInputTextBox.Text);
                cmd.Parameters.AddWithValue("@Password", PasswordInputTextBox.Text);

                using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        string userType = dataTable.Rows[0]["type"].ToString();
                        if (userType.Equals('C')) //coach
                        {
                            adminView = new AdminView();
                            adminView.FormClosed += SecondView_FormClosed;
                            adminView.Show();
                            this.Hide();
                        }
                        else if (userType.Equals('M')) // member
                        {
                            userView = new UserView();
                            userView.FormClosed += SecondView_FormClosed;
                            userView.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("user or password wrong", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }




            }
        }

        private void CreateAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void UserTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void PasswordView_CheckedChanged(object sender, EventArgs e)
        {
            if (ViewPasswordCheckButton.Checked)
                this.PasswordInputTextBox.PasswordChar = '\0';
            else
                this.PasswordInputTextBox.PasswordChar = '*';

        }

        private void SecondView_FormClosed(object sender, EventArgs e)
        {
            restoreDefault();
            this.Show();
        }

        private void restoreDefault()
        {
            RecenterForm();
            this.UserInputTextBox.Clear();
            this.PasswordInputTextBox.Clear();
            this.ViewPasswordCheckButton.Checked = false;


        }

        private void RecenterForm()
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            int formWidth = this.Width;
            int formHeight = this.Height;

            int xPos = (screenWidth - formWidth) / 2;
            int yPos = (screenHeight - formHeight) / 2;

            this.Location = new Point(xPos, yPos);
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            createAccountView = new CreateAccountView();
            createAccountView.FormClosed += SecondView_FormClosed;
            createAccountView.Show();
            this.Hide();

        }
    }
}