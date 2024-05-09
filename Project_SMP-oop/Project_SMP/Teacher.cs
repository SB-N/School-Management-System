using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Project_SMP
{
    public partial class Teacher : Form
    {

        Hire h = new Hire();
        public Teacher()
        {
            InitializeComponent();
        }

        private void btnTAdd_Click(object sender, EventArgs e)
        {
            Teacher_cl tc = new Teacher_cl();
            tc.ad_ID = FrmLog.fk_adId;
         
            MessageBox.Show($"  {tc.ad_ID } as Admin");
            tc.Frname = txtTNme.Text;
            tc.Phone = txtTPhn.Text;
            if (rdbTMl.Checked == true)
            {
                tc.gender = "Male";
            }
            else if ( rdbnTFm.Checked == true)
            {
                tc.gender = "Female";
            }
            tc.Education = comboBox1Ed.SelectedItem.ToString();
            tc.JoiningDate = dateTimePicker1T.Value;
            tc.Address = richtTAd.Text;
            tc.salary =Convert.ToInt32(txtsal.Text);
            if (tc.JoiningDate > DateTime.Now)
            {
                MessageBox.Show("Invalid Joining Date. Please select a valid date.");
                return; // Exit the method if the date is invalid
            }
            MessageBox.Show( h.HireTeacher(tc));

        }

        private void lblTeavher_Click(object sender, EventArgs e)
        {

        }

        private void Teacher_Load(object sender, EventArgs e)
        {//on load  not enaable

            dataGridViewTTT.DefaultCellStyle.BackColor = Color.LightSkyBlue;
            txtTPhn.Enabled = false;
            dateTimePicker1T.Enabled = false;
            comboBox1Ed.Enabled = false;
            rdbnTFm.Enabled = false;
            rdbTMl.Enabled = false;
            btnTAdd.Enabled = false;
          string  qs = "select * from Teacher";
         dataGridViewTTT.DataSource=h.ShowH(qs);
            lblsl.Enabled = false;

        }


       

        private void txtTNme_TextChanged(object sender, EventArgs e)
        {
            txtTPhn.Enabled = true;

        }

        private void txtTPhn_TextChanged(object sender, EventArgs e)
        {
            rdbTMl.Enabled = true;
            rdbnTFm.Enabled = true;
            comboBox1Ed.Enabled = true;
            lblsl.Enabled = true;
        }

        private void comboBox1Ed_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker1T.Enabled = true;
        }

        private void dateTimePicker1T_ValueChanged(object sender, EventArgs e)
        {
            richtTAd.Enabled = true;
        }

        private void richtTAd_TextChanged(object sender, EventArgs e)
        {
            btnTAdd.Enabled = true;
        }

        private void btnref_Click(object sender, EventArgs e)
        {//on refresh disable
            //txtTchID.Enabled = false;
            txtTNme.Enabled = false;
            txtTPhn.Enabled = false;
            dateTimePicker1T.Enabled = false;
            comboBox1Ed.Enabled = false;
            rdbnTFm.Enabled = false;
            rdbTMl.Enabled = false;
            btnTAdd.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmTview t = new FrmTview();
            t.ShowDialog();
            this.Hide();
           
        }
    }
    
    }
        
    
