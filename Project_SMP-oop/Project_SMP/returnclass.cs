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
    class returnclass //retrival from database
    {
        private  string connstring = ConfigurationManager.ConnectionStrings["SMS_DB"].ConnectionString;
        string s="";
                public string scalarReturn(string q)
        {
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(q, conn);
               s = cmd.ExecuteScalar().ToString();
            }
            catch (Exception)
            {

                s = " ";        //if null not error
            }
            
            return s;
        }
    }
}

