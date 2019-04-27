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
    public partial class Customer_Register : Form
    {
        Controller controllerObj;
        public Customer_Register()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Customer_Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            if (username_Box.Text == "" || password_Box1.Text == "" || password_Box2.Text == "" || email_Box.Text == "" || Adress_Box.Text == "")
                MessageBox.Show("Please fill all the slots");
            else
            {
                if (password_Box1.Text == password_Box2.Text)
                {
                    int check;
                    try
                    { 
                        check = controllerObj.insertCustomer(username_Box.Text, password_Box1.Text, email_Box.Text, Adress_Box.Text, BirthDate_Picker.Value.ToString());
                    }
                    catch(System.FormatException)   //this exception if datatype was not entered correctly
                    {
                        MessageBox.Show("you entered wronge datatypes in the slots");
                        return;
                    }
                    if (check > 0)
                    {
                        MessageBox.Show("registeration done");
                        this.Close();
                         
                    }
                    else
                        MessageBox.Show("registeration error please try again with different username or Email");    //if any thing went wronge
                }
                else
                    MessageBox.Show("you re-Entered wronge password");  //if the two passwords are not identical
            }
        }
    }
}
