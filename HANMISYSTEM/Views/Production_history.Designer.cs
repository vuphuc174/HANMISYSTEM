namespace HANMISYSTEM
{
    partial class Production_history
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Warehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productiontime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stoptime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnexcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.cbwarehouse = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cblocation = new System.Windows.Forms.ComboBox();
            this.btndata = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Warehouse,
            this.idlocation,
            this.Partno,
            this.Partname,
            this.Productiontime,
            this.Stoptime,
            this.Remark,
            this.Qty});
            this.dataGridView1.Location = new System.Drawing.Point(0, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(960, 568);
            this.dataGridView1.TabIndex = 0;
            // 
            // Warehouse
            // 
            this.Warehouse.DataPropertyName = "namewarehouse";
            this.Warehouse.HeaderText = "Warehouse";
            this.Warehouse.Name = "Warehouse";
            this.Warehouse.ReadOnly = true;
            // 
            // idlocation
            // 
            this.idlocation.DataPropertyName = "idlocation";
            this.idlocation.HeaderText = "Location";
            this.idlocation.Name = "idlocation";
            this.idlocation.ReadOnly = true;
            // 
            // Partno
            // 
            this.Partno.DataPropertyName = "partno";
            this.Partno.HeaderText = "PartNo";
            this.Partno.Name = "Partno";
            this.Partno.ReadOnly = true;
            // 
            // Partname
            // 
            this.Partname.DataPropertyName = "partname";
            this.Partname.HeaderText = "Partname";
            this.Partname.Name = "Partname";
            this.Partname.ReadOnly = true;
            // 
            // Productiontime
            // 
            this.Productiontime.DataPropertyName = "productiontime";
            this.Productiontime.HeaderText = "Production Time";
            this.Productiontime.Name = "Productiontime";
            this.Productiontime.ReadOnly = true;
            // 
            // Stoptime
            // 
            this.Stoptime.DataPropertyName = "stoptime";
            this.Stoptime.HeaderText = "Stop Time";
            this.Stoptime.Name = "Stoptime";
            this.Stoptime.ReadOnly = true;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "remark";
            this.Remark.HeaderText = "Remark";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "qty";
            this.Qty.HeaderText = "Quantity";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(873, 50);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(75, 23);
            this.btnexcel.TabIndex = 1;
            this.btnexcel.Text = "Excel Tổng";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(79, 53);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(163, 20);
            this.txtsearch.TabIndex = 3;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(302, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(507, 53);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Begin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "End";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(652, 51);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Warehouse";
            // 
            // cbwarehouse
            // 
            this.cbwarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbwarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbwarehouse.FormattingEnabled = true;
            this.cbwarehouse.Location = new System.Drawing.Point(79, 26);
            this.cbwarehouse.Name = "cbwarehouse";
            this.cbwarehouse.Size = new System.Drawing.Size(163, 21);
            this.cbwarehouse.TabIndex = 7;
            this.cbwarehouse.SelectedIndexChanged += new System.EventHandler(this.cbwarehouse_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cblocation);
            this.panel1.Controls.Add(this.btndata);
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.btnexcel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbwarehouse);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 97);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cblocation
            // 
            this.cblocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cblocation.FormattingEnabled = true;
            this.cblocation.Location = new System.Drawing.Point(302, 26);
            this.cblocation.Name = "cblocation";
            this.cblocation.Size = new System.Drawing.Size(121, 21);
            this.cblocation.TabIndex = 9;
            this.cblocation.SelectedIndexChanged += new System.EventHandler(this.cblocation_SelectedIndexChanged);
            // 
            // btndata
            // 
            this.btndata.Location = new System.Drawing.Point(792, 50);
            this.btndata.Name = "btndata";
            this.btndata.Size = new System.Drawing.Size(75, 23);
            this.btndata.TabIndex = 8;
            this.btndata.Text = "Excel";
            this.btndata.UseVisualStyleBackColor = true;
            this.btndata.Click += new System.EventHandler(this.btndata_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Line";
            // 
            // Production_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(960, 766);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Production_history";
            this.Text = "Production_history";
            this.Load += new System.EventHandler(this.Production_history_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Warehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productiontime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stoptime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbwarehouse;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btndata;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.ComboBox cblocation;
        private System.Windows.Forms.Label label5;
    }
}