namespace HANMISYSTEM
{
    partial class Overviewv2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LINE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROGRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtpagenumber = new System.Windows.Forms.TextBox();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnpre = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 729);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = global::HANMISYSTEM.Properties.Settings.Default.keeporder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LINE,
            this.Linename,
            this.partno,
            this.inventory,
            this.plan,
            this.actual,
            this.NG,
            this.PROGRESS});
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("AutoGenerateColumns", global::HANMISYSTEM.Properties.Settings.Default, "keeporder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1352, 729);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // LINE
            // 
            this.LINE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LINE.DataPropertyName = "idlocation";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.LINE.DefaultCellStyle = dataGridViewCellStyle2;
            this.LINE.FillWeight = 50F;
            this.LINE.HeaderText = "LINE";
            this.LINE.Name = "LINE";
            this.LINE.ReadOnly = true;
            this.LINE.Width = 62;
            // 
            // Linename
            // 
            this.Linename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Linename.DataPropertyName = "namelocation1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Linename.DefaultCellStyle = dataGridViewCellStyle3;
            this.Linename.FillWeight = 220F;
            this.Linename.HeaderText = "LINE NAME";
            this.Linename.Name = "Linename";
            this.Linename.ReadOnly = true;
            this.Linename.Width = 312;
            // 
            // partno
            // 
            this.partno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.partno.DataPropertyName = "partno";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.partno.DefaultCellStyle = dataGridViewCellStyle4;
            this.partno.FillWeight = 180F;
            this.partno.HeaderText = "PARTNO";
            this.partno.Name = "partno";
            this.partno.ReadOnly = true;
            this.partno.Width = 249;
            // 
            // inventory
            // 
            this.inventory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.inventory.DataPropertyName = "inventory";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "#,##0";
            dataGridViewCellStyle5.NullValue = "0";
            this.inventory.DefaultCellStyle = dataGridViewCellStyle5;
            this.inventory.FillWeight = 140F;
            this.inventory.HeaderText = "INVENTORY";
            this.inventory.Name = "inventory";
            this.inventory.ReadOnly = true;
            this.inventory.Width = 175;
            // 
            // plan
            // 
            this.plan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.plan.DataPropertyName = "productionplan";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.plan.DefaultCellStyle = dataGridViewCellStyle6;
            this.plan.HeaderText = "PLAN";
            this.plan.Name = "plan";
            this.plan.ReadOnly = true;
            this.plan.Width = 125;
            // 
            // actual
            // 
            this.actual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.actual.DataPropertyName = "actual";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.actual.DefaultCellStyle = dataGridViewCellStyle7;
            this.actual.HeaderText = "ACTUAL";
            this.actual.Name = "actual";
            this.actual.ReadOnly = true;
            this.actual.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.actual.Width = 124;
            // 
            // NG
            // 
            this.NG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NG.DataPropertyName = "ng";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.NG.DefaultCellStyle = dataGridViewCellStyle8;
            this.NG.FillWeight = 80F;
            this.NG.HeaderText = "NG";
            this.NG.Name = "NG";
            this.NG.ReadOnly = true;
            // 
            // PROGRESS
            // 
            this.PROGRESS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "p";
            dataGridViewCellStyle9.NullValue = "0";
            this.PROGRESS.DefaultCellStyle = dataGridViewCellStyle9;
            this.PROGRESS.FillWeight = 130F;
            this.PROGRESS.HeaderText = "PROGRESS";
            this.PROGRESS.Name = "PROGRESS";
            this.PROGRESS.ReadOnly = true;
            this.PROGRESS.Width = 162;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtpagenumber);
            this.panel2.Controls.Add(this.btnnext);
            this.panel2.Controls.Add(this.btnpre);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 704);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1352, 25);
            this.panel2.TabIndex = 2;
            // 
            // txtpagenumber
            // 
            this.txtpagenumber.Enabled = false;
            this.txtpagenumber.Location = new System.Drawing.Point(37, 5);
            this.txtpagenumber.Name = "txtpagenumber";
            this.txtpagenumber.Size = new System.Drawing.Size(27, 20);
            this.txtpagenumber.TabIndex = 1;
            this.txtpagenumber.Text = "1";
            this.txtpagenumber.TextChanged += new System.EventHandler(this.txtpagenumber_TextChanged);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(64, 3);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(32, 23);
            this.btnnext.TabIndex = 0;
            this.btnnext.Text = ">>";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnpre
            // 
            this.btnpre.Location = new System.Drawing.Point(3, 3);
            this.btnpre.Name = "btnpre";
            this.btnpre.Size = new System.Drawing.Size(32, 23);
            this.btnpre.TabIndex = 0;
            this.btnpre.Text = "<<";
            this.btnpre.UseVisualStyleBackColor = true;
            this.btnpre.Click += new System.EventHandler(this.btnpre_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 20000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Overviewv2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1352, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Overviewv2";
            this.Text = "Overviewv2";
            this.Load += new System.EventHandler(this.Overviewv2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtpagenumber;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnpre;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LINE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linename;
        private System.Windows.Forms.DataGridViewTextBoxColumn partno;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn NG;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROGRESS;
    }
}