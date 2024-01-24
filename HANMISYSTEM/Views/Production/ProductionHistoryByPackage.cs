using HANMISYSTEM.Common;
using HANMISYSTEM.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.Production
{
    public partial class ProductionHistoryByPackage : Form
    {
        public ProductionHistoryByPackage()
        {
            InitializeComponent();
        }
        DAO_ProductionHistory dAO_ProductionHistory = new DAO_ProductionHistory();
        public string partno;
        public string lineID;
        public DateTime fromDate;
        public DateTime toDate;
        DataTable packageList;
        private async void ProductHistoryByPackage_Load(object sender, EventArgs e)
        {
            packageList = await dAO_ProductionHistory.GetPackageList( partno, lineID, fromDate,toDate);
            dataGridView1.DataSource = packageList;
            lbHeader.Text+="<"+partno+">";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filter = txtSearch.Text;
            DataView dv = packageList.DefaultView;
            dv.RowFilter = $"idpack LIKE '%{filter}%'"; // Filter based on the 'Name' column

            dataGridView1.DataSource = dv.ToTable();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                ExcelHelper.ExportDataTableToExcel(packageList);
            }
        }
    }
}
