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
        private bool isShownAddSection = false;
        private bool isShownPersonList = false;
       

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
            }
        }

        private void AdminView_Load(object sender, EventArgs e)
        {
       
            HideAll();
            ClearTextBoxes();

        }

        private void AddPersonButtonClick(object sender, EventArgs e)
        {
            if(!isShownAddSection)
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

        }

        private void SelectPersonTraining_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
