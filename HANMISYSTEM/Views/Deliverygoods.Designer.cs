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
            this.dgvworkorder = new System.Windows.Forms.DataGridView();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbmessage = new System.Windows.Forms.ListBox();
            this.cbbdriver = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtrownum = new System.Windows.Forms.TextBox();
            this.btnxuat = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Partno1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbposition = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbsearch = new System.Windows.Forms.ListBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.vitri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbwarehouse = new System.Windows.Forms.ComboBox();
            this.btncheck = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpartno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvworkorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // cbewarehouse
            // 
            this.cbewarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbewarehouse.FormattingEnabled = true;
            this.cbewarehouse.Location = new System.Drawing.Point(145, 24);
            this.cbewarehouse.Name = "cbewarehouse";
            this.cbewarehouse.Size = new System.Drawing.Size(121, 21);
            this.cbewarehouse.TabIndex = 0;
            this.cbewarehouse.SelectedIndexChanged += new System.EventHandler(this.cbewarehouse_SelectedIndexChanged);
            this.cbewarehouse.Click += new System.EventHandler(this.cbewarehouse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kho xuất";
            // 
            // cbiwarehouse
            // 
            this.cbiwarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbiwarehouse.FormattingEnabled = true;
            this.cbiwarehouse.Location = new System.Drawing.Point(340, 24);
            this.cbiwarehouse.Name = "cbiwarehouse";
            this.cbiwarehouse.Size = new System.Drawing.Size(121, 21);
            this.cbiwarehouse.TabIndex = 0;
            this.cbiwarehouse.SelectedIndexChanged += new System.EventHandler(this.cbiwarehouse_SelectedIndexChanged);
            this.cbiwarehouse.Click += new System.EventHandler(this.cbiwarehouse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kho nhập";
            // 
            // dgvworkorder
            // 
            this.dgvworkorder.AllowUserToAddRows = false;
            this.dgvworkorder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvworkorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvworkorder.Location = new System.Drawing.Point(450, 33);
            this.dgvworkorder.Name = "dgvworkorder";
            this.dgvworkorder.Size = new System.Drawing.Size(518, 204);
            this.dgvworkorder.TabIndex = 2;
            // 
            // txtboxno
            // 
            this.txtboxno.Location = new System.Drawing.Point(145, 51);
            this.txtboxno.Name = "txtboxno";
            this.txtboxno.Size = new System.Drawing.Size(121, 20);
            this.txtboxno.TabIndex = 3;
            this.txtboxno.TextChanged += new System.EventHandler(this.txtboxno_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "BOX NO";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpack,
            this.partno,
            this.boxqty,
            this.Remain,
            this.remark,
            this.Location});
            this.dataGridView2.Location = new System.Drawing.Point(19, 103);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(442, 191);
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
            this.txtinvoice.Location = new System.Drawing.Point(19, 79);
            this.txtinvoice.Name = "txtinvoice";
            this.txtinvoice.Size = new System.Drawing.Size(126, 20);
            this.txtinvoice.TabIndex = 7;
            this.txtinvoice.TextChanged += new System.EventHandler(this.txtinvoice_TextChanged_1);
            // 
            // btnfn
            // 
            this.btnfn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfn.Location = new System.Drawing.Point(151, 79);
            this.btnfn.Name = "btnfn";
            this.btnfn.Size = new System.Drawing.Size(33, 20);
            this.btnfn.TabIndex = 8;
            this.btnfn.Text = "Fn";
            this.btnfn.UseVisualStyleBackColor = true;
            this.btnfn.Click += new System.EventHandler(this.btnfn_Click);
            // 
            // txtsumqty
            // 
            this.txtsumqty.Location = new System.Drawing.Point(196, 296);
            this.txtsumqty.Name = "txtsumqty";
            this.txtsumqty.Size = new System.Drawing.Size(57, 20);
            this.txtsumqty.TabIndex = 9;
            // 
            // btnremove
            // 
            this.btnremove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremove.Location = new System.Drawing.Point(386, 74);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(75, 23);
            this.btnremove.TabIndex = 11;
            this.btnremove.Text = "REMOVE";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // txtreason
            // 
            this.txtreason.Location = new System.Drawing.Point(19, 318);
            this.txtreason.Multiline = true;
            this.txtreason.Name = "txtreason";
            this.txtreason.Size = new System.Drawing.Size(247, 38);
            this.txtreason.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "REASON";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Chọn xe";
            this.label5.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cbbdriver);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtrownum);
            this.groupBox1.Controls.Add(this.btnxuat);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dataGridView4);
            this.groupBox1.Controls.Add(this.btnfn);
            this.groupBox1.Controls.Add(this.btnremove);
            this.groupBox1.Controls.Add(this.txtinvoice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtsumqty);
            this.groupBox1.Controls.Add(this.txtboxno);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtreason);
            this.groupBox1.Controls.Add(this.cbiwarehouse);
            this.groupBox1.Controls.Add(this.cbewarehouse);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(2, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 487);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xuất hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbmessage);
            this.groupBox3.Location = new System.Drawing.Point(493, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 104);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Message";
            // 
            // lbmessage
            // 
            this.lbmessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbmessage.FormattingEnabled = true;
            this.lbmessage.Location = new System.Drawing.Point(3, 16);
            this.lbmessage.Name = "lbmessage";
            this.lbmessage.ScrollAlwaysVisible = true;
            this.lbmessage.Size = new System.Drawing.Size(418, 85);
            this.lbmessage.TabIndex = 0;
            // 
            // cbbdriver
            // 
            this.cbbdriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbdriver.FormattingEnabled = true;
            this.cbbdriver.Location = new System.Drawing.Point(347, 303);
            this.cbbdriver.Name = "cbbdriver";
            this.cbbdriver.Size = new System.Drawing.Size(121, 21);
            this.cbbdriver.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Số thùng";
            // 
            // txtrownum
            // 
            this.txtrownum.Location = new System.Drawing.Point(340, 77);
            this.txtrownum.Name = "txtrownum";
            this.txtrownum.ReadOnly = true;
            this.txtrownum.Size = new System.Drawing.Size(40, 20);
            this.txtrownum.TabIndex = 19;
            // 
            // btnxuat
            // 
            this.btnxuat.Location = new System.Drawing.Point(826, 303);
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.Size = new System.Drawing.Size(91, 42);
            this.btnxuat.TabIndex = 18;
            this.btnxuat.Text = "Xuất hàng";
            this.btnxuat.UseVisualStyleBackColor = true;
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(489, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Danh sách hàng chuẩn bị xuất";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Partno1,
            this.PartName1,
            this.quantity1,
            this.Max});
            this.dataGridView4.Location = new System.Drawing.Point(494, 129);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(423, 171);
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
            // lbposition
            // 
            this.lbposition.AutoSize = true;
            this.lbposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbposition.Location = new System.Drawing.Point(452, 9);
            this.lbposition.Name = "lbposition";
            this.lbposition.Size = new System.Drawing.Size(38, 20);
            this.lbposition.TabIndex = 16;
            this.lbposition.Text = "WO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbposition);
            this.groupBox2.Controls.Add(this.lbsearch);
            this.groupBox2.Controls.Add(this.dataGridView3);
            this.groupBox2.Controls.Add(this.cbwarehouse);
            this.groupBox2.Controls.Add(this.btncheck);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtpartno);
            this.groupBox2.Controls.Add(this.dgvworkorder);
            this.groupBox2.Location = new System.Drawing.Point(2, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(974, 243);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiểm tra tồn kho";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lbsearch
            // 
            this.lbsearch.FormattingEnabled = true;
            this.lbsearch.Location = new System.Drawing.Point(95, 68);
            this.lbsearch.Name = "lbsearch";
            this.lbsearch.Size = new System.Drawing.Size(227, 134);
            this.lbsearch.TabIndex = 5;
            this.lbsearch.Visible = false;
            this.lbsearch.Click += new System.EventHandler(this.lbsearch_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vitri,
            this.soluong,
            this.datefi});
            this.dataGridView3.Location = new System.Drawing.Point(19, 91);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(402, 146);
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
            // cbwarehouse
            // 
            this.cbwarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbwarehouse.FormattingEnabled = true;
            this.cbwarehouse.Location = new System.Drawing.Point(95, 16);
            this.cbwarehouse.Name = "cbwarehouse";
            this.cbwarehouse.Size = new System.Drawing.Size(121, 21);
            this.cbwarehouse.TabIndex = 3;
            this.cbwarehouse.SelectedIndexChanged += new System.EventHandler(this.cbwarehouse_SelectedIndexChanged);
            this.cbwarehouse.Click += new System.EventHandler(this.cbwarehouse_Click);
            // 
            // btncheck
            // 
            this.btncheck.Location = new System.Drawing.Point(229, 46);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(75, 23);
            this.btncheck.TabIndex = 2;
            this.btncheck.Text = "Kiểm tra";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Kho";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã hàng";
            // 
            // txtpartno
            // 
            this.txtpartno.Enabled = false;
            this.txtpartno.Location = new System.Drawing.Point(95, 48);
            this.txtpartno.Name = "txtpartno";
            this.txtpartno.Size = new System.Drawing.Size(128, 20);
            this.txtpartno.TabIndex = 0;
            this.txtpartno.TextChanged += new System.EventHandler(this.txtpartno_TextChanged);
            // 
            // Deliverygoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 768);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(988, 768);
            this.MinimumSize = new System.Drawing.Size(988, 506);
            this.Name = "Deliverygoods";
            this.Text = "Delivery goods";
            this.Load += new System.EventHandler(this.Deliverygoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvworkorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbewarehouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbiwarehouse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvworkorder;
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
        private System.Windows.Forms.Label lbposition;
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
    }
}