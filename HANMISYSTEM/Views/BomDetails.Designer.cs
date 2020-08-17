namespace HANMISYSTEM
{
    partial class BomDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BomDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbpartno = new System.Windows.Forms.Label();
            this.lbpartname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbrawqty = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnexcel = new System.Windows.Forms.Button();
            this.btnbomtong = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Partno :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Partname :";
            // 
            // lbpartno
            // 
            this.lbpartno.AutoSize = true;
            this.lbpartno.Location = new System.Drawing.Point(97, 13);
            this.lbpartno.Name = "lbpartno";
            this.lbpartno.Size = new System.Drawing.Size(31, 13);
            this.lbpartno.TabIndex = 3;
            this.lbpartno.Text = "none";
            // 
            // lbpartname
            // 
            this.lbpartname.AutoSize = true;
            this.lbpartname.Location = new System.Drawing.Point(97, 35);
            this.lbpartname.Name = "lbpartname";
            this.lbpartname.Size = new System.Drawing.Size(31, 13);
            this.lbpartname.TabIndex = 4;
            this.lbpartname.Text = "none";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số nguyên vật liệu :";
            // 
            // lbrawqty
            // 
            this.lbrawqty.AutoSize = true;
            this.lbrawqty.Location = new System.Drawing.Point(380, 13);
            this.lbrawqty.Name = "lbrawqty";
            this.lbrawqty.Size = new System.Drawing.Size(13, 13);
            this.lbrawqty.TabIndex = 5;
            this.lbrawqty.Text = "0";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(31, 89);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(683, 273);
            this.treeView1.TabIndex = 6;
            this.treeView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView1_KeyDown);
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(31, 369);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(75, 23);
            this.btnexcel.TabIndex = 7;
            this.btnexcel.Text = "EXCEL";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // btnbomtong
            // 
            this.btnbomtong.Location = new System.Drawing.Point(112, 369);
            this.btnbomtong.Name = "btnbomtong";
            this.btnbomtong.Size = new System.Drawing.Size(75, 23);
            this.btnbomtong.TabIndex = 8;
            this.btnbomtong.Text = "BOM TỔNG";
            this.btnbomtong.UseVisualStyleBackColor = true;
            // 
            // BomDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 415);
            this.Controls.Add(this.btnbomtong);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.lbrawqty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbpartname);
            this.Controls.Add(this.lbpartno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BomDetails";
            this.Text = "BomDetails";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BomDetails_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbpartno;
        public System.Windows.Forms.Label lbpartname;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lbrawqty;
        public System.Windows.Forms.TreeView treeView1;
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Button btnbomtong;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

    }
}