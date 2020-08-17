using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Globalization;
using System.Data.SqlClient;

namespace HANMISYSTEM
{
    public partial class Deliverygoods : Form
    {
        private bool check = true;
        private double sumqty = 0;
        public Deliverygoods()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private void cbewarehouse_Click(object sender, EventArgs e)
        {



        }

        private void cbiwarehouse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbewarehouse.Text) == false)
            {
                DataTable dt1 = connect.readdata("select t.idwarehouse,namewarehouse from tbl_user_e_permission t inner join warehouse w on t.idwarehouse=w.idwarehouse where t.idwarehouse <> '" + cbewarehouse.SelectedValue + "' and username ='" + HANMISYSTEM.Properties.Settings.Default.username + "'");
                cbiwarehouse.DataSource = dt1;
                cbiwarehouse.ValueMember = "idwarehouse";
                cbiwarehouse.DisplayMember = "namewarehouse";
            }
            else
            {
                DataTable dt2 = connect.readdata("select select t.idwarehouse,namewarehouse from tbl_user_e_permission t inner join warehouse w on t.idwarehouse=w.idwarehouse from tbl_user_e_permission where username ='" + HANMISYSTEM.Properties.Settings.Default.username + "'");
                cbiwarehouse.DataSource = dt2;
                cbiwarehouse.ValueMember = "idwarehouse";
                cbiwarehouse.DisplayMember = "namewarehouse";
            }

        }

        private void cbiwarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            if (cbiwarehouse.Text != "")
            {
                DataTable dtworkorder = connect.readdata("select PartNo,ProductionDate,Quantity,isnull(Delivered,0) as Delivered from DeliveryPlan where IdWarehouse='" + cbiwarehouse.SelectedValue.ToString() + "' and ProductionDate>=CONVERT(date,getdate())");
                if (dtworkorder != null)
                {
                    dgvworkorder.DataSource = dtworkorder;
                }
                DataTable dtcategory = connect.readdata("select idcategory from warehouse where idwarehouse ='" + cbiwarehouse.SelectedValue.ToString() + "'");
                txtinvoice.Text = "";
                if (dtcategory.Rows.Count > 0)
                {
                    if (dtcategory.Rows[0]["idcategory"].ToString() == "W4" || dtcategory.Rows[0]["idcategory"].ToString() == "W3")
                    {
                        dataGridView2.Columns["boxqty"].ReadOnly = false;
                        label5.Visible = true;
                        cbbdriver.Visible = true;
                    }
                    else if (dtcategory.Rows[0]["idcategory"].ToString() == "W2")
                    {
                        dataGridView2.Columns["boxqty"].ReadOnly = false;
                    }
                    else
                    {
                        dataGridView2.Columns["boxqty"].ReadOnly = true;
                        label5.Visible = false;
                        cbbdriver.Visible = false;
                    }
                }

            }

        }

        private void txtboxno_TextChanged(object sender, EventArgs e)
        {
            double maxty;
            double curqty;
            double boxqty;
            if (cbiwarehouse.Text == "")
            {
                MessageBox.Show("Xin hãy chọn một kho");
                txtboxno.Text = "";
            }
            else
            {
                if (txtboxno.Text.Length >= 14)
                {
                    DataTable dt;
                    DataTable dtuser = connect.readdata("select idwarehouse from tbl_user where username='" + HANMISYSTEM.Properties.Settings.Default.username + "'");
                    if (dtuser.Rows.Count > 0)
                    {
                        if (dtuser.Rows[0]["idwarehouse"].ToString() == "WH006")
                        {
                            dt = connect.readdata("select idpack,partno,quantity,position from packinginfo where idpack='" + txtboxno.Text + "' and idwarehouse='" + cbewarehouse.SelectedValue + "' or idpack='" + txtboxno.Text + "' and idwarehouse='WH002'");
                        }
                        else
                        {
                            dt = connect.readdata("select idpack,partno,quantity,position from packinginfo where idpack='" + txtboxno.Text + "' and idwarehouse='" + cbewarehouse.SelectedValue + "'");
                        }
                    }
                    else
                    {
                        dt = connect.readdata("select idpack,partno,quantity,position from packinginfo where idpack='" + txtboxno.Text + "' and idwarehouse='" + cbewarehouse.SelectedValue + "'");
                    }
                    if (dt.Rows.Count > 0)
                    {
                        boxqty = Convert.ToDouble(dt.Rows[0]["quantity"].ToString());
                        if (dataGridView2.Rows.Count >= 1)
                        {
                            for (int i = 0; i < dataGridView2.Rows.Count; i++)
                            {
                                if (dt.Rows[0]["idpack"].ToString() == dataGridView2.Rows[i].Cells[0].Value.ToString())
                                {
                                    check = false;
                                }
                            }
                        }
                        if (check == false)
                        {
                            lbmessage.Items.Insert(0, DateTime.UtcNow.AddHours(7).ToString() + ":" + txtboxno.Text + ":Mã box này đã có sẵn để đóng gói ");
                            txtboxno.Text = "";
                            txtboxno.Focus();
                            check = true;
                        }
                        else
                        {
                        gohere:
                            DataTable dtwarehousecategory = connect.readdata("select idcategory from warehouse where idwarehouse='" + cbiwarehouse.SelectedValue.ToString() + "'");
                            if (dtwarehousecategory.Rows[0]["idcategory"].ToString() == "W3")
                            {
                                if (connect.countdata("select count(*) from DeliveryPlan where idwarehouse='" + cbiwarehouse.SelectedValue.ToString() + "' and partno='" + dt.Rows[0]["partno"].ToString() + "' and ProductionDate >= Convert(date,getdate())") != 0)
                                {
                                    DataTable dtmaxqty = connect.readdata("select (SUM(quantity)-isnull(SUM(Delivered),0)) as maxqty from DeliveryPlan where ProductionDate>=CONVERT(date,getdate()) and PartNo='" + dt.Rows[0]["partno"].ToString() + "' and IdWarehouse='" + cbiwarehouse.SelectedValue.ToString() + "' group by PartNo");
                                    curqty = 0;
                                    foreach (DataGridViewRow row in dataGridView4.Rows)
                                    {
                                        if (row.Cells["Partno1"].Value.ToString() == dt.Rows[0]["partno"].ToString())
                                        {
                                            curqty = curqty + Convert.ToDouble(row.Cells["quantity1"].Value.ToString());
                                        }
                                    }
                                    // neu maxqty<0
                                    if (dtmaxqty.Rows.Count <= 0 || Convert.ToDouble(dtmaxqty.Rows[0]["maxqty"].ToString()) - curqty<=0 || Convert.ToDouble(dt.Rows[0]["quantity"].ToString()) > Convert.ToDouble(dtmaxqty.Rows[0]["maxqty"].ToString()))
                                    {
                                        //MessageBox.Show("Đã giao hàng đủ kế hoạch");
                                        //txtboxno.Text = "";
                                        connect.exedata("update DeliveryPlan set Quantity =Quantity + '" + Convert.ToDouble(dt.Rows[0]["quantity"].ToString()) + "'");
                                        goto gohere;
                                    }
                                    else
                                    {
                                        maxty = Convert.ToDouble(dtmaxqty.Rows[0]["maxqty"].ToString()) - curqty;
                                        if (maxty >= boxqty)
                                        {
                                            sumqty = 0;
                                            dataGridView2.Rows.Add(dt.Rows[0]["idpack"].ToString(), dt.Rows[0]["partno"].ToString(), dt.Rows[0]["quantity"].ToString(), "0", "", dt.Rows[0]["position"].ToString());
                                            txtboxno.Text = "";
                                            for (int j = 0; j < dataGridView2.Rows.Count; j++)
                                            {
                                                sumqty = sumqty + Convert.ToDouble(dataGridView2.Rows[j].Cells["boxqty"].Value);
                                            }
                                            txtsumqty.Text = sumqty.ToString();
                                        }
                                        else
                                        {

                                            sumqty = 0;
                                            dataGridView2.Rows.Add(dt.Rows[0]["idpack"].ToString(), dt.Rows[0]["partno"].ToString(), dt.Rows[0]["quantity"].ToString(), "0", "", dt.Rows[0]["position"].ToString());
                                            txtboxno.Text = "";
                                            for (int j = 0; j < dataGridView2.Rows.Count; j++)
                                            {
                                                sumqty = sumqty + Convert.ToDouble(dataGridView2.Rows[j].Cells["boxqty"].Value);
                                            }
                                            txtsumqty.Text = sumqty.ToString();
                                        }
                                    }

                                }
                                //chua co ke hoach giao hang
                                else
                                {
                                    //MessageBox.Show("Chưa có kế hoạch giao hàng");
                                    //txtboxno.Text = "";
                                    connect.exedata("insert into DeliveryPlan (Partno,Idwarehouse,ProductionDate,Quantity) values ('" + dt.Rows[0]["partno"].ToString() + "','" + cbiwarehouse.SelectedValue.ToString() + "',Convert(date,getdate()),'" + dt.Rows[0]["quantity"].ToString() + "')");
                                    goto gohere;
                                }
                            }
                            else
                            {
                                sumqty = 0;
                                dataGridView2.Rows.Add(dt.Rows[0]["idpack"].ToString(), dt.Rows[0]["partno"].ToString(), dt.Rows[0]["quantity"].ToString(), "0", "", dt.Rows[0]["position"].ToString());
                                txtboxno.Text = "";
                                for (int j = 0; j < dataGridView2.Rows.Count; j++)
                                {

                                    sumqty = sumqty + Convert.ToDouble(dataGridView2.Rows[j].Cells["boxqty"].Value);
                                }
                                txtsumqty.Text = sumqty.ToString();
                            }

                        }

                    }
                    else
                    {
                        lbmessage.Items.Insert(0, DateTime.UtcNow.AddHours(7).ToString()+":" +txtboxno.Text + ":Mã box này không tồn tại "); ;
                        txtboxno.Text = "";
                        txtboxno.Focus();
                    }
                }
            }
        }


        private void Deliverygoods_Load(object sender, EventArgs e)
        {

            DataTable dtcheckpermission = connect.readdata("select t.idwarehouse,namewarehouse from tbl_user_permission t inner join warehouse w on t.idwarehouse=w.idwarehouse where username ='" + HANMISYSTEM.Properties.Settings.Default.username + "'");

            if (dtcheckpermission.Rows.Count > 0)
            {
                cbewarehouse.DataSource = dtcheckpermission;
                cbewarehouse.ValueMember = "idwarehouse";
                cbewarehouse.DisplayMember = "namewarehouse";
            }
            DataTable dtdriver = connect.readdata("select * from driver");
            cbbdriver.DataSource = dtdriver;
            cbbdriver.DisplayMember = "carnumber";
            cbbdriver.ValueMember = "name";

        }
        bool chk;
        private void btnexport_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private string r;
        private string mahoa(string str)
        {
            DataTable dtcategory = connect.readdata("select sign from warehouse where idwarehouse ='" + str + "'");
            try
            {
                r = dtcategory.Rows[0]["sign"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return r;
        }
        private void btnfn_Click(object sender, EventArgs e)
        {


            if (cbewarehouse.Text == "" || cbiwarehouse.Text == "")
            {
                MessageBox.Show("Make sure selected both from WH and to WH");
            }
            else
            {
                string str = mahoa(cbewarehouse.SelectedValue.ToString()) + mahoa(cbiwarehouse.SelectedValue.ToString());
                int a = connect.countdata("select count (*) from slipout where idslipout like'%" + str + "%' ") + 1;
                txtinvoice.Text = str + DateTime.Now.ToString("yyyyMM") + a.ToString("0000");
            }
        }

        private void cbewarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            txtinvoice.Text = "";
            //work order

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtinvoice_TextChanged(object sender, EventArgs e)
        {

        }


        private double qty;
        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView4.Rows.Clear();
            if (dataGridView2.Rows.Count > 0)
            {
                DataTable dt;
                dt = connect.readdata("select partname from cargo where partno='" + dataGridView2.Rows[0].Cells["partno"].Value + "'");
                dataGridView4.Rows.Add(dataGridView2.Rows[0].Cells["partno"].Value, dt.Rows[0]["partname"].ToString(), 0);
            }

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                chk = true;
                foreach (DataGridViewRow row in dataGridView4.Rows)
                {
                    if (dataGridView2.Rows[i].Cells["partno"].Value.ToString() == row.Cells["partno1"].Value.ToString())
                    {
                        chk = false;
                        break;
                    }
                }
                if (chk == true)
                {
                    DataTable dtcargo = connect.readdata("select partname from cargo where partno='" + dataGridView2.Rows[i].Cells["partno"].Value + "'");
                    dataGridView4.Rows.Add(dataGridView2.Rows[i].Cells["partno"].Value, dtcargo.Rows[0]["partname"].ToString(), 0);
                }
            }
            for (int i = 0; i < dataGridView4.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView2.Rows.Count; j++)
                {
                    if (dataGridView2.Rows[j].Cells["partno"].Value.ToString() == dataGridView4.Rows[i].Cells["partno1"].Value.ToString())
                    {
                        dataGridView4.Rows[i].Cells["quantity1"].Value = (Convert.ToDouble(dataGridView4.Rows[i].Cells["quantity1"].Value) + Convert.ToDouble(dataGridView2.Rows[j].Cells["boxqty"].Value)).ToString();
                    }

                }
            }

        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = connect.readdata("select * from packinginfo where idpack='" + dataGridView2.Rows[e.RowIndex].Cells["idpack"].Value + "' and idwarehouse ='" + cbewarehouse.SelectedValue + "'");

            try
            {
                qty = Convert.ToDouble(dt.Rows[0]["quantity"].ToString());
            }
            catch
            {

            }
            if (dataGridView2.Rows[e.RowIndex].Cells["boxqty"].Value == null || dataGridView2.Rows[e.RowIndex].Cells["boxqty"].Value.ToString() == "" || Convert.ToDouble(dataGridView2.Rows[e.RowIndex].Cells["boxqty"].Value) == 0 || Convert.ToDouble(dataGridView2.Rows[e.RowIndex].Cells["boxqty"].Value) > qty)
            {
                MessageBox.Show("Không hợp lệ !");
                dataGridView2.Rows[e.RowIndex].Cells["boxqty"].Value = qty;
                dataGridView2.Rows[e.RowIndex].Cells["Remain"].Value = 0;
            }
            else
            {
                dataGridView2.Rows[e.RowIndex].Cells["Remain"].Value = qty - Convert.ToDouble(dataGridView2.Rows[e.RowIndex].Cells["boxqty"].Value);
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
            {
                if(item.Index!=-1)
                {
                    dataGridView2.Rows.RemoveAt(item.Index);
                }
                
            }
            sumqty = 0;
            txtboxno.Text = "";
            for (int j = 0; j < dataGridView2.Rows.Count; j++)
            {
                sumqty = sumqty + Convert.ToDouble(dataGridView2.Rows[j].Cells["boxqty"].Value);
            }
            txtsumqty.Text = sumqty.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbwarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbwarehouse.Text != "")
            {
                txtpartno.Enabled = true;
                cbewarehouse.Text = cbwarehouse.Text;
            }
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            if (txtpartno.Text != "")
            {
                if (connect.countdata("select count(partno) from cargo where partno ='" + txtpartno.Text + "'") != 0)
                {
                    DataTable dtcheckposition = connect.readdata("select position,sl,datefirstin from view_checkposition where idwarehouse='" + cbwarehouse.SelectedValue + "' and partno='" + txtpartno.Text + "' order by datefirstin asc");
                    dataGridView3.DataSource = dtcheckposition;
                }
                else
                {
                    MessageBox.Show("Mã hàng không hợp lệ !");
                }
            }
            else
            {
                MessageBox.Show("Trống");
            }
        }

        private void cbwarehouse_Click(object sender, EventArgs e)
        {
            DataTable dtcheckpermission = connect.readdata("select t.idwarehouse,namewarehouse from tbl_user_permission t inner join warehouse w on t.idwarehouse=w.idwarehouse where username ='" + HANMISYSTEM.Properties.Settings.Default.username + "'");

            if (dtcheckpermission.Rows.Count > 0)
            {
                cbwarehouse.DataSource = dtcheckpermission;
                cbwarehouse.ValueMember = "idwarehouse";
                cbwarehouse.DisplayMember = "namewarehouse";
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                lbposition.Text = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
                DataTable dtcheckposition = connect.readdata("select Idpack,PartNo,Quantity,Packingdate from packinginfo where position='" + lbposition.Text + "' and partno='" + txtpartno.Text + "' and idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "'");
                dgvworkorder.DataSource = dtcheckposition;

            }
        }

        private void txtpartno_TextChanged(object sender, EventArgs e)
        {
            lbsearch.Visible = true;
            lbsearch.Items.Clear();
            DataTable dtsearch = connect.readdata("select top 10 partno from cargo where partno like '%" + txtpartno.Text + "%' or partname like '%" + txtpartno.Text + "%'");
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

        private void dataGridView2_ColumnStateChanged(object sender, DataGridViewColumnStateChangedEventArgs e)
        {

        }

        private void dataGridView2_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

            DataTable dtcategory = connect.readdata("select idcategory from warehouse where idwarehouse ='" + cbiwarehouse.SelectedValue.ToString() + "'");
            if (dtcategory.Rows[0]["idcategory"].ToString() == "W3")
            {
                dataGridView4.Rows.Clear();
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    chk = true;
                    foreach (DataGridViewRow row1 in dataGridView4.Rows)
                    {
                        if (row.Cells["partno"].Value.ToString() == row1.Cells["partno1"].Value.ToString())
                        {
                            chk = false;
                            break;
                        }
                    }
                    //chua co trong hang
                    if (chk == true)
                    {
                        DataTable dtwo = connect.readdata("select (select partname from cargo where cargo.partno=dp.PartNo) as PartName,(isnull(SUM(quantity),0)-ISNULL(sum(Delivered),0)) as MaxQuantity from DeliveryPlan dp where dp.PartNo='" + row.Cells["partno"].Value.ToString() + "' and dp.IdWarehouse ='" + cbiwarehouse.SelectedValue.ToString() + "' and dp.ProductionDate>= CONVERT(date,GETDATE()) group by dp.PartNo");
                        if (dtwo.Rows.Count > 0)
                        {
                            dataGridView4.Rows.Add(row.Cells["partno"].Value.ToString(), dtwo.Rows[0]["PartName"].ToString(), row.Cells["boxqty"].Value.ToString(), dtwo.Rows[0]["MaxQuantity"].ToString());
                        }
                    }
                    else
                    {
                        foreach (DataGridViewRow row3 in dataGridView4.Rows)
                        {
                            if (row.Cells["partno"].Value.ToString() == row3.Cells["partno1"].Value.ToString())
                            {
                                row3.Cells["quantity1"].Value = Convert.ToDouble(row3.Cells["quantity1"].Value) + Convert.ToDouble(row.Cells["boxqty"].Value);
                            }
                        }
                    }
                }
            }
            else
            {
                dataGridView4.Rows.Clear();
                if (dataGridView2.Rows.Count > 0)
                {
                    DataTable dt;
                    dt = connect.readdata("select partname from cargo where partno='" + dataGridView2.Rows[0].Cells["partno"].Value + "'");
                    dataGridView4.Rows.Add(dataGridView2.Rows[0].Cells["partno"].Value, dt.Rows[0]["partname"].ToString(), 0);
                }

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    chk = true;
                    foreach (DataGridViewRow row in dataGridView4.Rows)
                    {
                        if (dataGridView2.Rows[i].Cells["partno"].Value.ToString() == row.Cells["partno1"].Value.ToString())
                        {
                            chk = false;
                            break;
                        }
                    }
                    if (chk == true)
                    {
                        DataTable dtcargo = connect.readdata("select partname from cargo where partno='" + dataGridView2.Rows[i].Cells["partno"].Value + "'");
                        dataGridView4.Rows.Add(dataGridView2.Rows[i].Cells["partno"].Value, dtcargo.Rows[0]["partname"].ToString(), 0);
                    }
                }
                for (int i = 0; i < dataGridView4.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView2.Rows.Count; j++)
                    {
                        if (dataGridView2.Rows[j].Cells["partno"].Value.ToString() == dataGridView4.Rows[i].Cells["partno1"].Value.ToString())
                        {
                            dataGridView4.Rows[i].Cells["quantity1"].Value = (Convert.ToDouble(dataGridView4.Rows[i].Cells["quantity1"].Value) + Convert.ToDouble(dataGridView2.Rows[j].Cells["boxqty"].Value)).ToString();
                        }

                    }
                }
            }



        }

        private void btnxuat_Click(object sender, EventArgs e)
        {
            double temp;
            double shortage;

            DataTable dtcategory = connect.readdata("select idcategory from warehouse where idwarehouse='" + cbiwarehouse.SelectedValue.ToString() + "'");
            if (cbewarehouse.Text == "" || cbiwarehouse.Text == "" || txtinvoice.Text == "" || dataGridView2.Rows.Count < 1)
            {
                MessageBox.Show("Không được bỏ trống thông tin !");
            }
            else if (dtcategory.Rows[0]["idcategory"].ToString() == "W3")
            {
                if (connect.countdata("select count(idslipout) from slipout where idslipout='" + txtinvoice.Text + "'") == 0)
                {
                    //update delivery plan
                    foreach (DataGridViewRow row in dataGridView4.Rows)
                    {
                        DataTable dtdeliveryplan = connect.readdata("select PartNo,Quantity,ProductionDate,Delivered,(Quantity-isnull(Delivered,0)) as Shortage from DeliveryPlan where IdWarehouse='" + cbiwarehouse.SelectedValue.ToString() + "' and ProductionDate >= Convert(date,getdate()) and PartNo='" + row.Cells["Partno1"].Value.ToString() + "' order by Shortage desc");
                        temp = Convert.ToDouble(row.Cells["quantity1"].Value.ToString());
                        int i = 0;
                        while (temp > 0 && Convert.ToDouble(dtdeliveryplan.Rows[i]["Shortage"].ToString()) != 0)
                        {
                            shortage = Convert.ToDouble(dtdeliveryplan.Rows[i]["Shortage"].ToString());

                            if (temp <= shortage)
                            {
                                DateTime dt = Convert.ToDateTime(dtdeliveryplan.Rows[i]["ProductionDate"].ToString());
                                connect.exedata("update DeliveryPlan set Delivered =isnull(Delivered,0) + " + temp + " where PartNo ='" + row.Cells["Partno1"].Value.ToString() + "' and IdWarehouse='" + cbiwarehouse.SelectedValue.ToString() + "' and ProductionDate='" + dt.ToString("yyyy-MM-dd") + "'");
                                temp = 0;
                                break;
                            }
                            else
                            {
                                connect.exedata("update DeliveryPlan set Delivered =Quantity where PartNo ='" + row.Cells["Partno1"].Value.ToString() + "' ");
                                temp = temp - shortage;

                            }
                            i++;
                        }
                    }
                    // xu ly ton kho

                    //toa hoa don 
                    if (connect.exedata("exec spInsertSlipout @idslipout='" + txtinvoice.Text + "',@idwarehouse='" + cbewarehouse.SelectedValue.ToString() + "',@idcustomer='" + cbiwarehouse.SelectedValue.ToString() + "'"))
                    {
                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {
                            DataTable dtpackinginfo = connect.readdata("select * from packinginfo where idpack='" + row.Cells["idpack"].Value + "'");
                            connect.exedata("exec spInsertSlipoutInfo @idslipout='" + txtinvoice.Text + "',@idpack='" + row.Cells["idpack"].Value + "',@quantity='" + row.Cells["boxqty"].Value + "',@remark='" + row.Cells["remark"].Value + "',@carnumber='" + cbbdriver.Text + "',@partno='" + row.Cells["partno"].Value + "'");
                            //connect.exedata("insert into slipoutinfo (idslipout,idpack,quantity,remark,carnumber,partno,packingdate) values('" + txtinvoice.Text + "','" + row.Cells["idpack"].Value + "','" + row.Cells["boxqty"].Value + "','" + row.Cells["remark"].Value + "','" + txtcarnumber.Text + "','" + row.Cells["partno"].Value + "','" + dtpackinginfo.Rows[0]["packingdate"].ToString() + "')");
                            //xuat chan
                            if (Convert.ToDouble(row.Cells["Remain"].Value) == 0)
                            {
                                connect.exedata("exec spDeletePackingInfo @idpack='" + row.Cells["idpack"].Value + "'");
                            }
                            //xuat le
                            else
                            {
                                connect.exedata("Exec spUpdatePackingInfo @quantity='" + row.Cells["Remain"].Value + "' ,@idpack='" + row.Cells["idpack"].Value + "'");
                            }
                        }
                        DataTable dtworkorder = connect.readdata("select PartNo,ProductionDate,Quantity,isnull(Delivered,0) as Delivered from DeliveryPlan where IdWarehouse='" + cbiwarehouse.SelectedValue.ToString() + "' and ProductionDate>=CONVERT(date,getdate())");
                        if (dtworkorder != null)
                        {
                            dgvworkorder.DataSource = dtworkorder;
                        }
                        dataGridView2.Rows.Clear();
                        dataGridView4.Rows.Clear();
                        MessageBox.Show("Thành công");
                        Printing_Slipout fr = new Printing_Slipout();
                        fr.lbday.Text = DateTime.Now.ToString("dd");
                        fr.lbmonth.Text = DateTime.Now.ToString("MM");
                        fr.lbyear.Text = DateTime.Now.ToString("yyyy");
                        fr.lbinvoice.Text = txtinvoice.Text;
                        fr.lbewarehouse.Text = cbewarehouse.Text;
                        fr.lbiwarehouse.Text = cbiwarehouse.Text;
                        fr.lbcarnumber.Text = cbbdriver.Text;
                        fr.lbdriver.Text = cbbdriver.SelectedValue.ToString();
                        fr.lbreason.Text = txtreason.Text;
                        DataTable dt1 = connect.readdata("select cargo.partno,cargo.partname,(select nameunit from unit where idunit=cargo.idunit) as dvt,SUM(quantity) as qty,slipoutinfo.remark from cargo inner join slipoutinfo on cargo.partno=slipoutinfo.partno  where idslipout='" + txtinvoice.Text + "' group by cargo.partno,cargo.partname,cargo.idunit,slipoutinfo.remark");
                        fr.dataGridView1.DataSource = dt1;
                        fr.Show();
                        lbmessage.Items.Clear();
                        txtinvoice.Text = "";
                        txtsumqty.Text = "";
                        txtreason.Text = "";
                        cbbdriver.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Lỗi ,xin thử lại hoặc liên hệ administrator");
                    }
                }
                else
                {
                    MessageBox.Show("xin taọ mới mã hóa đơn ");
                }
            }
            else
            {
                try
                {
                    if (connect.countdata("select count(idslipout) from slipout where idslipout='" + txtinvoice.Text + "'") == 0)
                    {
                        if (connect.exedata("exec spInsertSlipout @idslipout='" + txtinvoice.Text + "',@idwarehouse='" + cbewarehouse.SelectedValue.ToString() + "',@idcustomer='" + cbiwarehouse.SelectedValue.ToString() + "'"))
                        {
                            for (int i = 0; i < dataGridView2.Rows.Count; i++)
                            {
                                DataTable dtpackinginfo = connect.readdata("select * from packinginfo where idpack='" + dataGridView2.Rows[i].Cells["idpack"].Value + "'");
                                connect.exedata("exec spInsertSlipoutInfo @idslipout='" + txtinvoice.Text + "',@idpack='" + dataGridView2.Rows[i].Cells["idpack"].Value + "',@quantity='" + dataGridView2.Rows[i].Cells["boxqty"].Value + "',@remark='" + dataGridView2.Rows[i].Cells["remark"].Value + "',@carnumber='" + cbbdriver.Text + "',@partno='" + dataGridView2.Rows[i].Cells["partno"].Value + "'");
                            }
                            //for (int j = 0; j < dataGridView2.Rows.Count; j++)
                            //{
                            //    connect.exedata("insert into tbl_inout (idpack,kind,dateio,outwarehouse,inwarehouse) values('" + dataGridView2.Rows[j].Cells["idpack"].Value + "','OUT','" + DateTime.Now + "','" + cbewarehouse.SelectedValue + "','" + cbiwarehouse.SelectedValue + "')");
                            //}
                            for (int k = 0; k < dataGridView2.Rows.Count; k++)
                            {

                                //xuất chẵn
                                if (Convert.ToDouble(dataGridView2.Rows[k].Cells["Remain"].Value) == 0)
                                {
                                    //xuat ra prod,ng,lost warehouse,outsource

                                    if (dtcategory.Rows[0]["idcategory"].ToString() == "W2" || dtcategory.Rows[0]["idcategory"].ToString() == "W3" || dtcategory.Rows[0]["idcategory"].ToString() == "W4")
                                    {
                                        connect.exedata("exec spDeletePackingInfo  @idpack='" + dataGridView2.Rows[k].Cells["idpack"].Value + "'");
                                        // xuat ra factory
                                        if (dtcategory.Rows[0]["idcategory"].ToString() == "W2")
                                        {
                                            if (connect.countdata("select count(partno) from stock where partno='" + dataGridView2.Rows[k].Cells["partno"].Value.ToString() + "' and idwarehouse ='" + cbiwarehouse.SelectedValue.ToString() + "'") == 0)
                                            {
                                                connect.exedata("exec spInsertStock @idwarehouse='" + cbiwarehouse.SelectedValue.ToString() + "',@partno='" + dataGridView2.Rows[k].Cells["partno"].Value.ToString() + "',@quantity='" + dataGridView2.Rows[k].Cells["boxqty"].Value.ToString() + "'");
                                            }
                                            else
                                            {
                                                connect.exedata("exec spUpdateStock @idwarehouse='" + cbiwarehouse.SelectedValue.ToString() + "',@partno='" + dataGridView2.Rows[k].Cells["partno"].Value.ToString() + "',@quantity='" + dataGridView2.Rows[k].Cells["boxqty"].Value.ToString() + "'");
                                            }
                                        }
                                    }
                                    else
                                    {

                                        connect.exedata("exec spUpdatePackingInfo_Move @idwarehouse='" + cbiwarehouse.SelectedValue + "',@idpack='" + dataGridView2.Rows[k].Cells["idpack"].Value + "'");
                                    }

                                }
                                // xuất lẻ 
                                else
                                {
                                    if (dtcategory.Rows[0]["idcategory"].ToString() == "W2")
                                    {
                                        if (connect.countdata("select count(partno) from stock where partno='" + dataGridView2.Rows[k].Cells["partno"].Value.ToString() + "'") == 0)
                                        {
                                            connect.exedata("exec spInsertStock @idwarehouse='" + cbiwarehouse.SelectedValue.ToString() + "',@partno='" + dataGridView2.Rows[k].Cells["partno"].Value.ToString() + "',@quantity='" + dataGridView2.Rows[k].Cells["boxqty"].Value.ToString() + "'");
                                        }
                                        else
                                        {
                                            connect.exedata("exec spUpdateStock @idwarehouse='" + cbiwarehouse.SelectedValue.ToString() + "' ,@partno='" + dataGridView2.Rows[k].Cells["partno"].Value.ToString() + "',@quantity='" + dataGridView2.Rows[k].Cells["boxqty"].Value.ToString() + "'");
                                        }
                                    }
                                    connect.exedata("exec spUpdatePackingInfo @quantity='" + dataGridView2.Rows[k].Cells["Remain"].Value + "',@idpack='" + dataGridView2.Rows[k].Cells["idpack"].Value + "'");
                                }
                            }
                            MessageBox.Show("Success");
                            //in hoa don
                            Printing_Slipout fr = new Printing_Slipout();
                            fr.lbday.Text = DateTime.Now.ToString("dd");
                            fr.lbmonth.Text = DateTime.Now.ToString("MM");
                            fr.lbyear.Text = DateTime.Now.ToString("yyyy");
                            fr.lbinvoice.Text = txtinvoice.Text;
                            fr.lbewarehouse.Text = cbewarehouse.Text;
                            fr.lbiwarehouse.Text = cbiwarehouse.Text;
                            fr.lbcarnumber.Text = cbbdriver.Text;
                            fr.lbdriver.Text = cbbdriver.SelectedValue.ToString();
                            fr.lbreason.Text = txtreason.Text;
                            DataTable dt1 = connect.readdata("select cargo.partno,cargo.partname,(select nameunit from unit where idunit=cargo.idunit) as dvt,SUM(quantity) as qty,slipoutinfo.remark from cargo inner join slipoutinfo on cargo.partno=slipoutinfo.partno  where idslipout='" + txtinvoice.Text + "' group by cargo.partno,cargo.partname,cargo.idunit,slipoutinfo.remark");
                            fr.dataGridView1.DataSource = dt1;
                            fr.Show();
                            lbmessage.Items.Clear();
                            txtinvoice.Text = "";
                            txtsumqty.Text = "";
                            txtreason.Text = "";
                            cbbdriver.Text = "";
                            dataGridView2.Rows.Clear();
                            DataTable dtstock = connect.readdata("select * from packinginfo where idwarehouse='" + cbewarehouse.SelectedValue + "'");
                            if (dtstock != null)
                            {
                                dgvworkorder.DataSource = dtstock;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Xuất hàng không thành công ,xin vui lòng thử lại sau hoặc báo cho admin");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Mã hóa đơn đã có ,xin hay tạo lại");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.ToString());
                }


            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            txtrownum.Text = dataGridView2.Rows.Count.ToString();
        }

        private void txtinvoice_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

