namespace HANMISYSTEM.Views
{
    partial class BOMList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rawquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnfg = new System.Windows.Forms.Button();
            this.btnsemi = new System.Windows.Forms.Button();
            this.btnraw = new System.Windows.Forms.Button();
            this.btnfirstpage = new System.Windows.Forms.Button();
            this.txtpage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.llmaxpage = new System.Windows.Forms.LinkLabel();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(745, 2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(223, 20);
            this.txtsearch.TabIndex = 0;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(668, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.partno,
            this.partname,
            this.process,
            this.rawquantity});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(27, 72);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(941, 472);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // stt
            // 
            this.stt.DataPropertyName = "rowindex";
            this.stt.FillWeight = 30F;
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // partno
            // 
            this.partno.DataPropertyName = "partno";
            this.partno.HeaderText = "Mã hàng";
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
            // process
            // 
            this.process.DataPropertyName = "process";
            this.process.HeaderText = "Quy trình";
            this.process.Name = "process";
            this.process.ReadOnly = true;
            // 
            // rawquantity
            // 
            this.rawquantity.DataPropertyName = "rawquantity";
            this.rawquantity.HeaderText = "Số NVL";
            this.rawquantity.Name = "rawquantity";
            this.rawquantity.ReadOnly = true;
            // 
            // btnfg
            // 
            this.btnfg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnfg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfg.Location = new System.Drawing.Point(27, 45);
            this.btnfg.Name = "btnfg";
            this.btnfg.Size = new System.Drawing.Size(75, 28);
            this.btnfg.TabIndex = 4;
            this.btnfg.Text = "Thành phẩm";
            this.btnfg.UseVisualStyleBackColor = true;
            this.btnfg.Click += new System.EventHandler(this.btnfg_Click);
            // 
            // btnsemi
            // 
            this.btnsemi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnsemi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsemi.Location = new System.Drawing.Point(104, 45);
            this.btnsemi.Name = "btnsemi";
            this.btnsemi.Size = new System.Drawing.Size(95, 28);
            this.btnsemi.TabIndex = 4;
            this.btnsemi.Text = "Bán thành phẩm";
            this.btnsemi.UseVisualStyleBackColor = true;
            this.btnsemi.Click += new System.EventHandler(this.btnsemi_Click);
            // 
            // btnraw
            // 
            this.btnraw.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnraw.Location = new System.Drawing.Point(201, 45);
            this.btnraw.Name = "btnraw";
            this.btnraw.Size = new System.Drawing.Size(96, 28);
            this.btnraw.TabIndex = 4;
            this.btnraw.Text = "Nguyên vật liệu";
            this.btnraw.UseVisualStyleBackColor = true;
            this.btnraw.Click += new System.EventHandler(this.btnraw_Click);
            // 
            // btnfirstpage
            // 
            this.btnfirstpage.Location = new System.Drawing.Point(349, 43);
            this.btnfirstpage.Name = "btnfirstpage";
            this.btnfirstpage.Size = new System.Drawing.Size(33, 23);
            this.btnfirstpage.TabIndex = 5;
            this.btnfirstpage.Text = "1";
            this.btnfirstpage.UseVisualStyleBackColor = true;
            this.btnfirstpage.Click += new System.EventHandler(this.btnfirstpage_Click);
            // 
            // txtpage
            // 
            this.txtpage.Location = new System.Drawing.Point(466, 43);
            this.txtpage.Name = "txtpage";
            this.txtpage.Size = new System.Drawing.Size(47, 20);
            this.txtpage.TabIndex = 6;
            this.txtpage.TextChanged += new System.EventHandler(this.txtpage_TextChanged);
            this.txtpage.Enter += new System.EventHandler(this.txtpage_Enter);
            this.txtpage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpage_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "/";
            // 
            // llmaxpage
            // 
            this.llmaxpage.AutoSize = true;
            this.llmaxpage.Location = new System.Drawing.Point(537, 46);
            this.llmaxpage.Name = "llmaxpage";
            this.llmaxpage.Size = new System.Drawing.Size(13, 13);
            this.llmaxpage.TabIndex = 8;
            this.llmaxpage.TabStop = true;
            this.llmaxpage.Text = "1";
            this.llmaxpage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llmaxpage_LinkClicked);
            // 
            // btnprevious
            // 
            this.btnprevious.Location = new System.Drawing.Point(388, 43);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(33, 23);
            this.btnprevious.TabIndex = 5;
            this.btnprevious.Text = "<";
            this.btnprevious.UseVisualStyleBackColor = true;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(427, 43);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(33, 23);
            this.btnnext.TabIndex = 5;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // BOMList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 556);
            this.Controls.Add(this.llmaxpage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpage);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.btnfirstpage);
            this.Controls.Add(this.btnraw);
            this.Controls.Add(this.btnsemi);
            this.Controls.Add(this.btnfg);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BOMList";
            this.Text = "BOMList";
            this.Load += new System.EventHandler(this.BOMList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnfg;
        private System.Windows.Forms.Button btnsemi;
        private System.Windows.Forms.Button btnraw;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn partno;
        private System.Windows.Forms.DataGridViewTextBoxColumn partname;
        private System.Windows.Forms.DataGridViewTextBoxColumn process;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawquantity;
        private System.Windows.Forms.Button btnfirstpage;
        private System.Windows.Forms.TextBox txtpage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llmaxpage;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnnext;
    }
}