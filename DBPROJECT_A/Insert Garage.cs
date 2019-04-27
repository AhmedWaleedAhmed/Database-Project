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
    public partial class Insert_Garage : Form
    {
        int ownerId;
        Controller controllerObj;
        public Insert_Garage(int ID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            ownerId = ID;
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            if(garagenameBox.Text == "" || slots_Box.Text == "" || Address_Box.Text == "" || Cost_Box.Text == "" || workerNumber_Box.Text == "" || CityBox.Text == "")
            {
                MessageBox.Show("Please fill all garage information");
                return;
            }
            int check;
            try
            {
                check = controllerObj.insertGarage(garagenameBox.Text, Convert.ToInt32(slots_Box.Text), Address_Box.Text, Convert.ToInt16(Cost_Box.Text), Convert.ToInt32(workerNumber_Box.Text), CityBox.Text, ownerId);
            }
            catch(System.FormatException)
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

        private void Insert_Garage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }
    }
}
