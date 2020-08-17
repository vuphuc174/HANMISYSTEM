namespace HANMISYSTEM
{
    partial class Warehousemgt
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbcategory = new System.Windows.Forms.ComboBox();
            this.txtsign = new System.Windows.Forms.TextBox();
            this.txtnamewarehouse = new System.Windows.Forms.TextBox();
            this.txtidwarehouse = new System.Windows.Forms.TextBox();
            this.idwarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namewarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(345, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 415);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idwarehouse,
            this.namewarehouse,
            this.namecategory,
            this.sign});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(515, 415);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbcategory);
            this.panel2.Controls.Add(this.txtsign);
            this.panel2.Controls.Add(this.txtnamewarehouse);
            this.panel2.Controls.Add(this.txtidwarehouse);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 415);
            this.panel2.TabIndex = 0;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(201, 126);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(76, 29);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(119, 126);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(76, 29);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SIGN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "CATEGORY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NAME WH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IDWAREHOUSE";
            // 
            // cbcategory
            // 
            this.cbcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcategory.FormattingEnabled = true;
            this.cbcategory.Location = new System.Drawing.Point(119, 73);
            this.cbcategory.Name = "cbcategory";
            this.cbcategory.Size = new System.Drawing.Size(121, 21);
            this.cbcategory.TabIndex = 1;
            // 
            // txtsign
            // 
            this.txtsign.Location = new System.Drawing.Point(119, 100);
            this.txtsign.Name = "txtsign";
            this.txtsign.Size = new System.Drawing.Size(184, 20);
            this.txtsign.TabIndex = 0;
            // 
            // txtnamewarehouse
            // 
            this.txtnamewarehouse.Location = new System.Drawing.Point(119, 46);
            this.txtnamewarehouse.Name = "txtnamewarehouse";
            this.txtnamewarehouse.Size = new System.Drawing.Size(184, 20);
            this.txtnamewarehouse.TabIndex = 0;
            // 
            // txtidwarehouse
            // 
            this.txtidwarehouse.Enabled = false;
            this.txtidwarehouse.Location = new System.Drawing.Point(119, 20);
            this.txtidwarehouse.Name = "txtidwarehouse";
            this.txtidwarehouse.Size = new System.Drawing.Size(184, 20);
            this.txtidwarehouse.TabIndex = 0;
            // 
            // idwarehouse
            // 
            this.idwarehouse.DataPropertyName = "idwarehouse";
            this.idwarehouse.HeaderText = "ID WAREHOUSE";
            this.idwarehouse.Name = "idwarehouse";
            // 
            // namewarehouse
            // 
            this.namewarehouse.DataPropertyName = "namewarehouse";
            this.namewarehouse.HeaderText = "NAME WAREHOUSE";
            this.namewarehouse.Name = "namewarehouse";
            // 
            // namecategory
            // 
            this.namecategory.DataPropertyName = "namecategory";
            this.namecategory.HeaderText = "CATEGORY";
            this.namecategory.Name = "namecategory";
            // 
            // sign
            // 
            this.sign.DataPropertyName = "sign";
            this.sign.HeaderText = "SIGN";
            this.sign.Name = "sign";
            // 
            // Warehousemgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 415);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Warehousemgt";
            this.Text = "Warehousemgt";
            this.Load += new System.EventHandler(this.Warehousemgt_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbcategory;
        private System.Windows.Forms.TextBox txtsign;
        private System.Windows.Forms.TextBox txtnamewarehouse;
        private System.Windows.Forms.TextBox txtidwarehouse;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idwarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn namewarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn sign;
    }
}