using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Project_SMP
{
    public partial class update : Form
    {
        private string connstring = ConfigurationManager.ConnectionStrings["SMS_DB"].ConnectionString;
        public update()
        {
            InitializeComponent();
        }

        private void grpadmisn_Enter(object sender, EventArgs e)
        {

        }

        private void txtUpid_KeyUp(object sender, KeyEventArgs e)
        {
            txtupFrstN.Text = " ";
            txtupLstN.Text = " ";
            txtupFthrN.Text = " ";
            rdBtnUpmale.Checked = false;
            rdBtnUpFemale.Checked = false;
            richTextBox1Up.Text = " ";
            SqlConnection connection = new SqlConnection(connstring);
            string sql = $"select std_Firstname,std_Lastname,std_Fname,std_Gender,std_Address from STUDENT where std_ID ='{ txtupid.Text}'" ;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtupFrstN.Text = reader.GetValue(0).ToString();
                    txtupLstN.Text = reader.GetValue(1).ToString();
                    txtupFthrN.Text = reader.GetValue(2).ToString();
                    if (reader.GetValue(3).ToString().Equals("Male"))
                    {
                        rdBtnUpmale.Checked = true;
                    }
                    else {rdBtnUpFemale.Checked = true; }
                    richTextBox1Up.Text = reader.GetValue(4).ToString();
                }

                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No Records were Found!");
            }



        }

        private void btnAdUpd_Click(object sender, EventArgs e)
        {
            STUDENT_CLS s = new STUDENT_CLS();
            s.Frname = txtupFrstN.Text;
            s.lastNme = txtupLstN.Text;
            s.fathername = txtupFthrN.Text;
            if (rdBtnUpmale.Checked == true) { s.gender = "Male"; }
            else { s.gender = "Female"; }
            s.Address = richTextBox1Up.Text;
            s.ID=Convert.ToInt32(txtupid.Text);
            Update_Cls u = new Update_Cls();
            string msg = u.updateRecord(s);
            MessageBox.Show(msg);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.ShowDialog();
            this.Hide();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();//to close
        }

        private void txtupid_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

