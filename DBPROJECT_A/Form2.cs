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
    public partial class Form2 : Form
    {
        string UserName;
        int GargeID;
        object Slot;

        Controller controllerobj;

        public Form2(int G_ID,string CustomerName)
        {
            
            InitializeComponent();
            controllerobj = new Controller();
            UserName = CustomerName;                //To make the relation between Customer and Cars and slot 
            GargeID = G_ID;
            Slot = controllerobj.GetRequestedSlot(GargeID);
      
            DataTable dt = controllerobj.GetPromoCode(CustomerName);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "PromoCode";
            comboBox1.ValueMember = "Promocode";

            //Retrive Garage informantion 
            DataRow dr = controllerobj.SelectGaragInfo(G_ID).Rows[0];
            label2.Text = dr["G_ID"].ToString();
            label3.Text ="Address : " + dr["Address"].ToString();
            label4.Text ="Rate : " + dr["RatingValue"].ToString();
            label5.Text = "Cost Of Slot Per Hour : " + dr["SoltCostPerHour"].ToString();
            label9.Text = controllerobj.GetRequestedSlot(GargeID).ToString();
  
        }

        private void Reserve_Click(object sender, EventArgs e)
        {
            if(carIdBox.Text == "" || carTypeBox.Text == "" || carTypeBox.Text == "")
            {
                MessageBox.Show("please fill all the slots");
                return;
            }
            if (controllerobj.GetNumOfFreeSlots(GargeID) == 0)
                return;
            int result1 = 0;
            int result2 = 0;
            int p = (comboBox1.SelectedValue == null) ? 0 : (int)comboBox1.SelectedValue;
            int c = controllerobj.InsertCar(carIdBox.Text, carTypeBox.Text, carColorBox.Text, Convert.ToInt32(checkBox2.Checked), Convert.ToInt32(checkBox1.Checked), UserName);
            if (c == 0)
            {
                MessageBox.Show("error in car insertion");
                return;
            }
            int s = controllerobj.GetCustomerSlot((int)Slot, GargeID, UserName,p);
            if (s == 0)
            {
                MessageBox.Show("error in update the customer and the slot");
                return;
            }
            controllerobj.Requestslot(GargeID, (int)Slot);
            if (checkBox1.Checked)
            {
                result1 = controllerobj.OrderRepair(GargeID,carIdBox.Text);
            }
            
            if (checkBox2.Checked)
            {
                result2 = controllerobj.Orderwash(GargeID, carIdBox.Text);
            }
            if ((checkBox1.Checked && result1 == 1) || (checkBox2.Checked && result2 == 1))
            {
                MessageBox.Show("Reserve Sucsses with repair or wash");
                //login form
            }
            else
            {
                MessageBox.Show("you have reserved without wash or repair");
            }
            this.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }
    }
}
