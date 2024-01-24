namespace HANMISYSTEM.Views.Credential
{
    partial class AddNewCredential
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUserGroupID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoleID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new HANMISYSTEM.Module.MyButton();
            this.btnUserGroupSearch = new HANMISYSTEM.Module.MyButton();
            this.btnRoleSearch = new HANMISYSTEM.Module.MyButton();
            this.btnOK = new HANMISYSTEM.Module.MyButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 39);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thêm phân quyền mới";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(469, 268);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnUserGroupSearch);
            this.panel3.Controls.Add(this.btnRoleSearch);
            this.panel3.Controls.Add(this.btnOK);
            this.panel3.Controls.Add(this.txtUserGroupID);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtRoleID);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(459, 258);
            this.panel3.TabIndex = 0;
            // 
            // txtUserGroupID
            // 
            this.txtUserGroupID.Location = new System.Drawing.Point(147, 106);
            this.txtUserGroupID.Name = "txtUserGroupID";
            this.txtUserGroupID.Size = new System.Drawing.Size(232, 25);
            this.txtUserGroupID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "UserGroupID:";
            // 
            // txtRoleID
            // 
            this.txtRoleID.Location = new System.Drawing.Point(147, 54);
            this.txtRoleID.Name = "txtRoleID";
            this.txtRoleID.Size = new System.Drawing.Size(232, 25);
            this.txtRoleID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "RoleID:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(289, 183);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Đóng";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUserGroupSearch
            // 
            this.btnUserGroupSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnUserGroupSearch.FlatAppearance.BorderSize = 0;
            this.btnUserGroupSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserGroupSearch.ForeColor = System.Drawing.Color.Black;
            this.btnUserGroupSearch.Location = new System.Drawing.Point(385, 106);
            this.btnUserGroupSearch.Name = "btnUserGroupSearch";
            this.btnUserGroupSearch.Size = new System.Drawing.Size(30, 25);
            this.btnUserGroupSearch.TabIndex = 2;
            this.btnUserGroupSearch.Text = "...";
            this.btnUserGroupSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserGroupSearch.UseVisualStyleBackColor = false;
            this.btnUserGroupSearch.Click += new System.EventHandler(this.btnUserGroupSearch_Click);
            // 
            // btnRoleSearch
            // 
            this.btnRoleSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnRoleSearch.FlatAppearance.BorderSize = 0;
            this.btnRoleSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleSearch.ForeColor = System.Drawing.Color.Black;
            this.btnRoleSearch.Location = new System.Drawing.Point(385, 54);
            this.btnRoleSearch.Name = "btnRoleSearch";
            this.btnRoleSearch.Size = new System.Drawing.Size(30, 25);
            this.btnRoleSearch.TabIndex = 2;
            this.btnRoleSearch.Text = "...";
            this.btnRoleSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoleSearch.UseVisualStyleBackColor = false;
            this.btnRoleSearch.Click += new System.EventHandler(this.btnRoleSearch_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(366, 183);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(49, 28);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // AddNewCredential
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(203)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(469, 307);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewCredential";
            this.Text = "AddNewCredential";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private Module.MyButton btnClose;
        private Module.MyButton btnOK;
        private System.Windows.Forms.TextBox txtUserGroupID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoleID;
        private System.Windows.Forms.Label label1;
        private Module.MyButton btnUserGroupSearch;
        private Module.MyButton btnRoleSearch;
    }
}