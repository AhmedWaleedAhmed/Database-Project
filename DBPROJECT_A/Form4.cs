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
    public partial class Form4 : Form
    {

        string UserName;
        Controller controllerobj;

        public Form4(string CustomerName)
        {
            InitializeComponent();
            controllerobj = new Controller();
            UserName = CustomerName;

            DataRow dr = controllerobj.GetCustomerBySSN(UserName).Rows[0];
            label5.Text = UserName;
            textBox1.Text = dr["Email"].ToString();
            textBox2.Text = dr["Password"].ToString();
            textBox4.Text = dr["Address"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = controllerobj.UpdateCustomer(textBox1.Text, textBox2.Text, textBox4.Text, UserName);
            if(result == 1)
            {
                MainCustomer f = new MainCustomer(UserName);
                f.Show(this);
                this.Hide();
            }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }
    }
}
