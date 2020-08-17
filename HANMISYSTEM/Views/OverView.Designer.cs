namespace HANMISYSTEM.Views
{
    partial class OverView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.achieve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.line,
            this.partno,
            this.inventory,
            this.plan,
            this.ok,
            this.target,
            this.progress,
            this.achieve});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(1264, 729);
            this.dataGridView1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // id
            // 
            this.id.DataPropertyName = "idlocation";
            this.id.FillWeight = 30F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // line
            // 
            this.line.DataPropertyName = "namelocation1";
            this.line.HeaderText = "LINE";
            this.line.Name = "line";
            this.line.ReadOnly = true;
            // 
            // partno
            // 
            this.partno.DataPropertyName = "partno";
            this.partno.HeaderText = "MODEL";
            this.partno.Name = "partno";
            this.partno.ReadOnly = true;
            // 
            // inventory
            // 
            this.inventory.DataPropertyName = "inventory";
            dataGridViewCellStyle2.Format = "N0";
            this.inventory.DefaultCellStyle = dataGridViewCellStyle2;
            this.inventory.HeaderText = "INVENTORY";
            this.inventory.Name = "inventory";
            this.inventory.ReadOnly = true;
            // 
            // plan
            // 
            this.plan.DataPropertyName = "productionplan";
            this.plan.HeaderText = "PLAN";
            this.plan.Name = "plan";
            this.plan.ReadOnly = true;
            // 
            // ok
            // 
            this.ok.DataPropertyName = "actual";
            this.ok.HeaderText = "OK";
            this.ok.Name = "ok";
            this.ok.ReadOnly = true;
            // 
            // target
            // 
            this.target.DataPropertyName = "prodtarget";
            this.target.HeaderText = "TARGET";
            this.target.Name = "target";
            this.target.ReadOnly = true;
            // 
            // progress
            // 
            this.progress.DataPropertyName = "progress";
            this.progress.HeaderText = "PROGRESS";
            this.progress.Name = "progress";
            this.progress.ReadOnly = true;
            // 
            // achieve
            // 
            this.achieve.DataPropertyName = "achieve";
            this.achieve.HeaderText = "ACHIEVE";
            this.achieve.Name = "achieve";
            this.achieve.ReadOnly = true;
            // 
            // OverView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OverView";
            this.Text = "OverView";
            this.Load += new System.EventHandler(this.OverView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn line;
        private System.Windows.Forms.DataGridViewTextBoxColumn partno;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ok;
        private System.Windows.Forms.DataGridViewTextBoxColumn target;
        private System.Windows.Forms.DataGridViewTextBoxColumn progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn achieve;
    }
}