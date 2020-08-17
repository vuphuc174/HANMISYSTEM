namespace HANMISYSTEM
{
    partial class ProductionResult
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
            this.components = new System.ComponentModel.Container();
            this.cbwarehouse = new System.Windows.Forms.ComboBox();
            this.cblocation = new System.Windows.Forms.ComboBox();
            this.txtpartno = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btncheck = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbsearch = new System.Windows.Forms.ListBox();
            this.btncheckall = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // cbwarehouse
            // 
            this.cbwarehouse.FormattingEnabled = true;
            this.cbwarehouse.Location = new System.Drawing.Point(80, 32);
            this.cbwarehouse.Name = "cbwarehouse";
            this.cbwarehouse.Size = new System.Drawing.Size(121, 21);
            this.cbwarehouse.TabIndex = 0;
            // 
            // cblocation
            // 
            this.cblocation.FormattingEnabled = true;
            this.cblocation.Location = new System.Drawing.Point(80, 59);
            this.cblocation.Name = "cblocation";
            this.cblocation.Size = new System.Drawing.Size(121, 21);
            this.cblocation.TabIndex = 0;
            // 
            // txtpartno
            // 
            this.txtpartno.Location = new System.Drawing.Point(80, 86);
            this.txtpartno.Name = "txtpartno";
            this.txtpartno.Size = new System.Drawing.Size(234, 20);
            this.txtpartno.TabIndex = 1;
            this.txtpartno.TextChanged += new System.EventHandler(this.txtpartno_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 112);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(376, 112);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Warehouse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Models";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Result";
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(80, 205);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(153, 46);
            this.txtresult.TabIndex = 1;
            // 
            // btncheck
            // 
            this.btncheck.Location = new System.Drawing.Point(80, 171);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(100, 23);
            this.btncheck.TabIndex = 4;
            this.btncheck.Text = "Check";
            this.toolTip1.SetToolTip(this.btncheck, "Check theo chuyền");
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Từ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Đến";
            // 
            // lbsearch
            // 
            this.lbsearch.FormattingEnabled = true;
            this.lbsearch.Location = new System.Drawing.Point(80, 138);
            this.lbsearch.Name = "lbsearch";
            this.lbsearch.Size = new System.Drawing.Size(234, 147);
            this.lbsearch.TabIndex = 6;
            this.lbsearch.Visible = false;
            this.lbsearch.Click += new System.EventHandler(this.lbsearch_Click);
            // 
            // btncheckall
            // 
            this.btncheckall.Location = new System.Drawing.Point(196, 170);
            this.btncheckall.Name = "btncheckall";
            this.btncheckall.Size = new System.Drawing.Size(71, 23);
            this.btncheckall.TabIndex = 7;
            this.btncheckall.Text = "Check All";
            this.toolTip1.SetToolTip(this.btncheckall, "Check tất cả các chuyền");
            this.btncheckall.UseVisualStyleBackColor = true;
            this.btncheckall.Click += new System.EventHandler(this.btncheckall_Click);
            // 
            // ProductionResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 473);
            this.Controls.Add(this.btncheckall);
            this.Controls.Add(this.lbsearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtpartno);
            this.Controls.Add(this.cblocation);
            this.Controls.Add(this.cbwarehouse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductionResult";
            this.Text = "ProductionResult";
            this.Load += new System.EventHandler(this.ProductionResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbwarehouse;
        private System.Windows.Forms.ComboBox cblocation;
        private System.Windows.Forms.TextBox txtpartno;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbsearch;
        private System.Windows.Forms.Button btncheckall;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}