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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPlanID = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtworkorder = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Model";
            // 
            // btnremark
            // 
            this.btnremark.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremark.Location = new System.Drawing.Point(129, 222);
            this.btnremark.Name = "btnremark";
            this.btnremark.Size = new System.Drawing.Size(130, 32);
            this.btnremark.TabIndex = 0;
            this.btnremark.Text = "Ghi chú";
            this.btnremark.UseVisualStyleBackColor = true;
            this.btnremark.Click += new System.EventHandler(this.btnremark_Click);
            // 
            // cbwarehouse
            // 
            this.cbwarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbwarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbwarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbwarehouse.FormattingEnabled = true;
            this.cbwarehouse.ItemHeight = 18;
            this.cbwarehouse.Location = new System.Drawing.Point(541, 11);
            this.cbwarehouse.Name = "cbwarehouse";
            this.cbwarehouse.Size = new System.Drawing.Size(252, 26);
            this.cbwarehouse.TabIndex = 1;
            this.cbwarehouse.SelectedIndexChanged += new System.EventHandler(this.cbwarehouse_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 15);
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
            this.cblocation.Location = new System.Drawing.Point(886, 8);
            this.cblocation.Name = "cblocation";
            this.cblocation.Size = new System.Drawing.Size(177, 26);
            this.cblocation.TabIndex = 1;
            this.cblocation.SelectedIndexChanged += new System.EventHandler(this.cblocation_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(810, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chọn line";
            // 
            // txtpartno
            // 
            this.txtpartno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpartno.Location = new System.Drawing.Point(129, 349);
            this.txtpartno.Name = "txtpartno";
            this.txtpartno.Size = new System.Drawing.Size(233, 29);
            this.txtpartno.TabIndex = 4;
            this.txtpartno.TextChanged += new System.EventHandler(this.txtpartno_TextChanged);
            // 
            // txtboxno
            // 
            this.txtboxno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxno.Location = new System.Drawing.Point(129, 126);
            this.txtboxno.Name = "txtboxno";
            this.txtboxno.Size = new System.Drawing.Size(259, 29);
            this.txtboxno.TabIndex = 5;
            this.txtboxno.TextChanged += new System.EventHandler(this.txtboxno_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã thùng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã hàng";
            // 
            // txtqty
            // 
            this.txtqty.Enabled = false;
            this.txtqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(394, 126);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(30, 29);
            this.txtqty.TabIndex = 7;
            // 
            // btnpacking
            // 
            this.btnpacking.Enabled = false;
            this.btnpacking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpacking.Location = new System.Drawing.Point(129, 309);
            this.btnpacking.Name = "btnpacking";
            this.btnpacking.Size = new System.Drawing.Size(130, 31);
            this.btnpacking.TabIndex = 8;
            this.btnpacking.Text = "Đóng gói";
            this.btnpacking.UseVisualStyleBackColor = true;
            this.btnpacking.Click += new System.EventHandler(this.btnpacking_Click);
            // 
            // txtactualqty
            // 
            this.txtactualqty.Enabled = false;
            this.txtactualqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtactualqty.Location = new System.Drawing.Point(46, 105);
            this.txtactualqty.Name = "txtactualqty";
            this.txtactualqty.Size = new System.Drawing.Size(176, 60);
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
            this.btnpower.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpower.Location = new System.Drawing.Point(129, 167);
            this.btnpower.Name = "btnpower";
            this.btnpower.Size = new System.Drawing.Size(130, 49);
            this.btnpower.TabIndex = 0;
            this.btnpower.Text = "Stop line";
            this.btnpower.UseVisualStyleBackColor = true;
            this.btnpower.Click += new System.EventHandler(this.btnpower_Click);
            // 
            // txttarget
            // 
            this.txttarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txttarget.Enabled = false;
            this.txttarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttarget.Location = new System.Drawing.Point(0, 0);
            this.txttarget.Multiline = true;
            this.txttarget.Name = "txttarget";
            this.txttarget.Size = new System.Drawing.Size(144, 34);
            this.txttarget.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Kế hoạch";
            // 
            // txtplan
            // 
            this.txtplan.Enabled = false;
            this.txtplan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplan.Location = new System.Drawing.Point(129, 64);
            this.txtplan.Multiline = true;
            this.txtplan.Name = "txtplan";
            this.txtplan.Size = new System.Drawing.Size(130, 40);
            this.txtplan.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số lượng hiện tại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(390, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "MAX";
            // 
            // txtproductionqty
            // 
            this.txtproductionqty.Enabled = false;
            this.txtproductionqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductionqty.Location = new System.Drawing.Point(228, 105);
            this.txtproductionqty.Name = "txtproductionqty";
            this.txtproductionqty.Size = new System.Drawing.Size(202, 60);
            this.txtproductionqty.TabIndex = 13;
            this.txtproductionqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(129, 387);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 28);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "NG";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtngpartno
            // 
            this.txtngpartno.Enabled = false;
            this.txtngpartno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngpartno.Location = new System.Drawing.Point(129, 415);
            this.txtngpartno.Name = "txtngpartno";
            this.txtngpartno.Size = new System.Drawing.Size(233, 29);
            this.txtngpartno.TabIndex = 15;
            this.txtngpartno.TextChanged += new System.EventHandler(this.txtngpartno_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "Mã hàng";
            // 
            // txtngqty
            // 
            this.txtngqty.Enabled = false;
            this.txtngqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngqty.Location = new System.Drawing.Point(386, 415);
            this.txtngqty.Name = "txtngqty";
            this.txtngqty.Size = new System.Drawing.Size(38, 29);
            this.txtngqty.TabIndex = 16;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(368, 16);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(167, 28);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Scan theo thùng";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluong.Location = new System.Drawing.Point(129, 274);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(233, 29);
            this.txtsoluong.TabIndex = 18;
            this.txtsoluong.Visible = false;
            this.txtsoluong.TextChanged += new System.EventHandler(this.txtsoluong_TextChanged);
            this.txtsoluong.Enter += new System.EventHandler(this.txtsoluong_Enter);
            this.txtsoluong.Validated += new System.EventHandler(this.txtsoluong_Validated);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 24);
            this.label10.TabIndex = 6;
            this.label10.Text = "Số lượng";
            this.label10.Visible = false;
            // 
            // lbsearch
            // 
            this.lbsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsearch.FormattingEnabled = true;
            this.lbsearch.ItemHeight = 24;
            this.lbsearch.Location = new System.Drawing.Point(129, 41);
            this.lbsearch.Name = "lbsearch";
            this.lbsearch.Size = new System.Drawing.Size(223, 124);
            this.lbsearch.TabIndex = 19;
            this.lbsearch.Visible = false;
            this.lbsearch.Click += new System.EventHandler(this.lbsearch_Click);
            // 
            // txtmodel
            // 
            this.txtmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodel.Location = new System.Drawing.Point(129, 16);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(233, 29);
            this.txtmodel.TabIndex = 20;
            this.txtmodel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(230, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 24);
            this.label11.TabIndex = 12;
            this.label11.Text = "Sản lượng trong ngày";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(42, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 24);
            this.label12.TabIndex = 12;
            this.label12.Text = "Tồn kho hiện tại";
            // 
            // txtinventory
            // 
            this.txtinventory.Enabled = false;
            this.txtinventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinventory.Location = new System.Drawing.Point(45, 244);
            this.txtinventory.Name = "txtinventory";
            this.txtinventory.Size = new System.Drawing.Size(385, 98);
            this.txtinventory.TabIndex = 21;
            this.txtinventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.cbwarehouse);
            this.panel1.Controls.Add(this.cblocation);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 48);
            this.panel1.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 18);
            this.label13.TabIndex = 2;
            this.label13.Text = "Chọn WO";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(340, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Chọn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 8);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(232, 33);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPlanID);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1104, 34);
            this.panel2.TabIndex = 23;
            // 
            // txtPlanID
            // 
            this.txtPlanID.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtPlanID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlanID.Location = new System.Drawing.Point(693, 0);
            this.txtPlanID.Name = "txtPlanID";
            this.txtPlanID.Size = new System.Drawing.Size(100, 35);
            this.txtPlanID.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txttarget);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(793, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(144, 34);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtworkorder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(937, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 34);
            this.panel3.TabIndex = 1;
            // 
            // txtworkorder
            // 
            this.txtworkorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtworkorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtworkorder.Location = new System.Drawing.Point(0, 0);
            this.txtworkorder.Multiline = true;
            this.txtworkorder.Name = "txtworkorder";
            this.txtworkorder.ReadOnly = true;
            this.txtworkorder.Size = new System.Drawing.Size(167, 34);
            this.txtworkorder.TabIndex = 0;
            this.txtworkorder.Text = "...";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btnpower);
            this.panel5.Controls.Add(this.btnremark);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtmodel);
            this.panel5.Controls.Add(this.txtpartno);
            this.panel5.Controls.Add(this.lbsearch);
            this.panel5.Controls.Add(this.txtboxno);
            this.panel5.Controls.Add(this.txtsoluong);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.checkBox2);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.txtngqty);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtngpartno);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.checkBox1);
            this.panel5.Controls.Add(this.txtqty);
            this.panel5.Controls.Add(this.btnpacking);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txtplan);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 82);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(555, 622);
            this.panel5.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.txtactualqty);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.txtinventory);
            this.panel6.Controls.Add(this.txtproductionqty);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(555, 82);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(529, 622);
            this.panel6.TabIndex = 25;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(529, 44);
            this.panel7.TabIndex = 22;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(95, 44);
            this.panel8.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::HANMISYSTEM.Properties.Resources.settings1;
            this.pictureBox1.Location = new System.Drawing.Point(45, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmprod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 704);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmprod";
            this.Text = "Production management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmprod_FormClosing);
            this.Load += new System.EventHandler(this.frmprod_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txtworkorder;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox txtPlanID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
    }
}

