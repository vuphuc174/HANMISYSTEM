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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbEWarehouse = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dgvExportList = new System.Windows.Forms.DataGridView();
            this.Index_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNo_Fn_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName_FN_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_FN_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new HANMISYSTEM.Module.GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvPackageList = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtScan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDPack_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNo_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limit_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExportList)).BeginInit();
            this.panel8.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackageList)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbEWarehouse);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 80);
            this.panel1.TabIndex = 0;
            // 
            // cbbEWarehouse
            // 
            this.cbbEWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEWarehouse.FormattingEnabled = true;
            this.cbbEWarehouse.Location = new System.Drawing.Point(21, 37);
            this.cbbEWarehouse.Name = "cbbEWarehouse";
            this.cbbEWarehouse.Size = new System.Drawing.Size(281, 24);
            this.cbbEWarehouse.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(346, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(281, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1355, 582);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(638, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panel4.Size = new System.Drawing.Size(717, 582);
            this.panel4.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dgvExportList);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(20, 41);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(697, 468);
            this.panel11.TabIndex = 3;
            // 
            // dgvExportList
            // 
            this.dgvExportList.AllowUserToAddRows = false;
            this.dgvExportList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExportList.BackgroundColor = System.Drawing.Color.White;
            this.dgvExportList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExportList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExportList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index_col,
            this.PartNo_Fn_col,
            this.PartName_FN_col,
            this.Quantity_FN_col});
            this.dgvExportList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExportList.Location = new System.Drawing.Point(0, 0);
            this.dgvExportList.Name = "dgvExportList";
            this.dgvExportList.Size = new System.Drawing.Size(697, 468);
            this.dgvExportList.TabIndex = 0;
            // 
            // Index_col
            // 
            this.Index_col.HeaderText = "No.";
            this.Index_col.Name = "Index_col";
            this.Index_col.ReadOnly = true;
            // 
            // PartNo_Fn_col
            // 
            this.PartNo_Fn_col.HeaderText = "Mã hàng";
            this.PartNo_Fn_col.Name = "PartNo_Fn_col";
            this.PartNo_Fn_col.ReadOnly = true;
            // 
            // PartName_FN_col
            // 
            this.PartName_FN_col.HeaderText = "Tên mặt hàng";
            this.PartName_FN_col.Name = "PartName_FN_col";
            this.PartName_FN_col.ReadOnly = true;
            // 
            // Quantity_FN_col
            // 
            this.Quantity_FN_col.HeaderText = "Số lượng";
            this.Quantity_FN_col.Name = "Quantity_FN_col";
            this.Quantity_FN_col.ReadOnly = true;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(20, 509);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(697, 73);
            this.panel10.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.gradientPanel1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(20, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(697, 41);
            this.panel8.TabIndex = 0;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.White;
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(697, 41);
            this.gradientPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 41);
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
            this.panel3.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 582);
            this.panel3.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgvPackageList);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 83);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(638, 426);
            this.panel7.TabIndex = 4;
            // 
            // dgvPackageList
            // 
            this.dgvPackageList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            this.dgvPackageList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPackageList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPackageList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPackageList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPackageList.ColumnHeadersHeight = 35;
            this.dgvPackageList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPack_col,
            this.PartNo_col,
            this.Quantity_col,
            this.Limit_col,
            this.Remark_col});
            this.dgvPackageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPackageList.Location = new System.Drawing.Point(0, 0);
            this.dgvPackageList.Name = "dgvPackageList";
            this.dgvPackageList.Size = new System.Drawing.Size(638, 426);
            this.dgvPackageList.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 509);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(638, 73);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtScan);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(638, 83);
            this.panel5.TabIndex = 2;
            // 
            // txtScan
            // 
            this.txtScan.Location = new System.Drawing.Point(21, 44);
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(295, 23);
            this.txtScan.TabIndex = 1;
            this.txtScan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScan_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã đóng gói";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kho xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kho nhập";
            // 
            // IDPack_col
            // 
            this.IDPack_col.HeaderText = "Mã đóng gói";
            this.IDPack_col.Name = "IDPack_col";
            this.IDPack_col.ReadOnly = true;
            // 
            // PartNo_col
            // 
            this.PartNo_col.HeaderText = "Mã hàng";
            this.PartNo_col.Name = "PartNo_col";
            this.PartNo_col.ReadOnly = true;
            // 
            // Quantity_col
            // 
            this.Quantity_col.HeaderText = "SL xuất thực tế";
            this.Quantity_col.Name = "Quantity_col";
            // 
            // Limit_col
            // 
            this.Limit_col.HeaderText = "SL tối đa";
            this.Limit_col.Name = "Limit_col";
            this.Limit_col.ReadOnly = true;
            // 
            // Remark_col
            // 
            this.Remark_col.HeaderText = "Ghi chú";
            this.Remark_col.Name = "Remark_col";
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1355, 662);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panel8.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackageList)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Index_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNo_Fn_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName_FN_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_FN_col;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPack_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNo_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limit_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark_col;
    }
}