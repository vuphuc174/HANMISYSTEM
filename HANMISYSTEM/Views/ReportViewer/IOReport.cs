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

namespace HANMISYSTEM.Views.ReportViewer
{
    public partial class IOReport : Form
    {
        public IOReport()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private void IOReport_Load(object sender, EventArgs e)
        {
            DataTable dt = connect.readdata("select * from warehouse where idcategory='W1' ");
            cbbwarehouse.DataSource = dt;
            cbbwarehouse.DisplayMember = "namewarehouse";
            cbbwarehouse.ValueMember = "idwarehouse";
        }
        string sql;
        private void btnreport_Click(object sender, EventArgs e)
        {
            sql = "exec spReportIOByFilter @fromdate='" + dtpfrom.Value.ToString("yyyy-MM-dd") + "',@todate='" + dtpto.Value.ToString("yyyy-MM-dd") + "',@idwarehouse='" + cbbwarehouse.SelectedValue + "',@partno='" + txtpartno.Text + "'";
            DataTable dt = connect.readdata(sql);
            dataGridView1.DataSource = dt;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            HANMISYSTEM.Module.ExportToExcel _excel = new ExportToExcel();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = connect.readdata(sql);
                _excel.ExportToExcelFunction(dt, saveFileDialog1.FileName.ToString());
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if(dataGridView1.DataSource!=null)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("partno like '%{0}%'", txtsearch.Text);
            }
            
        }

        private void txtpartno_TextChanged(object sender, EventArgs e)
        {
            lbsearch.Visible = true;
            lbsearch.Items.Clear();
            DataTable dtsearch = connect.readdata("select top 15 partno from cargo where partno like '%" + txtpartno.Text + "%' or partname like '%" + txtpartno.Text + "%'");
            for (int i = 0; i < dtsearch.Rows.Count; i++)
            {
                lbsearch.Items.Add(dtsearch.Rows[i]["partno"].ToString());
            }
        }

        private void lbsearch_Click(object sender, EventArgs e)
        {
            if (lbsearch.SelectedItem != null)
            {
                txtpartno.Text = lbsearch.SelectedItem.ToString();
                lbsearch.Visible = false;
            }
        }
    }
}
