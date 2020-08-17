namespace HANMISYSTEM.Views.ReportViewer
{
    partial class SlipReport
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


            this.hANMIDataSet1 = new HANMISYSTEM.HANMIDataSet1();
            this.slipoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.slipoutTableAdapter = new HANMISYSTEM.HANMIDataSet1TableAdapters.slipoutTableAdapter();
            this.hANMIDataSet2 = new HANMISYSTEM.HANMIDataSet2();
            this.viewslipoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_slipoutTableAdapter = new HANMISYSTEM.HANMIDataSet2TableAdapters.view_slipoutTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hANMIDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slipoutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANMIDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewslipoutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 


            // hANMIDataSet1
            // 
            this.hANMIDataSet1.DataSetName = "HANMIDataSet1";
            this.hANMIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // slipoutBindingSource
            // 
            this.slipoutBindingSource.DataMember = "slipout";
            this.slipoutBindingSource.DataSource = this.hANMIDataSet1;
            // 
            // slipoutTableAdapter
            // 
            this.slipoutTableAdapter.ClearBeforeFill = true;
            // 
            // hANMIDataSet2
            // 
            this.hANMIDataSet2.DataSetName = "HANMIDataSet2";
            this.hANMIDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewslipoutBindingSource
            // 
            this.viewslipoutBindingSource.DataMember = "view_slipout";
            this.viewslipoutBindingSource.DataSource = this.hANMIDataSet2;
            // 
            // view_slipoutTableAdapter
            // 
            this.view_slipoutTableAdapter.ClearBeforeFill = true;
            // 
            // SlipReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 425);

            this.Name = "SlipReport";
            this.Text = "SlipReport";
            this.Load += new System.EventHandler(this.SlipReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hANMIDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slipoutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANMIDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewslipoutBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private HANMIDataSet1 hANMIDataSet1;
        private System.Windows.Forms.BindingSource slipoutBindingSource;
        private HANMIDataSet1TableAdapters.slipoutTableAdapter slipoutTableAdapter;
        private HANMIDataSet2 hANMIDataSet2;
        private System.Windows.Forms.BindingSource viewslipoutBindingSource;
        private HANMIDataSet2TableAdapters.view_slipoutTableAdapter view_slipoutTableAdapter;
    }
}