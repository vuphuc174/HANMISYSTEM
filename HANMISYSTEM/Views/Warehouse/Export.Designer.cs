namespace HANMISYSTEM.Views.Warehouse
{
    partial class Export
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbEWarehouse = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbIWarehouse = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dgvExportList = new System.Windows.Forms.DataGridView();
            this.Index_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNo_Fn_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName_FN_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_FN_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new HANMISYSTEM.Module.GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvPackageList = new System.Windows.Forms.DataGridView();
            this.PackageID_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNo_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limit_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbmessage = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRemove = new HANMISYSTEM.Module.MyButton();
            this.lbPackageCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtScan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExportList)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackageList)).BeginInit();
            this.panel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbEWarehouse);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbbIWarehouse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1331, 65);
            this.panel1.TabIndex = 0;
            // 
            // cbbEWarehouse
            // 
            this.cbbEWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEWarehouse.FormattingEnabled = true;
            this.cbbEWarehouse.Location = new System.Drawing.Point(4, 30);
            this.cbbEWarehouse.Name = "cbbEWarehouse";
            this.cbbEWarehouse.Size = new System.Drawing.Size(246, 25);
            this.cbbEWarehouse.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kho nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kho xuất";
            // 
            // cbbIWarehouse
            // 
            this.cbbIWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbIWarehouse.FormattingEnabled = true;
            this.cbbIWarehouse.Location = new System.Drawing.Point(303, 30);
            this.cbbIWarehouse.Name = "cbbIWarehouse";
            this.cbbIWarehouse.Size = new System.Drawing.Size(246, 25);
            this.cbbIWarehouse.TabIndex = 0;
            this.cbbIWarehouse.Click += new System.EventHandler(this.cbbIWarehouse_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1331, 601);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(579, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.panel4.Size = new System.Drawing.Size(752, 601);
            this.panel4.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.dgvExportList);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(18, 44);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(734, 479);
            this.panel11.TabIndex = 3;
            // 
            // dgvExportList
            // 
            this.dgvExportList.AllowUserToAddRows = false;
            this.dgvExportList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExportList.BackgroundColor = System.Drawing.Color.White;
            this.dgvExportList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExportList.ColumnHeadersHeight = 30;
            this.dgvExportList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index_col,
            this.PartNo_Fn_col,
            this.PartName_FN_col,
            this.Quantity_FN_col});
            this.dgvExportList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExportList.Location = new System.Drawing.Point(0, 0);
            this.dgvExportList.Name = "dgvExportList";
            this.dgvExportList.Size = new System.Drawing.Size(732, 477);
            this.dgvExportList.TabIndex = 0;
            // 
            // Index_col
            // 
            this.Index_col.DataPropertyName = "index";
            this.Index_col.FillWeight = 30F;
            this.Index_col.HeaderText = "No.";
            this.Index_col.Name = "Index_col";
            this.Index_col.ReadOnly = true;
            // 
            // PartNo_Fn_col
            // 
            this.PartNo_Fn_col.DataPropertyName = "PartNo";
            this.PartNo_Fn_col.HeaderText = "Mã hàng";
            this.PartNo_Fn_col.Name = "PartNo_Fn_col";
            this.PartNo_Fn_col.ReadOnly = true;
            // 
            // PartName_FN_col
            // 
            this.PartName_FN_col.DataPropertyName = "PartName";
            this.PartName_FN_col.HeaderText = "Tên mặt hàng";
            this.PartName_FN_col.Name = "PartName_FN_col";
            this.PartName_FN_col.ReadOnly = true;
            // 
            // Quantity_FN_col
            // 
            this.Quantity_FN_col.DataPropertyName = "SumQuantity";
            this.Quantity_FN_col.HeaderText = "Số lượng";
            this.Quantity_FN_col.Name = "Quantity_FN_col";
            this.Quantity_FN_col.ReadOnly = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel9);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(18, 523);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(734, 78);
            this.panel10.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnExport);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(589, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(145, 78);
            this.panel9.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Location = new System.Drawing.Point(13, 24);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 32);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Xuất hàng";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.gradientPanel1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(18, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(734, 44);
            this.panel8.TabIndex = 0;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.White;
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(734, 44);
            this.gradientPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh sách chờ xuất:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 601);
            this.panel3.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgvPackageList);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 66);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(579, 437);
            this.panel7.TabIndex = 4;
            // 
            // dgvPackageList
            // 
            this.dgvPackageList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvPackageList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPackageList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPackageList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPackageList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPackageList.ColumnHeadersHeight = 45;
            this.dgvPackageList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackageID_col,
            this.PartNo_col,
            this.Quantity_col,
            this.Limit_col,
            this.Remark_col});
            this.dgvPackageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPackageList.Location = new System.Drawing.Point(0, 0);
            this.dgvPackageList.Name = "dgvPackageList";
            this.dgvPackageList.Size = new System.Drawing.Size(579, 437);
            this.dgvPackageList.TabIndex = 0;
            this.dgvPackageList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPackageList_CellEndEdit);
            this.dgvPackageList.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvPackageList_EditingControlShowing);
            this.dgvPackageList.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvPackageList_RowStateChanged);
            // 
            // PackageID_col
            // 
            this.PackageID_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PackageID_col.HeaderText = "Mã đóng gói";
            this.PackageID_col.Name = "PackageID_col";
            this.PackageID_col.ReadOnly = true;
            this.PackageID_col.Width = 104;
            // 
            // PartNo_col
            // 
            this.PartNo_col.HeaderText = "Mã hàng";
            this.PartNo_col.Name = "PartNo_col";
            this.PartNo_col.ReadOnly = true;
            // 
            // Quantity_col
            // 
            dataGridViewCellStyle2.Format = "N0";
            this.Quantity_col.DefaultCellStyle = dataGridViewCellStyle2;
            this.Quantity_col.HeaderText = "SL xuất thực tế";
            this.Quantity_col.Name = "Quantity_col";
            // 
            // Limit_col
            // 
            dataGridViewCellStyle3.Format = "N0";
            this.Limit_col.DefaultCellStyle = dataGridViewCellStyle3;
            this.Limit_col.HeaderText = "SL tối đa";
            this.Limit_col.Name = "Limit_col";
            this.Limit_col.ReadOnly = true;
            // 
            // Remark_col
            // 
            this.Remark_col.HeaderText = "Ghi chú";
            this.Remark_col.Name = "Remark_col";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 503);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(579, 98);
            this.panel6.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbmessage);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông báo";
            // 
            // lbmessage
            // 
            this.lbmessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbmessage.FormattingEnabled = true;
            this.lbmessage.ItemHeight = 17;
            this.lbmessage.Location = new System.Drawing.Point(3, 21);
            this.lbmessage.Margin = new System.Windows.Forms.Padding(4);
            this.lbmessage.Name = "lbmessage";
            this.lbmessage.ScrollAlwaysVisible = true;
            this.lbmessage.Size = new System.Drawing.Size(573, 74);
            this.lbmessage.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnRemove);
            this.panel5.Controls.Add(this.lbPackageCount);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtScan);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(579, 66);
            this.panel5.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(500, 32);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(67, 26);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Loại bỏ";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbPackageCount
            // 
            this.lbPackageCount.AutoSize = true;
            this.lbPackageCount.Location = new System.Drawing.Point(391, 37);
            this.lbPackageCount.Name = "lbPackageCount";
            this.lbPackageCount.Size = new System.Drawing.Size(17, 19);
            this.lbPackageCount.TabIndex = 2;
            this.lbPackageCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số mã đóng gói:";
            // 
            // txtScan
            // 
            this.txtScan.Location = new System.Drawing.Point(6, 31);
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(252, 25);
            this.txtScan.TabIndex = 1;
            this.txtScan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScan_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã đóng gói";
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1331, 666);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Export";
            this.Text = "Export";
            this.Load += new System.EventHandler(this.Export_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExportList)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackageList)).EndInit();
            this.panel6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbbEWarehouse;
        private System.Windows.Forms.ComboBox cbbIWarehouse;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvPackageList;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtScan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dgvExportList;
        private Module.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbmessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageID_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNo_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limit_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark_col;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNo_Fn_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName_FN_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_FN_col;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lbPackageCount;
        private Module.MyButton btnRemove;
    }
}