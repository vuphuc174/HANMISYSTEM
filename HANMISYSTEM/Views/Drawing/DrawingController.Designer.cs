namespace HANMISYSTEM.Views.Drawing
{
    partial class DrawingController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawingController));
            this.label1 = new System.Windows.Forms.Label();
            this.txtversion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnviewdetail = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnupload = new System.Windows.Forms.Button();
            this.btndownload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.lbsearch = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model";
            // 
            // txtversion
            // 
            this.txtversion.Location = new System.Drawing.Point(126, 78);
            this.txtversion.Name = "txtversion";
            this.txtversion.Size = new System.Drawing.Size(251, 20);
            this.txtversion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "PDF File";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.axAcroPDF1);
            this.groupBox1.Location = new System.Drawing.Point(517, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 258);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Review";
            // 
            // btnviewdetail
            // 
            this.btnviewdetail.Location = new System.Drawing.Point(906, 276);
            this.btnviewdetail.Name = "btnviewdetail";
            this.btnviewdetail.Size = new System.Drawing.Size(99, 30);
            this.btnviewdetail.TabIndex = 3;
            this.btnviewdetail.Text = "Xem chi tiết >>";
            this.btnviewdetail.UseVisualStyleBackColor = true;
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(126, 164);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(107, 32);
            this.btnselect.TabIndex = 4;
            this.btnselect.Text = "Chọn File (PDF)";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(126, 124);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(251, 20);
            this.txtpath.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Version";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnupload
            // 
            this.btnupload.Location = new System.Drawing.Point(239, 164);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(95, 32);
            this.btnupload.TabIndex = 4;
            this.btnupload.Text = "Upload";
            this.btnupload.UseVisualStyleBackColor = true;
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // btndownload
            // 
            this.btndownload.Location = new System.Drawing.Point(807, 276);
            this.btndownload.Name = "btndownload";
            this.btndownload.Size = new System.Drawing.Size(93, 30);
            this.btndownload.TabIndex = 5;
            this.btndownload.Text = "Tải xuống";
            this.btndownload.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(6, 10);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(476, 242);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(126, 38);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(251, 20);
            this.txtmodel.TabIndex = 1;
            this.txtmodel.TextChanged += new System.EventHandler(this.txtmodel_TextChanged);
            // 
            // lbsearch
            // 
            this.lbsearch.FormattingEnabled = true;
            this.lbsearch.Location = new System.Drawing.Point(126, 58);
            this.lbsearch.Name = "lbsearch";
            this.lbsearch.Size = new System.Drawing.Size(140, 316);
            this.lbsearch.TabIndex = 7;
            this.lbsearch.Visible = false;
            this.lbsearch.Click += new System.EventHandler(this.lbsearch_Click);
            // 
            // DrawingController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 450);
            this.Controls.Add(this.lbsearch);
            this.Controls.Add(this.btndownload);
            this.Controls.Add(this.btnupload);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.btnviewdetail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.txtmodel);
            this.Controls.Add(this.txtversion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DrawingController";
            this.Text = "DrawingController";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtversion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnviewdetail;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnupload;
        private System.Windows.Forms.Button btndownload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.ListBox lbsearch;
    }
}