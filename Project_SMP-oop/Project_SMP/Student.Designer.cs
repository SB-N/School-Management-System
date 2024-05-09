
namespace Project_SMP
{
    partial class Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblView = new System.Windows.Forms.Label();
            this.lblDel = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblup = new System.Windows.Forms.Label();
            this.lblalstd = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbdlt = new System.Windows.Forms.PictureBox();
            this.pbvw = new System.Windows.Forms.PictureBox();
            this.pbupd = new System.Windows.Forms.PictureBox();
            this.pbadm = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbvw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbupd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbadm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.BackColor = System.Drawing.Color.SkyBlue;
            this.lblView.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.ForeColor = System.Drawing.SystemColors.Control;
            this.lblView.Location = new System.Drawing.Point(297, 586);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(110, 46);
            this.lblView.TabIndex = 1;
            this.lblView.Text = "View";
            // 
            // lblDel
            // 
            this.lblDel.AutoSize = true;
            this.lblDel.BackColor = System.Drawing.Color.SkyBlue;
            this.lblDel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDel.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDel.Location = new System.Drawing.Point(855, 586);
            this.lblDel.Name = "lblDel";
            this.lblDel.Size = new System.Drawing.Size(139, 46);
            this.lblDel.TabIndex = 1;
            this.lblDel.Text = "Delete";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.BackColor = System.Drawing.Color.SkyBlue;
            this.lblAd.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAd.Location = new System.Drawing.Point(251, 303);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(220, 46);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Admission";
            // 
            // lblup
            // 
            this.lblup.AutoSize = true;
            this.lblup.BackColor = System.Drawing.Color.SkyBlue;
            this.lblup.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblup.ForeColor = System.Drawing.SystemColors.Control;
            this.lblup.Location = new System.Drawing.Point(854, 303);
            this.lblup.Name = "lblup";
            this.lblup.Size = new System.Drawing.Size(154, 46);
            this.lblup.TabIndex = 1;
            this.lblup.Text = "Update";
            // 
            // lblalstd
            // 
            this.lblalstd.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalstd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblalstd.Location = new System.Drawing.Point(361, 32);
            this.lblalstd.Name = "lblalstd";
            this.lblalstd.Size = new System.Drawing.Size(536, 59);
            this.lblalstd.TabIndex = 1;
            this.lblalstd.Text = "Student";
            this.lblalstd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project_SMP.Properties.Resources.goback;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbdlt
            // 
            this.pbdlt.Image = global::Project_SMP.Properties.Resources.delete;
            this.pbdlt.Location = new System.Drawing.Point(816, 418);
            this.pbdlt.Name = "pbdlt";
            this.pbdlt.Size = new System.Drawing.Size(186, 121);
            this.pbdlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbdlt.TabIndex = 0;
            this.pbdlt.TabStop = false;
            this.pbdlt.Click += new System.EventHandler(this.pbdlt_Click);
            // 
            // pbvw
            // 
            this.pbvw.Image = global::Project_SMP.Properties.Resources.view;
            this.pbvw.Location = new System.Drawing.Point(239, 418);
            this.pbvw.Name = "pbvw";
            this.pbvw.Size = new System.Drawing.Size(186, 121);
            this.pbvw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbvw.TabIndex = 0;
            this.pbvw.TabStop = false;
            this.pbvw.Click += new System.EventHandler(this.pbvw_Click);
            // 
            // pbupd
            // 
            this.pbupd.Image = global::Project_SMP.Properties.Resources.upda;
            this.pbupd.Location = new System.Drawing.Point(816, 154);
            this.pbupd.Name = "pbupd";
            this.pbupd.Size = new System.Drawing.Size(186, 121);
            this.pbupd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbupd.TabIndex = 0;
            this.pbupd.TabStop = false;
            this.pbupd.Click += new System.EventHandler(this.pbupd_Click);
            // 
            // pbadm
            // 
            this.pbadm.Image = global::Project_SMP.Properties.Resources._5573522;
            this.pbadm.Location = new System.Drawing.Point(239, 154);
            this.pbadm.Name = "pbadm";
            this.pbadm.Size = new System.Drawing.Size(186, 121);
            this.pbadm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbadm.TabIndex = 0;
            this.pbadm.TabStop = false;
            this.pbadm.Click += new System.EventHandler(this.pbadm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_SMP.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(1180, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Student
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1307, 704);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblDel);
            this.Controls.Add(this.lblup);
            this.Controls.Add(this.lblalstd);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblView);
            this.Controls.Add(this.pbdlt);
            this.Controls.Add(this.pbvw);
            this.Controls.Add(this.pbupd);
            this.Controls.Add(this.pbadm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Student";
            this.Text = "Student";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbvw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbupd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbadm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbadm;
        private System.Windows.Forms.PictureBox pbupd;
        private System.Windows.Forms.PictureBox pbvw;
        private System.Windows.Forms.PictureBox pbdlt;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Label lblDel;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblup;
        private System.Windows.Forms.Label lblalstd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}