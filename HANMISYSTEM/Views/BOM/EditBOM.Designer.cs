namespace HANMISYSTEM.Views.BOM
{
    partial class EditBOM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBOM));
            this.label1 = new System.Windows.Forms.Label();
            this.txtpartno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbpartname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbprocess = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PartNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnundo = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtaddpartno = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.lbsearch = new System.Windows.Forms.ListBox();
            this.lbaddpartname = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mặt hàng";
            // 
            // txtpartno
            // 
            this.txtpartno.Location = new System.Drawing.Point(97, 11);
            this.txtpartno.Name = "txtpartno";
            this.txtpartno.ReadOnly = true;
            this.txtpartno.Size = new System.Drawing.Size(171, 20);
            this.txtpartno.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên mặt hàng :";
            // 
            // lbpartname
            // 
            this.lbpartname.AutoSize = true;
            this.lbpartname.Location = new System.Drawing.Point(94, 47);
            this.lbpartname.Name = "lbpartname";
            this.lbpartname.Size = new System.Drawing.Size(39, 13);
            this.lbpartname.TabIndex = 0;
            this.lbpartname.Text = "pname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quy trình :";
            // 
            // lbprocess
            // 
            this.lbprocess.AutoSize = true;
            this.lbprocess.Location = new System.Drawing.Point(387, 14);
            this.lbprocess.Name = "lbprocess";
            this.lbprocess.Size = new System.Drawing.Size(44, 13);
            this.lbprocess.TabIndex = 0;
            this.lbprocess.Text = "process";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.PartNo,
            this.PartName,
            this.Unit,
            this.Quantity,
            this.Process});
            this.dataGridView1.Location = new System.Drawing.Point(16, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(901, 291);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValidated);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // Select
            // 
            this.Select.FillWeight = 30F;
            this.Select.HeaderText = "S";
            this.Select.Name = "Select";
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PartNo
            // 
            this.PartNo.DataPropertyName = "rawpartno";
            this.PartNo.HeaderText = "Mã mặt hàng";
            this.PartNo.Name = "PartNo";
            this.PartNo.ReadOnly = true;
            // 
            // PartName
            // 
            this.PartName.DataPropertyName = "partname";
            this.PartName.HeaderText = "Tên mặt hàng";
            this.PartName.Name = "PartName";
            this.PartName.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "unit";
            this.Unit.HeaderText = "Đơn vị";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "quantity";
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            // 
            // Process
            // 
            this.Process.DataPropertyName = "process";
            this.Process.HeaderText = "Quy trình";
            this.Process.Name = "Process";
            this.Process.ReadOnly = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(13, 450);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Lưu lại";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnundo
            // 
            this.btnundo.Location = new System.Drawing.Point(204, 450);
            this.btnundo.Name = "btnundo";
            this.btnundo.Size = new System.Drawing.Size(75, 23);
            this.btnundo.TabIndex = 4;
            this.btnundo.Text = "Hoàn tác";
            this.btnundo.UseVisualStyleBackColor = true;
            this.btnundo.Click += new System.EventHandler(this.btnundo_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(285, 450);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(75, 23);
            this.btnexcel.TabIndex = 5;
            this.btnexcel.Text = "Excel";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(94, 450);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(104, 23);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "Xóa mục đã chọn";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtaddpartno
            // 
            this.txtaddpartno.Location = new System.Drawing.Point(16, 75);
            this.txtaddpartno.Name = "txtaddpartno";
            this.txtaddpartno.Size = new System.Drawing.Size(153, 20);
            this.txtaddpartno.TabIndex = 7;
            this.txtaddpartno.TextChanged += new System.EventHandler(this.txtaddpartno_TextChanged);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(175, 73);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(45, 23);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lbsearch
            // 
            this.lbsearch.FormattingEnabled = true;
            this.lbsearch.Location = new System.Drawing.Point(16, 97);
            this.lbsearch.Name = "lbsearch";
            this.lbsearch.Size = new System.Drawing.Size(154, 277);
            this.lbsearch.TabIndex = 9;
            this.lbsearch.Visible = false;
            this.lbsearch.Click += new System.EventHandler(this.lbsearch_Click);
            // 
            // lbaddpartname
            // 
            this.lbaddpartname.AutoSize = true;
            this.lbaddpartname.Location = new System.Drawing.Point(14, 109);
            this.lbaddpartname.Name = "lbaddpartname";
            this.lbaddpartname.Size = new System.Drawing.Size(28, 13);
            this.lbaddpartname.TabIndex = 10;
            this.lbaddpartname.Text = "###";
            // 
            // EditBOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 508);
            this.Controls.Add(this.lbsearch);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtaddpartno);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btnundo);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbprocess);
            this.Controls.Add(this.lbpartname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpartno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbaddpartname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditBOM";
            this.Text = "EditBOM";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtpartno;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbpartname;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbprocess;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btnsave;
        public System.Windows.Forms.Button btnundo;
        public System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtaddpartno;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process;
        private System.Windows.Forms.ListBox lbsearch;
        private System.Windows.Forms.Label lbaddpartname;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}