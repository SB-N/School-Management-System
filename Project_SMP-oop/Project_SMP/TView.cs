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
    public partial class FrmTview : Form
    {
        public FrmTview()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)//to go back
        {
            DashBoard d = new DashBoard();
            d.ShowDialog();
            this.Hide();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Salary sal = new Salary();
            sal.ShowDialog();
            this.Hide();
        }
    }     
}
