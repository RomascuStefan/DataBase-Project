namespace ProiectBD
{
    public partial class CreateAccountView : Form
    {
        public CreateAccountView()
        {
            InitializeComponent();
        }

        private void CreateAccountView_Load(object sender, EventArgs e)
        {
            this.PasswordTextbox.PasswordChar = '*';
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            
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
    }
}
