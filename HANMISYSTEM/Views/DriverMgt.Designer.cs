namespace HANMISYSTEM.Views
{
    partial class DriverMgt
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcarnumber = new System.Windows.Forms.TextBox();
            this.btncreate = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsavechange = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.carnumber});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(540, 248);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnsavechange);
            this.panel1.Controls.Add(this.btncreate);
            this.panel1.Controls.Add(this.txtcarnumber);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 214);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng kí lái xe mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lái xe";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(78, 88);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(206, 20);
            this.txtname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Biển số xe";
            // 
            // txtcarnumber
            // 
            this.txtcarnumber.Location = new System.Drawing.Point(78, 123);
            this.txtcarnumber.Name = "txtcarnumber";
            this.txtcarnumber.Size = new System.Drawing.Size(134, 20);
            this.txtcarnumber.TabIndex = 2;
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(78, 150);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(91, 26);
            this.btncreate.TabIndex = 3;
            this.btncreate.Text = "Đăng ký";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên lái xe";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // carnumber
            // 
            this.carnumber.DataPropertyName = "carnumber";
            this.carnumber.HeaderText = "Biển số xe";
            this.carnumber.Name = "carnumber";
            this.carnumber.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 248);
            this.panel2.TabIndex = 2;
            // 
            // btnsavechange
            // 
            this.btnsavechange.Location = new System.Drawing.Point(175, 150);
            this.btnsavechange.Name = "btnsavechange";
            this.btnsavechange.Size = new System.Drawing.Size(91, 26);
            this.btnsavechange.TabIndex = 3;
            this.btnsavechange.Text = "Lưu thay đổi";
            this.btnsavechange.UseVisualStyleBackColor = true;
            this.btnsavechange.Click += new System.EventHandler(this.btnsavechange_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(78, 52);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(42, 20);
            this.txtid.TabIndex = 2;
            // 
            // DriverMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 462);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DriverMgt";
            this.Text = "DriverMgt";
            this.Load += new System.EventHandler(this.DriverMgt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.TextBox txtcarnumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnsavechange;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
    }
}