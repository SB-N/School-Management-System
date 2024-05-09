using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Project_SMP
{
    class admission_Class
    {
        private string connstring = ConfigurationManager.ConnectionStrings["SMS_DB"].ConnectionString;
        string msg = "";

       

        public string stdRecord(STUDENT_CLS student)
        {
            SqlConnection conn = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand("insert_tablestudent2", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("@std_id", SqlDbType.Int).Value = student.stdID;
                cmd.Parameters.Add("@std_Firstname ", SqlDbType.VarChar, 30).Value = student.Frname;
                cmd.Parameters.Add("@std_LastName", SqlDbType.VarChar, 30).Value = student.lastNme;
                cmd.Parameters.Add("@std_Fname", SqlDbType.VarChar, 100).Value = student.fathername;
                cmd.Parameters.Add("@std_dateofBirth", SqlDbType.DateTime).Value = student.stdDateofBirth;
                cmd.Parameters.Add("@std_Gender", SqlDbType.VarChar,10).Value = student.gender;
                 cmd.Parameters.Add("@std_Address", SqlDbType.VarChar, 99).Value = student.Address;
                cmd.Parameters.Add("@std_AdmissionDate", SqlDbType.DateTime).Value = student.admissionDate;
                cmd.Parameters.Add("@st_Ad_ID", SqlDbType.Int).Value = student.ad_ID ; 
                conn.Open();
                cmd.ExecuteNonQuery();
                msg = "Data Successfully Inserted.";
            }
            catch (Exception)
            {
                msg = "Sorry!Data is not successfully inserted";
            }
            finally
            {
                conn.Close();
            }
            return msg;

        }

        public void insert_img(Std_Image img)
        {
            SqlConnection conn = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand("insert_Student_img", conn);//calling procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Img_path", SqlDbType.VarChar).Value = img.img_path;
                cmd.Parameters.Add("@img_fk", SqlDbType.Int).Value = img.Student.ID;
                conn.Open();//opening connection
                cmd.ExecuteNonQuery();
                MessageBox.Show("DAta has inserted successfully");
            }
            catch (Exception)//if some error
            {
                MessageBox.Show("data is not inserted");
            }
            finally
            {
                conn.Close();//to close connection
            }
        }
        public void Insert_stdStatus(Std_Status stts)
        {
            SqlConnection conn = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand("insert_Student_status2", conn);//calling procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Sa_ST_ID", SqlDbType.Int).Value = stts.status_stdId;
                cmd.Parameters.Add("@Sa_Class_ID", SqlDbType.Int).Value = stts.class_ID;
                cmd.Parameters.Add("@Sa_year", SqlDbType.VarChar,20).Value = stts.year;
                conn.Open();//opening connection
                cmd.ExecuteNonQuery();
                MessageBox.Show("DAta has inserted successfully");
            }

            finally
            {
                conn.Close();//to close connection
            }
        }
        public void insert_Fee(Std_Status st,string id)    //for Fee
        {
            SqlConnection conn = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand("insert_tableFee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@fee_Amount", SqlDbType.Float).Value = st.class_fee;
                cmd.Parameters.Add("@fdays", SqlDbType.VarChar).Value = System.DateTime.Now.Day.ToString();
                cmd.Parameters.Add("@months", SqlDbType.VarChar).Value = System.DateTime.Now.Month.ToString();
                 cmd.Parameters.Add("@fee_st_Id ", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@fee_sa_id", SqlDbType.Int).Value = st.status_ID;
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fee submitted");

            }
            catch (Exception)
            {
                MessageBox.Show("Data is not inserted");
            }
            finally
            {
                conn.Close();
            }
        }
    }//method end
}


