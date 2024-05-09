using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Project_SMP
{
    class Hire
    {
        private string connstring = ConfigurationManager.ConnectionStrings["SMS_DB"].ConnectionString;
        string msg = "";

        internal Teacher_cl Teacher_cl
        {
            get => default;
            set
            {
            }
        }

        public string HireTeacher(Teacher_cl t)
        {
            SqlConnection conn = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand("ins_Tea", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("@std_id", SqlDbType.Int).Value = student.stdID;
                cmd.Parameters.Add("@T_Name", SqlDbType.VarChar, 70).Value = t.Frname;
                
                cmd.Parameters.Add("@T_Gender", SqlDbType.VarChar, 10).Value = t.gender;
                cmd.Parameters.Add("@T_Address", SqlDbType.VarChar, 99).Value = t.Address;
                cmd.Parameters.Add("@joind", SqlDbType.DateTime).Value =t.JoiningDate;
                cmd.Parameters.Add("@Phone", SqlDbType.VarChar,80).Value = t.Phone;
                cmd.Parameters.Add("@Salary", SqlDbType.Float).Value = t.salary;
                cmd.Parameters.Add("@T_Ad_ID", SqlDbType.Int).Value = t.ad_ID;
                cmd.Parameters.Add("@Education", SqlDbType.VarChar,50).Value = t.Education;
                conn.Open();
                cmd.ExecuteNonQuery();
                msg = "Data Successfully Inserted.";
            }
            //catch (Exception)
            //{
            //    msg = "Sorry!Data is not successfully inserted";
            //}
            finally
            {
                conn.Close();
            }
            return msg;

        }
    
   


    public DataTable ShowH(string query)
    {
        DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection(connstring);
        SqlCommand cmd = new SqlCommand(query, conn);
        try
        {
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dt.Load(dr);
            }

            else
            {
                MessageBox.Show("No Record Found");
            }

        }
        catch (Exception)
        {
            MessageBox.Show("No Records were Found!");
        }
        finally
        {
            conn.Close();
        }
        return dt;
    }
}
}

