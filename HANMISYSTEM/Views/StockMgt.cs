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

namespace HANMISYSTEM
{
    public partial class StockMgt : Form
    {
        public StockMgt()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private string sql;
        private void StockMgt_Load(object sender, EventArgs e)
        {
            btna.BackColor = Color.Blue;
            btna.ForeColor = Color.White;
            sql = "select PARTNO,PARTNAME,QTY,BOXQTY,BAGQTY,CARTQTY,TRAYQTY,ROLLQTY,CANQTY,PALLETQTY from  view_stock_warehouse where idwarehouse='WH002'";
            DataTable dtwarehouse = connect.readdata("select * from warehouse where idcategory <>'W3' and idcategory <> 'W4'");
            if (dtwarehouse.Rows.Count > 0)
            {
                cbwarehouse.DataSource = dtwarehouse;
                cbwarehouse.ValueMember = "idwarehouse";
                cbwarehouse.DisplayMember = "namewarehouse";
                cbwarehouse.SelectedValue = "WH002";
            }
            DataTable dtgrid = connect.readdata(sql);
            dataGridView1.DataSource = dtgrid;
        }

        private DataTable dtgrid1;
        private void cbwarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbwarehouse.Text != "")
            {
                DataTable dtcategory = connect.readdata("select idcategory from warehouse where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "'");
                if (dtcategory.Rows.Count > 0)
                {
                    if (dtcategory.Rows[0]["idcategory"].ToString() == "W2")
                    {
                        sql = "select partno,(select partname from cargo where partno =stock.partno) as partname ,convert(varchar,cast(quantity as money),1) as quantity  from stock  where idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "'";
                        dtgrid1 = connect.readdata(sql);
                    }
                    if (dtcategory.Rows[0]["idcategory"].ToString() == "W1")
                    {
                        sql = "select PARTNO,PARTNAME,QTY,BOXQTY,BAGQTY,CARTQTY,TRAYQTY,ROLLQTY,CANQTY,PALLETQTY from  view_stock_warehouse where idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "'";
                        dtgrid1 = connect.readdata(sql);
                    }
                }
                dataGridView1.DataSource = dtgrid1;
            }

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (btna.BackColor == Color.Blue)
            {
                DataTable dtcategory = connect.readdata("select idcategory from warehouse where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "'");
                if (dtcategory.Rows.Count > 0)
                {
                    if (dtcategory.Rows[0]["idcategory"].ToString() == "W2")
                    {
                        sql = "select partno,(select partname from cargo where partno =stock.partno) as partname ,convert(varchar,cast(quantity as money),1) as quantity  from stock  where idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "' and partno like '%" + txtsearch.Text + "%'";
                        dtgrid1 = connect.readdata(sql);
                    }
                    if (dtcategory.Rows[0]["idcategory"].ToString() == "W1")
                    {
                        sql = "select PARTNO,PARTNAME,QTY,BOXQTY,BAGQTY,CARTQTY,TRAYQTY,ROLLQTY,CANQTY,PALLETQTY from  view_stock_warehouse where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' and partno like '%" + txtsearch.Text + "%'";
                        dtgrid1 = connect.readdata(sql);
                    }
                }
                dataGridView1.DataSource = dtgrid1;
            }
            else
            {
                DataTable dtcategory = connect.readdata("select idcategory from warehouse where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "'");
                if (dtcategory.Rows.Count > 0)
                {
                    if (dtcategory.Rows[0]["idcategory"].ToString() == "W1")
                    {
                        sql = "select partno,p.idpack,quantity,packingdate,(select manufacturedate from dateofmanufacture d where d.idpack=p.idpack) as manufacturedate,position from  packinginfo p where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' and p.idpack like '%" + txtsearch.Text + "%'";
                        dtgrid1 = connect.readdata(sql);
                    }
                }
                dataGridView1.DataSource = dtgrid1;
            }


        }

        private void btnb_Click(object sender, EventArgs e)
        {
            btnb.BackColor = Color.Blue;
            btnb.ForeColor = Color.White;
            btna.BackColor = SystemColors.Control;
            btna.ForeColor = Color.Black;
            txtsearch.Text = "";
            DataTable dtcategory = connect.readdata("select idcategory from warehouse where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "'");
            if (dtcategory.Rows.Count > 0)
            {
                if (dtcategory.Rows[0]["idcategory"].ToString() == "W1")
                {
                    sql = "select partno,p.idpack,quantity,packingdate,(select manufacturedate from dateofmanufacture d where d.idpack=p.idpack) as manufacturedate,position from  packinginfo p  where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "'";
                    dtgrid1 = connect.readdata(sql);
                }
            }
            dataGridView1.DataSource = dtgrid1;
        }

        private void btna_Click(object sender, EventArgs e)
        {
            btna.BackColor = Color.Blue;
            btna.ForeColor = Color.White;
            btnb.BackColor = SystemColors.Control;
            btnb.ForeColor = Color.Black;
            txtsearch.Text = "";
            DataTable dtcategory = connect.readdata("select idcategory from warehouse where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "'");
            if (dtcategory.Rows.Count > 0)
            {
                if (dtcategory.Rows[0]["idcategory"].ToString() == "W2")
                {
                    sql = "select partno,(select partname from cargo where partno =stock.partno) as partname ,convert(varchar,cast(quantity as money),1) as quantity  from stock  where idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "'";
                    dtgrid1 = connect.readdata(sql);
                }
                if (dtcategory.Rows[0]["idcategory"].ToString() == "W1")
                {
                    sql = "select PARTNO,PARTNAME,QTY,BOXQTY,BAGQTY,CARTQTY,TRAYQTY,ROLLQTY,CANQTY,PALLETQTY from  view_stock_warehouse where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "'";
                    dtgrid1 = connect.readdata(sql);
                }
            }
            dataGridView1.DataSource = dtgrid1;

        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            HANMISYSTEM.Module.ExportToExcel _excel = new ExportToExcel();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = connect.readdata(sql);
                _excel.ExportToExcelFunction(dt, saveFileDialog1.FileName.ToString());
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Statistics fr = new Statistics();
                fr.cur_month = Convert.ToInt32(DateTime.Now.ToString("MM"));
                fr.lbpartno.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                fr.lbmonth.Text = DateTime.Now.ToString("MM");
                fr.lbwarehouse.Text = cbwarehouse.SelectedValue.ToString();
                DataGridViewRow row = new DataGridViewRow();
                for (int i = 1; i <= Convert.ToInt32(DateTime.Now.ToString("dd")); i++)
                {
                    fr.dataGridView1.Rows.Add("" + i);
                }

                for (int i = 0; i < Convert.ToInt32(DateTime.Now.ToString("dd")); i++)
                {
                    fr.dataGridView1.Rows[i].Cells["actualok"].Value = connect.countdata("select COUNT(qty) from productionhistory where DAY(productiontime)='" + (i + 1).ToString() + "' and partno='" + dataGridView1.Rows[e.RowIndex].Cells["partno"].Value + "' and idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "' and MONTH(productiontime)='" + DateTime.Now.ToString("MM") + "' and year(productiontime)='" + DateTime.Now.ToString("yyyy") + "'");
                }

                for (int i = 0; i < Convert.ToInt32(DateTime.Now.ToString("dd")); i++)
                {
                    fr.dataGridView1.Rows[i].Cells["actualng"].Value = connect.countdata("select COUNT(quantity) from tbl_nghistory where DAY(productiontime)='" + (i + 1).ToString() + "' and partno='" + dataGridView1.Rows[e.RowIndex].Cells["partno"].Value + "' and idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "' and MONTH(productiontime)='" + DateTime.Now.ToString("MM") + "' and year(productiontime)='" + DateTime.Now.ToString("yyyy") + "'");
                }
                //box
                for (int i = 0; i < Convert.ToInt32(DateTime.Now.ToString("dd")); i++)
                {
                    fr.dataGridView1.Rows[i].Cells["boxqty"].Value = connect.countdata("select COUNT(idpack) from packinginfo where DAY(packingdate)='" + (i + 1).ToString() + "' and partno='" + dataGridView1.Rows[e.RowIndex].Cells["partno"].Value + "' and idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "' and MONTH(packingdate)='" + DateTime.Now.ToString("MM") + "' and left(idpack,3)='BOX' and year(packingdate)='" + DateTime.Now.ToString("yyyy") + "'");
                }
                //bag
                for (int i = 0; i < Convert.ToInt32(DateTime.Now.ToString("dd")); i++)
                {
                    fr.dataGridView1.Rows[i].Cells["bagqty"].Value = connect.countdata("select COUNT(idpack) from packinginfo where DAY(packingdate)='" + (i + 1).ToString() + "' and partno='" + dataGridView1.Rows[e.RowIndex].Cells["partno"].Value + "' and idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "' and MONTH(packingdate)='" + DateTime.Now.ToString("MM") + "' and left(idpack,3)='BAG' and year(packingdate)='" + DateTime.Now.ToString("yyyy") + "'");
                }
                //cart
                for (int i = 0; i < Convert.ToInt32(DateTime.Now.ToString("dd")); i++)
                {
                    fr.dataGridView1.Rows[i].Cells["crtqty"].Value = connect.countdata("select COUNT(idpack) from packinginfo where DAY(packingdate)='" + (i + 1).ToString() + "' and partno='" + dataGridView1.Rows[e.RowIndex].Cells["partno"].Value + "' and idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "' and MONTH(packingdate)='" + DateTime.Now.ToString("MM") + "' and left(idpack,3)='CRT' and year(packingdate)='" + DateTime.Now.ToString("yyyy") + "'");
                }
                fr.Show();
            }

        }
        //double sumqty;
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void StockMgt_MouseClick(object sender, MouseEventArgs e)
        {
            ContextMenu ctx = new ContextMenu();

            MenuItem mItem1 = new MenuItem();
            mItem1.Text = "Quy trình tiếp theo";
            mItem1.Click += new System.EventHandler(this.menuItem1_Click);
            ctx.MenuItems.Add(mItem1);
        }
        public void menuItem1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
