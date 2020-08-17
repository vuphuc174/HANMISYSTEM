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
    public partial class DeliveryResultDetail : Form
    {
        public DeliveryResultDetail()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        DataTable dtwarehouse;
        DataTable dtProductionKind;
        DataTable dtDeliveryResult;
        private void DeliveryResultDetail_Load(object sender, EventArgs e)
        {
            dtwarehouse = connect.readdata("select * from warehouse where idcategory='W3'");
            cbCustomer.DataSource = dtwarehouse;
            cbCustomer.DisplayMember = "namewarehouse";
            cbCustomer.ValueMember = "idwarehouse";
            cbStatus.Text = "Tất cả";

            dtProductionKind = connect.readdata("Select Name from ProductKind");
            cbProductionKind.DataSource = dtProductionKind;
            cbProductionKind.DisplayMember = "Name";
            dtProductionKind.Rows.Add("ALL");

            dtDeliveryResult = connect.readdata("select top 20 from view_delivery_detail_all");
            dataGridView1.DataSource = dtDeliveryResult;
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (cbStatus.Text)
            //{
            //    case "Tất cả":
            //        dtDeliveryResult = connect.readdata("select * from view_delivery_detail_all");
            //        dataGridView1.DataSource = dtDeliveryResult;
            //        break;
            //    case "Đã hoàn thành":
            //        dtDeliveryResult = connect.readdata("select * from view_delivery_detail_all where Delivered=Quantity");
            //        dataGridView1.DataSource = dtDeliveryResult;
            //        break;
            //    case "Chưa hoàn thành":
            //        dtDeliveryResult = connect.readdata("select * from view_delivery_detail_all where isnull(Delivered,0) <Quantity");
            //        dataGridView1.DataSource = dtDeliveryResult;
            //        break;
            //    default:
            //        dtDeliveryResult = connect.readdata("select * from view_delivery_detail_all");
            //        dataGridView1.DataSource = dtDeliveryResult;
            //        break;
            //}
        }

        private void cbProductionKind_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            if (cbProductionKind.Text == "ALL")
            {
                switch (cbStatus.Text)
                {
                    case "Tất cả":
                        dtDeliveryResult = connect.readdata("select * from view_delivery_detail_all where ProductionDate between '" + dtpfrom.Value + "' and '" + dtpto.Value + "'");
                        dataGridView1.DataSource = dtDeliveryResult;
                        break;
                    case "Đã hoàn thành":
                        dtDeliveryResult = connect.readdata("select * from view_delivery_detail_all where Delivered=Quantity and ProductionDate between '" + dtpfrom.Value + "' and '" + dtpto.Value + "'");
                        dataGridView1.DataSource = dtDeliveryResult;
                        break;
                    case "Chưa hoàn thành":
                        dtDeliveryResult = connect.readdata("select * from view_delivery_detail_all where isnull(Delivered,0) <Quantity and ProductionDate between '" + dtpfrom.Value + "' and '" + dtpto.Value + "'");
                        dataGridView1.DataSource = dtDeliveryResult;
                        break;
                    default:
                        dtDeliveryResult = connect.readdata("select * from view_delivery_detail_all and ProductionDate between '" + dtpfrom.Value + "' and '" + dtpto.Value + "'");
                        dataGridView1.DataSource = dtDeliveryResult;
                        break;
                }
            }
            else
            {
                switch (cbStatus.Text)
                {
                    case "Tất cả":
                        dtDeliveryResult = connect.readdata("select * from view_delivery_detail_all where ProductionDate between '" + dtpfrom.Value + "' and '" + dtpto.Value + "' and Model='" + cbProductionKind.Text + "'");
                        dataGridView1.DataSource = dtDeliveryResult;
                        break;
                    case "Đã hoàn thành":
                        dtDeliveryResult = connect.readdata("select * from view_delivery_detail_all where Delivered=Quantity and ProductionDate between '" + dtpfrom.Value + "' and '" + dtpto.Value + "' and Model='" + cbProductionKind.Text + "'");
                        dataGridView1.DataSource = dtDeliveryResult;
                        break;
                    case "Chưa hoàn thành":
                        dtDeliveryResult = connect.readdata("select * from view_delivery_detail_all where isnull(Delivered,0) <Quantity and ProductionDate between '" + dtpfrom.Value + "' and '" + dtpto.Value + "' and Model='" + cbProductionKind.Text + "'");
                        dataGridView1.DataSource = dtDeliveryResult;
                        break;
                    default:
                        dtDeliveryResult = connect.readdata("select * from view_delivery_detail_all and ProductionDate between '" + dtpfrom.Value + "' and '" + dtpto.Value + "' and Model='" + cbProductionKind.Text + "'");
                        dataGridView1.DataSource = dtDeliveryResult;
                        break;
                }
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dtDeliveryResult.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "partno", txtsearch.Text);
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            ExportToExcel _excel = new ExportToExcel();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _excel.ExportToExcelFunction(dtDeliveryResult, saveFileDialog1.FileName.ToString());
            }
        }
    }
}
