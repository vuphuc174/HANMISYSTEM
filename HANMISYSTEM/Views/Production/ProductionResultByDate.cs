using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HANMISYSTEM.Common;
using HANMISYSTEM.Module;

namespace HANMISYSTEM.Views
{
    public partial class ProductionResultByDate : Form
    {
        private ContextMenuStrip contextMenuStrip;
        private MainFrm _parrentFrom;
        public ProductionResultByDate(MainFrm parrentFrom)
        {
            InitializeComponent();
            contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem menuViewDetails = new ToolStripMenuItem("Xem chi tiết");
            //ToolStripMenuItem menuItem2 = new ToolStripMenuItem("Delete");

            // Add Click event handlers for menu items
            menuViewDetails.Click += ViewDetails_Click;
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { menuViewDetails });

            // Step 2: Associate ContextMenuStrip with DataGridView
            dgvdata.ContextMenuStrip = contextMenuStrip;
            _parrentFrom = parrentFrom;
        }
        private void ViewDetails_Click(object sender, EventArgs e)
        {
            // Handle the edit action here
            _parrentFrom.btnProduction_history_Click(sender, e);
        }
        Dbconnect connect = new Dbconnect();
        DataTable dtdata;
        private void ProductionResultByDate_Load(object sender, EventArgs e)
        {
            cbwarehouse.DataSource = connect.readdata("select * from warehouse where idwarehouse='WH001'");
            cbwarehouse.DisplayMember = "namewarehouse";
            cbwarehouse.ValueMember = "idwarehouse";

            //location
            DataTable dtlocation = connect.readdata("select idlocation,namelocation1 from location");
            dtlocation.Rows.Add("-1", "ALL");
            cblocation.DataSource = dtlocation;
            cblocation.DisplayMember = "namelocation1";
            cblocation.ValueMember = "idlocation";
            cblocation.SelectedValue = "L1";
            dtdata = connect.readdata("select partno,partname,productiondate,quantity from view_production_result where idlocation ='L1' and productiondate=Convert(date,getdate())");
            try
            {
                dgvdata.DataSource = dtdata;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dtdata.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "partno", txtsearch.Text);
        }
        Double total;
        private void dgvData_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {

        }

        private void dgvData_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            total = 0;
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                total = total + Convert.ToDouble(row.Cells["quantity"].Value);
            }
            lbtotal.Text = total.ToString("N0");
        }

        private void cblocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtsearch.Text = "";
            //if (cblocation.SelectedValue.ToString() != "-1")
            //{
            //    dtdata = connect.readdata("select partno,partname,productiondate,quantity from view_production_result where idlocation='" + cblocation.SelectedValue.ToString() + "'");
            //    try
            //    {
            //        dgvdata.DataSource = dtdata;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error :" + ex);
            //    }
            //}
            //else
            //{
            //    dtdata = connect.readdata("select partno,partname,productiondate,quantity from view_production_result");
            //    try
            //    {
            //        dgvdata.DataSource = dtdata;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error :" + ex);
            //    }
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtsearch.Text = "";
            if (cblocation.Text == "ALL")
            {
                dtdata = connect.readdata("select partno,partname,productiondate,quantity from view_production_result where productiondate between '" + dtpfrom.Value.ToString("yyyy-MM-dd") + "' and '" + dtpto.Value.ToString("yyyy-MM-dd") + "'");
            }
            else
            {
                dtdata = connect.readdata("select partno,partname,productiondate,quantity from view_production_result where idlocation='" + cblocation.SelectedValue.ToString() + "' and productiondate between '" + dtpfrom.Value.ToString("yyyy-MM-dd") + "' and '" + dtpto.Value.ToString("yyyy-MM-dd") + "'");
            }
            try
            {
                dgvdata.DataSource = dtdata;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }
        }
        private void dgvdata_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {   
            DataGridView.HitTestInfo hitTestInfo = dgvdata.HitTest(e.X, e.Y);
            if (e.Button == MouseButtons.Right)
            {
                if (hitTestInfo.Type == DataGridViewHitTestType.Cell && e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Select the clicked cell
                    dgvdata.CurrentCell = dgvdata.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    // Show the context menu
                    contextMenuStrip.Show(dgvdata, e.Location);
                }
            }
        }

        private void btnexcel_Click_1(object sender, EventArgs e)
        {
            ExcelHelper.ExportDataTableToExcel(dtdata);
        }
    }
}
