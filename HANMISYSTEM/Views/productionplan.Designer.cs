namespace HANMISYSTEM
{
    partial class productionplan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productionplan));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbwarehouse = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cblocation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpartno = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvplan = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtplan = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnimport = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnbrowser = new System.Windows.Forms.Button();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dtpdateplan = new System.Windows.Forms.DateTimePicker();
            this.cbline = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkdate = new System.Windows.Forms.CheckBox();
            this.lbsearch = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvplan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(86, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày sản xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bộ phận";
            // 
            // cbwarehouse
            // 
            this.cbwarehouse.FormattingEnabled = true;
            this.cbwarehouse.Location = new System.Drawing.Point(86, 114);
            this.cbwarehouse.Name = "cbwarehouse";
            this.cbwarehouse.Size = new System.Drawing.Size(155, 21);
            this.cbwarehouse.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chuyền";
            // 
            // cblocation
            // 
            this.cblocation.FormattingEnabled = true;
            this.cblocation.Location = new System.Drawing.Point(86, 152);
            this.cblocation.Name = "cblocation";
            this.cblocation.Size = new System.Drawing.Size(155, 21);
            this.cblocation.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Model";
            // 
            // txtpartno
            // 
            this.txtpartno.Location = new System.Drawing.Point(86, 190);
            this.txtpartno.Name = "txtpartno";
            this.txtpartno.Size = new System.Drawing.Size(144, 20);
            this.txtpartno.TabIndex = 7;
            this.txtpartno.TextChanged += new System.EventHandler(this.txtpartno_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvplan);
            this.groupBox1.Location = new System.Drawing.Point(308, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 470);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // dgvplan
            // 
            this.dgvplan.AllowUserToAddRows = false;
            this.dgvplan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvplan.ColumnHeadersVisible = false;
            this.dgvplan.Location = new System.Drawing.Point(7, 11);
            this.dgvplan.Name = "dgvplan";
            this.dgvplan.Size = new System.Drawing.Size(541, 442);
            this.dgvplan.TabIndex = 0;
            this.dgvplan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvplan_CellClick);
            this.dgvplan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvplan_MouseClick);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(700, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(653, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Search";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Kế hoạch";
            // 
            // txtplan
            // 
            this.txtplan.Location = new System.Drawing.Point(86, 231);
            this.txtplan.Name = "txtplan";
            this.txtplan.Size = new System.Drawing.Size(144, 20);
            this.txtplan.TabIndex = 7;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(86, 272);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "THÊM";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(146, 574);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(75, 23);
            this.btnexcel.TabIndex = 12;
            this.btnexcel.Text = "Excel";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(227, 574);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Template";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnimport
            // 
            this.btnimport.Location = new System.Drawing.Point(781, 10);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(75, 23);
            this.btnimport.TabIndex = 12;
            this.btnimport.Text = "Import";
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Visible = false;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(167, 272);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 13;
            this.btnsave.Text = "LƯU LẠI";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnbrowser
            // 
            this.btnbrowser.Location = new System.Drawing.Point(700, 10);
            this.btnbrowser.Name = "btnbrowser";
            this.btnbrowser.Size = new System.Drawing.Size(75, 23);
            this.btnbrowser.TabIndex = 14;
            this.btnbrowser.Text = "Browser";
            this.btnbrowser.UseVisualStyleBackColor = true;
            this.btnbrowser.Click += new System.EventHandler(this.btnbrowser_Click);
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(497, 12);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(197, 20);
            this.txtpath.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HANMISYSTEM.Properties.Resources.upload;
            this.pictureBox1.Location = new System.Drawing.Point(448, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // dtpdateplan
            // 
            this.dtpdateplan.Enabled = false;
            this.dtpdateplan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdateplan.Location = new System.Drawing.Point(547, 120);
            this.dtpdateplan.Name = "dtpdateplan";
            this.dtpdateplan.Size = new System.Drawing.Size(100, 20);
            this.dtpdateplan.TabIndex = 17;
            this.dtpdateplan.ValueChanged += new System.EventHandler(this.dtpdateplan_ValueChanged);
            // 
            // cbline
            // 
            this.cbline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbline.FormattingEnabled = true;
            this.cbline.Location = new System.Drawing.Point(369, 119);
            this.cbline.Name = "cbline";
            this.cbline.Size = new System.Drawing.Size(172, 21);
            this.cbline.TabIndex = 18;
            this.cbline.SelectedIndexChanged += new System.EventHandler(this.cbline_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Chuyền";
            // 
            // chkdate
            // 
            this.chkdate.AutoSize = true;
            this.chkdate.Location = new System.Drawing.Point(547, 97);
            this.chkdate.Name = "chkdate";
            this.chkdate.Size = new System.Drawing.Size(93, 17);
            this.chkdate.TabIndex = 21;
            this.chkdate.Text = "Tìm theo ngày";
            this.chkdate.UseVisualStyleBackColor = true;
            this.chkdate.CheckedChanged += new System.EventHandler(this.chkdate_CheckedChanged);
            // 
            // lbsearch
            // 
            this.lbsearch.FormattingEnabled = true;
            this.lbsearch.Location = new System.Drawing.Point(86, 212);
            this.lbsearch.Name = "lbsearch";
            this.lbsearch.Size = new System.Drawing.Size(144, 186);
            this.lbsearch.TabIndex = 22;
            this.lbsearch.Visible = false;
            this.lbsearch.Click += new System.EventHandler(this.lbsearch_Click);
            // 
            // productionplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 626);
            this.Controls.Add(this.lbsearch);
            this.Controls.Add(this.chkdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbline);
            this.Controls.Add(this.dtpdateplan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.btnbrowser);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btnimport);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtplan);
            this.Controls.Add(this.txtpartno);
            this.Controls.Add(this.cblocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbwarehouse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "productionplan";
            this.Text = "Production Plan";
            this.Load += new System.EventHandler(this.productionplan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvplan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbwarehouse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cblocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpartno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvplan;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtplan;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnbrowser;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DateTimePicker dtpdateplan;
        private System.Windows.Forms.ComboBox cbline;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkdate;
        private System.Windows.Forms.ListBox lbsearch;
    }
}