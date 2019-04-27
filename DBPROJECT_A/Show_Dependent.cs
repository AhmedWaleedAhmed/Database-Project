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
    public partial class Show_Dependent : Form
    {
        Controller control;
        string name;
        public Show_Dependent(string n)
        {
            InitializeComponent();
            control = new Controller();
            name = n;
        }

        private void Show_Dependent_Load(object sender, EventArgs e)
        {

        }

        private void Show_Dependent_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = control.Get_Dependents(name);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
