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
using System.Threading;
using HANMISYSTEM.Views.MsgBox;
using HANMISYSTEM.Views.Production;
using HANMISYSTEM.DAO;
using System.IO;
using System.Drawing.Drawing2D;
using ZXing;

namespace HANMISYSTEM
{
    public partial class frmprod : Form
    {
        public frmprod()
        {
            InitializeComponent();
            //AutoUpdateTarget();
        }
        private bool mode= false;
        DAO_SystemLog DAO_SystemLog = new DAO_SystemLog();
        DAO_AssemblyFGsWarehouse  dAO_AssemblyFGsWarehouse = new DAO_AssemblyFGsWarehouse();
        DAO_Line dAO_Line = new DAO_Line();
        DAO_Production dAO_Production = new DAO_Production();
        DAO_ProductionHistory dAO_ProductionHistory = new DAO_ProductionHistory();
        DAO_PackingInfo dAO_PackingInfo = new DAO_PackingInfo();
        SerialPort serialPort = new SerialPort(HANMISYSTEM.Properties.Settings.Default.comport, Convert.ToInt32(HANMISYSTEM.Properties.Settings.Default.baudrate));
        Dbconnect connect = new Dbconnect();
        Isnumber _isnumber = new Isnumber();
        PackingController packageController = new PackingController();
        bool toggleState = false;
        string package_capa;
        double plan;
        double curr_plan_result;
        bool checkStatus;
        string mapping_lineID;
        public string pushnotifytype;
        public string wh = "WH001";
        static string _workprocesscode = "LAPRAP2-1542";
        static string _warehouseId= "1970561";
        private void CallOK()
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                }

                var chanel1_open = new byte[] { 0x55, 0x56, 0x00, 0x00, 0x00, 0x01, 0x01, 0xAD };
                serialPort.Write(chanel1_open, 0, chanel1_open.Length);

                Thread.Sleep(200);

