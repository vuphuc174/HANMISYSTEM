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
    public partial class ApprovalFrm : Form
    {
        public ApprovalFrm()
        {
            InitializeComponent();
        }
        Dbconnect dbconnect = new Dbconnect();
        private void ApprovalFrm_Load(object sender, EventArgs e)
        {
            DataTable dtwarehouse = dbconnect.readdata("select t.idwarehouse,w.namewarehouse from tbl_user t inner join warehouse w on t.idwarehouse=w.idwarehouse where username='" + HANMISYSTEM.Properties.Settings.Default.username + "'");
            if (dtwarehouse.Rows.Count > 0)
            {
                txtwarehouse.Text = dtwarehouse.Rows[0]["idwarehouse"].ToString();
                txtNameWarehouse.Text = dtwarehouse.Rows[0]["namewarehouse"].ToString();
                DataTable dtRequestList = dbconnect.readdata("select s.idslipout,s.dateout,count(si.idslipout) as PackageQuantity,sum(si.quantity) as Quantity from slipout s inner join slipoutinfo si on s.idslipout =si.idslipout where idcustomer ='" + txtwarehouse.Text + "' and status='Pending' group by s.idslipout,s.dateout");
                dataGridView1.DataSource = dtRequestList;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MainFrm frm = new MainFrm();
            
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
        e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Approval")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn đã kiểm tra kỹ phiếu xuất", "Xac nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DataTable dtList = dbconnect.readdata("select idpack from slipoutinfo where idslipout = '" + dataGridView1.Rows[e.RowIndex].Cells["idslipout"].Value.ToString() + "'");
                    DataTable dtCustomer = dbconnect.readdata("select idcustomer from slipout where idslipout ='" + dataGridView1.Rows[e.RowIndex].Cells["idslipout"].Value.ToString() + "'");
                    //chuyen tu kho tam sang kho chinh
                    if (dtList.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtList.Rows.Count; i++)
                        {
                            dbconnect.exedata("update packinginfo set idwarehouse='" + dtCustomer.Rows[0]["idcustomer"].ToString() + "' where idpack='" + dtList.Rows[i]["idpack"].ToString() + "'");
                        }
                    }
                    //update request
                    DataTable dtwarehouse = dbconnect.readdata("select t.idwarehouse,w.namewarehouse from tbl_user t inner join warehouse w on t.idwarehouse=w.idwarehouse where username='" + HANMISYSTEM.Properties.Settings.Default.username + "'");
                    if (dtwarehouse.Rows.Count > 0)
                    {
                        frm.request = dbconnect.countdata("select count(idslipout) from slipout where idcustomer='" + dtwarehouse.Rows[0]["idwarehouse"].ToString() + "' and status ='Pending'");

                    }
                    frm.Controls.Find("btnApproval", true).FirstOrDefault().Text = "Yêu cầu xác nhận (" + frm.request + ")";
                    //doi trang thai trong phieu xuat
                    dbconnect.exedata("update slipout set status ='Approval' where idslipout ='" + dataGridView1.Rows[e.RowIndex].Cells["idslipout"].Value.ToString() + "' ");
                    //Them lich su xac nhan 

                }

            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
        e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Reject")
            {
                DialogResult dialogResult = MessageBox.Show("Xin hãy cân nhắc trước khi trả hàng", "Xac nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DataTable dtList = dbconnect.readdata("select idpack from slipoutinfo where idslipout = '" + dataGridView1.Rows[e.RowIndex].Cells["idslipout"].Value.ToString() + "'");
                    DataTable dtWarehouse = dbconnect.readdata("select idwarehouse from slipout where idslipout ='" + dataGridView1.Rows[e.RowIndex].Cells["idslipout"].Value.ToString() + "'");
                    //chuyen tu kho tam sang kho chinh
                    if (dtList.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtList.Rows.Count; i++)
                        {
                            dbconnect.exedata("update packinginfo set idwarehouse='" + dtWarehouse.Rows[0]["idwarehouse"].ToString() + "' where idpack='" + dtList.Rows[i]["idpack"].ToString() + "'");
                        }
                    }

                    //doi trang thai trong phieu xuat
                    dbconnect.exedata("update slipout set status ='Rejected' where idslipout ='" + dataGridView1.Rows[e.RowIndex].Cells["idslipout"].Value.ToString() + "' ");
                    //Them lich su xac nhan 

                }
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
        e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Details")
            {
                EditInvoice fr = new EditInvoice();
                if (e.RowIndex > -1 && e.ColumnIndex != 0)
                {
                    fr.lbinvoice.Text = dataGridView1.Rows[e.RowIndex].Cells["idslipout"].Value.ToString();

                    DataTable dt = dbconnect.readdata("select distinct idpack,partno,quantity from ioview where idslipout='" + dataGridView1.Rows[e.RowIndex].Cells["idslipout"].Value.ToString() + "'");
                    fr.dataGridView1.DataSource = dt;
                    fr.ShowDialog();
                }
                else
                {

                }
            }

            DataTable dtwarehouse1 = dbconnect.readdata("select t.idwarehouse,w.namewarehouse from tbl_user t inner join warehouse w on t.idwarehouse=w.idwarehouse where username='" + HANMISYSTEM.Properties.Settings.Default.username + "'");
            if (dtwarehouse1.Rows.Count > 0)
            {
                txtwarehouse.Text = dtwarehouse1.Rows[0]["idwarehouse"].ToString();
                txtNameWarehouse.Text = dtwarehouse1.Rows[0]["namewarehouse"].ToString();
                DataTable dtRequestList = dbconnect.readdata("select s.idslipout,s.dateout,count(si.idslipout) as PackageQuantity,sum(si.quantity) as Quantity from slipout s inner join slipoutinfo si on s.idslipout =si.idslipout where idcustomer ='" + txtwarehouse.Text + "' and status='Pending' group by s.idslipout,s.dateout");
                dataGridView1.DataSource = dtRequestList;
            }
        }

    }
}
