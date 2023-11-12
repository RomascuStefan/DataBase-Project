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

    public partial class UserView : Form
    {
        private bool isChangeTrainerShown = false;
        private bool isSeeEquipmentShown = false;
        public UserView()
        {
            InitializeComponent();

        }

        private void HideAll()
        {
            this.TrainersListCheckBox.Hide();
            this.AvailableEquipmentList.Hide();
            this.OkButton.Hide();

            isChangeTrainerShown = false;
            isSeeEquipmentShown = false;
        }

        private void UserView_Load(object sender, EventArgs e)
        {
            HideAll();
        }

        private void ChangeTrainerButton_Click(object sender, EventArgs e)
        {
            if (!isChangeTrainerShown)
            {
                HideAll();

                isChangeTrainerShown = true;
                this.TrainersListCheckBox.Show();
                this.OkButton.Show();
            }
        }

        private void TraintersListCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddBalanceButton_Click(object sender, EventArgs e)
        {

        }

        private void BuySessionsButton_Click(object sender, EventArgs e)
        {

        }

        private void SeeAvailableEquipmentButton_Click(object sender, EventArgs e)
        {
            if (!isSeeEquipmentShown)
            {
                HideAll();

                isSeeEquipmentShown = true;
                this.AvailableEquipmentList.Show();

            }
        }

        private void AvailableEquipmentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StartSoloTrainButton_Click(object sender, EventArgs e)
        {

        }

        private void OkButton_Click(object sender, EventArgs e)
        {

        }
    }
}
