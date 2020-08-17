namespace HANMISYSTEM.Views
{
    partial class ChangeBoxQty
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
            this.txtpartname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtpartno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtwarehouse = new System.Windows.Forms.TextBox();
            this.txtidpack = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hàng";
            // 
            // txtpartname
            // 
            this.txtpartname.Location = new System.Drawing.Point(154, 171);
            this.txtpartname.Name = "txtpartname";
            this.txtpartname.ReadOnly = true;
            this.txtpartname.Size = new System.Drawing.Size(177, 20);
            this.txtpartname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lượng";
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(154, 209);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(177, 20);
            this.txtquantity.TabIndex = 2;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(154, 245);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 29);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Lưu";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtpartno
            // 
            this.txtpartno.Enabled = false;
            this.txtpartno.Location = new System.Drawing.Point(154, 135);
            this.txtpartno.Name = "txtpartno";
            this.txtpartno.ReadOnly = true;
            this.txtpartno.Size = new System.Drawing.Size(177, 20);
            this.txtpartno.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã đóng gói";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kho";
            // 
            // txtwarehouse
            // 
            this.txtwarehouse.Location = new System.Drawing.Point(154, 98);
            this.txtwarehouse.Name = "txtwarehouse";
            this.txtwarehouse.ReadOnly = true;
            this.txtwarehouse.Size = new System.Drawing.Size(177, 20);
            this.txtwarehouse.TabIndex = 2;
            // 
            // txtidpack
            // 
            this.txtidpack.Location = new System.Drawing.Point(154, 62);
            this.txtidpack.Name = "txtidpack";
            this.txtidpack.Size = new System.Drawing.Size(177, 20);
            this.txtidpack.TabIndex = 4;
            this.txtidpack.TextChanged += new System.EventHandler(this.txtidpack_TextChanged);
            // 
            // ChangeBoxQty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 339);
            this.Controls.Add(this.txtidpack);
            this.Controls.Add(this.txtpartno);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtwarehouse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpartname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeBoxQty";
            this.Text = "ChangeBoxQty";
            this.Load += new System.EventHandler(this.ChangeBoxQty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpartname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtpartno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtwarehouse;
        private System.Windows.Forms.TextBox txtidpack;
    }
}