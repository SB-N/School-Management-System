
namespace Project_SMP
{
    partial class Salary
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
            this.txtsalto = new System.Windows.Forms.TextBox();
            this.txtTNmesal = new System.Windows.Forms.TextBox();
            this.txtTchIDsal = new System.Windows.Forms.TextBox();
            this.lblsls = new System.Windows.Forms.Label();
            this.lblTnsl = new System.Windows.Forms.Label();
            this.lblTchIDs = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.comboxPayto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStap = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblsalw = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPayYEa = new System.Windows.Forms.TextBox();
            this.txtwor = new System.Windows.Forms.TextBox();
            this.lbltopay = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsalto
            // 
            this.txtsalto.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalto.Location = new System.Drawing.Point(844, 280);
            this.txtsalto.Name = "txtsalto";
            this.txtsalto.Size = new System.Drawing.Size(262, 40);
            this.txtsalto.TabIndex = 11;
            // 
            // txtTNmesal
            // 
            this.txtTNmesal.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTNmesal.Location = new System.Drawing.Point(844, 214);
            this.txtTNmesal.Name = "txtTNmesal";
            this.txtTNmesal.Size = new System.Drawing.Size(262, 40);
            this.txtTNmesal.TabIndex = 10;
            // 
            // txtTchIDsal
            // 
            this.txtTchIDsal.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTchIDsal.Location = new System.Drawing.Point(844, 140);
            this.txtTchIDsal.Name = "txtTchIDsal";
            this.txtTchIDsal.Size = new System.Drawing.Size(262, 40);
            this.txtTchIDsal.TabIndex = 9;
            this.txtTchIDsal.TextChanged += new System.EventHandler(this.txtTchIDsal_TextChanged);
            this.txtTchIDsal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTchIDsal_KeyUp);
            // 
            // lblsls
            // 
            this.lblsls.AutoSize = true;
            this.lblsls.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsls.ForeColor = System.Drawing.SystemColors.Control;
            this.lblsls.Location = new System.Drawing.Point(418, 293);
            this.lblsls.Name = "lblsls";
            this.lblsls.Size = new System.Drawing.Size(97, 37);
            this.lblsls.TabIndex = 3;
            this.lblsls.Text = "Salary";
            this.lblsls.Click += new System.EventHandler(this.lblsl_Click);
            // 
            // lblTnsl
            // 
            this.lblTnsl.AutoSize = true;
            this.lblTnsl.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTnsl.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTnsl.Location = new System.Drawing.Point(418, 233);
            this.lblTnsl.Name = "lblTnsl";
            this.lblTnsl.Size = new System.Drawing.Size(89, 37);
            this.lblTnsl.TabIndex = 2;
            this.lblTnsl.Text = "Name";
            // 
            // lblTchIDs
            // 
            this.lblTchIDs.AutoSize = true;
            this.lblTchIDs.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTchIDs.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTchIDs.Location = new System.Drawing.Point(418, 143);
            this.lblTchIDs.Name = "lblTchIDs";
            this.lblTchIDs.Size = new System.Drawing.Size(43, 37);
            this.lblTchIDs.TabIndex = 1;
            this.lblTchIDs.Text = "ID";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.ForeColor = System.Drawing.SystemColors.Control;
            this.lblP.Location = new System.Drawing.Point(424, 432);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(102, 37);
            this.lblP.TabIndex = 5;
            this.lblP.Text = "To pay";
            this.lblP.Click += new System.EventHandler(this.lblsl_Click);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMonth.Location = new System.Drawing.Point(424, 502);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(96, 37);
            this.lblMonth.TabIndex = 6;
            this.lblMonth.Text = "Month";
            this.lblMonth.Click += new System.EventHandler(this.lblsl_Click);
            // 
            // comboxPayto
            // 
            this.comboxPayto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxPayto.FormattingEnabled = true;
            this.comboxPayto.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboxPayto.Location = new System.Drawing.Point(844, 499);
            this.comboxPayto.Name = "comboxPayto";
            this.comboxPayto.Size = new System.Drawing.Size(262, 40);
            this.comboxPayto.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(539, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 83);
            this.label1.TabIndex = 20;
            this.label1.Text = "Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(421, 649);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Status";
            this.label2.Click += new System.EventHandler(this.lblsl_Click);
            // 
            // txtStap
            // 
            this.txtStap.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStap.Location = new System.Drawing.Point(844, 646);
            this.txtStap.Name = "txtStap";
            this.txtStap.Size = new System.Drawing.Size(262, 40);
            this.txtStap.TabIndex = 15;
            this.txtStap.TextChanged += new System.EventHandler(this.txtStap_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(577, 800);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 80);
            this.button1.TabIndex = 16;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblsalw
            // 
            this.lblsalw.AutoSize = true;
            this.lblsalw.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalw.ForeColor = System.Drawing.SystemColors.Control;
            this.lblsalw.Location = new System.Drawing.Point(421, 367);
            this.lblsalw.Name = "lblsalw";
            this.lblsalw.Size = new System.Drawing.Size(193, 37);
            this.lblsalw.TabIndex = 4;
            this.lblsalw.Text = "Working Days";
            this.lblsalw.Click += new System.EventHandler(this.lblsl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(424, 575);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Year";
            this.label3.Click += new System.EventHandler(this.lblsl_Click);
            // 
            // txtPayYEa
            // 
            this.txtPayYEa.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayYEa.Location = new System.Drawing.Point(844, 572);
            this.txtPayYEa.Name = "txtPayYEa";
            this.txtPayYEa.Size = new System.Drawing.Size(262, 40);
            this.txtPayYEa.TabIndex = 14;
            // 
            // txtwor
            // 
            this.txtwor.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwor.Location = new System.Drawing.Point(844, 352);
            this.txtwor.Name = "txtwor";
            this.txtwor.Size = new System.Drawing.Size(262, 40);
            this.txtwor.TabIndex = 12;
            this.txtwor.TextChanged += new System.EventHandler(this.txtwor_TextChanged);
            // 
            // lbltopay
            // 
            this.lbltopay.AutoSize = true;
            this.lbltopay.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltopay.ForeColor = System.Drawing.SystemColors.Control;
            this.lbltopay.Location = new System.Drawing.Point(746, 446);
            this.lbltopay.Name = "lbltopay";
            this.lbltopay.Size = new System.Drawing.Size(0, 42);
            this.lbltopay.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Project_SMP.Properties.Resources.close;
            this.pictureBox4.Location = new System.Drawing.Point(1337, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 49);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Project_SMP.Properties.Resources.goback;
            this.pictureBox3.Location = new System.Drawing.Point(12, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1449, 848);
            this.Controls.Add(this.lbltopay);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtwor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboxPayto);
            this.Controls.Add(this.txtPayYEa);
            this.Controls.Add(this.txtsalto);
            this.Controls.Add(this.txtStap);
            this.Controls.Add(this.txtTNmesal);
            this.Controls.Add(this.txtTchIDsal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblsalw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblsls);
            this.Controls.Add(this.lblTnsl);
            this.Controls.Add(this.lblTchIDs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salary";
            this.Text = "ddd";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsalto;
        private System.Windows.Forms.TextBox txtTNmesal;
        private System.Windows.Forms.TextBox txtTchIDsal;
        private System.Windows.Forms.Label lblsls;
        private System.Windows.Forms.Label lblTnsl;
        private System.Windows.Forms.Label lblTchIDs;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox comboxPayto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblsalw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtPayYEa;
        private System.Windows.Forms.TextBox txtwor;
        private System.Windows.Forms.Label lbltopay;
    }
}