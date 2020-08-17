using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views
{
    public partial class DriverMgt : Form
    {
        public DriverMgt()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        DataTable dt;
        private void DriverMgt_Load(object sender, EventArgs e)
        {
            dt = connect.readdata("select * from driver order by id asc");
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtid.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                txtname.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
                txtcarnumber.Text = dataGridView1.Rows[e.RowIndex].Cells["carnumber"].Value.ToString();
            }
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            if (connect.countdata("select count(name) from driver where name='" + txtname.Text + "' and carnumber='" + txtcarnumber.Text + "'") != 0)
            {
                MessageBox.Show("Có vẻ lái xe này đã được đăng ký");
            }
            else
            {
                if (connect.exedata("insert into driver(name,carnumber) values (N'" + txtname.Text + "',N'" + txtcarnumber.Text + "')"))
                {
                    MessageBox.Show("Thành công");
                    dt = connect.readdata("select * from driver");
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void btnsavechange_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                if (connect.exedata("update driver set name=N'" + txtname.Text + "' ,carnumber=N'" + txtcarnumber.Text + "' where id='" + txtid.Text + "'"))
                {
                    dt = connect.readdata("select * from driver");
                    MessageBox.Show("Thanh công");
                    dt = connect.readdata("select * from driver");
                    dataGridView1.DataSource = dt;
                }

            }
            else
            {
                MessageBox.Show("Chọn một đối tượng để sửa");
            }
        }
        int i;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            ContextMenu ctx = new ContextMenu();
            MenuItem mItem = new MenuItem();
            mItem.Text = "Huỷ đăng ký";
            mItem.Click += new System.EventHandler(this.menuItem1_Click);
            ctx.MenuItems.Add(mItem);
            i = dataGridView1.HitTest(e.X, e.Y).RowIndex;

            if (e.Button == MouseButtons.Right)
            {
                Point pt = new Point(e.X, e.Y);
                ctx.Show(dataGridView1, pt);
            }
        }
        private void menuItem1_Click(object sender, System.EventArgs e)
        {
            if (i != -1)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa kế hoạch không.", "COnfirm", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    connect.exedata("delete from driver where id='"+dataGridView1.Rows[i].Cells["id"].Value.ToString()+"'");
                    dt = connect.readdata("select * from driver");
                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
}
