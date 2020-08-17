namespace HANMISYSTEM
{
    partial class packingnotify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(packingnotify));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.btnapply = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbpartno = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbidpacking = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin hãy nhập lại số lượng hợp lệ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Có vẻ số lượng đóng gói bạn vừa nhập vào không hợp lệ ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(140, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thông báo";
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(37, 186);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(107, 20);
            this.txtquantity.TabIndex = 2;
            // 
            // btnapply
            // 
            this.btnapply.Location = new System.Drawing.Point(37, 225);
            this.btnapply.Name = "btnapply";
            this.btnapply.Size = new System.Drawing.Size(75, 23);
            this.btnapply.TabIndex = 3;
            this.btnapply.Text = "Apply";
            this.btnapply.UseVisualStyleBackColor = true;
            this.btnapply.Click += new System.EventHandler(this.btnapply_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(143, 225);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "Để sau";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Có vẻ như bạn đang cố gắng thêm phương thức đóng gói cho :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Partno : ";
            // 
            // lbpartno
            // 
            this.lbpartno.AutoSize = true;
            this.lbpartno.Location = new System.Drawing.Point(97, 81);
            this.lbpartno.Name = "lbpartno";
            this.lbpartno.Size = new System.Drawing.Size(19, 13);
            this.lbpartno.TabIndex = 4;
            this.lbpartno.Text = "....";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Kiểu đóng gói";
            // 
            // lbidpacking
            // 
            this.lbidpacking.AutoSize = true;
            this.lbidpacking.Location = new System.Drawing.Point(306, 81);
            this.lbidpacking.Name = "lbidpacking";
            this.lbidpacking.Size = new System.Drawing.Size(19, 13);
            this.lbidpacking.TabIndex = 4;
            this.lbidpacking.Text = "....";
            // 
            // packingnotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 259);
            this.Controls.Add(this.lbidpacking);
            this.Controls.Add(this.lbpartno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnapply);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "packingnotify";
            this.Text = "Thông báo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtquantity;
        public System.Windows.Forms.Button btnapply;
        public System.Windows.Forms.Button btnclose;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lbpartno;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lbidpacking;

    }
}