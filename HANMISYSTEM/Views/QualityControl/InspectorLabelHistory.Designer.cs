namespace HANMISYSTEM.Views.QualityControl
{
    partial class InspectorLabelHistory
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MACAddress_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Judge_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InspectTime_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFilter = new HANMISYSTEM.Module.MyButton();
            this.txtSearchTerm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbJudge = new System.Windows.Forms.ComboBox();
            this.cbbDepartment = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbRowCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbOKCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbNGCount = new System.Windows.Forms.Label();
            this.chkTime = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1239, 588);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 462);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_col,
            this.MACAddress_col,
            this.Judge_col,
            this.InspectTime_col,
            this.Remark_col});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1233, 462);
            this.dataGridView1.TabIndex = 1;
            // 
            // ID_col
            // 
            this.ID_col.DataPropertyName = "id";
            this.ID_col.FillWeight = 30F;
            this.ID_col.HeaderText = "No";
            this.ID_col.Name = "ID_col";
            this.ID_col.ReadOnly = true;
            // 
            // MACAddress_col
            // 
            this.MACAddress_col.DataPropertyName = "MACAddress";
            this.MACAddress_col.FillWeight = 40F;
            this.MACAddress_col.HeaderText = "MAC Address";
            this.MACAddress_col.Name = "MACAddress_col";
            this.MACAddress_col.ReadOnly = true;
            // 
            // Judge_col
            // 
            this.Judge_col.DataPropertyName = "Judge";
            this.Judge_col.HeaderText = "Đánh giá";
            this.Judge_col.Name = "Judge_col";
            this.Judge_col.ReadOnly = true;
            // 
            // InspectTime_col
            // 
            this.InspectTime_col.DataPropertyName = "InspectTime";
            this.InspectTime_col.HeaderText = "Thời gian";
            this.InspectTime_col.Name = "InspectTime_col";
            this.InspectTime_col.ReadOnly = true;
            // 
            // Remark_col
            // 
            this.Remark_col.DataPropertyName = "Remark";
            this.Remark_col.FillWeight = 60F;
            this.Remark_col.HeaderText = "Ghi chú";
            this.Remark_col.Name = "Remark_col";
            this.Remark_col.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkTime);
            this.panel2.Controls.Add(this.toDate);
            this.panel2.Controls.Add(this.fromDate);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtSearchTerm);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbbJudge);
            this.panel2.Controls.Add(this.cbbDepartment);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1233, 64);
            this.panel2.TabIndex = 1;
            // 
            // toDate
            // 
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDate.Location = new System.Drawing.Point(725, 28);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(96, 25);
            this.toDate.TabIndex = 7;
            // 
            // fromDate
            // 
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDate.Location = new System.Drawing.Point(598, 28);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(96, 25);
            this.fromDate.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnFilter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1124, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(109, 64);
            this.panel3.TabIndex = 6;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.ForeColor = System.Drawing.Color.Black;
            this.btnFilter.Location = new System.Drawing.Point(26, 28);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(61, 25);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filter";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtSearchTerm
            // 
            this.txtSearchTerm.Location = new System.Drawing.Point(239, 29);
            this.txtSearchTerm.Name = "txtSearchTerm";
            this.txtSearchTerm.Size = new System.Drawing.Size(189, 25);
            this.txtSearchTerm.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "MAC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(700, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "~";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đánh giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bộ phận:";
            // 
            // cbbJudge
            // 
            this.cbbJudge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbJudge.FormattingEnabled = true;
            this.cbbJudge.Location = new System.Drawing.Point(443, 29);
            this.cbbJudge.Name = "cbbJudge";
            this.cbbJudge.Size = new System.Drawing.Size(129, 25);
            this.cbbJudge.TabIndex = 0;
            // 
            // cbbDepartment
            // 
            this.cbbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDepartment.FormattingEnabled = true;
            this.cbbDepartment.Location = new System.Drawing.Point(38, 28);
            this.cbbDepartment.Name = "cbbDepartment";
            this.cbbDepartment.Size = new System.Drawing.Size(183, 25);
            this.cbbDepartment.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 541);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1233, 44);
            this.panel4.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.lbRowCount);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.lbOKCount);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.lbNGCount);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1233, 44);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 44);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số dòng:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRowCount
            // 
            this.lbRowCount.Location = new System.Drawing.Point(84, 0);
            this.lbRowCount.Name = "lbRowCount";
            this.lbRowCount.Size = new System.Drawing.Size(75, 44);
            this.lbRowCount.TabIndex = 1;
            this.lbRowCount.Text = "0";
            this.lbRowCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(165, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 44);
            this.label7.TabIndex = 2;
            this.label7.Text = "OK:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbOKCount
            // 
            this.lbOKCount.Location = new System.Drawing.Point(246, 0);
            this.lbOKCount.Name = "lbOKCount";
            this.lbOKCount.Size = new System.Drawing.Size(75, 44);
            this.lbOKCount.TabIndex = 3;
            this.lbOKCount.Text = "0";
            this.lbOKCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(327, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 44);
            this.label8.TabIndex = 4;
            this.label8.Text = "NG:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNGCount
            // 
            this.lbNGCount.Location = new System.Drawing.Point(408, 0);
            this.lbNGCount.Name = "lbNGCount";
            this.lbNGCount.Size = new System.Drawing.Size(75, 44);
            this.lbNGCount.TabIndex = 5;
            this.lbNGCount.Text = "0";
            this.lbNGCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkTime
            // 
            this.chkTime.AutoSize = true;
            this.chkTime.Location = new System.Drawing.Point(598, 3);
            this.chkTime.Name = "chkTime";
            this.chkTime.Size = new System.Drawing.Size(115, 23);
            this.chkTime.TabIndex = 8;
            this.chkTime.Text = "Toàn thời gian";
            this.chkTime.UseVisualStyleBackColor = true;
            // 
            // InspectorLabelHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1239, 588);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InspectorLabelHistory";
            this.Text = "InspectorLabelHistory";
            this.Load += new System.EventHandler(this.InspectorLabelHistory_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbDepartment;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearchTerm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Module.MyButton btnFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbJudge;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACAddress_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Judge_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn InspectTime_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark_col;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbRowCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbOKCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbNGCount;
        private System.Windows.Forms.CheckBox chkTime;
    }
}