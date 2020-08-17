﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HANMISYSTEM.Module;
using HANMISYSTEM.Views.Accessory;

namespace HANMISYSTEM
{
    public partial class frmprod : Form
    {


        public frmprod()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        Isnumber _isnumber = new Isnumber();
        int plan;

        private void frmprod_Load(object sender, EventArgs e)
        {
            DataTable dt2;
            DataTable dt3 = connect.readdata("select * from tbl_user where username='" + HANMISYSTEM.Properties.Settings.Default.username + "'");
            DataTable dt1 = connect.readdata("select * from warehouse where idwarehouse='WH001'");
            if (dt1 != null)
            {
                try
                {
                    cbwarehouse.DataSource = dt1;
                    cbwarehouse.DisplayMember = "namewarehouse";
                    cbwarehouse.ValueMember = "idwarehouse";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection faile", ex.ToString());
                }
            }
            if (dt3.Rows[0]["location"].ToString() == "all")
            {
                dt2 = connect.readdata("select * from location where idwarehouse='" + cbwarehouse.SelectedValue + "'");
            }
            else
            {
                dt2 = connect.readdata("select * from location where idwarehouse='" + cbwarehouse.SelectedValue + "' and idlocation='" + dt3.Rows[0]["location"].ToString() + "'");
            }
            if (dt2 != null)
            {
                try
                {
                    cblocation.DataSource = dt2;
                    cblocation.DisplayMember = "namelocation";
                    cblocation.ValueMember = "idlocation";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection faile", ex.ToString());
                }
            }

        }
        //bool ck=true;
        private void txtpartno_TextChanged(object sender, EventArgs e)
        {
            Dbconnect connect = new Dbconnect();
            string remark;
            remark = "";
            if (txtpartno.Text.Length >= 11)
            {

                if (btnpower.Text == "Stop line")
                {
                    MessageBox.Show("Line was stopped");
                    txtpartno.Text = "";
                }
                else
                {
                    if (txtpartno.Text.ToUpper() == txtmodel.Text.ToUpper().ToString().ToUpper())
                    {

                        if (txtqty.Text == "0" || txtboxno.Text.Contains(" ") == true)
                        {
                            MessageBox.Show("Mã đóng gói không hợp lệ !");
                            txtpartno.Text = "";
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
                            if (connect.countdata("select count(partno) from productionhistory where partno='" + txtpartno.Text.ToUpper() + "' and idlocation='" + cblocation.SelectedValue + "' and convert(date,productiontime)=CONVERT(DATE,GETDATE())") < plan)
                            {
                                if (txtboxno.Text == "")
                                {
                                    MessageBox.Show("XIN HÃY NHẬP MÃ ĐÓNG GÓI TRƯỚC TIÊN !!!");
                                    txtpartno.Text = "";
                                }
                                else
                                {
                                    //them lich su va running status
                                    connect.exedata("exec spInsertProductionHistory @idwarehouse='" + cbwarehouse.SelectedValue + "',@partno='" + txtpartno.Text.ToUpper() + "',@remark='" + remark + "',@idlocation='" + cblocation.SelectedValue + "',@idpack='" + txtboxno.Text + "'");
                                    //remove save data follow month
                                    //if (connect.countdata("select count(partno) from productivity where partno ='" + txtmodel.Text.ToUpper() + "' and idwarehouse='" + cbwarehouse.SelectedValue + "' and yearmonth=left(CONVERT(date,getdate()),7)") == 0)
                                    //{
                                    //    connect.exedata("insert into productivity (partno,idwarehouse,quantity,yearmonth) values('" + txtmodel.Text.ToUpper() + "','" + cbwarehouse.SelectedValue + "','1',left(CONVERT(date,getdate()),7))");
                                    //}
                                    //else
                                    //{
                                    //    connect.exedata("update productivity set quantity=quantity+1 where partno='" + txtmodel.Text.ToUpper() + "' and idwarehouse='" + cbwarehouse.SelectedValue + "' and yearmonth=left(CONVERT(date,getdate()),7)");
                                    //}
                                    DataTable dtsumqty = connect.readdata("select sum(qty) as pro from productionhistory where partno='" + txtmodel.Text.ToUpper() + "' and idlocation='" + cblocation.SelectedValue.ToString() + "' and convert(date,productiontime)=convert(date,getdate())");
                                    txtproductionqty.Text = dtsumqty.Rows[0]["pro"].ToString();
                                    //quanli packing
                                    if (connect.countdata("select count(idpack) from packinginfo where idpack='" + txtboxno.Text + "'") == 0)
                                    {
                                        connect.exedata("exec spInsertPackingInfo @idpack='" + txtboxno.Text + "',@partno='" + txtmodel.Text.ToUpper() + "',@idlocation='" + cblocation.SelectedValue.ToString() + "',@idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "'");
                                    }
                                    else
                                    {
                                        connect.exedata("exec spUpdatePackingInfo_Increase @idpack='" + txtboxno.Text + "'");
                                    }
                                    DataTable dtinventory = connect.readdata("select sum(quantity) as stock from packinginfo where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' and partno='" + txtmodel.Text + "'");
                                    if (dtinventory.Rows.Count > 0)
                                    {
                                        txtinventory.Text = dtinventory.Rows[0]["stock"].ToString();
                                    }

                                    DataTable qtypack = connect.readdata("select quantity from packinginfo where idpack='" + txtboxno.Text + "'");
                                    txtactualqty.Text = qtypack.Rows[0]["quantity"].ToString();
                                    //quan li status
                                    if (connect.countdata("select COUNT(partno) from productionstatus where partno='" + txtmodel.Text.ToUpper() + "' and productiondate=convert(date,getdate())") == 0)
                                    {
                                        connect.exedata("insert INTO productionstatus (partno,idwarehouse,idlocation,productiondate,starttime) values('" + txtpartno.Text + "','" + cbwarehouse.SelectedValue + "','" + cblocation.SelectedValue + "',convert(date,getdate()),getdate())");
                                        txtpartno.Text = "";
                                    }
                                    else
                                    {
                                        txtpartno.Text = "";
                                    }

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


                            }
                            else
                            {
                                MessageBox.Show("Chưa có kết hoạch " + plan + connect.countdata("select count(*) from productionhistory where partno='" + txtmodel.Text.ToUpper() + "' and idlocation='" + cblocation.SelectedValue + "' and convert(date,productiontime)=convert(date,getdate())"));
                                txtpartno.Text = "";
                            }
                        }
                    }
                    else
                    {
                        if (txtactualqty.Text != "0")
                        {
                            MessageBox.Show("Cần đóng gói xong thùng hiện tại ");
                            txtpartno.Text = "";
                        }

                        else
                        {
                            DialogResult ans = MessageBox.Show("Bạn có muốn đổi model không", "Notice", MessageBoxButtons.YesNo);
                            if (ans == DialogResult.Yes)
                            {
                                if (connect.countdata("select count(*) from cargo where partno='" + txtpartno.Text + "' and idcategory='3'") != 0)
                                {
                                    txtmodel.Text = txtpartno.Text;
                                    txtpartno.Text = "";
                                }
                                else
                                {
                                    MessageBox.Show("Partno không tồn tại!");
                                    txtpartno.Text = "";
                                }
                            }
                            else
                            {
                                txtpartno.Text = "";
                            }
                        }

                    }




                }
            }
        }
        bool check = true;
        private Boolean xulibom(string partno, double qty)
        {
            check = true;
            double tmp;
            DataTable dtcheckkho = connect.readdata("select SUM(quantity) as stock from packinginfo where partno ='" + partno + "'  and idwarehouse ='" + cbwarehouse.SelectedValue + "'");
            if (dtcheckkho.Rows.Count > 0)
            {
                if (string.IsNullOrEmpty(dtcheckkho.Rows[0]["stock"].ToString()))
                {
                    check = false;
                }
                else
                {
                    DataTable dtcheckstock = connect.readdata("select top 1  quantity from packinginfo where partno='" + txtmodel.Text.ToUpper() + "' order by packingdate asc");
                    if (dtcheckstock.Rows.Count > 0)
                    {
                        if (qty < Convert.ToDouble(dtcheckstock.Rows[0]["quantity"].ToString()))
                        {
                            connect.exedata("update packinginfo set quantity =quantity-" + qty + " where idpack =(select top 1 idpack from packinginfo where partno = '" + txtmodel.Text.ToUpper() + "' order by packingdate asc )");
                        }
                        else if (qty == Convert.ToDouble(dtcheckstock.Rows[0]["quantity"].ToString()))
                        {
                            connect.exedata("delete from packinginfo where idpack =(select top 1 idpack from packinginfo where partno = '" + txtmodel.Text.ToUpper() + "' order by packingdate asc )");
                        }
                        else
                        {
                            tmp = qty - Convert.ToDouble(dtcheckstock.Rows[0]["quantity"].ToString());
                            connect.exedata("delete from packinginfo where idpack =(select top 1 idpack from packinginfo where partno = '" + txtmodel.Text.ToUpper() + "' order by packingdate asc )");
                            DataTable dtcheckagain = connect.readdata("select top 1  quantity from packinginfo where partno='" + txtmodel.Text.ToUpper() + "' order by packingdate asc");
                            connect.exedata("update packinginfo set quantity =quantity-" + tmp + " where idpack =(select top 1 idpack from packinginfo where partno = '" + txtmodel.Text.ToUpper() + "' order by packingdate asc )");
                        }
                    }
                    else
                    {

                        check = false;
                    }
                }
            }

            return check;
        }
        private void cbwarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = connect.readdata("select * from location where idwarehouse='" + cbwarehouse.SelectedValue + "'");
            if (dt2 != null)
            {
                try
                {
                    cblocation.DataSource = dt2;
                    cblocation.DisplayMember = "namelocation";
                    cblocation.ValueMember = "idlocation";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection faile", ex.ToString());
                }
            }
        }

        private void txtboxno_TextChanged(object sender, EventArgs e)
        {
            txtqty.Text = "0";
            DataTable dtShortagePlan = connect.readdata("select shortage from view_shortage_plan where partno ='" + txtmodel.Text + "' and idlocation ='" + cblocation.SelectedValue.ToString() + "' and idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "'");
            if (txtboxno.Text.Length == 14)
            {
                DataTable packqty = connect.readdata("select * from packinginfo where idpack='" + txtboxno.Text + "'");
                DataTable dt = connect.readdata("select * from packingstandard where partno='" + txtmodel.Text.ToUpper() + "' and idpacking like '" + txtboxno.Text.Substring(0, 3) + "'");
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Phương thức đóng gói không tồn tại !");
                    txtboxno.Text = "";
                    txtactualqty.Text = "0";
                }
                else
                {
                    if (dt.Rows[0]["quantity"].ToString() == "0")
                    {
                        MessageBox.Show("Xin vui long chọn cách đóng gói khác");
                        txtboxno.Text = "";
                    }
                    else
                    {
                        if (checkBox2.Checked == false)
                        {
                            txtqty.Text = dt.Rows[0]["quantity"].ToString();
                            txtpartno.Focus();
                        }
                        else
                        {
                            txtsoluong.Focus();
                            DataTable dtpacking = connect.readdata("select quantity from packingstandard where partno='" + txtmodel.Text.ToUpper() + "' and idpacking like '" + txtboxno.Text.Substring(0, 3) + "'");
                            txtsoluong.Text = dtpacking.Rows[0]["quantity"].ToString();
                            txtqty.Text = dt.Rows[0]["quantity"].ToString();
                        }
                        if (packqty.Rows.Count != 0)
                        {
                            if (packqty.Rows[0]["partno"].ToString() != txtmodel.Text.ToUpper().ToString())
                            {
                                MessageBox.Show("Box này đã được sử dụng cho mã hàng khác !");
                                txtboxno.Focus();
                                txtboxno.Text = "";
                                txtqty.Text = "";
                            }
                            else
                            {
                                txtboxno.Enabled = false;
                                if (Convert.ToInt32(packqty.Rows[0]["quantity"].ToString()) >= Convert.ToInt32(dt.Rows[0]["quantity"].ToString()))
                                {
                                    MessageBox.Show("Box full!");
                                    txtboxno.Text = "";
                                    txtboxno.Enabled = true;
                                    txtsoluong.Text = "";
                                }
                                else
                                {
                                    if (checkBox2.Checked == true)
                                    {
                                        // MessageBox.Show("true");
                                        txtsoluong.Focus();
                                        DataTable dtpacking = connect.readdata("select quantity from packingstandard where partno='" + txtmodel.Text.ToUpper() + "' and idpacking like '" + txtboxno.Text.Substring(0, 3) + "'");
                                        DataTable dtpackinginfo = connect.readdata("select quantity from packinginfo where idpack='" + txtboxno.Text + "'");
                                        txtqty.Text = dtpackinginfo.Rows[0]["quantity"].ToString();
                                        txtsoluong.Text = packqty.Rows[0]["quantity"].ToString();

                                    }
                                    else if (checkBox2.Checked == false)
                                    {
                                        //  MessageBox.Show("false");
                                        txtpartno.Focus();
                                    }

                                    txtactualqty.Text = packqty.Rows[0]["quantity"].ToString();
                                }
                            }

                        }

                    }
                }

            }

        }


        private void btnpower_Click(object sender, EventArgs e)
        {
            if (btnpower.Text == "Stop line")
            {
                DataTable dtplan = connect.readdata("select productionplan from productionplan where partno='" + txtmodel.Text + "' and idlocation='" + cblocation.SelectedValue.ToString() + "' and idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "' and productiondate= CONVERT(date, GETDATE()) ");
                if (dtplan.Rows.Count > 0)
                {
                    connect.exedata("exec spInsertTrackingUPH @partno='" + txtmodel.Text + "' ,@locationid='" + cblocation.SelectedValue.ToString() + "',@remark=''");
                    btnpower.Text = "CONTINUE";
                    plan = Convert.ToInt32(dtplan.Rows[0]["productionplan"].ToString());
                    checkBox1.Enabled = true;
                    txtpartno.Focus();
                    btnpacking.Enabled = true;
                    HANMISYSTEM.Properties.Settings.Default.status = "CONTINUE";
                    connect.exedata("update runingstatus set status='CONTINUE' where idwarehouse='" + cbwarehouse.SelectedValue + "' and idlocation ='" + cblocation.SelectedValue + "'");
                    Properties.Settings.Default.Save();
                    txtmodel.Enabled = false;
                    cbwarehouse.Enabled = false;
                    cblocation.Enabled = false;
                    DataTable dt = connect.readdata("select * from productionstatus where partno='" + txtmodel.Text.ToUpper() + "' and productiondate=convert(date,getdate()) and idlocation='" + cblocation.SelectedValue + "'");
                    if (dt.Rows.Count > 0)
                    {
                        connect.exedata("update productionstatus set continuetime=getdate() where idlocation='" + cblocation.SelectedValue + "' and partno='" + txtmodel.Text.ToUpper() + "' and productiondate=convert(date,getdate())");
                    }
                    else
                    {
                        connect.exedata("insert into productionstatus (partno,idwarehouse,idlocation,productiondate,starttime) values('" + txtmodel.Text.ToUpper() + "','" + cbwarehouse.SelectedValue + "','" + cblocation.SelectedValue + "',convert(date,getdate()),getdate())");
                    }
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("Chưa có kế hoạch cho mã : " + txtmodel.Text + " ngày " + DateTime.Now.ToString("yyyy-MM-dd") + "");
                }
            }
            else
            {
                btnpower.Text = "Stop line";
                checkBox1.Enabled = false;
                HANMISYSTEM.Properties.Settings.Default.status = "Stop line";
                connect.exedata("update runingstatus set status='Stop line' where idwarehouse='" + cbwarehouse.SelectedValue + "' and idlocation ='" + cblocation.SelectedValue + "'");
                Properties.Settings.Default.Save();
                txtmodel.Enabled = true;
                btnpacking.Enabled = false;
                cbwarehouse.Enabled = true;
                cblocation.Enabled = true;
                timer1.Stop();
                DialogResult dlr;
                dlr = CustomMsgBox.Show("Tại sao bạn lại muốn dừng lại ", "Thông báo", "Kết thúc ngày làm việc", "Nghỉ giải lao", "Hủy");
                if (dlr == DialogResult.Yes)
                {
                    connect.exedata("with cte as (select top 1 EndTime from TrackingUPH where PartNo='" + txtmodel.Text + "' and LocationID='" + cblocation.SelectedValue.ToString() + "' order by StartTime Desc) update cte set EndTime =getdate()");
                    connect.exedata("update runingstatus set partno='' where idwarehouse='WH001' and idlocation='" + cblocation.SelectedValue + "'");
                    connect.exedata("insert into productionhistory (idwarehouse,partno,idlocation,stoptime,remark) values ('" + cbwarehouse.SelectedValue + "','" + txtmodel.Text.ToUpper() + "','" + cblocation.SelectedValue + "',getdate(),'Stop working day')");
                    connect.exedata("update productionstatus set stoptime=getdate(),lastesttarget='0' where idlocation='" + cblocation.SelectedValue + "' and partno='" + txtmodel.Text.ToUpper() + "'and productiondate=convert(date,getdate())");
                    txttarget.Text = "0";
                    txtboxno.Text = "";
                    txtqty.Text = "0";
                    txtactualqty.Text = "0";

                }
                else if (dlr == DialogResult.No)
                {
                    connect.exedata("with cte as (select top 1 EndTime from TrackingUPH where PartNo='" + txtmodel.Text + "' and LocationID='" + cblocation.SelectedValue.ToString() + "' order by StartTime Desc) update cte set EndTime =getdate()");
                    connect.exedata("insert into productionhistory (idwarehouse,partno,idlocation,stoptime,remark) values ('" + cbwarehouse.SelectedValue + "','" + txtpartno.Text + "','" + cblocation.SelectedValue + "',getdate(),'Break time')");
                    connect.exedata("update productionstatus set stoptime=getdate(),lastesttarget='" + txttarget.Text + "' where idlocation='" + cblocation.SelectedValue + "' and partno='" + txtmodel.Text.ToUpper() + "' and productiondate=convert(date,getdate())");
                }
                else
                {
                    btnpower.Text = "CONTINUE";
                    txtmodel.Enabled = false;
                    timer1.Start();
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataTable dtproductivity = connect.readdata("select productivity from cargo where partno='" + txtmodel.Text.ToUpper() + "'");
            int pro = Convert.ToInt32(dtproductivity.Rows[0]["productivity"].ToString());
            DateTime t;
            TimeSpan t1;
            t = connect.returndate("select continuetime from productionstatus where partno='" + txtmodel.Text.ToUpper() + "' and idlocation='" + cblocation.SelectedValue + "' and productiondate=convert(date,getdate())");
            if (t == DateTime.MinValue)
            {
                t1 = DateTime.Now - connect.returndate("select starttime from productionstatus where partno='" + txtmodel.Text.ToUpper() + "' and idlocation='" + cblocation.SelectedValue + "' and productiondate=convert(date,getdate())");
            }
            else
            {
                t1 = DateTime.Now - t;
            }

            double ltarget;
            double target;
            DataTable dt = connect.readdata("select lastesttarget from productionstatus where partno='" + txtmodel.Text.ToUpper() + "' and idlocation='" + cblocation.SelectedValue + "' and productiondate=convert(date,getdate())");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["lastesttarget"].ToString() != "" && connect.countdata("select COUNT(qty) from productionhistory where DAY(productiontime) =DAY(GETDATE()) and productiontime <GETDATE() and partno ='" + txtmodel.Text.ToUpper() + "'") != 0)
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


            DataTable dt1 = connect.readdata("select * from updatestatus where partno='" + txtmodel.Text.ToUpper() + "' and productiondate=convert(date,getdate()) and idlocation='" + cblocation.SelectedValue + "'");

            if (dt1.Rows.Count > 0)
            {
                connect.exedata("exec spUpdateUPdateStatus @currenttarget='" + txttarget.Text + "',@partno='" + txtmodel.Text.ToUpper() + "',@idlocation='" + cblocation.SelectedValue + "'");
            }
            else
            {
                connect.exedata("exec spInsertUPdateStatus @currenttarget='" + txttarget.Text + "',@partno='" + txtmodel.Text.ToUpper() + "',@idlocation='" + cblocation.SelectedValue + "'");
            }
        }

        private void txtactualqty_TextChanged(object sender, EventArgs e)
        {
            if (txtqty.Text != "0")
            {
                txtboxno.Enabled = false;
                if (Convert.ToInt32(txtactualqty.Text) == Convert.ToInt32(txtqty.Text))
                {
                    DialogResult dlr;
                    dlr = MessageBox.Show("BOx đã đầy ,Xin hãy kết thúc quá trình đóng gói", "Notice", MessageBoxButtons.OK);
                    if (dlr == DialogResult.OK)
                    {
                        txtboxno.Text = "";
                        txtactualqty.Text = "0";

                        txtqty.Text = "0";
                        txtboxno.Enabled = true;
                        txtboxno.Focus();
                    }
                }
            }

        }

        private void btnpacking_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                txtboxno.Text = "";
                txtactualqty.Text = "0";
                txtqty.Text = "0";
                txtboxno.Enabled = true;

            }
            else
            {
                if (txtboxno.Text == "")
                {
                    MessageBox.Show("Lưu ý : Chọn box(xe,túi) dùng để đóng hàng trước");
                    txtsoluong.Text = "";
                    txtboxno.Focus();
                }
                else
                {
                    if (_isnumber.IsNumber(txtsoluong.Text) == true || txtsoluong.Text == "")
                    {
                        if (Convert.ToInt32(txtsoluong.Text) > Convert.ToInt32(txtqty.Text) || Convert.ToInt32(txtsoluong.Text) <= 0)
                        {
                            MessageBox.Show("Sô lượng vượt quá giới hạn cho phép");
                            txtsoluong.Text = txtqty.Text;
                        }
                        else
                        {
                            connect.exedata("insert into productionhistory (idwarehouse,partno,productiontime,qty,idlocation,idpack) values('" + cbwarehouse.SelectedValue + "','" + txtmodel.Text.ToUpper() + "',getdate(),'" + txtsoluong.Text + "','" + cblocation.SelectedValue + "','" + txtboxno.Text + "')");
                            if (connect.countdata("select count(idpack) from packinginfo where idpack = '" + txtboxno.Text + "'") != 0)
                            {
                                connect.exedata("update packinginfo set quantity ='" + txtsoluong.Text + "' where idpack ='" + txtboxno.Text + "'");
                            }
                            else
                            {
                                connect.exedata("insert into packinginfo (idpack,partno,quantity,packingdate,idlocation,idwarehouse) values('" + txtboxno.Text + "','" + txtmodel.Text.ToUpper() + "','" + txtsoluong.Text + "',getdate(),'" + cblocation.SelectedValue + "','" + cbwarehouse.SelectedValue + "') ");
                            }
                            connect.exedata("update runingstatus set partno='" + txtmodel.Text.ToUpper() + "' where idwarehouse='WH001' and idlocation='" + cblocation.SelectedValue + "'");
                            DataTable dtinventory = connect.readdata("select sum(quantity) as stock from packinginfo where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' and partno='" + txtmodel.Text + "'");
                            if (dtinventory.Rows.Count > 0)
                            {
                                txtinventory.Text = dtinventory.Rows[0]["stock"].ToString();
                            }
                            //bom solve in here 
                            DataTable dtbom = connect.readdata("with temp(partno,rawpartno,quantity) as (select partno,rawpartno,quantity from bom where partno='" + txtmodel.Text + "' union all select a.partno,b.rawpartno,a.quantity*b.quantity from temp as a, bom as b where a.rawpartno=b.partno and (select ProcessID from cargo where partno ='" + txtmodel.Text + "')=(select ProcessID from cargo where partno=b.partno) ) select rawpartno, SUM(quantity) as quantity from (select * from temp t1 where (select ProcessID from cargo where partno ='" + txtmodel.Text + "')<>(select ProcessID from cargo where partno=t1.rawpartno)) as temp1 inner join cargo c1 on temp1.partno=c1.partno group by temp1.partno,rawpartno order by temp1.partno asc");
                            if (dtbom.Rows.Count > 0)
                            {
                                for (int i = 0; i < dtbom.Rows.Count; i++)
                                {
                                    if (connect.countdata("select count(partno) from stock where idwarehouse ='WH014' and partno='" + dtbom.Rows[i]["rawpartno"].ToString() + "'") == 0)
                                    {
                                        connect.exedata("insert into stock(idwarehouse,partno,quantity) values('WH014','" + dtbom.Rows[i]["rawpartno"].ToString() + "','" + (Convert.ToDouble(dtbom.Rows[i]["quantity"].ToString()) * Convert.ToDouble(txtsoluong.Text) * -1) + "')");
                                    }
                                    else
                                    {
                                        connect.exedata("update stock set quantity =quantity-" + (Convert.ToDouble(dtbom.Rows[i]["quantity"].ToString()) * Convert.ToDouble(txtsoluong.Text)) + " where partno='" + dtbom.Rows[i]["rawpartno"].ToString() + "'");
                                    }
                                }
                            }
                            //clear data
                            txtboxno.Text = "";
                            txtsoluong.Text = "";
                            txtboxno.Enabled = true;
                            txtboxno.Focus();
                            DataTable dtsumqty = connect.readdata("select sum(qty) as pro from productionhistory where partno='" + txtmodel.Text.ToUpper() + "' and idlocation='" + cblocation.SelectedValue + "' and convert(date,productiontime)=convert(date,getdate())");
                            txtproductionqty.Text = dtsumqty.Rows[0]["pro"].ToString();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Xin hãy nhập vào 1 số");
                        txtsoluong.Text = "";
                    }
                }

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmprod_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnpower.Text == "CONTINUE")
            {
                MessageBox.Show("You can not close form while line runing");
                e.Cancel = true;
            }
        }

        private void cblocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*  DataTable dt = connect.readdata("select * from tbl_user where username='"+HANMISYSTEM.Properties.Settings.Default.username+"'");
              if(cblocation.SelectedValue.ToString()!=dt.Rows[0]["location"].ToString())
              {
                  MessageBox.Show("you dont have permission");
              }
              txtboxno.Enabled = true; 
             */
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtngpartno.Enabled = true;
            }
            else
            {
                txtngpartno.Enabled = false;
            }
        }

