namespace HANMISYSTEM
{
    partial class inproduction
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
            this.datagridview4 = new System.Windows.Forms.DataGridView();
            this.partno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trayqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Canqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palletqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidpack = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtpartno = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbsupplier = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbposition = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbnotify = new System.Windows.Forms.Label();
            this.lbsuggest = new System.Windows.Forms.LinkLabel();
            this.lbposition = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btncheck = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbsearch = new System.Windows.Forms.ListBox();
            this.txtpartname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbwarehouse = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtlineqty = new System.Windows.Forms.TextBox();
            this.chkcheckall = new System.Windows.Forms.CheckBox();
            this.txtsumqty = new System.Windows.Forms.TextBox();
            this.txtinvoice = new System.Windows.Forms.TextBox();
            this.btnremove = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idpack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dateofmanufacture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partno1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridview4
            // 
            this.datagridview4.AllowUserToAddRows = false;
            this.datagridview4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partno,
            this.partname,
            this.quantity,
            this.boxqty,
            this.bagqty,
            this.cartqty,
            this.Trayqty,
            this.rollqty,
            this.Canqty,
            this.palletqty});
            this.datagridview4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridview4.Location = new System.Drawing.Point(0, 0);
            this.datagridview4.Name = "datagridview4";
            this.datagridview4.RowHeadersVisible = false;
            this.datagridview4.Size = new System.Drawing.Size(629, 320);
            this.datagridview4.TabIndex = 0;
            this.datagridview4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.datagridview4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview4_CellContentClick);
            // 
            // partno
            // 
            this.partno.DataPropertyName = "partno";
            this.partno.HeaderText = "Part No";
            this.partno.Name = "partno";
            // 
            // partname
            // 
            this.partname.DataPropertyName = "partname";
            this.partname.HeaderText = "Part Name";
            this.partname.Name = "partname";
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "qty";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // boxqty
            // 
            this.boxqty.DataPropertyName = "boxqty";
            this.boxqty.HeaderText = "Box Qty";
            this.boxqty.Name = "boxqty";
            // 
            // bagqty
            // 
            this.bagqty.DataPropertyName = "bagqty";
            this.bagqty.HeaderText = "Bag qty";
            this.bagqty.Name = "bagqty";
            // 
            // cartqty
            // 
            this.cartqty.DataPropertyName = "cartqty";
            this.cartqty.HeaderText = "Cart qty";
            this.cartqty.Name = "cartqty";
            // 
            // Trayqty
            // 
            this.Trayqty.DataPropertyName = "trayqty";
            this.Trayqty.HeaderText = "Tray qty";
            this.Trayqty.Name = "Trayqty";
            // 
            // rollqty
            // 
            this.rollqty.DataPropertyName = "rollqty";
            this.rollqty.HeaderText = "Roll Qty";
            this.rollqty.Name = "rollqty";
            // 
            // Canqty
            // 
            this.Canqty.DataPropertyName = "canqty";
            this.Canqty.HeaderText = "Can qty";
            this.Canqty.Name = "Canqty";
            // 
            // palletqty
            // 
            this.palletqty.DataPropertyName = "palletqty";
            this.palletqty.HeaderText = "Pallet qty";
            this.palletqty.Name = "palletqty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Model";
            // 
            // txtidpack
            // 
            this.txtidpack.Location = new System.Drawing.Point(100, 173);
            this.txtidpack.Name = "txtidpack";
            this.txtidpack.Size = new System.Drawing.Size(121, 20);
            this.txtidpack.TabIndex = 2;
            this.txtidpack.TextChanged += new System.EventHandler(this.txtidpack_TextChanged);
            this.txtidpack.Leave += new System.EventHandler(this.txtidpack_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã thùng";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(473, 258);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Nhập hàng";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtpartno
            // 
            this.txtpartno.Location = new System.Drawing.Point(100, 115);
            this.txtpartno.Name = "txtpartno";
            this.txtpartno.Size = new System.Drawing.Size(121, 20);
            this.txtpartno.TabIndex = 5;
            this.txtpartno.TextChanged += new System.EventHandler(this.txtpartno_TextChanged);
            this.txtpartno.Leave += new System.EventHandler(this.txtpartno_Leave);
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(100, 200);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(43, 20);
            this.txtqty.TabIndex = 6;
            this.txtqty.TextChanged += new System.EventHandler(this.txtqty_TextChanged);
            this.txtqty.Leave += new System.EventHandler(this.txtqty_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nhà cung cấp";
            // 
            // cbsupplier
            // 
            this.cbsupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsupplier.FormattingEnabled = true;
            this.cbsupplier.Location = new System.Drawing.Point(100, 87);
            this.cbsupplier.Name = "cbsupplier";
            this.cbsupplier.Size = new System.Drawing.Size(121, 21);
            this.cbsupplier.TabIndex = 9;
            this.cbsupplier.SelectedIndexChanged += new System.EventHandler(this.cbsupplier_SelectedIndexChanged);
            this.cbsupplier.Click += new System.EventHandler(this.cbsupplier_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vị trí ";
            // 
            // cbposition
            // 
            this.cbposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbposition.FormattingEnabled = true;
            this.cbposition.Location = new System.Drawing.Point(100, 280);
            this.cbposition.Name = "cbposition";
            this.cbposition.Size = new System.Drawing.Size(71, 21);
            this.cbposition.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Vị trí đề xuất :";
            // 
            // lbnotify
            // 
            this.lbnotify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbnotify.Location = new System.Drawing.Point(19, 4);
            this.lbnotify.Name = "lbnotify";
            this.lbnotify.Size = new System.Drawing.Size(248, 50);
            this.lbnotify.TabIndex = 14;
            this.lbnotify.Text = "*";
            // 
            // lbsuggest
            // 
            this.lbsuggest.AutoSize = true;
            this.lbsuggest.Location = new System.Drawing.Point(97, 264);
            this.lbsuggest.Name = "lbsuggest";
            this.lbsuggest.Size = new System.Drawing.Size(16, 13);
            this.lbsuggest.TabIndex = 15;
            this.lbsuggest.TabStop = true;
            this.lbsuggest.Text = "...";
            this.lbsuggest.Click += new System.EventHandler(this.lbsuggest_Click);
            // 
            // lbposition
            // 
            this.lbposition.AutoSize = true;
            this.lbposition.Location = new System.Drawing.Point(3, 361);
            this.lbposition.Name = "lbposition";
            this.lbposition.Size = new System.Drawing.Size(16, 13);
            this.lbposition.TabIndex = 18;
            this.lbposition.Text = "...";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(417, 320);
            this.dataGridView2.TabIndex = 19;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btncheck
            // 
            this.btncheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncheck.Location = new System.Drawing.Point(227, 113);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(60, 23);
            this.btncheck.TabIndex = 20;
            this.btncheck.Text = "Kiểm tra";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbsearch);
            this.panel1.Controls.Add(this.txtpartname);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbposition);
            this.panel1.Controls.Add(this.cbwarehouse);
            this.panel1.Controls.Add(this.txtidpack);
            this.panel1.Controls.Add(this.btncheck);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbsuggest);
            this.panel1.Controls.Add(this.txtpartno);
            this.panel1.Controls.Add(this.lbnotify);
            this.panel1.Controls.Add(this.txtqty);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbposition);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbsupplier);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 389);
            this.panel1.TabIndex = 21;
            // 
            // lbsearch
            // 
            this.lbsearch.FormattingEnabled = true;
            this.lbsearch.Location = new System.Drawing.Point(100, 136);
            this.lbsearch.Name = "lbsearch";
            this.lbsearch.Size = new System.Drawing.Size(233, 160);
            this.lbsearch.TabIndex = 21;
            this.lbsearch.Visible = false;
            this.lbsearch.Click += new System.EventHandler(this.lbsearch_Click);
            // 
            // txtpartname
            // 
            this.txtpartname.Enabled = false;
            this.txtpartname.Location = new System.Drawing.Point(100, 141);
            this.txtpartname.Name = "txtpartname";
            this.txtpartname.Size = new System.Drawing.Size(224, 20);
            this.txtpartname.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Kho";
            // 
            // cbwarehouse
            // 
            this.cbwarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbwarehouse.FormattingEnabled = true;
            this.cbwarehouse.Location = new System.Drawing.Point(100, 60);
            this.cbwarehouse.Name = "cbwarehouse";
            this.cbwarehouse.Size = new System.Drawing.Size(121, 21);
            this.cbwarehouse.TabIndex = 22;
            this.cbwarehouse.SelectedIndexChanged += new System.EventHandler(this.cbwarehouse_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtlineqty);
            this.panel2.Controls.Add(this.chkcheckall);
            this.panel2.Controls.Add(this.txtsumqty);
            this.panel2.Controls.Add(this.txtinvoice);
            this.panel2.Controls.Add(this.btnremove);
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 389);
            this.panel2.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Fn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtlineqty
            // 
            this.txtlineqty.Location = new System.Drawing.Point(4, 283);
            this.txtlineqty.Name = "txtlineqty";
            this.txtlineqty.Size = new System.Drawing.Size(45, 20);
            this.txtlineqty.TabIndex = 7;
            // 
            // chkcheckall
            // 
            this.chkcheckall.AutoSize = true;
            this.chkcheckall.Location = new System.Drawing.Point(473, 15);
            this.chkcheckall.Name = "chkcheckall";
            this.chkcheckall.Size = new System.Drawing.Size(90, 17);
            this.chkcheckall.TabIndex = 6;
            this.chkcheckall.Text = "Chọn toàn bộ";
            this.chkcheckall.UseVisualStyleBackColor = true;
            // 
            // txtsumqty
            // 
            this.txtsumqty.Enabled = false;
            this.txtsumqty.Location = new System.Drawing.Point(265, 283);
            this.txtsumqty.Name = "txtsumqty";
            this.txtsumqty.Size = new System.Drawing.Size(62, 20);
            this.txtsumqty.TabIndex = 5;
            // 
            // txtinvoice
            // 
            this.txtinvoice.Enabled = false;
            this.txtinvoice.Location = new System.Drawing.Point(4, 10);
            this.txtinvoice.Name = "txtinvoice";
            this.txtinvoice.Size = new System.Drawing.Size(136, 20);
            this.txtinvoice.TabIndex = 4;
            // 
            // btnremove
            // 
            this.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremove.Location = new System.Drawing.Point(391, 9);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(75, 23);
            this.btnremove.TabIndex = 1;
            this.btnremove.Text = "Xóa dòng";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpack,
            this.Dateofmanufacture,
            this.partno1,
            this.sl,
            this.position});
            this.dataGridView3.Location = new System.Drawing.Point(4, 37);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(463, 244);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            this.dataGridView3.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellEndEdit);
            this.dataGridView3.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView3_ColumnWidthChanged);
            this.dataGridView3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView3_Scroll);
            // 
            // idpack
            // 
            this.idpack.FillWeight = 120F;
            this.idpack.HeaderText = "IdPack";
            this.idpack.Name = "idpack";
            this.idpack.ReadOnly = true;
            // 
            // Dateofmanufacture
            // 
            this.Dateofmanufacture.HeaderText = "Date Of Manufacture";
            this.Dateofmanufacture.Name = "Dateofmanufacture";
            // 
            // partno1
            // 
            this.partno1.HeaderText = "Partno";
            this.partno1.Name = "partno1";
            this.partno1.ReadOnly = true;
            // 
            // sl
            // 
            this.sl.FillWeight = 80F;
            this.sl.HeaderText = "Quantity";
            this.sl.Name = "sl";
            // 
            // position
            // 
            this.position.HeaderText = "Location";
            this.position.Name = "position";
            this.position.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 389);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1134, 320);
            this.panel3.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.datagridview4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(505, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(629, 320);
            this.panel6.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(417, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(88, 320);
            this.panel5.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(417, 320);
            this.panel4.TabIndex = 20;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1134, 389);
            this.panel7.TabIndex = 24;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(417, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(717, 389);
            this.panel8.TabIndex = 23;
            // 
            // inproduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1134, 709);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inproduction";
            this.Text = "Nhập kho NVL";
            this.Load += new System.EventHandler(this.inproduction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtidpack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtpartno;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbsupplier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbposition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbnotify;
        private System.Windows.Forms.LinkLabel lbsuggest;
        private System.Windows.Forms.Label lbposition;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn partno;
        private System.Windows.Forms.DataGridViewTextBoxColumn partname;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trayqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Canqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn palletqty;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox txtsumqty;
        private System.Windows.Forms.TextBox txtinvoice;
        private System.Windows.Forms.CheckBox chkcheckall;
        private System.Windows.Forms.ListBox lbsearch;
        private System.Windows.Forms.TextBox txtlineqty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbwarehouse;
        private System.Windows.Forms.TextBox txtpartname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dateofmanufacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn partno1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
    }
}