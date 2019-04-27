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
    public partial class Owner_Register : Form
    {
        Controller controllerObj;
        public Owner_Register()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Owner_Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            //new Admin().Show(Owner);
            //this.Hide();
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            if (username_Box.Text == "" || password_Box1.Text == "" || password_Box2.Text == "" || email_Box.Text == "" || slots_Box.Text == "" || Address_Box.Text == "" || Cost_Box.Text == "" || workerNumber_Box.Text == "" || garagelabelname.Text == "" || Citylabel.Text == "")
                MessageBox.Show("Please fill all the slots");
            else
            {
                if (password_Box1.Text == password_Box2.Text)
                {
                    int check;
                    try
                    {
                        check = controllerObj.insertOwner(username_Box.Text, password_Box1.Text, email_Box.Text, Address_Box.Text, Convert.ToInt32(slots_Box.Text), Convert.ToInt32(Cost_Box.Text), Convert.ToInt32(workerNumber_Box.Text), garagenameBox.Text, CityBox.Text);
                    }
                    catch (System.FormatException)
                    {
                        MessageBox.Show("you entered wronge datatypes in the slots");
                        return;
                    }
                    if (check == 0)
                    {
                        MessageBox.Show("error in Owner registration try again in different Email");
                        return;
                    }
                    if (check == 1)
                    {
                        MessageBox.Show("error in garage registration");
                        return;
                    }
                    MessageBox.Show("registration done");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("you re-Entered wronge passsword");
                }

            }
        }
    }
}
