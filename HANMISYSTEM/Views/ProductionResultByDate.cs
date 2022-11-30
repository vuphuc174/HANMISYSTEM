using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HANMISYSTEM.Module;

namespace HANMISYSTEM.Views
{
    public partial class ProductionResultByDate : Form
    {
        public ProductionResultByDate()
        {
            InitializeComponent();
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
            txtsearch.Text = "";
            if (cblocation.SelectedValue.ToString() != "-1")
            {
                dtdata = connect.readdata("select partno,partname,productiondate,quantity from view_production_result where idlocation='" + cblocation.SelectedValue.ToString() + "'");
                try
                {
                    dgvdata.DataSource = dtdata;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + ex);
                }
            }
            else
            {
                dtdata = connect.readdata("select partno,partname,productiondate,quantity from view_production_result");
                try
                {
                    dgvdata.DataSource = dtdata;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + ex);
                }
            }

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
        ExportToExcel _excel = new ExportToExcel();
        private void btnexcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _excel.ExportToExcelFunction(dtdata, saveFileDialog1.FileName.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
