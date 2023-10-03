namespace HANMISYSTEM
{
    partial class Deliverygoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deliverygoods));
            this.cbewarehouse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbiwarehouse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idpack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtinvoice = new System.Windows.Forms.TextBox();
            this.btnfn = new System.Windows.Forms.Button();
            this.txtsumqty = new System.Windows.Forms.TextBox();
            this.btnremove = new System.Windows.Forms.Button();
            this.txtreason = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbmessage = new System.Windows.Forms.ListBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Partno1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbbdriver = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtrownum = new System.Windows.Forms.TextBox();
            this.btnxuat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gradientPanel2 = new HANMISYSTEM.Module.GradientPanel();
            this.dgvworkorder = new System.Windows.Forms.DataGridView();
            this.gradientPanel1 = new HANMISYSTEM.Module.GradientPanel();
            this.lbposition = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btncheck = new System.Windows.Forms.Button();
            this.lbsearch = new System.Windows.Forms.ListBox();
            this.cbwarehouse = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.vitri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtpartno = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.panel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvworkorder)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbewarehouse
            // 
            this.cbewarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbewarehouse.FormattingEnabled = true;
            this.cbewarehouse.Location = new System.Drawing.Point(89, 5);
            this.cbewarehouse.Margin = new System.Windows.Forms.Padding(4);
            this.cbewarehouse.Name = "cbewarehouse";
            this.cbewarehouse.Size = new System.Drawing.Size(140, 23);
            this.cbewarehouse.TabIndex = 0;
            this.cbewarehouse.SelectedIndexChanged += new System.EventHandler(this.cbewarehouse_SelectedIndexChanged);
            this.cbewarehouse.Click += new System.EventHandler(this.cbewarehouse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kho xuất";
            // 
            // cbiwarehouse
            // 
            this.cbiwarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbiwarehouse.FormattingEnabled = true;
            this.cbiwarehouse.Location = new System.Drawing.Point(322, 4);
            this.cbiwarehouse.Margin = new System.Windows.Forms.Padding(4);
            this.cbiwarehouse.Name = "cbiwarehouse";
            this.cbiwarehouse.Size = new System.Drawing.Size(140, 23);
            this.cbiwarehouse.TabIndex = 0;
            this.cbiwarehouse.SelectedIndexChanged += new System.EventHandler(this.cbiwarehouse_SelectedIndexChanged);
            this.cbiwarehouse.Click += new System.EventHandler(this.cbiwarehouse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kho nhập";
            // 
            // txtboxno
            // 
            this.txtboxno.Location = new System.Drawing.Point(80, 32);
            this.txtboxno.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxno.Name = "txtboxno";
            this.txtboxno.Size = new System.Drawing.Size(140, 21);
            this.txtboxno.TabIndex = 3;
            this.txtboxno.TextChanged += new System.EventHandler(this.txtboxno_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "BOX NO";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeight = 35;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpack,
            this.partno,
            this.boxqty,
            this.Remain,
            this.remark,
            this.Location});
            this.dataGridView2.Location = new System.Drawing.Point(5, 98);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(469, 318);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            this.dataGridView2.ColumnStateChanged += new System.Windows.Forms.DataGridViewColumnStateChangedEventHandler(this.dataGridView2_ColumnStateChanged);
            this.dataGridView2.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_RowEnter);
            this.dataGridView2.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView2_RowsAdded);
            this.dataGridView2.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView2_RowStateChanged);
            // 
            // idpack
            // 
            this.idpack.HeaderText = "Box no";
            this.idpack.Name = "idpack";
            this.idpack.ReadOnly = true;
            // 
            // partno
            // 
            this.partno.HeaderText = "Part no";
            this.partno.Name = "partno";
            this.partno.ReadOnly = true;
            // 
            // boxqty
            // 
            this.boxqty.HeaderText = "Qty";
            this.boxqty.Name = "boxqty";
            this.boxqty.ReadOnly = true;
            // 
            // Remain
            // 
            this.Remain.HeaderText = "Remain";
            this.Remain.Name = "Remain";
            // 
            // remark
            // 
            this.remark.HeaderText = "Remark";
            this.remark.Name = "remark";
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            // 
            // txtinvoice
            // 
            this.txtinvoice.Enabled = false;
            this.txtinvoice.Location = new System.Drawing.Point(6, 67);
            this.txtinvoice.Margin = new System.Windows.Forms.Padding(4);
            this.txtinvoice.Name = "txtinvoice";
            this.txtinvoice.Size = new System.Drawing.Size(147, 21);
            this.txtinvoice.TabIndex = 7;
            this.txtinvoice.TextChanged += new System.EventHandler(this.txtinvoice_TextChanged_1);
            // 
            // btnfn
            // 
            this.btnfn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfn.Location = new System.Drawing.Point(160, 67);
            this.btnfn.Margin = new System.Windows.Forms.Padding(4);
            this.btnfn.Name = "btnfn";
            this.btnfn.Size = new System.Drawing.Size(38, 23);
            this.btnfn.TabIndex = 8;
            this.btnfn.Text = "Fn";
            this.btnfn.UseVisualStyleBackColor = true;
            this.btnfn.Click += new System.EventHandler(this.btnfn_Click);
            // 
            // txtsumqty
            // 
            this.txtsumqty.Location = new System.Drawing.Point(169, 424);
            this.txtsumqty.Margin = new System.Windows.Forms.Padding(4);
            this.txtsumqty.Name = "txtsumqty";
            this.txtsumqty.Size = new System.Drawing.Size(66, 21);
            this.txtsumqty.TabIndex = 9;
            // 
            // btnremove
            // 
            this.btnremove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremove.Location = new System.Drawing.Point(387, 64);
            this.btnremove.Margin = new System.Windows.Forms.Padding(4);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(88, 26);
            this.btnremove.TabIndex = 11;
            this.btnremove.Text = "REMOVE";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // txtreason
            // 
            this.txtreason.Location = new System.Drawing.Point(15, 22);
            this.txtreason.Margin = new System.Windows.Forms.Padding(4);
            this.txtreason.Multiline = true;
            this.txtreason.Name = "txtreason";
            this.txtreason.Size = new System.Drawing.Size(288, 43);
            this.txtreason.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ghi chú:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 427);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Chọn xe";
            this.label5.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1152, 487);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xuất hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.dataGridView4);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(485, 18);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(663, 465);
            this.panel7.TabIndex = 24;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.groupBox3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(663, 144);
            this.panel8.TabIndex = 23;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbmessage);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(663, 144);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Message";
            // 
            // lbmessage
            // 
            this.lbmessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbmessage.FormattingEnabled = true;
            this.lbmessage.ItemHeight = 15;
            this.lbmessage.Location = new System.Drawing.Point(4, 18);
            this.lbmessage.Margin = new System.Windows.Forms.Padding(4);
            this.lbmessage.Name = "lbmessage";
            this.lbmessage.ScrollAlwaysVisible = true;
            this.lbmessage.Size = new System.Drawing.Size(655, 122);
            this.lbmessage.TabIndex = 0;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView4.ColumnHeadersHeight = 35;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Partno1,
            this.PartName1,
            this.quantity1,
            this.Max});
            this.dataGridView4.Location = new System.Drawing.Point(4, 151);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(659, 261);
            this.dataGridView4.TabIndex = 16;
            // 
            // Partno1
            // 
            this.Partno1.HeaderText = "PartNo";
            this.Partno1.Name = "Partno1";
            this.Partno1.ReadOnly = true;
            // 
            // PartName1
            // 
            this.PartName1.HeaderText = "PartName";
            this.PartName1.Name = "PartName1";
            this.PartName1.ReadOnly = true;
            // 
            // quantity1
            // 
            this.quantity1.HeaderText = "Quantity";
            this.quantity1.Name = "quantity1";
            this.quantity1.ReadOnly = true;
            // 
            // Max
            // 
            this.Max.HeaderText = "Max Qty";
            this.Max.Name = "Max";
            this.Max.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 422);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Danh sách hàng chuẩn bị xuất";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbewarehouse);
            this.panel6.Controls.Add(this.cbiwarehouse);
            this.panel6.Controls.Add(this.cbbdriver);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.txtsumqty);
            this.panel6.Controls.Add(this.txtrownum);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.txtboxno);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.dataGridView2);
            this.panel6.Controls.Add(this.txtinvoice);
            this.panel6.Controls.Add(this.btnremove);
            this.panel6.Controls.Add(this.btnfn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(4, 18);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(481, 465);
            this.panel6.TabIndex = 23;
            // 
            // cbbdriver
            // 
            this.cbbdriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbdriver.FormattingEnabled = true;
            this.cbbdriver.Location = new System.Drawing.Point(338, 423);
            this.cbbdriver.Margin = new System.Windows.Forms.Padding(4);
            this.cbbdriver.Name = "cbbdriver";
            this.cbbdriver.Size = new System.Drawing.Size(140, 23);
            this.cbbdriver.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(261, 68);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Số thùng";
            // 
            // txtrownum
            // 
            this.txtrownum.Location = new System.Drawing.Point(322, 64);
            this.txtrownum.Margin = new System.Windows.Forms.Padding(4);
            this.txtrownum.Name = "txtrownum";
            this.txtrownum.ReadOnly = true;
            this.txtrownum.Size = new System.Drawing.Size(46, 21);
            this.txtrownum.TabIndex = 19;
            // 
            // btnxuat
            // 
            this.btnxuat.Location = new System.Drawing.Point(917, 32);
            this.btnxuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.Size = new System.Drawing.Size(106, 33);
            this.btnxuat.TabIndex = 18;
            this.btnxuat.Text = "Xuất hàng";
            this.btnxuat.UseVisualStyleBackColor = true;
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1152, 316);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiểm tra tồn kho";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gradientPanel2);
            this.panel5.Controls.Add(this.gradientPanel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(485, 18);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(663, 294);
            this.panel5.TabIndex = 18;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.ColorBottom = System.Drawing.Color.Empty;
            this.gradientPanel2.ColorTop = System.Drawing.Color.Empty;
            this.gradientPanel2.Controls.Add(this.dgvworkorder);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 36);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(663, 258);
            this.gradientPanel2.TabIndex = 18;
            // 
            // dgvworkorder
            // 
            this.dgvworkorder.AllowUserToAddRows = false;
            this.dgvworkorder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvworkorder.BackgroundColor = System.Drawing.Color.White;
            this.dgvworkorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvworkorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvworkorder.Location = new System.Drawing.Point(0, 0);
            this.dgvworkorder.Margin = new System.Windows.Forms.Padding(4);
            this.dgvworkorder.Name = "dgvworkorder";
            this.dgvworkorder.Size = new System.Drawing.Size(663, 258);
            this.dgvworkorder.TabIndex = 2;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.White;
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gradientPanel1.Controls.Add(this.lbposition);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(663, 36);
            this.gradientPanel1.TabIndex = 17;
            // 
            // lbposition
            // 
            this.lbposition.BackColor = System.Drawing.Color.Transparent;
            this.lbposition.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbposition.Location = new System.Drawing.Point(0, 0);
            this.lbposition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbposition.Name = "lbposition";
            this.lbposition.Size = new System.Drawing.Size(136, 36);
            this.lbposition.TabIndex = 16;
            this.lbposition.Text = "WH";
            this.lbposition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.btncheck);
            this.panel4.Controls.Add(this.lbsearch);
            this.panel4.Controls.Add(this.cbwarehouse);
            this.panel4.Controls.Add(this.dataGridView3);
            this.panel4.Controls.Add(this.txtpartno);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(4, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(481, 294);
            this.panel4.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Kho";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã hàng";
            // 
            // btncheck
            // 
            this.btncheck.Location = new System.Drawing.Point(228, 31);
            this.btncheck.Margin = new System.Windows.Forms.Padding(4);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(88, 26);
            this.btncheck.TabIndex = 2;
            this.btncheck.Text = "Kiểm tra";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // lbsearch
            // 
            this.lbsearch.FormattingEnabled = true;
            this.lbsearch.ItemHeight = 15;
            this.lbsearch.Location = new System.Drawing.Point(73, 63);
            this.lbsearch.Margin = new System.Windows.Forms.Padding(4);
            this.lbsearch.Name = "lbsearch";
            this.lbsearch.Size = new System.Drawing.Size(264, 154);
            this.lbsearch.TabIndex = 5;
            this.lbsearch.Visible = false;
            this.lbsearch.Click += new System.EventHandler(this.lbsearch_Click);
            // 
            // cbwarehouse
            // 
            this.cbwarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbwarehouse.FormattingEnabled = true;
            this.cbwarehouse.Location = new System.Drawing.Point(73, 4);
            this.cbwarehouse.Margin = new System.Windows.Forms.Padding(4);
            this.cbwarehouse.Name = "cbwarehouse";
            this.cbwarehouse.Size = new System.Drawing.Size(140, 23);
            this.cbwarehouse.TabIndex = 3;
            this.cbwarehouse.SelectedIndexChanged += new System.EventHandler(this.cbwarehouse_SelectedIndexChanged);
            this.cbwarehouse.Click += new System.EventHandler(this.cbwarehouse_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vitri,
            this.soluong,
            this.datefi});
            this.dataGridView3.Location = new System.Drawing.Point(0, 83);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(474, 155);
            this.dataGridView3.TabIndex = 4;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // vitri
            // 
            this.vitri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vitri.DataPropertyName = "position";
            this.vitri.HeaderText = "Vị trí";
            this.vitri.Name = "vitri";
            this.vitri.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "sl";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // datefi
            // 
            this.datefi.DataPropertyName = "datefirstin";
            this.datefi.HeaderText = "Date First in";
            this.datefi.Name = "datefi";
            this.datefi.ReadOnly = true;
            // 
            // txtpartno
            // 
            this.txtpartno.Enabled = false;
            this.txtpartno.Location = new System.Drawing.Point(73, 34);
            this.txtpartno.Margin = new System.Windows.Forms.Padding(4);
            this.txtpartno.Name = "txtpartno";
            this.txtpartno.Size = new System.Drawing.Size(148, 21);
            this.txtpartno.TabIndex = 0;
            this.txtpartno.TextChanged += new System.EventHandler(this.txtpartno_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 316);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtreason);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnxuat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1152, 83);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1152, 487);
            this.panel3.TabIndex = 20;
            // 
            // panel9
            // 
            this.panel9.AutoSize = true;
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1152, 886);
            this.panel9.TabIndex = 21;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel3);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 316);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1152, 487);
            this.panel12.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel2);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 803);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1152, 83);
            this.panel11.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel1);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1152, 316);
            this.panel10.TabIndex = 0;
            // 
            // Deliverygoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1152, 886);
            this.Controls.Add(this.panel9);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Deliverygoods";
            this.Text = "Delivery goods";
            this.Load += new System.EventHandler(this.Deliverygoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvworkorder)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbewarehouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbiwarehouse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtinvoice;
        private System.Windows.Forms.Button btnfn;
        private System.Windows.Forms.TextBox txtsumqty;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpack;
        private System.Windows.Forms.DataGridViewTextBoxColumn partno;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remain;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.TextBox txtreason;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ComboBox cbwarehouse;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpartno;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitri;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.ListBox lbsearch;
        private System.Windows.Forms.Button btnxuat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partno1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max;
        private System.Windows.Forms.TextBox txtrownum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbdriver;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbmessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private Module.GradientPanel gradientPanel2;
        private System.Windows.Forms.DataGridView dgvworkorder;
        private Module.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label lbposition;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
    }
}