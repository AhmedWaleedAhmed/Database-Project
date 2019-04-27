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
    public partial class Delete_Worker : Form
    {
        Controller control;
        int oid;
        public Delete_Worker(int num)
        {
            InitializeComponent();
            control = new Controller();
            oid = num;
            DataTable dt = control.show_worker(oid);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void Delete_Worker_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >0)
            {
                int w = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);

                int re = control.Delete_spesific_Worker(w);
                if (re == 0)
                {
                    MessageBox.Show("can't delete this worker");
                }
                else
                {
                    DataTable dt = control.show_worker(oid);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    MessageBox.Show("The worker is deleted ");
                }

            }
            else {
                MessageBox.Show(" there is no worker to delete");
            }
                
        }
    }
}
