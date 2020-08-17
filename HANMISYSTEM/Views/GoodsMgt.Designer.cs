namespace HANMISYSTEM
{
    partial class GoodsMgt
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
            this.partno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificationinfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradingpartnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.othername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductKind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpartno = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpartname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtproductivity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtinfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbcategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbunit = new System.Windows.Forms.ComboBox();
            this.btnimport = new System.Windows.Forms.Button();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.btnbrowser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnexcel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbprocess = new System.Windows.Forms.ComboBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.txttradingpartnumber = new System.Windows.Forms.TextBox();
            this.txtothername = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.cbpacking = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbProductKind = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partno,
            this.partname,
            this.category,
            this.specificationinfo,
            this.productivity,
            this.unit,
            this.process,
            this.tradingpartnumber,
            this.othername,
            this.ProductKind});
            this.dataGridView1.Location = new System.Drawing.Point(294, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(677, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // partno
            // 
            this.partno.DataPropertyName = "partno";
            this.partno.HeaderText = "Part NO";
            this.partno.Name = "partno";
            this.partno.ReadOnly = true;
            // 
            // partname
            // 
            this.partname.DataPropertyName = "partname";
            this.partname.HeaderText = "Part Name";
            this.partname.Name = "partname";
            this.partname.ReadOnly = true;
            // 
            // category
            // 
            this.category.DataPropertyName = "namecategory";
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // specificationinfo
            // 
            this.specificationinfo.DataPropertyName = "specificationinfo";
            this.specificationinfo.HeaderText = "Specification Info";
            this.specificationinfo.Name = "specificationinfo";
            this.specificationinfo.ReadOnly = true;
            // 
            // productivity
            // 
            this.productivity.DataPropertyName = "productivity";
            this.productivity.HeaderText = "Productivity";
            this.productivity.Name = "productivity";
            this.productivity.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "nameunit";
            this.unit.HeaderText = "Unit";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // process
            // 
            this.process.DataPropertyName = "process";
            this.process.HeaderText = "Process";
            this.process.Name = "process";
            this.process.ReadOnly = true;
            // 
            // tradingpartnumber
            // 
            this.tradingpartnumber.DataPropertyName = "tradingpartnumber";
            this.tradingpartnumber.HeaderText = "Trading part number";
            this.tradingpartnumber.Name = "tradingpartnumber";
            this.tradingpartnumber.ReadOnly = true;
            // 
            // othername
            // 
            this.othername.DataPropertyName = "othername";
            this.othername.HeaderText = "Tên tiếng việt";
            this.othername.Name = "othername";
            this.othername.ReadOnly = true;
            // 
            // ProductKind
            // 
            this.ProductKind.DataPropertyName = "ProductionKindID";
            this.ProductKind.HeaderText = "ProductKind";
            this.ProductKind.Name = "ProductKind";
            this.ProductKind.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Partno";
            // 
            // txtpartno
            // 
            this.txtpartno.Location = new System.Drawing.Point(116, 49);
            this.txtpartno.Name = "txtpartno";
            this.txtpartno.Size = new System.Drawing.Size(100, 20);
            this.txtpartno.TabIndex = 2;
            this.txtpartno.TextChanged += new System.EventHandler(this.txtpartno_TextChanged);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(115, 436);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Partname";
            // 
            // txtpartname
            // 
            this.txtpartname.Location = new System.Drawing.Point(116, 75);
            this.txtpartname.Name = "txtpartname";
            this.txtpartname.Size = new System.Drawing.Size(100, 20);
            this.txtpartname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sản lượng / 1H";
            // 
            // txtproductivity
            // 
            this.txtproductivity.Location = new System.Drawing.Point(116, 101);
            this.txtproductivity.Name = "txtproductivity";
            this.txtproductivity.Size = new System.Drawing.Size(100, 20);
            this.txtproductivity.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thông tin thêm";
            // 
            // txtinfo
            // 
            this.txtinfo.Location = new System.Drawing.Point(116, 127);
            this.txtinfo.Multiline = true;
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.Size = new System.Drawing.Size(100, 55);
            this.txtinfo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Danh mục";
            // 
            // cbcategory
            // 
            this.cbcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbcategory.FormattingEnabled = true;
            this.cbcategory.Location = new System.Drawing.Point(116, 225);
            this.cbcategory.Name = "cbcategory";
            this.cbcategory.Size = new System.Drawing.Size(121, 21);
            this.cbcategory.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Đơn vị tính";
            // 
            // cbunit
            // 
            this.cbunit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbunit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbunit.FormattingEnabled = true;
            this.cbunit.Location = new System.Drawing.Point(116, 252);
            this.cbunit.Name = "cbunit";
            this.cbunit.Size = new System.Drawing.Size(121, 21);
            this.cbunit.TabIndex = 5;
            // 
            // btnimport
            // 
            this.btnimport.Location = new System.Drawing.Point(866, 17);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(75, 23);
            this.btnimport.TabIndex = 6;
            this.btnimport.Text = "Import";
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Visible = false;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(645, 19);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(129, 20);
            this.txtpath.TabIndex = 7;
            // 
            // btnbrowser
            // 
            this.btnbrowser.Location = new System.Drawing.Point(781, 17);
            this.btnbrowser.Name = "btnbrowser";
            this.btnbrowser.Size = new System.Drawing.Size(75, 23);
            this.btnbrowser.TabIndex = 8;
            this.btnbrowser.Text = "Browser";
            this.btnbrowser.UseVisualStyleBackColor = true;
            this.btnbrowser.Click += new System.EventHandler(this.btnbrowser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HANMISYSTEM.Properties.Resources.upload;
            this.pictureBox1.Location = new System.Drawing.Point(588, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(645, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Uploading....";
            this.label7.Visible = false;
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(866, 505);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(75, 23);
            this.btnexcel.TabIndex = 11;
            this.btnexcel.Text = "Excel";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HANMISYSTEM.Properties.Resources.upload;
            this.pictureBox2.Location = new System.Drawing.Point(829, 505);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(368, 20);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(124, 20);
            this.txtsearch.TabIndex = 13;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Search";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Quy trình";
            // 
            // cbprocess
            // 
            this.cbprocess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbprocess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbprocess.FormattingEnabled = true;
            this.cbprocess.Location = new System.Drawing.Point(116, 192);
            this.cbprocess.Name = "cbprocess";
            this.cbprocess.Size = new System.Drawing.Size(121, 21);
            this.cbprocess.TabIndex = 17;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(196, 436);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(57, 23);
            this.btnsave.TabIndex = 18;
            this.btnsave.Text = "Lưu lại";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txttradingpartnumber
            // 
            this.txttradingpartnumber.Location = new System.Drawing.Point(115, 369);
            this.txttradingpartnumber.Name = "txttradingpartnumber";
            this.txttradingpartnumber.Size = new System.Drawing.Size(154, 20);
            this.txttradingpartnumber.TabIndex = 19;
            // 
            // txtothername
            // 
            this.txtothername.Location = new System.Drawing.Point(115, 395);
            this.txtothername.Name = "txtothername";
            this.txtothername.Size = new System.Drawing.Size(154, 20);
            this.txtothername.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Trading P.no";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Tên tiếng việt";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(222, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(222, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(242, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(243, 233);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(243, 260);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "*";
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(114, 343);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(46, 20);
            this.txtquantity.TabIndex = 20;
            // 
            // cbpacking
            // 
            this.cbpacking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpacking.FormattingEnabled = true;
            this.cbpacking.Items.AddRange(new object[] {
            "BOX",
            "BAG",
            "CRT",
            "CAN",
            "PAL",
            "ROL",
            "TRA"});
            this.cbpacking.Location = new System.Drawing.Point(115, 312);
            this.cbpacking.Name = "cbpacking";
            this.cbpacking.Size = new System.Drawing.Size(121, 21);
            this.cbpacking.TabIndex = 21;
            this.cbpacking.SelectedIndexChanged += new System.EventHandler(this.cbpacking_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(37, 319);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Kiểu đóng gói";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(37, 350);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Số lượng";
            // 
            // cbProductKind
            // 
            this.cbProductKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductKind.FormattingEnabled = true;
            this.cbProductKind.Location = new System.Drawing.Point(115, 279);
            this.cbProductKind.Name = "cbProductKind";
            this.cbProductKind.Size = new System.Drawing.Size(121, 21);
            this.cbProductKind.TabIndex = 24;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(37, 287);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Model";
            // 
            // GoodsMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 555);
            this.Controls.Add(this.cbProductKind);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbpacking);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtothername);
            this.Controls.Add(this.txttradingpartnumber);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.cbprocess);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnbrowser);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.btnimport);
            this.Controls.Add(this.cbunit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbcategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtinfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtproductivity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpartname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpartno);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GoodsMgt";
            this.Text = "GoodsMgt";
            this.Load += new System.EventHandler(this.GoodsMgt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpartno;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpartname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtproductivity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtinfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbcategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbunit;
        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Button btnbrowser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbprocess;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txttradingpartnumber;
        private System.Windows.Forms.TextBox txtothername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.ComboBox cbpacking;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbProductKind;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewTextBoxColumn partno;
        private System.Windows.Forms.DataGridViewTextBoxColumn partname;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificationinfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn productivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn process;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradingpartnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn othername;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductKind;
    }
}