using HANMISYSTEM.Views.PartialView;
using Microsoft.Office.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.Spray
{
    public partial class S_FactoryFrm : Form
    {
        public S_FactoryFrm()
        {
            InitializeComponent();
            UpdateStatus();
        }
        Dbconnect dbconnect = new Dbconnect();
        bool check;
        string offType;
        private string fgwh = "WH013";
        private async void UpdateStatus()
        {
            while (true)
            {
                if (check == true)
                {
                    DataTable dtproductivity = dbconnect.readdata("select productivity from cargo where partno='" + txtModel.Text.ToUpper() + "'");
                    int pro = Convert.ToInt32(dtproductivity.Rows[0]["productivity"].ToString());
                    DateTime t;
                    DateTime ontime;
                    DateTime or;
                    TimeSpan t1;
                    t = dbconnect.returndate("select UpdateTime from SprayStatus where PartNo='" + txtModel.Text.ToUpper() + "' and LineID='" + cbbLocation.SelectedValue + "' and SprayDate=convert(date,getdate())");
                    ontime = dbconnect.returndate("select ContinueTime from SprayStatus where PartNo='" + txtModel.Text.ToUpper() + "' and LineID='" + cbbLocation.SelectedValue + "' and SprayDate=convert(date,getdate())");
                    if (t <= ontime)
                    {
                        or = ontime;
                    }
                    else
                    {
                        or = t;
                    }
                    DateTime cur = dbconnect.returndate("select getdate()");

                    if (t == DateTime.MinValue)
                    {
                        t1 = cur - ontime;
                    }
                    else
                    {
                        t1 = cur - t;
                    }

                    double ltarget;
                    double target;
                    DataTable dt = dbconnect.readdata("select lastesttarget from SprayStatus where partno='" + txtModel.Text.ToUpper() + "' and LineID='" + cbbLocation.SelectedValue + "' and SprayDate=convert(date,getdate())");
                    if (dt.Rows.Count > 0)
                    {
                        if (dt.Rows[0]["lastesttarget"].ToString() != "")
                        {
                            ltarget = Convert.ToDouble(dt.Rows[0]["lastesttarget"].ToString());
                        }
                        else
                        {
                            ltarget = 0;
                        }
                    }
                    else
                    {
                        ltarget = 0;
                    }
                    target = ltarget + t1.TotalMinutes / 60 * pro;
                    txttarget.Text = target.ToString();



                    //update status
                    try
                    {
                        dbconnect.exedata("update SprayStatus set lastesttarget ='" + txttarget.Text + "',UpdateTime=getdate() where LineID='" + cbbLocation.SelectedValue.ToString() + "' and PartNo='" + txtModel.Text + "' and SprayDate=convert(date,getdate())");
                    }
                    catch
                    {
                    }

                }


                await Task.Delay(5000);
            }
        }
        private void S_FactoryFrm_Load(object sender, EventArgs e)
        {
            DataTable dtLine = dbconnect.readdata("select * from SprayLine");
            if (dtLine != null)
            {
                cbbLocation.DataSource = dtLine;
                cbbLocation.DisplayMember = "Name";
                cbbLocation.ValueMember = "ID";
            }
        }

        private void btnselectWO_Click(object sender, EventArgs e)
        {
             using (SelectWorkOrder frm = new SelectWorkOrder())
            {
                DataTable dtLocation = dbconnect.readdata("select Name from SprayLine where ID='" + cbbLocation.SelectedValue.ToString() + "'");
                SelectWorkOrder fr = new SelectWorkOrder();
                fr.lbline.Text = dtLocation.Rows[0]["Name"].ToString();
                fr.dataGridView1.AutoGenerateColumns = false;
                DataTable dtwo = dbconnect.readdata(" select ROW_NUMBER() over(order by s.PartNo) as r,s.WO as WorkOrder,s.PartNo,c.partname,c.Color,c.Market,s.PST,s.Quantity as productionplan from SprayPlan s inner join cargo c on s.PartNo=c.partno where CONVERT(date,s.PST)=CONVERT(date,getdate()) and (s.Status=1 or s.Status is null) and LineID='" + cbbLocation.SelectedValue.ToString() + "'");
                fr.dataGridView1.DataSource = dtwo;
                fr.ShowDialog();
                lbWO.Text = fr.SendData();
                txtModel.Text = fr.sendDataModel();
                textBox1.Text = fr.sendDataModel();
                if(txtModel.Text!="")
                {
                    DataTable dt = dbconnect.readdata("select LastestTarget from SprayStatus where PartNo='" + txtModel.Text.ToUpper() + "' and LineID='" + cbbLocation.SelectedValue.ToString() + "' and SprayDate=convert(date,getdate())");
                    if (dt.Rows.Count > 0)
                    {
                        if (dt.Rows[0]["LastestTarget"].ToString() != "")
                        {
                            txttarget.Text = dt.Rows[0]["LastestTarget"].ToString();
                        }
                        else
                        {
                            txttarget.Text = "0";
                        }
                    }
                    else
                    {
                        txttarget.Text = "0";
                    }
                    DataTable dt1 = dbconnect.readdata("select Quantity from SprayPlan where PartNo='" + txtModel.Text.ToUpper() + "' and LineID='" + cbbLocation.SelectedValue + "' and convert(date,PST)=convert(date,getdate())");
                    if (dt1.Rows.Count > 0 || dt1 != null)
                    {
                        lbPlan.Text = dt1.Rows[0]["Quantity"].ToString();
                    }
                    else
                    {
                        lbPlan.Text = "0";
                    }
                    txtpackingid.Text = "";
                    txtPackqty.Text = "0";
                    txtdayinput.Text = "0";
                    txtpackingid.Enabled = true;
                }
               
               
                //lbsearch.Visible = false;

            }
        }

        private void btnON_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lbPlan.Text) <= 0)
            {
                MessageBox.Show("Chưa có kế hoặch sản xuất");
            }
            else
            {
                //kiem tra giai doan truoc da có endtime hay chưa
                DataTable dtendtime = dbconnect.readdata("select top 1 EndTime  from SprayTrackingUPH where LineID='" + cbbLocation.SelectedValue.ToString() + "' and  CONVERT(date,StartTime)=convert(date,getdate()) order by StartTime desc");
                if (dtendtime.Rows.Count > 0)
                {
                    if (string.IsNullOrEmpty(dtendtime.Rows[0]["EndTime"].ToString()))
                    {
                        //them endtime
                        dbconnect.exedata("with cte as (select top 1 *  from SprayTrackingUPH where LineID = '" + cbbLocation.SelectedValue.ToString() + "' and  CONVERT(date, StartTime) = CONVERT(date, getdate()) order by StartTime desc) update cte set EndTime = GETDATE(),Remark='EndTime added by system'");
                    }
                }
                //pictureBox1.Enabled = true;
                

                cbbLocation.Enabled = false;
                if (dbconnect.countdata("select count(LineID) from SprayRunningStatus where LineID='" + cbbLocation.SelectedValue.ToString() + "'   ") == 0)
                {
                    dbconnect.exedata("insert into SprayRunningStatus(LineID,PartNo,Status) values('" + cbbLocation.SelectedValue.ToString() + "','" + txtModel.Text + "',1)");
                }
                else
                {
                    dbconnect.exedata("update SprayRunningStatus set Status =1,PartNo='"+txtModel.Text+"',WO='"+lbWO.Text+"' where LineID='" + cbbLocation.SelectedValue.ToString() + "' ");
                }
                if (dbconnect.countdata("select count(id) from SprayStatus where LineID='" + cbbLocation.SelectedValue.ToString() + "' and PartNo='" + txtModel.Text + "' and SprayDate=convert(date,getdate())") == 0)
                {
                    dbconnect.exedata("insert into SprayStatus(PartNo,LineID,SprayDate,StartTime,ContinueTime) values('" + txtModel.Text + "','" + cbbLocation.SelectedValue.ToString() + "',convert(date,getdate()),getdate(),getdate())");
                }
                else
                {
                    dbconnect.exedata("update SprayStatus set ContinueTime=getdate(),updatetime=getdate() where LineID='" + cbbLocation.SelectedValue.ToString() + "' and PartNo='" + txtModel.Text + "' and SprayDate=convert(date,getdate())");
                }
                check = true;
                btnselectWO.Enabled = false;
                checkBox1.Enabled = true;
                //them lich su

                //dbconnect.exedata("insert into SprayHistory (PartNo,SprayTime,LineID,PackID,Quantity) values('"+txtModel.Text+"',getdate(),'" + cbbLocation.SelectedValue.ToString() + "','" + txtpackingid.Text + "',1)");
                DataTable dtsumqty = dbconnect.readdata("select sum(Quantity) as pro from SprayHistory where partno='" + txtModel.Text + "' and LineID='" + cbbLocation.SelectedValue.ToString() + "' and convert(date,SprayTime)=convert(date,getdate())");
                txtdayinput.Text = dtsumqty.Rows[0]["pro"].ToString();
                dbconnect.exedata("insert into SprayTrackingUPH(PartNo,LineID,StartTime) values('"+txtModel.Text+"','"+cbbLocation.SelectedValue.ToString()+"',getdate())");
                if (txtpackingid.Text != "")
                {

                    btnON.BackColor = Color.Lime;
                    btnON.BackColor = SystemColors.Control;
                    txtModel.Enabled = false;
                    //dbconnect.exedata("exec spInsertTrackingUPH @partno='" + cbbModel.SelectedValue.ToString() + "' ,@locationid='" + cbbLocation.SelectedValue.ToString() + "',@remark=''");
                    btnON.Enabled = false;
                    btnOFF.Enabled = true;
                    //if (txtpackingid.Text.Length >= 14)
                    //{
                    //    txtScan.Enabled = true;
                    //    txtScan.Focus();
                    //}
                    //else
                    //{
                    //    txtPackID.Enabled = true;
                    //    txtPackID.Focus();
                    //}
                    txtScan.Enabled = true;
                    txtScan.Focus();
                }
                else
                {

                    btnON.BackColor = Color.Lime;
                    btnOFF.BackColor = SystemColors.Control;
                    txtModel.Enabled = false;
                    txtpackingid.Enabled = true;

                    btnON.Enabled = false;
                    btnOFF.Enabled = true;
                    txtScan.Enabled = true;
                    txtpackingid.Focus();
                }


            }
        }

        private void txtpackingid_TextChanged(object sender, EventArgs e)
        {
            txtcurrentquantity.Text = "0";
            //DataTable dtShortagePlan = dbconnect.readdata("select shortage from view_shortage_plan where partno ='" + txtmodel.Text + "' and idlocation ='" + cblocation.SelectedValue.ToString() + "' and idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "'");
            if (txtpackingid.Text.Length == 14)
            {
                DataTable packqty = dbconnect.readdata("select * from packinginfo where idpack='" + txtpackingid.Text + "'");
                DataTable dt = dbconnect.readdata("select * from packingstandard where partno='" + txtModel.Text.ToUpper() + "' and idpacking like '" + txtpackingid.Text.Substring(0, 3) + "'");
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Phương thức đóng gói không tồn tại !");
                    txtpackingid.Text = "";
                    txtcurrentquantity.Text = "0";
                }
                else
                {
                    if (dt.Rows[0]["quantity"].ToString() == "0")
                    {
                        MessageBox.Show("Xin vui long chọn cách đóng gói khác");
                        txtpackingid.Text = "";
                    }
                    else
                    {

                        if (packqty.Rows.Count != 0)
                        {
                            if (packqty.Rows[0]["partno"].ToString() != txtModel.Text.ToUpper().ToString())
                            {
                                MessageBox.Show("Box này đã được sử dụng cho mã hàng khác !");
                                txtpackingid.Focus();
                                txtpackingid.Text = "";
                                txtPackqty.Text = "";
                            }
                            else
                            {
                                txtpackingid.Enabled = false;
                                if (Convert.ToInt32(packqty.Rows[0]["quantity"].ToString()) >= Convert.ToInt32(dt.Rows[0]["quantity"].ToString()))
                                {
                                    txtpackingid.Focus();
                                    MessageBox.Show("Box full!");
                                    txtpackingid.Text = "";
                                    txtpackingid.Enabled = true;
                                    txtquantity.Text = "";
                                }
                                else
                                {
                                    if (checkBox1.Checked == true)
                                    {
                                        // MessageBox.Show("true");
                                        txtquantity.Focus();
                                        DataTable dtpacking = dbconnect.readdata("select quantity from packingstandard where partno='" + txtModel.Text.ToUpper() + "' and idpacking like '" + txtpackingid.Text.Substring(0, 3) + "'");
                                        DataTable dtpackinginfo = dbconnect.readdata("select quantity from packinginfo where idpack='" + txtpackingid.Text + "'");
                                        txtquantity.Text = (Convert.ToInt32(dt.Rows[0]["quantity"].ToString()) - Convert.ToInt32(packqty.Rows[0]["quantity"].ToString())).ToString();
                                        txtPackqty.Text = (Convert.ToInt32(dt.Rows[0]["quantity"].ToString()) - Convert.ToInt32(packqty.Rows[0]["quantity"].ToString())).ToString();

                                    }
                                    else
                                    {
                                        DataTable dtpacked = dbconnect.readdata("select quantity from packinginfo where idpack='" + txtpackingid.Text + "'");
                                        DataTable dtpacking = dbconnect.readdata("select quantity from packingstandard where partno='" + txtModel.Text.ToUpper() + "' and idpacking like '" + txtpackingid.Text.Substring(0, 3) + "'");
                                        txtcurrentquantity.Text = dtpacked.Rows[0]["quantity"].ToString();
                                        txtPackqty.Text = dtpacking.Rows[0]["quantity"].ToString();
                                        txtScan.Focus();
                                    }

                                    txtcurrentquantity.Text = packqty.Rows[0]["quantity"].ToString();
                                }
                            }

                        }
                        else
                        {
                            if (checkBox1.Checked == false)
                            {
                                txtPackqty.Text = dt.Rows[0]["quantity"].ToString();
                                txtScan.Focus();
                            }
                            else
                            {
                                txtquantity.Focus();
                                DataTable dtpacking = dbconnect.readdata("select quantity from packingstandard where partno='" + txtModel.Text.ToUpper() + "' and idpacking like '" + txtpackingid.Text.Substring(0, 3) + "'");
                                txtquantity.Text = dt.Rows[0]["quantity"].ToString();
                                txtPackqty.Text = dt.Rows[0]["quantity"].ToString();
                            }
                        }
                    }
                }

            }
        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
            DialogResult dlr;
            dlr = CustomMsgBox.Show("Tại sao bạn lại muốn dừng lại ", "Thông báo", "Kết thúc ngày làm việc", "Nghỉ giải lao", "Hủy");
            if (dlr == DialogResult.Yes)
            {
                btnselectWO.Enabled = true;
                if (dbconnect.countdata("select count(LineID) from SprayRunningStatus where LineID='" + cbbLocation.SelectedValue.ToString() + "'  ") == 0)
                {
                    dbconnect.exedata("insert into SprayRunningStatus(LineID,PartNo,Status) values('" + cbbLocation.SelectedValue.ToString() + "','" + txtModel.Text + "',0)");
                }
                else
                {
                    dbconnect.exedata("update SprayRunningStatus set Status =0 where LineID='" + cbbLocation.SelectedValue.ToString() + "' and PartNo='" + txtModel.Text + "'");
                }
                check = false;
                checkBox1.Enabled = false;
                dbconnect.exedata("with cte as (select top 1 EndTime from SprayTrackingUPH where PartNo='" + txtModel.Text + "' and LineID='" + cbbLocation.SelectedValue.ToString() + "' order by StartTime Desc) update cte set EndTime =getdate()");
                //pictureBox1.Enabled = false;
                btnOFF.BackColor = Color.Lime;
                btnON.BackColor = SystemColors.Control;
                btnON.Enabled = true;
                btnOFF.Enabled = false;
                txtpackingid.Text = "";
                txtScan.Enabled = false;
                txtModel.Enabled = true;
                txtModel.Focus();
                offType = "";
                cbbLocation.Enabled = true;
            }
            if (dlr == DialogResult.No)
            {
                checkBox1.Enabled = false;
                btnselectWO.Enabled = true;
                if (dbconnect.countdata("select count(LineID) from SprayRunningStatus where LineID='" + cbbLocation.SelectedValue.ToString() + "'  ") == 0)
                {
                    dbconnect.exedata("insert into SprayRunningStatus(LineID,PartNo,Status) values('" + cbbLocation.SelectedValue.ToString() + "','" + txtModel.Text + "',0)");
                }
                else
                {
                    dbconnect.exedata("update SprayRunningStatus set Status =0 where LineID='" + cbbLocation.SelectedValue.ToString() + "' and PartNo='" + txtModel.Text + "'");
                }
                //dbconnect.exedata("with cte as (select top 1 EndTime from TrackingUPH where PartNo='" + cbbModel.SelectedValue.ToString() + "' and LocationID='" + cbbLocation.SelectedValue.ToString() + "' order by StartTime Desc) update cte set EndTime =getdate()");
                check = false;
                //pictureBox1.Enabled = false;
                offType = "Break";
                btnOFF.BackColor = Color.Lime;
                btnON.BackColor = SystemColors.Control;
                btnON.Enabled = true;
                btnOFF.Enabled = false;
                txtScan.Enabled = false;
            }
        }

        private void txtScan_TextChanged(object sender, EventArgs e)
        {
            if (txtScan.Text.Length >= 11)
            {

                if (check == false)
                {
                    MessageBox.Show("Chuyền đang dừng");
                    txtScan.Text = "";
                }
                else
                {
                    if (txtScan.Text.ToUpper() == txtModel.Text.ToUpper().ToString().ToUpper())
                    {

                        if (txtpackingid.Text == "0" || txtpackingid.Text.Contains(" ") == true)
                        {
                            MessageBox.Show("Mã đóng gói không hợp lệ !");
                            txtScan.Text = "";
                        }
                        else
                        {
                            //CHECK PLAN
                            //DataTable dtplan = connect.readdata("select * from productionplan where partno='" + txtpartno.Text.ToUpper() + "' and idlocation='" + cblocation.SelectedValue + "' and productiondate='" + DateTime.Now.ToString("yyyy-MM-dd") + "'");

                            //if (dtplan.Rows.Count > 0)
                            //{
                            //    plan = Convert.ToInt32(dtplan.Rows[0]["productionplan"].ToString());
                            //}
                            //else
                            //{
                            //    plan = 0;
                            //}
                            //if (dbconnect.countdata("select count(partno) from productionhistory where partno='" + txtpartno.Text.ToUpper() + "' and idlocation='" + cblocation.SelectedValue + "' and convert(date,productiontime)=CONVERT(DATE,GETDATE())") < plan)
                            //{
                            if (txtpackingid.Text == "")
                            {
                                MessageBox.Show("XIN HÃY NHẬP MÃ ĐÓNG GÓI TRƯỚC TIÊN !!!");
                                txtScan.Text = "";
                            }
                            else
                            {
                                dbconnect.exedata("insert into SprayHistory (PartNo,SprayTime,LineID,PackID,Quantity) values('" + txtModel.Text + "',getdate(),'" + cbbLocation.SelectedValue.ToString() + "','" + txtpackingid.Text + "',1)");
                                DataTable dtsumqty = dbconnect.readdata("select sum(Quantity) as pro from SprayHistory where partno='" + txtModel.Text.ToUpper() + "' and LineID='" + cbbLocation.SelectedValue.ToString() + "' and convert(date,SprayTime)=convert(date,getdate())");
                                txtdayinput.Text = dtsumqty.Rows[0]["pro"].ToString();
                                //quanli packing
                                if (dbconnect.countdata("select count(idpack) from packinginfo where idpack='" + txtpackingid.Text + "'") == 0)
                                {
                                    dbconnect.exedata("INSERT into packinginfo(idpack,partno,quantity,packingdate,LineID,idwarehouse) values('" + txtpackingid.Text + "','" + txtModel.Text + "',1,getdate(),'" + cbbLocation.SelectedValue.ToString() + "','" + fgwh + "')");
                                }
                                else
                                {
                                    dbconnect.exedata("exec spUpdatePackingInfo_Increase @idpack='" + txtpackingid.Text + "'");
                                }
                                DataTable dtinventory = dbconnect.readdata("select sum(quantity) as stock from packinginfo where idwarehouse ='" + fgwh + "' and partno='" + txtModel.Text + "'");
                                if (dtinventory.Rows.Count > 0)
                                {
                                    txtInventory.Text = dtinventory.Rows[0]["stock"].ToString();
                                }

                                DataTable qtypack = dbconnect.readdata("select quantity from packinginfo where idpack='" + txtpackingid.Text + "'");
                                txtcurrentquantity.Text = qtypack.Rows[0]["quantity"].ToString();
                                txtScan.Text = "";

                                //quanli #bom
                                //DataTable dtbom = connect.readdata("with temp(partno,rawpartno,quantity) as (select partno,rawpartno,quantity from bom where partno='" + txtmodel.Text + "' union all select a.partno,b.rawpartno,a.quantity*b.quantity from temp as a, bom as b where a.rawpartno=b.partno and (select ProcessID from cargo where partno ='" + txtmodel.Text + "')=(select ProcessID from cargo where partno=b.partno) ) select rawpartno, SUM(quantity) as quantity from (select * from temp t1 where (select ProcessID from cargo where partno ='" + txtmodel.Text + "')<>(select ProcessID from cargo where partno=t1.rawpartno)) as temp1 inner join cargo c1 on temp1.partno=c1.partno group by temp1.partno,rawpartno order by temp1.partno asc");
                                //if (dtbom.Rows.Count > 0)
                                //{
                                //    for (int i = 0; i < dtbom.Rows.Count; i++)
                                //    {
                                //        if (connect.countdata("select count(partno) from stock where idwarehouse ='WH014' and partno='" + dtbom.Rows[i]["rawpartno"].ToString() + "'") == 0)
                                //        {
                                //            connect.exedata("insert into stock(idwarehouse,partno,quantity) values('WH014','" + dtbom.Rows[i]["rawpartno"].ToString() + "','" + (Convert.ToDouble(dtbom.Rows[i]["quantity"].ToString())  * -1) + "')");
                                //        }
                                //        else
                                //        {
                                //            connect.exedata("update stock set quantity =quantity-" + (Convert.ToDouble(dtbom.Rows[i]["quantity"].ToString())) + " where partno='"+dtbom.Rows[i]["rawpartno"].ToString()+"'");
                                //        }
                                //    }
                                //}


                            }


                            //}
                            //else
                            //{
                            //    MessageBox.Show("Chưa có kết hoạch " + plan + connect.countdata("select count(*) from productionhistory where partno='" + txtmodel.Text.ToUpper() + "' and idlocation='" + cblocation.SelectedValue + "' and convert(date,productiontime)=convert(date,getdate())"));
                            //    txtpartno.Text = "";
                            //}
                        }
                    }
                    else
                    {
                        //if (txtactualqty.Text != "0")
                        //{
                        //    MessageBox.Show("Cần đóng gói xong thùng hiện tại ");
                        //    txtpartno.Text = "";
                        //}

                        //else
                        //{
                        //DialogResult ans = MessageBox.Show("Sai mã ,Đổi model ngay bây giờ", "Notice", MessageBoxButtons.YesNo);
                        //if (ans == DialogResult.Yes)
                        //{
                        //    if (connect.countdata("select count(*) from cargo where partno='" + txtpartno.Text + "' and idcategory='3'") != 0)
                        //    {
                        //        txtmodel.Text = txtpartno.Text;
                        //        txtpartno.Text = "";
                        //        //kiem tra giai doan truoc da có endtime hay chưa
                        //        DataTable dtendtime = connect.readdata("select top 1 EndTime  from TrackingUPH where LocationID='" + cblocation.SelectedValue.ToString() + "' and  CONVERT(date,StartTime)=convert(date,getdate()) order by StartTime desc");
                        //        if (dtendtime.Rows.Count > 0)
                        //        {
                        //            if (string.IsNullOrEmpty(dtendtime.Rows[0]["EndTime"].ToString()))
                        //            {
                        //                //them endtime
                        //                connect.exedata("with cte as (select top 1 *  from TrackingUPH where LocationID = '" + cblocation.SelectedValue.ToString() + "' and  CONVERT(date, StartTime) = CONVERT(date, getdate()) order by StartTime desc) update cte set EndTime = GETDATE(),Remark='EndTime added by system'");
                        //            }
                        //        }
                        //        connect.exedata("exec spInsertTrackingUPH @partno='" + txtmodel.Text + "' ,@locationid='" + cblocation.SelectedValue.ToString() + "',@remark=''");
                        //    }
                        //    else
                        //    {
                        //        MessageBox.Show("Partno không tồn tại!");
                        //        txtpartno.Text = "";
                        //    }
                        //}
                        //else
                        //{
                        //    txtpartno.Text = "";
                        //}
                        MessageBox.Show("Sai mã ,xin hãy kiểm tra lại tem nhãn");
                        txtScan.Text = "";
                        //}

                    }




                }
            }
        }

        private void txtcurrentquantity_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                if (txtpackingid.Text.Length >= 14)
                {

                    if (txtPackqty.Text != "0")
                    {
                        txtpackingid.Enabled = false;
                        if (Convert.ToInt32(txtcurrentquantity.Text) == Convert.ToInt32(txtPackqty.Text))
                        {
                            DialogResult dlr;
                            dlr = MessageBox.Show("BOx đã đầy ,Xin hãy kết thúc quá trình đóng gói", "Notice", MessageBoxButtons.OK);
                            if (dlr == DialogResult.OK)
                            {
                                txtpackingid.Text = "";
                                txtcurrentquantity.Text = "0";

                                txtPackqty.Text = "0";
                                txtpackingid.Enabled = true;
                                txtpackingid.Focus();
                            }
                        }
                    }
                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                lbQuantity.Visible = true;
                txtquantity.Visible = true;
      
                txtScan.Visible = false;
                lbScantext.Visible = false;
                if (txtpackingid.Text.Length < 14)
                {
                    txtpackingid.Focus();
                }
                else
                {
                    DataTable dtpacked = dbconnect.readdata("select quantity from packinginfo where idpack='" + txtpackingid.Text + "'");
                    DataTable dtpackingstandard = dbconnect.readdata("select quantity from packingstandard where partno='"+txtModel.Text+"' and idpacking='"+txtpackingid.Text.Substring(0,3)+"' ");
                    int packed = (dtpacked == null || dtpacked.Rows.Count==0) ? 0 : Convert.ToInt32(dtpacked.Rows[0]["quantity"].ToString());
                    txtquantity.Text = (Convert.ToInt32(dtpackingstandard.Rows[0]["quantity"].ToString())-packed).ToString();
                }
            }
            else
            {
                lbQuantity.Visible = false;
                txtquantity.Visible = false;

                txtScan.Visible = true;
                lbScantext.Visible = true;
            }

        }

        private void btnpacking_Click(object sender, EventArgs e)
        {
            if(txtpackingid.Text!="")
            {
                if (checkBox1.Checked == true)
                {
                    if (dbconnect.countdata("select count(idpack) from packinginfo where idpack='" + txtpackingid.Text + "'") == 0)
                    {
                        dbconnect.exedata("INSERT into packinginfo(idpack,partno,quantity,packingdate,LineID,idwarehouse) values('" + txtpackingid.Text + "','" + txtModel.Text + "',"+txtquantity.Text+",getdate(),'" + cbbLocation.SelectedValue.ToString() + "','" + fgwh + "')");
                        dbconnect.exedata("insert into SprayHistory (PartNo,SprayTime,LineID,PackID,Quantity) values('" + txtModel.Text + "',getdate(),'" + cbbLocation.SelectedValue.ToString() + "','" + txtpackingid.Text + "',"+txtquantity.Text+")");
                        txtpackingid.Text = "";
                        txtpackingid.Enabled = true;
                        txtquantity.Text = "";
                        txtpackingid.Focus();
                    }
                    else
                    {
                        dbconnect.exedata("update packinginfo set quantity =quantity + "+txtquantity.Text+" where idpack='"+txtpackingid.Text+"'");
                        dbconnect.exedata("insert into SprayHistory (PartNo,SprayTime,LineID,PackID,Quantity) values('" + txtModel.Text + "',getdate(),'" + cbbLocation.SelectedValue.ToString() + "','" + txtpackingid.Text + "',"+txtquantity.Text+")");
                        txtpackingid.Text = "";
                        txtquantity.Text = "";
                        txtpackingid.Enabled = true;
                        txtpackingid.Focus();
                    }
                    DataTable dtsumqty = dbconnect.readdata("select sum(Quantity) as pro from SprayHistory where partno='" + txtModel.Text.ToUpper() + "' and LineID='" + cbbLocation.SelectedValue.ToString() + "' and convert(date,SprayTime)=convert(date,getdate())");
                    txtdayinput.Text = dtsumqty.Rows[0]["pro"].ToString();

                    DataTable dtinventory = dbconnect.readdata("select sum(quantity) as stock from packinginfo where idwarehouse ='" + fgwh + "' and partno='" + txtModel.Text + "'");
                    if (dtinventory.Rows.Count > 0)
                    {
                        txtInventory.Text = dtinventory.Rows[0]["stock"].ToString();
                    }

                }
                else
                {
                    txtpackingid.Text = "";
                    txtpackingid.Enabled = true;
                    txtpackingid.Focus();
                }
            }

        }
    }
}
