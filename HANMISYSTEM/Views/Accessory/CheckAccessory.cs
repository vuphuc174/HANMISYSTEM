using HANMISYSTEM.Common;
using HANMISYSTEM.Module;
using HANMISYSTEM.Views.PartialView;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.Accessory
{
    public partial class CheckAccessory : Form
    {
        public CheckAccessory()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        const string warehouse = "WH001";
        string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        List<packingdata> packingdatas;
        List<GroupBox> accessoryGroup = new List<GroupBox>();
        List<Label> lbJudge = new List<Label>();
        List<Label> lbAccessory = new List<Label>();
        Thread t;
        bool varcheck;
        string lineID;
        private void btnon_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtPlan.Text) <= 0)
            {
                MessageBox.Show("Chưa có kế hoặch sản xuất");
            }
            else
            {
                //kiem tra giai doan truoc da có endtime hay chưa
                DataTable dtendtime = connect.readdata("select top 1 EndTime  from TrackingUPH where LocationID='" + lineID + "' and  CONVERT(date,StartTime)=convert(date,getdate()) order by StartTime desc");
                if (dtendtime.Rows.Count > 0)
                {
                    if (string.IsNullOrEmpty(dtendtime.Rows[0]["EndTime"].ToString()))
                    {
                        //them endtime
                        connect.exedata("with cte as (select top 1 *  from TrackingUPH where LocationID = '" + lineID + "' and  CONVERT(date, StartTime) = CONVERT(date, getdate()) order by StartTime desc) update cte set EndTime = GETDATE(),Remark='EndTime added by system'");
                    }
                }

                btnon.BackColor = Color.Lime;
                btnoff.BackColor = SystemColors.Control;
                connect.exedata("exec spInsertTrackingUPH @partno='" + txtmodel.Text + "' ,@locationid='" + lineID + "',@remark=''");
                btnon.Enabled = false;
                btnoff.Enabled = true;
                btnselectWO.Enabled = false;
                txtScan.Enabled = true;
                txtScan.Focus();
            }
        }
        private void checkTask()
        {
            while (varcheck == true)
            {
                if (packingdatas != null)
                {
                    //if (lbTask.InvokeRequired)
                    //{
                    try
                    {
                        lbTask.Invoke(new MethodInvoker(delegate
                        {
                            this.lbTask.Text = packingdatas.Count().ToString();
                            //this.Dispose();
                        }));
                        if (packingdatas.Count() > 0)
                        {
                            doJob();
                        }
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message);
                    }

                    //}
                }




            }

        }
        private void doJob()
        {
            while (packingdatas.Count > 0)
            {
                for (int i = 0; i < packingdatas.Count; i++)
                {
                    //save database
                    //quanli packing
                    if (connect.countdata("select count(idpack) from packinginfo where idpack='" + packingdatas[i].PackageID + "'") == 0)
                    {
                        connect.exedata("exec spInsertPackingInfo @idpack='" + packingdatas[i].PackageID + "',@partno='" + packingdatas[i].PartNo + "',@idlocation='" + packingdatas[i].LocationID + "',@idwarehouse='WH001'");
                    }
                    else
                    {
                        connect.exedata("exec spUpdatePackingInfo_Increase @idpack='" + packingdatas[i].PackageID + "'");
                    }
                    //DataTable qtypack = connect.readdata("select quantity from packinginfo where idpack='" + txtPackID.Text + "'");
                    //lbCurrentQtyPack.Text = qtypack.Rows[0]["quantity"].ToString();
                    //them lich su
                    connect.exedata("insert into productionhistory (idwarehouse,partno,productiontime,qty,idlocation,idpack) values('WH001','" + packingdatas[i].PartNo + "',getdate(),1,'" + packingdatas[i].LocationID + "','" + packingdatas[i].PackageID + "')");
                    //DataTable dtsumqty = connect.readdata("select sum(qty) as pro from productionhistory where partno='" + packingdatas[i].PartNo + "' and idlocation='" + cbbLocation.SelectedValue.ToString() + "' and convert(date,productiontime)=convert(date,getdate())");
                    //lbProductivity.Text = dtsumqty.Rows[0]["pro"].ToString();
                    packingdatas.RemoveAt(0);
                    string json = JsonConvert.SerializeObject(packingdatas.ToArray(), Formatting.Indented);
                    File.WriteAllText(path + "\\json\\packingdata.json", json);
                }
                Thread.Sleep(200);
            }
        }
        private void CheckAccessory_Load(object sender, EventArgs e)
        {
            varcheck = true;
            DataTable dt2;
            DataTable dt3 = connect.readdata("select * from tbl_user where username='" + HANMISYSTEM.Properties.Settings.Default.username + "'");
            if (dt3.Rows[0]["location"].ToString() == "all")
            {
                lineID = "L1";
            }
            else
            {
                lineID = dt3.Rows[0]["location"].ToString();

            }
            dt2 = connect.readdata("select * from location where idwarehouse='WH001' and idlocation='" + lineID + "'");
            if (dt2 != null)
            {
                try
                {
                    lbLine.Text = dt2.Rows[0]["namelocation1"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection faile", ex.ToString());
                }
            }
            accessoryGroup.Add(gb1);
            accessoryGroup.Add(gb2);
            accessoryGroup.Add(gb3);
            accessoryGroup.Add(gb4);
            accessoryGroup.Add(gb5);
            accessoryGroup.Add(gb6);
            accessoryGroup.Add(gb7);
            accessoryGroup.Add(gb8);
            accessoryGroup.Add(gb9);
            accessoryGroup.Add(gb10);
            accessoryGroup.Add(gb11);
            accessoryGroup.Add(gb12);

            lbJudge.Add(lbJudge1);
            lbJudge.Add(lbJudge2);
            lbJudge.Add(lbJudge3);
            lbJudge.Add(lbJudge4);
            lbJudge.Add(lbJudge5);
            lbJudge.Add(lbJudge6);
            lbJudge.Add(lbJudge7);
            lbJudge.Add(lbJudge8);
            lbJudge.Add(lbJudge9);
            lbJudge.Add(lbJudge10);
            lbJudge.Add(lbJudge11);
            lbJudge.Add(lbJudge12);

            lbAccessory.Add(lbAccessory1);
            lbAccessory.Add(lbAccessory2);
            lbAccessory.Add(lbAccessory3);
            lbAccessory.Add(lbAccessory4);
            lbAccessory.Add(lbAccessory5);
            lbAccessory.Add(lbAccessory6);
            lbAccessory.Add(lbAccessory7);
            lbAccessory.Add(lbAccessory8);
            lbAccessory.Add(lbAccessory9);
            lbAccessory.Add(lbAccessory10);
            lbAccessory.Add(lbAccessory11);
            lbAccessory.Add(lbAccessory12);
            if (!Directory.Exists(path + "\\json"))
            {
                Directory.CreateDirectory(path + "\\json");
                using (StreamWriter sw = File.CreateText(path + "\\json\\packingdata.json"))
                {
                    sw.WriteLine("[]");
                }
                //File.Create(path + "\\json\\packingdata.json");
            }
            if (File.Exists((path + "\\json\\packingdata.json")))
            {
                using (StreamReader file = File.OpenText(path + "\\json\\packingdata.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    packingdatas = (List<packingdata>)serializer.Deserialize(file, typeof(List<packingdata>));
                }
            }

            // Control.CheckForIllegalCrossThreadCalls = false;
            t = new Thread(checkTask);
            t.IsBackground = true;
            t.Start();

            HideAll();
        }
        string offType;
        private void btnoff_Click(object sender, EventArgs e)
        {
            DialogResult dlr;
            dlr = CustomMsgBox.Show("Tại sao bạn lại muốn dừng lại ", "Thông báo", "Kết thúc ngày làm việc", "Nghỉ giải lao", "Hủy");
            if (dlr == DialogResult.Yes)
            {

                connect.exedata("with cte as (select top 1 EndTime from TrackingUPH where PartNo='" + txtmodel.Text + "' and LocationID='" + lineID + "' order by StartTime Desc) update cte set EndTime =getdate()");
                btnoff.BackColor = Color.Lime;
                btnon.BackColor = SystemColors.Control;
                btnon.Enabled = true;
                btnoff.Enabled = false;
                txtScan.Enabled = false;
                offType = "";
            }
            if (dlr == DialogResult.No)
            {
                connect.exedata("with cte as (select top 1 EndTime from TrackingUPH where PartNo='" + txtmodel.Text + "' and LocationID='" + lineID + "' order by StartTime Desc) update cte set EndTime =getdate()");
                offType = "Break";
                btnoff.BackColor = Color.Lime;
                btnon.BackColor = SystemColors.Control;
                btnon.Enabled = true;
                btnoff.Enabled = false;
                txtScan.Enabled = false;
            }
        }
        SerialPort serialPort = new SerialPort(HANMISYSTEM.Properties.Settings.Default.comport, Convert.ToInt32(HANMISYSTEM.Properties.Settings.Default.baudrate));
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


                var chanel1 = new byte[] { 0x55, 0x56, 0x00, 0x00, 0x00, 0x01, 0x01, 0xAD };
                serialPort.Write(chanel1, 0, chanel1.Length);
                serialPort.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }
        private async void DoCheckAccessory(string data)
        {
            if (Judge(data))
            {
                if (CheckJudgeStatus())
                {

                    lbQuantity.Text = (Convert.ToInt32(lbQuantity.Text) + 1).ToString();
                    lbFinalJudge.Text = "OK";
                    lbFinalJudge.ForeColor = Color.Lime;
                    dataGridView1.Rows.Insert(0, dataGridView1.Rows.Count, txtmodel.Text, "OK", DateTime.Now);
                    Task.Delay(200).Wait();
                    packingdatas.Add(new packingdata()
                    {
                        PackageID = lbPackageID.Text,
                        PartNo = txtmodel.Text,
                        PackingTime = DateTime.Now.ToString(),
                        LocationID = lineID
                    });
                    string json = JsonConvert.SerializeObject(packingdatas.ToArray(), Formatting.Indented);
                    File.WriteAllText(path + "\\json\\packingdata.json", json);

                    lbPackageQuantity.Text = (Convert.ToInt32(lbPackageQuantity.Text) + 1).ToString();
                    await Task.Run(() => ClearJudge());
                }
                //txtScan.Text = "";
            }
            else
            {
                //if (CheckJudgeExisted())
                //{
                lbFinalJudge.Text = "NG";
                lbFinalJudge.ForeColor = Color.Red;
                dataGridView1.Rows.Insert(0, dataGridView1.Rows.Count, txtmodel.Text, "NG", DateTime.Now);
                //notify box
                using (Notify frm = new Notify())
                {
                    frm.content = data;
                    frm.ShowDialog();
                }
                await Task.Run(() => ClearJudge());
                //}


            }
        }
        private void CheckPackageChange(string data)
        {

            //lbPackageID.Text = data;
            DataTable packqty = connect.readdata("select partno,quantity from packinginfo where idpack='" + data + "'");
            DataTable dt = connect.readdata("select * from packingstandard where partno='" + txtmodel.Text + "' and idpacking like '" + data.Substring(0, 3) + "'");
            //check phuong thuc dong goi
            if (dt.Rows.Count == 0 || dt.Rows[0]["quantity"].ToString() == "0")
            {
                MessageBox.Show("Phương thức đóng gói không hợp lệ !");
                //txtPackID.Text = "";
            }
            else
            {
                //package da ton tai
                if (packqty.Rows.Count != 0)
                {
                    //check partno -if other
                    if (packqty.Rows[0]["partno"].ToString() != txtmodel.Text)
                    {
                        MessageBox.Show("Box này đã được sử dụng cho mã hàng khác !");
                        //txtPackID.Text = "";
                        //txtPackID.Focus();
                    }
                    else
                    {
                        if (Convert.ToInt32(packqty.Rows[0]["quantity"].ToString()) >= Convert.ToInt32(dt.Rows[0]["quantity"].ToString()))
                        {
                            MessageBox.Show("Box fulled !");
                            //txtPackID.Text = "";
                            //txtPackID.Focus();
                        }
                        else
                        {
                            lbPackageCapa.Text = dt.Rows[0]["quantity"].ToString();
                            lbPackageQuantity.Text = packqty.Rows[0]["quantity"].ToString();
                            lbPackageID.Text = data;
                            //txtScan.Enabled = true;
                            //txtScan.Focus();
                            //txtPackID.Enabled = false;
                        }
                    }

                }
                //package moi
                else
                {
                    lbPackageCapa.Text = dt.Rows[0]["quantity"].ToString();
                    lbPackageQuantity.Text = "0";
                    lbPackageID.Text = data;
                    //txtScan.Enabled = true;
                    //txtScan.Focus();
                    //txtPackID.Enabled = false;
                }
            }

        }
        private void txtScan_KeyPress(object sender, KeyPressEventArgs e)
        {
            string data = txtScan.Text;

            if (e.KeyChar == (char)13)
            {
                if (data.Length > 0 && txtmodel.Text.Length > 0)
                {
                    if (data.Length >= 14)
                    {
                        if (data.Substring(0, 3) == "BOX" || data.Substring(0, 3) == "CRT" || data.Substring(0, 3) == "BAG" || data.Substring(0, 3) == "PAL")
                        {
                            CheckPackageChange(data);
                            txtScan.Text = "";
                        }
                        else
                        {
                            if (lbPackageID.Text != "")
                            {
                                DoCheckAccessory((txtScan.Text.Length >= 12) ? txtScan.Text.Substring(0, 12) : txtScan.Text);
                                txtScan.Text = "";
                            }
                            else
                            {
                                txtScan.Text = "";
                            }
                        }
                    }
                    else
                    {
                        if (lbPackageID.Text != "")
                        {
                            DoCheckAccessory((txtScan.Text.Length >= 12) ? txtScan.Text.Substring(0, 12) : txtScan.Text);
                            txtScan.Text = "";
                        }
                        else
                        {
                            txtScan.Text = "";
                        }
                    }
                }


            }
        }
        private bool CheckJudgeExisted()
        {
            List<Label> listJudge = new List<Label>();
            listJudge.Add(lbJudge1);
            listJudge.Add(lbJudge2);
            listJudge.Add(lbJudge3);
            listJudge.Add(lbJudge4);
            listJudge.Add(lbJudge5);

            for (int i = 0; i < listJudge.Count; i++)
            {
                if (listJudge[i].Text == "OK")
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckJudgeStatus()
        {
            for (int i = 0; i < lbAccessory.Count; i++)
            {
                if (lbAccessory[i].Text != "")
                {
                    if (lbJudge[i].Text != "OK")
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private bool Judge(string accessory)
        {
            for (int i = 0; i < lbAccessory.Count; i++)
            {
                if (lbAccessory[i].Text != "")
                {
                    if (lbAccessory[i].Text.Contains(accessory))
                    //if (accessory == lbAccessory[i].Text)
                    {
                        lbJudge[i].Text = "OK";
                        lbJudge[i].ForeColor = Color.Lime;
                        return true;
                    }
                }
            }
            return false;
        }
        private void ClearJudge()
        {
            Task.Delay(500).Wait();
            ThreadHelperClass.SetText(this, lbJudge1, "");
            ThreadHelperClass.SetText(this, lbJudge2, "");
            ThreadHelperClass.SetText(this, lbJudge3, "");
            ThreadHelperClass.SetText(this, lbJudge4, "");
            ThreadHelperClass.SetText(this, lbJudge5, "");
            ThreadHelperClass.SetText(this, lbJudge6, "");
            ThreadHelperClass.SetText(this, lbJudge7, "");
            ThreadHelperClass.SetText(this, lbJudge8, "");
            ThreadHelperClass.SetText(this, lbJudge9, "");
            ThreadHelperClass.SetText(this, lbJudge10, "");
            ThreadHelperClass.SetText(this, lbJudge11, "");
            ThreadHelperClass.SetText(this, lbJudge12, "");
            ThreadHelperClass.SetText(this, lbFinalJudge, "");
        }


        private void txtScan_Leave(object sender, EventArgs e)
        {
            txtScan.Focus();
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
                if (dataGridView1.Rows[0].Cells["judgestatus"].Value.ToString() == "OK")
                {
                    dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Lime;
                    dataGridView1.Rows[0].DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Red;
                    dataGridView1.Rows[0].DefaultCellStyle.ForeColor = Color.White;
                }
        }



        private void txtScan_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbJudge1_TextChanged(object sender, EventArgs e)
        {
            //if (CheckJudgeStatus())
            //{
            //    lbJudge.Text = "OK";
            //    lbJudge.ForeColor = Color.Lime;
            //}
            //else
            //{
            //    lbJudge.Text = "NG";
            //    lbJudge.ForeColor = Color.Lime;
            //    ClearJudge();
            //}
        }

        private void lbJudge2_TextChanged(object sender, EventArgs e)
        {
            //if (CheckJudgeStatus())
            //{
            //    lbJudge.Text = "OK";
            //    lbJudge.ForeColor = Color.Lime;
            //    ClearJudge();
            //}
            //else
            //{
            //    lbJudge.Text = "NG";
            //    lbJudge.ForeColor = Color.Lime;
            //    ClearJudge();
            //}
        }
        private void HideAll()
        {
            for (int i = 0; i < accessoryGroup.Count; i++)
            {
                accessoryGroup[i].Visible = false;
                lbAccessory[i].Text = "";


            }
        }
        private void LoadAccessory(string id)
        {
            HideAll();
            DataTable dtAccessory = connect.readdata("select Accessory from Accessory where PartNo='" + id + "'");


            if (dtAccessory.Rows.Count > 0)
            {
                for (int i = 0; i < dtAccessory.Rows.Count; i++)
                {
                    accessoryGroup[i].Visible = true;
                    lbAccessory[i].Text = dtAccessory.Rows[i]["Accessory"].ToString();
                }
            }
        }
        private void btnselectWO_Click(object sender, EventArgs e)
        {
            using (SelectWorkOrder frm = new SelectWorkOrder())
            {
                DataTable dtLocation = connect.readdata("select namelocation1 from location where idlocation ='" + lineID + "'");
                SelectWorkOrder fr = new SelectWorkOrder();
                fr.lbline.Text = dtLocation.Rows[0]["namelocation1"].ToString();
                fr.dataGridView1.AutoGenerateColumns = false;
                DataTable dtwo = connect.readdata("select a.* ,ROW_NUMBER() over (order by a.PST asc) as r from (select distinct  a.PartNo,p.WOCode as WorkOrder,p.ID as PlanID,c.partname,c.Color,c.Market,p.PST,p.productionplan   from Accessory a inner join cargo c on a.PartNo=c.partno inner join productionplan p on a.PartNo=p.partno left join WorkOrder w on w.ID=p.WorkOrderID where p.idlocation ='" + lineID + "' and (p.Status is null or p.Status<> 0 )   and  (convert(date,p.PST)=CONVERT(date,getdate()) or CONVERT(date,p.productiondate)=CONVERT(date,getdate()))) a");
                fr.dataGridView1.DataSource = dtwo;
                fr.ShowDialog();
                txtmodel.Text = fr.sendDataModel();
                txtmodel.Text = fr.sendDataModel();
                LoadAccessory(fr.sendDataModel());
                DataTable dt1 = connect.readdata("select productionplan from productionplan where partno='" + txtmodel.Text.ToUpper() + "' and idlocation='" + lineID + "' and productiondate=convert(date,getdate())");
                if (dt1.Rows.Count > 0)
                {

                    txtPlan.Text = dt1.Rows[0]["productionplan"].ToString();
                }
                else
                {
                    txtPlan.Text = "0";
                }
                lbPackageID.Text = "";
                lbCurrentQtyPack.Text = "0";
                lbQuantity.Text = "0";

            }

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_RowStateChanged_1(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.Rows[0].Cells["judgestatus"].Value.ToString() == "OK")
                {
                    dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Green;
                    dataGridView1.Rows[0].DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Red;
                    dataGridView1.Rows[0].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void lbPackageCapa_Click(object sender, EventArgs e)
        {

        }

        private void lbPackageQuantity_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lbPackageQuantity.Text) >= Convert.ToInt32(lbPackageCapa.Text))
            {
                MessageBox.Show("Mã đóng gói đã đầy ,xin hãy nhập mã đóng gói mới !!!");
                lbPackageID.Text = "";
                lbPackageQuantity.Text = "0";
                lbPackageCapa.Text = "0";
            }
        }
    }
}
