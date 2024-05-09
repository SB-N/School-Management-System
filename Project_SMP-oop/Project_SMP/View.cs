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
    public partial class View : Form
    {

        View_cls v = new View_cls();
        string q = " ";

        public View()
        {
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {
          dataGridView1sh.DefaultCellStyle.BackColor = Color.LightSkyBlue; // Change to your desired color
            


            //     q = "select * from student_Record";
            q = "select std_id as ID,std_Firstname as [First Name],std_Lastname as [Last Name],std_Address as [Address],std_dateofBirth as [Date of Birth],std_AdmissionDate as [Admission Date] ,st_Ad_ID  as [Admin ID] from STUDENT";
            dataGridView1sh.DataSource = v.ShowRec(q);
        }

        private void txtserch_KeyUp(object sender, KeyEventArgs e)
        {
            //for showing specified record
           // q = "select s.s_id,s.first,s.last,s.father,s.admission,s.gender from STUDENT inner join ADMINISTRATOR on STUDENT.ad_ID=ADMINISTRATOR.ad_ID where s.first=like '" + txtserch.Text + "%";
           q = $"select st.std_id as ID,st.std_Firstname as [First Name], st.std_Lastname as [Last Name],st.std_Address as [Address],st.std_dateofBirth as [Date of Birth],st.std_AdmissionDate as [Admission Date] ,ad.Ad_name  as [Admin Name] from STUDENT st inner join Administator ad on ad.Ad_ID = st.st_Ad_ID where st.std_Firstname like '{txtserch.Text}'+ '%'";
            dataGridView1sh.DataSource = v.ShowRec(q);
        }

        private void btn1shw_Click(object sender, EventArgs e)
        {
           // q = "select s.s_id,s.first,s.last,s.father,s.admission,s.gender from STUDENT inner join ADMINISTRATOR on STUDENT.ad_ID=ADMINISTRATOR.ad_ID where s.first= '" + txtsrchID.Text + "'";
            q = $"select st.std_id as ID,st.std_Firstname as [First Name],st.std_Lastname as [Last Name] ,st.std_Address as [Address] ,st.std_dateofBirth as [Date of Birth],st.std_AdmissionDate as [Admission Date],ad.Ad_name as [Admin Name] from STUDENT st inner join Administator ad on ad.Ad_ID = st.st_Ad_ID where st.std_id='{txtsrchID.Text}'";
         
            dataGridView1sh.DataSource = v.ShowRec(q);
           

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            q = "select * from STUDENT";
            dataGridView1sh.DataSource = v.ShowRec(q);
        }

        private void pictureBox2_Click(object sender, EventArgs e)//to go back
        {
            Student s = new Student();
            
            s.ShowDialog();
            this.Hide();
        }

        private void txtserch_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();//to close
        }
    }
}




