namespace HANMISYSTEM.Views
{
    partial class ReleaseAndReceiveHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnend = new System.Windows.Forms.Button();
            this.txtpagenumber = new System.Windows.Forms.TextBox();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnpre = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.cbfilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbwarehouse = new System.Windows.Forms.ComboBox();
            this.txtidpack = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idinvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outwarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inwarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.package = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnprint = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnend);
            this.panel1.Controls.Add(this.txtpagenumber);
            this.panel1.Controls.Add(this.btnfirst);
            this.panel1.Controls.Add(this.btnpre);
            this.panel1.Controls.Add(this.btnnext);
            this.panel1.Location = new System.Drawing.Point(51, 548);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 50);
            this.panel1.TabIndex = 19;
            this.panel1.Visible = false;
            // 
            // btnend
            // 
            this.btnend.Location = new System.Drawing.Point(156, 16);
            this.btnend.Name = "btnend";
            this.btnend.Size = new System.Drawing.Size(33, 23);
            this.btnend.TabIndex = 8;
            this.btnend.Text = ">|";
            this.btnend.UseVisualStyleBackColor = true;
            this.btnend.Click += new System.EventHandler(this.btnend_Click);
            // 
            // txtpagenumber
            // 
            this.txtpagenumber.Location = new System.Drawing.Point(82, 18);
            this.txtpagenumber.Name = "txtpagenumber";
            this.txtpagenumber.Size = new System.Drawing.Size(36, 20);
            this.txtpagenumber.TabIndex = 9;
            this.txtpagenumber.Text = "1";
            this.txtpagenumber.TextChanged += new System.EventHandler(this.txtpagenumber_TextChanged);
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(10, 16);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(33, 23);
            this.btnfirst.TabIndex = 8;
            this.btnfirst.Text = "|<";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnpre
            // 
            this.btnpre.Location = new System.Drawing.Point(45, 16);
            this.btnpre.Name = "btnpre";
            this.btnpre.Size = new System.Drawing.Size(33, 23);
            this.btnpre.TabIndex = 8;
            this.btnpre.Text = "<";
            this.btnpre.UseVisualStyleBackColor = true;
            this.btnpre.Click += new System.EventHandler(this.btnpre_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(121, 16);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(33, 23);
            this.btnnext.TabIndex = 8;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // cbfilter
            // 
            this.cbfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfilter.Enabled = false;
            this.cbfilter.FormattingEnabled = true;
            this.cbfilter.Items.AddRange(new object[] {
            "IN",
            "OUT"});
            this.cbfilter.Location = new System.Drawing.Point(296, 54);
            this.cbfilter.Name = "cbfilter";
            this.cbfilter.Size = new System.Drawing.Size(45, 21);
            this.cbfilter.TabIndex = 17;
            this.cbfilter.SelectedIndexChanged += new System.EventHandler(this.cbfilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Warehouse";
            // 
            // cbwarehouse
            // 
            this.cbwarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbwarehouse.FormattingEnabled = true;
            this.cbwarehouse.Location = new System.Drawing.Point(160, 54);
            this.cbwarehouse.Name = "cbwarehouse";
            this.cbwarehouse.Size = new System.Drawing.Size(121, 21);
            this.cbwarehouse.TabIndex = 13;
            this.cbwarehouse.SelectedIndexChanged += new System.EventHandler(this.cbwarehouse_SelectedIndexChanged);
            this.cbwarehouse.Click += new System.EventHandler(this.cbwarehouse_Click);
            // 
            // txtidpack
            // 
            this.txtidpack.Location = new System.Drawing.Point(411, 54);
            this.txtidpack.Name = "txtidpack";
            this.txtidpack.Size = new System.Drawing.Size(154, 20);
            this.txtidpack.TabIndex = 12;
            this.txtidpack.TextChanged += new System.EventHandler(this.txtidpack_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.STT,
            this.idinvoice,
            this.outwarehouse,
            this.inwarehouse,
            this.package,
            this.dateio});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.Format = "N0";
            dataGridViewCellStyle12.NullValue = "0";
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.Location = new System.Drawing.Point(45, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(868, 461);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // select
            // 
            this.select.FillWeight = 50F;
            this.select.HeaderText = "Select";
            this.select.Name = "select";
            // 
            // STT
            // 
            this.STT.DataPropertyName = "r";
            this.STT.FillWeight = 40F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // idinvoice
            // 
            this.idinvoice.DataPropertyName = "idslipout";
            this.idinvoice.HeaderText = "Invoice";
            this.idinvoice.Name = "idinvoice";
            // 
            // outwarehouse
            // 
            this.outwarehouse.DataPropertyName = "warehouse";
            this.outwarehouse.HeaderText = "From";
            this.outwarehouse.Name = "outwarehouse";
            // 
            // inwarehouse
            // 
            this.inwarehouse.DataPropertyName = "customer";
            this.inwarehouse.HeaderText = "TO";
            this.inwarehouse.Name = "inwarehouse";
            // 
            // package
            // 
            this.package.DataPropertyName = "packqty";
            this.package.FillWeight = 70F;
            this.package.HeaderText = "Package Q\'ty";
            this.package.Name = "package";
            this.package.ReadOnly = true;
            // 
            // dateio
            // 
            this.dateio.DataPropertyName = "dateout";
            dataGridViewCellStyle11.Format = "g";
            dataGridViewCellStyle11.NullValue = null;
            this.dateio.DefaultCellStyle = dataGridViewCellStyle11;
            this.dateio.HeaderText = "Date";
            this.dateio.Name = "dateio";
            // 
            // btnprint
            // 
            this.btnprint.Image = global::HANMISYSTEM.Properties.Resources.print;
            this.btnprint.Location = new System.Drawing.Point(860, 41);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(53, 34);
            this.btnprint.TabIndex = 20;
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // ReleaseAndReceiveHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 651);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbfilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbwarehouse);
            this.Controls.Add(this.txtidpack);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReleaseAndReceiveHistory";
            this.Text = "ReleaseAndReceiveHistory";
            this.Load += new System.EventHandler(this.ReleaseAndReceiveHistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnend;
        private System.Windows.Forms.TextBox txtpagenumber;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnpre;
        private System.Windows.Forms.Button btnnext;
        public System.Windows.Forms.ComboBox cbfilter;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbwarehouse;
        public System.Windows.Forms.TextBox txtidpack;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn outwarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn inwarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn package;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateio;
    }
}