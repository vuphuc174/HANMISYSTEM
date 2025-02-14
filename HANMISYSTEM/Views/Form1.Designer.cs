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
            this.cblocation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpartno = new System.Windows.Forms.TextBox();
            this.txtboxno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtactualqty = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txttarget = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtplan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtproductionqty = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLabelChecking = new HANMISYSTEM.Module.MyButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPlanID = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtworkorder = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbbMode = new System.Windows.Forms.ComboBox();
            this.txtsoluong = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrentQuantity = new System.Windows.Forms.TextBox();
            this.toggleButton1 = new HANMISYSTEM.CustomControls.ToggleButton();
            this.btnPacking_renew = new HANMISYSTEM.Module.MyButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Code_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnCheckWO = new System.Windows.Forms.Button();
            this.txtTotalWO = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txtWOQuantityAvailable = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCreateWO = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel15.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Model";
            // 
            // cblocation
            // 
            this.cblocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cblocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblocation.FormattingEnabled = true;
            this.cblocation.ItemHeight = 18;
            this.cblocation.Location = new System.Drawing.Point(491, 11);
            this.cblocation.Name = "cblocation";
            this.cblocation.Size = new System.Drawing.Size(177, 26);
            this.cblocation.TabIndex = 1;
            this.cblocation.SelectedIndexChanged += new System.EventHandler(this.cblocation_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chọn line";
            // 
            // txtpartno
            // 
            this.txtpartno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpartno.Location = new System.Drawing.Point(117, 331);
            this.txtpartno.Name = "txtpartno";
            this.txtpartno.Size = new System.Drawing.Size(233, 26);
            this.txtpartno.TabIndex = 4;
            this.txtpartno.TextChanged += new System.EventHandler(this.txtpartno_TextChanged);
            this.txtpartno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpartno_KeyPress);
            // 
            // txtboxno
            // 
            this.txtboxno.Enabled = false;
            this.txtboxno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxno.Location = new System.Drawing.Point(117, 177);
            this.txtboxno.Name = "txtboxno";
            this.txtboxno.Size = new System.Drawing.Size(259, 26);
            this.txtboxno.TabIndex = 5;
            this.txtboxno.TextChanged += new System.EventHandler(this.txtboxno_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã đóng gói:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã hàng";
            // 
            // txtqty
            // 
            this.txtqty.Enabled = false;
            this.txtqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(382, 177);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(66, 26);
            this.txtqty.TabIndex = 7;
            // 
            // txtactualqty
            // 
            this.txtactualqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtactualqty.Enabled = false;
            this.txtactualqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtactualqty.Location = new System.Drawing.Point(24, 44);
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
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Kế hoạch";
            // 
            // txtplan
            // 
            this.txtplan.Enabled = false;
            this.txtplan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplan.Location = new System.Drawing.Point(117, 115);
            this.txtplan.Multiline = true;
            this.txtplan.Name = "txtplan";
            this.txtplan.Size = new System.Drawing.Size(130, 33);
            this.txtplan.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số lượng hiện tại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(379, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Package capa";
            // 
            // txtproductionqty
            // 
            this.txtproductionqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtproductionqty.Enabled = false;
            this.txtproductionqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductionqty.Location = new System.Drawing.Point(206, 44);
            this.txtproductionqty.Name = "txtproductionqty";
            this.txtproductionqty.Size = new System.Drawing.Size(202, 60);
            this.txtproductionqty.TabIndex = 13;
            this.txtproductionqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtproductionqty.TextChanged += new System.EventHandler(this.txtproductionqty_TextChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(356, 69);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(92, 24);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Scan Lot";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 21);
            this.label10.TabIndex = 6;
            this.label10.Text = "Số lượng";
            this.label10.Visible = false;
            // 
            // txtmodel
            // 
            this.txtmodel.Enabled = false;
            this.txtmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodel.Location = new System.Drawing.Point(117, 67);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(233, 26);
            this.txtmodel.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(208, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Sản lượng trong ngày";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLabelChecking);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.cblocation);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 48);
            this.panel1.TabIndex = 22;
            // 
            // btnLabelChecking
            // 
            this.btnLabelChecking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnLabelChecking.FlatAppearance.BorderSize = 0;
            this.btnLabelChecking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLabelChecking.ForeColor = System.Drawing.Color.Black;
            this.btnLabelChecking.Location = new System.Drawing.Point(761, 13);
            this.btnLabelChecking.Name = "btnLabelChecking";
            this.btnLabelChecking.Size = new System.Drawing.Size(113, 28);
            this.btnLabelChecking.TabIndex = 24;
            this.btnLabelChecking.Text = "Kiểm tra Tem";
            this.btnLabelChecking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLabelChecking.UseVisualStyleBackColor = false;
            this.btnLabelChecking.Click += new System.EventHandler(this.btnLabelChecking_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::HANMISYSTEM.Properties.Resources.settings1;
            this.pictureBox1.Location = new System.Drawing.Point(693, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txtPlanID);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1267, 34);
            this.panel2.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPlanID
            // 
            this.txtPlanID.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtPlanID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlanID.Location = new System.Drawing.Point(856, 0);
            this.txtPlanID.Name = "txtPlanID";
            this.txtPlanID.Size = new System.Drawing.Size(100, 35);
            this.txtPlanID.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txttarget);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(956, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(144, 34);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtworkorder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1100, 0);
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
            this.panel5.Controls.Add(this.cbbMode);
            this.panel5.Controls.Add(this.txtsoluong);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtCurrentQuantity);
            this.panel5.Controls.Add(this.toggleButton1);
            this.panel5.Controls.Add(this.btnPacking_renew);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtmodel);
            this.panel5.Controls.Add(this.txtpartno);
            this.panel5.Controls.Add(this.txtboxno);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.checkBox2);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtqty);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txtplan);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 82);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(567, 622);
            this.panel5.TabIndex = 24;
            // 
            // cbbMode
            // 
            this.cbbMode.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMode.FormattingEnabled = true;
            this.cbbMode.Location = new System.Drawing.Point(418, 0);
            this.cbbMode.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMode.Name = "cbbMode";
            this.cbbMode.Size = new System.Drawing.Size(149, 21);
            this.cbbMode.TabIndex = 26;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluong.Location = new System.Drawing.Point(117, 240);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(120, 26);
            this.txtsoluong.TabIndex = 25;
            this.txtsoluong.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cur.quantity";
            // 
            // txtCurrentQuantity
            // 
            this.txtCurrentQuantity.Enabled = false;
            this.txtCurrentQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentQuantity.Location = new System.Drawing.Point(463, 177);
            this.txtCurrentQuantity.Name = "txtCurrentQuantity";
            this.txtCurrentQuantity.Size = new System.Drawing.Size(72, 26);
            this.txtCurrentQuantity.TabIndex = 23;
            this.txtCurrentQuantity.Text = "0";
            // 
            // toggleButton1
            // 
            this.toggleButton1.Enabled = false;
            this.toggleButton1.Location = new System.Drawing.Point(129, 10);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton1.Size = new System.Drawing.Size(68, 34);
            this.toggleButton1.TabIndex = 22;
            this.toggleButton1.UseVisualStyleBackColor = true;
            this.toggleButton1.CheckedChanged += new System.EventHandler(this.toggleButton1_CheckedChanged);
            // 
            // btnPacking_renew
            // 
            this.btnPacking_renew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnPacking_renew.Enabled = false;
            this.btnPacking_renew.FlatAppearance.BorderSize = 0;
            this.btnPacking_renew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacking_renew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacking_renew.ForeColor = System.Drawing.Color.Black;
            this.btnPacking_renew.Location = new System.Drawing.Point(117, 295);
            this.btnPacking_renew.Name = "btnPacking_renew";
            this.btnPacking_renew.Size = new System.Drawing.Size(85, 30);
            this.btnPacking_renew.TabIndex = 21;
            this.btnPacking_renew.Text = "Đóng gói";
            this.btnPacking_renew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacking_renew.UseVisualStyleBackColor = false;
            this.btnPacking_renew.Click += new System.EventHandler(this.btnPacking_renew_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(567, 82);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(700, 622);
            this.panel6.TabIndex = 25;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.groupBox1);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 170);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(700, 452);
            this.panel10.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel12);
            this.groupBox1.Controls.Add(this.panel11);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 452);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WO Tracker";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel16);
            this.panel12.Controls.Add(this.panel15);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(240, 19);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(457, 430);
            this.panel12.TabIndex = 4;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.dataGridView1);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(0, 32);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(457, 398);
            this.panel16.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code_col,
            this.Quantity_col,
            this.Date_col});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(457, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // Code_col
            // 
            this.Code_col.DataPropertyName = "code";
            this.Code_col.HeaderText = "WO";
            this.Code_col.MinimumWidth = 6;
            this.Code_col.Name = "Code_col";
            this.Code_col.ReadOnly = true;
            // 
            // Quantity_col
            // 
            this.Quantity_col.DataPropertyName = "quantity";
            this.Quantity_col.HeaderText = "Số lượng";
            this.Quantity_col.MinimumWidth = 6;
            this.Quantity_col.Name = "Quantity_col";
            this.Quantity_col.ReadOnly = true;
            // 
            // Date_col
            // 
            this.Date_col.DataPropertyName = "createdate";
            this.Date_col.HeaderText = "Thời gian";
            this.Date_col.MinimumWidth = 6;
            this.Date_col.Name = "Date_col";
            this.Date_col.ReadOnly = true;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.btnCheckWO);
            this.panel15.Controls.Add(this.txtTotalWO);
            this.panel15.Controls.Add(this.label12);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(457, 32);
            this.panel15.TabIndex = 0;
            // 
            // btnCheckWO
            // 
            this.btnCheckWO.Image = global::HANMISYSTEM.Properties.Resources.search;
            this.btnCheckWO.Location = new System.Drawing.Point(217, 3);
            this.btnCheckWO.Name = "btnCheckWO";
            this.btnCheckWO.Size = new System.Drawing.Size(30, 26);
            this.btnCheckWO.TabIndex = 2;
            this.btnCheckWO.UseVisualStyleBackColor = true;
            this.btnCheckWO.Click += new System.EventHandler(this.btnCheckWO_Click);
            // 
            // txtTotalWO
            // 
            this.txtTotalWO.Location = new System.Drawing.Point(73, 6);
            this.txtTotalWO.Name = "txtTotalWO";
            this.txtTotalWO.ReadOnly = true;
            this.txtTotalWO.Size = new System.Drawing.Size(138, 23);
            this.txtTotalWO.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "WO đã tạo:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.btnCreateWO);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(3, 19);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(237, 430);
            this.panel11.TabIndex = 3;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.txtWOQuantityAvailable);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 32);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(237, 64);
            this.panel14.TabIndex = 4;
            // 
            // txtWOQuantityAvailable
            // 
            this.txtWOQuantityAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWOQuantityAvailable.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWOQuantityAvailable.Location = new System.Drawing.Point(0, 0);
            this.txtWOQuantityAvailable.Name = "txtWOQuantityAvailable";
            this.txtWOQuantityAvailable.Size = new System.Drawing.Size(237, 61);
            this.txtWOQuantityAvailable.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnRefresh);
            this.panel13.Controls.Add(this.label9);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(237, 32);
            this.panel13.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Image = global::HANMISYSTEM.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(203, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(31, 23);
            this.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "Số lượng khả dụng:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCreateWO
            // 
            this.btnCreateWO.Location = new System.Drawing.Point(3, 102);
            this.btnCreateWO.Name = "btnCreateWO";
            this.btnCreateWO.Size = new System.Drawing.Size(128, 29);
            this.btnCreateWO.TabIndex = 2;
            this.btnCreateWO.Text = "Tạo WO";
            this.btnCreateWO.UseVisualStyleBackColor = true;
            this.btnCreateWO.Click += new System.EventHandler(this.btnCreateWO_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtproductionqty);
            this.panel9.Controls.Add(this.txtactualqty);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 44);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(700, 126);
            this.panel9.TabIndex = 23;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(700, 44);
            this.panel7.TabIndex = 22;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(95, 44);
            this.panel8.TabIndex = 0;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmprod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1267, 704);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.TextBox txtactualqty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtplan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtproductionqty;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ComboBox cblocation;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txttarget;
        public System.Windows.Forms.TextBox txtpartno;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.Label label11;
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
        private Module.MyButton btnPacking_renew;
        private CustomControls.ToggleButton toggleButton1;
        private Module.MyButton btnLabelChecking;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurrentQuantity;
        private System.Windows.Forms.NumericUpDown txtsoluong;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txtWOQuantityAvailable;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCreateWO;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtTotalWO;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCheckWO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_col;
        private System.Windows.Forms.PictureBox btnRefresh;
        private System.Windows.Forms.ComboBox cbbMode;
    }
}

