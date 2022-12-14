namespace HANMISYSTEM.Views.Warehouse
{
    partial class Inventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Index_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNo_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackageQty_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbTotalPage = new System.Windows.Forms.Label();
            this.lbaaa = new System.Windows.Forms.Label();
            this.lbCurrentPage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new HANMISYSTEM.Module.GradientPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.cbbWarehouse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnExportExcel = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoFirst)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoLast)).BeginInit();
            this.panel10.SuspendLayout();
            this.pnPageList.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30, 28, 30, 28);
            this.panel1.Size = new System.Drawing.Size(1268, 669);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(30, 164);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1208, 477);
            this.panel4.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1208, 430);
            this.panel6.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index_col,
            this.PartNo_col,
            this.PartName_col,
            this.Quantity_col,
            this.PackageQty_col});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(1208, 430);
            this.dataGridView1.TabIndex = 0;
            // 
            // Index_col
            // 
            this.Index_col.DataPropertyName = "row";
            this.Index_col.FillWeight = 40F;
            this.Index_col.HeaderText = "No.";
            this.Index_col.Name = "Index_col";
            this.Index_col.ReadOnly = true;
            // 
            // PartNo_col
            // 
            this.PartNo_col.DataPropertyName = "partno";
            this.PartNo_col.HeaderText = "Mã hàng";
            this.PartNo_col.Name = "PartNo_col";
            this.PartNo_col.ReadOnly = true;
            // 
            // PartName_col
            // 
            this.PartName_col.DataPropertyName = "partname";
            this.PartName_col.HeaderText = "Tên hàng";
            this.PartName_col.Name = "PartName_col";
            this.PartName_col.ReadOnly = true;
            // 
            // Quantity_col
            // 
            this.Quantity_col.DataPropertyName = "quantity";
            dataGridViewCellStyle1.Format = "N0";
            this.Quantity_col.DefaultCellStyle = dataGridViewCellStyle1;
            this.Quantity_col.HeaderText = "Số lượng";
            this.Quantity_col.Name = "Quantity_col";
            this.Quantity_col.ReadOnly = true;
            // 
            // PackageQty_col
            // 
            this.PackageQty_col.DataPropertyName = "packageqty";
            this.PackageQty_col.HeaderText = "Số lượng đóng gói";
            this.PackageQty_col.Name = "PackageQty_col";
            this.PackageQty_col.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbTotalPage);
            this.panel5.Controls.Add(this.lbaaa);
            this.panel5.Controls.Add(this.lbCurrentPage);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 430);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1208, 47);
            this.panel5.TabIndex = 1;
            // 
            // lbTotalPage
            // 
            this.lbTotalPage.AutoSize = true;
            this.lbTotalPage.Location = new System.Drawing.Point(132, 17);
            this.lbTotalPage.Name = "lbTotalPage";
            this.lbTotalPage.Size = new System.Drawing.Size(40, 18);
            this.lbTotalPage.TabIndex = 2;
            this.lbTotalPage.Text = "9999";
            // 
            // lbaaa
            // 
            this.lbaaa.AutoSize = true;
            this.lbaaa.Location = new System.Drawing.Point(94, 17);
            this.lbaaa.Name = "lbaaa";
            this.lbaaa.Size = new System.Drawing.Size(24, 18);
            this.lbaaa.TabIndex = 3;
            this.lbaaa.Text = "Of";
            // 
            // lbCurrentPage
            // 
            this.lbCurrentPage.AutoSize = true;
            this.lbCurrentPage.Location = new System.Drawing.Point(56, 17);
            this.lbCurrentPage.Name = "lbCurrentPage";
            this.lbCurrentPage.Size = new System.Drawing.Size(16, 18);
            this.lbCurrentPage.TabIndex = 4;
            this.lbCurrentPage.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Page";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(778, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(430, 47);
            this.panel7.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnPrevious);
            this.panel9.Controls.Add(this.btnGoFirst);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(85, 47);
            this.panel9.TabIndex = 2;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.Image = global::HANMISYSTEM.Properties.Resources.rewind_button;
            this.btnPrevious.Location = new System.Drawing.Point(47, 15);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(35, 14);
            this.btnPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnGoFirst
            // 
            this.btnGoFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoFirst.Image = global::HANMISYSTEM.Properties.Resources.previous;
            this.btnGoFirst.Location = new System.Drawing.Point(6, 15);
            this.btnGoFirst.Name = "btnGoFirst";
            this.btnGoFirst.Size = new System.Drawing.Size(35, 14);
            this.btnGoFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGoFirst.TabIndex = 0;
            this.btnGoFirst.TabStop = false;
            this.btnGoFirst.Click += new System.EventHandler(this.btnGoFirst_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnNext);
            this.panel8.Controls.Add(this.btnGoLast);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(341, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(89, 47);
            this.panel8.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Image = global::HANMISYSTEM.Properties.Resources.forward_button;
            this.btnNext.Location = new System.Drawing.Point(14, 15);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 14);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNext.TabIndex = 0;
            this.btnNext.TabStop = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnGoLast
            // 
            this.btnGoLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoLast.Image = global::HANMISYSTEM.Properties.Resources.next;
            this.btnGoLast.Location = new System.Drawing.Point(55, 15);
            this.btnGoLast.Name = "btnGoLast";
            this.btnGoLast.Size = new System.Drawing.Size(35, 14);
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
            this.panel10.Location = new System.Drawing.Point(91, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(246, 44);
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
            this.pnPageList.Location = new System.Drawing.Point(0, 9);
            this.pnPageList.Name = "pnPageList";
            this.pnPageList.Size = new System.Drawing.Size(246, 26);
            this.pnPageList.TabIndex = 1;
            // 
            // p7
            // 
            this.p7.BackColor = System.Drawing.SystemColors.Control;
            this.p7.Dock = System.Windows.Forms.DockStyle.Left;
            this.p7.ForeColor = System.Drawing.Color.Black;
            this.p7.Location = new System.Drawing.Point(180, 0);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(30, 26);
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
            this.p6.Location = new System.Drawing.Point(150, 0);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(30, 26);
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
            this.p5.Location = new System.Drawing.Point(120, 0);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(30, 26);
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
            this.p4.Location = new System.Drawing.Point(90, 0);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(30, 26);
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
            this.p3.Location = new System.Drawing.Point(60, 0);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(30, 26);
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
            this.p2.Location = new System.Drawing.Point(30, 0);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(30, 26);
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
            this.p1.Size = new System.Drawing.Size(30, 26);
            this.p1.TabIndex = 0;
            this.p1.Text = "1";
            this.p1.UseVisualStyleBackColor = false;
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 35);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(246, 9);
            this.panel14.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(246, 9);
            this.panel12.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gradientPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(30, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1208, 43);
            this.panel3.TabIndex = 1;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.White;
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gradientPanel1.Controls.Add(this.panel11);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1208, 43);
            this.gradientPanel1.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.Controls.Add(this.cbbWarehouse);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(916, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(292, 43);
            this.panel11.TabIndex = 4;
            // 
            // cbbWarehouse
            // 
            this.cbbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWarehouse.FormattingEnabled = true;
            this.cbbWarehouse.Location = new System.Drawing.Point(24, 11);
            this.cbbWarehouse.Name = "cbbWarehouse";
            this.cbbWarehouse.Size = new System.Drawing.Size(265, 26);
            this.cbbWarehouse.TabIndex = 3;
            this.cbbWarehouse.SelectedIndexChanged += new System.EventHandler(this.cbbWarehouse_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtsearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(30, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1208, 93);
            this.panel2.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnExportExcel);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel13.Location = new System.Drawing.Point(919, 0);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.panel13.Size = new System.Drawing.Size(289, 93);
            this.panel13.TabIndex = 4;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.Image = global::HANMISYSTEM.Properties.Resources.xlsx;
            this.btnExportExcel.Location = new System.Drawing.Point(244, 48);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(41, 39);
            this.btnExportExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExportExcel.TabIndex = 5;
            this.btnExportExcel.TabStop = false;
            this.toolTip1.SetToolTip(this.btnExportExcel, "Download file");
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm kiếm";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(99, 45);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(201, 24);
            this.txtsearch.TabIndex = 2;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1268, 669);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
            this.panel3.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExportExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
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
        private Module.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotalPage;
        private System.Windows.Forms.Label lbaaa;
        private System.Windows.Forms.Label lbCurrentPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox cbbWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNo_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageQty_col;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.PictureBox btnExportExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}