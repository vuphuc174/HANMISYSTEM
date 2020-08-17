namespace HANMISYSTEM.Views
{
    partial class DeliveryPlanForm
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
            this.lbsearch = new System.Windows.Forms.ListBox();
            this.chkdate = new System.Windows.Forms.CheckBox();
            this.dtpdateplan = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.btnbrowser = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.btnimport = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvplan = new System.Windows.Forms.DataGridView();
            this.partno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productiondate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploaddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtplan = new System.Windows.Forms.TextBox();
            this.txtpartno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbwarehouse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvplan)).BeginInit();
            this.SuspendLayout();
            // 
            // lbsearch
            // 
            this.lbsearch.FormattingEnabled = true;
            this.lbsearch.Location = new System.Drawing.Point(111, 160);
            this.lbsearch.Name = "lbsearch";
            this.lbsearch.Size = new System.Drawing.Size(144, 186);
            this.lbsearch.TabIndex = 48;
            this.lbsearch.Visible = false;
            this.lbsearch.Click += new System.EventHandler(this.lbsearch_Click);
            // 
            // chkdate
            // 
            this.chkdate.AutoSize = true;
            this.chkdate.Location = new System.Drawing.Point(339, 74);
            this.chkdate.Name = "chkdate";
            this.chkdate.Size = new System.Drawing.Size(93, 17);
            this.chkdate.TabIndex = 47;
            this.chkdate.Text = "Tìm theo ngày";
            this.chkdate.UseVisualStyleBackColor = true;
            this.chkdate.CheckedChanged += new System.EventHandler(this.chkdate_CheckedChanged);
            // 
            // dtpdateplan
            // 
            this.dtpdateplan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdateplan.Location = new System.Drawing.Point(339, 97);
            this.dtpdateplan.Name = "dtpdateplan";
            this.dtpdateplan.Size = new System.Drawing.Size(100, 20);
            this.dtpdateplan.TabIndex = 44;
            this.dtpdateplan.ValueChanged += new System.EventHandler(this.dtpdateplan_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HANMISYSTEM.Properties.Resources.upload;
            this.pictureBox1.Location = new System.Drawing.Point(473, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(522, 32);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(197, 20);
            this.txtpath.TabIndex = 42;
            // 
            // btnbrowser
            // 
            this.btnbrowser.Location = new System.Drawing.Point(725, 30);
            this.btnbrowser.Name = "btnbrowser";
            this.btnbrowser.Size = new System.Drawing.Size(75, 23);
            this.btnbrowser.TabIndex = 41;
            this.btnbrowser.Text = "Browser";
            this.btnbrowser.UseVisualStyleBackColor = true;
            this.btnbrowser.Click += new System.EventHandler(this.btnbrowser_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(192, 216);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 40;
            this.btnsave.Text = "LƯU LẠI";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(252, 553);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 38;
            this.button3.Text = "Template";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(171, 553);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(75, 23);
            this.btnexcel.TabIndex = 37;
            this.btnexcel.Text = "Excel";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // btnimport
            // 
            this.btnimport.Location = new System.Drawing.Point(806, 30);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(75, 23);
            this.btnimport.TabIndex = 36;
            this.btnimport.Text = "Import";
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Visible = false;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(111, 216);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 39;
            this.btnadd.Text = "THÊM";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Kế hoạch";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(492, 97);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(156, 20);
            this.txtsearch.TabIndex = 33;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Search";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvplan);
            this.groupBox1.Location = new System.Drawing.Point(333, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 470);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // dgvplan
            // 
            this.dgvplan.AllowUserToAddRows = false;
            this.dgvplan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvplan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvplan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partno,
            this.productiondate,
            this.plan,
            this.uploaddate});
            this.dgvplan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvplan.Location = new System.Drawing.Point(3, 16);
            this.dgvplan.Name = "dgvplan";
            this.dgvplan.Size = new System.Drawing.Size(560, 451);
            this.dgvplan.TabIndex = 0;
            this.dgvplan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvplan_CellClick);
            // 
            // partno
            // 
            this.partno.DataPropertyName = "PartNo";
            this.partno.HeaderText = "PartNO";
            this.partno.Name = "partno";
            // 
            // productiondate
            // 
            this.productiondate.DataPropertyName = "ProductionDate";
            this.productiondate.HeaderText = "Production Date";
            this.productiondate.Name = "productiondate";
            // 
            // plan
            // 
            this.plan.DataPropertyName = "Quantity";
            this.plan.HeaderText = "Plans";
            this.plan.Name = "plan";
            // 
            // uploaddate
            // 
            this.uploaddate.DataPropertyName = "UploadDate";
            this.uploaddate.HeaderText = "UploadDate";
            this.uploaddate.Name = "uploaddate";
            // 
            // txtplan
            // 
            this.txtplan.Location = new System.Drawing.Point(111, 175);
            this.txtplan.Name = "txtplan";
            this.txtplan.Size = new System.Drawing.Size(144, 20);
            this.txtplan.TabIndex = 31;
            // 
            // txtpartno
            // 
            this.txtpartno.Location = new System.Drawing.Point(111, 134);
            this.txtpartno.Name = "txtpartno";
            this.txtpartno.Size = new System.Drawing.Size(144, 20);
            this.txtpartno.TabIndex = 30;
            this.txtpartno.TextChanged += new System.EventHandler(this.txtpartno_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Model";
            // 
            // cbwarehouse
            // 
            this.cbwarehouse.FormattingEnabled = true;
            this.cbwarehouse.Location = new System.Drawing.Point(111, 93);
            this.cbwarehouse.Name = "cbwarehouse";
            this.cbwarehouse.Size = new System.Drawing.Size(155, 21);
            this.cbwarehouse.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ngày sản xuất";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // DeliveryPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 691);
            this.Controls.Add(this.lbsearch);
            this.Controls.Add(this.chkdate);
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
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtplan);
            this.Controls.Add(this.txtpartno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbwarehouse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeliveryPlanForm";
            this.Text = "DeliveryPlanForm";
            this.Load += new System.EventHandler(this.DeliveryPlanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvplan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbsearch;
        private System.Windows.Forms.CheckBox chkdate;
        private System.Windows.Forms.DateTimePicker dtpdateplan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Button btnbrowser;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvplan;
        private System.Windows.Forms.TextBox txtplan;
        private System.Windows.Forms.TextBox txtpartno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbwarehouse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partno;
        private System.Windows.Forms.DataGridViewTextBoxColumn productiondate;
        private System.Windows.Forms.DataGridViewTextBoxColumn plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn uploaddate;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}