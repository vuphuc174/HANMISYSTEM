using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.Producs
{
    public partial class ProductCategoryMgt : Form
    {
        public ProductCategoryMgt()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnaddCategory_Click(object sender, EventArgs e)
        {
            if (txtnode.Text == "")
            {
                treeView1.Nodes.Add("New Nodes");
            }
            else
            {
                treeView1.Nodes.Add(txtnode.Text);
            }
            
        }
        private int id;
        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            ContextMenu ctx = new ContextMenu();

            MenuItem mItem1 = new MenuItem();
            mItem1.Text = "Thêm danh mục con";
            mItem1.Click += new System.EventHandler(this.menuItem1_Click);
            ctx.MenuItems.Add(mItem1);

            MenuItem mItem2 = new MenuItem();
            mItem2.Text = "Xóa danh mục con";
            mItem2.Click += new System.EventHandler(this.menuItem2_Click);
            ctx.MenuItems.Add(mItem2);

            MenuItem mItem3 = new MenuItem();
            mItem3.Text = "Sửa tên";
            mItem3.Click += new System.EventHandler(this.menuItem3_Click);
            ctx.MenuItems.Add(mItem3);

            id = treeView1.HitTest(e.X, e.Y).Node.Index;

            if (e.Button == MouseButtons.Right)
            {
                Point pt = new Point(e.X, e.Y);
                ctx.Show(treeView1, pt);
            }
        }
        //quy trinh tiep theo
        public void menuItem1_Click(object sender, System.EventArgs e)
        {
            treeView1.Nodes[id].Nodes.Add("abc");
        }
        public void menuItem2_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("item2");
        }
        public void menuItem3_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("item3");
        }

    }
}
