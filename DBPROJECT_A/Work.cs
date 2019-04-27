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
    public partial class Work : Form
    {
        Controller control;
        int ID;
        decimal total_pay;
        decimal cost;
        //int counter = 0;
        public Work(int id)
        {
            InitializeComponent();
            control = new Controller();
            ID = id;

            DateTime date = DateTime.Now;
            if (date.Day == 1 )
            {
                button6.Enabled = true;
                //counter = 1;
            }
            else
            {
                button6.Enabled = false;
               // counter = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Confirm_Cash view = new Confirm_Cash();
            //view.Show(this);
            //this.Hide();
            if (comboBox2.Text != "")
            {
                int result = control.Free(control.Get_GarageID(ID), Convert.ToInt32(comboBox2.Text));
                if (result == 0)
                {
                    MessageBox.Show("The Slot isnot free ");
                }
                else
                {
                    int res = control.Set_ENDTime(control.Get_GarageID(ID), Convert.ToInt32(comboBox2.Text));

                    //MessageBox.Show("The Slot isn't free ");
                    DataTable dt = control.Get_Slot(control.Get_GarageID(ID), Convert.ToInt32(comboBox2.Text));
                    TimeSpan start = (TimeSpan)(dt.Rows[0]["StartUse"]);
                    TimeSpan end = (TimeSpan)(dt.Rows[0]["EndUse"]);
                    decimal total_houres = end.Hours - start.Hours;
                    decimal total_minutes = end.Minutes - start.Minutes;
                    //int total_seconds = end.Seconds - start.Seconds;
                    while (total_minutes > 60)
                    {
                        total_minutes -= 60;
                        total_houres++;
                    }
                    if (total_minutes >= 10)
                    {
                        total_minutes /= 100;
                    }
                    else {
                        total_minutes /= 10;
                    }
                    
                    decimal diuration = total_houres + total_minutes;
                    decimal cost_hour = control.Get_SoltCostPerHour(control.Get_GarageID(ID));
                    //decimal cost_minute = cost_hour / 60;
                    //decimal pay_hour = total_houres * cost_hour;
                    //decimal pay_Minute = total_minutes * cost_minute;
                    DataTable s = control.get_activepromo_from_user(control.Get_GarageID(ID), Convert.ToInt32(comboBox2.Text));
                    if ( s != null && Convert.ToInt32(s.Rows[0][0])!=0)
                    {
                        total_pay = diuration * cost_hour;
                        decimal n = total_pay * 25 / 100;
                        total_pay -= n;
                        control.delete_promo(control.get_Username2(control.Get_GarageID(ID), Convert.ToInt32(comboBox2.Text)), (int)s.Rows[0][0]);
                        control.set_activepromocode(control.Get_GarageID(ID), Convert.ToInt32(comboBox2.Text));
                    }
                    else {
                        total_pay = diuration * cost_hour;
                    }
                    decimal profit = control.getGarage_Profit(control.Get_GarageID(ID));
                    profit += total_pay;
                    int ret = control.update_profit(control.Get_GarageID(ID), profit);
                    if (ret == 0)
                    {
                        MessageBox.Show("the update is wrong");
                    }
                    else
                    {
                        MessageBox.Show("The profit is updated ");
                    }
                    control.update_COST_Customer(control.Get_GarageID(ID), Convert.ToInt32(comboBox2.Text), total_pay);
                    control.update_Duration_Customer(control.Get_GarageID(ID), Convert.ToInt32(comboBox2.Text), diuration);

                    ////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    string user_name = control.get_Username2(control.Get_GarageID(ID), Convert.ToInt32(comboBox2.Text));
                    int q = control.MoveOrder(user_name);
                    control.DeleteFromWash(user_name);
                    int re = control.delete_Car(user_name);
                    
                    if (re == 0)
                    {
                        MessageBox.Show("The car wasn't deleted");
                    }
                    else
                    {
                        MessageBox.Show("The Car is deleted ");
                    }

                  
                    ///////////////////////////////////////////////////////////////////////////////////////////////////////////

                    control.update_all_times(control.Get_GarageID(ID), Convert.ToInt32(comboBox2.Text));

                    control.remove_SlotID_from_Customer(control.Get_GarageID(ID), Convert.ToInt32(comboBox2.Text));
                    MessageBox.Show("The Slot is free \n" +
                          "The Duration = " + diuration + "\n"
                          + "The total cost = " + total_pay + "\n"
                          + "The cost per hour in the garage = " + cost_hour);
                    control.inc_number_slots(control.Get_GarageID(ID));
                }
            }
            else
            {
                MessageBox.Show("The ComboBox Is Empty ");
            }
            DataTable dtt = control.Select_The_Request(control.Get_GarageID(ID)); // here i will select all employees from the table 
            comboBox1.DataSource = dtt; // put this info in the combobox 
            comboBox1.DisplayMember = "Slot_ID";  // this is the value will appear to the user 

            DataTable dt1 = control.Select_The_reserved(control.Get_GarageID(ID)); // here i will select all employees from the table 
            comboBox2.DataSource = dt1;  // put this info in the combobox 
            comboBox2.DisplayMember = "Slot_ID";  // this is the value will appear to the user 

            DateTime date = DateTime.Now;
            if (date.Day == 1)
            {
                button6.Enabled = true;
                //counter = 1;
            }
            else
            {
                button6.Enabled = false;
                //counter = 0;
            }
        }

        private void Work_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                int result = control.Accept_Request(control.Get_GarageID(ID), Convert.ToInt32(comboBox1.Text));
                
                if (result == 0)
                {
                    MessageBox.Show("The Request isn't accepted ");
                }
                else
                {
                    int res = control.Set_StartTime(control.Get_GarageID(ID), Convert.ToInt32(comboBox1.Text));
                    if (res == 0)
                    {
                        MessageBox.Show(" The Slots isn't Reserved");
                    }
                    else
                    {
                        control.dec_number_slots(control.Get_GarageID(ID));
                        MessageBox.Show("The Slots is Reserved");
                    }
                }
            }
            else
            {
                MessageBox.Show("The ComboBox Is Empty ");
            }
            DataTable dt = control.Select_The_Request(control.Get_GarageID(ID)); // here i will select all employees from the table 
            comboBox1.DataSource = dt;  // put this info in the combobox 
            comboBox1.DisplayMember = "Slot_ID";  // this is the value will appear to the user 

            DataTable dt1 = control.Select_The_reserved(control.Get_GarageID(ID)); // here i will select all employees from the table 
            comboBox2.DataSource = dt1;  // put this info in the combobox 
            comboBox2.DisplayMember = "Slot_ID";  // this is the value will appear to the user 

            DateTime date = DateTime.Now;
            if (date.Day == 1   )
            {
                button6.Enabled = true;
                //counter = 1;
            }
            else
            {
                button6.Enabled = false;
               // counter = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = control.Select_The_Request(control.Get_GarageID(ID)); // here i will select all employees from the table 
            comboBox1.DataSource = dt;  // put this info in the combobox 
            comboBox1.DisplayMember = "Slot_ID";  // this is the value will appear to the user 

            DataTable dt1 = control.Select_The_reserved(control.Get_GarageID(ID)); // here i will select all employees from the table 
            comboBox2.DataSource = dt1;  // put this info in the combobox 
            comboBox2.DisplayMember = "Slot_ID";  // this is the value will appear to the user 

            DateTime date = DateTime.Now;
            if (date.Day == 1 )
            {
                button6.Enabled = true;
                //counter = 1;
            }
            else
            {
                button6.Enabled = false;
                //counter = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "")
            {
                DataTable n = control.Get_UserName(control.Get_GarageID(ID), Convert.ToInt32(comboBox2.Text));


                string name = n.Rows[0]["UserName"].ToString();
                Show_Dependent view = new Show_Dependent(name);
                view.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("no slot is selected to check about its customer");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            object promocode = control.Get_Max_prormo();
            int promo;
            if (promocode == DBNull.Value)
            {
                promo = 1;
            }
            else
            {
                promo = Convert.ToInt32(promocode);
                promo++;
            }
            object times = control.Get_Max_numberOftimes_INGarage();
            if (times == DBNull.Value)
            {
                times = 1;
            }
            DataTable username = control.userNames_TOGetPromoCode(Convert.ToInt32(times));
            int num = control.getnumofcustomer(Convert.ToInt32(times));
            if (num <= 0)
            {
                MessageBox.Show("no slot is selected to check about its customer");
            }
            else
            {
                for (int i = 0; i < num; i++)
                {
                    control.insert_into_promocode(username.Rows[i][0].ToString(), promo);
                    promo++;
                }
            }
            button6.Enabled = false;
        }

        private void Work_Load(object sender, EventArgs e)
        {
            DataTable dt = control.Select_The_Request(control.Get_GarageID(ID)); // here i will select all employees from the table 
            comboBox1.DataSource = dt;  // put this info in the combobox 
            comboBox1.DisplayMember = "Slot_ID";  // this is the value will appear to the user 

            DataTable dt1 = control.Select_The_reserved(control.Get_GarageID(ID)); // here i will select all employees from the table 
            comboBox2.DataSource = dt1;  // put this info in the combobox 
            comboBox2.DisplayMember = "Slot_ID";  // this is the value will appear to the user 

            DateTime date = DateTime.Now;
            if (date.Day == 1 )
            {
                button6.Enabled = true;
                //counter = 1;
            }
            else
            {
                button6.Enabled = false;
                //counter = 0;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            object promocode = control.Get_Max_prormo();
            int promo;
            if (promocode == DBNull.Value)
            {
                promo = 1;
            }
            else
            {
                promo = Convert.ToInt32(promocode);
                promo++;
            }
            object times = control.Get_Max_numberOftimes_INGarage();
            if (times == DBNull.Value)
            {
                times = 1;
            }
            DataTable username = control.userNames_TOGetPromoCode(Convert.ToInt32(times));
            int num = control.getnumofcustomer(Convert.ToInt32(times));
            if (num <= 0)
            {
                MessageBox.Show("no slot is selected to check about its customer");
            }
            else
            {
                for (int i = 0; i < num; i++)
                {
                    control.insert_into_promocode(username.Rows[i][0].ToString(), promo);
                    promo++;
                }
            }
            button6.Enabled = false;
        }
    }
}
