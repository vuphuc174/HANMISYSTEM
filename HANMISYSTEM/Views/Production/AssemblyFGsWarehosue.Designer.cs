namespace HANMISYSTEM.Views.Production
{
    partial class AssemblyFGsWarehosue
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCreateWO = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbbLine = new System.Windows.Forms.ComboBox();
            this.txtPartno = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Select_col = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partno_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partname_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineID_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.cbbLine);
            this.panel1.Controls.Add(this.txtPartno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 79);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCreateWO);
            this.panel3.Controls.Add(this.btnModify);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(655, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 79);
            this.panel3.TabIndex = 5;
            // 
            // btnCreateWO
            // 
            this.btnCreateWO.Location = new System.Drawing.Point(167, 38);
            this.btnCreateWO.Name = "btnCreateWO";
            this.btnCreateWO.Size = new System.Drawing.Size(75, 30);
            this.btnCreateWO.TabIndex = 0;
            this.btnCreateWO.Text = "Tạo WO";
            this.btnCreateWO.UseVisualStyleBackColor = true;
            this.btnCreateWO.Click += new System.EventHandler(this.btnCreateWO_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(58, 38);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(103, 30);
            this.btnModify.TabIndex = 0;
            this.btnModify.Text = "Điều chỉnh";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chuyền Sx:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã hàng";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(383, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbbLine
            // 
            this.cbbLine.FormattingEnabled = true;
            this.cbbLine.Location = new System.Drawing.Point(244, 41);
            this.cbbLine.Name = "cbbLine";
            this.cbbLine.Size = new System.Drawing.Size(121, 25);
            this.cbbLine.TabIndex = 1;
            // 
            // txtPartno
            // 
            this.txtPartno.Location = new System.Drawing.Point(12, 41);
            this.txtPartno.Name = "txtPartno";
            this.txtPartno.Size = new System.Drawing.Size(215, 25);
            this.txtPartno.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 645);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select_col,
            this.ID_col,
            this.Partno_col,
            this.Partname_col,
            this.Quantity_col,
            this.LineID_col});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1119, 645);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
            // 
            // Select_col
            // 
            this.Select_col.FillWeight = 40F;
            this.Select_col.HeaderText = "Chọn";
            this.Select_col.Name = "Select_col";
            this.Select_col.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select_col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ID_col
            // 
            this.ID_col.DataPropertyName = "ID";
            this.ID_col.FillWeight = 40F;
            this.ID_col.HeaderText = "ID";
            this.ID_col.Name = "ID_col";
            this.ID_col.ReadOnly = true;
            // 
            // Partno_col
            // 
            this.Partno_col.DataPropertyName = "partno";
            this.Partno_col.HeaderText = "Mã hàng";
            this.Partno_col.Name = "Partno_col";
            this.Partno_col.ReadOnly = true;
            // 
            // Partname_col
            // 
            this.Partname_col.DataPropertyName = "Partname";
            this.Partname_col.HeaderText = "Tên mặt hàng";
            this.Partname_col.Name = "Partname_col";
            this.Partname_col.ReadOnly = true;
            // 
            // Quantity_col
            // 
            this.Quantity_col.DataPropertyName = "Quantity";
            this.Quantity_col.HeaderText = "Số lượng";
            this.Quantity_col.Name = "Quantity_col";
            this.Quantity_col.ReadOnly = true;
            // 
            // LineID_col
            // 
            this.LineID_col.DataPropertyName = "LineID";
            this.LineID_col.HeaderText = "LineID";
            this.LineID_col.Name = "LineID_col";
            this.LineID_col.ReadOnly = true;
            // 
            // AssemblyFGsWarehosue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 724);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AssemblyFGsWarehosue";
            this.Text = "BravoWorkOrderManagement";
            this.Load += new System.EventHandler(this.BravoWorkOrderManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPartno;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbbLine;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCreateWO;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partno_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partname_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineID_col;
    }
}