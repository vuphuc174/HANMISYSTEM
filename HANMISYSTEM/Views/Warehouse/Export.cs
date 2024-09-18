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
    public partial class Export : Form
    {
        public Export()
        {
            InitializeComponent();
        }
        DAO_Warehouse dAO_Warehouse = new DAO_Warehouse();
        DAO_PackingInfo dAO_PackingInfo = new DAO_PackingInfo();
        DAO_Slipout dAO_Slipout = new DAO_Slipout();
        DAO_Product dAO_Product = new DAO_Product();
        DAO_SlipoutInfo dAO_SlipoutInfo = new DAO_SlipoutInfo();
        DAO_Stock dAO_Stock = new DAO_Stock();
        Dbconnect connect = new Dbconnect();

        private async void txtScan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && !string.IsNullOrEmpty(txtScan.Text))
            {
                if (StringHelper.ContainsSpecialCharacters(txtScan.Text))
                {
                    lbmessage.Items.Insert(0, DateTime.UtcNow.AddHours(7).ToString() + ":" + txtScan.Text + ":Mã có chứa ký tự không hợp lệ ");
                    txtScan.Text = "";
                }
                else
                {
                    if (CheckExisted(txtScan.Text))
                    {
                        lbmessage.Items.Insert(0, DateTime.UtcNow.AddHours(7).ToString() + ":" + txtScan.Text + ":Mã box này đã có sẵn để đóng gói ");
                        txtScan.Text = "";
                    }
                    else
                    {
                        DataTable dtPackage = await dAO_PackingInfo.GetPackageInfoByIDAndWarehouse(txtScan.Text, cbbEWarehouse.SelectedValue.ToString());
                        if (dtPackage.Rows.Count > 0)
                        {
                            dgvPackageList.Rows.Add(dtPackage.Rows[0]["idpack"].ToString(), dtPackage.Rows[0]["partno"].ToString(), dtPackage.Rows[0]["quantity"].ToString(), dtPackage.Rows[0]["quantity"].ToString(), "");
                            txtScan.Text = "";
                        }
                        else
                        {
                            lbmessage.Items.Insert(0, DateTime.UtcNow.AddHours(7).ToString() + ":" + txtScan.Text + ":Mã box này không có sẵn! ");
                            txtScan.Text = "";
                        }
                    }
                }


            }
        }
        private bool CheckExisted(string packageID)
        {
            for (int i = 0; i < dgvPackageList.Rows.Count; i++)
            {
                if (packageID == dgvPackageList.Rows[i].Cells["PackageID_col"].Value.ToString())
                {
                    return true;
                }
            }
            return false;
        }
        private void Export_Load(object sender, EventArgs e)
        {
            DataTable dtcheckpermission = connect.readdata($"select t.idwarehouse,namewarehouse from tbl_user_permission t inner join warehouse w on t.idwarehouse=w.idwarehouse where username ='{UserSession.UserName}'");

            if (dtcheckpermission.Rows.Count > 0)
            {
                cbbEWarehouse.DataSource = dtcheckpermission;
                cbbEWarehouse.ValueMember = "idwarehouse";
                cbbEWarehouse.DisplayMember = "namewarehouse";
            }
        }
        public class PartSummary
        {
            public int Index { get; set; }
            public string PartNo { get; set; }
            public string PartName { get; set; }
            public int SumQuantity { get; set; }
        }
        private async Task UpdateExportList()
        {
            List<PartSummary> partSummaries = new List<PartSummary>();
            foreach (DataGridViewRow row in dgvPackageList.Rows)
            {
                // Assuming the "partno" column is at index 0 and the "quantity" column is at index 1
                string partNo = row.Cells["PartNo_col"].Value?.ToString();
                int quantity = 0;

                if (row.Cells[1].Value != null && int.TryParse(row.Cells["Quantity_col"].Value.ToString(), out quantity))
                {
                    // Check if the partNo already exists in partSummaries
                    PartSummary existingSummary = partSummaries.FirstOrDefault(ps => ps.PartNo == partNo);

                    if (existingSummary != null)
                    {
                        // If it exists, update the quantity
                        existingSummary.SumQuantity += quantity;
                    }
                    else
                    {
                        // If it doesn't exist, create a new PartSummary
                        partSummaries.Add(new PartSummary { Index = partSummaries.Count, PartNo = partNo, PartName = await dAO_Product.GetPartName(partNo), SumQuantity = quantity });
                    }
                }
            }

            // Bind the summarized data to dataGridView2
            dgvExportList.DataSource = partSummaries;
            lbPackageCount.Text = dgvPackageList.Rows.Count.ToString();
        }
        private async void dgvPackageList_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            await UpdateExportList();
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true; // Loại bỏ ký tự không hợp lệ
            }

            // Đảm bảo chỉ có một dấu thập phân được phép
            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text.Contains(".") || textBox.Text.Contains(","))
                {
                    e.Handled = true; // Loại bỏ dấu thập phân nếu đã tồn tại trong ô
                }
            }
        }
        private async void dgvPackageList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPackageList.Columns[e.ColumnIndex].Name == "Quantity_col")
            {
                double eQty;
                double limit = Convert.ToDouble(dgvPackageList.Rows[e.RowIndex].Cells["Limit_col"].Value.ToString());
                if (double.TryParse(dgvPackageList.Rows[e.RowIndex].Cells["Quantity_col"].Value.ToString(), out eQty))
                {
                    if (eQty > limit || eQty <= 0)
                    {
                        MessageBox.Show("Số lượng không hợp lệ!");
                        dgvPackageList.Rows[e.RowIndex].Cells["Quantity_col"].Value = limit;
                    }
                }
                else
                {
                    MessageBox.Show("Số nhập vào không hợp lệ!");
                    dgvPackageList.Rows[e.RowIndex].Cells["Quantity_col"].Value = limit;
                }
                await UpdateExportList();
            }

        }

        private void dgvPackageList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox textBox)
            {
                // Gắn sự kiện KeyPress cho ô kiểu TextBox
                textBox.KeyPress += TextBox_KeyPress;
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvPackageList.SelectedRows)
            {
                if (item.Index != -1)
                {
                    dgvPackageList.Rows.RemoveAt(item.Index);
                }

            }
        }

        private async void cbbIWarehouse_Click(object sender, EventArgs e)
        {
            string cmd = "select t.idwarehouse,namewarehouse from tbl_user_e_permission t inner join warehouse w on t.idwarehouse=w.idwarehouse where t.idwarehouse <> '" + cbbEWarehouse.SelectedValue + "' and username ='" + UserSession.UserName + "'";
            DataTable dt2 = await connect.ReadDataAsync(cmd);
            cbbIWarehouse.DataSource = dt2;
            cbbIWarehouse.ValueMember = "idwarehouse";
            cbbIWarehouse.DisplayMember = "namewarehouse";
        }
        private async Task<string> GetSlipoutID()
        {
            string prefix = await dAO_Warehouse.GetSign(cbbEWarehouse.SelectedValue.ToString()) + await dAO_Warehouse.GetSign(cbbIWarehouse.SelectedValue.ToString());
            string md = DateTime.Now.ToString("yyyyMMdd");
            int serial = await dAO_Slipout.GetTotalToday(prefix) + 1;
            return prefix + md + serial.ToString("0000");
        }
        private async void btnExport_Click(object sender, EventArgs e)
        {
            string iwh = cbbIWarehouse.SelectedValue.ToString();
            string id;
            //double temp = 0;
            if (cbbEWarehouse.Text == "" || cbbIWarehouse.Text == "" || dgvPackageList.Rows.Count < 1)
            {
                MessageBox.Show("Không được bỏ trống thông tin !");
            }
            else
            {
                string cateID = await dAO_Warehouse.GetCategoryID(cbbIWarehouse.SelectedValue.ToString());
                switch (cateID)
                {
                    case "W3": //supplier
                               //update delivery plan
                               //foreach (DataGridViewRow row in dgvExportList.Rows)
                               //{
                               //    DataTable dtdeliveryplan = connect.readdata($"select PartNo,Quantity,ProductionDate,Delivered,(Quantity-isnull(Delivered,0)) as Shortage from DeliveryPlan where IdWarehouse='{iwh}' and ProductionDate >= Convert(date,getdate()) and PartNo='" + row.Cells["PartNo_Fn_col"].Value.ToString() + "' order by Shortage desc");
                               //    temp = Convert.ToDouble(row.Cells["Quantity_FN_col"].Value.ToString());
                               //    int i = 0;
                               //    while (temp > 0 && Convert.ToDouble(dtdeliveryplan.Rows[i]["Shortage"].ToString()) != 0)
                               //    {
                               //        shortage = Convert.ToDouble(dtdeliveryplan.Rows[i]["Shortage"].ToString());

                        //        if (temp <= shortage)
                        //        {
                        //            DateTime dt = Convert.ToDateTime(dtdeliveryplan.Rows[i]["ProductionDate"].ToString());
                        //            connect.exedata("update DeliveryPlan set Delivered =isnull(Delivered,0) + " + temp + " where PartNo ='" + row.Cells["Partno1"].Value.ToString() + "' and IdWarehouse='" + cbiwarehouse.SelectedValue.ToString() + "' and ProductionDate='" + dt.ToString("yyyy-MM-dd") + "'");
                        //            temp = 0;
                        //            break;
                        //        }
                        //        else
                        //        {
                        //            connect.exedata("update DeliveryPlan set Delivered =Quantity where PartNo ='" + row.Cells["Partno1"].Value.ToString() + "' ");
                        //            temp = temp - shortage;

                        //        }
                        //        i++;
                        //    }
                        //}
                        // xu ly ton kho

                        //toa hoa don 
                        id = await GetSlipoutID();
                        if (await dAO_Slipout.AddNew(id, cbbEWarehouse.SelectedValue.ToString(), cbbIWarehouse.SelectedValue.ToString(), "Compeleted"))
                        {
                            foreach (DataGridViewRow row in dgvPackageList.Rows)
                            {
                                await dAO_SlipoutInfo.AddNew(id, row.Cells["PackageID_col"].Value.ToString(), row.Cells["Quantity_col"].Value.ToString(), row.Cells["Remark_col"].Value.ToString(), row.Cells["Partno_col"].Value.ToString(), "");
                                //xuat chan
                                if (Convert.ToDouble(row.Cells["Quantity_col"].Value) == Convert.ToDouble(row.Cells["Limit_col"].Value))
                                {
                                    await dAO_PackingInfo.RemovePackage(row.Cells["PackageID_col"].Value.ToString());
                                }
                                //xuat le
                                else
                                {
                                    double remain = Convert.ToDouble(row.Cells["Limit_col"].Value.ToString()) - Convert.ToDouble(row.Cells["Quantity_col"].Value.ToString());
                                    await dAO_PackingInfo.UpdatePackageQuantity(row.Cells["PackageID_col"].Value.ToString(), remain.ToString());
                                }
                            }
                            dgvPackageList.Rows.Clear();
                            using (Printing_Slipout frm = new Printing_Slipout())
                            {
                                frm._slipoutID = id;
                                frm.lbinvoice.Text = id;
                                frm.lbewarehouse.Text = cbbEWarehouse.Text;
                                frm.lbiwarehouse.Text = cbbIWarehouse.Text;
                                //frm.lbcarnumber.Text = cbbdriver.Text;
                                //frm.lbdriver.Text = cbbdriver.SelectedValue.ToString();
                                //frm.lbreason.Text = txtreason.Text;

                                frm.ShowDialog();
                                lbmessage.Items.Clear();
                                dgvPackageList.Rows.Clear();
                            } 
                        }
                        else
                        {
                            MessageBox.Show("Lỗi ,xin thử lại hoặc liên hệ administrator");
                        }

                        break;
                    case "W1":
                        id = await GetSlipoutID();
                        if (await dAO_Warehouse.CheckApprovalStatus(iwh))
                        {
                            try
                            {
                                if (await dAO_Slipout.AddNew(id, cbbEWarehouse.SelectedValue.ToString(), cbbIWarehouse.SelectedValue.ToString(), "Pending"))
                                {
                                    foreach (DataGridViewRow row in dgvPackageList.Rows)
                                    {
                                        await dAO_SlipoutInfo.AddNew(id, row.Cells["PackageID_col"].Value.ToString(), row.Cells["Quantity_col"].Value.ToString(), row.Cells["Remark_col"].Value.ToString(), row.Cells["Partno_col"].Value.ToString(), "");
                                        await dAO_PackingInfo.MovePackage(row.Cells["PackageID_col"].Value.ToString(), "WH023");
                                    }
                                    using (Printing_Slipout frm = new Printing_Slipout())
                                    {
                                        frm._slipoutID = id;
                                        frm.lbinvoice.Text = id;
                                        frm.lbewarehouse.Text = cbbEWarehouse.Text;
                                        frm.lbiwarehouse.Text = cbbIWarehouse.Text;
                                        //frm.lbcarnumber.Text = cbbdriver.Text;
                                        //frm.lbdriver.Text = cbbdriver.SelectedValue.ToString();
                                        //frm.lbreason.Text = txtreason.Text;

                                        frm.ShowDialog();
                                        lbmessage.Items.Clear();
                                        dgvPackageList.Rows.Clear();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Xuất hàng không thành công ,xin vui lòng thử lại sau hoặc báo cho admin");
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error " + ex.ToString());
                            }
                        }
                        else
                        {
                            try
                            {
                                if (await dAO_Slipout.AddNew(id, cbbEWarehouse.SelectedValue.ToString(), cbbIWarehouse.SelectedValue.ToString(), "Completed"))
                                {
                                    foreach (DataGridViewRow row in dgvPackageList.Rows)
                                    {
                                        await dAO_SlipoutInfo.AddNew(id, row.Cells["PackageID_col"].Value.ToString(), row.Cells["Quantity_col"].Value.ToString(), row.Cells["Remark_col"].Value.ToString(), row.Cells["Partno_col"].Value.ToString(), "");
                                        await dAO_PackingInfo.MovePackage(row.Cells["PackageID_col"].Value.ToString(), iwh);
                                    }
                                    //in hoa don
                                    using (Printing_Slipout frm = new Printing_Slipout())
                                    {
                                        frm._slipoutID = id;
                                        frm.lbinvoice.Text = id;
                                        frm.lbewarehouse.Text = cbbEWarehouse.Text;
                                        frm.lbiwarehouse.Text = cbbIWarehouse.Text;
                                        //frm.lbcarnumber.Text = cbbdriver.Text;
                                        //frm.lbdriver.Text = cbbdriver.SelectedValue.ToString();
                                        //frm.lbreason.Text = txtreason.Text;

                                        frm.ShowDialog();
                                        lbmessage.Items.Clear();
                                        dgvPackageList.Rows.Clear();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Xuất hàng không thành công ,xin vui lòng thử lại sau hoặc báo cho admin");
                                }





                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error " + ex.ToString());
                            }
                        }
                        break;
                    default: //prod,ng,lost warehouse,outsource
                        id = await GetSlipoutID();
                        if (await dAO_Slipout.AddNew(id, cbbEWarehouse.SelectedValue.ToString(), cbbIWarehouse.SelectedValue.ToString(), "Completed"))
                        {
                            foreach (DataGridViewRow row in dgvPackageList.Rows)
                            {
                                await dAO_SlipoutInfo.AddNew(id, row.Cells["PackageID_col"].Value.ToString(), row.Cells["Quantity_col"].Value.ToString(), row.Cells["Remark_col"].Value.ToString(), row.Cells["Partno_col"].Value.ToString(), "");
                                //xuat chan
                                if (Convert.ToDouble(row.Cells["Quantity_col"].Value.ToString()) == Convert.ToDouble(row.Cells["Limit_col"].Value.ToString()))
                                {

                                    if (cateID == "W2" || cateID == "W3" || cateID == "W4")
                                    {
                                        await dAO_PackingInfo.RemovePackage(row.Cells["PackageID_col"].Value.ToString());
                                        // xuat ra factory
                                        if (cateID == "W2")
                                        {
                                            await dAO_Stock.AddStock(row.Cells["Partno_col"].Value.ToString(), cbbIWarehouse.SelectedValue.ToString(), row.Cells["Quantity_col"].Value.ToString());
                                        }
                                    }
                                    else
                                    {
                                        await dAO_PackingInfo.MovePackage(row.Cells["PackageID_col"].Value.ToString(), cbbIWarehouse.SelectedValue.ToString());
                                    }
                                }
                                //xuat le
                                else
                                {
                                    if (cateID == "W2")
                                    {
                                        await dAO_Stock.AddStock(row.Cells["Partno_col"].Value.ToString(), iwh, row.Cells["Quantity_col"].Value.ToString());
                                    }
                                    double remain = Convert.ToDouble(row.Cells["Limit_col"].Value.ToString()) - Convert.ToDouble(row.Cells["Quantity_col"].Value.ToString());
                                    await dAO_PackingInfo.UpdatePackageQuantity(row.Cells["PackageID_col"].Value.ToString(), remain.ToString());
                                }
                            }
                            //in hd
                            using (Printing_Slipout frm = new Printing_Slipout())
                            {
                                frm._slipoutID = id;
                                frm.lbinvoice.Text = id;
                                frm.lbewarehouse.Text = cbbEWarehouse.Text;
                                frm.lbiwarehouse.Text = cbbIWarehouse.Text;
                                //frm.lbcarnumber.Text = cbbdriver.Text;
                                //frm.lbdriver.Text = cbbdriver.SelectedValue.ToString();
                                //frm.lbreason.Text = txtreason.Text;

                                frm.ShowDialog();
                                lbmessage.Items.Clear();
                                dgvPackageList.Rows.Clear();
                            }
                        }
                        break;
                }
            }
        }
    }
}
