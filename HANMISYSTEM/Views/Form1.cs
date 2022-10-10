using System;
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
using HANMISYSTEM.Views.PartialView;
using System.IO.Ports;
using HANMISYSTEM.Common;

namespace HANMISYSTEM
{
    public partial class frmprod : Form
    {


        public frmprod()
        {
            InitializeComponent();
            //AutoUpdateTarget();
        }
        SerialPort serialPort = new SerialPort(HANMISYSTEM.Properties.Settings.Default.comport, Convert.ToInt32(HANMISYSTEM.Properties.Settings.Default.baudrate));
        Dbconnect connect = new Dbconnect();
        Isnumber _isnumber = new Isnumber();
        PackingController packageController = new PackingController();
        int plan;
        bool checkStatus;
        public string pushnotifytype;
        private void CallOK()
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                }
                //close relay
                var chanel1 = new byte[] { 0x55, 0x56, 0x00, 0x00, 0x00, 0x01, 0x04, 0xB0 };
                serialPort.Write(chanel1, 0, chanel1.Length);
                //serialPort.WriteLine('\n' + "@R0" + '\r');
                //Thread.Sleep(10);
                //serialPort.WriteLine('\n' + "@Y0" + '\r');
                //Thread.Sleep(10);
                //serialPort.WriteLine('\n' + "@G1" + '\r');
                //Thread.Sleep(10);
                //serialPort.WriteLine('\n' + "@B0" + '\r');

                serialPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void CallNG()
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                }
                //serialPort.WriteLine('\n' + "@R1" + '\r');
                //Thread.Sleep(10);
                //serialPort.WriteLine('\n' + "@Y0" + '\r');
                //Thread.Sleep(10);
                //serialPort.WriteLine('\n' + "@G0" + '\r');
                //Thread.Sleep(10);
                //serialPort.WriteLine('\n' + "@B1" + '\r');


                if(pushnotifytype=="1")
                {
                    //chanel 1
                    var chanel1 = new byte[] { 0x55, 0x56, 0x00, 0x00, 0x00, 0x01, 0x01, 0xAD };
                    serialPort.Write(chanel1, 0, chanel1.Length);
                }
                else
                {
                    ////chanel 2
                    var chanel2 = new byte[] { 0x55, 0x56, 0x00, 0x00, 0x00, 0x02, 0x01, 0xAE };
                    serialPort.Write(chanel2, 0, chanel2.Length);
                }

   
                //Thread.Sleep(10);
                serialPort.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }
        private void frmprod_Load(object sender, EventArgs e)
        {

            //set push notify type 
            if( !string.IsNullOrEmpty(HANMISYSTEM.Properties.Settings.Default.pushnotifytype))
            {
                pushnotifytype=HANMISYSTEM.Properties.Settings.Default.pushnotifytype;
            }
            else
            {
                pushnotifytype = "1";
            }
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
                            if (connect.countdata("select count(partno) from productionhistory where partno='" + txtpartno.Text.ToUpper() + "' and idlocation='" + cblocation.SelectedValue + "' and convert(date,productiontime)=CONVERT(DATE,GETDATE())") < plan)
                            {
                                if (txtboxno.Text == "")
                                {
                                    MessageBox.Show("XIN HÃY NHẬP MÃ ĐÓNG GÓI TRƯỚC TIÊN !!!");
                                    txtpartno.Text = "";
                                }
                                else
                                {
                                    if(pushnotifytype=="2")
                                    {
                                        CallOK();
                                    }
                                    //them lich su va running status
                                    //connect.exedata("exec spInsertProductionHistory @idwarehouse='" + cbwarehouse.SelectedValue + "',@partno='" + txtpartno.Text.ToUpper() + "',@remark='" + remark + "',@idlocation='" + cblocation.SelectedValue + "',@idpack='" + txtboxno.Text + "'");
                                    connect.exedata("update runingstatus set partno=@partno where idlocation='" + cblocation.SelectedValue.ToString() + "'");
                                    connect.exedata("insert into productionhistory (idwarehouse,partno,productiontime,remark,qty,idlocation,idpack,WO,PlanID) values('" + cbwarehouse.SelectedValue.ToString() + "','" + txtmodel.Text + "',GETDATE(),'" + remark + "',1,'" + cblocation.SelectedValue + "','" + txtboxno.Text + "','" + txtworkorder.Text + "','" + txtPlanID.Text + "')");
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
                                        connect.exedata("insert INTO productionstatus (partno,idwarehouse,idlocation,productiondate,starttime,WO) values('" + txtpartno.Text + "','" + cbwarehouse.SelectedValue + "','" + cblocation.SelectedValue + "',convert(date,getdate()),getdate(),'" + txtworkorder.Text + "')");
                                        txtpartno.Text = "";
                                    }
                                    else
                                    {
                                        txtpartno.Text = "";
                                    }
                                    
                                }
                            }
                            else
                            {
                                using (Notify frm =new Notify())
                                {
                                    frm.content = "Kế hoạch đã hoàn thành ";
                                    frm.ShowDialog();
                                }
                                txtpartno.Text = "";
                                //MessageBox.Show("Chưa có kết hoạch " + plan + connect.countdata("select count(*) from productionhistory where partno='" + txtmodel.Text.ToUpper() + "' and idlocation='" + cblocation.SelectedValue + "' and convert(date,productiontime)=convert(date,getdate())"));
                                
                            }
                        }
                    }
                    else
                    {
                        using (Notify frm = new Notify())
                        {
                            CallNG();
                            frm.content = "Label : " + txtpartno.Text + " không hợp lệ.Xin hãy kiểm tra lại !!!";
                            frm.ShowDialog();
                        }
                        txtpartno.Text = "";
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
            //DataTable dtShortagePlan = connect.readdata("select shortage from view_shortage_plan where partno ='" + txtmodel.Text + "' and idlocation ='" + cblocation.SelectedValue.ToString() + "' and idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "'");
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
                                    if (packageController.CheckLabel(txtmodel.Text))
                                    {
                                        CheckPackageLabel frm = new CheckPackageLabel();
                                        frm.label = txtmodel.Text;
                                        frm.ShowDialog();

                                        if (checkBox2.Checked == true)
                                        {
                                            txtsoluong.Focus();
                                            DataTable dtpacking = connect.readdata("select quantity from packingstandard where partno='" + txtmodel.Text.ToUpper() + "' and idpacking like '" + txtboxno.Text.Substring(0, 3) + "'");
                                            DataTable dtpackinginfo = connect.readdata("select quantity from packinginfo where idpack='" + txtboxno.Text + "'");
                                            txtsoluong.Text = (Convert.ToInt32(dt.Rows[0]["quantity"].ToString()) - Convert.ToInt32(packqty.Rows[0]["quantity"].ToString())).ToString();
                                            txtqty.Text = (Convert.ToInt32(dt.Rows[0]["quantity"].ToString()) - Convert.ToInt32(packqty.Rows[0]["quantity"].ToString())).ToString();

                                        }
                                        else if (checkBox2.Checked == false)
                                        {
                                            txtqty.Text = (Convert.ToInt32(dt.Rows[0]["quantity"].ToString()) - Convert.ToInt32(packqty.Rows[0]["quantity"].ToString())).ToString();
                                            txtpartno.Focus();
                                        }

                                        txtactualqty.Text = packqty.Rows[0]["quantity"].ToString();



                                    }
                                    else
                                    {
                                        if (checkBox2.Checked == true)
                                        {
                                            txtsoluong.Focus();
                                            DataTable dtpacking = connect.readdata("select quantity from packingstandard where partno='" + txtmodel.Text.ToUpper() + "' and idpacking like '" + txtboxno.Text.Substring(0, 3) + "'");
                                            DataTable dtpackinginfo = connect.readdata("select quantity from packinginfo where idpack='" + txtboxno.Text + "'");
                                            txtsoluong.Text = (Convert.ToInt32(dt.Rows[0]["quantity"].ToString()) - Convert.ToInt32(packqty.Rows[0]["quantity"].ToString())).ToString();
                                            txtqty.Text = (Convert.ToInt32(dt.Rows[0]["quantity"].ToString()) - Convert.ToInt32(packqty.Rows[0]["quantity"].ToString())).ToString();

                                        }
                                        else if (checkBox2.Checked == false)
                                        {
                                            txtqty.Text = (Convert.ToInt32(dt.Rows[0]["quantity"].ToString()) - Convert.ToInt32(packqty.Rows[0]["quantity"].ToString())).ToString();
                                            txtpartno.Focus();
                                        }

                                        txtactualqty.Text = packqty.Rows[0]["quantity"].ToString();
                                    }


                                }
                            }

                        }
                        else
                        {
                            if (packageController.CheckLabel(txtmodel.Text))
                            {
                                CheckPackageLabel frm = new CheckPackageLabel();
                                frm.label = txtmodel.Text;
                                frm.ShowDialog();
                                if (frm.label == txtmodel.Text)
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
                                        txtsoluong.Text = dt.Rows[0]["quantity"].ToString();
                                        txtqty.Text = dt.Rows[0]["quantity"].ToString();
                                    }
                                }


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
                                    txtsoluong.Text = dt.Rows[0]["quantity"].ToString();
                                    txtqty.Text = dt.Rows[0]["quantity"].ToString();
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
                    //kiem tra giai doan truoc da có endtime hay chưa
                    DataTable dtendtime = connect.readdata("select top 1 EndTime  from TrackingUPH where LocationID='" + cblocation.SelectedValue.ToString() + "' and  CONVERT(date,StartTime)=convert(date,getdate()) order by StartTime desc");
                    if (dtendtime.Rows.Count > 0)
                    {
                        if (string.IsNullOrEmpty(dtendtime.Rows[0]["EndTime"].ToString()))
                        {
                            //them endtime
                            connect.exedata("with cte as (select top 1 *  from TrackingUPH where LocationID = '" + cblocation.SelectedValue.ToString() + "' and  CONVERT(date, StartTime) = CONVERT(date, getdate()) order by StartTime desc) update cte set EndTime = GETDATE(),Remark='EndTime added by system'");
                        }
                    }
                    connect.exedata("exec spInsertTrackingUPH @partno='" + txtmodel.Text + "' ,@locationid='" + cblocation.SelectedValue.ToString() + "',@remark=''");
                    btnpower.Text = "CONTINUE";
                    //plan = Convert.ToInt32(dtplan.Rows[0]["productionplan"].ToString());
                    checkBox1.Enabled = true;
                    txtpartno.Focus();
                    btnpacking.Enabled = true;
                    Properties.Settings.Default.Save();
                    txtmodel.Enabled = false;
                    cbwarehouse.Enabled = false;
                    cblocation.Enabled = false;
                    checkStatus = true;
                    //timer1.Start();
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
                DialogResult dlr;
                checkStatus = false;
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
                    checkStatus = true;
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
            if (checkBox2.Checked == false)
            {
                if (txtboxno.Text.Length >= 14)
                {
                    DataTable dtpack = connect.readdata("select quantity from packingstandard where partno ='" + txtmodel.Text.ToUpper() + "' and idpacking='" + txtboxno.Text.Substring(0, 3) + "' ");
                    if (txtqty.Text != "0")
                    {
                        txtboxno.Enabled = false;
                        if (Convert.ToInt32(txtactualqty.Text) == Convert.ToInt32(dtpack.Rows[0]["quantity"].ToString()))
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
                txtboxno.Focus();
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
                            connect.exedata("update runingstatus set partno=@partno where idlocation='" + cblocation.SelectedValue.ToString() + "'");
                            connect.exedata("insert into productionhistory (idwarehouse,partno,productiontime,qty,idlocation,idpack,WO,PlanID) values('" + cbwarehouse.SelectedValue.ToString() + "','" + txtmodel.Text + "',GETDATE(),'" + txtsoluong.Text + "','" + cblocation.SelectedValue + "','" + txtboxno.Text + "','" + txtworkorder.Text + "','" + txtPlanID.Text + "')");
                            //connect.exedata("insert into productionhistory (idwarehouse,partno,productiontime,qty,idlocation,idpack) values('" + cbwarehouse.SelectedValue + "','" + txtmodel.Text.ToUpper() + "',getdate(),'" + txtsoluong.Text + "','" + cblocation.SelectedValue + "','" + txtboxno.Text + "')");
                            if (connect.countdata("select count(idpack) from packinginfo where idpack = '" + txtboxno.Text + "'") != 0)
                            {
                                connect.exedata("update packinginfo set quantity =quantity + '" + txtsoluong.Text + "' where idpack ='" + txtboxno.Text + "'");
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
                if (txtboxno.Text.Length < 14)
                {
                    txtboxno.Focus();
                }
                else
                {
                    DataTable dtpacked = connect.readdata("select quantity from packinginfo where idpack='" + txtboxno.Text + "'");
                    DataTable dtpackingstandard = connect.readdata("select quantity from packingstandard where partno='" + txtmodel.Text + "' and idpacking='" + txtboxno.Text.Substring(0, 3) + "' ");
                    int packed = (dtpacked == null || dtpacked.Rows.Count == 0) ? 0 : Convert.ToInt32(dtpacked.Rows[0]["quantity"].ToString());
                    txtsoluong.Text = (Convert.ToInt32(dtpackingstandard.Rows[0]["quantity"].ToString()) - packed).ToString();
                }
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
                if (txtboxno.Text != "")
                {
                    txtpartno.Focus();
                }
                else
                {
                    txtboxno.Focus();
                }
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

        public void LabelSearch()
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

        private void lbsearch_Click(object sender, EventArgs e)
        {
            LabelSearch();
        }
        private void TextModelChange()
        {
            lbsearch.Visible = true;
            lbsearch.Items.Clear();
            DataTable dtsearch = connect.readdata("select top 15 partno from cargo where partno like '%" + txtmodel.Text + "%' and idcategory ='3'");
            for (int i = 0; i < dtsearch.Rows.Count; i++)
            {
                lbsearch.Items.Add(dtsearch.Rows[i]["partno"].ToString());
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextModelChange();
        }

        private void btnremark_Click(object sender, EventArgs e)
        {
            //IssueReport fr = new IssueReport();
            //fr.lbLocation.Text = cblocation.SelectedValue.ToString();
            //fr.lbModel.Text = txtmodel.Text;
            //fr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SelectWorkOrder frm = new SelectWorkOrder())
            {
                DataTable dtLocation = connect.readdata("select namelocation1 from location where idlocation ='" + cblocation.SelectedValue + "'");
                SelectWorkOrder fr = new SelectWorkOrder();
                fr.lbline.Text = dtLocation.Rows[0]["namelocation1"].ToString();
                fr.dataGridView1.AutoGenerateColumns = false;
                DataTable dtwo = connect.readdata("select ROW_NUMBER() over(order by p.partno) as r ,isnull(w.Code,p.WOCode) as WorkOrder,p.ID as PlanID,p.partno,c.partname,c.Color,c.Market,p.PST,p.productionplan from productionplan p  left join WorkOrder w on p.WorkOrderID=w.ID inner join cargo c on c.partno =p.partno where (p.Status is null or p.Status<> 0 )  and p.idlocation='" + cblocation.SelectedValue.ToString() + "' and productiondate =CONVERT(date,getdate())"); ;
                fr.dataGridView1.DataSource = dtwo;
                fr.ShowDialog();
                txtworkorder.Text = fr.SendData();
                txtmodel.Text = fr.sendDataModel();
                txtPlanID.Text = fr.SendPlanID();
                plan = Convert.ToInt32(fr.SendPlan());
                lbsearch.Visible = false;
                if (!packageController.CheckChangePackingMethod(txtmodel.Text))
                {
                    checkBox2.Enabled = false;
                }
                else
                {
                    checkBox2.Enabled = true;
                }
                txtplan.Text = plan.ToString();
                txtboxno.Text = "";
                txtqty.Text = "0";
                txtactualqty.Text = "0";
                txtboxno.Enabled = true; ;
            }

        }

        async void AutoUpdateTarget()
        {
            while (true)
            {
                if (checkStatus == true && txtmodel.Text != "")
                {
                    DataTable dtproductivity = connect.readdata("select productivity from cargo where partno='" + txtmodel.Text.ToUpper() + "'");
                    int pro = Convert.ToInt32(dtproductivity.Rows[0]["productivity"].ToString());
                    DateTime t;
                    DateTime ontime;
                    DateTime or;
                    TimeSpan t1;
                    t = connect.returndate("select UpdateTime from productionstatus where PartNo='" + txtmodel.Text.ToUpper() + "' and idlocation='" + cblocation.SelectedValue + "' and productiondate=convert(date,getdate())");
                    ontime = connect.returndate("select ContinueTime from productionstatus where PartNo='" + txtmodel.Text.ToUpper() + "' and idlocation='" + cblocation.SelectedValue + "' and productiondate=convert(date,getdate())");
                    if (t <= ontime)
                    {
                        or = ontime;
                    }
                    else
                    {
                        or = t;
                    }
                    DateTime cur = connect.returndate("select getdate()");

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
                    DataTable dt = connect.readdata("select lastesttarget from productionstatus where partno='" + txtmodel.Text.ToUpper() + "' and idlocation='" + cblocation.SelectedValue + "' and productiondate=convert(date,getdate())");
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
                        connect.exedata("update productionstatus set lastesttarget ='" + txttarget.Text + "',UpdateTime=getdate() where idlocation='" + cblocation.SelectedValue.ToString() + "' and PartNo='" + txtmodel.Text + "' and productiondate=convert(date,getdate())");
                    }
                    catch
                    {
                    }

                }
                await Task.Delay(10000);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Settings frm = new Settings();
            frm.ShowDialog();
        }
    }
}
