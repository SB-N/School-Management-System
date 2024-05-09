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
    public partial class Admission : Form
    {
        admission_Class adm_c = new admission_Class();
        public Admission()
        {
            InitializeComponent();
        }

        private void grpadmisn_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdSbmit_Click(object sender, EventArgs e)
        {

            STUDENT_CLS s = new STUDENT_CLS();
            s.ad_ID = FrmLog.fk_adId;
            s.admissionDate = System.DateTime.Now;
            MessageBox.Show(s.admissionDate + "\n" + "Admin\t\t" + s.ad_ID);
           s.Frname = txtAdFrstN.Text;
            s.lastNme = txtAdLstN.Text;
            s.fathername = txtAdFthrN.Text;
            
            if (rdBtnmale.Checked == true)
            {
                s.gender = "Male";
            }
            else if (rdBtnFemale.Checked == true)
            {
                s.gender = "Female";
            }
            else { MessageBox.Show("Please,Enter Gender"); }
            s.Address = richTextBox1.Text;
            s.stdDateofBirth = dateTimePicker1DOB.Value;
            s.stdDateofBirth = dateTimePicker1DOB.Value;

            // Check if the date of birth is not in the future
            if (s.stdDateofBirth > DateTime.Now)
            {
                MessageBox.Show("Invalid date of birth. Please select a valid date.");
                return; // Exit the method if the date is invalid
            }
            MessageBox.Show( adm_c.stdRecord(s));
            Std_Status sa = new Std_Status();
            sa.year = System.DateTime.Now.Year.ToString();
            
            returnclass rc = new returnclass();
            sa.class_ID = Convert.ToInt32(comboBox1.SelectedValue);
          sa.status_stdId = Convert.ToInt32(rc.scalarReturn("select max(std_id) from STUDENT"));
            adm_c.Insert_stdStatus(sa);

            CleraAdForm();
        }//btn ends
        public void CleraAdForm()
        {
            txtAdFrstN.Text = " ";
            txtAdLstN.Text = " ";
            txtAdFthrN.Text = " ";
            rdBtnFemale.Checked = false;
            rdBtnmale.Checked = false;
            richTextBox1.Text = " ";
            btnAdSbmit.Enabled = false;
            dateTimePicker1DOB.Value = System.DateTime.Now;
        }

        private void btnPUplAD_Click(object sender, EventArgs e)
        {
            //for uploading  image
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Picture";
            //image filter
            open.Filter= "Image Files(*.jpg; *.jpeg; *.gif; *.png; *.bmp)| *.jpg; *.jpeg; *.gif; *.png; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAd.Image = new Bitmap(open.FileName);//image file path
            }
            txtP.Text = open.FileName;
        }

        private void btnSavePAd_Click(object sender, EventArgs e)
        {

            //for image saving
            Std_Image im = new Std_Image();
            STUDENT_CLS st = new STUDENT_CLS();
            im.Student = st;//Association
            st.ID=int.Parse( txtBxImgId.Text);

           im.img_path = txtP.Text;
            
            adm_c.insert_img(im);
        }

        private void Admission_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolProjectDataSet.Classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.schoolProjectDataSet.Classes);
            //on loading disabled
            txtAdLstN.Enabled = false;
            txtAdFthrN.Enabled = false;
            rdBtnFemale.Enabled = false;
            rdBtnmale.Enabled = false;
            richTextBox1.Enabled = false;
            btnAdSbmit.Enabled = false;
           
            pictureBoxAd.Image = Image.FromFile(@"C:\Users\PMLS\OneDrive - Higher Education Commission\DB Lab\Project\Project_SMP\Project_SMP\Resources\images.png");
        }

        private void txtAdFrstN_TextChanged(object sender, EventArgs e)
        {
            //some text next  enables
            txtAdLstN.Enabled = true;
        }

        private void txtAdLstN_TextChanged(object sender, EventArgs e)
        {
            //some text next  enables
            txtAdFthrN.Enabled = true;
        }

      

        private void rdBtnmale_MouseClick(object sender, MouseEventArgs e)
        {
            //some text next  enables
            richTextBox1.Enabled = true;
        }

        private void rdBtnFemale_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Enabled = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            btnAdSbmit.Enabled = true;
            btnSavePAd.Enabled = true;
            btnPUplAD.Enabled = true;
        }

        private void btnAdRef_Click(object sender, EventArgs e)
        {
            //on refresh clear form
            txtAdLstN.Enabled = false;
            txtAdFthrN.Enabled = false;
            rdBtnFemale.Enabled = false;
            rdBtnmale.Enabled = false;
            richTextBox1.Enabled = false;
            btnAdSbmit.Enabled = false;
            btnPUplAD.Enabled = false;
            btnSavePAd.Enabled = false;
        }

        private void txtAdFthrN_TextChanged(object sender, EventArgs e)
        {
            rdBtnFemale.Enabled = true;
            rdBtnmale.Enabled = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)//for back
        {
            //to go back
            Student s = new Student();
            s.ShowDialog();
            this.Hide();
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {//to close
            Application.Exit();
        }


        //private void btnAddCls_Click(object sender, EventArgs e)
        //{
        //    Std_Status sa = new Std_Status();
        //    sa.year = System.DateTime.Now.ToString();
        //    //combobox video 12
        //    returnclass rc = new returnclass();
        //    sa.status_stdId = Convert.ToInt32(rc.scalarReturn("select max(std_Id) from Student"));
        //    adm_c.Insert_stdStatus(sa);
        //}
    }
}
