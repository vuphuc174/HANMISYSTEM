namespace HANMISYSTEM
{
    partial class OverAnalysis
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
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastmonthinventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inother = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inproduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outother = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Outproduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentinventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbwarehouse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Partno,
            this.lastmonthinventory,
            this.inother,
            this.Inproduction,
            this.outother,
            this.Outproduction,
            this.ng,
            this.lost,
            this.currentinventory,
            this.rate});
            this.dataGridView1.Location = new System.Drawing.Point(29, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(891, 318);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "hang";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // Partno
            // 
            this.Partno.DataPropertyName = "partno";
            this.Partno.HeaderText = "Partno";
            this.Partno.Name = "Partno";
            this.Partno.ReadOnly = true;
            // 
            // lastmonthinventory
            // 
            this.lastmonthinventory.HeaderText = "Last month Inventory";
            this.lastmonthinventory.Name = "lastmonthinventory";
            this.lastmonthinventory.ReadOnly = true;
            // 
            // inother
            // 
            this.inother.DataPropertyName = "qty";
            this.inother.HeaderText = "In Other";
            this.inother.Name = "inother";
            this.inother.ReadOnly = true;
            // 
            // Inproduction
            // 
            this.Inproduction.DataPropertyName = "quantity";
            this.Inproduction.HeaderText = "In production";
            this.Inproduction.Name = "Inproduction";
            this.Inproduction.ReadOnly = true;
            // 
            // outother
            // 
            this.outother.HeaderText = "Out other";
            this.outother.Name = "outother";
            this.outother.ReadOnly = true;
            // 
            // Outproduction
            // 
            this.Outproduction.HeaderText = "Out production";
            this.Outproduction.Name = "Outproduction";
            this.Outproduction.ReadOnly = true;
            // 
            // ng
            // 
            this.ng.HeaderText = "NG";
            this.ng.Name = "ng";
            this.ng.ReadOnly = true;
            // 
            // lost
            // 
            this.lost.HeaderText = "Lost";
            this.lost.Name = "lost";
            this.lost.ReadOnly = true;
            // 
            // currentinventory
            // 
            this.currentinventory.HeaderText = "Current Inventory";
            this.currentinventory.Name = "currentinventory";
            this.currentinventory.ReadOnly = true;
            // 
            // rate
            // 
            this.rate.HeaderText = "Rate";
            this.rate.Name = "rate";
            this.rate.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(24, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 100);
            this.panel1.TabIndex = 2;
            // 
            // cbwarehouse
            // 
            this.cbwarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbwarehouse.FormattingEnabled = true;
            this.cbwarehouse.Location = new System.Drawing.Point(63, 24);
            this.cbwarehouse.Name = "cbwarehouse";
            this.cbwarehouse.Size = new System.Drawing.Size(121, 21);
            this.cbwarehouse.TabIndex = 3;
            this.cbwarehouse.SelectedIndexChanged += new System.EventHandler(this.cbwarehouse_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "W/H";
            // 
            // OverAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbwarehouse);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OverAnalysis";
            this.Text = "CURKHOAI";
            this.Load += new System.EventHandler(this.OverAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbwarehouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partno;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastmonthinventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn inother;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inproduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn outother;
        private System.Windows.Forms.DataGridViewTextBoxColumn Outproduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ng;
        private System.Windows.Forms.DataGridViewTextBoxColumn lost;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentinventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
    }
}