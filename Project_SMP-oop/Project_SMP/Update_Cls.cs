using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace Project_SMP
{
    class Update_Cls
    {
        private string connstring = ConfigurationManager.ConnectionStrings["SMS_DB"].ConnectionString;
        string msg;
        public string updateRecord(STUDENT_CLS student)
        {
            SqlConnection conn = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand("Update_STUDENT", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@std_id", SqlDbType.Int).Value = student.ID;
                cmd.Parameters.Add("@std_Firstname", SqlDbType.VarChar, 30).Value = student.Frname;
                cmd.Parameters.Add("@std_Lastname", SqlDbType.VarChar, 30).Value = student.lastNme;
                cmd.Parameters.Add("@std_Fname", SqlDbType.VarChar, 100).Value = student.fathername;
                cmd.Parameters.Add("@std_Gender", SqlDbType.VarChar, 10).Value = student.gender;
                cmd.Parameters.Add("@std_Address", SqlDbType.VarChar, 99).Value = student.Address;

                conn.Open();
                cmd.ExecuteNonQuery();
                msg = "Data Successfully Updated.";
            }
            catch (Exception)
            {
                msg = "Sorry!Data is not  updated";
            }

            finally
            {
                conn.Close();
            }
            return msg;
        }
    }




}


   

