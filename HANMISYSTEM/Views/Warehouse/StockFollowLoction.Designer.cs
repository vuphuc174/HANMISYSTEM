namespace HANMISYSTEM
{
    partial class StockFollowLoction
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
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnWarehouseLabel = new System.Windows.Forms.Panel();
            this.flpWarehouseLabel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new HANMISYSTEM.Module.GradientPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbWarehouseLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbwarehouse = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gradientPanel2 = new HANMISYSTEM.Module.GradientPanel();
            this.Selection_col = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IDPack_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNo_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partname_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackingDate_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnWarehouseLabel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.gradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(677, 12);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(222, 23);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selection_col,
            this.IDPack_Col,
            this.PartNo_col,
            this.Partname_col,
            this.Quantity_col,
            this.PackingDate_col});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1496, 496);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pnWarehouseLabel
            // 
            this.pnWarehouseLabel.AutoSize = true;
            this.pnWarehouseLabel.BackColor = System.Drawing.Color.White;
            this.pnWarehouseLabel.Controls.Add(this.panel5);
            this.pnWarehouseLabel.Controls.Add(this.panel4);
            this.pnWarehouseLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnWarehouseLabel.Location = new System.Drawing.Point(0, 0);
            this.pnWarehouseLabel.Margin = new System.Windows.Forms.Padding(5, 15, 5, 3);
            this.pnWarehouseLabel.MinimumSize = new System.Drawing.Size(0, 150);
            this.pnWarehouseLabel.Name = "pnWarehouseLabel";
            this.pnWarehouseLabel.Size = new System.Drawing.Size(1496, 150);
            this.pnWarehouseLabel.TabIndex = 2;
            // 
            // flpWarehouseLabel
            // 
            this.flpWarehouseLabel.AutoSize = true;
            this.flpWarehouseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpWarehouseLabel.Location = new System.Drawing.Point(0, 0);
            this.flpWarehouseLabel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.flpWarehouseLabel.Name = "flpWarehouseLabel";
            this.flpWarehouseLabel.Size = new System.Drawing.Size(1496, 113);
            this.flpWarehouseLabel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1496, 540);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1496, 496);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gradientPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1496, 44);
            this.panel2.TabIndex = 2;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.White;
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gradientPanel1.Controls.Add(this.btnSearch);
            this.gradientPanel1.Controls.Add(this.lbWarehouseLabel);
            this.gradientPanel1.Controls.Add(this.txtsearch);
            this.gradientPanel1.Controls.Add(this.label8);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1496, 44);
            this.gradientPanel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 37);
            this.label7.TabIndex = 1;
            this.label7.Text = "Warehouse";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWarehouseLabel
            // 
            this.lbWarehouseLabel.BackColor = System.Drawing.Color.Transparent;
            this.lbWarehouseLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbWarehouseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarehouseLabel.Location = new System.Drawing.Point(78, 0);
            this.lbWarehouseLabel.Name = "lbWarehouseLabel";
            this.lbWarehouseLabel.Size = new System.Drawing.Size(160, 44);
            this.lbWarehouseLabel.TabIndex = 1;
            this.lbWarehouseLabel.Text = "WH";
            this.lbWarehouseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 44);
            this.label8.TabIndex = 0;
            this.label8.Text = "Vị trí :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbwarehouse
            // 
            this.cbwarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbwarehouse.FormattingEnabled = true;
            this.cbwarehouse.Location = new System.Drawing.Point(94, 7);
            this.cbwarehouse.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbwarehouse.Name = "cbwarehouse";
            this.cbwarehouse.Size = new System.Drawing.Size(262, 24);
            this.cbwarehouse.TabIndex = 0;
            this.cbwarehouse.SelectedIndexChanged += new System.EventHandler(this.cbwarehouse_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gradientPanel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1496, 37);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.flpWarehouseLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1496, 113);
            this.panel5.TabIndex = 2;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.ColorBottom = System.Drawing.Color.White;
            this.gradientPanel2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gradientPanel2.Controls.Add(this.label7);
            this.gradientPanel2.Controls.Add(this.cbwarehouse);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(1496, 37);
            this.gradientPanel2.TabIndex = 0;
            // 
            // Selection_col
            // 
            this.Selection_col.FillWeight = 30F;
            this.Selection_col.HeaderText = "";
            this.Selection_col.Name = "Selection_col";
            // 
            // IDPack_Col
            // 
            this.IDPack_Col.DataPropertyName = "idpack";
            this.IDPack_Col.HeaderText = "Mã đóng gói";
            this.IDPack_Col.Name = "IDPack_Col";
            this.IDPack_Col.ReadOnly = true;
            // 
            // PartNo_col
            // 
            this.PartNo_col.DataPropertyName = "partno";
            this.PartNo_col.HeaderText = "Mã hàng";
            this.PartNo_col.Name = "PartNo_col";
            this.PartNo_col.ReadOnly = true;
            // 
            // Partname_col
            // 
            this.Partname_col.DataPropertyName = "partname";
            this.Partname_col.HeaderText = "Tên mặt hàng";
            this.Partname_col.Name = "Partname_col";
            this.Partname_col.ReadOnly = true;
            // 
            // Quantity_col
            // 
            this.Quantity_col.DataPropertyName = "quantity";
            this.Quantity_col.FillWeight = 50F;
            this.Quantity_col.HeaderText = "Số lượng";
            this.Quantity_col.Name = "Quantity_col";
            this.Quantity_col.ReadOnly = true;
            // 
            // PackingDate_col
            // 
            this.PackingDate_col.DataPropertyName = "packingdate";
            this.PackingDate_col.HeaderText = "Ngày đóng gói";
            this.PackingDate_col.Name = "PackingDate_col";
            this.PackingDate_col.ReadOnly = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Location = new System.Drawing.Point(907, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 26);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // StockFollowLoction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 690);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnWarehouseLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "StockFollowLoction";
            this.Text = "Tồn kho theo vị trí";
            this.Load += new System.EventHandler(this.StockFollowLoction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnWarehouseLabel.ResumeLayout(false);
            this.pnWarehouseLabel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.gradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Panel pnWarehouseLabel;
        private System.Windows.Forms.FlowLayoutPanel flpWarehouseLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Module.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbWarehouseLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbwarehouse;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private Module.GradientPanel gradientPanel2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selection_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPack_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNo_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partname_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackingDate_col;
        private System.Windows.Forms.Button btnSearch;
    }
}