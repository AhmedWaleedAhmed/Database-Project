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
    public partial class AdminReport : Form
    {
        int ownerID;
        public AdminReport(int ID)
        {
            InitializeComponent();
            ownerID = ID;
        }

        private void AdminReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.OwnerOfGarage' table. You can move, or remove it, as needed.
            this.GarageTableAdapter.Fill(this.DataSet1.Garage,ownerID);

            this.reportViewer1.RefreshReport();
            

        }

        private void AdminReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }
    }
}
