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
    public partial class Admin : Form
    {
        Controller controllerObj;
        public Admin()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void AddOwner_Click(object sender, EventArgs e)
        {
            new Owner_Register().Show (this);
            this.Hide();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.getOwnerId();
            ownerDelete.DataSource = dt;
            ownerDelete.DisplayMember = "OwnerId";
            ownerDelete.ValueMember = "OwnerId";
            dt = controllerObj.getCustomerUsername();
            CustomerDelete.DataSource = dt;
            CustomerDelete.DisplayMember = "UserName";
            CustomerDelete.ValueMember = "UserName";
            dt = controllerObj.getAdminID();
            AdminDelete.DataSource = dt;
            AdminDelete.ValueMember = "AdminID";
            AdminDelete.DisplayMember = "AdminID";
        }

        private void DeleteOwner_Click(object sender, EventArgs e)
        {
            if (ownerDelete.SelectedValue != null)
            {
            
            int OwnerId = (int)ownerDelete.SelectedValue;
            DataTable dtGarageid = controllerObj.getOwnerGarageId(OwnerId);
            int gCount = controllerObj.getOwnerGarageCount(OwnerId);
            for (int i = 0; i < gCount; i++)
            {
                controllerObj.DeleteWorker(Convert.ToInt32(dtGarageid.Rows[i][0]));
                DataTable usernames = controllerObj.getUsernamesofGarage(Convert.ToInt32(dtGarageid.Rows[i][0]));
                int usercount = (int)controllerObj.getCountofParkedCustomers(Convert.ToInt32(dtGarageid.Rows[i][0]));
                for(int j=0;j<usercount;j++)
                {
                    controllerObj.deleteGidSlotIdByUsername(Convert.ToString(usernames.Rows[j][0]));
                    controllerObj.delete_Car(Convert.ToString(usernames.Rows[j][0]));
                }
                controllerObj.DeleteSlot(Convert.ToInt32(dtGarageid.Rows[i][0]));
                controllerObj.DeleteGarageRate(Convert.ToInt32(dtGarageid.Rows[i][0]));
                controllerObj.DeleteGarage(Convert.ToInt32(dtGarageid.Rows[i][0]));
            }
            controllerObj.DeleteOwner(OwnerId);
            DataTable dt = controllerObj.getOwnerId();
            ownerDelete.DataSource = dt;
            ownerDelete.DisplayMember = "OwnerId";
            ownerDelete.ValueMember = "OwnerId";
            }
            else
            {
                MessageBox.Show("there is no owner to delete");
            }
        }

        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            if (CustomerDelete.SelectedValue == null)
            {
                MessageBox.Show("there is no Customers to delete");
                return;
            }
            string username = Convert.ToString(CustomerDelete.SelectedValue);
            controllerObj.DeleteCustomerattachments(username);
            controllerObj.DeleteCars(username);
            controllerObj.DeleteCustomer(username);
            DataTable dt = controllerObj.getCustomerUsername();
            CustomerDelete.DataSource = dt;
            CustomerDelete.DisplayMember = "UserName";
            CustomerDelete.ValueMember = "UserName";
        }

        private void DeleteAdmin_Click(object sender, EventArgs e)
        {
            if (AdminDelete.SelectedValue == null)
            {
                MessageBox.Show("there is no Admin to delete");
                return;
            }
            int AdminID = Convert.ToInt32(AdminDelete.SelectedValue);
            controllerObj.DeleteAdmin(AdminID);
            DataTable dt = controllerObj.getAdminID();
            AdminDelete.DataSource = dt;
            AdminDelete.ValueMember = "AdminID";
            AdminDelete.DisplayMember = "AdminID";
        }

        private void AddAdmin_Click(object sender, EventArgs e)
        {
            new Admin_Registration().Show(Owner);
            this.Hide();
        }

        private void SHOW_Click(object sender, EventArgs e)
        {
            
        }
    }
}
