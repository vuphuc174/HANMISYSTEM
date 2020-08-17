namespace HANMISYSTEM
{
    partial class Location_Mgt
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtwh = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtposition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbwarehouse = new System.Windows.Forms.ComboBox();
            this.lbposition = new System.Windows.Forms.ListBox();
            this.lbnotify = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lí vị trí kho";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 36);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtwh);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Controls.Add(this.txtposition);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbwarehouse);
            this.panel2.Location = new System.Drawing.Point(2, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 147);
            this.panel2.TabIndex = 3;
            // 
            // txtwh
            // 
            this.txtwh.Enabled = false;
            this.txtwh.Location = new System.Drawing.Point(71, 52);
            this.txtwh.Name = "txtwh";
            this.txtwh.Size = new System.Drawing.Size(41, 20);
            this.txtwh.TabIndex = 4;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(152, 88);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(45, 23);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(71, 88);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtposition
            // 
            this.txtposition.Location = new System.Drawing.Point(118, 52);
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(41, 20);
            this.txtposition.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Vị trí";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kho";
            // 
            // cbwarehouse
            // 
            this.cbwarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbwarehouse.FormattingEnabled = true;
            this.cbwarehouse.Location = new System.Drawing.Point(71, 17);
            this.cbwarehouse.Name = "cbwarehouse";
            this.cbwarehouse.Size = new System.Drawing.Size(147, 21);
            this.cbwarehouse.TabIndex = 0;
            this.cbwarehouse.SelectedIndexChanged += new System.EventHandler(this.cbwarehouse_SelectedIndexChanged);
            // 
            // lbposition
            // 
            this.lbposition.FormattingEnabled = true;
            this.lbposition.Location = new System.Drawing.Point(269, 52);
            this.lbposition.Name = "lbposition";
            this.lbposition.Size = new System.Drawing.Size(348, 147);
            this.lbposition.TabIndex = 4;
            this.lbposition.Click += new System.EventHandler(this.lbposition_Click);
            // 
            // lbnotify
            // 
            this.lbnotify.ForeColor = System.Drawing.Color.Red;
            this.lbnotify.Location = new System.Drawing.Point(2, 206);
            this.lbnotify.Name = "lbnotify";
            this.lbnotify.Size = new System.Drawing.Size(615, 57);
            this.lbnotify.TabIndex = 5;
            this.lbnotify.Text = "...";
            // 
            // Location_Mgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 283);
            this.Controls.Add(this.lbnotify);
            this.Controls.Add(this.lbposition);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Location_Mgt";
            this.Text = "Quản lý vị trí kho";
            this.Load += new System.EventHandler(this.Location_Mgt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtposition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbwarehouse;
        private System.Windows.Forms.ListBox lbposition;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label lbnotify;
        private System.Windows.Forms.TextBox txtwh;
    }
}