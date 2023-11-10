namespace ProiectBD
{

    public partial class LogInView : Form
    {
        AdminView adminView;
        UserView userView;
        CreateAccountView createAccountView;
        public LogInView()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (UserInputTextBox.TextLength == 0)
                MessageBox.Show("ai uitat sa pui user", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (PasswordInputTextBox.TextLength == 0)
                MessageBox.Show("ai uitat sa pui parola", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (UserInputTextBox.Text.Equals("admin") && PasswordInputTextBox.Text.Equals("admin"))
                {
                    adminView = new AdminView();
                    adminView.FormClosed += SecondView_FormClosed;
                    adminView.Show();
                    this.Hide();
                }
                else if (UserInputTextBox.Text.Equals("user") && PasswordInputTextBox.Text.Equals("user"))
                {
                    userView = new UserView();
                    userView.FormClosed += SecondView_FormClosed;
                    userView.Show();
                    this.Hide();
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