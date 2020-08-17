using HANMISYSTEM.Module;
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
    public partial class MakeBOM : Form
    {
        public MakeBOM()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        Isnumber isnum = new Isnumber();
        private void btnaddsub_Click(object sender, EventArgs e)
        {
            if (txtmodel.Text == "" || txtsub.Text == "" || txtqty.Text == "")
            {
                MessageBox.Show("Xin hãy ,Điền đầy đủ các trường");
            }
            else
            {
                DataTable dtcheckbom = connect.readdata("select * from Bom where partno ='" + txtmodel.Text + "' and rawpartno ='" + txtsub.Text + "'");
                if (dtcheckbom.Rows.Count != 0)
                {
                    MessageBox.Show("Nguyên vật liêu này đã có !");
                }
                else
                {
                    if (isnum.IsNumber(txtqty.Text) == false)
                    {
                        MessageBox.Show("Hãy nhập vào một số ");
                    }
                    else
                    {
                        if (Convert.ToDouble(txtqty.Text) <= 0)
                        {
                            MessageBox.Show("Hãy nhập một số lớn hơn 0");
                        }
                        else
                        {
                            if (connect.exedata("Insert into bom(partno,rawpartno,quantity) values ('" + txtmodel.Text + "','" + txtsub.Text + "','" + txtqty.Text + "')"))
                            {
                                MessageBox.Show("Thanh công");
                                DataTable dtbom = connect.readdata("select b.rawpartno,(select partname from cargo c where c.partno =b.rawpartno) as partname,Quantity,isnull((select name from BomProcess where id=(select ProcessID from cargo where partno=b.rawpartno)),'Outsource') as name from bom b where b.partno='" + txtmodel.Text + "'");
                                dataGridView1.DataSource = dtbom;
                                txtsub.Text = "";
                                txtqty.Text = "";
                                lbsearchsub.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("Thất bại");
                            }
                        }
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lbsearch.Visible = true;
            lbsearch.Items.Clear();
            DataTable dtsearch = connect.readdata("select top 15 partno from cargo where partno like '%" + txtmodel.Text + "%'");
            for (int i = 0; i < dtsearch.Rows.Count; i++)
            {
                lbsearch.Items.Add(dtsearch.Rows[i]["partno"].ToString());
            }
        }

        private void lbsearch_Click(object sender, EventArgs e)
        {
            if (lbsearch.SelectedItem != null)
            {
                txtmodel.Text = lbsearch.SelectedItem.ToString();
                lbsearch.Visible = false;
                DataTable dtbom = connect.readdata("select b.rawpartno,(select partname from cargo c where c.partno =b.rawpartno) as partname,Quantity,isnull((select name from BomProcess where id=(select ProcessID from cargo where partno=b.rawpartno)),'Outsource') as name from bom b where b.partno='" + txtmodel.Text + "'");
                dataGridView1.DataSource = dtbom;
            }
        }

        private void lbsearchsub_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void lbsearchsub_Click(object sender, EventArgs e)
        {
            if (lbsearchsub.SelectedItem != null)
            {
                txtsub.Text = lbsearchsub.SelectedItem.ToString();
                lbsearchsub.Visible = false;
            }
        }

        private void txtsub_TextChanged(object sender, EventArgs e)
        {
            lbsearchsub.Visible = true;
            lbsearchsub.Items.Clear();
            DataTable dtsearch = connect.readdata("select top 15 partno from cargo where partno like '%" + txtsub.Text + "%'");
            for (int i = 0; i < dtsearch.Rows.Count; i++)
            {
                lbsearchsub.Items.Add(dtsearch.Rows[i]["partno"].ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtsub.Text = dataGridView1.Rows[e.RowIndex].Cells["Partno"].Value.ToString();
                txtqty.Text = dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                lbsearchsub.Visible = false;
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtmodel.Text == "" || txtsub.Text == "" || txtqty.Text == "")
            {
                MessageBox.Show("Xin hãy ,Điền đầy đủ các trường");
            }
            else
            {
                DataTable dtcheckbom = connect.readdata("select * from Bom where partno ='" + txtmodel.Text + "' and rawpartno ='" + txtsub.Text + "'");
                if (dtcheckbom.Rows.Count == 0)
                {
                    MessageBox.Show("Nguyên vật liêu này chưa có ,xin hãy thêm mới trước !");
                }
                else
                {
                    if (isnum.IsNumber(txtqty.Text) == false)
                    {
                        MessageBox.Show("Hãy nhập vào một số ");
                    }
                    else
                    {
                        if (Convert.ToDouble(txtqty.Text) <= 0)
                        {
                            MessageBox.Show("Hãy nhập một số lớn hơn 0");
                        }
                        else
                        {
                            if (connect.exedata("update BOM set quantity ='" + txtqty.Text + "' where partno='" + txtmodel.Text + "' and rawpartno ='" + txtsub.Text + "'"))
                            {
                                MessageBox.Show("Thanh công");
                                DataTable dtbom = connect.readdata("select b.rawpartno,(select partname from cargo c where c.partno =b.rawpartno) as partname,Quantity,isnull((select name from BomProcess where id=(select ProcessID from cargo where partno=b.rawpartno)),'Outsource') as name from bom b where b.partno='" + txtmodel.Text + "'");
                                dataGridView1.DataSource = dtbom;
                                txtsub.Text = "";
                                txtqty.Text = "";
                                lbsearchsub.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("Thất bại");
                            }
                        }
                    }
                }
            }
        }
        //private int id;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //ContextMenu ctx = new ContextMenu();
            //MenuItem mItem = new MenuItem();
            //mItem.Text = "Quy trình trước đó";
            //MenuItem mItem1 = new MenuItem();
            //mItem1.Text = "Quy trình tiếp theo";
            //mItem1.Click += new System.EventHandler(this.menuItem2_Click);
            //ctx.MenuItems.Add(mItem1);
            //mItem.Click += new System.EventHandler(this.menuItem1_Click);
            //ctx.MenuItems.Add(mItem);
            //id = dataGridView1.HitTest(e.X, e.Y).RowIndex;

            //if (e.Button == MouseButtons.Right)
            //{
            //    Point pt = new Point(e.X, e.Y);
            //    ctx.Show(dataGridView1, pt);
            //}
        }
    }
}
