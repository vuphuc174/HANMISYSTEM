namespace HANMISYSTEM.Views
{
    partial class DeliveryResultDetail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbProductionKind = new System.Windows.Forms.ComboBox();
            this.btnfilter = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Partno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductionResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductionRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbProductionKind);
            this.panel1.Controls.Add(this.btnfilter);
            this.panel1.Controls.Add(this.btnexcel);
            this.panel1.Controls.Add(this.dtpto);
            this.panel1.Controls.Add(this.dtpfrom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.cbCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 106);
            this.panel1.TabIndex = 0;
            // 
            // cbProductionKind
            // 
            this.cbProductionKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductionKind.FormattingEnabled = true;
            this.cbProductionKind.Location = new System.Drawing.Point(567, 34);
            this.cbProductionKind.Name = "cbProductionKind";
            this.cbProductionKind.Size = new System.Drawing.Size(121, 21);
            this.cbProductionKind.TabIndex = 6;
            this.cbProductionKind.SelectedIndexChanged += new System.EventHandler(this.cbProductionKind_SelectedIndexChanged);
            // 
            // btnfilter
            // 
            this.btnfilter.Location = new System.Drawing.Point(723, 68);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(75, 23);
            this.btnfilter.TabIndex = 5;
            this.btnfilter.Text = "Lọc";
            this.btnfilter.UseVisualStyleBackColor = true;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(871, 71);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(75, 23);
            this.btnexcel.TabIndex = 4;
            this.btnexcel.Text = "EXCEL";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // dtpto
            // 
            this.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpto.Location = new System.Drawing.Point(567, 71);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(121, 20);
            this.dtpto.TabIndex = 3;
            // 
            // dtpfrom
            // 
            this.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfrom.Location = new System.Drawing.Point(363, 71);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(121, 20);
            this.dtpfrom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Từ ngày";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tình trạng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm kiếm";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(88, 71);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(165, 20);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Tất cả",
            "Đã hoàn thành",
            "Chưa hoàn thành"});
            this.cbStatus.Location = new System.Drawing.Point(363, 34);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 0;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // cbCustomer
            // 
            this.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(88, 31);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(165, 21);
            this.cbCustomer.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Partno,
            this.PartName,
            this.Model,
            this.Quantity,
            this.Delivered,
            this.DeliveryRate,
            this.ProductionResult,
            this.ProductionRate});
            this.dataGridView1.Location = new System.Drawing.Point(12, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(934, 482);
            this.dataGridView1.TabIndex = 1;
            // 
            // Partno
            // 
            this.Partno.DataPropertyName = "partno";
            this.Partno.HeaderText = "Partno";
            this.Partno.Name = "Partno";
            this.Partno.ReadOnly = true;
            // 
            // PartName
            // 
            this.PartName.DataPropertyName = "partname";
            this.PartName.HeaderText = "PartName";
            this.PartName.Name = "PartName";
            this.PartName.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Delivered
            // 
            this.Delivered.DataPropertyName = "delivered";
            this.Delivered.HeaderText = "Delivered";
            this.Delivered.Name = "Delivered";
            this.Delivered.ReadOnly = true;
            // 
            // DeliveryRate
            // 
            this.DeliveryRate.DataPropertyName = "deliveryrate";
            this.DeliveryRate.HeaderText = "Delivery Rate";
            this.DeliveryRate.Name = "DeliveryRate";
            this.DeliveryRate.ReadOnly = true;
            // 
            // ProductionResult
            // 
            this.ProductionResult.DataPropertyName = "productionresult";
            this.ProductionResult.HeaderText = "ProductionResult";
            this.ProductionResult.Name = "ProductionResult";
            this.ProductionResult.ReadOnly = true;
            // 
            // ProductionRate
            // 
            this.ProductionRate.DataPropertyName = "productionrate";
            this.ProductionRate.HeaderText = "Production Rate";
            this.ProductionRate.Name = "ProductionRate";
            this.ProductionRate.ReadOnly = true;
            // 
            // DeliveryResultDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 649);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeliveryResultDetail";
            this.Text = "DeliveryResultDetail";
            this.Load += new System.EventHandler(this.DeliveryResultDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.DateTimePicker dtpto;
        private System.Windows.Forms.DateTimePicker dtpfrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partno;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductionResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductionRate;
        private System.Windows.Forms.ComboBox cbProductionKind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}