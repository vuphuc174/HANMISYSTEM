namespace HANMISYSTEM
{
    partial class StockMgt
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbwarehouse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexcel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnb = new System.Windows.Forms.Button();
            this.btna = new System.Windows.Forms.Button();
            this.txtsumqty = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(39, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(760, 548);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbwarehouse);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnexcel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnb);
            this.panel1.Controls.Add(this.btna);
            this.panel1.Location = new System.Drawing.Point(58, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 55);
            this.panel1.TabIndex = 8;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(489, 19);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(167, 20);
            this.txtsearch.TabIndex = 13;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Search";
            // 
            // cbwarehouse
            // 
            this.cbwarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbwarehouse.FormattingEnabled = true;
            this.cbwarehouse.Location = new System.Drawing.Point(84, 15);
            this.cbwarehouse.Name = "cbwarehouse";
            this.cbwarehouse.Size = new System.Drawing.Size(121, 21);
            this.cbwarehouse.TabIndex = 7;
            this.cbwarehouse.SelectedIndexChanged += new System.EventHandler(this.cbwarehouse_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kho";
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(663, 17);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(75, 23);
            this.btnexcel.TabIndex = 12;
            this.btnexcel.Text = "Excel";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Loại hiển thị";
            // 
            // btnb
            // 
            this.btnb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnb.Location = new System.Drawing.Point(345, 17);
            this.btnb.Name = "btnb";
            this.btnb.Size = new System.Drawing.Size(64, 23);
            this.btnb.TabIndex = 10;
            this.btnb.Text = "Mã thùng";
            this.btnb.UseVisualStyleBackColor = true;
            this.btnb.Click += new System.EventHandler(this.btnb_Click);
            // 
            // btna
            // 
            this.btna.BackColor = System.Drawing.SystemColors.Control;
            this.btna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btna.Location = new System.Drawing.Point(283, 17);
            this.btna.Name = "btna";
            this.btna.Size = new System.Drawing.Size(64, 23);
            this.btna.TabIndex = 11;
            this.btna.Text = "Mặt hàng";
            this.btna.UseVisualStyleBackColor = false;
            this.btna.Click += new System.EventHandler(this.btna_Click);
            // 
            // txtsumqty
            // 
            this.txtsumqty.Location = new System.Drawing.Point(699, 639);
            this.txtsumqty.Name = "txtsumqty";
            this.txtsumqty.Size = new System.Drawing.Size(100, 20);
            this.txtsumqty.TabIndex = 9;
            // 
            // StockMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 671);
            this.Controls.Add(this.txtsumqty);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockMgt";
            this.Text = "StockMgt";
            this.Load += new System.EventHandler(this.StockMgt_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StockMgt_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbwarehouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnb;
        private System.Windows.Forms.Button btna;
        private System.Windows.Forms.TextBox txtsumqty;
    }
}