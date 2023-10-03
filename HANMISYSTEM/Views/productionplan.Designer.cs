namespace HANMISYSTEM
{
    partial class productionplan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productionplan));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbwarehouse = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cblocation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpartno = new System.Windows.Forms.TextBox();
            this.dgvplan = new System.Windows.Forms.DataGridView();
            this.ID_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtplan = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnimport = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnbrowser = new System.Windows.Forms.Button();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lbsearch = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPlanID = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtwo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbline = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpdateplan = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvplan)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm:00";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(75, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bộ phận";
            // 
            // cbwarehouse
            // 
            this.cbwarehouse.FormattingEnabled = true;
            this.cbwarehouse.Location = new System.Drawing.Point(75, 69);
            this.cbwarehouse.Name = "cbwarehouse";
            this.cbwarehouse.Size = new System.Drawing.Size(155, 24);
            this.cbwarehouse.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chuyền";
            // 
            // cblocation
            // 
            this.cblocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblocation.FormattingEnabled = true;
            this.cblocation.Location = new System.Drawing.Point(75, 103);
            this.cblocation.Name = "cblocation";
            this.cblocation.Size = new System.Drawing.Size(155, 24);
            this.cblocation.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Model";
            // 
            // txtpartno
            // 
            this.txtpartno.Location = new System.Drawing.Point(75, 165);
            this.txtpartno.Name = "txtpartno";
            this.txtpartno.Size = new System.Drawing.Size(144, 23);
            this.txtpartno.TabIndex = 7;
            this.txtpartno.TextChanged += new System.EventHandler(this.txtpartno_TextChanged);
            // 
            // dgvplan
            // 
            this.dgvplan.AllowUserToAddRows = false;
            this.dgvplan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvplan.BackgroundColor = System.Drawing.Color.White;
            this.dgvplan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvplan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvplan.ColumnHeadersHeight = 50;
            this.dgvplan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_col,
            this.partno,
            this.partname,
            this.quantity,
            this.idlocation,
            this.wo,
            this.pst,
            this.status});
            this.dgvplan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvplan.Location = new System.Drawing.Point(0, 0);
            this.dgvplan.Name = "dgvplan";
            this.dgvplan.RowHeadersVisible = false;
            this.dgvplan.Size = new System.Drawing.Size(905, 583);
            this.dgvplan.TabIndex = 0;
            this.dgvplan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvplan_CellClick);
            this.dgvplan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvplan_MouseClick);
            // 
            // ID_col
            // 
            this.ID_col.DataPropertyName = "id";
            this.ID_col.FillWeight = 50F;
            this.ID_col.HeaderText = "ID";
            this.ID_col.Name = "ID_col";
            this.ID_col.ReadOnly = true;
            this.ID_col.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // partno
            // 
            this.partno.DataPropertyName = "partno";
            this.partno.HeaderText = "Mặt hàng";
            this.partno.Name = "partno";
            this.partno.ReadOnly = true;
            // 
            // partname
            // 
            this.partname.DataPropertyName = "partname";
            this.partname.HeaderText = "Tên mặt hàng";
            this.partname.Name = "partname";
            this.partname.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "productionplan";
            this.quantity.HeaderText = "Kế hoạch";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // idlocation
            // 
            this.idlocation.DataPropertyName = "idlocation";
            this.idlocation.HeaderText = "Chuyền";
            this.idlocation.Name = "idlocation";
            this.idlocation.ReadOnly = true;
            // 
            // wo
            // 
            this.wo.DataPropertyName = "wocode";
            this.wo.HeaderText = "WO";
            this.wo.Name = "wo";
            this.wo.ReadOnly = true;
            // 
            // pst
            // 
            this.pst.DataPropertyName = "pst";
            this.pst.HeaderText = "PST";
            this.pst.Name = "pst";
            this.pst.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Trạng thái";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Kế hoạch";
            // 
            // txtplan
            // 
            this.txtplan.Location = new System.Drawing.Point(75, 195);
            this.txtplan.Name = "txtplan";
            this.txtplan.Size = new System.Drawing.Size(144, 23);
            this.txtplan.TabIndex = 7;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(74, 225);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 40);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "THÊM";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(25, 18);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(81, 35);
            this.btnexcel.TabIndex = 12;
            this.btnexcel.Text = "Excel";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(112, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 35);
            this.button3.TabIndex = 12;
            this.button3.Text = "Template";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnimport
            // 
            this.btnimport.Location = new System.Drawing.Point(323, 11);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(76, 26);
            this.btnimport.TabIndex = 12;
            this.btnimport.Text = "Import";
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Visible = false;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(155, 225);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 40);
            this.btnsave.TabIndex = 13;
            this.btnsave.Text = "LƯU LẠI";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnbrowser
            // 
            this.btnbrowser.Location = new System.Drawing.Point(242, 11);
            this.btnbrowser.Name = "btnbrowser";
            this.btnbrowser.Size = new System.Drawing.Size(75, 26);
            this.btnbrowser.TabIndex = 14;
            this.btnbrowser.Text = "Browser";
            this.btnbrowser.UseVisualStyleBackColor = true;
            this.btnbrowser.Click += new System.EventHandler(this.btnbrowser_Click);
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(39, 13);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(197, 24);
            this.txtpath.TabIndex = 15;
            // 
            // lbsearch
            // 
            this.lbsearch.FormattingEnabled = true;
            this.lbsearch.ItemHeight = 16;
            this.lbsearch.Location = new System.Drawing.Point(75, 195);
            this.lbsearch.Name = "lbsearch";
            this.lbsearch.Size = new System.Drawing.Size(205, 260);
            this.lbsearch.TabIndex = 22;
            this.lbsearch.Visible = false;
            this.lbsearch.Click += new System.EventHandler(this.lbsearch_Click);
            this.lbsearch.SelectedIndexChanged += new System.EventHandler(this.lbsearch_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 37);
            this.panel1.TabIndex = 23;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtpath);
            this.panel7.Controls.Add(this.btnimport);
            this.panel7.Controls.Add(this.btnbrowser);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(778, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(411, 37);
            this.panel7.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtPlanID);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lbsearch);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbwarehouse);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cblocation);
            this.panel2.Controls.Add(this.txtwo);
            this.panel2.Controls.Add(this.txtpartno);
            this.panel2.Controls.Add(this.txtplan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 643);
            this.panel2.TabIndex = 24;
            // 
            // txtPlanID
            // 
            this.txtPlanID.Enabled = false;
            this.txtPlanID.Location = new System.Drawing.Point(75, 6);
            this.txtPlanID.Name = "txtPlanID";
            this.txtPlanID.Size = new System.Drawing.Size(100, 23);
            this.txtPlanID.TabIndex = 26;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button3);
            this.panel8.Controls.Add(this.btnexcel);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 578);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(284, 65);
            this.panel8.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(168, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 23);
            this.textBox1.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Mã W/O";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Mã KH";
            // 
            // txtwo
            // 
            this.txtwo.Enabled = false;
            this.txtwo.Location = new System.Drawing.Point(74, 135);
            this.txtwo.Name = "txtwo";
            this.txtwo.Size = new System.Drawing.Size(88, 23);
            this.txtwo.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(284, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(905, 643);
            this.panel3.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvplan);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(905, 583);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.dtpdateplan);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.cbline);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.textBox3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(816, 60);
            this.panel6.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(333, 21);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 23);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Search";
            // 
            // cbline
            // 
            this.cbline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbline.FormattingEnabled = true;
            this.cbline.Location = new System.Drawing.Point(64, 21);
            this.cbline.Name = "cbline";
            this.cbline.Size = new System.Drawing.Size(145, 24);
            this.cbline.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Chuyền";
            // 
            // dtpdateplan
            // 
            this.dtpdateplan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdateplan.Location = new System.Drawing.Point(215, 21);
            this.dtpdateplan.Name = "dtpdateplan";
            this.dtpdateplan.Size = new System.Drawing.Size(100, 23);
            this.dtpdateplan.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::HANMISYSTEM.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(495, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(905, 60);
            this.panel4.TabIndex = 22;
            // 
            // productionplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1189, 680);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "productionplan";
            this.Text = "Production Plan";
            this.Load += new System.EventHandler(this.productionplan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvplan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbwarehouse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cblocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpartno;
        private System.Windows.Forms.DataGridView dgvplan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtplan;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnbrowser;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox lbsearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtwo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtPlanID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn partno;
        private System.Windows.Forms.DataGridViewTextBoxColumn partname;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn wo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pst;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpdateplan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbline;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
    }
}