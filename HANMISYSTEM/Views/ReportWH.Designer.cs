namespace HANMISYSTEM
{
    partial class ReportWH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastmonthinventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inother = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inproduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outother = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Outproduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaloutproduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lossrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentinventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbwarehouse = new System.Windows.Forms.ComboBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnpre = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnend = new System.Windows.Forms.Button();
            this.txtpagenumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexcel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Partno,
            this.lastmonthinventory,
            this.inother,
            this.Inproduction,
            this.outother,
            this.Outproduction,
            this.totaloutproduction,
            this.ng,
            this.ngrate,
            this.lost,
            this.lossrate,
            this.currentinventory});
            this.dataGridView1.Location = new System.Drawing.Point(15, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.Size = new System.Drawing.Size(935, 479);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "r";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // Partno
            // 
            this.Partno.DataPropertyName = "partno";
            this.Partno.HeaderText = "Partno";
            this.Partno.Name = "Partno";
            this.Partno.ReadOnly = true;
            // 
            // lastmonthinventory
            // 
            this.lastmonthinventory.DataPropertyName = "stocklastmonth";
            dataGridViewCellStyle15.Format = "N0";
            dataGridViewCellStyle15.NullValue = "0";
            this.lastmonthinventory.DefaultCellStyle = dataGridViewCellStyle15;
            this.lastmonthinventory.HeaderText = "Last month Inventory";
            this.lastmonthinventory.Name = "lastmonthinventory";
            this.lastmonthinventory.ReadOnly = true;
            // 
            // inother
            // 
            this.inother.DataPropertyName = "inother";
            dataGridViewCellStyle16.Format = "N0";
            dataGridViewCellStyle16.NullValue = "0";
            this.inother.DefaultCellStyle = dataGridViewCellStyle16;
            this.inother.HeaderText = "In Other";
            this.inother.Name = "inother";
            this.inother.ReadOnly = true;
            // 
            // Inproduction
            // 
            this.Inproduction.DataPropertyName = "inproduction";
            dataGridViewCellStyle17.Format = "N0";
            dataGridViewCellStyle17.NullValue = "0";
            this.Inproduction.DefaultCellStyle = dataGridViewCellStyle17;
            this.Inproduction.HeaderText = "In production";
            this.Inproduction.Name = "Inproduction";
            this.Inproduction.ReadOnly = true;
            // 
            // outother
            // 
            this.outother.DataPropertyName = "outother";
            dataGridViewCellStyle18.Format = "N0";
            dataGridViewCellStyle18.NullValue = "0";
            this.outother.DefaultCellStyle = dataGridViewCellStyle18;
            this.outother.HeaderText = "Out other";
            this.outother.Name = "outother";
            this.outother.ReadOnly = true;
            // 
            // Outproduction
            // 
            this.Outproduction.DataPropertyName = "outproduction";
            dataGridViewCellStyle19.Format = "N0";
            dataGridViewCellStyle19.NullValue = "0";
            this.Outproduction.DefaultCellStyle = dataGridViewCellStyle19;
            this.Outproduction.HeaderText = "Out production(Follow bom)";
            this.Outproduction.Name = "Outproduction";
            this.Outproduction.ReadOnly = true;
            // 
            // totaloutproduction
            // 
            dataGridViewCellStyle20.Format = "N0";
            dataGridViewCellStyle20.NullValue = "0";
            this.totaloutproduction.DefaultCellStyle = dataGridViewCellStyle20;
            this.totaloutproduction.HeaderText = "Total Out Production";
            this.totaloutproduction.Name = "totaloutproduction";
            this.totaloutproduction.ReadOnly = true;
            // 
            // ng
            // 
            this.ng.DataPropertyName = "ng";
            this.ng.HeaderText = "NG";
            this.ng.Name = "ng";
            this.ng.ReadOnly = true;
            // 
            // ngrate
            // 
            this.ngrate.DataPropertyName = "rate";
            this.ngrate.HeaderText = "NG Rate";
            this.ngrate.Name = "ngrate";
            this.ngrate.ReadOnly = true;
            // 
            // lost
            // 
            this.lost.DataPropertyName = "lost";
            this.lost.HeaderText = "Lost";
            this.lost.Name = "lost";
            this.lost.ReadOnly = true;
            // 
            // lossrate
            // 
            this.lossrate.HeaderText = "LOSS RATE";
            this.lossrate.Name = "lossrate";
            this.lossrate.ReadOnly = true;
            // 
            // currentinventory
            // 
            this.currentinventory.DataPropertyName = "inventory";
            dataGridViewCellStyle21.Format = "N0";
            dataGridViewCellStyle21.NullValue = "0";
            this.currentinventory.DefaultCellStyle = dataGridViewCellStyle21;
            this.currentinventory.HeaderText = "Current Inventory";
            this.currentinventory.Name = "currentinventory";
            this.currentinventory.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Warehouse";
            // 
            // cbwarehouse
            // 
            this.cbwarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbwarehouse.FormattingEnabled = true;
            this.cbwarehouse.Location = new System.Drawing.Point(90, 37);
            this.cbwarehouse.Name = "cbwarehouse";
            this.cbwarehouse.Size = new System.Drawing.Size(121, 21);
            this.cbwarehouse.TabIndex = 3;
            this.cbwarehouse.SelectedIndexChanged += new System.EventHandler(this.cbwarehouse_SelectedIndexChanged);
            this.cbwarehouse.Click += new System.EventHandler(this.cbwarehouse_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(318, 35);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(211, 20);
            this.txtsearch.TabIndex = 4;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            this.txtsearch.Validated += new System.EventHandler(this.txtsearch_Validated);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(535, 33);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(9, 13);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(25, 20);
            this.btnfirst.TabIndex = 6;
            this.btnfirst.Text = "|<";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnpre
            // 
            this.btnpre.Location = new System.Drawing.Point(35, 13);
            this.btnpre.Name = "btnpre";
            this.btnpre.Size = new System.Drawing.Size(22, 20);
            this.btnpre.TabIndex = 6;
            this.btnpre.Text = "<";
            this.btnpre.UseVisualStyleBackColor = true;
            this.btnpre.Click += new System.EventHandler(this.btnpre_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(95, 13);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(24, 20);
            this.btnnext.TabIndex = 6;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnend
            // 
            this.btnend.Location = new System.Drawing.Point(119, 13);
            this.btnend.Name = "btnend";
            this.btnend.Size = new System.Drawing.Size(28, 20);
            this.btnend.TabIndex = 6;
            this.btnend.Text = ">|";
            this.btnend.UseVisualStyleBackColor = true;
            this.btnend.Click += new System.EventHandler(this.btnend_Click);
            // 
            // txtpagenumber
            // 
            this.txtpagenumber.Location = new System.Drawing.Point(63, 13);
            this.txtpagenumber.Name = "txtpagenumber";
            this.txtpagenumber.Size = new System.Drawing.Size(25, 20);
            this.txtpagenumber.TabIndex = 7;
            this.txtpagenumber.Text = "1";
            this.txtpagenumber.TextChanged += new System.EventHandler(this.txtpagenumber_TextChanged);
            this.txtpagenumber.Validated += new System.EventHandler(this.txtpagenumber_Validated);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnend);
            this.panel1.Controls.Add(this.txtpagenumber);
            this.panel1.Controls.Add(this.btnfirst);
            this.panel1.Controls.Add(this.btnpre);
            this.panel1.Controls.Add(this.btnnext);
            this.panel1.Location = new System.Drawing.Point(12, 546);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 42);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(858, 35);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(75, 23);
            this.btnexcel.TabIndex = 9;
            this.btnexcel.Text = "EXCEL";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // ReportWH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 612);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.cbwarehouse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportWH";
            this.Text = "ReportWH";
            this.Load += new System.EventHandler(this.ReportWH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbwarehouse;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnpre;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnend;
        private System.Windows.Forms.TextBox txtpagenumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partno;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastmonthinventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn inother;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inproduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn outother;
        private System.Windows.Forms.DataGridViewTextBoxColumn Outproduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaloutproduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ng;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn lost;
        private System.Windows.Forms.DataGridViewTextBoxColumn lossrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentinventory;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}