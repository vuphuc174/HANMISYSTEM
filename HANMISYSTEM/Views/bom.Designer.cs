namespace HANMISYSTEM
{
    partial class bom
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
            this.partno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RawQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpartname = new System.Windows.Forms.TextBox();
            this.txtpartno = new System.Windows.Forms.TextBox();
            this.btnselect = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnimport = new System.Windows.Forms.Button();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.btnbrowser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnremove = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rawpartno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rawname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partno,
            this.partname,
            this.RawQty});
            this.dataGridView1.Location = new System.Drawing.Point(447, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 418);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // partno
            // 
            this.partno.DataPropertyName = "partno";
            this.partno.HeaderText = "Part No";
            this.partno.Name = "partno";
            // 
            // partname
            // 
            this.partname.DataPropertyName = "partname";
            this.partname.HeaderText = "Part Name";
            this.partname.Name = "partname";
            this.partname.Width = 200;
            // 
            // RawQty
            // 
            this.RawQty.DataPropertyName = "qty";
            this.RawQty.HeaderText = "Raw Qty";
            this.RawQty.Name = "RawQty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select part";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rawpartno,
            this.rawname,
            this.Qty});
            this.dataGridView2.Location = new System.Drawing.Point(33, 107);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(408, 155);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            this.dataGridView2.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BOM list";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtpartname
            // 
            this.txtpartname.Enabled = false;
            this.txtpartname.Location = new System.Drawing.Point(104, 46);
            this.txtpartname.Name = "txtpartname";
            this.txtpartname.Size = new System.Drawing.Size(286, 20);
            this.txtpartname.TabIndex = 4;
            // 
            // txtpartno
            // 
            this.txtpartno.Location = new System.Drawing.Point(104, 21);
            this.txtpartno.Name = "txtpartno";
            this.txtpartno.Size = new System.Drawing.Size(142, 20);
            this.txtpartno.TabIndex = 5;
            this.txtpartno.TextChanged += new System.EventHandler(this.txtpartno_TextChanged);
            // 
            // btnselect
            // 
            this.btnselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnselect.Location = new System.Drawing.Point(253, 19);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(36, 23);
            this.btnselect.TabIndex = 6;
            this.btnselect.Text = "sel";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // btnsave
            // 
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Location = new System.Drawing.Point(33, 281);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(104, 32);
            this.btnsave.TabIndex = 7;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Template";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnimport
            // 
            this.btnimport.Location = new System.Drawing.Point(827, 76);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(64, 21);
            this.btnimport.TabIndex = 8;
            this.btnimport.Text = "Import";
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Visible = false;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(630, 50);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(191, 20);
            this.txtpath.TabIndex = 9;
            // 
            // btnbrowser
            // 
            this.btnbrowser.Location = new System.Drawing.Point(827, 50);
            this.btnbrowser.Name = "btnbrowser";
            this.btnbrowser.Size = new System.Drawing.Size(64, 20);
            this.btnbrowser.TabIndex = 10;
            this.btnbrowser.Text = "Browser";
            this.btnbrowser.UseVisualStyleBackColor = true;
            this.btnbrowser.Click += new System.EventHandler(this.btnbrowser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Uploading....";
            this.label3.Visible = false;
            // 
            // btnremove
            // 
            this.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremove.Location = new System.Drawing.Point(366, 82);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(75, 23);
            this.btnremove.TabIndex = 13;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(617, 84);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(146, 20);
            this.txtsearch.TabIndex = 14;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tìm kiếm";
            // 
            // rawpartno
            // 
            this.rawpartno.HeaderText = "Raw";
            this.rawpartno.Name = "rawpartno";
            // 
            // rawname
            // 
            this.rawname.HeaderText = "Raw Name";
            this.rawname.Name = "rawname";
            this.rawname.ReadOnly = true;
            this.rawname.Width = 200;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HANMISYSTEM.Properties.Resources.add;
            this.pictureBox2.Location = new System.Drawing.Point(329, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HANMISYSTEM.Properties.Resources.upload;
            this.pictureBox1.Location = new System.Drawing.Point(594, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // bom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 518);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnbrowser);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.btnimport);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.txtpartno);
            this.Controls.Add(this.txtpartname);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bom";
            this.Text = "`";
            this.Load += new System.EventHandler(this.bom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpartname;
        private System.Windows.Forms.TextBox txtpartno;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.DataGridViewTextBoxColumn partno;
        private System.Windows.Forms.DataGridViewTextBoxColumn partname;
        private System.Windows.Forms.DataGridViewTextBoxColumn RawQty;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Button btnbrowser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawpartno;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}