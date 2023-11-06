namespace ProiectBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (UserInputTextBox.TextLength == 0)
                MessageBox.Show("BRAVO FRATE! ai uitat sa pui user", "Popup Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (PasswordInputTextBox.TextLength == 0)
                MessageBox.Show("BRAVO FRATE! ai uitat sa pui parola", "Popup Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (UserInputTextBox.Text.Equals("admin") && PasswordInputTextBox.Text.Equals("admin"))
                    MessageBox.Show("BRAVO FRATE!", "Popup Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("ESTI VAI MORTII TAI GISCA!", "Popup Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}