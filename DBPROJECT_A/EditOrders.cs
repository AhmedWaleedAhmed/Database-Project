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
    public partial class EditOrders : Form
    {
        Controller controlobj;
        int ordertype;
        int Done = 0;
        int orderID;
        int Gid;
        int id;
        public EditOrders(int WID,int Repair0wash1,int Orderid, int GID)
        {
            InitializeComponent();
            textBox2.Enabled = false;
            ordertype = Repair0wash1;
            id = WID;
            orderID = Orderid;
            Gid = GID;
            controlobj = new Controller();
            if (ordertype == 1)
            {
                textBox2.Enabled = false;
                textBox1.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Done = Convert.ToInt32(checkBox1.Checked);
            if( ordertype == 0)
                textBox2.Enabled = (textBox2.Enabled) ? false :true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ordertype == 0)
            {
                controlobj.UpdateOrdersOfWorkshop(orderID, Gid,textBox1.Text, textBox2.Text, Done, (int)numericUpDown1.Value);
            }
            else
            {
                controlobj.UpdateOrdersOfWash(orderID, Gid, Done, (int)numericUpDown1.Value);
            }
            this.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EditOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();

        }
    }
}
