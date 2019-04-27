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
    public partial class Orders : Form
    {
        Controller controlobj;
        int GID;
        int Repair0wash1 = -1;
        int ID;
        public Orders(int W_ID)
        {
            InitializeComponent();
            controlobj = new Controller();
            GID = controlobj.getGarageIDofWorker(W_ID);
            ID = W_ID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controlobj.GetOrdersOfWS(GID);
            Repair0wash1 = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controlobj.GetOrdersOfWash(GID);
            Repair0wash1 = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Repair0wash1 != -1)
            {
                if (dataGridView1.SelectedRows.Count > 0) {
                    EditOrders f = new EditOrders(ID, Repair0wash1, (int)dataGridView1.SelectedRows[0].Cells[0].Value, GID);
                    f.Show(this);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("no order till now ");
                }
                
            }
            else
            {
                MessageBox.Show("Select Orders First");
            }
        }

        private void Orders_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void Orders_Load(object sender, EventArgs e)
        {

        }
    }
}
