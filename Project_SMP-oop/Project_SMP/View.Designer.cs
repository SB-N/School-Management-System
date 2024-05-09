
namespace Project_SMP
{
    partial class View
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
            this.dataGridView1sh = new System.Windows.Forms.DataGridView();
            this.lblsrchName = new System.Windows.Forms.Label();
            this.txtserch = new System.Windows.Forms.TextBox();
            this.btn1shw = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.groupBox1view = new System.Windows.Forms.GroupBox();
            this.txtsrchID = new System.Windows.Forms.TextBox();
            this.lblsrchID = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1sh)).BeginInit();
            this.groupBox1view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1sh
            // 
            this.dataGridView1sh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1sh.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1sh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1sh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1sh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1sh.Location = new System.Drawing.Point(1, 435);
            this.dataGridView1sh.Name = "dataGridView1sh";
            this.dataGridView1sh.RowHeadersWidth = 62;
            this.dataGridView1sh.RowTemplate.Height = 28;
            this.dataGridView1sh.Size = new System.Drawing.Size(1304, 267);
            this.dataGridView1sh.TabIndex = 0;
            // 
            // lblsrchName
            // 
            this.lblsrchName.AutoSize = true;
            this.lblsrchName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsrchName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblsrchName.Location = new System.Drawing.Point(43, 89);
            this.lblsrchName.Name = "lblsrchName";
            this.lblsrchName.Size = new System.Drawing.Size(239, 33);
            this.lblsrchName.TabIndex = 1;
            this.lblsrchName.Text = "Search By Name";
            // 
            // txtserch
            // 
            this.txtserch.Location = new System.Drawing.Point(246, 89);
            this.txtserch.Name = "txtserch";
            this.txtserch.Size = new System.Drawing.Size(191, 26);
            this.txtserch.TabIndex = 2;
            this.txtserch.TextChanged += new System.EventHandler(this.txtserch_TextChanged);
            this.txtserch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtserch_KeyUp);
            // 
            // btn1shw
            // 
            this.btn1shw.BackColor = System.Drawing.Color.Khaki;
            this.btn1shw.Font = new System.Drawing.Font("Arial Narrow", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1shw.Location = new System.Drawing.Point(156, 164);
            this.btn1shw.Name = "btn1shw";
            this.btn1shw.Size = new System.Drawing.Size(117, 35);
            this.btn1shw.TabIndex = 3;
            this.btn1shw.Text = "Show";
            this.btn1shw.UseVisualStyleBackColor = false;
            this.btn1shw.Click += new System.EventHandler(this.btn1shw_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.Khaki;
            this.btnrefresh.Font = new System.Drawing.Font("Arial Narrow", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Location = new System.Drawing.Point(353, 164);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(129, 35);
            this.btnrefresh.TabIndex = 3;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // groupBox1view
            // 
            this.groupBox1view.Controls.Add(this.txtsrchID);
            this.groupBox1view.Controls.Add(this.btnrefresh);
            this.groupBox1view.Controls.Add(this.lblsrchID);
            this.groupBox1view.Controls.Add(this.btn1shw);
            this.groupBox1view.Location = new System.Drawing.Point(542, 29);
            this.groupBox1view.Name = "groupBox1view";
            this.groupBox1view.Size = new System.Drawing.Size(741, 306);
            this.groupBox1view.TabIndex = 4;
            this.groupBox1view.TabStop = false;
            // 
            // txtsrchID
            // 
            this.txtsrchID.Location = new System.Drawing.Point(316, 82);
            this.txtsrchID.Name = "txtsrchID";
            this.txtsrchID.Size = new System.Drawing.Size(191, 26);
            this.txtsrchID.TabIndex = 3;
            // 
            // lblsrchID
            // 
            this.lblsrchID.AutoSize = true;
            this.lblsrchID.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsrchID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblsrchID.Location = new System.Drawing.Point(74, 75);
            this.lblsrchID.Name = "lblsrchID";
            this.lblsrchID.Size = new System.Drawing.Size(189, 33);
            this.lblsrchID.TabIndex = 2;
            this.lblsrchID.Text = "Search By ID";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Project_SMP.Properties.Resources.close;
            this.pictureBox3.Location = new System.Drawing.Point(1177, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project_SMP.Properties.Resources.goback;
            this.pictureBox2.Location = new System.Drawing.Point(1, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // View
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1307, 704);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1view);
            this.Controls.Add(this.txtserch);
            this.Controls.Add(this.lblsrchName);
            this.Controls.Add(this.dataGridView1sh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "View";
            this.Text = "View";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1sh)).EndInit();
            this.groupBox1view.ResumeLayout(false);
            this.groupBox1view.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1sh;
        private System.Windows.Forms.Label lblsrchName;
        private System.Windows.Forms.TextBox txtserch;
        private System.Windows.Forms.Button btn1shw;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.GroupBox groupBox1view;
        private System.Windows.Forms.TextBox txtsrchID;
        private System.Windows.Forms.Label lblsrchID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}