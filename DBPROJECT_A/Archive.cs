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
    public partial class Archive : Form
    {
        Controller control;
        public Archive()
        {
            InitializeComponent();
            control = new Controller();
        }

        private void Archive_Load(object sender, EventArgs e)
        {
            DataTable dt = control.Get_Car_id_Archive();  // here i will select all employees from the table 
            if (dt != null)
            {
                comboBox1.DataSource = dt;  // put this info in the combobox 
                comboBox1.DisplayMember = "carid";  // this is the value will appear to the user 
                                                    // for each one of this there are another one that i will usee it insteade the value appear to the user 
                comboBox1.ValueMember = "carid";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                int number = Convert.ToInt32(comboBox1.Text);
                
                DataTable dt = control.Get_Archive(number);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("No Cars in the combobox to show it's archive ");
            }
            
        }

        private void Archive_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }
    }
}
