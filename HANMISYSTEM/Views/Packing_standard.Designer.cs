﻿namespace HANMISYSTEM
{
    partial class Packing_standard
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
            this.box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.can = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtpartno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkbox = new System.Windows.Forms.CheckBox();
            this.txtpartname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkbag = new System.Windows.Forms.CheckBox();
            this.chkcrt = new System.Windows.Forms.CheckBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtboxqty = new System.Windows.Forms.TextBox();
            this.txtbagqty = new System.Windows.Forms.TextBox();
            this.txtcrtqty = new System.Windows.Forms.TextBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttrayqty = new System.Windows.Forms.TextBox();
            this.txtrollqty = new System.Windows.Forms.TextBox();
            this.txtpalletqty = new System.Windows.Forms.TextBox();
            this.chktray = new System.Windows.Forms.CheckBox();
            this.chkroll = new System.Windows.Forms.CheckBox();
            this.chkpallet = new System.Windows.Forms.CheckBox();
            this.txtcanqty = new System.Windows.Forms.TextBox();
            this.chkcan = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partno,
            this.partname,
            this.box,
            this.bag,
            this.crt,
            this.TRA,
            this.rol,
            this.pal,
            this.can});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(892, 597);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // partno
            // 
            this.partno.DataPropertyName = "partno";
            this.partno.HeaderText = "Part No";
            this.partno.Name = "partno";
            this.partno.ReadOnly = true;
            // 
            // partname
            // 
            this.partname.DataPropertyName = "partname";
            this.partname.HeaderText = "PartName";
            this.partname.Name = "partname";
            this.partname.ReadOnly = true;
            // 
            // box
            // 
            this.box.DataPropertyName = "box";
            this.box.HeaderText = "BOX";
            this.box.Name = "box";
            this.box.ReadOnly = true;
            // 
            // bag
            // 
            this.bag.DataPropertyName = "bag";
            this.bag.HeaderText = "BAG";
            this.bag.Name = "bag";
            this.bag.ReadOnly = true;
            // 
            // crt
            // 
            this.crt.DataPropertyName = "crt";
            this.crt.HeaderText = "CRT";
            this.crt.Name = "crt";
            this.crt.ReadOnly = true;
            // 
            // TRA
            // 
            this.TRA.DataPropertyName = "tra";
            this.TRA.HeaderText = "TRAY";
            this.TRA.Name = "TRA";
            this.TRA.ReadOnly = true;
            // 
            // rol
            // 
            this.rol.DataPropertyName = "rol";
            this.rol.HeaderText = "ROLL";
            this.rol.Name = "rol";
            this.rol.ReadOnly = true;
            // 
            // pal
            // 
            this.pal.DataPropertyName = "pal";
            this.pal.HeaderText = "PALLET";
            this.pal.Name = "pal";
            this.pal.ReadOnly = true;
            // 
            // can
            // 
            this.can.DataPropertyName = "can";
            this.can.HeaderText = "CAN";
            this.can.Name = "can";
            this.can.ReadOnly = true;
            // 
            // txtpartno
            // 
            this.txtpartno.Enabled = false;
            this.txtpartno.Location = new System.Drawing.Point(51, 10);
            this.txtpartno.Name = "txtpartno";
            this.txtpartno.Size = new System.Drawing.Size(136, 20);
            this.txtpartno.TabIndex = 1;
            this.txtpartno.TextChanged += new System.EventHandler(this.txtpartno_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "P/N";
            // 
            // chkbox
            // 
            this.chkbox.AutoSize = true;
            this.chkbox.Enabled = false;
            this.chkbox.Location = new System.Drawing.Point(44, 85);
            this.chkbox.Name = "chkbox";
            this.chkbox.Size = new System.Drawing.Size(48, 17);
            this.chkbox.TabIndex = 3;
            this.chkbox.Text = "BOX";
            this.chkbox.UseVisualStyleBackColor = true;
            this.chkbox.CheckedChanged += new System.EventHandler(this.chkbox_CheckedChanged);
            // 
            // txtpartname
            // 
            this.txtpartname.Enabled = false;
            this.txtpartname.Location = new System.Drawing.Point(51, 36);
            this.txtpartname.Name = "txtpartname";
            this.txtpartname.Size = new System.Drawing.Size(204, 20);
            this.txtpartname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "P/Name";
            // 
            // chkbag
            // 
            this.chkbag.AutoSize = true;
            this.chkbag.Enabled = false;
            this.chkbag.Location = new System.Drawing.Point(121, 85);
            this.chkbag.Name = "chkbag";
            this.chkbag.Size = new System.Drawing.Size(48, 17);
            this.chkbag.TabIndex = 3;
            this.chkbag.Text = "BAG";
            this.chkbag.UseVisualStyleBackColor = true;
            this.chkbag.CheckedChanged += new System.EventHandler(this.chkbag_CheckedChanged);
            // 
            // chkcrt
            // 
            this.chkcrt.AutoSize = true;
            this.chkcrt.Enabled = false;
            this.chkcrt.Location = new System.Drawing.Point(200, 85);
            this.chkcrt.Name = "chkcrt";
            this.chkcrt.Size = new System.Drawing.Size(48, 17);
            this.chkcrt.TabIndex = 3;
            this.chkcrt.Text = "CRT";
            this.chkcrt.UseVisualStyleBackColor = true;
            this.chkcrt.CheckedChanged += new System.EventHandler(this.chkcrt_CheckedChanged);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(121, 564);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(101, 40);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Lưu lại";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtboxqty
            // 
            this.txtboxqty.Enabled = false;
            this.txtboxqty.Location = new System.Drawing.Point(44, 108);
            this.txtboxqty.Name = "txtboxqty";
            this.txtboxqty.Size = new System.Drawing.Size(34, 20);
            this.txtboxqty.TabIndex = 1;
            this.txtboxqty.Validated += new System.EventHandler(this.txtboxqty_Validated);
            // 
            // txtbagqty
            // 
            this.txtbagqty.Enabled = false;
            this.txtbagqty.Location = new System.Drawing.Point(121, 108);
            this.txtbagqty.Name = "txtbagqty";
            this.txtbagqty.Size = new System.Drawing.Size(34, 20);
            this.txtbagqty.TabIndex = 1;
            // 
            // txtcrtqty
            // 
            this.txtcrtqty.Enabled = false;
            this.txtcrtqty.Location = new System.Drawing.Point(200, 108);
            this.txtcrtqty.Name = "txtcrtqty";
            this.txtcrtqty.Size = new System.Drawing.Size(34, 20);
            this.txtcrtqty.TabIndex = 1;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(107, 21);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(136, 20);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tìm kiếm";
            // 
            // txttrayqty
            // 
            this.txttrayqty.Enabled = false;
            this.txttrayqty.Location = new System.Drawing.Point(44, 162);
            this.txttrayqty.Name = "txttrayqty";
            this.txttrayqty.Size = new System.Drawing.Size(34, 20);
            this.txttrayqty.TabIndex = 1;
            this.txttrayqty.Validated += new System.EventHandler(this.txtboxqty_Validated);
            // 
            // txtrollqty
            // 
            this.txtrollqty.Enabled = false;
            this.txtrollqty.Location = new System.Drawing.Point(121, 162);
            this.txtrollqty.Name = "txtrollqty";
            this.txtrollqty.Size = new System.Drawing.Size(34, 20);
            this.txtrollqty.TabIndex = 1;
            // 
            // txtpalletqty
            // 
            this.txtpalletqty.Enabled = false;
            this.txtpalletqty.Location = new System.Drawing.Point(200, 162);
            this.txtpalletqty.Name = "txtpalletqty";
            this.txtpalletqty.Size = new System.Drawing.Size(34, 20);
            this.txtpalletqty.TabIndex = 1;
            // 
            // chktray
            // 
            this.chktray.AutoSize = true;
            this.chktray.Enabled = false;
            this.chktray.Location = new System.Drawing.Point(44, 139);
            this.chktray.Name = "chktray";
            this.chktray.Size = new System.Drawing.Size(48, 17);
            this.chktray.TabIndex = 3;
            this.chktray.Text = "TRA";
            this.chktray.UseVisualStyleBackColor = true;
            this.chktray.CheckedChanged += new System.EventHandler(this.chktray_CheckedChanged);
            // 
            // chkroll
            // 
            this.chkroll.AutoSize = true;
            this.chkroll.Enabled = false;
            this.chkroll.Location = new System.Drawing.Point(121, 139);
            this.chkroll.Name = "chkroll";
            this.chkroll.Size = new System.Drawing.Size(48, 17);
            this.chkroll.TabIndex = 3;
            this.chkroll.Text = "ROL";
            this.chkroll.UseVisualStyleBackColor = true;
            this.chkroll.CheckedChanged += new System.EventHandler(this.chkroll_CheckedChanged);
            // 
            // chkpallet
            // 
            this.chkpallet.AutoSize = true;
            this.chkpallet.Enabled = false;
            this.chkpallet.Location = new System.Drawing.Point(200, 139);
            this.chkpallet.Name = "chkpallet";
            this.chkpallet.Size = new System.Drawing.Size(46, 17);
            this.chkpallet.TabIndex = 3;
            this.chkpallet.Text = "PAL";
            this.chkpallet.UseVisualStyleBackColor = true;
            this.chkpallet.CheckedChanged += new System.EventHandler(this.chkpallet_CheckedChanged);
            // 
            // txtcanqty
            // 
            this.txtcanqty.Enabled = false;
            this.txtcanqty.Location = new System.Drawing.Point(44, 219);
            this.txtcanqty.Name = "txtcanqty";
            this.txtcanqty.Size = new System.Drawing.Size(34, 20);
            this.txtcanqty.TabIndex = 1;
            this.txtcanqty.Validated += new System.EventHandler(this.txtboxqty_Validated);
            // 
            // chkcan
            // 
            this.chkcan.AutoSize = true;
            this.chkcan.Enabled = false;
            this.chkcan.Location = new System.Drawing.Point(44, 196);
            this.chkcan.Name = "chkcan";
            this.chkcan.Size = new System.Drawing.Size(48, 17);
            this.chkcan.TabIndex = 3;
            this.chkcan.Text = "CAN";
            this.chkcan.UseVisualStyleBackColor = true;
            this.chkcan.CheckedChanged += new System.EventHandler(this.chkcan_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.txtpartno);
            this.panel1.Controls.Add(this.chkpallet);
            this.panel1.Controls.Add(this.txtboxqty);
            this.panel1.Controls.Add(this.chkcrt);
            this.panel1.Controls.Add(this.txtbagqty);
            this.panel1.Controls.Add(this.chkroll);
            this.panel1.Controls.Add(this.txttrayqty);
            this.panel1.Controls.Add(this.chkbag);
            this.panel1.Controls.Add(this.txtcanqty);
            this.panel1.Controls.Add(this.chkcan);
            this.panel1.Controls.Add(this.txtcrtqty);
            this.panel1.Controls.Add(this.chktray);
            this.panel1.Controls.Add(this.txtrollqty);
            this.panel1.Controls.Add(this.chkbox);
            this.panel1.Controls.Add(this.txtpalletqty);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtpartname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 653);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(252, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 653);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtsearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(892, 56);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(892, 597);
            this.panel4.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(44, 260);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(44, 283);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "checkBox1";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Packing_standard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Packing_standard";
            this.Text = "Packing_standard";
            this.Load += new System.EventHandler(this.Packing_standard_Load);
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

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtpartno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkbox;
        private System.Windows.Forms.TextBox txtpartname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkbag;
        private System.Windows.Forms.CheckBox chkcrt;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtboxqty;
        private System.Windows.Forms.TextBox txtbagqty;
        private System.Windows.Forms.TextBox txtcrtqty;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttrayqty;
        private System.Windows.Forms.TextBox txtrollqty;
        private System.Windows.Forms.TextBox txtpalletqty;
        private System.Windows.Forms.CheckBox chktray;
        private System.Windows.Forms.CheckBox chkroll;
        private System.Windows.Forms.CheckBox chkpallet;
        private System.Windows.Forms.TextBox txtcanqty;
        private System.Windows.Forms.CheckBox chkcan;
        private System.Windows.Forms.DataGridViewTextBoxColumn partno;
        private System.Windows.Forms.DataGridViewTextBoxColumn partname;
        private System.Windows.Forms.DataGridViewTextBoxColumn box;
        private System.Windows.Forms.DataGridViewTextBoxColumn bag;
        private System.Windows.Forms.DataGridViewTextBoxColumn crt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pal;
        private System.Windows.Forms.DataGridViewTextBoxColumn can;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}