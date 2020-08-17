namespace HANMISYSTEM
{
    partial class EditInvoice
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
            this.idpack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lbinvoice = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.txtcarno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpack,
            this.partno,
            this.quantity,
            this.remain,
            this.Remark});
            this.dataGridView1.Location = new System.Drawing.Point(45, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 247);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // idpack
            // 
            this.idpack.DataPropertyName = "idpack";
            this.idpack.HeaderText = "Box No";
            this.idpack.Name = "idpack";
            this.idpack.ReadOnly = true;
            // 
            // partno
            // 
            this.partno.DataPropertyName = "partno";
            this.partno.HeaderText = "Part No";
            this.partno.Name = "partno";
            this.partno.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Qty";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // remain
            // 
            this.remain.HeaderText = "Remain";
            this.remain.Name = "remain";
            this.remain.ReadOnly = true;
            // 
            // Remark
            // 
            this.Remark.HeaderText = "Remark";
            this.Remark.Name = "Remark";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "INVOICE NUMBER :";
            // 
            // lbinvoice
            // 
            this.lbinvoice.AutoSize = true;
            this.lbinvoice.Location = new System.Drawing.Point(154, 39);
            this.lbinvoice.Name = "lbinvoice";
            this.lbinvoice.Size = new System.Drawing.Size(35, 13);
            this.lbinvoice.TabIndex = 2;
            this.lbinvoice.Text = "label2";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(45, 316);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(416, 34);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 23);
            this.btnprint.TabIndex = 3;
            this.btnprint.Text = "PRINT";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // txtcarno
            // 
            this.txtcarno.Location = new System.Drawing.Point(313, 36);
            this.txtcarno.Name = "txtcarno";
            this.txtcarno.Size = new System.Drawing.Size(97, 20);
            this.txtcarno.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Car No";
            // 
            // EditInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 365);
            this.Controls.Add(this.txtcarno);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbinvoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditInvoice";
            this.Text = "EditInvoice";
            this.Load += new System.EventHandler(this.EditInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbinvoice;
        public System.Windows.Forms.Button btnsave;
        public System.Windows.Forms.Button btnprint;
        public System.Windows.Forms.TextBox txtcarno;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpack;
        private System.Windows.Forms.DataGridViewTextBoxColumn partno;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn remain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;

    }
}