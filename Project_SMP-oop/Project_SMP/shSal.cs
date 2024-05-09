using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
namespace Project_SMP
{
    class shSal
    {
        private string connstring = ConfigurationManager.ConnectionStrings["SMS_DB"].ConnectionString;
        string msg;
        public string showSal(salary_cl sl)//association
        {
            SqlConnection conn = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand("ToPAyS1", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@T_id", SqlDbType.Int).Value = sl.teacher.ID;
                
                cmd.Parameters.Add("@amount", SqlDbType.Float).Value = sl.Amount;
                cmd.Parameters.Add("@Pmonth", SqlDbType.VarChar, 30).Value = sl.month;
                cmd.Parameters.Add("@Pyera", SqlDbType.VarChar, 100).Value = sl.year;
                cmd.Parameters.Add("@PWdays", SqlDbType.Int).Value = sl.workD;
                cmd.Parameters.Add("@Pstatus", SqlDbType.VarChar, 10).Value = sl.status;

                conn.Open();
                cmd.ExecuteNonQuery();
                msg = "Salary paid";
            }
            catch (Exception)
            {
                msg = "Salary not Paid";
            }

            finally
            {
                conn.Close();
            }
            return msg;
        }
    }




}

