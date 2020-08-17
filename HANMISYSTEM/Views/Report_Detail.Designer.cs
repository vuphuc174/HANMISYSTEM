namespace HANMISYSTEM
{
    partial class Report_Detail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbpartno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbmonth = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbwarehouse = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexcel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastmonthinventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inother = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inproduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outother = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outproduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaloutproduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lossrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentinventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report Detail";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.lastmonthinventory,
            this.inother,
            this.inproduction,
            this.outother,
            this.outproduction,
            this.totaloutproduction,
            this.ng,
            this.ngrate,
            this.loss,
            this.lossrate,
            this.currentinventory});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.NullValue = "0";
            this.dataGridView1.Size = new System.Drawing.Size(914, 416);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Partno:";
            // 
            // lbpartno
            // 
            this.lbpartno.AutoSize = true;
            this.lbpartno.Location = new System.Drawing.Point(285, 66);
            this.lbpartno.Name = "lbpartno";
            this.lbpartno.Size = new System.Drawing.Size(27, 13);
            this.lbpartno.TabIndex = 3;
            this.lbpartno.Text = "P/N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Month";
            // 
            // lbmonth
            // 
            this.lbmonth.AutoSize = true;
            this.lbmonth.Location = new System.Drawing.Point(429, 66);
            this.lbmonth.Name = "lbmonth";
            this.lbmonth.Size = new System.Drawing.Size(19, 13);
            this.lbmonth.TabIndex = 4;
            this.lbmonth.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Warehouse :";
            // 
            // lbwarehouse
            // 
            this.lbwarehouse.AutoSize = true;
            this.lbwarehouse.Location = new System.Drawing.Point(103, 66);
            this.lbwarehouse.Name = "lbwarehouse";
            this.lbwarehouse.Size = new System.Drawing.Size(26, 13);
            this.lbwarehouse.TabIndex = 6;
            this.lbwarehouse.Text = "WH";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnexcel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbwarehouse);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbmonth);
            this.panel1.Controls.Add(this.lbpartno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 90);
            this.panel1.TabIndex = 7;
            // 
            // btnexcel
            // 
            this.btnexcel.Enabled = false;
            this.btnexcel.Location = new System.Drawing.Point(827, 57);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(75, 23);
            this.btnexcel.TabIndex = 7;
            this.btnexcel.Text = "EXCEL";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 416);
            this.panel2.TabIndex = 8;
            // 
            // date
            // 
            dataGridViewCellStyle1.NullValue = "0";
            this.date.DefaultCellStyle = dataGridViewCellStyle1;
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // lastmonthinventory
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.lastmonthinventory.DefaultCellStyle = dataGridViewCellStyle2;
            this.lastmonthinventory.HeaderText = "Last Month Inventory";
            this.lastmonthinventory.Name = "lastmonthinventory";
            this.lastmonthinventory.ReadOnly = true;
            // 
            // inother
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            this.inother.DefaultCellStyle = dataGridViewCellStyle3;
            this.inother.HeaderText = "In Other";
            this.inother.Name = "inother";
            this.inother.ReadOnly = true;
            // 
            // inproduction
            // 
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.inproduction.DefaultCellStyle = dataGridViewCellStyle4;
            this.inproduction.HeaderText = "In Production";
            this.inproduction.Name = "inproduction";
            this.inproduction.ReadOnly = true;
            // 
            // outother
            // 
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "0";
            this.outother.DefaultCellStyle = dataGridViewCellStyle5;
            this.outother.HeaderText = "Out Other";
            this.outother.Name = "outother";
            this.outother.ReadOnly = true;
            // 
            // outproduction
            // 
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = "0";
            this.outproduction.DefaultCellStyle = dataGridViewCellStyle6;
            this.outproduction.HeaderText = "Out Production";
            this.outproduction.Name = "outproduction";
            this.outproduction.ReadOnly = true;
            // 
            // totaloutproduction
            // 
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = "0";
            this.totaloutproduction.DefaultCellStyle = dataGridViewCellStyle7;
            this.totaloutproduction.HeaderText = "Total Out Production";
            this.totaloutproduction.Name = "totaloutproduction";
            this.totaloutproduction.ReadOnly = true;
            // 
            // ng
            // 
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = "0";
            this.ng.DefaultCellStyle = dataGridViewCellStyle8;
            this.ng.HeaderText = "NG";
            this.ng.Name = "ng";
            this.ng.ReadOnly = true;
            // 
            // ngrate
            // 
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = "0";
            this.ngrate.DefaultCellStyle = dataGridViewCellStyle9;
            this.ngrate.HeaderText = "NG Rate";
            this.ngrate.Name = "ngrate";
            this.ngrate.ReadOnly = true;
            // 
            // loss
            // 
            dataGridViewCellStyle10.NullValue = "0";
            this.loss.DefaultCellStyle = dataGridViewCellStyle10;
            this.loss.HeaderText = "LOSS";
            this.loss.Name = "loss";
            this.loss.ReadOnly = true;
            // 
            // lossrate
            // 
            dataGridViewCellStyle11.NullValue = "0";
            this.lossrate.DefaultCellStyle = dataGridViewCellStyle11;
            this.lossrate.HeaderText = "Loss Rate";
            this.lossrate.Name = "lossrate";
            this.lossrate.ReadOnly = true;
            // 
            // currentinventory
            // 
            dataGridViewCellStyle12.Format = "N0";
            dataGridViewCellStyle12.NullValue = "0";
            this.currentinventory.DefaultCellStyle = dataGridViewCellStyle12;
            this.currentinventory.HeaderText = "Current Inventory";
            this.currentinventory.Name = "currentinventory";
            this.currentinventory.ReadOnly = true;
            // 
            // Report_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 506);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Report_Detail";
            this.Text = "Report_Detail";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbpartno;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbmonth;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbwarehouse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastmonthinventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn inother;
        private System.Windows.Forms.DataGridViewTextBoxColumn inproduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn outother;
        private System.Windows.Forms.DataGridViewTextBoxColumn outproduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaloutproduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ng;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn loss;
        private System.Windows.Forms.DataGridViewTextBoxColumn lossrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentinventory;

    }
}