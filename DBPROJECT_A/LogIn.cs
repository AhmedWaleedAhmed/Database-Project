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
    public partial class LogIn : Form
    {
        Controller controllerObj;
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }

        private void Customer_Button_Click(object sender, EventArgs e)
        {
            new Customer_Register().Show(this);
            this.Hide();
        }

        private void Owner_Button_Click(object sender, EventArgs e)
        {
            new Owner_Register().Show(this);
            this.Hide();
        }

        private void Log_In_Button_Click(object sender, EventArgs e)
        {
            if (OwnerRadio.Checked)
            {
                object check = controllerObj.checkPassword_Owner(usernameBox.Text, passwordBox.Text);
                if (check != null)
                {
                    Owner f = new Owner(Convert.ToInt32(check));
                    f.Show(this);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("you entered wronge username or password owner");
                }
                //show another form
            }
            else if(customerRadio.Checked)
            {
                DataTable d = new DataTable();
                DataTable check = controllerObj.checkPassword_Customer(usernameBox.Text, passwordBox.Text);
                if (check != null)
                {
                    string user = Convert.ToString(check.Rows[0][0]);
                    object Duration = controllerObj.checkonDurationCustomer(user);
                    object Cost = controllerObj.checkonCostCustomer(user);
                    if (Duration != DBNull.Value && Cost != DBNull.Value)
                    {
                        new Rate(user).Show(this);
                        this.Hide();
                    }
                    else
                    {
                        new MainCustomer(user).Show(this);
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("you entered wronge username or password customer");
                }
            }
            else if(workerRadio.Checked)
            {
                object check = controllerObj.checkPassword_Worker(usernameBox.Text, passwordBox.Text);
                if (check != null)
                {
                    new Form1(Convert.ToInt32(check)).Show(this);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("you entered wronge username or password worker");
                }
            }
            else if(AdminRadio.Checked)
            {
                object check = controllerObj.checkPasswordAdmin(usernameBox.Text, passwordBox.Text);
                if (check != null)
                {
                    new Admin().Show(this);
                    this.Hide();
                }
                else
                    MessageBox.Show("you entered wronge username or password for Admin");
            }
        }

    }
}