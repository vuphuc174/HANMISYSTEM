namespace HANMISYSTEM.Views.Production
{
    partial class CheckLabelHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbbLine = new System.Windows.Forms.ComboBox();
            this.txtPartno = new System.Windows.Forms.TextBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSearch = new HANMISYSTEM.Module.MyButton();
            this.ID_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partno_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partname_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Judge_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JudgeTime_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 554);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(219, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(848, 554);
            this.panel3.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 38);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(848, 516);
            this.panel7.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_col,
            this.Partno_col,
            this.Partname_col,
            this.Judge_col,
            this.JudgeTime_col,
            this.Remark_col,
            this.Line_col});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(848, 516);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(848, 38);
            this.panel6.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 554);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbbLine);
            this.panel5.Controls.Add(this.txtPartno);
            this.panel5.Controls.Add(this.dtpEndDate);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.dtpStartDate);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(217, 500);
            this.panel5.TabIndex = 4;
            // 
            // cbbLine
            // 
            this.cbbLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLine.FormattingEnabled = true;
            this.cbbLine.Location = new System.Drawing.Point(14, 111);
            this.cbbLine.Name = "cbbLine";
            this.cbbLine.Size = new System.Drawing.Size(179, 24);
            this.cbbLine.TabIndex = 3;
            // 
            // txtPartno
            // 
            this.txtPartno.Location = new System.Drawing.Point(11, 51);
            this.txtPartno.Name = "txtPartno";
            this.txtPartno.Size = new System.Drawing.Size(182, 23);
            this.txtPartno.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(11, 226);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(182, 23);
            this.dtpEndDate.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày kết thúc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày bắt đầu:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(11, 170);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(182, 23);
            this.dtpStartDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chuyền sản xuất:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 500);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(217, 52);
            this.panel4.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(89, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 29);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ID_col
            // 
            this.ID_col.DataPropertyName = "id";
            this.ID_col.HeaderText = "ID";
            this.ID_col.Name = "ID_col";
            this.ID_col.ReadOnly = true;
            // 
            // Partno_col
            // 
            this.Partno_col.DataPropertyName = "partno";
            this.Partno_col.HeaderText = "Mã hàng";
            this.Partno_col.Name = "Partno_col";
            this.Partno_col.ReadOnly = true;
            // 
            // Partname_col
            // 
            this.Partname_col.DataPropertyName = "partname";
            this.Partname_col.HeaderText = "Tên mặt hàng";
            this.Partname_col.Name = "Partname_col";
            this.Partname_col.ReadOnly = true;
            // 
            // Judge_col
            // 
            this.Judge_col.DataPropertyName = "judge";
            this.Judge_col.HeaderText = "Đánh giá";
            this.Judge_col.Name = "Judge_col";
            this.Judge_col.ReadOnly = true;
            // 
            // JudgeTime_col
            // 
            this.JudgeTime_col.DataPropertyName = "judgetime";
            this.JudgeTime_col.HeaderText = "Thời gian";
            this.JudgeTime_col.Name = "JudgeTime_col";
            this.JudgeTime_col.ReadOnly = true;
            // 
            // Remark_col
            // 
            this.Remark_col.DataPropertyName = "remark";
            this.Remark_col.HeaderText = "Ghi chú";
            this.Remark_col.Name = "Remark_col";
            this.Remark_col.ReadOnly = true;
            // 
            // Line_col
            // 
            this.Line_col.DataPropertyName = "namelocation1";
            this.Line_col.HeaderText = "Chuyền";
            this.Line_col.Name = "Line_col";
            this.Line_col.ReadOnly = true;
            // 
            // CheckLabelHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CheckLabelHistory";
            this.Text = "CheckLabelHistory";
            this.Load += new System.EventHandler(this.CheckLabelHistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbbLine;
        private System.Windows.Forms.TextBox txtPartno;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private Module.MyButton btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partno_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partname_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Judge_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn JudgeTime_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line_col;
    }
}