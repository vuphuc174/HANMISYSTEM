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

namespace HANMISYSTEM.Views.BOM
{
    public partial class BOMDetail : Form
    {
        public DataTable dtbom;
        public BOMDetail()
        {
            InitializeComponent();
        }
        double total;
        Dbconnect connect = new Dbconnect();
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex != -1)
        //    {
        //        if (dataGridView1.Rows[e.RowIndex].Cells["expand"].Value.ToString() == "+")
        //        {
        //            string sub = dataGridView1.Rows[e.RowIndex].Cells["rawpartno"].Value.ToString();
        //            DataTable dtsub = connect.readdata("select rawpartno,quantity,(select partname from cargo where partno =b.rawpartno) as partname,isnull((select nameunit from unit where idunit=(select idunit from cargo where partno =b.rawpartno) ),'EA') as unit from bom b where partno='" + sub + "'");
        //            if (dtsub.Rows.Count > 0)
        //            {
        //                for (int i = 0; i < dtsub.Rows.Count; i++)
        //                {
        //                    DataRow addrow = dtbom.NewRow();
        //                    addrow["rawpartno"] = "          " + dtsub.Rows[i]["rawpartno"].ToString();
        //                    addrow["partname"] = dtsub.Rows[i]["partname"].ToString();
        //                    addrow["unit"] = dtsub.Rows[i]["unit"].ToString();
        //                    addrow["quantity"] = dtsub.Rows[i]["quantity"].ToString();
        //                    //dataGridView1.Rows.Add(dtsub.Rows[i]["rawpartno"].ToString(), dtsub.Rows[i]["partname"].ToString(), dtsub.Rows[i]["unit"].ToString());
        //                    dtbom.Rows.InsertAt(addrow, e.RowIndex + 1);
        //                    dtbom.AcceptChanges();
        //                    dtbom.Dispose();
        //                }

        //            }
        //            dataGridView1.Rows[e.RowIndex].Cells["rawpartno"].Value = "- " + sub;
        //        }
        //        if (dataGridView1.Rows[e.RowIndex].Cells["rawpartno"].Value.ToString().Trim().Substring(0, 1) == "-")
        //        {
        //            //dtbom.Rows.RemoveAt(e.RowIndex + 1);
        //            //dataGridView1.Rows[e.RowIndex].Cells["rawpartno"].Value = "+ " + dataGridView1.Rows[e.RowIndex].Cells["rawpartno"].Value.ToString().Trim().Substring(2, dataGridView1.Rows[e.RowIndex].Cells["rawpartno"].Value.ToString().Trim().Length - 2);
        //            dtbom.AcceptChanges();
        //            dtbom.Dispose();
        //        }
        //    }

