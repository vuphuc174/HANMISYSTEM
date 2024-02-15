namespace HANMISYSTEM.Views.Systems
{
    partial class AboutVersion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutVersion));
            this.lbheader = new System.Windows.Forms.Label();
            this.lbnew = new System.Windows.Forms.Label();
            this.lbcurrent = new System.Windows.Forms.Label();
            this.labelnew = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new HANMISYSTEM.Module.MyButton();
            this.btnCheckUpdate = new HANMISYSTEM.Module.MyButton();
            this.SuspendLayout();
            // 
            // lbheader
            // 
            this.lbheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbheader.Location = new System.Drawing.Point(117, 36);
            this.lbheader.Name = "lbheader";
            this.lbheader.Size = new System.Drawing.Size(285, 67);
            this.lbheader.TabIndex = 11;
            this.lbheader.Text = "A New Version is Available.\r\nDo you want to Update ?\r\n";
            this.lbheader.Visible = false;
            // 
            // lbnew
            // 
            this.lbnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnew.Location = new System.Drawing.Point(272, 173);
            this.lbnew.Name = "lbnew";
            this.lbnew.Size = new System.Drawing.Size(66, 20);
            this.lbnew.TabIndex = 10;
            this.lbnew.Text = "1.0.0.0";
            this.lbnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbcurrent
            // 
            this.lbcurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcurrent.Location = new System.Drawing.Point(272, 129);
            this.lbcurrent.Name = "lbcurrent";
            this.lbcurrent.Size = new System.Drawing.Size(66, 20);
            this.lbcurrent.TabIndex = 9;
            this.lbcurrent.Text = "1.0.0.0";
            this.lbcurrent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelnew
            // 
            this.labelnew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnew.Location = new System.Drawing.Point(118, 171);
            this.labelnew.Name = "labelnew";
            this.labelnew.Size = new System.Drawing.Size(149, 20);
            this.labelnew.TabIndex = 8;
            this.labelnew.Text = "New Version Available :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Current Version : ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btnUpdate.Location = new System.Drawing.Point(292, 238);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 38);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCheckUpdate
            // 
            this.btnCheckUpdate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCheckUpdate.FlatAppearance.BorderSize = 0;
            this.btnCheckUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btnCheckUpdate.Location = new System.Drawing.Point(121, 238);
            this.btnCheckUpdate.Name = "btnCheckUpdate";
            this.btnCheckUpdate.Size = new System.Drawing.Size(130, 38);
            this.btnCheckUpdate.TabIndex = 0;
            this.btnCheckUpdate.Text = "Check for update";
            this.btnCheckUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckUpdate.UseVisualStyleBackColor = false;
            this.btnCheckUpdate.Click += new System.EventHandler(this.btnCheckUpdate_Click);
            // 
            // AboutVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 333);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbheader);
            this.Controls.Add(this.lbnew);
            this.Controls.Add(this.lbcurrent);
            this.Controls.Add(this.labelnew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckUpdate);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AboutVersion";
            this.Text = "Thông tin phiên bản";
            this.Load += new System.EventHandler(this.AboutVersion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Module.MyButton btnCheckUpdate;
        private System.Windows.Forms.Label lbheader;
        private System.Windows.Forms.Label lbnew;
        private System.Windows.Forms.Label lbcurrent;
        private System.Windows.Forms.Label labelnew;
        private System.Windows.Forms.Label label1;
        private Module.MyButton btnUpdate;
    }
}