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
    public partial class Salary : Form
    {
        private string connstring = ConfigurationManager.ConnectionStrings["SMS_DB"].ConnectionString;
        shSal sh = new shSal();
        public Salary()
        {
            InitializeComponent();
        }

        private void lblsl_Click(object sender, EventArgs e)
        {

        }

        private void txtTchIDsal_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtwor_TextChanged(object sender, EventArgs e)
        {
            float s = Convert.ToInt32(txtsalto.Text) / 30;
            float c = Convert.ToInt32(txtwor.Text);

            float total = s * c;
            lbltopay.Text = total.ToString();
            
            lbltopay.Text = total.ToString();
            lbltopay.Visible = true;
        }
        private void txtTchIDsal_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection connection = new SqlConnection(connstring);
            string sql = $"select t.T_Name,T.Salary from  Teacher t where t.T_id='{txtTchIDsal.Text}'";
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtTNmesal.Text = reader.GetValue(0).ToString();
                    txtsalto.Text = reader.GetValue(1).ToString();
                }
               
            }

            catch (Exception )
            {
                MessageBox.Show("no records were found!");
            }
            finally
            {
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            salary_cl slc = new salary_cl();
            slc.teacher.ID = Convert.ToInt32(txtTchIDsal.Text);
            slc.workD =Convert.ToInt32 (txtwor.Text);
            slc.teacher.salary =Convert.ToInt32 (txtsalto.Text);
            slc.status = txtStap.Text;
            float s= Convert.ToInt32(txtsalto.Text)/30;
            float c = Convert.ToInt32(txtwor.Text);
            
            float total = s * c;//calculate salary
            lbltopay.Text = total.ToString();
            lbltopay.Visible = true;
            slc.Amount =Convert.ToInt32 (lbltopay.Text);
            slc.month = comboxPayto.SelectedItem.ToString();
            slc.year = txtPayYEa.Text;
            MessageBox.Show(sh.showSal(slc));
        }

        private void txtStap_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmTview f = new FrmTview();
            f.ShowDialog();
            this.Hide();
        }

      
    }
    }

