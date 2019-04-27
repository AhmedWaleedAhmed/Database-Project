using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBPROJECT_A
{
    public partial class MainCustomer : Form
    {
        String UserName;
        Controller controllerobj;
        public MainCustomer(String CustomerName)
        {
            UserName = CustomerName;
            InitializeComponent();
            controllerobj = new Controller();
            DataRow Customer = controllerobj.GetCustomerBySSN(UserName).Rows[0];
            label1.Text = Customer["UserName"].ToString();
            label2.Text = "   "+ Customer["Email"].ToString();
            label3.Text = "   "+ Customer["Address"].ToString();

            DataTable dt = controllerobj.SelectFreeGarages();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "City";
            comboBox1.ValueMember = "G_ID";
            comboBox1_SelectedIndexChanged(null, null);
            //comboBox1_SelectedValueChanged(null, null);
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("There Is No Garages");
                return;
            }
            DataTable dt = controllerobj.SelectFreeGaragesInCity(Convert.ToInt32(comboBox1.SelectedValue));
            if (dt != null)
            {

                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null)
                return;
            object Obj = controllerobj.getslotid(UserName);
            if (Obj != DBNull.Value)
            {
                MessageBox.Show("You have reserved a slot before );");
                return;
            }
            if (comboBox1.SelectedValue == DBNull.Value)
            {
                MessageBox.Show("Select a Garage To Reserve");
            }
            else
            {
                Form2 f = new Form2((int)dataGridView1.SelectedRows[0].Cells[0].Value, UserName);
                f.Show(this);
                this.Hide();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4(UserName);
            f.Show(this);
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5(UserName);
            f.Show(this);
            this.Hide();
        }

        private void MainCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        //private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    if (comboBox1.SelectedValue == null)
        //    {
        //        MessageBox.Show("There Is No Garages");
        //        return;
        //    }
        //    DataTable dt = controllerobj.SelectFreeGaragesInCity(Convert.ToInt32(comboBox1.SelectedValue));
        //    if (dt != null)
        //    {

        //        dataGridView1.DataSource = dt;
        //    }
        //}
    }
}
