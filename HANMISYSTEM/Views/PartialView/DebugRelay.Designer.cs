namespace HANMISYSTEM.Views.PartialView
{
    partial class DebugRelay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebugRelay));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbpushnotifytype = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbcom = new System.Windows.Forms.Label();
            this.lbbaudrate = new System.Windows.Forms.Label();
            this.btnCLoseCH2 = new HANMISYSTEM.Module.MyButton();
            this.btnCloseCH1 = new HANMISYSTEM.Module.MyButton();
            this.btnOpenCH2 = new HANMISYSTEM.Module.MyButton();
            this.btnOpenCH1 = new HANMISYSTEM.Module.MyButton();
            this.myButton3 = new HANMISYSTEM.Module.MyButton();
            this.myButton2 = new HANMISYSTEM.Module.MyButton();
            this.btnReadStatus = new HANMISYSTEM.Module.MyButton();
            this.btnClose = new HANMISYSTEM.Module.MyButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kiểu xuất tín hiệu hiện tại :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbbaudrate);
            this.groupBox1.Controls.Add(this.lbcom);
            this.groupBox1.Controls.Add(this.lbpushnotifytype);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 149);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cài đặt";
            // 
            // lbpushnotifytype
            // 
            this.lbpushnotifytype.AutoSize = true;
            this.lbpushnotifytype.Location = new System.Drawing.Point(206, 41);
            this.lbpushnotifytype.Name = "lbpushnotifytype";
            this.lbpushnotifytype.Size = new System.Drawing.Size(108, 17);
            this.lbpushnotifytype.TabIndex = 1;
            this.lbpushnotifytype.Text = "push notify type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "COM port :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Baud rate :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCLoseCH2);
            this.groupBox2.Controls.Add(this.btnCloseCH1);
            this.groupBox2.Controls.Add(this.btnOpenCH2);
            this.groupBox2.Controls.Add(this.btnOpenCH1);
            this.groupBox2.Controls.Add(this.myButton3);
            this.groupBox2.Controls.Add(this.myButton2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 142);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Relay";
            // 
            // lbcom
            // 
            this.lbcom.AutoSize = true;
            this.lbcom.Location = new System.Drawing.Point(108, 69);
            this.lbcom.Name = "lbcom";
            this.lbcom.Size = new System.Drawing.Size(34, 17);
            this.lbcom.TabIndex = 1;
            this.lbcom.Text = "com";
            // 
            // lbbaudrate
            // 
            this.lbbaudrate.AutoSize = true;
            this.lbbaudrate.Location = new System.Drawing.Point(108, 98);
            this.lbbaudrate.Name = "lbbaudrate";
            this.lbbaudrate.Size = new System.Drawing.Size(65, 17);
            this.lbbaudrate.TabIndex = 1;
            this.lbbaudrate.Text = "baudrate";
            // 
            // btnCLoseCH2
            // 
            this.btnCLoseCH2.BackColor = System.Drawing.Color.Orange;
            this.btnCLoseCH2.FlatAppearance.BorderSize = 0;
            this.btnCLoseCH2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLoseCH2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btnCLoseCH2.Location = new System.Drawing.Point(192, 86);
            this.btnCLoseCH2.Name = "btnCLoseCH2";
            this.btnCLoseCH2.Size = new System.Drawing.Size(61, 23);
            this.btnCLoseCH2.TabIndex = 2;
            this.btnCLoseCH2.Text = "Close";
            this.btnCLoseCH2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCLoseCH2.UseVisualStyleBackColor = false;
            this.btnCLoseCH2.Click += new System.EventHandler(this.btnCLoseCH2_Click);
            // 
            // btnCloseCH1
            // 
            this.btnCloseCH1.BackColor = System.Drawing.Color.Orange;
            this.btnCloseCH1.FlatAppearance.BorderSize = 0;
            this.btnCloseCH1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseCH1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btnCloseCH1.Location = new System.Drawing.Point(192, 41);
            this.btnCloseCH1.Name = "btnCloseCH1";
            this.btnCloseCH1.Size = new System.Drawing.Size(61, 23);
            this.btnCloseCH1.TabIndex = 2;
            this.btnCloseCH1.Text = "Close";
            this.btnCloseCH1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseCH1.UseVisualStyleBackColor = false;
            this.btnCloseCH1.Click += new System.EventHandler(this.btnCloseCH1_Click);
            // 
            // btnOpenCH2
            // 
            this.btnOpenCH2.BackColor = System.Drawing.Color.Green;
            this.btnOpenCH2.FlatAppearance.BorderSize = 0;
            this.btnOpenCH2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCH2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btnOpenCH2.Location = new System.Drawing.Point(125, 86);
            this.btnOpenCH2.Name = "btnOpenCH2";
            this.btnOpenCH2.Size = new System.Drawing.Size(61, 23);
            this.btnOpenCH2.TabIndex = 2;
            this.btnOpenCH2.Text = "Open";
            this.btnOpenCH2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenCH2.UseVisualStyleBackColor = false;
            this.btnOpenCH2.Click += new System.EventHandler(this.btnOpenCH2_Click);
            // 
            // btnOpenCH1
            // 
            this.btnOpenCH1.BackColor = System.Drawing.Color.Green;
            this.btnOpenCH1.FlatAppearance.BorderSize = 0;
            this.btnOpenCH1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCH1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btnOpenCH1.Location = new System.Drawing.Point(125, 41);
            this.btnOpenCH1.Name = "btnOpenCH1";
            this.btnOpenCH1.Size = new System.Drawing.Size(61, 23);
            this.btnOpenCH1.TabIndex = 2;
            this.btnOpenCH1.Text = "Open";
            this.btnOpenCH1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenCH1.UseVisualStyleBackColor = false;
            this.btnOpenCH1.Click += new System.EventHandler(this.btnOpenCH1_Click);
            // 
            // myButton3
            // 
            this.myButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.myButton3.FlatAppearance.BorderSize = 0;
            this.myButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton3.ForeColor = System.Drawing.Color.White;
            this.myButton3.Location = new System.Drawing.Point(29, 83);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(86, 29);
            this.myButton3.TabIndex = 1;
            this.myButton3.Text = "CH 2";
            this.myButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myButton3.UseVisualStyleBackColor = false;
            // 
            // myButton2
            // 
            this.myButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.myButton2.FlatAppearance.BorderSize = 0;
            this.myButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton2.ForeColor = System.Drawing.Color.White;
            this.myButton2.Location = new System.Drawing.Point(29, 37);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(86, 31);
            this.myButton2.TabIndex = 1;
            this.myButton2.Text = "CH 1";
            this.myButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myButton2.UseVisualStyleBackColor = false;
            // 
            // btnReadStatus
            // 
            this.btnReadStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.btnReadStatus.FlatAppearance.BorderSize = 0;
            this.btnReadStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadStatus.ForeColor = System.Drawing.Color.White;
            this.btnReadStatus.Location = new System.Drawing.Point(29, 379);
            this.btnReadStatus.Name = "btnReadStatus";
            this.btnReadStatus.Size = new System.Drawing.Size(113, 40);
            this.btnReadStatus.TabIndex = 1;
            this.btnReadStatus.Text = "Read status";
            this.btnReadStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReadStatus.UseVisualStyleBackColor = false;
            this.btnReadStatus.Click += new System.EventHandler(this.btnReadStatus_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(379, 448);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "    Đóng";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(29, 308);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(248, 65);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // DebugRelay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 500);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReadStatus);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DebugRelay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test connection";
            this.Load += new System.EventHandler(this.DebugRelay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Module.MyButton btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbbaudrate;
        private System.Windows.Forms.Label lbcom;
        private System.Windows.Forms.Label lbpushnotifytype;
        private System.Windows.Forms.GroupBox groupBox2;
        private Module.MyButton btnCLoseCH2;
        private Module.MyButton btnCloseCH1;
        private Module.MyButton btnOpenCH2;
        private Module.MyButton btnOpenCH1;
        private Module.MyButton myButton3;
        private Module.MyButton myButton2;
        private Module.MyButton btnReadStatus;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}