using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBPROJECT_A
{
    public partial class Garage_Delete : Form
    {
        int ownerID;
        Controller controllerObj;
        public Garage_Delete(int ID)
        {
            InitializeComponent();
            ownerID = ID;
            controllerObj = new Controller();

        }

        private void Garage_Delete_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.getOwnerGarageId(ownerID);
            GarageIDsconmboBox.DataSource = dt;
            GarageIDsconmboBox.DisplayMember = "G_ID";
            GarageIDsconmboBox.ValueMember = "G_ID";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (GarageIDsconmboBox.SelectedValue != null)
            {
                controllerObj.DeleteWorker(Convert.ToInt32(GarageIDsconmboBox.SelectedValue));
                DataTable usernames = controllerObj.getUsernamesofGarage(Convert.ToInt32(GarageIDsconmboBox.SelectedValue));
                int usercount = (int)controllerObj.getCountofParkedCustomers(Convert.ToInt32(GarageIDsconmboBox.SelectedValue));
                for (int j = 0; j < usercount; j++)
                {
                    controllerObj.deleteGidSlotIdByUsername(Convert.ToString(usernames.Rows[j][0]));
                    controllerObj.delete_Car(Convert.ToString(usernames.Rows[j][0]));
                }
                controllerObj.DeleteSlot(Convert.ToInt32(GarageIDsconmboBox.SelectedValue));
                controllerObj.DeleteGarageRate(Convert.ToInt32(GarageIDsconmboBox.SelectedValue));
                controllerObj.DeleteGarage(Convert.ToInt32(GarageIDsconmboBox.SelectedValue));
                DataTable dt = controllerObj.getOwnerGarageId(ownerID);
                GarageIDsconmboBox.DataSource = dt;
                GarageIDsconmboBox.DisplayMember = "G_ID";
                GarageIDsconmboBox.ValueMember = "G_ID";
            }
            else
            {
                MessageBox.Show("there is no garages to delete");
                return;
            }
        }

        private void Garage_Delete_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }
    }
}
