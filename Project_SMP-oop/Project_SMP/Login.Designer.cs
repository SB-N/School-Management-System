
namespace Project_SMP
{
    partial class FrmLog
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
            this.txtPAss = new System.Windows.Forms.TextBox();
            this.txtUSer = new System.Windows.Forms.TextBox();
            this.lblPAss = new System.Windows.Forms.Label();
            this.lblUSer = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblWrP = new System.Windows.Forms.Label();
            this.lblwrU = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPAss
            // 
            this.txtPAss.BackColor = System.Drawing.Color.MintCream;
            this.txtPAss.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPAss.Location = new System.Drawing.Point(687, 335);
            this.txtPAss.Name = "txtPAss";
            this.txtPAss.PasswordChar = '*';
            this.txtPAss.Size = new System.Drawing.Size(240, 44);
            this.txtPAss.TabIndex = 2;
            // 
            // txtUSer
            // 
            this.txtUSer.BackColor = System.Drawing.Color.MintCream;
            this.txtUSer.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUSer.Location = new System.Drawing.Point(687, 223);
            this.txtUSer.Name = "txtUSer";
            this.txtUSer.Size = new System.Drawing.Size(240, 44);
            this.txtUSer.TabIndex = 1;
            // 
            // lblPAss
            // 
            this.lblPAss.AutoSize = true;
            this.lblPAss.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblPAss.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPAss.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPAss.Location = new System.Drawing.Point(365, 335);
            this.lblPAss.Name = "lblPAss";
            this.lblPAss.Size = new System.Drawing.Size(208, 46);
            this.lblPAss.TabIndex = 0;
            this.lblPAss.Text = "Password";
            // 
            // lblUSer
            // 
            this.lblUSer.AutoSize = true;
            this.lblUSer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblUSer.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUSer.Location = new System.Drawing.Point(365, 223);
            this.lblUSer.Name = "lblUSer";
            this.lblUSer.Size = new System.Drawing.Size(109, 46);
            this.lblUSer.TabIndex = 0;
            this.lblUSer.Text = "User";
            this.lblUSer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.Location = new System.Drawing.Point(542, 472);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(290, 60);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblWrP
            // 
            this.lblWrP.AutoSize = true;
            this.lblWrP.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrP.Location = new System.Drawing.Point(201, 402);
            this.lblWrP.Name = "lblWrP";
            this.lblWrP.Size = new System.Drawing.Size(0, 33);
            this.lblWrP.TabIndex = 3;
            this.lblWrP.Visible = false;
            // 
            // lblwrU
            // 
            this.lblwrU.AutoSize = true;
            this.lblwrU.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwrU.Location = new System.Drawing.Point(241, 461);
            this.lblwrU.Name = "lblwrU";
            this.lblwrU.Size = new System.Drawing.Size(0, 33);
            this.lblwrU.TabIndex = 4;
            this.lblwrU.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Project_SMP.Properties.Resources.cll;
            this.pictureBox1.Location = new System.Drawing.Point(1179, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Project_SMP.Properties.Resources.go_back;
            this.pictureBox2.Location = new System.Drawing.Point(39, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FrmLog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Project_SMP.Properties.Resources.lfgglg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1307, 704);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblwrU);
            this.Controls.Add(this.lblWrP);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPAss);
            this.Controls.Add(this.txtPAss);
            this.Controls.Add(this.txtUSer);
            this.Controls.Add(this.lblUSer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmLog";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPAss;
        private System.Windows.Forms.TextBox txtUSer;
        private System.Windows.Forms.Label lblPAss;
        private System.Windows.Forms.Label lblUSer;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblWrP;
        private System.Windows.Forms.Label lblwrU;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

