namespace HANMISYSTEM
{
    partial class Statistics
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crtqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lbpartno = new System.Windows.Forms.Label();
            this.lbmonth = new System.Windows.Forms.Label();
            this.lbwarehouse = new System.Windows.Forms.Label();
            this.llpre = new System.Windows.Forms.LinkLabel();
            this.llnext = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.actualok,
            this.actualng,
            this.boxqty,
            this.bagqty,
            this.crtqty});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(801, 353);
            this.dataGridView1.TabIndex = 2;
            // 
            // date
            // 
            this.date.FillWeight = 60F;
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // actualok
            // 
            this.actualok.FillWeight = 83.45177F;
            this.actualok.HeaderText = "Actual-OK";
            this.actualok.Name = "actualok";
            this.actualok.ReadOnly = true;
            // 
            // actualng
            // 
            this.actualng.FillWeight = 83.45177F;
            this.actualng.HeaderText = "Actual-NG";
            this.actualng.Name = "actualng";
            this.actualng.ReadOnly = true;
            // 
            // boxqty
            // 
            this.boxqty.FillWeight = 83.45177F;
            this.boxqty.HeaderText = "Box qty";
            this.boxqty.Name = "boxqty";
            this.boxqty.ReadOnly = true;
            // 
            // bagqty
            // 
            this.bagqty.FillWeight = 83.45177F;
            this.bagqty.HeaderText = "Bag Qty";
            this.bagqty.Name = "bagqty";
            this.bagqty.ReadOnly = true;
            // 
            // crtqty
            // 
            this.crtqty.FillWeight = 83.45177F;
            this.crtqty.HeaderText = "Cart Qty";
            this.crtqty.Name = "crtqty";
            this.crtqty.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Statistics";
            // 
            // lbpartno
            // 
            this.lbpartno.AutoSize = true;
            this.lbpartno.Location = new System.Drawing.Point(20, 55);
            this.lbpartno.Name = "lbpartno";
            this.lbpartno.Size = new System.Drawing.Size(41, 13);
            this.lbpartno.TabIndex = 4;
            this.lbpartno.Text = "Part no";
            // 
            // lbmonth
            // 
            this.lbmonth.AutoSize = true;
            this.lbmonth.Location = new System.Drawing.Point(652, 51);
            this.lbmonth.Name = "lbmonth";
            this.lbmonth.Size = new System.Drawing.Size(16, 13);
            this.lbmonth.TabIndex = 5;
            this.lbmonth.Text = "...";
            // 
            // lbwarehouse
            // 
            this.lbwarehouse.AutoSize = true;
            this.lbwarehouse.Location = new System.Drawing.Point(20, 23);
            this.lbwarehouse.Name = "lbwarehouse";
            this.lbwarehouse.Size = new System.Drawing.Size(26, 13);
            this.lbwarehouse.TabIndex = 6;
            this.lbwarehouse.Text = "WH";
            // 
            // llpre
            // 
            this.llpre.AutoSize = true;
            this.llpre.Location = new System.Drawing.Point(613, 55);
            this.llpre.Name = "llpre";
            this.llpre.Size = new System.Drawing.Size(23, 13);
            this.llpre.TabIndex = 7;
            this.llpre.TabStop = true;
            this.llpre.Text = "Pre";
            this.llpre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llpre_LinkClicked);
            // 
            // llnext
            // 
            this.llnext.AutoSize = true;
            this.llnext.Location = new System.Drawing.Point(694, 55);
            this.llnext.Name = "llnext";
            this.llnext.Size = new System.Drawing.Size(29, 13);
            this.llnext.TabIndex = 7;
            this.llnext.TabStop = true;
            this.llnext.Text = "Next";
            this.llnext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llnext_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 353);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbpartno);
            this.panel2.Controls.Add(this.llnext);
            this.panel2.Controls.Add(this.lbmonth);
            this.panel2.Controls.Add(this.llpre);
            this.panel2.Controls.Add(this.lbwarehouse);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 447);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Image = global::HANMISYSTEM.Properties.Resources.export;
            this.pictureBox1.Location = new System.Drawing.Point(313, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 447);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbpartno;
        public System.Windows.Forms.Label lbmonth;
        public System.Windows.Forms.Label lbwarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualok;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualng;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn crtqty;
        private System.Windows.Forms.LinkLabel llpre;
        private System.Windows.Forms.LinkLabel llnext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}