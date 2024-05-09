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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pbstd1_Click(object sender, EventArgs e)
        {

            Student s = new Student();
           
            s.ShowDialog();
            this.Hide();

        }

        private void pictureBox2fee_Click(object sender, EventArgs e)
        {
            Fee f = new Fee();
           
            f.ShowDialog();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            FrmTview tv = new FrmTview();
            
            tv.ShowDialog();
            this.Hide();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            lblstd1.BackColor = Color.Transparent;
            lblfe.BackColor = Color.Transparent;
            lbltch.BackColor = Color.Transparent;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {//close 
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //go back
            FrmLog f = new FrmLog();
            
            f.ShowDialog();
            this.Hide();
        }
    }
}