        //}
        Isnumber isn = new Isnumber();
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (isn.IsNumber(row.Cells["quantity"].Value.ToString()))
                {
                    total += Convert.ToDouble(row.Cells["quantity"].Value.ToString());
                }
            }
            txttotal.Text = total.ToString();

        }

        private void btnapply_Click(object sender, EventArgs e)
        {
            if (btnactive.Text == "Hide")
            {
                DataTable dtfully = connect.readdata("WITH RPL(LEVEL, PART, SUBPART, SUB, QUANTITY, Orderpath) AS(SELECT 1, ROOT.partno, ROOT.rawpartno, convert(varchar(MAX), ROOT.rawpartno) sub, ROOT.QUANTITY, CONVERT(VARCHAR(MAX), ROOT.rawpartno) OrderPath FROM bom ROOT where ROOT.partno = '" + lbpartno.Text + "' UNION ALL SELECT PARENT.LEVEL + 1, CHILD.partno, CHILD.rawpartno, REPLACE(PARENT.SUB, PARENT.SUB, REPLICATE('        ', PARENT.LEVEL) + CHILD.rawpartno), CHILD.QUANTITY, PARENT.Orderpath + PARENT.SUBPART + CHILD.rawpartno FROM RPL PARENT, bom CHILD WHERE PARENT.SUBPART = LTRIM(CHILD.partno)) SELECT  SUB as rawpartno, LEVEL, (select partname from cargo c where c.partno = RPL.SUBPART) as partname,(select nameunit from unit where idunit = (select idunit from cargo c where c.partno = RPL.SUBPART))as unit, isnull((select SUM(quantity) from packinginfo where partno = RPL.SUBPART),'0') as Inventory, QUANTITY FROM RPL order by Orderpath; ");
                dataGridView1.DataSource = dtfully;

            }
            else
            {
                DataTable dtsummary = connect.readdata("select level=1,rawpartno,(select partname from cargo where cargo.partno =rawpartno) as partname,quantity,isnull((select sum(packinginfo.quantity) from packinginfo where packinginfo.partno =rawpartno),0) as inventory,(select nameunit from unit where idunit=(select idunit from cargo where cargo.partno =rawpartno)) as unit from bom where partno='" + lbpartno.Text + "' order by rawpartno asc");
                dataGridView1.DataSource = dtsummary;
            }

            if (isn.IsNumber(txtqty.Text))
            {
                if (Convert.ToDouble(txtqty.Text) != 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (isn.IsNumber(row.Cells["quantity"].Value.ToString()))
                        {

                            row.Cells["quantity"].Value = Convert.ToDouble(row.Cells["quantity"].Value.ToString()) * Convert.ToDouble(txtqty.Text);
                        }
                    }
                }

            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToDouble(row.Cells["quantity"].Value.ToString()) > Convert.ToDouble(row.Cells["Inventory"].Value.ToString()))
                {
                    row.Cells["quantity"].Style.ForeColor = Color.Red;
                }
            }
            total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (isn.IsNumber(row.Cells["quantity"].Value.ToString()))
                {
                    total += Convert.ToDouble(row.Cells["quantity"].Value.ToString());
                }
            }
            txttotal.Text = total.ToString();
        }

        private void btnactive_Click(object sender, EventArgs e)
        {
            if (btnactive.Text == "Hide")
            {
                dtbom = connect.readdata("select level=1,rawpartno,(select partname from cargo where cargo.partno =rawpartno) as partname,quantity,isnull((select sum(packinginfo.quantity) from packinginfo where packinginfo.partno =rawpartno),0) as inventory,(select nameunit from unit where idunit=(select idunit from cargo where cargo.partno =rawpartno)) as unit from bom where partno='" + lbpartno.Text + "' order by rawpartno asc");
                dataGridView1.DataSource = dtbom;
                btnactive.Text = "Show";
            }
            else
            {
               dtbom = connect.readdata("WITH RPL(LEVEL, PART, SUBPART, SUB, QUANTITY, Orderpath) AS(SELECT 1, ROOT.partno, ROOT.rawpartno, convert(varchar(MAX), ROOT.rawpartno) sub, ROOT.QUANTITY, CONVERT(VARCHAR(MAX), ROOT.rawpartno) OrderPath FROM bom ROOT where ROOT.partno = '" + lbpartno.Text + "' UNION ALL SELECT PARENT.LEVEL + 1, CHILD.partno, CHILD.rawpartno, REPLACE(PARENT.SUB, PARENT.SUB, REPLICATE('        ', PARENT.LEVEL) + CHILD.rawpartno), CHILD.QUANTITY, PARENT.Orderpath + PARENT.SUBPART + CHILD.rawpartno FROM RPL PARENT, bom CHILD WHERE PARENT.SUBPART = LTRIM(CHILD.partno)) SELECT  SUB as rawpartno, LEVEL, (select partname from cargo c where c.partno = RPL.SUBPART) as partname,(select nameunit from unit where idunit = (select idunit from cargo c where c.partno = RPL.SUBPART))as unit, isnull((select SUM(quantity) from packinginfo where partno = RPL.SUBPART),'0') as Inventory, QUANTITY FROM RPL order by Orderpath; ");
                dataGridView1.DataSource = dtbom;
                btnactive.Text = "Hide";
            }
        }

        private void dataGridView1_MouseHover(object sender, DataGridViewCellEventArgs e)
        {
            // dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 0)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["ce"].Value != null)
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells["ce"].Value.ToString() == "-")
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["ce"].Value = "+";
                        for (int i = e.RowIndex + 1; i < dataGridView1.Rows.Count; i++)
                        {
                            if (Convert.ToInt32(dataGridView1.Rows[i].Cells["level"].Value.ToString()) > Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["level"].Value.ToString()))
                            {
                                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                                currencyManager1.SuspendBinding();
                                dataGridView1.Rows[i].Visible = false;
                                currencyManager1.ResumeBinding();
                                dataGridView1.Refresh();
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["ce"].Value = "-";
                        for (int i = e.RowIndex + 1; i < dataGridView1.Rows.Count; i++)
                        {
                            if (Convert.ToInt32(dataGridView1.Rows[i].Cells["level"].Value.ToString()) > Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["level"].Value.ToString()))
                            {
                                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                                currencyManager1.SuspendBinding();
                                dataGridView1.Rows[i].Visible = true;
                                currencyManager1.ResumeBinding();
                                dataGridView1.Refresh();
                                //if(dataGridView1.Rows[i].Cells["ce"].Value.ToString() == "+")
                                //{
                                //    break;
                                //}
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["level"].Value != null)
                {
                    if (row.Cells["level"].Value.ToString() == "2")
                    {
                        row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#f5f6f7");
                    }
                    else if (row.Cells["level"].Value.ToString() == "3")
                    {
                        row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#eee");
                    }
                    else if (row.Cells["level"].Value.ToString() == "4")
                    {
                        row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#dddfe2");
                    }
                    else if (row.Cells["level"].Value.ToString() == "5")
                    {
                        row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ccc");
                    }
                }


            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //for(int i=row.Index+1;i<dataGridView1.Rows.Count-1;i++)
                //{
                if (i < dataGridView1.Rows.Count - 1)
                {
                    if(dataGridView1.Rows[i].Cells["level"].Value != null)
                        {
                        if (Convert.ToInt32(dataGridView1.Rows[i + 1].Cells["level"].Value.ToString()) > Convert.ToInt32(dataGridView1.Rows[i].Cells["level"].Value.ToString()))
                        {
                            dataGridView1.Rows[i].Cells["ce"].Value = "-";
                            continue;
                        }
                        else
                        {
                            continue;
                        }
                    }

                }

                ////}
            }

        }
        int id;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            ContextMenu ctx = new ContextMenu();
            MenuItem mItem1= new MenuItem();
            mItem1.Text = "Kiểm tra tồn kho";
            mItem1.Click += new System.EventHandler(this.menuItem1_Click);
            ctx.MenuItems.Add(mItem1);

            MenuItem mItem2 = new MenuItem();
            mItem2.Text = "Chỉnh sửa BOM";
            mItem2.Click += new System.EventHandler(this.menuItem2_Click);
            ctx.MenuItems.Add(mItem2);

            id = dataGridView1.HitTest(e.X, e.Y).RowIndex;
            if (e.Button == MouseButtons.Right)
            {
                Point pt = new Point(e.X, e.Y);
                ctx.Show(dataGridView1, pt);
            }
        }
        public void menuItem1_Click(object sender, System.EventArgs e)
        {
        }
        public void menuItem2_Click(object sender, System.EventArgs e)
        {
        }
        ExportToExcel exportToExcel = new ExportToExcel();
        private void btnexcel_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = lbpartno.Text;
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                exportToExcel.ExportToExcelFunction(dtbom, saveFileDialog1.FileName.ToString());
            }
        }
    }
}
