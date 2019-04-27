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
    public partial class INFO : Form
    {
        Controller control;
        int ID;
        public INFO(int id)
        {
            InitializeComponent();
            control = new Controller();
            ID = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // from the sign i want to get the name And  Password  of this worker to  make my query 
            DataTable dt = control.SelectWorker(ID);
            label7.Text = dt.Rows[0]["W_ID"].ToString();
            label8.Text = dt.Rows[0]["Name"].ToString();
            label9.Text = dt.Rows[0]["Salary"].ToString();
            label10.Text = dt.Rows[0]["TimeShift"].ToString();
            label11.Text = dt.Rows[0]["Password"].ToString();
            label12.Text = dt.Rows[0]["Address"].ToString();
        }

        private void INFO_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void INFO_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
