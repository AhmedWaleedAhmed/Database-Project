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
    public partial class Form1 : Form
    {
        int W_ID;
        Controller control;
        public Form1(int id)
        {
            InitializeComponent();
            W_ID = id;
            control = new Controller();

            Garage_Name.Text = control.get_garageName(control.Get_GarageID(W_ID));
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            Update_Worker view = new Update_Worker(W_ID);
            view.Show(this);
            this.Hide();

        }

        private void Show_Info_Click(object sender, EventArgs e)
        {
            INFO view = new INFO(W_ID);
            view.Show(this);
            this.Hide();
        }

        private void start_work_Click(object sender, EventArgs e)
        {
            Work view = new Work(W_ID);
            view.Show(this);
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orders f = new Orders(W_ID);
            f.Show(this);
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Archive f = new Archive();
            f.Show(this);
            this.Hide();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
