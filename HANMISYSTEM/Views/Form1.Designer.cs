namespace HANMISYSTEM
{
    partial class frmprod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprod));
            this.label1 = new System.Windows.Forms.Label();
            this.btnremark = new System.Windows.Forms.Button();
            this.cbwarehouse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cblocation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpartno = new System.Windows.Forms.TextBox();
            this.txtboxno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.btnpacking = new System.Windows.Forms.Button();
            this.txtactualqty = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnpower = new System.Windows.Forms.Button();
            this.txttarget = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtplan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtproductionqty = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtngpartno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtngqty = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbsearch = new System.Windows.Forms.ListBox();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtinventory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Model";
            // 
            // btnremark
            // 
            this.btnremark.Location = new System.Drawing.Point(89, 229);
            this.btnremark.Name = "btnremark";
            this.btnremark.Size = new System.Drawing.Size(130, 32);
            this.btnremark.TabIndex = 0;
            this.btnremark.Text = "Ghi chú";
            this.btnremark.UseVisualStyleBackColor = true;
            this.btnremark.Visible = false;
            this.btnremark.Click += new System.EventHandler(this.btnremark_Click);
            // 
            // cbwarehouse
            // 
            this.cbwarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbwarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbwarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbwarehouse.FormattingEnabled = true;
            this.cbwarehouse.ItemHeight = 18;
            this.cbwarehouse.Location = new System.Drawing.Point(452, 22);
            this.cbwarehouse.Name = "cbwarehouse";
            this.cbwarehouse.Size = new System.Drawing.Size(179, 26);
            this.cbwarehouse.TabIndex = 1;
            this.cbwarehouse.SelectedIndexChanged += new System.EventHandler(this.cbwarehouse_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn kho";
            // 
            // cblocation
            // 
            this.cblocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cblocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblocation.FormattingEnabled = true;
            this.cblocation.ItemHeight = 18;
            this.cblocation.Location = new System.Drawing.Point(713, 22);
            this.cblocation.Name = "cblocation";
            this.cblocation.Size = new System.Drawing.Size(177, 26);
            this.cblocation.TabIndex = 1;
            this.cblocation.SelectedIndexChanged += new System.EventHandler(this.cblocation_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(637, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chọn line";
            // 
            // txtpartno
            // 
            this.txtpartno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpartno.Location = new System.Drawing.Point(89, 356);
            this.txtpartno.Name = "txtpartno";
            this.txtpartno.Size = new System.Drawing.Size(149, 24);
            this.txtpartno.TabIndex = 4;
            this.txtpartno.TextChanged += new System.EventHandler(this.txtpartno_TextChanged);
            // 
            // txtboxno
            // 
            this.txtboxno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxno.Location = new System.Drawing.Point(89, 133);
            this.txtboxno.Name = "txtboxno";
            this.txtboxno.Size = new System.Drawing.Size(199, 24);
            this.txtboxno.TabIndex = 5;
            this.txtboxno.TextChanged += new System.EventHandler(this.txtboxno_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã thùng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã hàng";
            // 
            // txtqty
            // 
            this.txtqty.Enabled = false;
            this.txtqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(304, 133);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(30, 24);
            this.txtqty.TabIndex = 7;
            // 
            // btnpacking
            // 
            this.btnpacking.Enabled = false;
            this.btnpacking.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpacking.Location = new System.Drawing.Point(89, 316);
            this.btnpacking.Name = "btnpacking";
            this.btnpacking.Size = new System.Drawing.Size(78, 31);
            this.btnpacking.TabIndex = 8;
            this.btnpacking.Text = "Đóng gói";
            this.btnpacking.UseVisualStyleBackColor = true;
            this.btnpacking.Click += new System.EventHandler(this.btnpacking_Click);
            // 
            // txtactualqty
            // 
            this.txtactualqty.Enabled = false;
            this.txtactualqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtactualqty.Location = new System.Drawing.Point(376, 136);
            this.txtactualqty.Multiline = true;
            this.txtactualqty.Name = "txtactualqty";
            this.txtactualqty.Size = new System.Drawing.Size(176, 98);
            this.txtactualqty.TabIndex = 9;
            this.txtactualqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtactualqty.TextChanged += new System.EventHandler(this.txtactualqty_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnpower
            // 
            this.btnpower.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpower.Location = new System.Drawing.Point(89, 174);
            this.btnpower.Name = "btnpower";
            this.btnpower.Size = new System.Drawing.Size(130, 49);
            this.btnpower.TabIndex = 0;
            this.btnpower.Text = "Stop line";
            this.btnpower.UseVisualStyleBackColor = true;
            this.btnpower.Click += new System.EventHandler(this.btnpower_Click);
            // 
            // txttarget
            // 
            this.txttarget.Enabled = false;
            this.txttarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttarget.Location = new System.Drawing.Point(896, 11);
            this.txttarget.Multiline = true;
            this.txttarget.Name = "txttarget";
            this.txttarget.Size = new System.Drawing.Size(96, 36);
            this.txttarget.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Kế hoạch";
            // 
            // txtplan
            // 
            this.txtplan.Enabled = false;
            this.txtplan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplan.Location = new System.Drawing.Point(89, 71);
            this.txtplan.Multiline = true;
            this.txtplan.Name = "txtplan";
            this.txtplan.Size = new System.Drawing.Size(130, 40);
            this.txtplan.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(373, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số lượng hiện tại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(301, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "MAX";
            // 
            // txtproductionqty
            // 
            this.txtproductionqty.Enabled = false;
            this.txtproductionqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductionqty.Location = new System.Drawing.Point(558, 136);
            this.txtproductionqty.Multiline = true;
            this.txtproductionqty.Name = "txtproductionqty";
            this.txtproductionqty.Size = new System.Drawing.Size(202, 98);
            this.txtproductionqty.TabIndex = 13;
            this.txtproductionqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(89, 394);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 22);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "NG";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtngpartno
            // 
            this.txtngpartno.Enabled = false;
            this.txtngpartno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngpartno.Location = new System.Drawing.Point(89, 422);
            this.txtngpartno.Name = "txtngpartno";
            this.txtngpartno.Size = new System.Drawing.Size(149, 24);
            this.txtngpartno.TabIndex = 15;
            this.txtngpartno.TextChanged += new System.EventHandler(this.txtngpartno_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Mã hàng";
            // 
            // txtngqty
            // 
            this.txtngqty.Enabled = false;
            this.txtngqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngqty.Location = new System.Drawing.Point(250, 422);
            this.txtngqty.Name = "txtngqty";
            this.txtngqty.Size = new System.Drawing.Size(38, 24);
            this.txtngqty.TabIndex = 16;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(233, 24);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(134, 22);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Scan theo thùng";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluong.Location = new System.Drawing.Point(89, 281);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(199, 24);
            this.txtsoluong.TabIndex = 18;
            this.txtsoluong.Visible = false;
            this.txtsoluong.TextChanged += new System.EventHandler(this.txtsoluong_TextChanged);
            this.txtsoluong.Enter += new System.EventHandler(this.txtsoluong_Enter);
            this.txtsoluong.Validated += new System.EventHandler(this.txtsoluong_Validated);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "Số lượng";
            this.label10.Visible = false;
            // 
            // lbsearch
            // 
            this.lbsearch.FormattingEnabled = true;
            this.lbsearch.Location = new System.Drawing.Point(89, 48);
            this.lbsearch.Name = "lbsearch";
            this.lbsearch.Size = new System.Drawing.Size(130, 134);
            this.lbsearch.TabIndex = 19;
            this.lbsearch.Visible = false;
            this.lbsearch.Click += new System.EventHandler(this.lbsearch_Click);
            // 
            // txtmodel
            // 
            this.txtmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodel.Location = new System.Drawing.Point(89, 23);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(138, 24);
            this.txtmodel.TabIndex = 20;
            this.txtmodel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(560, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 18);
            this.label11.TabIndex = 12;
            this.label11.Text = "Sản lượng trong ngày";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(372, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 18);
            this.label12.TabIndex = 12;
            this.label12.Text = "Tồn kho hiện tại";
            // 
            // txtinventory
            // 
            this.txtinventory.Enabled = false;
            this.txtinventory.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinventory.Location = new System.Drawing.Point(375, 275);
            this.txtinventory.Multiline = true;
            this.txtinventory.Name = "txtinventory";
            this.txtinventory.Size = new System.Drawing.Size(385, 87);
            this.txtinventory.TabIndex = 21;
            this.txtinventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmprod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1004, 600);
            this.Controls.Add(this.txtinventory);
            this.Controls.Add(this.txtmodel);
            this.Controls.Add(this.lbsearch);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.txtngqty);
            this.Controls.Add(this.txtngpartno);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtproductionqty);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtplan);
            this.Controls.Add(this.txttarget);
            this.Controls.Add(this.txtactualqty);
            this.Controls.Add(this.btnpacking);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxno);
            this.Controls.Add(this.txtpartno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cblocation);
            this.Controls.Add(this.cbwarehouse);
            this.Controls.Add(this.btnremark);
            this.Controls.Add(this.btnpower);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmprod";
            this.Text = "Production management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmprod_FormClosing);
            this.Load += new System.EventHandler(this.frmprod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnremark;
        private System.Windows.Forms.TextBox txtboxno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Button btnpacking;
        private System.Windows.Forms.TextBox txtactualqty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtplan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtproductionqty;
        public System.Windows.Forms.Button btnpower;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ComboBox cbwarehouse;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cblocation;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txttarget;
        public System.Windows.Forms.TextBox txtpartno;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtngpartno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtngqty;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbsearch;
        public System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtinventory;
    }
}

