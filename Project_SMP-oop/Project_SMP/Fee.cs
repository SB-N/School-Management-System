using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_SMP
{
    public partial class Fee : Form
    {
        private string connstring = ConfigurationManager.ConnectionStrings["SMS_DB"].ConnectionString;
        View_cls v = new View_cls();
        string q = " ";
        public Fee()
        {
            InitializeComponent();
        }



        private void btnFFetch_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(connstring);


            //fetch data on basis of given id
            string sql = $"select SA.Sa_ID ,s.std_id,s.std_Firstname,SA.sa_year,SA.Sa_Class_ID,C.Classname ,c.Fees ,C.class_id from STUDENT s inner join Student_status SA  on S. std_id = SA.Sa_ST_ID inner join Classes C on C.class_id = SA.Sa_Class_ID where s.std_id='"+ txtFsId.Text + "' and SA.Sa_year ='"+System.DateTime.Now.Year.ToString()+"' ";
            try
            {
                lblShowFrstN.Font = new Font(lblShowFrstN.Font.FontFamily, 16f);
                lblShowClass.Font = new Font(lblShowClass.Font.FontFamily, 16f);
                lblShowFee.Font = new Font(lblShowFee.Font.FontFamily, 16f);
                lblShowStdI.Font = new Font(lblShowStdI.Font.FontFamily, 16f);
                lblShowFrstN.ForeColor = Color.Red;
                lblShowClass.ForeColor = Color.Red;
                lblShowFee.ForeColor = Color.Red;
                lblShowStdI.ForeColor = Color.Red;
                lblShowFrstN.Text = " ";
                lblShowClass.Text = " ";
                lblShowFee.Text = " ";
                lblShowStdI.Text = " ";

                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    btnFSbmt.Enabled = true;



                    while (reader.Read())
                    {

                        lblShowFrstN.Text = reader.GetValue(2).ToString();
                        lblShowClass.Text = reader.GetValue(5).ToString();
                        lblShowFee.Text = reader.GetValue(6).ToString(); ;
                        lblShowStdI.Text = reader.GetValue(0).ToString();
                    }


                    returnclass rc = new returnclass();
                    string s = rc.scalarReturn($"select count(Fee_ID) from FEE where fee_st_Id='"+txtFsId.Text+"' AND months='"+System.DateTime.Now.Month.ToString()+"'");
                   
                    if (s=="0")
                    {
                        btnFSbmt.Enabled = true;
                        lblFeestsShow.Font = new Font(lblFeestsShow.Font.FontFamily, 20f);
                        lblFeestsShow.Text = "Unpaid";
                        lblFeestsShow.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        lblFeestsShow.Font = new Font(lblFeestsShow.Font.FontFamily, 20f);
                        lblFeestsShow.Text = "paid";
                        lblFeestsShow.ForeColor = System.Drawing.Color.White;
                        btnFSbmt.Enabled = false;
                    }

                }
                else
                {
                    MessageBox.Show("No record Found");
                    btnFSbmt.Enabled = false;
                }
            }

            catch (Exception)
            {
                MessageBox.Show("No record found");
            }
            finally
            {
                connection.Close();
            }
         
           
        }


        private void btnFSbmt_Click(object sender, EventArgs e)
        {
            Std_Status st = new Std_Status();
            st.status_stdId =Convert.ToInt32(txtFsId.Text);
            st.class_fee = lblShowFee.Text;
            st.class_Name = lblShowClass.Text;
            st.status_ID =Convert.ToInt32(lblShowStdI.Text);
            admission_Class ac = new admission_Class();
          ac.insert_Fee(st, txtFsId.Text);
            //same query as above  q = "select s.s_id,s.first,s.last,s.father,s.admission,s.gender from STUDENT inner join ADMINISTRATOR on STUDENT.ad_ID=ADMINISTRATOR.ad_ID where s.first=like '" + txtserch.Text + "%";
            q=$"select SA.Sa_ID as [Status ID],s.std_id as [Student ID],s.std_Firstname as [Student Name],SA.sa_year as [Year],s.std_AdmissionDate as [Admission Date] ,SA.Sa_Class_ID as [Class ID],C.Classname as [Class Name] ,c.Fees as [Fee],C.class_id from STUDENT s inner join Student_status SA  on S. std_id = SA.Sa_ST_ID inner join Classes C on C.class_id = SA.Sa_Class_ID where s.std_id='" + txtFsId.Text + "' and SA.Sa_year ='" + System.DateTime.Now.Year.ToString() + "' ";
           
            dataGridView1.DataSource = v.ShowRec(q);
            returnclass rc = new returnclass();
            string s = rc.scalarReturn($"select count(Fee_ID) from FEE where fee_st_Id = '{txtFsId.Text}' AND months = '{System.DateTime.Now.Month.ToString()}'");//query of video 15
            if (s=="0")
            {
                btnFSbmt.Enabled = true;
                lblFeestsShow.Text = "Unpaid";
                lblFeestsShow.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblFeestsShow.Text = "Paid";
                lblFeestsShow.ForeColor = System.Drawing.Color.Green;
                btnFSbmt.Enabled = false;
            }
        
    }

        private void Fee_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.BackColor = Color.LightSkyBlue;
            dataGridView1.Width = this.ClientSize.Width;
            q = " select s.std_id as [Student ID], sa. Sa_year as [Year],s.std_AdmissionDate as [Admission Date] ,sa.SA_St_ID as [Status ID] ,s.std_Firstname [Student Name],f.fdays as [date],f.months as month,f.fee_Amount as Amount from STUDENT s inner join Student_status sa on s.std_id=sa.Sa_ST_ID inner join FEE f on sa.Sa_ID= f.fee_sa_id where sa. Sa_year='" + System.DateTime.Now.Year.ToString()+"'";
            dataGridView1.DataSource = v.ShowRec(q);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Defaulter d = new Defaulter();
            this.Hide();
            d.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DashBoard d = new DashBoard();
            d.ShowDialog();
            this.Hide();
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void grpBFee_Enter(object sender, EventArgs e)
        {

        }

       
    }
}

