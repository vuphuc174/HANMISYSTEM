namespace HANMISYSTEM
{
    partial class DeliveryResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryResultForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lgplan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryresult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionresult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.model,
            this.lgplan,
            this.deliveryresult,
            this.deliveryrate,
            this.productionresult,
            this.productionrate});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1109, 571);
            this.dataGridView1.TabIndex = 0;
            // 
            // model
            // 
            this.model.DataPropertyName = "model";
            this.model.HeaderText = "Models";
            this.model.Name = "model";
            // 
            // lgplan
            // 
            this.lgplan.DataPropertyName = "quantity";
            this.lgplan.HeaderText = "LG Plans";
            this.lgplan.Name = "lgplan";
            // 
            // deliveryresult
            // 
            this.deliveryresult.DataPropertyName = "delivered";
            this.deliveryresult.HeaderText = "Delivery Result";
            this.deliveryresult.Name = "deliveryresult";
            // 
            // deliveryrate
            // 
            this.deliveryrate.DataPropertyName = "deliveryrate";
            this.deliveryrate.HeaderText = "Delivery Rate";
            this.deliveryrate.Name = "deliveryrate";
            // 
            // productionresult
            // 
            this.productionresult.DataPropertyName = "productionresult";
            this.productionresult.HeaderText = "Production Result";
            this.productionresult.Name = "productionresult";
            // 
            // productionrate
            // 
            this.productionrate.DataPropertyName = "productionrate";
            this.productionrate.HeaderText = "Production Rate";
            this.productionrate.Name = "productionrate";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // DeliveryResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 571);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeliveryResultForm";
            this.Text = "DeliveryResult";
            this.Load += new System.EventHandler(this.DeliveryResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn lgplan;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryresult;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionresult;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionrate;
        private System.Windows.Forms.Timer timer2;
    }
}