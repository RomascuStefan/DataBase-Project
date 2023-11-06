namespace ProiectBD
{
    
    public partial class Form1 : Form
    {
        AdminView adminView;
        public Form1()
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
                else
                    MessageBox.Show("gresit user/parola", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
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
    }
}