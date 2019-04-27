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
    public partial class ADD_Worker : Form
    {
        int owner_id;
        Controller control;
        public ADD_Worker(int o_id)
        {
            InitializeComponent();
            owner_id = o_id;
            control = new Controller();

            DataTable dt = control.Get_garageid_from_ownerid(owner_id);  // here i will select all employees from the table 
            gid.DataSource = dt;  // put this info in the combobox 
            gid.DisplayMember = "Garage_Name";  // this is the value will appear to the user 
                                                // for each one of this there are another one that i will usee it insteade the value appear to the user 
            gid.ValueMember = "G_ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || address.Text == "" || salary.Text == "" || email.Text == "" || password.Text == "" || time.Text == "" || gid.SelectedValue == null || textBox1.Text=="")
            {
                MessageBox.Show("Please fill all the informations");
                return;
            }

            if (password.Text != textBox1.Text)
            {
                MessageBox.Show("wronge reentering the password ");
                return;
            }
            try
            {
                int re = control.insert_worker(name.Text.ToString(), Convert.ToDecimal(salary.Text.ToString()), TimeSpan.Parse(time.Text), password.Text.ToString(), address.Text.ToString(), email.Text.ToString(), Convert.ToInt32(gid.SelectedValue.ToString()));
            }
            catch(System.FormatException)
            {
                MessageBox.Show("wronge Datatype has been inserted");
                return; 
            }
            //if (re == 0)
            //{
            //    MessageBox.Show("The insertion failed");

            //}
            //else {
            //    MessageBox.Show("The insertion is done");
            //}
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ADD_Worker_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }
    }
}
