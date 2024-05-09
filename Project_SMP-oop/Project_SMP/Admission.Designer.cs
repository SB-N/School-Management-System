
namespace Project_SMP
{
    partial class Admission
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
            this.components = new System.ComponentModel.Container();
            this.grpadmisn = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblAdCls = new System.Windows.Forms.Label();
            this.dateTimePicker1DOB = new System.Windows.Forms.DateTimePicker();
            this.btnAdSbmit = new System.Windows.Forms.Button();
            this.rdBtnFemale = new System.Windows.Forms.RadioButton();
            this.rdBtnmale = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblAdGndr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdAdrs = new System.Windows.Forms.Label();
            this.lblAdfthr = new System.Windows.Forms.Label();
            this.lblAdlstn = new System.Windows.Forms.Label();
            this.txtAdFthrN = new System.Windows.Forms.TextBox();
            this.txtAdLstN = new System.Windows.Forms.TextBox();
            this.lblAdFrstN = new System.Windows.Forms.Label();
            this.txtAdFrstN = new System.Windows.Forms.TextBox();
            this.lblAdmhead = new System.Windows.Forms.Label();
            this.grpBxforPic = new System.Windows.Forms.GroupBox();
            this.txtBxImgId = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.btnSavePAd = new System.Windows.Forms.Button();
            this.btnPUplAD = new System.Windows.Forms.Button();
            this.pictureBoxAd = new System.Windows.Forms.PictureBox();
            this.lblimgID = new System.Windows.Forms.Label();
            this.btnAdRef = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.schoolProjectDataSet = new Project_SMP.SchoolProjectDataSet();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classesTableAdapter = new Project_SMP.SchoolProjectDataSetTableAdapters.ClassesTableAdapter();
            this.grpadmisn.SuspendLayout();
            this.grpBxforPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpadmisn
            // 
            this.grpadmisn.Controls.Add(this.comboBox1);
            this.grpadmisn.Controls.Add(this.lblAdCls);
            this.grpadmisn.Controls.Add(this.dateTimePicker1DOB);
            this.grpadmisn.Controls.Add(this.btnAdSbmit);
            this.grpadmisn.Controls.Add(this.rdBtnFemale);
            this.grpadmisn.Controls.Add(this.rdBtnmale);
            this.grpadmisn.Controls.Add(this.richTextBox1);
            this.grpadmisn.Controls.Add(this.lblAdGndr);
            this.grpadmisn.Controls.Add(this.label1);
            this.grpadmisn.Controls.Add(this.lblAdAdrs);
            this.grpadmisn.Controls.Add(this.lblAdfthr);
            this.grpadmisn.Controls.Add(this.lblAdlstn);
            this.grpadmisn.Controls.Add(this.txtAdFthrN);
            this.grpadmisn.Controls.Add(this.txtAdLstN);
            this.grpadmisn.Controls.Add(this.lblAdFrstN);
            this.grpadmisn.Controls.Add(this.txtAdFrstN);
            this.grpadmisn.Location = new System.Drawing.Point(39, 95);
            this.grpadmisn.Name = "grpadmisn";
            this.grpadmisn.Size = new System.Drawing.Size(659, 618);
            this.grpadmisn.TabIndex = 0;
            this.grpadmisn.TabStop = false;
            this.grpadmisn.Text = "Admission";
            this.grpadmisn.Enter += new System.EventHandler(this.grpadmisn_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.classesBindingSource;
            this.comboBox1.DisplayMember = "classname";
            this.comboBox1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(322, 476);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 40);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "class_id";
            // 
            // lblAdCls
            // 
            this.lblAdCls.AutoSize = true;
            this.lblAdCls.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdCls.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdCls.Location = new System.Drawing.Point(87, 476);
            this.lblAdCls.Name = "lblAdCls";
            this.lblAdCls.Size = new System.Drawing.Size(88, 37);
            this.lblAdCls.TabIndex = 9;
            this.lblAdCls.Text = "Class";
            // 
            // dateTimePicker1DOB
            // 
            this.dateTimePicker1DOB.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1DOB.Location = new System.Drawing.Point(322, 403);
            this.dateTimePicker1DOB.Name = "dateTimePicker1DOB";
            this.dateTimePicker1DOB.Size = new System.Drawing.Size(227, 40);
            this.dateTimePicker1DOB.TabIndex = 8;
            // 
            // btnAdSbmit
            // 
            this.btnAdSbmit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdSbmit.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdSbmit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdSbmit.Location = new System.Drawing.Point(204, 542);
            this.btnAdSbmit.Name = "btnAdSbmit";
            this.btnAdSbmit.Size = new System.Drawing.Size(158, 48);
            this.btnAdSbmit.TabIndex = 7;
            this.btnAdSbmit.Text = "Submit";
            this.btnAdSbmit.UseVisualStyleBackColor = false;
            this.btnAdSbmit.Click += new System.EventHandler(this.btnAdSbmit_Click);
            // 
            // rdBtnFemale
            // 
            this.rdBtnFemale.AutoSize = true;
            this.rdBtnFemale.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnFemale.ForeColor = System.Drawing.SystemColors.Control;
            this.rdBtnFemale.Location = new System.Drawing.Point(459, 223);
            this.rdBtnFemale.Name = "rdBtnFemale";
            this.rdBtnFemale.Size = new System.Drawing.Size(145, 40);
            this.rdBtnFemale.TabIndex = 5;
            this.rdBtnFemale.TabStop = true;
            this.rdBtnFemale.Text = "Female";
            this.rdBtnFemale.UseVisualStyleBackColor = true;
            this.rdBtnFemale.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdBtnFemale_MouseClick);
            // 
            // rdBtnmale
            // 
            this.rdBtnmale.AutoSize = true;
            this.rdBtnmale.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnmale.ForeColor = System.Drawing.SystemColors.Control;
            this.rdBtnmale.Location = new System.Drawing.Point(322, 223);
            this.rdBtnmale.Name = "rdBtnmale";
            this.rdBtnmale.Size = new System.Drawing.Size(108, 40);
            this.rdBtnmale.TabIndex = 4;
            this.rdBtnmale.TabStop = true;
            this.rdBtnmale.Text = "Male";
            this.rdBtnmale.UseVisualStyleBackColor = true;
            this.rdBtnmale.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdBtnmale_MouseClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(322, 283);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(227, 71);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lblAdGndr
            // 
            this.lblAdGndr.AutoSize = true;
            this.lblAdGndr.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdGndr.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdGndr.Location = new System.Drawing.Point(87, 226);
            this.lblAdGndr.Name = "lblAdGndr";
            this.lblAdGndr.Size = new System.Drawing.Size(109, 37);
            this.lblAdGndr.TabIndex = 1;
            this.lblAdGndr.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(87, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date of Birth";
            // 
            // lblAdAdrs
            // 
            this.lblAdAdrs.AutoSize = true;
            this.lblAdAdrs.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblAdAdrs.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdAdrs.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdAdrs.Location = new System.Drawing.Point(87, 281);
            this.lblAdAdrs.Name = "lblAdAdrs";
            this.lblAdAdrs.Size = new System.Drawing.Size(123, 37);
            this.lblAdAdrs.TabIndex = 1;
            this.lblAdAdrs.Text = "Address";
            // 
            // lblAdfthr
            // 
            this.lblAdfthr.AutoSize = true;
            this.lblAdfthr.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdfthr.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdfthr.Location = new System.Drawing.Point(87, 160);
            this.lblAdfthr.Name = "lblAdfthr";
            this.lblAdfthr.Size = new System.Drawing.Size(177, 37);
            this.lblAdfthr.TabIndex = 1;
            this.lblAdfthr.Text = "Father Name";
            // 
            // lblAdlstn
            // 
            this.lblAdlstn.AutoSize = true;
            this.lblAdlstn.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdlstn.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdlstn.Location = new System.Drawing.Point(87, 106);
            this.lblAdlstn.Name = "lblAdlstn";
            this.lblAdlstn.Size = new System.Drawing.Size(151, 37);
            this.lblAdlstn.TabIndex = 1;
            this.lblAdlstn.Text = "Last Name";
            // 
            // txtAdFthrN
            // 
            this.txtAdFthrN.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdFthrN.Location = new System.Drawing.Point(322, 154);
            this.txtAdFthrN.Name = "txtAdFthrN";
            this.txtAdFthrN.Size = new System.Drawing.Size(228, 40);
            this.txtAdFthrN.TabIndex = 3;
            this.txtAdFthrN.TextChanged += new System.EventHandler(this.txtAdFthrN_TextChanged);
            // 
            // txtAdLstN
            // 
            this.txtAdLstN.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdLstN.Location = new System.Drawing.Point(322, 100);
            this.txtAdLstN.Name = "txtAdLstN";
            this.txtAdLstN.Size = new System.Drawing.Size(228, 40);
            this.txtAdLstN.TabIndex = 2;
            this.txtAdLstN.TextChanged += new System.EventHandler(this.txtAdLstN_TextChanged);
            // 
            // lblAdFrstN
            // 
            this.lblAdFrstN.AutoSize = true;
            this.lblAdFrstN.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdFrstN.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdFrstN.Location = new System.Drawing.Point(87, 41);
            this.lblAdFrstN.Name = "lblAdFrstN";
            this.lblAdFrstN.Size = new System.Drawing.Size(153, 37);
            this.lblAdFrstN.TabIndex = 1;
            this.lblAdFrstN.Text = "First Name";
            // 
            // txtAdFrstN
            // 
            this.txtAdFrstN.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdFrstN.Location = new System.Drawing.Point(322, 35);
            this.txtAdFrstN.Name = "txtAdFrstN";
            this.txtAdFrstN.Size = new System.Drawing.Size(228, 40);
            this.txtAdFrstN.TabIndex = 1;
            this.txtAdFrstN.TextChanged += new System.EventHandler(this.txtAdFrstN_TextChanged);
            // 
            // lblAdmhead
            // 
            this.lblAdmhead.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblAdmhead.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmhead.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdmhead.Location = new System.Drawing.Point(76, 21);
            this.lblAdmhead.Name = "lblAdmhead";
            this.lblAdmhead.Size = new System.Drawing.Size(1113, 55);
            this.lblAdmhead.TabIndex = 1;
            this.lblAdmhead.Text = "Student  Record";
            this.lblAdmhead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBxforPic
            // 
            this.grpBxforPic.Controls.Add(this.txtBxImgId);
            this.grpBxforPic.Controls.Add(this.txtP);
            this.grpBxforPic.Controls.Add(this.btnSavePAd);
            this.grpBxforPic.Controls.Add(this.btnPUplAD);
            this.grpBxforPic.Controls.Add(this.pictureBoxAd);
            this.grpBxforPic.Controls.Add(this.lblimgID);
            this.grpBxforPic.Location = new System.Drawing.Point(780, 95);
            this.grpBxforPic.Name = "grpBxforPic";
            this.grpBxforPic.Size = new System.Drawing.Size(448, 502);
            this.grpBxforPic.TabIndex = 2;
            this.grpBxforPic.TabStop = false;
            this.grpBxforPic.Text = " ";
            // 
            // txtBxImgId
            // 
            this.txtBxImgId.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxImgId.Location = new System.Drawing.Point(151, 359);
            this.txtBxImgId.Name = "txtBxImgId";
            this.txtBxImgId.Size = new System.Drawing.Size(207, 30);
            this.txtBxImgId.TabIndex = 2;
            // 
            // txtP
            // 
            this.txtP.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP.Location = new System.Drawing.Point(89, 302);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(269, 30);
            this.txtP.TabIndex = 2;
            // 
            // btnSavePAd
            // 
            this.btnSavePAd.BackColor = System.Drawing.Color.Azure;
            this.btnSavePAd.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePAd.Location = new System.Drawing.Point(279, 417);
            this.btnSavePAd.Name = "btnSavePAd";
            this.btnSavePAd.Size = new System.Drawing.Size(96, 36);
            this.btnSavePAd.TabIndex = 1;
            this.btnSavePAd.Text = "Save";
            this.btnSavePAd.UseVisualStyleBackColor = false;
            this.btnSavePAd.Click += new System.EventHandler(this.btnSavePAd_Click);
            // 
            // btnPUplAD
            // 
            this.btnPUplAD.BackColor = System.Drawing.Color.Azure;
            this.btnPUplAD.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPUplAD.Location = new System.Drawing.Point(89, 417);
            this.btnPUplAD.Name = "btnPUplAD";
            this.btnPUplAD.Size = new System.Drawing.Size(96, 36);
            this.btnPUplAD.TabIndex = 1;
            this.btnPUplAD.Text = "Upload";
            this.btnPUplAD.UseVisualStyleBackColor = false;
            this.btnPUplAD.Click += new System.EventHandler(this.btnPUplAD_Click);
            // 
            // pictureBoxAd
            // 
            this.pictureBoxAd.Location = new System.Drawing.Point(89, 68);
            this.pictureBoxAd.Name = "pictureBoxAd";
            this.pictureBoxAd.Size = new System.Drawing.Size(260, 195);
            this.pictureBoxAd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAd.TabIndex = 0;
            this.pictureBoxAd.TabStop = false;
            // 
            // lblimgID
            // 
            this.lblimgID.AutoSize = true;
            this.lblimgID.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblimgID.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimgID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblimgID.Location = new System.Drawing.Point(84, 357);
            this.lblimgID.Name = "lblimgID";
            this.lblimgID.Size = new System.Drawing.Size(43, 37);
            this.lblimgID.TabIndex = 1;
            this.lblimgID.Text = "ID";
            // 
            // btnAdRef
            // 
            this.btnAdRef.BackColor = System.Drawing.Color.LightCoral;
            this.btnAdRef.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdRef.Location = new System.Drawing.Point(931, 613);
            this.btnAdRef.Name = "btnAdRef";
            this.btnAdRef.Size = new System.Drawing.Size(154, 48);
            this.btnAdRef.TabIndex = 3;
            this.btnAdRef.Text = "Refresh";
            this.btnAdRef.UseVisualStyleBackColor = false;
            this.btnAdRef.Click += new System.EventHandler(this.btnAdRef_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_SMP.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(1178, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project_SMP.Properties.Resources.goback;
            this.pictureBox2.Location = new System.Drawing.Point(1, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // schoolProjectDataSet
            // 
            this.schoolProjectDataSet.DataSetName = "SchoolProjectDataSet";
            this.schoolProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "Classes";
            this.classesBindingSource.DataSource = this.schoolProjectDataSet;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // Admission
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1307, 704);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAdRef);
            this.Controls.Add(this.grpBxforPic);
            this.Controls.Add(this.lblAdmhead);
            this.Controls.Add(this.grpadmisn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Admission";
            this.Text = "Admission";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admission_Load);
            this.grpadmisn.ResumeLayout(false);
            this.grpadmisn.PerformLayout();
            this.grpBxforPic.ResumeLayout(false);
            this.grpBxforPic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpadmisn;
        private System.Windows.Forms.Label lblAdGndr;
        private System.Windows.Forms.Label lblAdAdrs;
        private System.Windows.Forms.Label lblAdfthr;
        private System.Windows.Forms.Label lblAdlstn;
        private System.Windows.Forms.TextBox txtAdFthrN;
        private System.Windows.Forms.TextBox txtAdLstN;
        private System.Windows.Forms.Label lblAdFrstN;
        private System.Windows.Forms.TextBox txtAdFrstN;
        private System.Windows.Forms.Label lblAdmhead;
        private System.Windows.Forms.Button btnAdSbmit;
        private System.Windows.Forms.RadioButton rdBtnFemale;
        private System.Windows.Forms.RadioButton rdBtnmale;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1DOB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBxforPic;
        private System.Windows.Forms.PictureBox pictureBoxAd;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Button btnSavePAd;
        private System.Windows.Forms.Button btnPUplAD;
        private System.Windows.Forms.Label lblimgID;
        private System.Windows.Forms.TextBox txtBxImgId;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblAdCls;
        private System.Windows.Forms.Button btnAdRef;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SchoolProjectDataSet schoolProjectDataSet;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private SchoolProjectDataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
    }
}