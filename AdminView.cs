using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectBD
{
    public partial class AdminView : Form
    {
        private bool isShownAddCreate = false;
        private bool isShownPersonList = false;
        private enum SectionType {Create,Add};
        private SectionType lastPressed = SectionType.Create;

        public AdminView()
        {
            InitializeComponent();
            HideAll();
        }

        private void HideAll()
        {
            this.FullNameLabel.Hide();
            this.FullNameTextBox.Hide();
            this.PhoneNumberLabel.Hide();
            this.PhoneNumberTextBox.Hide();
            this.DoneButton.Hide();

            this.PersonListTraining.Hide();

            isShownAddCreate = false;
            isShownPersonList = false;
        }

        private void ShowAddCreateSection()
        {
            if(!isShownAddCreate)
            {
                HideAll();

                isShownAddCreate = true;

                this.FullNameLabel.Show();
                this.FullNameTextBox.Show();
                this.PhoneNumberLabel.Show();
                this.PhoneNumberTextBox.Show();
                this.DoneButton.Show();
            }
        }

        private void ShowPersonListTraining()
        {
            if(!isShownPersonList)
            {
                HideAll();

                isShownPersonList = true;

                this.PersonListTraining.Show();

            }
        }

        private void AdminView_Load(object sender, EventArgs e)
        {

        }

        private void AddPersonButtonClick(object sender, EventArgs e)
        {
            ShowAddCreateSection();
            lastPressed = SectionType.Add;
        }

        private void CreateNewAccountButtonClick(object sender, EventArgs e)
        {
            ShowAddCreateSection();
            ClearTextBoxes();
            lastPressed = SectionType.Create;
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
            switch (lastPressed)
            {
                case SectionType.Add:

                    break;
                case SectionType.Create:

                    break;
                    
            }
        }

        private void SelectPersonTraining_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
