namespace HANMISYSTEM.Views.Producs
{
    partial class ProductCategoryMgt
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnaddCategory = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // txtnode
            // 
            this.txtnode.Location = new System.Drawing.Point(358, 18);
            this.txtnode.Name = "txtnode";
            this.txtnode.Size = new System.Drawing.Size(123, 20);
            this.txtnode.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(358, 43);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(610, 382);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            // 
            // btnaddCategory
            // 
            this.btnaddCategory.Location = new System.Drawing.Point(487, 15);
            this.btnaddCategory.Name = "btnaddCategory";
            this.btnaddCategory.Size = new System.Drawing.Size(117, 23);
            this.btnaddCategory.TabIndex = 4;
            this.btnaddCategory.Text = "Add Category";
            this.btnaddCategory.UseVisualStyleBackColor = true;
            this.btnaddCategory.Click += new System.EventHandler(this.btnaddCategory_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(856, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Save Category";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ProductCategoryMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 469);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnaddCategory);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnode);
            this.Controls.Add(this.label1);
            this.Name = "ProductCategoryMgt";
            this.Text = "ProductCategoryMgt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnaddCategory;
        private System.Windows.Forms.Button button3;
    }
}