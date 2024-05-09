using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SMP
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

       

        private void pbadm_Click(object sender, EventArgs e)
        {
            Admission obj = new Admission();
            
            obj.Show();
            this.Hide();
        }

        private void pbupd_Click(object sender, EventArgs e)
        {
            update upd = new update();
           
            upd.Show();
            this.Hide();

        }

        private void pbvw_Click(object sender, EventArgs e)
        {
            View v = new View();
           
            v.Show();
            this.Hide();
        }

        private void pbdlt_Click(object sender, EventArgs e)
        {
            Delete d = new Delete();
            d.Show();
            this.Hide();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DashBoard d = new DashBoard();
            d.ShowDialog();
            this.Hide();
           
        }

        private void Student_Load(object sender, EventArgs e)
        {
            lblAd.BackColor = Color.Transparent;
            lblalstd.BackColor = Color.Transparent;
            lblDel.BackColor = Color.Transparent;
            lblup.BackColor = Color.Transparent;
            lblView.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();       //to close
        }
    }
}