                var chanel1_close = new byte[] { 0x55, 0x56, 0x00, 0x00, 0x00, 0x01, 0x02, 0xAE };
                serialPort.Write(chanel1_close, 0, chanel1_close.Length);
                serialPort.Close();
            }
            catch (Exception)
            {
            }
        }

        private void RenderLabel(string qty,string wo)
        {

        }
        private void CallNG()
        {
            try
            {


                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                }
                if (pushnotifytype == "1")
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
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }

        }
        public class Mapping_Line
        {
            public string factoryCode;
            public string factoryID;
            public string machineCode;
            public string machineID;
        }
        Mapping_Line _mapping_Line = new Mapping_Line();

        private async void frmprod_Load(object sender, EventArgs e)
        {
            //do turn off relay 

            //set push notify type 
            if (!string.IsNullOrEmpty(HANMISYSTEM.Properties.Settings.Default.pushnotifytype))
            {
                pushnotifytype = HANMISYSTEM.Properties.Settings.Default.pushnotifytype;
            }
            else
            {
                pushnotifytype = "1";
            }
            DataTable dt2;
            DataTable dt3 = connect.readdata("select * from tbl_user where username='" + HANMISYSTEM.Properties.Settings.Default.username + "'");

            if (dt3.Rows[0]["location"].ToString() == "all")
            {
                dt2 = connect.readdata("select * from location where idwarehouse='" + wh + "'");
            }
            else
            {
                dt2 = connect.readdata("select * from location where idwarehouse='" + wh + "' and idlocation='" + dt3.Rows[0]["location"].ToString() + "'");
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
            mapping_lineID = await dAO_Line.GetBravoLineIDByLineID(cblocation.SelectedValue.ToString());
            DataTable dtMappingLine = await dAO_Line.GetBravoLineDetails(mapping_lineID);
            try
            {
                if (dtMappingLine.Rows.Count > 0)
                {
                    _mapping_Line.factoryCode = dtMappingLine.Rows[0]["FactoryCode"].ToString();
                    _mapping_Line.factoryID = dtMappingLine.Rows[0]["FactoryID"].ToString();
                    _mapping_Line.machineCode = dtMappingLine.Rows[0]["Code"].ToString();
                    _mapping_Line.machineID = dtMappingLine.Rows[0]["Id"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nạp dữ liệu mapping line(bravo): " + ex.Message);
            }
        }
        private async void txtpartno_TextChanged(object sender, EventArgs e)
        {
            //if (txtpartno.Text.Length >= 11)
            //{

            //    if (btnpower.Text == "Stop line")
            //    {
            //        MessageBox.Show("Line was stopped");
            //        txtpartno.Text = "";
            //    }
            //    else
            //    {
            //        if (txtpartno.Text.ToUpper() == txtmodel.Text.ToUpper().ToString().ToUpper())
            //        {

            //            if (txtqty.Text == "0" || txtboxno.Text.Contains(" ") == true)
            //            {
            //                MessageBox.Show("Mã đóng gói không hợp lệ !");
            //                txtpartno.Text = "";
            //            }
            //            else
            //            {
            //                if (Convert.ToInt32(txtproductionqty.Text) < plan)
            //                {
            //                    if (txtboxno.Text == "")
            //                    {
            //                        MessageBox.Show("XIN HÃY NHẬP MÃ ĐÓNG GÓI TRƯỚC TIÊN !!!");
            //                        txtpartno.Text = "";
            //                    }
            //                    else
            //                    {
            //                        if (pushnotifytype == "2")
            //                        {
            //                            CallOK();
            //                        }
            //                        txtproductionqty.Text = (Convert.ToInt32(txtproductionqty.Text) + 1).ToString();
            //                        //quanli packing
            //                        if (connect.countdata("select count(idpack) from packinginfo where idpack='" + txtboxno.Text + "'") == 0)
            //                        {
            //                            //err2
            //                            try
            //                            {
            //                                await connect.ExeDataAsync("exec spInsertPackingInfo @idpack='" + txtboxno.Text + "',@partno='" + txtmodel.Text.ToUpper() + "',@idlocation='" + cblocation.SelectedValue.ToString() + "',@idwarehouse='" + wh + "'");

            //                            }
            //                            catch (Exception ex)
            //                            {
            //                                MessageBox.Show("err2 :" + ex.Message);
            //                            }
            //                        }
            //                        else
            //                        {
            //                            //err4
            //                            try
            //                            {
            //                                await connect.ExeDataAsync("exec spUpdatePackingInfo_Increase @idpack='" + txtboxno.Text + "'");
            //                            }
            //                            catch (Exception ex)
            //                            {
            //                                MessageBox.Show("err4 :" + ex.Message);
            //                            }

            //                        }
            //                        //err3
            //                        try
            //                        {
            //                            await connect.ExeDataAsync("insert into productionhistory (idwarehouse,partno,productiontime,remark,qty,idlocation,idpack,WO,PlanID) values('" + wh + "','" + txtmodel.Text + "',GETDATE(),'',1,'" + cblocation.SelectedValue + "','" + txtboxno.Text + "','" + txtworkorder.Text + "','" + txtPlanID.Text + "')");

            //                        }
            //                        catch (Exception ex)
            //                        {
            //                            MessageBox.Show("err3 :" + ex.Message);
            //                        }
            //                        //err1
            //                        try
            //                        {
            //                            txtactualqty.Text = (Convert.ToInt32(txtactualqty.Text) + 1).ToString();
            //                        }
            //                        catch (Exception ex)
            //                        {
            //                            MessageBox.Show("err1 :" + ex.Message);
            //                        }
            //                        txtpartno.Text = "";

            //                    }
            //                }
            //                else
            //                {
            //                    using (Notify frm = new Notify())
            //                    {
            //                        frm.content = "Kế hoạch đã hoàn thành ";
            //                        frm.ShowDialog();
            //                    }
            //                    txtpartno.Text = "";
            //                }
            //            }
            //        }
            //        else
            //        {
            //            using (Notify frm = new Notify())
            //            {
            //                //save to stopalertcounter (table)--update 11/11/2022
            //                try
            //                {
            //                    string remark = "Mã hàng không hợp lệ " + txtpartno.Text;
            //                    await connect.ExeDataAsync("Insert into StopAlertCounter(SubmitDate,PartNo,Remark,LocationID) values(getdate(),'" + txtmodel.Text + "','" + remark + "','" + cblocation.SelectedValue.ToString() + "')"); ;
            //                }
            //                catch { }
            //                CallNG();
            //                frm.content = "Label : " + txtpartno.Text + " không hợp lệ.Xin hãy kiểm tra lại !!!";
            //                frm.ShowDialog();
            //            }
            //            txtpartno.Text = "";
            //        }
            //    }
            //}
        }
        bool check = true;
        private Boolean xulibom(string partno, double qty)
        {
            check = true;
            double tmp;
            DataTable dtcheckkho = connect.readdata("select SUM(quantity) as stock from packinginfo where partno ='" + partno + "'  and idwarehouse ='" + wh + "'");
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
            DataTable dt2 = connect.readdata("select * from location where idwarehouse='" + wh + "'");
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
                package_capa = dt.Rows[0]["quantity"].ToString();
                if (dt.Rows.Count == 0)
                {
                    using (CustomMessageBox frm = new CustomMessageBox())
                    {
                        frm.lbContent.Text = "Phương thức đóng gói không tồn tại !";
                        frm.ShowInTaskbar = false;
                        frm.ShowDialog();
                    }
                    //MessageBox.Show("Phương thức đóng gói không tồn tại !");
                    txtboxno.Text = "";
                    txtactualqty.Text = "0";
                }
                else
                {
                    if (dt.Rows[0]["quantity"].ToString() == "0")
                    {
                        using (CustomMessageBox frm = new CustomMessageBox())
                        {
                            frm.lbContent.Text = "Xin vui long chọn cách đóng gói khác !";
                            frm.ShowInTaskbar = false;
                            frm.ShowDialog();
                        }
                        //MessageBox.Show("Xin vui long chọn cách đóng gói khác");
                        txtboxno.Text = "";
                    }
                    else
                    {

                        if (packqty.Rows.Count != 0)
                        {
                            if (packqty.Rows[0]["partno"].ToString() != txtmodel.Text.ToUpper().ToString())
                            {
                                using (CustomMessageBox frm = new CustomMessageBox())
                                {
                                    frm.lbContent.Text = "Box này đã được sử dụng cho mã hàng khác !";
                                    frm.ShowInTaskbar = false;
                                    frm.ShowDialog();
                                }
                                //MessageBox.Show("Box này đã được sử dụng cho mã hàng khác !");
                                txtboxno.Focus();
                                txtboxno.Text = "";
                                txtqty.Text = "";
                            }
                            else
                            {

                                txtboxno.Enabled = false;
                                if (Convert.ToInt32(packqty.Rows[0]["quantity"].ToString()) >= Convert.ToInt32(dt.Rows[0]["quantity"].ToString()))
                                {
                                    //MessageBox.Show("Box full!");
                                    using (CustomMessageBox frm = new CustomMessageBox())
                                    {
                                        frm.lbContent.Text = "Box đầy!";
                                        frm.ShowInTaskbar = false;
                                        frm.ShowDialog();
                                    }
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
                                        //scan LOT
                                        if (checkBox2.Checked == true)
                                        {
                                            txtsoluong.Focus();
                                            DataTable dtpacking = connect.readdata("select quantity from packingstandard where partno='" + txtmodel.Text.ToUpper() + "' and idpacking like '" + txtboxno.Text.Substring(0, 3) + "'");
                                            DataTable dtpackinginfo = connect.readdata("select quantity from packinginfo where idpack='" + txtboxno.Text + "'");

                                            txtsoluong.Maximum = Convert.ToInt32(dt.Rows[0]["quantity"].ToString()) - Convert.ToInt32(packqty.Rows[0]["quantity"].ToString());
                                            txtsoluong.Text = (Convert.ToInt32(dt.Rows[0]["quantity"].ToString()) - Convert.ToInt32(packqty.Rows[0]["quantity"].ToString())).ToString();
                                            txtqty.Text = dt.Rows[0]["quantity"].ToString();

                                        }
                                        else if (checkBox2.Checked == false)
                                        {
                                            txtqty.Text = dt.Rows[0]["quantity"].ToString();
                                            txtpartno.Focus();
                                        }

                                        txtactualqty.Text = packqty.Rows[0]["quantity"].ToString();
                                        txtCurrentQuantity.Text = packqty.Rows[0]["quantity"].ToString();
                                    }
                                    else
                                    {
                                        if (checkBox2.Checked == true)
                                        {
                                            txtsoluong.Focus();
                                            DataTable dtpacking = connect.readdata("select quantity from packingstandard where partno='" + txtmodel.Text.ToUpper() + "' and idpacking like '" + txtboxno.Text.Substring(0, 3) + "'");
                                            DataTable dtpackinginfo = connect.readdata("select quantity from packinginfo where idpack='" + txtboxno.Text + "'");

                                            txtsoluong.Maximum = Convert.ToInt32(dt.Rows[0]["quantity"].ToString()) - Convert.ToInt32(packqty.Rows[0]["quantity"].ToString());
                                            txtsoluong.Text = (Convert.ToInt32(dt.Rows[0]["quantity"].ToString()) - Convert.ToInt32(packqty.Rows[0]["quantity"].ToString())).ToString();
                                            txtqty.Text = dt.Rows[0]["quantity"].ToString();

                                        }
                                        else if (checkBox2.Checked == false)
                                        {
                                            txtqty.Text = dt.Rows[0]["quantity"].ToString();
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
                                        txtsoluong.Maximum = Convert.ToInt32(dt.Rows[0]["quantity"].ToString());
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
                                    txtsoluong.Maximum = Convert.ToInt32(dt.Rows[0]["quantity"].ToString());
                                    txtsoluong.Text = dt.Rows[0]["quantity"].ToString();
                                    txtqty.Text = dt.Rows[0]["quantity"].ToString();
                                }
                            }


                        }
                    }
                }

            }

        }

        #region
        //private void btnpower_Click(object sender, EventArgs e)
        //{
        //    if (btnpower.Text == "Stop line")
        //    {
        //        DataTable dtplan = connect.readdata("select productionplan from productionplan where partno='" + txtmodel.Text + "' and idlocation='" + cblocation.SelectedValue.ToString() + "' and idwarehouse='" + wh + "' and productiondate= CONVERT(date, GETDATE()) ");
        //        if (dtplan.Rows.Count > 0)
        //        {
        //            //kiem tra giai doan truoc da có endtime hay chưa
        //            DataTable dtendtime = connect.readdata("select top 1 EndTime  from TrackingUPH where LocationID='" + cblocation.SelectedValue.ToString() + "' and  CONVERT(date,StartTime)=convert(date,getdate()) order by StartTime desc");
        //            if (dtendtime.Rows.Count > 0)
        //            {
        //                if (string.IsNullOrEmpty(dtendtime.Rows[0]["EndTime"].ToString()))
        //                {
        //                    //them endtime
        //                    connect.exedata("with cte as (select top 1 *  from TrackingUPH where LocationID = '" + cblocation.SelectedValue.ToString() + "' and  CONVERT(date, StartTime) = CONVERT(date, getdate()) order by StartTime desc) update cte set EndTime = GETDATE(),Remark='EndTime added by system'");
        //                }
        //            }
        //            connect.exedata("exec spInsertTrackingUPH @partno='" + txtmodel.Text + "' ,@locationid='" + cblocation.SelectedValue.ToString() + "',@remark=''");
        //            btnpower.Text = "CONTINUE";
        //            //plan = Convert.ToInt32(dtplan.Rows[0]["productionplan"].ToString());
        //            txtpartno.Focus();
        //            btnPacking_renew.Enabled = true;
        //            Properties.Settings.Default.Save();
        //            txtmodel.Enabled = false;
        //            cblocation.Enabled = false;
        //            checkStatus = true;
        //            //timer1.Start();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Chưa có kế hoạch cho mã : " + txtmodel.Text + " ngày " + DateTime.Now.ToString("yyyy-MM-dd") + "");
        //        }
        //    }
        //    else
        //    {
        //        btnpower.Text = "Stop line";
        //        HANMISYSTEM.Properties.Settings.Default.status = "Stop line";
        //        connect.exedata("update runingstatus set status='Stop line' where idwarehouse='" + wh + "' and idlocation ='" + cblocation.SelectedValue + "'");
        //        Properties.Settings.Default.Save();
        //        txtmodel.Enabled = true;
        //        btnPacking_renew.Enabled = false;
        //        cblocation.Enabled = true;
        //        DialogResult dlr;
        //        checkStatus = false;
        //        dlr = CustomMsgBox.Show("Tại sao bạn lại muốn dừng lại ", "Thông báo", "Kết thúc ngày làm việc", "Nghỉ giải lao", "Hủy");
        //        if (dlr == DialogResult.Yes)
        //        {
        //            connect.exedata("with cte as (select top 1 EndTime from TrackingUPH where PartNo='" + txtmodel.Text + "' and LocationID='" + cblocation.SelectedValue.ToString() + "' order by StartTime Desc) update cte set EndTime =getdate()");
        //            connect.exedata("update runingstatus set partno='' where idwarehouse='WH001' and idlocation='" + cblocation.SelectedValue + "'");
        //            connect.exedata("insert into productionhistory (idwarehouse,partno,idlocation,stoptime,remark) values ('" + wh + "','" + txtmodel.Text.ToUpper() + "','" + cblocation.SelectedValue + "',getdate(),'Stop working day')");
        //            connect.exedata("update productionstatus set stoptime=getdate(),lastesttarget='0' where idlocation='" + cblocation.SelectedValue + "' and partno='" + txtmodel.Text.ToUpper() + "'and productiondate=convert(date,getdate())");
        //            txttarget.Text = "0";
        //            txtboxno.Text = "";
        //            txtqty.Text = "0";
        //            txtactualqty.Text = "0";

        //        }
        //        else if (dlr == DialogResult.No)
        //        {
        //            connect.exedata("with cte as (select top 1 EndTime from TrackingUPH where PartNo='" + txtmodel.Text + "' and LocationID='" + cblocation.SelectedValue.ToString() + "' order by StartTime Desc) update cte set EndTime =getdate()");
        //            connect.exedata("insert into productionhistory (idwarehouse,partno,idlocation,stoptime,remark) values ('" + wh + "','" + txtpartno.Text + "','" + cblocation.SelectedValue + "',getdate(),'Break time')");
        //            connect.exedata("update productionstatus set stoptime=getdate(),lastesttarget='" + txttarget.Text + "' where idlocation='" + cblocation.SelectedValue + "' and partno='" + txtmodel.Text.ToUpper() + "' and productiondate=convert(date,getdate())");
        //        }
        //        else
        //        {
        //            btnpower.Text = "CONTINUE";
        //            txtmodel.Enabled = false;
        //            checkStatus = true;
        //        }
        //    }

        //}
        #endregion


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
                    //DataTable dtpack = connect.readdata("select quantity from packingstandard where partno ='" + txtmodel.Text.ToUpper() + "' and idpacking='" + txtboxno.Text.Substring(0, 3) + "' ");

                    txtboxno.Enabled = false;
                    if (Convert.ToInt32(txtactualqty.Text) == Convert.ToInt32(package_capa))
                    {
                        DialogResult dlr;
                        dlr = MessageBox.Show("Box đã đầy ,Xin hãy kết thúc quá trình đóng gói", "Notice", MessageBoxButtons.OK);
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmprod_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (toggleState == true)
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
        private void button1_Click(object sender, EventArgs e)
        {
            //using (SelectWorkOrder frm = new SelectWorkOrder())
            //{
            //    DataTable dtLocation = connect.readdata("select namelocation1 from location where idlocation ='" + cblocation.SelectedValue + "'");
            //    SelectWorkOrder fr = new SelectWorkOrder();
            //    fr.lbline.Text = dtLocation.Rows[0]["namelocation1"].ToString();
            //    fr.dataGridView1.AutoGenerateColumns = false;
            //    fr.lineID = cblocation.SelectedValue.ToString();
            //    fr.ShowInTaskbar = false;
            //    fr.ShowDialog();
            //    txtworkorder.Text = fr.SendData();
            //    txtmodel.Text = fr.sendDataModel();
            //    UserSession.PartNo_Packing = fr.sendDataModel();
            //    txtPlanID.Text = fr.SendPlanID();
            //    plan = Convert.ToInt32(fr.SendPlan());
            //    if (!packageController.CheckChangePackingMethod(txtmodel.Text))
            //    {
            //        checkBox2.Enabled = false;
            //    }
            //    else
            //    {
            //        checkBox2.Enabled = true;
            //    }
            //    DataTable dtsumqty = connect.readdata("select isnull(sum(qty),0) as pro from productionhistory where partno='" + txtmodel.Text.ToUpper() + "' and idlocation='" + cblocation.SelectedValue + "' and convert(date,productiontime)=convert(date,getdate())");
            //    try
            //    {
            //        txtproductionqty.Text = dtsumqty.Rows[0]["pro"].ToString();
            //    }
            //    catch
            //    {
            //        txtproductionqty.Text = "0";
            //    }
            //    toggleButton1.Enabled = true;
            //    txtplan.Text = plan.ToString();
            //    txtboxno.Text = "";
            //    txtqty.Text = "0";
            //    txtactualqty.Text = "0";
            //    txtboxno.Enabled = true; ;
            //}
            using (GetPlan frm = new GetPlan())
            {
                DataTable dtLocation = connect.readdata("select namelocation1 from location where idlocation ='" + cblocation.SelectedValue + "'");
                frm.lbline.Text = dtLocation.Rows[0]["namelocation1"].ToString();
                frm.dataGridView1.AutoGenerateColumns = false;
                frm.lineID = cblocation.SelectedValue.ToString();
                frm.ShowInTaskbar = false;
                frm.ShowDialog();
                txtworkorder.Text = frm.SendData();
                txtmodel.Text = frm.sendDataModel();
                UserSession.PartNo_Packing = frm.sendDataModel();
                txtPlanID.Text = frm.SendPlanID();
                plan = Convert.ToDouble(frm.SendPlan());
                if (!packageController.CheckChangePackingMethod(txtmodel.Text))
                {
                    checkBox2.Enabled = false;
                }
                else
                {
                    checkBox2.Enabled = true;
                }
                DataTable dtsumqty = connect.readdata("select isnull(sum(qty),0) as pro from productionhistory where partno='" + txtmodel.Text.ToUpper() + "' and idlocation='" + cblocation.SelectedValue + "' and convert(date,productiontime)=convert(date,getdate())");
                try
                {
                    txtproductionqty.Text = dtsumqty.Rows[0]["pro"].ToString();
                }
                catch
                {
                    txtproductionqty.Text = "0";
                }
                curr_plan_result = 0;
                toggleButton1.Enabled = true;
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

        private async void btnPacking_renew_Click(object sender, EventArgs e)
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
                            await dAO_ProductionHistory.Create(wh, txtmodel.Text, txtsoluong.Text, cblocation.SelectedValue.ToString(), txtboxno.Text, txtworkorder.Text, txtPlanID.Text);
                            //connect.exedata("insert into productionhistory (idwarehouse,partno,productiontime,qty,idlocation,idpack,WO,PlanID) values('" + wh + "','" + txtmodel.Text + "',GETDATE(),'" + txtsoluong.Text + "','" + cblocation.SelectedValue + "','" + txtboxno.Text + "','" + txtworkorder.Text + "','" + txtPlanID.Text + "')");
                            //connect.exedata("insert into productionhistory (idwarehouse,partno,productiontime,qty,idlocation,idpack) values('" + cbwarehouse.SelectedValue + "','" + txtmodel.Text.ToUpper() + "',getdate(),'" + txtsoluong.Text + "','" + cblocation.SelectedValue + "','" + txtboxno.Text + "')");
                            if (await dAO_PackingInfo.CheckExisted(txtboxno.Text))
                            {
                                connect.exedata("update packinginfo set quantity =quantity + '" + txtsoluong.Text + "' where idpack ='" + txtboxno.Text + "'");
                            }
                            else
                            {
                                connect.exedata("insert into packinginfo (idpack,partno,quantity,packingdate,idlocation,idwarehouse) values('" + txtboxno.Text + "','" + txtmodel.Text.ToUpper() + "','" + txtsoluong.Text + "',getdate(),'" + cblocation.SelectedValue + "','" + wh + "') ");
                            }
                            await dAO_Production.UpdateProductionResult(_mapping_Line.factoryCode, _mapping_Line.factoryID, _mapping_Line.machineCode, _mapping_Line.machineID, txtmodel.Text, txtsoluong.Text, txtboxno.Text, txtPlanID.Text, txtworkorder.Text);
                            txtboxno.Text = "";
                            txtsoluong.Text = "";
                            txtboxno.Enabled = true;
                            txtboxno.Focus();
                            DataTable dtsumqty = connect.readdata("select sum(qty) as pro from productionhistory where partno='" + txtmodel.Text.ToUpper() + "' and idlocation='" + cblocation.SelectedValue + "' and convert(date,productiontime)=convert(date,getdate())");
                            txtproductionqty.Text = dtsumqty.Rows[0]["pro"].ToString();
                            await UpdateWO();
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

        private async Task ErrorLog(string filePath, string message)
        {
            try
            {
                // Check if the file exists.
                if (!File.Exists(filePath))
                {
                    // If the file doesn't exist, create it.
                    using (FileStream fs = File.Create(filePath))
                    {
                        // Optionally, you can add an initial message or header to the file.
                        byte[] initialMessage = new UTF8Encoding(true).GetBytes("Log File Created\n");
                        await fs.WriteAsync(initialMessage, 0, initialMessage.Length);
                    }
                }

                // Open the file in append mode and write the message.
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    string logLine = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}: {message}";
                    await writer.WriteLineAsync(logLine);
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during file operations (e.g., file permissions issues).
                MessageBox.Show($"Error while writing to file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int _WOQuantityAvailable;
        private async void UpdateData(string idpack, string partno)
        {

            try
            {
                if (await dAO_PackingInfo.CheckExisted(idpack))
                {
                    //existed package
                    await connect.ExeDataAsync("exec spUpdatePackingInfo_Increase @idpack='" + idpack + "'");
                }
                else
                {
                    //new package
                    await connect.ExeDataAsync("exec spInsertPackingInfo @idpack='" + idpack + "',@partno='" + partno + "',@idlocation='" + cblocation.SelectedValue.ToString() + "',@idwarehouse='" + wh + "'");
                }
                //bravo import
                await dAO_Production.UpdateProductionResult(_mapping_Line.factoryCode, _mapping_Line.factoryID, _mapping_Line.machineCode, _mapping_Line.machineID, txtmodel.Text, "1", txtboxno.Text, txtPlanID.Text, txtworkorder.Text);
                string cmd = "insert into productionhistory (idwarehouse,partno,productiontime,remark,qty,idlocation,idpack,WO,PlanID) values('" + wh + "','" + txtmodel.Text + "',GETDATE(),'',1,'" + cblocation.SelectedValue + "','" + txtboxno.Text + "','" + txtworkorder.Text + "','" + txtPlanID.Text + "')";
                await connect.ExeDataAsync(cmd);
                //txtactualqty.Text = (Convert.ToInt32(txtactualqty.Text) + 1).ToString();
                txtactualqty.Text = await dAO_PackingInfo.GetPackageQty(txtboxno.Text);
                // txtproductionqty.Text = (Convert.ToInt32(txtproductionqty.Text) + 1).ToString();
                txtproductionqty.Text = await dAO_ProductionHistory.GetProductOutput(txtmodel.Text, cblocation.SelectedValue.ToString());
               
                string tmp;
                tmp = await dAO_ProductionHistory.GetProductOutputByID(txtmodel.Text, cblocation.SelectedValue.ToString(), txtPlanID.Text);
                curr_plan_result = Convert.ToDouble(tmp);
            }
            catch (Exception ex)
            {
                await ErrorLog("errlog.txt", ex.Message);
                MessageBox.Show(ex.Message); 
            }
        }
        private async Task UpdateWO()
        {
            //string wo_finished_qty = await dAO_Production.GetFinishedWorkOrder(txtmodel.Text, cblocation.SelectedValue.ToString());
            //_WOQuantityAvailable = Convert.ToInt32(txtproductionqty.Text) - Convert.ToInt32(wo_finished_qty);
            //txtWOQuantityAvailable.Text = _WOQuantityAvailable.ToString();
            string inv = await dAO_AssemblyFGsWarehouse.GetInventory(txtmodel.Text, cblocation.SelectedValue.ToString());
            _WOQuantityAvailable = Convert.ToInt32(inv);
            txtWOQuantityAvailable.Text= inv;
        }
        private async void txtpartno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!string.IsNullOrEmpty(txtpartno.Text))
                {

                    if (toggleState == false)
                    {
                        MessageBox.Show("Chuyển trạng thái chuyền trước khi scan");
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
                                if (curr_plan_result<plan /*Convert.ToInt32(txtproductionqty.Text) < plan*/)
                                {
                                    if (txtboxno.Text == "")
                                    {
                                        MessageBox.Show("XIN HÃY NHẬP MÃ ĐÓNG GÓI TRƯỚC TIÊN !!!");
                                        txtpartno.Text = "";
                                    }
                                    else
                                    {
                                        #region
                                        if (pushnotifytype == "2")
                                        {
                                            CallOK();
                                        }
                                        //txtproductionqty.Text = (Convert.ToInt32(txtproductionqty.Text) + 1).ToString();
                                        //quanli packing
                                        //if (connect.countdata("select count(idpack) from packinginfo where idpack='" + txtboxno.Text + "'") == 0)
                                        //{
                                        //    //err2
                                        //    try
                                        //    {
                                        //        await connect.ExeDataAsync("exec spInsertPackingInfo @idpack='" + txtboxno.Text + "',@partno='" + txtmodel.Text.ToUpper() + "',@idlocation='" + cblocation.SelectedValue.ToString() + "',@idwarehouse='" + wh + "'");

                                        //    }
                                        //    catch (Exception ex)
                                        //    {
                                        //        MessageBox.Show("err2 :" + ex.Message);
                                        //    }
                                        //}
                                        //else
                                        //{
                                        //    //err4
                                        //    try
                                        //    {
                                        //        await connect.ExeDataAsync("exec spUpdatePackingInfo_Increase @idpack='" + txtboxno.Text + "'");
                                        //    }
                                        //    catch (Exception ex)
                                        //    {
                                        //        MessageBox.Show("err4 :" + ex.Message);
                                        //    }
                                        //}
                                        ////err3
                                        //try
                                        //{
                                        //    await connect.ExeDataAsync("insert into productionhistory (idwarehouse,partno,productiontime,remark,qty,idlocation,idpack,WO,PlanID) values('" + wh + "','" + txtmodel.Text + "',GETDATE(),'',1,'" + cblocation.SelectedValue + "','" + txtboxno.Text + "','" + txtworkorder.Text + "','" + txtPlanID.Text + "')");

                                        //}
                                        //catch (Exception ex)
                                        //{
                                        //    MessageBox.Show("err3 :" + ex.Message);
                                        //}
                                        ////err1
                                        //try
                                        //{
                                        //    txtactualqty.Text = (Convert.ToInt32(txtactualqty.Text) + 1).ToString();
                                        //}
                                        //catch (Exception ex)
                                        //{
                                        //    MessageBox.Show("err1 :" + ex.Message);
                                        //}
                                        UpdateData(txtboxno.Text, txtmodel.Text);
                                        await UpdateWO();
                                        txtpartno.Text = "";
                                        #endregion

                                    }
                                }
                                else
                                {
                                    using (Notify frm = new Notify())
                                    {
                                        frm.content = "Kế hoạch đã hoàn thành ";
                                        frm.ShowDialog();
                                    }
                                    txtpartno.Text = "";
                                }
                            }
                        }
                        else
                        {
                            using (Notify frm = new Notify())
                            {
                                //save to stopalertcounter (table)--update 11/11/2022
                                try
                                {
                                    string remark = "Mã hàng không hợp lệ " + txtpartno.Text;
                                    await connect.ExeDataAsync("Insert into StopAlertCounter(SubmitDate,PartNo,Remark,LocationID) values(getdate(),'" + txtmodel.Text + "','" + remark + "','" + cblocation.SelectedValue.ToString() + "')"); ;
                                }
                                catch { }
                                CallNG();
                                frm.content = "Label : " + txtpartno.Text + " không hợp lệ.Xin hãy kiểm tra lại !!!";
                                frm.ShowDialog();
                            }
                            txtpartno.Text = "";
                        }
                    }
                }


            }
            //Thread.Sleep(300);
        }
        List<string> inspectLineLinked = new List<string>()
        {
            "L11"
        };
        async Task SetActiveItem(string code,string lineId)
        {
            if(inspectLineLinked.Contains(lineId))
            {
                await connect.ExeDataAsync("update LineInspection set Status =0 where  LineID='" + lineId + "'");
                await connect.ExeDataAsync("update LineInspection set Status =1 where PartNo ='" + code + "' and LineID='" + lineId + "'");
            }  
        }
        private async void toggleButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (toggleButton1.Checked == false)
            {
                toggleState = false;
                HANMISYSTEM.Properties.Settings.Default.status = "Stop line";
                connect.exedata("update runingstatus set status='Stop line' where idwarehouse='" + wh + "' and idlocation ='" + cblocation.SelectedValue + "'");
                Properties.Settings.Default.Save();
                //txtmodel.Enabled = true;
                btnPacking_renew.Enabled = false;
                cblocation.Enabled = true;
                DialogResult dlr;
                checkStatus = false;
                button1.Enabled = true;
                dlr = CustomMsgBox.Show("Tại sao bạn lại muốn dừng lại ", "Thông báo", "Kết thúc ngày làm việc", "Nghỉ giải lao", "Hủy");
                if (dlr == DialogResult.Yes)
                {
                    connect.exedata("with cte as (select top 1 EndTime from TrackingUPH where PartNo='" + txtmodel.Text + "' and LocationID='" + cblocation.SelectedValue.ToString() + "' order by StartTime Desc) update cte set EndTime =getdate()");
                    connect.exedata("update runingstatus set partno='' where idwarehouse='WH001' and idlocation='" + cblocation.SelectedValue + "'");
                    connect.exedata("insert into productionhistory (idwarehouse,partno,idlocation,stoptime,remark) values ('" + wh + "','" + txtmodel.Text.ToUpper() + "','" + cblocation.SelectedValue + "',getdate(),'Stop working day')");
                    connect.exedata("update productionstatus set stoptime=getdate(),lastesttarget='0' where idlocation='" + cblocation.SelectedValue + "' and partno='" + txtmodel.Text.ToUpper() + "'and productiondate=convert(date,getdate())");
                    txttarget.Text = "0";
                    txtboxno.Text = "";
                    txtqty.Text = "0";
                    txtactualqty.Text = "0";

                }
                else if (dlr == DialogResult.No)
                {
                    connect.exedata("with cte as (select top 1 EndTime from TrackingUPH where PartNo='" + txtmodel.Text + "' and LocationID='" + cblocation.SelectedValue.ToString() + "' order by StartTime Desc) update cte set EndTime =getdate()");
                    connect.exedata("insert into productionhistory (idwarehouse,partno,idlocation,stoptime,remark) values ('" + wh + "','" + txtpartno.Text + "','" + cblocation.SelectedValue + "',getdate(),'Break time')");
                    connect.exedata("update productionstatus set stoptime=getdate(),lastesttarget='" + txttarget.Text + "' where idlocation='" + cblocation.SelectedValue + "' and partno='" + txtmodel.Text.ToUpper() + "' and productiondate=convert(date,getdate())");
                }
                else
                {
                    toggleState = true;
                    txtmodel.Enabled = false;
                    checkStatus = true;
                }
            }
            else
            {

                //DataTable dtplan = connect.readdata("select productionplan from productionplan where partno='" + txtmodel.Text + "' and idlocation='" + cblocation.SelectedValue.ToString() + "' and idwarehouse='" + wh + "' and productiondate= CONVERT(date, GETDATE()) ");
                //if (dtplan.Rows.Count > 0)
                //{

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
                //change partlist monitor
                await SetActiveItem(txtmodel.Text,cblocation.SelectedValue.ToString());
                connect.exedata("exec spInsertTrackingUPH @partno='" + txtmodel.Text + "' ,@locationid='" + cblocation.SelectedValue.ToString() + "',@remark=''");
                //plan = Convert.ToInt32(dtplan.Rows[0]["productionplan"].ToString());
                txtpartno.Focus();
                btnPacking_renew.Enabled = true;
                Properties.Settings.Default.Save();
                txtmodel.Enabled = false;
                cblocation.Enabled = false;
                checkStatus = true;
                toggleState = true;
                button1.Enabled = false;
                await UpdateWO();
                //timer1.Start();
                //}
                //else
                //{
                //    MessageBox.Show("Chưa có kế hoạch cho mã : " + txtmodel.Text + " ngày " + DateTime.Now.ToString("yyyy-MM-dd") + "");
                //    toggleState = false;
                //    toggleButton1.Checked = false;
                //}
            }


        }

        private void btnLabelChecking_Click(object sender, EventArgs e)
        {
            if (UserSession.UserName.ToUpper() == "KVLINE" && !string.IsNullOrEmpty(txtmodel.Text))
            {
                CheckMaterials frm = new CheckMaterials();
                frm.ShowInTaskbar = false;
                frm.WindowState = FormWindowState.Maximized;
                frm.partno = txtmodel.Text;
                frm.lineID = cblocation.SelectedValue.ToString();
                frm.ShowDialog();
            }
        }

        private async void txtproductionqty_TextChanged(object sender, EventArgs e)
        {
            await UpdateWO();
        }
        private class PrintSpecs
        {
            string partno { get; set; }
            string qty { get; set; }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int startX = 30;
            int startY = 15;
            int line = 30;
            int fontSize = 11;
            string font = "Times New Roman";
            string barcodeText = "AGG76839197";
            BarcodeWriter barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_39, // Select the barcode format (e.g., Code 128)
                Options = new ZXing.Common.EncodingOptions
                {
                    
                    Height = 45, // Height of the barcode
                    Width = 390 ,  // Width of the barcode
                    PureBarcode = true
                }
            };
            Bitmap barcodeImage = barcodeWriter.Write(barcodeText);
            Graphics g = e.Graphics;
            GraphicsState state = g.Save();
            g.TranslateTransform(startX, startY);
            g.RotateTransform(90);
         
            Pen pen = new Pen(Color.Black, 2); // Pen with color and width
            int lineStartX = startX;
            int lineEndX = startX + 350; // Length of the line
            int lineY = startY + 30; // Line position (a bit below the text)
            g.DrawString("Line", new Font(font, fontSize, FontStyle.Bold), Brushes.Black, new Point(startX+20, startY-360));
            g.DrawString("VH_VC", new Font(font, fontSize, FontStyle.Bold), Brushes.Black, new Point(startX+140, startY-360));
            g.DrawString("Supplier", new Font(font, fontSize, FontStyle.Bold), Brushes.Black, new Point(startX+260, startY-360));
            g.DrawString("Hanmi Flexible", new Font(font, fontSize, FontStyle.Bold), Brushes.Black, new Point(startX+380, startY- 360));

            //line 2
            g.DrawString("Q.ty", new Font(font, fontSize, FontStyle.Bold), Brushes.Black, new Point(startX + 40, startY - 330));
            g.DrawString("Part No", new Font(font, fontSize, FontStyle.Bold), Brushes.Black, new Point(startX + 160, startY - 330));
            g.DrawString("Part Name", new Font(font, fontSize, FontStyle.Bold), Brushes.Black, new Point(startX + 330, startY - 330));

            //line3
            g.DrawString("AGG76839197", new Font(font, fontSize, FontStyle.Bold), Brushes.Black, new Point(startX + 140, startY - 290));
            g.DrawString("Packing Assembly", new Font(font, fontSize, FontStyle.Bold), Brushes.Black, new Point(startX + 320, startY - 290));

            //line 4
            g.DrawString("45", new Font(font, fontSize, FontStyle.Bold), Brushes.Black, new Point(startX + 40, startY -200));

            //line 5
            g.DrawString($"Production Date: {DateTime.Now.ToString("dd")}/{DateTime.Now.ToString("MM")}/{DateTime.Now.ToString("yyyy")}", new Font(font, fontSize, FontStyle.Bold), Brushes.Black, new Point(startX + 20, startY - 40));
            g.DrawString("Delivery Time", new Font(font, fontSize, FontStyle.Bold), Brushes.Black, new Point(startX + 300, startY - 40));
            g.DrawString("RoHS", new Font(font, fontSize, FontStyle.Bold), Brushes.Black, new Point(startX + 430, startY - 40));

            g.DrawImage(barcodeImage, new Point(startX+110, startY-240));
            g.Restore(state);
            g.DrawLine(pen, lineStartX, lineY, lineEndX, lineY);
            g.DrawLine(pen, lineStartX+line, lineY+130, lineEndX, lineY+130);
            g.DrawLine(pen, lineStartX+240, lineY+260, lineEndX, lineY+260);
           // g.DrawLine(pen, lineStartX, lineY+280, lineEndX, lineY+280);
            g.DrawLine(pen, lineStartX+320, lineY+ 360, lineEndX, lineY+360);
            g.DrawLine(pen, lineStartX, lineY+500, lineEndX, lineY+500);
            g.DrawLine(pen, lineStartX, lineY, lineStartX, lineY+500);


            g.DrawLine(pen, lineStartX+ line, lineY, lineStartX+ line, lineY+500);
            g.DrawLine(pen, lineStartX+ 100, lineY+130, lineStartX+ 100, lineY+500);
            g.DrawLine(pen, lineStartX+ 165, lineY+130, lineStartX+ 165, lineY+500);
            g.DrawLine(pen, lineStartX+ 240, lineY+130, lineStartX+ 240, lineY+500);
            g.DrawLine(pen, lineStartX + 350 -line*2, lineY, lineStartX + 350 - line * 2, lineY + 500) ;
            g.DrawLine(pen, lineStartX+ 350-line, lineY, lineStartX+ 350-line, lineY+500);
            g.DrawLine(pen, lineStartX+350, lineY, lineStartX+350, lineY+500);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
     
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        static bool IsPositiveInteger(string input)
        {
            // Kiểm tra chuỗi có phải là số và lớn hơn 0
            if (int.TryParse(input, out int number))
            {
                return number > 0;
            }
            return false;
        }
        private async void btnCreateWO_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtmodel.Text))
            {
                DialogResult result = MessageBox.Show(
           "Xác nhận tạo WO",
           "Confirmation",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question
       );
                if (result == DialogResult.Yes)
                {
                    //await DAO_SystemLog.Add("notify", $"{txtWOQuantityAvailable.Text},{_WOQuantityAvailable.ToString()}");
                    if (!IsPositiveInteger(txtWOQuantityAvailable.Text) || Convert.ToInt32(txtWOQuantityAvailable.Text) > _WOQuantityAvailable)
                    {
                        MessageBox.Show($"Số nhập vào không hợp lệ:(available:{_WOQuantityAvailable})");
                    }
                    else
                    {

                        await dAO_Production.SubmitWorkOrder(_mapping_Line.factoryCode, _mapping_Line.factoryID, _mapping_Line.machineCode, _mapping_Line.machineID, txtmodel.Text, txtWOQuantityAvailable.Text, txtboxno.Text, txtPlanID.Text, txtworkorder.Text, _workprocesscode, _warehouseId);
                        Task.Delay(200).Wait();
                        await dAO_Production.CreateBravoWorkOrder(txtWOQuantityAvailable.Text, cblocation.SelectedValue.ToString(), txtmodel.Text);
                        await UpdateWO();
                        //dataGridView1.Rows.Insert(0, dataGridView1.Rows.Count.ToString(),);
                    }
                }
                if (checkBox2.Checked)
                {
                    txtboxno.Focus();
                }
                else
                {
                    txtpartno.Focus();
                }
            }
           
               
        }

        private async void btnCheckWO_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await dAO_Production.GetBravoWorkOrder(cblocation.SelectedValue.ToString(), txtmodel.Text);
            double sum = GetColumnSum(dataGridView1, "Quantity_col");
            txtTotalWO.Text = sum.ToString("N0");
        }
        private double GetColumnSum(DataGridView dgv, string columnName)
        {
            double sum = 0;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[columnName].Value != null &&
                    double.TryParse(row.Cells[columnName].Value.ToString(), out double value))
                {
                    sum += value;
                }
            }

            return sum;
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await UpdateWO();
        }
    }
}
