namespace HANMISYSTEM.Views
{
    partial class MakeBOM
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
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsub = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Partno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbsearch = new System.Windows.Forms.ListBox();
            this.lbsearchsub = new System.Windows.Forms.ListBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnedit = new System.Windows.Forms.PictureBox();
            this.btnadd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnedit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã mặt hàng";
            // 
            // txtmodel
            // 
            this.txtmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodel.Location = new System.Drawing.Point(168, 109);
            this.txtmodel.Multiline = true;
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(251, 36);
            this.txtmodel.TabIndex = 1;
            this.txtmodel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(475, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh sách nguyên vật liệu";
            // 
            // txtsub
            // 
            this.txtsub.Location = new System.Drawing.Point(168, 160);
            this.txtsub.Name = "txtsub";
            this.txtsub.Size = new System.Drawing.Size(153, 20);
            this.txtsub.TabIndex = 3;
            this.txtsub.TextChanged += new System.EventHandler(this.txtsub_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nguyên vật liệu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Partno,
            this.Partname,
            this.Quantity,
            this.process});
            this.dataGridView1.Location = new System.Drawing.Point(480, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(539, 456);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Partno
            // 
            this.Partno.DataPropertyName = "rawpartno";
            this.Partno.HeaderText = "Mã hàng";
            this.Partno.Name = "Partno";
            this.Partno.ReadOnly = true;
            // 
            // Partname
            // 
            this.Partname.DataPropertyName = "partname";
            this.Partname.HeaderText = "Tên hàng";
            this.Partname.Name = "Partname";
            this.Partname.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "quantity";
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // process
            // 
            this.process.DataPropertyName = "name";
            this.process.HeaderText = "Quy trình";
            this.process.Name = "process";
            this.process.ReadOnly = true;
            // 
            // lbsearch
            // 
            this.lbsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsearch.FormattingEnabled = true;
            this.lbsearch.ItemHeight = 20;
            this.lbsearch.Location = new System.Drawing.Point(167, 222);
            this.lbsearch.Name = "lbsearch";
            this.lbsearch.Size = new System.Drawing.Size(251, 344);
            this.lbsearch.TabIndex = 6;
            this.lbsearch.Visible = false;
            this.lbsearch.Click += new System.EventHandler(this.lbsearch_Click);
            // 
            // lbsearchsub
            // 
            this.lbsearchsub.FormattingEnabled = true;
            this.lbsearchsub.Location = new System.Drawing.Point(167, 257);
            this.lbsearchsub.Name = "lbsearchsub";
            this.lbsearchsub.Size = new System.Drawing.Size(153, 303);
            this.lbsearchsub.TabIndex = 7;
            this.lbsearchsub.Visible = false;
            this.lbsearchsub.Click += new System.EventHandler(this.lbsearchsub_Click);
            this.lbsearchsub.SelectedIndexChanged += new System.EventHandler(this.lbsearchsub_SelectedIndexChanged);
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(168, 187);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(100, 20);
            this.txtqty.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng";
            // 
            // btnedit
            // 
            this.btnedit.Image = global::HANMISYSTEM.Properties.Resources.edit_flat;
            this.btnedit.Location = new System.Drawing.Point(302, 187);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(25, 20);
            this.btnedit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnedit.TabIndex = 9;
            this.btnedit.TabStop = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Image = global::HANMISYSTEM.Properties.Resources.add;
            this.btnadd.Location = new System.Drawing.Point(274, 187);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(26, 20);
            this.btnadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnadd.TabIndex = 2;
            this.btnadd.TabStop = false;
            this.btnadd.Click += new System.EventHandler(this.btnaddsub_Click);
            // 
            // MakeBOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 804);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.lbsearchsub);
            this.Controls.Add(this.lbsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtmodel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnadd);
            this.Name = "MakeBOM";
            this.Text = "BOM";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnedit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnadd;
        private System.Windows.Forms.TextBox txtsub;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lbsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn process;
        private System.Windows.Forms.ListBox lbsearchsub;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnedit;
    }
}