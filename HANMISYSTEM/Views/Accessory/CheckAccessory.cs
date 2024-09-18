using HANMISYSTEM.Common;
using HANMISYSTEM.DAO;
using HANMISYSTEM.Module;
using HANMISYSTEM.Views.MsgBox;
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
        private static CheckAccessory instance;
        private bool inspectorLabelQSS;
        DAO_CheckAccessoryOptional dAO_CheckAccessoryOptional = new DAO_CheckAccessoryOptional();
        DAO_SystemLog dAO_SystemLog = new DAO_SystemLog();
        DAO_Accessory dAO_Accessory = new DAO_Accessory();
        DAO_Production dAO_Production = new DAO_Production();
        public static CheckAccessory Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new CheckAccessory();

                return instance;
            }
        }
        DAO_Line dAO_Line = new DAO_Line();
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
        string mapping_lineID;
        public string pushnotifytype;
        double plan;
        public class Mapping_Line
        {
            public string factoryCode;
            public string factoryID;
            public string machineCode;
            public string machineID;
        }
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
                    catch
                    {
                        throw;
                        //MessageBox.Show(ex.Message);
                    }

                    //}
                }
                Thread.Sleep(200);



            }

        }
        void UpdateDB(string partno,string lineID,string packageID)
        {
            //quanli packing
            if (connect.countdata($"select count(idpack) from packinginfo where idpack='{packageID}'") == 0)
            {
                connect.exedata($"exec spInsertPackingInfo @idpack='{packageID}',@partno='{partno}',@idlocation='{lineID}',@idwarehouse='WH001'");
            }
            else
            {
                connect.exedata($"exec spUpdatePackingInfo_Increase @idpack='{packageID}'");
            }
        }
        private async void doJob()
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
                    //bravo import
                    //await dAO_Production.UpdateProductionResult(_mapping_Line.factoryCode, _mapping_Line.factoryID, _mapping_Line.machineCode, _mapping_Line.machineID, txtmodel.Text, "1", txtboxno.Text, txtPlanID.Text);
                    //bravo import
                    await dAO_Production.UpdateProductionResult(_mapping_Line.factoryCode, _mapping_Line.factoryID, _mapping_Line.machineCode, _mapping_Line.machineID, txtmodel.Text, "1", lbPackageID.Text, txtPlanID.Text, txtWoCode.Text);
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
        private async Task LoadAccessory(string id)
        {
            pnMaterials.Controls.Clear();
            lbAccessory.Clear();
            lbJudge.Clear();
            try
            {
                DataTable dtAccessorys = await dAO_Accessory.GetAccessoryByPartNo(id);
                string ag_width = string.IsNullOrEmpty(HANMISYSTEM.Properties.Settings.Default.accessory_group_width) ? "150" : HANMISYSTEM.Properties.Settings.Default.accessory_group_width;
                string ag_height = string.IsNullOrEmpty(HANMISYSTEM.Properties.Settings.Default.accessory_group_height) ? "200" : HANMISYSTEM.Properties.Settings.Default.accessory_group_height;
                string al_height = string.IsNullOrEmpty(HANMISYSTEM.Properties.Settings.Default.accessory_label_height) ? "30" : HANMISYSTEM.Properties.Settings.Default.accessory_label_height;
                string ai_height = string.IsNullOrEmpty(HANMISYSTEM.Properties.Settings.Default.accessory_image_height) ? "60" : HANMISYSTEM.Properties.Settings.Default.accessory_image_height;
                if (dtAccessorys.Rows.Count > 0)
                {
                    if (await dAO_CheckAccessoryOptional.GetStatus(txtmodel.Text))
                    {
                        dtAccessorys.Rows.Add(DateTime.Now.ToString("yyyyMMdd"));
                    }
                    for (int i = 0; i < dtAccessorys.Rows.Count; i++)
                    {
                        GroupBox groupBox = new GroupBox();
                        groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        groupBox.Text = "Accessory " + (i + 1).ToString();
                        groupBox.Size = new Size(Convert.ToInt32(ag_width), Convert.ToInt32(ag_height));

                        //LABEL IMAGE
                        if (ai_height != "0")
                        {

                            Panel pnPic = new Panel();
                            pnPic.Size = new Size(Convert.ToInt32(ag_width), Convert.ToInt32(ai_height));
                            pnPic.BorderStyle = BorderStyle.FixedSingle;

                            PictureBox pictureBox = new PictureBox();
                            try
                            {
                                pictureBox.Image = connect.GetImage(dtAccessorys.Rows[i]["Accessory"].ToString());
                            }
                            catch
                            {

                            }
                            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox.Dock = DockStyle.Fill;
                            pnPic.Controls.Add(pictureBox);

                            groupBox.Controls.Add(pnPic);
                            pnPic.Dock = DockStyle.Bottom;
                        }

                        //LABEL ACCESSORY
                        Panel pnCode = new Panel();
                        pnCode.Size = new Size(Convert.ToInt32(ag_width), Convert.ToInt32(al_height));
                        pnCode.BackColor = Color.FromArgb(64, 64, 64);
                        Label lblCode = new Label();
                        lblCode.Text = dtAccessorys.Rows[i]["Accessory"].ToString();
                        //lblCode.BackColor = Color.Black;
                        lblCode.ForeColor = Color.White;
                        lblCode.TextAlign = ContentAlignment.MiddleCenter;
                        lblCode.AutoSize = false;
                        lbAccessory.Add(lblCode);
                        lblCode.Dock = Dock = DockStyle.Fill;
                        pnCode.Dock = DockStyle.Bottom;
                        pnCode.Controls.Add(lblCode);



                        //LABEL JUDGE
                        Panel pnJudge = new Panel();
                        groupBox.Controls.Add(pnJudge);
                        pnJudge.Dock = DockStyle.Fill;
                        pnJudge.Height = Convert.ToInt32(ag_height) - Convert.ToInt32(al_height) - Convert.ToInt32(ai_height);
                        Label lblJudge = new Label
                        {
                            AutoSize = false,
                            Dock = DockStyle.Fill,
                            BackColor = Color.Black,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Font = new Font("Arial", 30, FontStyle.Bold)
                        };
                        lbJudge.Add(lblJudge);
                        pnJudge.Controls.Add(lblJudge);
                        groupBox.Controls.Add(pnCode);
                        pnMaterials.Controls.Add(groupBox);
                    }

                }
                ClearJudge();
            }
            catch(Exception ex)
            {
                await dAO_SystemLog.Add("error", "Cannot load accessory:" + ex.Message);
                MessageBox.Show(ex.Message);
            }
            

        }
        Mapping_Line _mapping_Line = new Mapping_Line();
        private async void CheckAccessory_Load(object sender, EventArgs e)
        {
            //set push notify type 
            if (!string.IsNullOrEmpty(HANMISYSTEM.Properties.Settings.Default.pushnotifytype))
            {
                pushnotifytype = HANMISYSTEM.Properties.Settings.Default.pushnotifytype;
            }
            else
            {
                pushnotifytype = "1";
            }
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
            mapping_lineID = await dAO_Line.GetBravoLineIDByLineID(lineID);
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
                    if (file.ReadToEnd().Trim() == "")
                    {
                        file.Close();
                        //write file here
                        File.WriteAllText(path + "\\json\\packingdata.json", "[]");
                    }  
                }
                using (StreamReader file = File.OpenText(path + "\\json\\packingdata.json"))
                {
          
                        JsonSerializer serializer = new JsonSerializer();
                        packingdatas = (List<packingdata>)serializer.Deserialize(file, typeof(List<packingdata>));
                    
                }
            }

            try
            {
                // Control.CheckForIllegalCrossThreadCalls = false;
                t = new Thread(checkTask);
                t.IsBackground = true;
                t.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            HideAll();
        }
        public static bool IsJsonFileEmpty(string filePath)
        {
            try
            {
                using (StreamReader file = File.OpenText(filePath))
                {
                    return file.ReadToEnd().Trim() == "";
                }
            }
            catch (IOException)
            {
                // Handle exception if the file cannot be opened or read
                return false;
            }
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
                btnselectWO.Enabled = true;
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
                btnselectWO.Enabled = true;
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
                serialPort.Close();
            }
            catch (Exception)
            {

            }

        }
        bool checkStatus = true;
        private async void DoCheckAccessory(string data)
        {
            if (Judge(data))
            {
                if (CheckJudgeStatus() && checkStatus == true)
                {
                    checkStatus = false;
                    timer1.Start();
                    lbQuantity.Text = (Convert.ToInt32(lbQuantity.Text) + 1).ToString();
                    lbFinalJudge.Text = "OK";
                    lbFinalJudge.ForeColor = Color.Lime;
                    dataGridView1.Rows.Insert(0, dataGridView1.Rows.Count, txtmodel.Text, "OK", DateTime.Now);
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
                    //Thread.Sleep(510);
                }
            }
            else
            {
                //if (CheckJudgeExisted())
                //{
                lbFinalJudge.Text = "NG";
                lbFinalJudge.ForeColor = Color.Red;
                dataGridView1.Rows.Insert(0, dataGridView1.Rows.Count, txtmodel.Text, "NG", DateTime.Now);
                //save to stopalertcounter (table)--update 11/11/2022
                try
                {
                    string remark = "Mã hàng không hợp lệ " + data;
                    await connect.ExeDataAsync($"Insert into StopAlertCounter(SubmitDate,PartNo,Remark,LocationID) values(getdate(),'{txtmodel.Text}',N'{remark}','{lineID}')"); ;
                }
                catch { }
                //notify box
                CallNG();
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
                using (CustomMessageBox frm = new CustomMessageBox())
                {
                    frm.lbContent.Text = "Phương thức đóng gói không hợp lệ !";
                    frm.ShowInTaskbar = false;
                    frm.ShowDialog();
                }
                //MessageBox.Show("Phương thức đóng gói không hợp lệ !");
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
                        using (CustomMessageBox frm = new CustomMessageBox())
                        {
                            frm.lbContent.Text = "Box này đã được sử dụng cho mã hàng khác !";
                            frm.ShowInTaskbar = false;
                            frm.ShowDialog();
                        }
                        //MessageBox.Show("Box này đã được sử dụng cho mã hàng khác !");
                        //txtPackID.Text = "";
                        //txtPackID.Focus();
                    }
                    else
                    {
                        if (Convert.ToInt32(packqty.Rows[0]["quantity"].ToString()) >= Convert.ToInt32(dt.Rows[0]["quantity"].ToString()))
                        {
                            using (CustomMessageBox frm = new CustomMessageBox())
                            {
                                frm.lbContent.Text = "Box fulled !";
                                frm.ShowInTaskbar = false;
                                frm.ShowDialog();
                            }
                            //MessageBox.Show("Box fulled !");
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
            for (int i = 0; i < lbJudge.Count; i++)
            {
                if (lbJudge[i].Text == "OK")
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
                    if(inspectorLabelQSS && accessory.Contains(DateTime.Now.ToString("yyyyMMdd")) && accessory.Length==12 && accessory.Contains(lbAccessory[i].Text) && lbJudge[i].Text != "OK")
                    {
                        lbJudge[i].Text = "OK";
                        lbJudge[i].ForeColor = Color.Lime;
                        return true;
                    }
                    else
                    {
                        if (lbAccessory[i].Text == accessory && lbJudge[i].Text != "OK")
                        //if (accessory == lbAccessory[i].Text)
                        {
                            lbJudge[i].Text = "OK";
                            lbJudge[i].ForeColor = Color.Lime;
                            return true;
                        }
                    }
                    
                }
            }
            return false;
        }
        private void ClearJudge()
        {

            Task.Delay(500).Wait();
            foreach (Label label in lbJudge)
            {
                ThreadHelperClass.SetText(this, label, "");
            }
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
        //private void LoadAccessory(string id)
        //{
        //    HideAll();
        //    DataTable dtAccessory = connect.readdata("select Accessory from Accessory where PartNo='" + id + "'");


        //    if (dtAccessory.Rows.Count > 0)
        //    {
        //        for (int i = 0; i < dtAccessory.Rows.Count; i++)
        //        {
        //            accessoryGroup[i].Visible = true;
        //            lbAccessory[i].Text = dtAccessory.Rows[i]["Accessory"].ToString();
        //        }
        //    }
        //}
        private async void btnselectWO_Click(object sender, EventArgs e)
        {
            //using (SelectWorkOrder frm = new SelectWorkOrder())
            //{
            //    DataTable dtLocation = connect.readdata("select namelocation1 from location where idlocation ='" + lineID + "'");
            //    SelectWorkOrder fr = new SelectWorkOrder();
            //    fr.ShowInTaskbar = false;
            //    fr.lineID = lineID;
            //    fr.lbline.Text = dtLocation.Rows[0]["namelocation1"].ToString();
            //    fr.ShowInTaskbar = false;
            //    fr.dataGridView1.AutoGenerateColumns = false;
            //    fr.ShowDialog();
            //    txtmodel.Text = fr.sendDataModel();
            //    await LoadAccessory(fr.sendDataModel());
            //    inspectorLabelQSS = await dAO_CheckAccessoryOptional.GetStatus(fr.sendDataModel());
            //    DataTable dt1 = connect.readdata("select productionplan from productionplan where partno='" + txtmodel.Text.ToUpper() + "' and idlocation='" + lineID + "' and productiondate=convert(date,getdate())");
            //    if (dt1.Rows.Count > 0)
            //    {

            //        txtPlan.Text = dt1.Rows[0]["productionplan"].ToString();
            //    }
            //    else
            //    {
            //        txtPlan.Text = "0";
            //    }
            //    lbPackageID.Text = "";
            //    lbCurrentQtyPack.Text = "0";
            //    lbQuantity.Text = GetCurrentQuantity_Day(txtmodel.Text.ToUpper());

            //}
            using (GetPlan frm = new GetPlan())
            {
                DataTable dtLocation = connect.readdata("select namelocation1 from location where idlocation ='" + lineID + "'");
                frm.lbline.Text = dtLocation.Rows[0]["namelocation1"].ToString();
                frm.dataGridView1.AutoGenerateColumns = false;
                frm.lineID = lineID;
                frm.ShowInTaskbar = false;
                frm.ShowDialog();
                txtWoCode.Text = frm.SendData();
                txtmodel.Text = frm.sendDataModel();
                await LoadAccessory(frm.sendDataModel());
                inspectorLabelQSS = await dAO_CheckAccessoryOptional.GetStatus(frm.sendDataModel());
                UserSession.PartNo_Packing = frm.sendDataModel();
                txtPlanID.Text = frm.SendPlanID();
                plan = Convert.ToDouble(frm.SendPlan());
                txtPlan.Text = plan.ToString();
                lbPackageID.Text = "";
                lbCurrentQtyPack.Text = "0";
                lbQuantity.Text = GetCurrentQuantity_Day(txtmodel.Text.ToUpper());;
            }
        }
        private string GetCurrentQuantity_Day(string code)
        {
            try
            {
                DataTable dtResult = connect.readdata("select sum(qty) as quantity from productionhistory where partno='" + code + "' and CONVERT(date,productiontime) =CONVERT(date,getdate()) ");
                return (dtResult.Rows[0]["quantity"].ToString() == "") ? "0" : dtResult.Rows[0]["quantity"].ToString();
            }
            catch
            {
                return "0";
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
            lbCurrentQtyPack.Text = lbPackageQuantity.Text;
            if (Convert.ToInt32(lbPackageQuantity.Text) >= Convert.ToInt32(lbPackageCapa.Text))
            {
                MessageBox.Show("Mã đóng gói đã đầy ,xin hãy nhập mã đóng gói mới !!!");
                lbPackageID.Text = "";
                lbPackageQuantity.Text = "0";
                lbPackageCapa.Text = "0";
            }
        }

        private void CheckAccessory_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }

        private void lbPackageID_TextChanged(object sender, EventArgs e)
        {
            label10.Text = lbPackageID.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Task.Delay(500).Wait();
            checkStatus = true;
            timer1.Stop();
        }

        private void btnSettingLayout_Click(object sender, EventArgs e)
        {
            using (LayoutSetting frm = new LayoutSetting())
            {
                frm.ShowInTaskbar = false;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
        }
    }
}
