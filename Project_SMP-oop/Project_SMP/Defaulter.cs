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
    public partial class Defaulter : Form
    {
        
        View_cls v = new View_cls();
        string q = " ";
        
        public Defaulter()
        {
            InitializeComponent();
        }

        private void Defaulter_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.BackColor = Color.LightSkyBlue;
            dataGridView1.Anchor = AnchorStyles.Left |  AnchorStyles.Right | AnchorStyles.Bottom;
            comboBox1D.Text = "2018";
            comboBox1Mon.Text = "1";
            comboBox1Mon.Enabled = false;

            for(int i = 2018; i <= System.DateTime.Now.Year; i++)
            {
                comboBox1D.Items.Add(i.ToString());
            }
            for(int i = 1; i < 12; i++)
            {
                comboBox1Mon.Items.Add(i.ToString());
            }
            q = @"select  s.std_id, sa.SA_ID,s.std_Gender,s.std_Address,c.classname from  STUDENT s inner join Student_status sa on s.std_id=sa.Sa_ST_ID inner join Classes c on sa.Sa_Class_ID=c.class_id   where s.std_id not in (select f.fee_st_Id from Student_status sa inner join FEE f on sa.Sa_Id = f.fee_sa_id where sa.Sa_year = '"+System.DateTime.Now.Year.ToString()+"' and f.months = '"+System.DateTime.Now.Month.ToString()+"')";
            dataGridView1.DataSource = v.ShowRec(q); 

        }

        private void comboBox1D_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1Mon.Enabled = true;
        }

        private void comboBox1Mon_SelectedIndexChanged(object sender, EventArgs e)
        {
            q = $"select  s.std_id, sa.SA_ID,s.std_Gender,s.std_Address,c.classname from  STUDENT s inner join Student_status sa on s.std_id=sa.Sa_ST_ID inner join Classes c on sa.Sa_Class_ID=c.class_id   where s.std_id not in (select f.fee_st_Id from Student_status sa inner join FEE f on sa.Sa_Id = f.fee_sa_id where sa.Sa_year = '"+comboBox1D.SelectedItem.ToString()+"' and f.months = '"+comboBox1Mon.SelectedItem.ToString()+"')";
           // q = "select s.s_id,s.first,s.last,s.father,s.admission,s.gender from STUDENT inner join ADMINISTRATOR on STUDENT.ad_ID=ADMINISTRATOR.ad_ID where s.first=like '" + txtserch.Text + "%";
            dataGridView1.DataSource = v.ShowRec(q);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //go back
            Fee f = new Fee();
           
            f.ShowDialog();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {//close
            Application.Exit();
        }
    }
}
