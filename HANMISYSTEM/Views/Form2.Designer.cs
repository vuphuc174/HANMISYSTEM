namespace HANMISYSTEM
{
    partial class productionline2
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
            this.txtngqty = new System.Windows.Forms.TextBox();
            this.txtngpartno = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtplan = new System.Windows.Forms.TextBox();
            this.txttarget = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnpacking = new System.Windows.Forms.Button();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxno = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbpartno = new System.Windows.Forms.ComboBox();
            this.btnremark = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnpower = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cblocation = new System.Windows.Forms.ComboBox();
            this.cbwarehouse = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtngqty
            // 
            this.txtngqty.Enabled = false;
            this.txtngqty.Location = new System.Drawing.Point(232, 477);
            this.txtngqty.Name = "txtngqty";
            this.txtngqty.Size = new System.Drawing.Size(38, 20);
            this.txtngqty.TabIndex = 42;
            // 
            // txtngpartno
            // 
            this.txtngpartno.Enabled = false;
            this.txtngpartno.Location = new System.Drawing.Point(82, 477);
            this.txtngpartno.Name = "txtngpartno";
            this.txtngpartno.Size = new System.Drawing.Size(130, 20);
            this.txtngpartno.TabIndex = 41;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(82, 444);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(42, 17);
            this.checkBox1.TabIndex = 40;
            this.checkBox1.Text = "NG";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "MAX";
            // 
            // txtplan
            // 
            this.txtplan.Enabled = false;
            this.txtplan.Location = new System.Drawing.Point(85, 74);
            this.txtplan.Name = "txtplan";
            this.txtplan.Size = new System.Drawing.Size(31, 20);
            this.txtplan.TabIndex = 36;
            // 
            // txttarget
            // 
            this.txttarget.Enabled = false;
            this.txttarget.Location = new System.Drawing.Point(862, 38);
            this.txttarget.Name = "txttarget";
            this.txttarget.Size = new System.Drawing.Size(36, 20);
            this.txttarget.TabIndex = 35;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnpacking
            // 
            this.btnpacking.Location = new System.Drawing.Point(82, 292);
            this.btnpacking.Name = "btnpacking";
            this.btnpacking.Size = new System.Drawing.Size(130, 31);
            this.btnpacking.TabIndex = 33;
            this.btnpacking.Text = "Đóng gói";
            this.btnpacking.UseVisualStyleBackColor = true;
            // 
            // txtqty
            // 
            this.txtqty.Enabled = false;
            this.txtqty.Location = new System.Drawing.Point(218, 133);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(30, 20);
            this.txtqty.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 484);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "SCAN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "BOX.NO";
            // 
            // txtboxno
            // 
            this.txtboxno.Location = new System.Drawing.Point(82, 133);
            this.txtboxno.Name = "txtboxno";
            this.txtboxno.Size = new System.Drawing.Size(130, 20);
            this.txtboxno.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(347, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 439);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partno,
            this.partname,
            this.quantity,
            this.boxqty,
            this.bagqty,
            this.cartqty});
            this.dataGridView1.Location = new System.Drawing.Point(6, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 424);
            this.dataGridView1.TabIndex = 0;
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
            this.quantity.HeaderText = "Inventory";
            this.quantity.Name = "quantity";
            // 
            // boxqty
            // 
            this.boxqty.DataPropertyName = "boxqty";
            this.boxqty.HeaderText = "Box Q.ty";
            this.boxqty.Name = "boxqty";
            // 
            // bagqty
            // 
            this.bagqty.DataPropertyName = "bagqty";
            this.bagqty.HeaderText = "Bag Qty";
            this.bagqty.Name = "bagqty";
            // 
            // cartqty
            // 
            this.cartqty.DataPropertyName = "cartqty";
            this.cartqty.HeaderText = "Cart Qty";
            this.cartqty.Name = "cartqty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Partno";
            // 
            // cbpartno
            // 
            this.cbpartno.FormattingEnabled = true;
            this.cbpartno.ItemHeight = 13;
            this.cbpartno.Location = new System.Drawing.Point(85, 37);
            this.cbpartno.Name = "cbpartno";
            this.cbpartno.Size = new System.Drawing.Size(130, 21);
            this.cbpartno.TabIndex = 20;
            // 
            // btnremark
            // 
            this.btnremark.Location = new System.Drawing.Point(82, 208);
            this.btnremark.Name = "btnremark";
            this.btnremark.Size = new System.Drawing.Size(130, 32);
            this.btnremark.TabIndex = 18;
            this.btnremark.Text = "Ghi chú";
            this.btnremark.UseVisualStyleBackColor = true;
            this.btnremark.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Kế hoạch";
            // 
            // btnpower
            // 
            this.btnpower.Location = new System.Drawing.Point(82, 170);
            this.btnpower.Name = "btnpower";
            this.btnpower.Size = new System.Drawing.Size(130, 32);
            this.btnpower.TabIndex = 17;
            this.btnpower.Text = "Stop line";
            this.btnpower.UseVisualStyleBackColor = true;
            this.btnpower.Click += new System.EventHandler(this.btnpower_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(634, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Chọn line";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Chọn kho";
            // 
            // cblocation
            // 
            this.cblocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cblocation.FormattingEnabled = true;
            this.cblocation.ItemHeight = 13;
            this.cblocation.Location = new System.Drawing.Point(719, 37);
            this.cblocation.Name = "cblocation";
            this.cblocation.Size = new System.Drawing.Size(130, 21);
            this.cblocation.TabIndex = 21;
            // 
            // cbwarehouse
            // 
            this.cbwarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbwarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbwarehouse.FormattingEnabled = true;
            this.cbwarehouse.ItemHeight = 13;
            this.cbwarehouse.Location = new System.Drawing.Point(481, 37);
            this.cbwarehouse.Name = "cbwarehouse";
            this.cbwarehouse.Size = new System.Drawing.Size(130, 21);
            this.cbwarehouse.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Số lượng";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(82, 266);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(130, 20);
            this.txtsoluong.TabIndex = 44;
            this.txtsoluong.TextChanged += new System.EventHandler(this.txtsoluong_TextChanged);
            // 
            // productionline2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 541);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtngqty);
            this.Controls.Add(this.txtngpartno);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtplan);
            this.Controls.Add(this.txttarget);
            this.Controls.Add(this.btnpacking);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbpartno);
            this.Controls.Add(this.btnremark);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnpower);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cblocation);
            this.Controls.Add(this.cbwarehouse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "productionline2";
            this.Text = "Production line (2)";
            this.Load += new System.EventHandler(this.productionline2_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtngqty;
        private System.Windows.Forms.TextBox txtngpartno;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtplan;
        public System.Windows.Forms.TextBox txttarget;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnpacking;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partno;
        private System.Windows.Forms.DataGridViewTextBoxColumn partname;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartqty;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbpartno;
        private System.Windows.Forms.Button btnremark;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnpower;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cblocation;
        public System.Windows.Forms.ComboBox cbwarehouse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsoluong;

    }
}