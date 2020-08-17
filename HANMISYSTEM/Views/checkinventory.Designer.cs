namespace HANMISYSTEM
{
    partial class checkinventory
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
            this.cbwarehouse = new System.Windows.Forms.ComboBox();
            this.txtpartno = new System.Windows.Forms.TextBox();
            this.lbkho = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpartname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btndeleteall = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidpack = new System.Windows.Forms.TextBox();
            this.listsearch = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsumqty = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbwarehouse
            // 
            this.cbwarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbwarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbwarehouse.FormattingEnabled = true;
            this.cbwarehouse.Location = new System.Drawing.Point(85, 35);
            this.cbwarehouse.Name = "cbwarehouse";
            this.cbwarehouse.Size = new System.Drawing.Size(141, 21);
            this.cbwarehouse.TabIndex = 0;
            // 
            // txtpartno
            // 
            this.txtpartno.Location = new System.Drawing.Point(85, 62);
            this.txtpartno.Name = "txtpartno";
            this.txtpartno.Size = new System.Drawing.Size(197, 20);
            this.txtpartno.TabIndex = 1;
            this.txtpartno.TextChanged += new System.EventHandler(this.txtpartno_TextChanged);
            // 
            // lbkho
            // 
            this.lbkho.AutoSize = true;
            this.lbkho.Location = new System.Drawing.Point(18, 38);
            this.lbkho.Name = "lbkho";
            this.lbkho.Size = new System.Drawing.Size(53, 13);
            this.lbkho.TabIndex = 2;
            this.lbkho.Text = "Chọn kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã hàng";
            // 
            // txtpartname
            // 
            this.txtpartname.Enabled = false;
            this.txtpartname.Location = new System.Drawing.Point(440, 58);
            this.txtpartname.Name = "txtpartname";
            this.txtpartname.Size = new System.Drawing.Size(263, 20);
            this.txtpartname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btndeleteall);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtidpack);
            this.panel2.Controls.Add(this.txtpartname);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.listsearch);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbkho);
            this.panel2.Controls.Add(this.cbwarehouse);
            this.panel2.Controls.Add(this.txtpartno);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 406);
            this.panel2.TabIndex = 4;
            // 
            // btndeleteall
            // 
            this.btndeleteall.Location = new System.Drawing.Point(785, 268);
            this.btndeleteall.Name = "btndeleteall";
            this.btndeleteall.Size = new System.Drawing.Size(75, 23);
            this.btndeleteall.TabIndex = 6;
            this.btndeleteall.Text = "Xóa tất cả";
            this.btndeleteall.UseVisualStyleBackColor = true;
            this.btndeleteall.Click += new System.EventHandler(this.btndeleteall_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã thùng";
            // 
            // txtidpack
            // 
            this.txtidpack.Location = new System.Drawing.Point(85, 238);
            this.txtidpack.Name = "txtidpack";
            this.txtidpack.Size = new System.Drawing.Size(197, 20);
            this.txtidpack.TabIndex = 4;
            this.txtidpack.TextChanged += new System.EventHandler(this.txtidpack_TextChanged);
            // 
            // listsearch
            // 
            this.listsearch.FormattingEnabled = true;
            this.listsearch.Location = new System.Drawing.Point(85, 88);
            this.listsearch.Name = "listsearch";
            this.listsearch.Size = new System.Drawing.Size(197, 134);
            this.listsearch.TabIndex = 3;
            this.listsearch.Visible = false;
            this.listsearch.Click += new System.EventHandler(this.listsearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partno,
            this.partname,
            this.idpack,
            this.position,
            this.quantity});
            this.dataGridView1.Location = new System.Drawing.Point(1, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(885, 109);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // partno
            // 
            this.partno.HeaderText = "Mã hàng";
            this.partno.Name = "partno";
            // 
            // partname
            // 
            this.partname.FillWeight = 150F;
            this.partname.HeaderText = "Tên Hàng";
            this.partname.Name = "partname";
            // 
            // idpack
            // 
            this.idpack.HeaderText = "Mã thùng";
            this.idpack.Name = "idpack";
            // 
            // position
            // 
            this.position.HeaderText = "Vị trí";
            this.position.Name = "position";
            // 
            // quantity
            // 
            this.quantity.FillWeight = 60F;
            this.quantity.HeaderText = "Số lượng";
            this.quantity.Name = "quantity";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txtsumqty);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 406);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(885, 99);
            this.panel5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng";
            // 
            // txtsumqty
            // 
            this.txtsumqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsumqty.Location = new System.Drawing.Point(90, 17);
            this.txtsumqty.Multiline = true;
            this.txtsumqty.Name = "txtsumqty";
            this.txtsumqty.Size = new System.Drawing.Size(141, 34);
            this.txtsumqty.TabIndex = 1;
            // 
            // checkinventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 505);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "checkinventory";
            this.Text = "checkinventory";
            this.Load += new System.EventHandler(this.checkinventory_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbwarehouse;
        private System.Windows.Forms.TextBox txtpartno;
        private System.Windows.Forms.Label lbkho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpartname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partno;
        private System.Windows.Forms.DataGridViewTextBoxColumn partname;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpack;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsumqty;
        private System.Windows.Forms.ListBox listsearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtidpack;
        private System.Windows.Forms.Button btndeleteall;
    }
}