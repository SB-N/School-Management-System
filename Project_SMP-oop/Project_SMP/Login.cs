using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SMP
{
    public partial class FrmLog : Form
    {
        public static int fk_adId ;
        public FrmLog()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUSer.Text;
            string password = txtPAss.Text;
            string dbuser;
            string pddb=" ";
            returnclass rc = new returnclass();
            dbuser = rc.scalarReturn($"select count(Ad_ID) from Administator where Ad_name='{user}'");
            if (dbuser.Equals("0"))
            {
                lblwrU.Visible = true;//label show invalid user
                lblwrU.ForeColor = Color.Red;
                lblwrU.Text="Invalid User Name!";
            }
            else
            {
                pddb = rc.scalarReturn($"select Ad_password from Administator where Ad_name='{user}'");
            }
            if (pddb.Equals(password))
            {
                //  fk_adId = rc.scalarReturn("select Ad_ID from  where Ad_name='"+user+"'");
                fk_adId =int.Parse( rc.scalarReturn("SELECT Ad_ID FROM Administator WHERE Ad_name='" + user + "'"));

                btnLogin.BackColor = Color.Green;
                DashBoard ds = new DashBoard();
                this.Hide();
                ds.Show();
               
            }
            else
            {
                btnLogin.BackColor = Color.Red;
               
                lblWrP.Visible = true;//label show invalid password
                lblWrP.ForeColor = Color.Red;
                lblWrP.Text = "Invalid Password";
             

            }

        }

        private void FrmLog_Load(object sender, EventArgs e)
        {
            lblPAss.BackColor = Color.Transparent;
            lblUSer.BackColor = Color.Transparent;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            school s = new school();
            s.ShowDialog();
            this.Hide();
        }
    }
}
