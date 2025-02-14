namespace HANMISYSTEM.Views.Production.BravoWorkOrder
{
    partial class AddBravoWorkOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBravoWorkOrder));
            this.txtCurrentQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPartno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPartname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBravoUserID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFactory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMax = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCurrentQuantity
            // 
            this.txtCurrentQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentQuantity.Location = new System.Drawing.Point(15, 83);
            this.txtCurrentQuantity.Name = "txtCurrentQuantity";
            this.txtCurrentQuantity.Size = new System.Drawing.Size(300, 26);
            this.txtCurrentQuantity.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số lượng khả dụng:";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Blue;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(159, 131);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 28);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(240, 131);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtLine);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtFactory);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtBravoUserID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPartname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPartno);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 122);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbMax);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtCurrentQuantity);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnCreate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 229);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hàng:";
            // 
            // txtPartno
            // 
            this.txtPartno.Location = new System.Drawing.Point(15, 27);
            this.txtPartno.Name = "txtPartno";
            this.txtPartno.ReadOnly = true;
            this.txtPartno.Size = new System.Drawing.Size(252, 21);
            this.txtPartno.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên mặt hàng:";
            // 
            // txtPartname
            // 
            this.txtPartname.Location = new System.Drawing.Point(15, 78);
            this.txtPartname.Name = "txtPartname";
            this.txtPartname.ReadOnly = true;
            this.txtPartname.Size = new System.Drawing.Size(252, 21);
            this.txtPartname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chuyền sản xuất";
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(285, 27);
            this.txtLine.Name = "txtLine";
            this.txtLine.ReadOnly = true;
            this.txtLine.Size = new System.Drawing.Size(252, 21);
            this.txtLine.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã người phụ trách:";
            // 
            // txtBravoUserID
            // 
            this.txtBravoUserID.Location = new System.Drawing.Point(285, 78);
            this.txtBravoUserID.Name = "txtBravoUserID";
            this.txtBravoUserID.ReadOnly = true;
            this.txtBravoUserID.Size = new System.Drawing.Size(163, 21);
            this.txtBravoUserID.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phân xưởng:";
            // 
            // txtFactory
            // 
            this.txtFactory.Location = new System.Drawing.Point(479, 78);
            this.txtFactory.Name = "txtFactory";
            this.txtFactory.ReadOnly = true;
            this.txtFactory.Size = new System.Drawing.Size(163, 21);
            this.txtFactory.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "MAX:";
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Location = new System.Drawing.Point(235, 65);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(64, 15);
            this.lbMax.TabIndex = 4;
            this.lbMax.TabStop = true;
            this.lbMax.Text = "linkLabel1";
            this.lbMax.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbMax_LinkClicked);
            // 
            // AddBravoWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 351);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddBravoWorkOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBravoWorkOrder";
            this.Load += new System.EventHandler(this.AddBravoWorkOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrentQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBravoUserID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPartname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPartno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFactory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lbMax;
        private System.Windows.Forms.Label label7;
    }
}