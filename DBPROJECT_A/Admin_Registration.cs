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
    public partial class Admin_Registration : Form
    {
        Controller controllerObj;
        public Admin_Registration()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if(EmailBox.Text == "" || PasswordBox.Text == "" || password2.Text == "")
            {
                MessageBox.Show("please fill all the slots");
                return;
            }
            if (PasswordBox.Text != password2.Text)
            {
                MessageBox.Show("You re-entered wronge password");
                return;
            }
            int R = controllerObj.InsertAdmin(EmailBox.Text, PasswordBox.Text);
            if (R != 0)
                MessageBox.Show("Registration Done");
            else
                MessageBox.Show("Admin Registration Error");
        }

        private void Admin_Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Admin().Show(Owner);
            this.Hide();
            //if (e.CloseReason == CloseReason.UserClosing)
            //   Owner.Show();
        }
    }
}
