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

namespace HANMISYSTEM.Views.Warehouse
{
    public partial class StockInOut : Form
    {
        public StockInOut()
        {
            InitializeComponent();
        }
        DAO_Warehouse dAO_Warehouse = new DAO_Warehouse();
        DAO_Slipout dAO_Slipout = new DAO_Slipout();
        private class Types
        {
            public string Name { get; set; }
        }
        private async void StockInOut_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtWarehouse = await dAO_Warehouse.GetWarehousesByCateGory("W1");
                cbbWarehouse.DataSource = dtWarehouse;
                cbbWarehouse.DisplayMember = "namewarehouse";
                cbbWarehouse.ValueMember = "idwarehouse";

                List<Types> items = new List<Types>
                {
                    new Types { Name = "ALL" },
                    new Types { Name = "IN" },
                    new Types { Name = "OUT" },
                };

                cbbType.DataSource = items;
                cbbType.DisplayMember = "Name";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
            

        }

        private async void btnApply_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await dAO_Slipout.GetWarehouseInOut(cbbWarehouse.SelectedValue.ToString(), cbbType.Text, dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private async void btnExportExcel_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count>0)
            {
                ExcelHelper.ExportDataTableToExcel(await dAO_Slipout.GetWarehouseInOut(cbbWarehouse.SelectedValue.ToString(), cbbType.Text, dateTimePicker1.Value, dateTimePicker2.Value));
            }
        }
    }
}
