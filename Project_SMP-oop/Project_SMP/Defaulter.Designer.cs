
namespace Project_SMP
{
    partial class Defaulter
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1D = new System.Windows.Forms.ComboBox();
            this.comboBox1Mon = new System.Windows.Forms.ComboBox();
            this.lbldefMon = new System.Windows.Forms.Label();
            this.lblDefY = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView1.Location = new System.Drawing.Point(1, 363);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1304, 341);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1D
            // 
            this.comboBox1D.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1D.FormattingEnabled = true;
            this.comboBox1D.Location = new System.Drawing.Point(266, 108);
            this.comboBox1D.Name = "comboBox1D";
            this.comboBox1D.Size = new System.Drawing.Size(241, 31);
            this.comboBox1D.TabIndex = 1;
            this.comboBox1D.SelectedIndexChanged += new System.EventHandler(this.comboBox1D_SelectedIndexChanged);
            // 
            // comboBox1Mon
            // 
            this.comboBox1Mon.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1Mon.FormattingEnabled = true;
            this.comboBox1Mon.Location = new System.Drawing.Point(933, 101);
            this.comboBox1Mon.Name = "comboBox1Mon";
            this.comboBox1Mon.Size = new System.Drawing.Size(232, 31);
            this.comboBox1Mon.TabIndex = 2;
            this.comboBox1Mon.SelectedIndexChanged += new System.EventHandler(this.comboBox1Mon_SelectedIndexChanged);
            // 
            // lbldefMon
            // 
            this.lbldefMon.AutoSize = true;
            this.lbldefMon.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldefMon.ForeColor = System.Drawing.SystemColors.Control;
            this.lbldefMon.Location = new System.Drawing.Point(785, 98);
            this.lbldefMon.Name = "lbldefMon";
            this.lbldefMon.Size = new System.Drawing.Size(118, 46);
            this.lbldefMon.TabIndex = 3;
            this.lbldefMon.Text = "Month";
            // 
            // lblDefY
            // 
            this.lblDefY.AutoSize = true;
            this.lblDefY.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefY.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDefY.Location = new System.Drawing.Point(111, 101);
            this.lblDefY.Name = "lblDefY";
            this.lblDefY.Size = new System.Drawing.Size(91, 46);
            this.lblDefY.TabIndex = 4;
            this.lblDefY.Text = "Year";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_SMP.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(1174, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project_SMP.Properties.Resources.go_back;
            this.pictureBox2.Location = new System.Drawing.Point(1, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Defaulter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1307, 704);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblDefY);
            this.Controls.Add(this.lbldefMon);
            this.Controls.Add(this.comboBox1Mon);
            this.Controls.Add(this.comboBox1D);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Defaulter";
            this.Text = "Defaulter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Defaulter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1D;
        private System.Windows.Forms.ComboBox comboBox1Mon;
        private System.Windows.Forms.Label lbldefMon;
        private System.Windows.Forms.Label lblDefY;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}