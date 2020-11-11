namespace HANMISYSTEM.Views.PartialView
{
    partial class SearchProductFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkMarket = new System.Windows.Forms.CheckBox();
            this.chkColor = new System.Windows.Forms.CheckBox();
            this.chkSpecs = new System.Windows.Forms.CheckBox();
            this.chkPartName = new System.Windows.Forms.CheckBox();
            this.chkPartNo = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Market = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnselect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 81);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMarket);
            this.groupBox1.Controls.Add(this.chkColor);
            this.groupBox1.Controls.Add(this.chkSpecs);
            this.groupBox1.Controls.Add(this.chkPartName);
            this.groupBox1.Controls.Add(this.chkPartNo);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1014, 81);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // chkMarket
            // 
            this.chkMarket.AutoSize = true;
            this.chkMarket.Checked = true;
            this.chkMarket.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMarket.Location = new System.Drawing.Point(415, 23);
            this.chkMarket.Name = "chkMarket";
            this.chkMarket.Size = new System.Drawing.Size(93, 22);
            this.chkMarket.TabIndex = 1;
            this.chkMarket.Text = "Thị trường";
            this.chkMarket.UseVisualStyleBackColor = true;
            // 
            // chkColor
            // 
            this.chkColor.AutoSize = true;
            this.chkColor.Checked = true;
            this.chkColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkColor.Location = new System.Drawing.Point(316, 23);
            this.chkColor.Name = "chkColor";
            this.chkColor.Size = new System.Drawing.Size(84, 22);
            this.chkColor.TabIndex = 1;
            this.chkColor.Text = "Màu sắc";
            this.chkColor.UseVisualStyleBackColor = true;
            // 
            // chkSpecs
            // 
            this.chkSpecs.AutoSize = true;
            this.chkSpecs.Checked = true;
            this.chkSpecs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpecs.Location = new System.Drawing.Point(211, 23);
            this.chkSpecs.Name = "chkSpecs";
            this.chkSpecs.Size = new System.Drawing.Size(90, 22);
            this.chkSpecs.TabIndex = 1;
            this.chkSpecs.Text = "Thông số";
            this.chkSpecs.UseVisualStyleBackColor = true;
            // 
            // chkPartName
            // 
            this.chkPartName.AutoSize = true;
            this.chkPartName.Checked = true;
            this.chkPartName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPartName.Location = new System.Drawing.Point(109, 23);
            this.chkPartName.Name = "chkPartName";
            this.chkPartName.Size = new System.Drawing.Size(88, 22);
            this.chkPartName.TabIndex = 1;
            this.chkPartName.Text = "Tên hàng";
            this.chkPartName.UseVisualStyleBackColor = true;
            // 
            // chkPartNo
            // 
            this.chkPartNo.AutoSize = true;
            this.chkPartNo.Checked = true;
            this.chkPartNo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPartNo.Location = new System.Drawing.Point(8, 23);
            this.chkPartNo.Name = "chkPartNo";
            this.chkPartNo.Size = new System.Drawing.Size(84, 22);
            this.chkPartNo.TabIndex = 1;
            this.chkPartNo.Text = "Mã hàng";
            this.chkPartNo.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(343, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 24);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(8, 51);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(329, 24);
            this.txtSearch.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 516);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1014, 516);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.PartNo,
            this.PartName,
            this.Specs,
            this.Color,
            this.Market,
            this.btnselect});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 493);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "r";
            this.STT.FillWeight = 30F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // PartNo
            // 
            this.PartNo.DataPropertyName = "partno";
            this.PartNo.HeaderText = "Mã hàng";
            this.PartNo.Name = "PartNo";
            this.PartNo.ReadOnly = true;
            // 
            // PartName
            // 
            this.PartName.DataPropertyName = "partname";
            this.PartName.HeaderText = "Tên hàng";
            this.PartName.Name = "PartName";
            this.PartName.ReadOnly = true;
            // 
            // Specs
            // 
            this.Specs.DataPropertyName = "specification";
            this.Specs.HeaderText = "Thông số";
            this.Specs.Name = "Specs";
            this.Specs.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "color";
            this.Color.HeaderText = "Màu sắc";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // Market
            // 
            this.Market.DataPropertyName = "market";
            this.Market.HeaderText = "Thị trường";
            this.Market.Name = "Market";
            this.Market.ReadOnly = true;
            // 
            // btnselect
            // 
            this.btnselect.FillWeight = 60F;
            this.btnselect.HeaderText = "Chọn";
            this.btnselect.Name = "btnselect";
            this.btnselect.ReadOnly = true;
            this.btnselect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnselect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnselect.Text = "Chọn";
            this.btnselect.UseColumnTextForButtonValue = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 597);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1014, 63);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(898, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchProductFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 660);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SearchProductFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm mặt hàng";
            this.Load += new System.EventHandler(this.SearchProductFrm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox chkMarket;
        private System.Windows.Forms.CheckBox chkColor;
        private System.Windows.Forms.CheckBox chkSpecs;
        private System.Windows.Forms.CheckBox chkPartName;
        private System.Windows.Forms.CheckBox chkPartNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Market;
        private System.Windows.Forms.DataGridViewButtonColumn btnselect;
    }
}