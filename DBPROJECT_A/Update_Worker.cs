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
    public partial class Update_Worker : Form
    {
        Controller control;
        int W_ID;
        public Update_Worker(int id)
        {
            InitializeComponent();
            control = new Controller();
            W_ID = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // the second parameter must be avariable from the counstructor of this form 
            int result = control.UpdateAddress(textBox1.Text.ToString(),W_ID);
            if (result == 0)
            {
                MessageBox.Show("The updateing of the address is failed");
            }
            else
            {
                MessageBox.Show("The address is updated successfully!");
            }
        }

        private void Update_Worker_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // the second parameter must be avariable from the counstructor of this form 
            int result = control.UpdatePassword(textBox2.Text.ToString(), W_ID);
            if (result == 0)
            {
                MessageBox.Show("The updateing of the password is failed");
            }
            else
            {
                MessageBox.Show("The password is updated successfully!");
            }
        }
    }
}
