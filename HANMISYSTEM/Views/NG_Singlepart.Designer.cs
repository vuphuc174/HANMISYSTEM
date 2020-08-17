namespace HANMISYSTEM
{
    partial class NG_Singlepart
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbwarehouse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpartno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Partno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpartname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdefect = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warehouse";
            // 
            // cbwarehouse
            // 
            this.cbwarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbwarehouse.FormattingEnabled = true;
            this.cbwarehouse.Location = new System.Drawing.Point(90, 26);
            this.cbwarehouse.Name = "cbwarehouse";
            this.cbwarehouse.Size = new System.Drawing.Size(141, 21);
            this.cbwarehouse.TabIndex = 1;
            this.cbwarehouse.SelectedIndexChanged += new System.EventHandler(this.cbwarehouse_SelectedIndexChanged);
            this.cbwarehouse.Click += new System.EventHandler(this.cbwarehouse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Partno";
            // 
            // txtpartno
            // 
            this.txtpartno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtpartno.Location = new System.Drawing.Point(90, 62);
            this.txtpartno.Name = "txtpartno";
            this.txtpartno.Size = new System.Drawing.Size(141, 20);
            this.txtpartno.TabIndex = 2;
            this.txtpartno.TextChanged += new System.EventHandler(this.txtpartno_TextChanged);
            this.txtpartno.Leave += new System.EventHandler(this.txtpartno_Leave);
            this.txtpartno.Validated += new System.EventHandler(this.txtpartno_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantity";
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(90, 127);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(41, 20);
            this.txtqty.TabIndex = 2;
            this.txtqty.Validated += new System.EventHandler(this.txtqty_Validated);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(90, 224);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(69, 23);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Partno,
            this.Partname,
            this.quantity});
            this.dataGridView1.Location = new System.Drawing.Point(257, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(527, 397);
            this.dataGridView1.TabIndex = 4;
            // 
            // Partno
            // 
            this.Partno.DataPropertyName = "partno";
            this.Partno.HeaderText = "Partno";
            this.Partno.Name = "Partno";
            this.Partno.ReadOnly = true;
            // 
            // Partname
            // 
            this.Partname.DataPropertyName = "partname";
            this.Partname.HeaderText = "Partname";
            this.Partname.Name = "Partname";
            this.Partname.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "qty";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "PartName";
            // 
            // txtpartname
            // 
            this.txtpartname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtpartname.Enabled = false;
            this.txtpartname.Location = new System.Drawing.Point(90, 97);
            this.txtpartname.Name = "txtpartname";
            this.txtpartname.Size = new System.Drawing.Size(141, 20);
            this.txtpartname.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Defect";
            // 
            // txtdefect
            // 
            this.txtdefect.Location = new System.Drawing.Point(90, 153);
            this.txtdefect.Multiline = true;
            this.txtdefect.Name = "txtdefect";
            this.txtdefect.Size = new System.Drawing.Size(150, 65);
            this.txtdefect.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sum of part ng";
            // 
            // NG_Singlepart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 428);
            this.Controls.Add(this.txtdefect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.txtpartname);
            this.Controls.Add(this.txtpartno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbwarehouse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NG_Singlepart";
            this.Text = "NG_Singlepart";
            this.Load += new System.EventHandler(this.NG_Singlepart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbwarehouse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpartno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partname;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpartname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdefect;
        private System.Windows.Forms.Label label6;
    }
}