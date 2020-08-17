namespace HANMISYSTEM
{
    partial class Usermgt
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namewarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameposition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbposition = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.cbdepartment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 378);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách user";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.username,
            this.name,
            this.namewarehouse,
            this.nameposition});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(477, 359);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Select
            // 
            this.Select.FillWeight = 60F;
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "User";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // namewarehouse
            // 
            this.namewarehouse.DataPropertyName = "namewarehouse";
            this.namewarehouse.HeaderText = "Department";
            this.namewarehouse.Name = "namewarehouse";
            this.namewarehouse.ReadOnly = true;
            // 
            // nameposition
            // 
            this.nameposition.DataPropertyName = "nameposition";
            this.nameposition.HeaderText = "Position";
            this.nameposition.Name = "nameposition";
            this.nameposition.ReadOnly = true;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(84, 18);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(154, 20);
            this.txtusername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // cbposition
            // 
            this.cbposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbposition.FormattingEnabled = true;
            this.cbposition.Location = new System.Drawing.Point(84, 147);
            this.cbposition.Name = "cbposition";
            this.cbposition.Size = new System.Drawing.Size(154, 21);
            this.cbposition.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.cbdepartment);
            this.panel1.Controls.Add(this.cbposition);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Location = new System.Drawing.Point(513, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 359);
            this.panel1.TabIndex = 4;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(84, 187);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(89, 25);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(180, 187);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(89, 25);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // cbdepartment
            // 
            this.cbdepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdepartment.FormattingEnabled = true;
            this.cbdepartment.Location = new System.Drawing.Point(84, 113);
            this.cbdepartment.Name = "cbdepartment";
            this.cbdepartment.Size = new System.Drawing.Size(154, 21);
            this.cbdepartment.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(84, 49);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(154, 20);
            this.txtpassword.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(84, 80);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(154, 20);
            this.txtname.TabIndex = 2;
            // 
            // btndelete
            // 
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Location = new System.Drawing.Point(401, 30);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Usermgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 462);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usermgt";
            this.Text = "Permission";
            this.Load += new System.EventHandler(this.Usermgt_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbposition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.ComboBox cbdepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn namewarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameposition;
        private System.Windows.Forms.Button btndelete;
    }
}