        private void txtngpartno_TextChanged(object sender, EventArgs e)
        {
            if (txtngpartno.Text.Length >= 11)
            {
                if (txtngpartno.Text == txtmodel.Text.ToUpper())
                {
                    if (connect.exedata("insert into tbl_nghistory (partno,idlocation,idwarehouse,quantity,productiontime) values('" + txtngpartno.Text + "','" + cblocation.SelectedValue + "','" + cbwarehouse.SelectedValue + "','1',getdate())"))
                    {
                        DataTable dtng = connect.readdata("select * from bom where partno='" + txtmodel.Text + "'");
                        if (dtng.Rows.Count > 0)
                        {
                            for (int i = 0; i < dtng.Rows.Count; i++)
                            {
                                connect.exedata("insert into tbl_nghistory (partno,quantity,idwarehouse,productiontime) values ('" + dtng.Rows[i]["rawpartno"].ToString() + "','" + dtng.Rows[i]["quantity"].ToString() + "','" + cbwarehouse.SelectedValue + "',getdate())");
                            }
                        }
                        txtngqty.Text = connect.countdata("select count(quantity) from tbl_nghistory  where convert(date,productiontime)=convert(date,getdate()) and partno='" + txtmodel.Text.ToUpper() + "' and idwarehouse='" + cbwarehouse.SelectedValue + "' and idlocation='" + cblocation.SelectedValue + "'").ToString();
                        txtngpartno.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("chiu cheet");
                        txtngqty.Text = "";
                    }

                }
                else
                {
                    MessageBox.Show("Partno không hợp lệ");
                    txtngqty.Text = "";
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                label7.Visible = false;
                txtactualqty.Visible = false;
                label5.Visible = false;
                txtpartno.Visible = false;
                checkBox1.Visible = false;
                label9.Visible = false;
                txtngpartno.Visible = false;
                txtngqty.Visible = false;
                label10.Visible = true;
                txtsoluong.Visible = true;
            }
            else
            {
                label7.Visible = true;
                txtactualqty.Visible = true;
                label5.Visible = true;
                txtpartno.Visible = true;
                checkBox1.Visible = true;
                label9.Visible = true;
                txtngpartno.Visible = true;
                txtngqty.Visible = true;

                label10.Visible = false;
                txtsoluong.Visible = false;
            }
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsoluong_Validated(object sender, EventArgs e)
        {
            if (_isnumber.IsNumber(txtsoluong.Text) == true)
            {
                if (txtqty.Text != "" || txtqty.Text != "0")
                {
                    if (Convert.ToInt32(txtsoluong.Text) > Convert.ToInt32(txtqty.Text) || Convert.ToInt32(txtsoluong.Text) < 0)
                    {
                        MessageBox.Show("Sô lượng vượt quá giới hạn cho phép");
                        txtsoluong.Text = txtqty.Text;
                    }
                }

            }
            else
            {
                MessageBox.Show("Lưu ý chỉ nhập vào 1 số");
                txtsoluong.Text = txtqty.Text;
            }

        }

        private void txtsoluong_Enter(object sender, EventArgs e)
        {

        }



        private void lbsearch_Click(object sender, EventArgs e)
        {
            if (lbsearch.SelectedItem != null)
            {
                txtmodel.Text = lbsearch.SelectedItem.ToString();
                lbsearch.Visible = false;

                DataTable dt = connect.readdata("select lastesttarget from productionstatus where partno='" + txtmodel.Text.ToUpper() + "' and idlocation='" + cblocation.SelectedValue + "' and productiondate=convert(date,getdate())");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["lastesttarget"].ToString() != "")
                    {
                        txttarget.Text = dt.Rows[0]["lastesttarget"].ToString();
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
                DataTable dt1 = connect.readdata("select productionplan from productionplan where partno='" + txtmodel.Text.ToUpper() + "' and idlocation='" + cblocation.SelectedValue + "' and productiondate=convert(date,getdate())");
                if (dt1.Rows.Count > 0)
                {

                    txtplan.Text = dt1.Rows[0]["productionplan"].ToString();
                }
                else
                {
                    txtplan.Text = "0";
                }
                txtboxno.Text = "";
                txtqty.Text = "0";
                txtactualqty.Text = "0";
                txtboxno.Enabled = true;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lbsearch.Visible = true;
            lbsearch.Items.Clear();
            DataTable dtsearch = connect.readdata("select top 15 partno from cargo where partno like '%" + txtmodel.Text + "%' and idcategory ='3'");
            for (int i = 0; i < dtsearch.Rows.Count; i++)
            {
                lbsearch.Items.Add(dtsearch.Rows[i]["partno"].ToString());
            }
        }

        private void btnremark_Click(object sender, EventArgs e)
        {
            IssueReport fr = new IssueReport();
            fr.lbLocation.Text = cblocation.SelectedValue.ToString();
            fr.lbModel.Text = txtmodel.Text;
            fr.ShowDialog();
        }
    }
}