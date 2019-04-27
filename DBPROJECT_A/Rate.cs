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
    public partial class Rate : Form
    {
        Controller controllerObj;
        string user;
        public Rate(string u)
        {
            InitializeComponent();
            user = u;
        }

        private void Rate_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                controllerObj.setDurationCostCustomernull(user);
                new MainCustomer(user).Show(Owner);
            }
        }

        private void Rate_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.checkRateExist(user);
            if (dt == null)
                controllerObj.InsertRate((int)numericUpDown1.Value, user);
            else
                controllerObj.UpdateRate((int)numericUpDown1.Value, user);
            controllerObj.remove_garageid(user);
            this.Close();
        }
    }
}