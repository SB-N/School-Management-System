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
    public partial class Delete : Form
    {
        private string connstring = ConfigurationManager.ConnectionStrings["SMS_DB"].ConnectionString;
        public Delete()
        {
            InitializeComponent();
        }

        private void txtDelid_KeyUp(object sender, KeyEventArgs e)
        {
            //retrieve data on base of given id
            txtDelFrstN.Text = " ";
           txtDelLstN.Text = " ";
            txtDelFthrN.Text = " ";
          rdBtnDelmale.Checked = false;
            rdBtnDelFemale.Checked = false;
           richTextBox1Del.Text = " ";
            SqlConnection connection = new SqlConnection(connstring);
            string sql = $"select std_Firstname,std_Lastname,std_Fname,std_Gender,std_Address from STUDENT where std_ID ='{txtDelid.Text}' ";
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtDelFrstN.Text = reader.GetValue(0).ToString();
                    txtDelLstN.Text = reader.GetValue(1).ToString();
                    txtDelFthrN.Text = reader.GetValue(2).ToString();
                    if (reader.GetValue(3).ToString().Equals("Male"))
                    {
                        rdBtnDelmale.Checked = true;
                    }
                    else { rdBtnDelFemale.Checked = true; }
                    richTextBox1Del.Text = reader.GetValue(4).ToString();
                }
            }



            catch (Exception ex)
            {
                MessageBox.Show("no record was found!");
            }

            finally
            {
                connection.Close();
            }








        }



        private void btnDel_Click(object sender, EventArgs e)
        {
            DelteR del = new DelteR();
            int studentIdToDelete = Convert.ToInt32( txtDelid.Text);

            string msg = del.stddelete(studentIdToDelete);

            MessageBox.Show(msg);
            
          

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {//go back
            Student s = new Student();
           
            s.ShowDialog();
            this.Hide();
        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {//close
            Application.Exit();
        }

      
    }
}
