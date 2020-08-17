namespace HANMISYSTEM
{
    partial class ioform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtidpack = new System.Windows.Forms.TextBox();
            this.cbwarehouse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnexcel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cbfilter = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.btnfirst = new System.Windows.Forms.Button();
            this.txtpagenumber = new System.Windows.Forms.TextBox();
            this.btnpre = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnend = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idinvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outwarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inwarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.STT,
            this.idinvoice,
            this.idpack,
            this.partno,
            this.qty,
            this.outwarehouse,
            this.inwarehouse,
            this.dateio,
            this.carnumber});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(24, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(970, 461);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtidpack
            // 
            this.txtidpack.Location = new System.Drawing.Point(390, 72);
            this.txtidpack.Name = "txtidpack";
            this.txtidpack.Size = new System.Drawing.Size(154, 20);
            this.txtidpack.TabIndex = 1;
            this.txtidpack.TextChanged += new System.EventHandler(this.txtidpack_TextChanged);
            // 
            // cbwarehouse
            // 
            this.cbwarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbwarehouse.FormattingEnabled = true;
            this.cbwarehouse.Location = new System.Drawing.Point(139, 72);
            this.cbwarehouse.Name = "cbwarehouse";
            this.cbwarehouse.Size = new System.Drawing.Size(121, 21);
            this.cbwarehouse.TabIndex = 2;
            this.cbwarehouse.SelectedIndexChanged += new System.EventHandler(this.cbwarehouse_SelectedIndexChanged);
            this.cbwarehouse.Click += new System.EventHandler(this.cbwarehouse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Warehouse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search";
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(754, 72);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(75, 23);
            this.btnexcel.TabIndex = 5;
            this.btnexcel.Text = "Excel tổng";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // cbfilter
            // 
            this.cbfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfilter.Enabled = false;
            this.cbfilter.FormattingEnabled = true;
            this.cbfilter.Items.AddRange(new object[] {
            "ALL",
            "IN",
            "OUT"});
            this.cbfilter.Location = new System.Drawing.Point(275, 72);
            this.cbfilter.Name = "cbfilter";
            this.cbfilter.Size = new System.Drawing.Size(45, 21);
            this.cbfilter.TabIndex = 6;
            this.cbfilter.SelectedIndexChanged += new System.EventHandler(this.cbfilter_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(845, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(10, 16);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(33, 23);
            this.btnfirst.TabIndex = 8;
            this.btnfirst.Text = "|<";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // txtpagenumber
            // 
            this.txtpagenumber.Location = new System.Drawing.Point(82, 18);
            this.txtpagenumber.Name = "txtpagenumber";
            this.txtpagenumber.Size = new System.Drawing.Size(36, 20);
            this.txtpagenumber.TabIndex = 9;
            this.txtpagenumber.Text = "1";
            this.txtpagenumber.TextChanged += new System.EventHandler(this.txtpagenumber_TextChanged);
            this.txtpagenumber.Validated += new System.EventHandler(this.txtpagenumber_Validated);
            // 
            // btnpre
            // 
            this.btnpre.Location = new System.Drawing.Point(45, 16);
            this.btnpre.Name = "btnpre";
            this.btnpre.Size = new System.Drawing.Size(33, 23);
            this.btnpre.TabIndex = 8;
            this.btnpre.Text = "<";
            this.btnpre.UseVisualStyleBackColor = true;
            this.btnpre.Click += new System.EventHandler(this.btnpre_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(121, 16);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(33, 23);
            this.btnnext.TabIndex = 8;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnend
            // 
            this.btnend.Location = new System.Drawing.Point(156, 16);
            this.btnend.Name = "btnend";
            this.btnend.Size = new System.Drawing.Size(33, 23);
            this.btnend.TabIndex = 8;
            this.btnend.Text = ">|";
            this.btnend.UseVisualStyleBackColor = true;
            this.btnend.Click += new System.EventHandler(this.btnend_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnend);
            this.panel1.Controls.Add(this.txtpagenumber);
            this.panel1.Controls.Add(this.btnfirst);
            this.panel1.Controls.Add(this.btnpre);
            this.panel1.Controls.Add(this.btnnext);
            this.panel1.Location = new System.Drawing.Point(30, 566);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 50);
            this.panel1.TabIndex = 10;
            this.panel1.Visible = false;
            // 
            // select
            // 
            this.select.FillWeight = 50F;
            this.select.HeaderText = "Select";
            this.select.Name = "select";
            // 
            // STT
            // 
            this.STT.DataPropertyName = "r";
            this.STT.FillWeight = 40F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // idinvoice
            // 
            this.idinvoice.DataPropertyName = "idslipout";
            this.idinvoice.HeaderText = "Invoice";
            this.idinvoice.Name = "idinvoice";
            // 
            // idpack
            // 
            this.idpack.DataPropertyName = "idpack";
            this.idpack.HeaderText = "Box .No";
            this.idpack.Name = "idpack";
            // 
            // partno
            // 
            this.partno.DataPropertyName = "partno";
            this.partno.HeaderText = "Part No";
            this.partno.Name = "partno";
            // 
            // qty
            // 
            this.qty.DataPropertyName = "quantity";
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            // 
            // outwarehouse
            // 
            this.outwarehouse.DataPropertyName = "fromwarehouse";
            this.outwarehouse.HeaderText = "From";
            this.outwarehouse.Name = "outwarehouse";
            // 
            // inwarehouse
            // 
            this.inwarehouse.DataPropertyName = "towarehouse";
            this.inwarehouse.HeaderText = "TO";
            this.inwarehouse.Name = "inwarehouse";
            // 
            // dateio
            // 
            this.dateio.DataPropertyName = "dateout";
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.dateio.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateio.HeaderText = "Date";
            this.dateio.Name = "dateio";
            // 
            // carnumber
            // 
            this.carnumber.DataPropertyName = "carnumber";
            this.carnumber.HeaderText = "Car number";
            this.carnumber.Name = "carnumber";
            // 
            // ioform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbfilter);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbwarehouse);
            this.Controls.Add(this.txtidpack);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ioform";
            this.Text = "Receive/Release Management";
            this.Load += new System.EventHandler(this.ioform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox txtidpack;
        public System.Windows.Forms.ComboBox cbwarehouse;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnexcel;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.ComboBox cbfilter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.TextBox txtpagenumber;
        private System.Windows.Forms.Button btnpre;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpack;
        private System.Windows.Forms.DataGridViewTextBoxColumn partno;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn outwarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn inwarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateio;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnumber;
    }
}