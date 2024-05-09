using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace Project_SMP
{
    class DelteR
    {

        private string connstring = ConfigurationManager.ConnectionStrings["SMS_DB"].ConnectionString;
        string msg = "";
        public string stddelete(int id)
        {
            SqlConnection conn = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand("Delete_Student1", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@student_id", SqlDbType.Int).Value = id;


                conn.Open();
                cmd.ExecuteNonQuery();
                msg = "Data Successfully deleted.";
            }
            catch (Exception)
            {
                msg = "Sorry!Data is not successfully deleted";
            }
            finally
            {
                conn.Close();
            }
            return msg;
        }
    }
}

