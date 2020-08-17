namespace HANMISYSTEM.Views.BOM
{
    partial class BOMDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lbpartno = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rawpartno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lbprocess = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnapply = new System.Windows.Forms.Button();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnactive = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnexcel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model :";
            // 
            // lbpartno
            // 
            this.lbpartno.AutoSize = true;
            this.lbpartno.Location = new System.Drawing.Point(63, 16);
            this.lbpartno.Name = "lbpartno";
            this.lbpartno.Size = new System.Drawing.Size(28, 13);
            this.lbpartno.TabIndex = 1;
            this.lbpartno.Text = "###";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.level,
            this.ce,
            this.rawpartno,
            this.partname,
            this.quantity,
            this.Inventory,
            this.unit});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1065, 387);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // level
            // 
            this.level.DataPropertyName = "level";
            this.level.FillWeight = 25F;
            this.level.HeaderText = "Level";
            this.level.Name = "level";
            this.level.ReadOnly = true;
            this.level.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ce
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ce.DefaultCellStyle = dataGridViewCellStyle8;
            this.ce.FillWeight = 30F;
            this.ce.HeaderText = "C";
            this.ce.Name = "ce";
            this.ce.ReadOnly = true;
            this.ce.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // rawpartno
            // 
            this.rawpartno.DataPropertyName = "rawpartno";
            this.rawpartno.HeaderText = "Mã hàng";
            this.rawpartno.Name = "rawpartno";
            this.rawpartno.ReadOnly = true;
            this.rawpartno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // partname
            // 
            this.partname.DataPropertyName = "partname";
            this.partname.HeaderText = "Tên mặt hàng";
            this.partname.Name = "partname";
            this.partname.ReadOnly = true;
            this.partname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Số lượng tiêu thụ";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Inventory
            // 
            this.Inventory.DataPropertyName = "Inventory";
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = "0";
            this.Inventory.DefaultCellStyle = dataGridViewCellStyle9;
            this.Inventory.HeaderText = "Số lượng hiện có";
            this.Inventory.Name = "Inventory";
            this.Inventory.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit";
            this.unit.HeaderText = "Đơn vị";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quy trình sản xuất :";
            // 
            // lbprocess
            // 
            this.lbprocess.AutoSize = true;
            this.lbprocess.Location = new System.Drawing.Point(360, 16);
            this.lbprocess.Name = "lbprocess";
            this.lbprocess.Size = new System.Drawing.Size(28, 13);
            this.lbprocess.TabIndex = 1;
            this.lbprocess.Text = "###";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnapply);
            this.panel1.Controls.Add(this.txtqty);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbprocess);
            this.panel1.Controls.Add(this.lbpartno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 78);
            this.panel1.TabIndex = 3;
            // 
            // btnapply
            // 
            this.btnapply.Location = new System.Drawing.Point(273, 40);
            this.btnapply.Name = "btnapply";
            this.btnapply.Size = new System.Drawing.Size(75, 23);
            this.btnapply.TabIndex = 3;
            this.btnapply.Text = "Áp dụng";
            this.btnapply.UseVisualStyleBackColor = true;
            this.btnapply.Click += new System.EventHandler(this.btnapply_Click);
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(124, 43);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(121, 20);
            this.txtqty.TabIndex = 2;
            this.txtqty.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng sản xuất";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(530, 3);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 4;
            // 
            // btnactive
            // 
            this.btnactive.Location = new System.Drawing.Point(16, 22);
            this.btnactive.Name = "btnactive";
            this.btnactive.Size = new System.Drawing.Size(75, 23);
            this.btnactive.TabIndex = 5;
            this.btnactive.Text = "Hide";
            this.btnactive.UseVisualStyleBackColor = true;
            this.btnactive.Click += new System.EventHandler(this.btnactive_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnexcel);
            this.panel2.Controls.Add(this.btnactive);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 48);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txttotal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 513);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1065, 71);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1065, 387);
            this.panel4.TabIndex = 8;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 12F;
            this.dataGridViewImageColumn1.HeaderText = "C";
            this.dataGridViewImageColumn1.Image = global::HANMISYSTEM.Properties.Resources.collapse;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 23;
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(990, 22);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(75, 23);
            this.btnexcel.TabIndex = 6;
            this.btnexcel.Text = "Excel";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // BOMDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 584);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BOMDetail";
            this.Text = "BOMDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbpartno;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbprocess;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnapply;
        public System.Windows.Forms.TextBox txtqty;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button btnactive;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.DataGridViewTextBoxColumn ce;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawpartno;
        private System.Windows.Forms.DataGridViewTextBoxColumn partname;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}