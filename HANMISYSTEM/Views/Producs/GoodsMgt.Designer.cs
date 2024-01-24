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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Row_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Action_col = new System.Windows.Forms.DataGridViewImageColumn();
            this.ActionCopy_col = new System.Windows.Forms.DataGridViewImageColumn();
            this.ActionDelete_col = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnadd = new System.Windows.Forms.Button();
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
            this.btnsave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.myButton1 = new HANMISYSTEM.Module.MyButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbProcess = new System.Windows.Forms.ComboBox();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new HANMISYSTEM.Module.MyButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbTotalPage = new System.Windows.Forms.Label();
            this.lbaaa = new System.Windows.Forms.Label();
            this.lbCurrentPage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.PictureBox();
            this.btnGoFirst = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.PictureBox();
            this.btnGoLast = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pnPageList = new System.Windows.Forms.Panel();
            this.p7 = new System.Windows.Forms.Button();
            this.p6 = new System.Windows.Forms.Button();
            this.p5 = new System.Windows.Forms.Button();
            this.p4 = new System.Windows.Forms.Button();
            this.p3 = new System.Windows.Forms.Button();
            this.p2 = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoFirst)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoLast)).BeginInit();
            this.panel10.SuspendLayout();
            this.pnPageList.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Row_col,
            this.partno,
            this.partname,
            this.category,
            this.specificationinfo,
            this.productivity,
            this.unit,
            this.process,
            this.tradingpartnumber,
            this.othername,
            this.ProductKind,
            this.Action_col,
            this.ActionCopy_col,
            this.ActionDelete_col});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1327, 582);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            // 
            // Row_col
            // 
            this.Row_col.DataPropertyName = "row";
            this.Row_col.FillWeight = 30F;
            this.Row_col.HeaderText = "STT";
            this.Row_col.Name = "Row_col";
            this.Row_col.ReadOnly = true;
            // 
            // partno
            // 
            this.partno.DataPropertyName = "partno";
            this.partno.FillWeight = 130F;
            this.partno.HeaderText = "Mã hàng";
            this.partno.Name = "partno";
            this.partno.ReadOnly = true;
            // 
            // partname
            // 
            this.partname.DataPropertyName = "partname";
            this.partname.HeaderText = "Tên mặt hàng";
            this.partname.Name = "partname";
            this.partname.ReadOnly = true;
            // 
            // category
            // 
            this.category.DataPropertyName = "namecategory";
            this.category.HeaderText = "Danh mục";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // specificationinfo
            // 
            this.specificationinfo.DataPropertyName = "specificationinfo";
            this.specificationinfo.HeaderText = "Thông số";
            this.specificationinfo.Name = "specificationinfo";
            this.specificationinfo.ReadOnly = true;
            // 
            // productivity
            // 
            this.productivity.DataPropertyName = "productivity";
            dataGridViewCellStyle1.Format = "N0";
            this.productivity.DefaultCellStyle = dataGridViewCellStyle1;
            this.productivity.HeaderText = "Mức UPH đề xuất";
            this.productivity.Name = "productivity";
            this.productivity.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "nameunit";
            this.unit.HeaderText = "Đơn vị";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // process
            // 
            this.process.DataPropertyName = "process";
            this.process.FillWeight = 80F;
            this.process.HeaderText = "Quy trình";
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
            this.ProductKind.HeaderText = "Phân loại";
            this.ProductKind.Name = "ProductKind";
            this.ProductKind.ReadOnly = true;
            // 
            // Action_col
            // 
            this.Action_col.FillWeight = 40F;
            this.Action_col.HeaderText = "";
            this.Action_col.Image = global::HANMISYSTEM.Properties.Resources.edit_button24x24;
            this.Action_col.Name = "Action_col";
            this.Action_col.ReadOnly = true;
            // 
            // ActionCopy_col
            // 
            this.ActionCopy_col.FillWeight = 40F;
            this.ActionCopy_col.HeaderText = "";
            this.ActionCopy_col.Image = global::HANMISYSTEM.Properties.Resources.copy24x24;
            this.ActionCopy_col.Name = "ActionCopy_col";
            this.ActionCopy_col.ReadOnly = true;
            this.ActionCopy_col.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ActionCopy_col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ActionDelete_col
            // 
            this.ActionDelete_col.FillWeight = 40F;
            this.ActionDelete_col.HeaderText = "";
            this.ActionDelete_col.Image = global::HANMISYSTEM.Properties.Resources.delete24x24;
            this.ActionDelete_col.Name = "ActionDelete_col";
            this.ActionDelete_col.ReadOnly = true;
            this.ActionDelete_col.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ActionDelete_col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(922, 57);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(88, 30);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Visible = false;
            // 
            // btnimport
            // 
            this.btnimport.Location = new System.Drawing.Point(1023, 22);
            this.btnimport.Margin = new System.Windows.Forms.Padding(4);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(88, 30);
            this.btnimport.TabIndex = 6;
            this.btnimport.Text = "Import";
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Visible = false;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(766, 46);
            this.txtpath.Margin = new System.Windows.Forms.Padding(4);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(150, 25);
            this.txtpath.TabIndex = 7;
            this.txtpath.Visible = false;
            // 
            // btnbrowser
            // 
            this.btnbrowser.Location = new System.Drawing.Point(914, 20);
            this.btnbrowser.Margin = new System.Windows.Forms.Padding(4);
            this.btnbrowser.Name = "btnbrowser";
            this.btnbrowser.Size = new System.Drawing.Size(88, 30);
            this.btnbrowser.TabIndex = 8;
            this.btnbrowser.Text = "Browser";
            this.btnbrowser.UseVisualStyleBackColor = true;
            this.btnbrowser.Visible = false;
            this.btnbrowser.Click += new System.EventHandler(this.btnbrowser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HANMISYSTEM.Properties.Resources.export;
            this.pictureBox1.Location = new System.Drawing.Point(718, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(766, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Uploading....";
            this.label7.Visible = false;
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(1033, 683);
            this.btnexcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(88, 30);
            this.btnexcel.TabIndex = 11;
            this.btnexcel.Text = "Excel";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HANMISYSTEM.Properties.Resources.export;
            this.pictureBox2.Location = new System.Drawing.Point(990, 683);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 28);
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
            this.txtsearch.Location = new System.Drawing.Point(254, 73);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(144, 25);
            this.txtsearch.TabIndex = 13;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tìm kiếm";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(1017, 60);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(66, 30);
            this.btnsave.TabIndex = 18;
            this.btnsave.Text = "Lưu lại";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Visible = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.myButton1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbbProcess);
            this.panel1.Controls.Add(this.cbbCategory);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtpath);
            this.panel1.Controls.Add(this.btnimport);
            this.panel1.Controls.Add(this.btnbrowser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1327, 102);
            this.panel1.TabIndex = 25;
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.myButton1.FlatAppearance.BorderSize = 0;
            this.myButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton1.ForeColor = System.Drawing.Color.Black;
            this.myButton1.Location = new System.Drawing.Point(402, 65);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(76, 32);
            this.myButton1.TabIndex = 21;
            this.myButton1.Text = "Lọc";
            this.myButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myButton1.UseVisualStyleBackColor = false;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Quy trình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Danh mục";
            // 
            // cbbProcess
            // 
            this.cbbProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProcess.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbbProcess.FormattingEnabled = true;
            this.cbbProcess.ItemHeight = 17;
            this.cbbProcess.Location = new System.Drawing.Point(136, 72);
            this.cbbProcess.Name = "cbbProcess";
            this.cbbProcess.Size = new System.Drawing.Size(113, 25);
            this.cbbProcess.TabIndex = 19;
            // 
            // cbbCategory
            // 
            this.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.ItemHeight = 17;
            this.cbbCategory.Location = new System.Drawing.Point(8, 72);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(113, 25);
            this.cbbCategory.TabIndex = 19;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.ForeColor = System.Drawing.Color.Black;
            this.btnAddProduct.Location = new System.Drawing.Point(494, 65);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(57, 32);
            this.btnAddProduct.TabIndex = 15;
            this.btnAddProduct.Text = "Thêm +";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1327, 624);
            this.panel2.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1327, 582);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 582);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1327, 42);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbTotalPage);
            this.panel6.Controls.Add(this.lbaaa);
            this.panel6.Controls.Add(this.lbCurrentPage);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1327, 42);
            this.panel6.TabIndex = 4;
            // 
            // lbTotalPage
            // 
            this.lbTotalPage.AutoSize = true;
            this.lbTotalPage.Location = new System.Drawing.Point(102, 16);
            this.lbTotalPage.Name = "lbTotalPage";
            this.lbTotalPage.Size = new System.Drawing.Size(41, 19);
            this.lbTotalPage.TabIndex = 2;
            this.lbTotalPage.Text = "9999";
            // 
            // lbaaa
            // 
            this.lbaaa.AutoSize = true;
            this.lbaaa.Location = new System.Drawing.Point(74, 16);
            this.lbaaa.Name = "lbaaa";
            this.lbaaa.Size = new System.Drawing.Size(24, 19);
            this.lbaaa.TabIndex = 3;
            this.lbaaa.Text = "Of";
            // 
            // lbCurrentPage
            // 
            this.lbCurrentPage.AutoSize = true;
            this.lbCurrentPage.Location = new System.Drawing.Point(44, 16);
            this.lbCurrentPage.Name = "lbCurrentPage";
            this.lbCurrentPage.Size = new System.Drawing.Size(17, 19);
            this.lbCurrentPage.TabIndex = 4;
            this.lbCurrentPage.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Page";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(993, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(334, 42);
            this.panel7.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnPrevious);
            this.panel9.Controls.Add(this.btnGoFirst);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(66, 42);
            this.panel9.TabIndex = 2;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.Image = global::HANMISYSTEM.Properties.Resources.rewind_button;
            this.btnPrevious.Location = new System.Drawing.Point(37, 14);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(27, 13);
            this.btnPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnGoFirst
            // 
            this.btnGoFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoFirst.Image = global::HANMISYSTEM.Properties.Resources.previous;
            this.btnGoFirst.Location = new System.Drawing.Point(4, 14);
            this.btnGoFirst.Name = "btnGoFirst";
            this.btnGoFirst.Size = new System.Drawing.Size(27, 13);
            this.btnGoFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGoFirst.TabIndex = 0;
            this.btnGoFirst.TabStop = false;
            this.btnGoFirst.Click += new System.EventHandler(this.btnGoFirst_Click_1);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnNext);
            this.panel8.Controls.Add(this.btnGoLast);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(265, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(69, 42);
            this.panel8.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Image = global::HANMISYSTEM.Properties.Resources.forward_button;
            this.btnNext.Location = new System.Drawing.Point(10, 14);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(27, 13);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNext.TabIndex = 0;
            this.btnNext.TabStop = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnGoLast
            // 
            this.btnGoLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoLast.Image = global::HANMISYSTEM.Properties.Resources.next;
            this.btnGoLast.Location = new System.Drawing.Point(43, 14);
            this.btnGoLast.Name = "btnGoLast";
            this.btnGoLast.Size = new System.Drawing.Size(27, 13);
            this.btnGoLast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGoLast.TabIndex = 0;
            this.btnGoLast.TabStop = false;
            this.btnGoLast.Click += new System.EventHandler(this.btnGoLast_Click);
            // 
            // panel10
            // 
            this.panel10.AutoSize = true;
            this.panel10.Controls.Add(this.pnPageList);
            this.panel10.Controls.Add(this.panel14);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Location = new System.Drawing.Point(71, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(192, 41);
            this.panel10.TabIndex = 3;
            // 
            // pnPageList
            // 
            this.pnPageList.Controls.Add(this.p7);
            this.pnPageList.Controls.Add(this.p6);
            this.pnPageList.Controls.Add(this.p5);
            this.pnPageList.Controls.Add(this.p4);
            this.pnPageList.Controls.Add(this.p3);
            this.pnPageList.Controls.Add(this.p2);
            this.pnPageList.Controls.Add(this.p1);
            this.pnPageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPageList.Location = new System.Drawing.Point(0, 8);
            this.pnPageList.Name = "pnPageList";
            this.pnPageList.Size = new System.Drawing.Size(192, 25);
            this.pnPageList.TabIndex = 1;
            // 
            // p7
            // 
            this.p7.BackColor = System.Drawing.SystemColors.Control;
            this.p7.Dock = System.Windows.Forms.DockStyle.Left;
            this.p7.ForeColor = System.Drawing.Color.Black;
            this.p7.Location = new System.Drawing.Point(162, 0);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(24, 25);
            this.p7.TabIndex = 6;
            this.p7.Text = "...";
            this.p7.UseVisualStyleBackColor = false;
            // 
            // p6
            // 
            this.p6.AutoSize = true;
            this.p6.BackColor = System.Drawing.SystemColors.Control;
            this.p6.Dock = System.Windows.Forms.DockStyle.Left;
            this.p6.ForeColor = System.Drawing.Color.Black;
            this.p6.Location = new System.Drawing.Point(135, 0);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(27, 25);
            this.p6.TabIndex = 5;
            this.p6.Text = "6";
            this.p6.UseVisualStyleBackColor = false;
            // 
            // p5
            // 
            this.p5.AutoSize = true;
            this.p5.BackColor = System.Drawing.SystemColors.Control;
            this.p5.Dock = System.Windows.Forms.DockStyle.Left;
            this.p5.ForeColor = System.Drawing.Color.Black;
            this.p5.Location = new System.Drawing.Point(108, 0);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(27, 25);
            this.p5.TabIndex = 4;
            this.p5.Text = "5";
            this.p5.UseVisualStyleBackColor = false;
            // 
            // p4
            // 
            this.p4.AutoSize = true;
            this.p4.BackColor = System.Drawing.SystemColors.Control;
            this.p4.Dock = System.Windows.Forms.DockStyle.Left;
            this.p4.ForeColor = System.Drawing.Color.Black;
            this.p4.Location = new System.Drawing.Point(81, 0);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(27, 25);
            this.p4.TabIndex = 3;
            this.p4.Text = "4";
            this.p4.UseVisualStyleBackColor = false;
            // 
            // p3
            // 
            this.p3.AutoSize = true;
            this.p3.BackColor = System.Drawing.SystemColors.Control;
            this.p3.Dock = System.Windows.Forms.DockStyle.Left;
            this.p3.ForeColor = System.Drawing.Color.Black;
            this.p3.Location = new System.Drawing.Point(54, 0);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(27, 25);
            this.p3.TabIndex = 2;
            this.p3.Text = "3";
            this.p3.UseVisualStyleBackColor = false;
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.BackColor = System.Drawing.SystemColors.Control;
            this.p2.Dock = System.Windows.Forms.DockStyle.Left;
            this.p2.ForeColor = System.Drawing.Color.Black;
            this.p2.Location = new System.Drawing.Point(27, 0);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(27, 25);
            this.p2.TabIndex = 1;
            this.p2.Text = "2";
            this.p2.UseVisualStyleBackColor = false;
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.p1.Dock = System.Windows.Forms.DockStyle.Left;
            this.p1.ForeColor = System.Drawing.Color.White;
            this.p1.Location = new System.Drawing.Point(0, 0);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(27, 25);
            this.p1.TabIndex = 0;
            this.p1.Text = "1";
            this.p1.UseVisualStyleBackColor = false;
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 33);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(192, 8);
            this.panel14.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(192, 8);
            this.panel12.TabIndex = 0;
            // 
            // GoodsMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1327, 726);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnexcel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GoodsMgt";
            this.Text = "GoodsMgt";
            this.Load += new System.EventHandler(this.GoodsMgt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoFirst)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoLast)).EndInit();
            this.panel10.ResumeLayout(false);
            this.pnPageList.ResumeLayout(false);
            this.pnPageList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnadd;
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
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Panel panel1;
        private Module.MyButton btnAddProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbTotalPage;
        private System.Windows.Forms.Label lbaaa;
        private System.Windows.Forms.Label lbCurrentPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox btnPrevious;
        private System.Windows.Forms.PictureBox btnGoFirst;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox btnNext;
        private System.Windows.Forms.PictureBox btnGoLast;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel pnPageList;
        private System.Windows.Forms.Button p7;
        private System.Windows.Forms.Button p6;
        private System.Windows.Forms.Button p5;
        private System.Windows.Forms.Button p4;
        private System.Windows.Forms.Button p3;
        private System.Windows.Forms.Button p2;
        private System.Windows.Forms.Button p1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ComboBox cbbCategory;
        private Module.MyButton myButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn Row_col;
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
        private System.Windows.Forms.DataGridViewImageColumn Action_col;
        private System.Windows.Forms.DataGridViewImageColumn ActionCopy_col;
        private System.Windows.Forms.DataGridViewImageColumn ActionDelete_col;
    }
}