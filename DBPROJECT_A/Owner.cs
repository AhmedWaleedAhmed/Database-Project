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
    public partial class Owner : Form
    {
        int owner_id;
        Controller controllerObj;
        public Owner(int o_id)
        {
            InitializeComponent();
            owner_id = o_id;
            controllerObj = new Controller();
        }

        private void Add_Worker_Click(object sender, EventArgs e)
        {
            ADD_Worker f = new ADD_Worker(owner_id);
            f.Show(this);
            this.Hide();
        }

        private void Owner_Load(object sender, EventArgs e)
        {

        }

        private void Delete_Worker_Click(object sender, EventArgs e)
        {
            Delete_Worker f = new Delete_Worker(owner_id);
            f.Show(this);
            this.Hide();
        }

        private void Owner_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void ADD_Garage_Click(object sender, EventArgs e)
        {
            new Insert_Garage(owner_id).Show(this);
            this.Hide();
        }

        private void Delete_Garage_Click(object sender, EventArgs e)
        {
            new Garage_Delete(owner_id).Show(this);
            this.Hide();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.getOwnerGarageId(owner_id);
            if (dt != null)
            {
                int count = controllerObj.getOwnerGarageCount(owner_id);
                for (int i = 0; i < count; i++)
                {
                    controllerObj.CalculateRateOfGarage(Convert.ToInt32(dt.Rows[i][0]));
                }
            }
            new AdminReport(owner_id).Show(this);
            this.Hide();
        }
    }
}
