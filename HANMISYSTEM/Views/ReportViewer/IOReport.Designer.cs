namespace HANMISYSTEM.Views.ReportViewer
{
    partial class IOReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnreport = new System.Windows.Forms.Button();
            this.txtpartno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbwarehouse = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.hANMIDataSet = new HANMISYSTEM.HANMIDataSet();
            this.hANMIDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receipt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closingstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExcel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lbsearch = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hANMIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANMIDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbsearch);
            this.panel1.Controls.Add(this.btnreport);
            this.panel1.Controls.Add(this.txtpartno);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbbwarehouse);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpfrom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 605);
            this.panel1.TabIndex = 1;
            // 
            // btnreport
            // 
            this.btnreport.Location = new System.Drawing.Point(22, 538);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(151, 28);
            this.btnreport.TabIndex = 8;
            this.btnreport.Text = "Chạy báo cáo";
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // txtpartno
            // 
            this.txtpartno.Location = new System.Drawing.Point(22, 247);
            this.txtpartno.Name = "txtpartno";
            this.txtpartno.Size = new System.Drawing.Size(167, 20);
            this.txtpartno.TabIndex = 7;
            this.txtpartno.TextChanged += new System.EventHandler(this.txtpartno_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "4.Mã hàng";
            // 
            // cbbwarehouse
            // 
            this.cbbwarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbwarehouse.FormattingEnabled = true;
            this.cbbwarehouse.Location = new System.Drawing.Point(22, 181);
            this.cbbwarehouse.Name = "cbbwarehouse";
            this.cbbwarehouse.Size = new System.Drawing.Size(167, 21);
            this.cbbwarehouse.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "3.Kho hàng";
            // 
            // dtpto
            // 
            this.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpto.Location = new System.Drawing.Point(22, 118);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(167, 20);
            this.dtpto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "2.Đến ngày";
            // 
            // dtpfrom
            // 
            this.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfrom.Location = new System.Drawing.Point(22, 56);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(167, 20);
            this.dtpfrom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Từ ngày";
            // 
            // hANMIDataSet
            // 
            this.hANMIDataSet.DataSetName = "HANMIDataSet";
            this.hANMIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hANMIDataSetBindingSource
            // 
            this.hANMIDataSetBindingSource.DataSource = this.hANMIDataSet;
            this.hANMIDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partno,
            this.partname,
            this.unit,
            this.openingstock,
            this.receipt,
            this.delivery,
            this.closingstock});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(899, 571);
            this.dataGridView1.TabIndex = 2;
            // 
            // partno
            // 
            this.partno.DataPropertyName = "partno";
            this.partno.HeaderText = "Model Name";
            this.partno.Name = "partno";
            this.partno.ReadOnly = true;
            // 
            // partname
            // 
            this.partname.DataPropertyName = "partname";
            this.partname.HeaderText = "Model Name";
            this.partname.Name = "partname";
            this.partname.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "nameunit";
            this.unit.HeaderText = "Unit";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // openingstock
            // 
            this.openingstock.DataPropertyName = "openingstock";
            dataGridViewCellStyle13.Format = "N0";
            this.openingstock.DefaultCellStyle = dataGridViewCellStyle13;
            this.openingstock.HeaderText = "Opening Stock";
            this.openingstock.Name = "openingstock";
            this.openingstock.ReadOnly = true;
            // 
            // receipt
            // 
            this.receipt.DataPropertyName = "receipt";
            dataGridViewCellStyle14.Format = "N0";
            this.receipt.DefaultCellStyle = dataGridViewCellStyle14;
            this.receipt.HeaderText = "Receipt";
            this.receipt.Name = "receipt";
            this.receipt.ReadOnly = true;
            // 
            // delivery
            // 
            this.delivery.DataPropertyName = "delivery";
            dataGridViewCellStyle15.Format = "N0";
            this.delivery.DefaultCellStyle = dataGridViewCellStyle15;
            this.delivery.HeaderText = "Delivery";
            this.delivery.Name = "delivery";
            this.delivery.ReadOnly = true;
            // 
            // closingstock
            // 
            this.closingstock.DataPropertyName = "closingstock";
            dataGridViewCellStyle16.Format = "N0";
            this.closingstock.DefaultCellStyle = dataGridViewCellStyle16;
            this.closingstock.HeaderText = "Closing Stock";
            this.closingstock.Name = "closingstock";
            this.closingstock.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtsearch);
            this.panel2.Controls.Add(this.btnExcel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 34);
            this.panel2.TabIndex = 3;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(6, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(82, 28);
            this.btnExcel.TabIndex = 0;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(899, 571);
            this.panel3.TabIndex = 4;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(668, 8);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(192, 20);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // lbsearch
            // 
            this.lbsearch.FormattingEnabled = true;
            this.lbsearch.Location = new System.Drawing.Point(22, 269);
            this.lbsearch.Name = "lbsearch";
            this.lbsearch.Size = new System.Drawing.Size(167, 225);
            this.lbsearch.TabIndex = 9;
            this.lbsearch.Visible = false;
            this.lbsearch.Click += new System.EventHandler(this.lbsearch_Click);
            // 
            // IOReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 605);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IOReport";
            this.Text = "IOReport";
            this.Load += new System.EventHandler(this.IOReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hANMIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANMIDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.TextBox txtpartno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbwarehouse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpfrom;
        private System.Windows.Forms.Label label1;
        private HANMIDataSet hANMIDataSet;
        private System.Windows.Forms.BindingSource hANMIDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partno;
        private System.Windows.Forms.DataGridViewTextBoxColumn partname;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn receipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn delivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn closingstock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ListBox lbsearch;
    }
}