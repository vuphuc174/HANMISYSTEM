namespace HANMISYSTEM.Views
{
    partial class ReleaseAndReceiveHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbfilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbWarehouse = new System.Windows.Forms.ComboBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnprint = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gradientPanel2 = new HANMISYSTEM.Module.GradientPanel();
            this.btnSearch = new HANMISYSTEM.Module.MyButton();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new HANMISYSTEM.Module.GradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbTotalPage = new System.Windows.Forms.Label();
            this.lbaaa = new System.Windows.Forms.Label();
            this.lbCurrentPage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gradientPanel4 = new HANMISYSTEM.Module.GradientPanel();
            this.gradientPanel3 = new HANMISYSTEM.Module.GradientPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idinvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outwarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inwarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.package = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.gradientPanel2.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.SuspendLayout();
            this.gradientPanel4.SuspendLayout();
            this.gradientPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbfilter
            // 
            this.cbfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfilter.FormattingEnabled = true;
            this.cbfilter.Items.AddRange(new object[] {
            "IN",
            "OUT"});
            this.cbfilter.Location = new System.Drawing.Point(298, 24);
            this.cbfilter.Margin = new System.Windows.Forms.Padding(4);
            this.cbfilter.Name = "cbfilter";
            this.cbfilter.Size = new System.Drawing.Size(66, 26);
            this.cbfilter.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Warehouse";
            // 
            // cbbWarehouse
            // 
            this.cbbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWarehouse.FormattingEnabled = true;
            this.cbbWarehouse.Location = new System.Drawing.Point(110, 24);
            this.cbbWarehouse.Margin = new System.Windows.Forms.Padding(4);
            this.cbbWarehouse.Name = "cbbWarehouse";
            this.cbbWarehouse.Size = new System.Drawing.Size(180, 26);
            this.cbbWarehouse.TabIndex = 13;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(372, 24);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(229, 24);
            this.txtsearch.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.STT,
            this.idinvoice,
            this.outwarehouse,
            this.inwarehouse,
            this.package,
            this.dateio});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = "0";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1177, 427);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnprint
            // 
            this.btnprint.Image = global::HANMISYSTEM.Properties.Resources.print;
            this.btnprint.Location = new System.Drawing.Point(256, 94);
            this.btnprint.Margin = new System.Windows.Forms.Padding(4);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(80, 47);
            this.btnprint.TabIndex = 20;
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gradientPanel2);
            this.panel2.Controls.Add(this.gradientPanel1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1177, 145);
            this.panel2.TabIndex = 21;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.ColorBottom = System.Drawing.Color.Empty;
            this.gradientPanel2.ColorTop = System.Drawing.Color.Empty;
            this.gradientPanel2.Controls.Add(this.btnSearch);
            this.gradientPanel2.Controls.Add(this.endDate);
            this.gradientPanel2.Controls.Add(this.startDate);
            this.gradientPanel2.Controls.Add(this.cbbWarehouse);
            this.gradientPanel2.Controls.Add(this.label6);
            this.gradientPanel2.Controls.Add(this.label5);
            this.gradientPanel2.Controls.Add(this.label1);
            this.gradientPanel2.Controls.Add(this.cbfilter);
            this.gradientPanel2.Controls.Add(this.txtsearch);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 36);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(837, 109);
            this.gradientPanel2.TabIndex = 23;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(365, 69);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 27);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // endDate
            // 
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(241, 72);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(115, 24);
            this.endDate.TabIndex = 18;
            // 
            // startDate
            // 
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(108, 72);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(115, 24);
            this.startDate.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "~";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Thời gian";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.White;
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.pictureBox2);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(837, 36);
            this.gradientPanel1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(56, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lịch sử xuất nhập";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::HANMISYSTEM.Properties.Resources.right_arrow;
            this.pictureBox2.Location = new System.Drawing.Point(40, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HANMISYSTEM.Properties.Resources.home;
            this.pictureBox1.Location = new System.Drawing.Point(11, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnprint);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(837, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(340, 145);
            this.panel4.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(20, 632);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1177, 52);
            this.panel3.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbTotalPage);
            this.panel5.Controls.Add(this.lbaaa);
            this.panel5.Controls.Add(this.lbCurrentPage);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1177, 52);
            this.panel5.TabIndex = 2;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Page";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(747, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(430, 52);
            this.panel7.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnPrevious);
            this.panel9.Controls.Add(this.btnGoFirst);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(85, 52);
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
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnNext);
            this.panel8.Controls.Add(this.btnGoLast);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(341, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(89, 52);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.gradientPanel4);
            this.panel1.Controls.Add(this.gradientPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 165);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 467);
            this.panel1.TabIndex = 23;
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.ColorBottom = System.Drawing.Color.Empty;
            this.gradientPanel4.ColorTop = System.Drawing.Color.Empty;
            this.gradientPanel4.Controls.Add(this.dataGridView1);
            this.gradientPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel4.Location = new System.Drawing.Point(0, 40);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(1177, 427);
            this.gradientPanel4.TabIndex = 13;
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.ColorBottom = System.Drawing.Color.White;
            this.gradientPanel3.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gradientPanel3.Controls.Add(this.label4);
            this.gradientPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel3.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(1177, 40);
            this.gradientPanel3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 40);
            this.label4.TabIndex = 1;
            this.label4.Text = "Danh sách";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // select
            // 
            this.select.FillWeight = 50F;
            this.select.HeaderText = "Select";
            this.select.Name = "select";
            // 
            // STT
            // 
            this.STT.DataPropertyName = "row";
            this.STT.FillWeight = 40F;
            this.STT.HeaderText = "No.";
            this.STT.Name = "STT";
            // 
            // idinvoice
            // 
            this.idinvoice.DataPropertyName = "idslipout";
            this.idinvoice.HeaderText = "Invoice";
            this.idinvoice.Name = "idinvoice";
            // 
            // outwarehouse
            // 
            this.outwarehouse.DataPropertyName = "warehouse";
            this.outwarehouse.HeaderText = "From";
            this.outwarehouse.Name = "outwarehouse";
            // 
            // inwarehouse
            // 
            this.inwarehouse.DataPropertyName = "customer";
            this.inwarehouse.HeaderText = "TO";
            this.inwarehouse.Name = "inwarehouse";
            // 
            // package
            // 
            this.package.DataPropertyName = "packqty";
            this.package.FillWeight = 70F;
            this.package.HeaderText = "Package Q\'ty";
            this.package.Name = "package";
            this.package.ReadOnly = true;
            // 
            // dateio
            // 
            this.dateio.DataPropertyName = "dateout";
            dataGridViewCellStyle5.Format = "g";
            dataGridViewCellStyle5.NullValue = null;
            this.dateio.DefaultCellStyle = dataGridViewCellStyle5;
            this.dateio.HeaderText = "Date";
            this.dateio.Name = "dateio";
            // 
            // ReleaseAndReceiveHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1217, 704);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReleaseAndReceiveHistory";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "ReleaseAndReceiveHistory";
            this.Load += new System.EventHandler(this.ReleaseAndReceiveHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
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
            this.panel1.ResumeLayout(false);
            this.gradientPanel4.ResumeLayout(false);
            this.gradientPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ComboBox cbfilter;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbbWarehouse;
        public System.Windows.Forms.TextBox txtsearch;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private Module.GradientPanel gradientPanel2;
        private Module.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private Module.GradientPanel gradientPanel4;
        private Module.GradientPanel gradientPanel3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        private Module.MyButton btnSearch;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbTotalPage;
        private System.Windows.Forms.Label lbaaa;
        private System.Windows.Forms.Label lbCurrentPage;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn outwarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn inwarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn package;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateio;
    }
}