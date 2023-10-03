namespace HANMISYSTEM.Views.Producs
{
    partial class CheckProductInv_POPUP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckProductInv_POPUP));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPartno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnCheckCondition = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConfirm_Delete = new HANMISYSTEM.Module.MyButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbPartno);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 48);
            this.panel1.TabIndex = 0;
            // 
            // lbPartno
            // 
            this.lbPartno.AutoSize = true;
            this.lbPartno.Location = new System.Drawing.Point(175, 18);
            this.lbPartno.Name = "lbPartno";
            this.lbPartno.Size = new System.Drawing.Size(20, 18);
            this.lbPartno.TabIndex = 0;
            this.lbPartno.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xác nhận xoá mã hàng  ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnCheckCondition);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 410);
            this.panel2.TabIndex = 1;
            // 
            // pnCheckCondition
            // 
            this.pnCheckCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCheckCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCheckCondition.Location = new System.Drawing.Point(0, 0);
            this.pnCheckCondition.Name = "pnCheckCondition";
            this.pnCheckCondition.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pnCheckCondition.Size = new System.Drawing.Size(716, 346);
            this.pnCheckCondition.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnConfirm_Delete);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 346);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(716, 64);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnConfirm_Delete
            // 
            this.btnConfirm_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(250)))));
            this.btnConfirm_Delete.FlatAppearance.BorderSize = 0;
            this.btnConfirm_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm_Delete.ForeColor = System.Drawing.Color.White;
            this.btnConfirm_Delete.Location = new System.Drawing.Point(566, 19);
            this.btnConfirm_Delete.Name = "btnConfirm_Delete";
            this.btnConfirm_Delete.Size = new System.Drawing.Size(121, 33);
            this.btnConfirm_Delete.TabIndex = 0;
            this.btnConfirm_Delete.Text = "Xác nhận";
            this.btnConfirm_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm_Delete.UseVisualStyleBackColor = false;
            this.btnConfirm_Delete.Click += new System.EventHandler(this.btnConfirm_Delete_Click);
            // 
            // CheckProductInv_POPUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(716, 458);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CheckProductInv_POPUP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckProductInv_POPUP";
            this.Load += new System.EventHandler(this.CheckProductInv_POPUP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnCheckCondition;
        private System.Windows.Forms.Panel panel3;
        private Module.MyButton btnConfirm_Delete;
        private System.Windows.Forms.Label lbPartno;
    }
}