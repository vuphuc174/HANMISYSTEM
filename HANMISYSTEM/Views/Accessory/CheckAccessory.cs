using HANMISYSTEM.Module;
using HANMISYSTEM.Views.PartialView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private void btnon_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtPlan.Text) <= 0)
            {
                MessageBox.Show("Chưa có kế hoặch sản xuất");
            }
            else
            {
                //kiem tra giai doan truoc da có endtime hay chưa
                DataTable dtendtime = connect.readdata("select top 1 EndTime  from TrackingUPH where LocationID='" + cbbLocation.SelectedValue.ToString() + "' and  CONVERT(date,StartTime)=convert(date,getdate()) order by StartTime desc");
                if (dtendtime.Rows.Count > 0)
                {
                    if (string.IsNullOrEmpty(dtendtime.Rows[0]["EndTime"].ToString()))
                    {
                        //them endtime
                        connect.exedata("with cte as (select top 1 *  from TrackingUPH where LocationID = '" + cbbLocation.SelectedValue.ToString() + "' and  CONVERT(date, StartTime) = CONVERT(date, getdate()) order by StartTime desc) update cte set EndTime = GETDATE(),Remark='EndTime added by system'");
                    }
                }
                pictureBox1.Enabled = true;
                cbbLocation.Enabled = false;
                if (!string.IsNullOrEmpty(offType))
                {
                    btnon.BackColor = Color.Lime;
                    btnoff.BackColor = SystemColors.Control;
                    cbbModel.Enabled = false;
                    connect.exedata("exec spInsertTrackingUPH @partno='" + cbbModel.SelectedValue.ToString() + "' ,@locationid='" + cbbLocation.SelectedValue.ToString() + "',@remark=''");
                    btnon.Enabled = false;
                    btnoff.Enabled = true;
                    if (txtPackID.Text.Length >= 14)
                    {
                        txtScan.Enabled = true;
                        txtScan.Focus();
                    }
                    else
                    {
                        txtPackID.Enabled = true;
                        txtPackID.Focus();
                    }

                }
                else
                {
                    btnon.BackColor = Color.Lime;
                    btnoff.BackColor = SystemColors.Control;
                    cbbModel.Enabled = false;
                    txtPackID.Enabled = true;
                    connect.exedata("exec spInsertTrackingUPH @partno='" + cbbModel.SelectedValue.ToString() + "' ,@locationid='" + cbbLocation.SelectedValue.ToString() + "',@remark=''");
                    btnon.Enabled = false;
                    btnoff.Enabled = true;
                    txtPackID.Focus();
                }


            }
        }

        private void CheckAccessory_Load(object sender, EventArgs e)
        {

            DataTable dt2;
            DataTable dt3 = connect.readdata("select * from tbl_user where username='" + HANMISYSTEM.Properties.Settings.Default.username + "'");
            if (dt3.Rows[0]["location"].ToString() == "all")
            {
                dt2 = connect.readdata("select * from location where idwarehouse='WH001'");
            }
            else
            {
                dt2 = connect.readdata("select * from location where idwarehouse='WH001' and idlocation='" + dt3.Rows[0]["location"].ToString() + "'");
            }
            if (dt2 != null)
            {
                try
                {
                    cbbLocation.DataSource = dt2;
                    cbbLocation.DisplayMember = "namelocation1";
                    cbbLocation.ValueMember = "idlocation";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection faile", ex.ToString());
                }
            }
            DataTable dtModel = connect.readdata("select distinct partno from Accessory");
            if (dtModel.Rows.Count > 0)
            {
                cbbModel.DataSource = dtModel;
                cbbModel.DisplayMember = "partno";
                cbbModel.ValueMember = "partno";
            }
            DataTable dtPlan = connect.readdata("select productionplan from productionplan where partno='" + cbbModel.SelectedValue.ToString() + "' and idlocation='" + cbbLocation.SelectedValue.ToString() + "' and productiondate=convert(date,getdate())");
            if (dtPlan.Rows.Count > 0)
            {
                txtPlan.Text = dtPlan.Rows[0]["productionplan"].ToString();
            }
            else
            {
                txtPlan.Text = "0";
            }
            List<Label> listAccessory = new List<Label>();
            listAccessory.Add(lbAccessory1);
            listAccessory.Add(lbAccessory2);
            listAccessory.Add(lbAccessory3);
            listAccessory.Add(lbAccessory4);
            listAccessory.Add(lbAccessory5);

            DataTable dtAccessory = connect.readdata("select Accessory from Accessory where PartNo='" + cbbModel.SelectedValue.ToString() + "'");
            if (dtAccessory.Rows.Count > 0)
            {
                for (int i = 0; i < dtAccessory.Rows.Count; i++)
                {
                    listAccessory[i].Text = dtAccessory.Rows[i]["Accessory"].ToString();
                }
            }

        }
        string offType;
        private void btnoff_Click(object sender, EventArgs e)
        {
            DialogResult dlr;
            dlr = CustomMsgBox.Show("Tại sao bạn lại muốn dừng lại ", "Thông báo", "Kết thúc ngày làm việc", "Nghỉ giải lao", "Hủy");
            if (dlr == DialogResult.Yes)
            {

                connect.exedata("with cte as (select top 1 EndTime from TrackingUPH where PartNo='" + cbbModel.SelectedValue.ToString() + "' and LocationID='" + cbbLocation.SelectedValue.ToString() + "' order by StartTime Desc) update cte set EndTime =getdate()");
                pictureBox1.Enabled = false;
                btnoff.BackColor = Color.Lime;
                btnon.BackColor = SystemColors.Control;
                btnon.Enabled = true;
                btnoff.Enabled = false;
                txtPackID.Text = "";
                txtScan.Enabled = false;
                cbbModel.Enabled = true;
                cbbModel.Focus();
                offType = "";
                cbbLocation.Enabled = true;
            }
            if (dlr == DialogResult.No)
            {
                connect.exedata("with cte as (select top 1 EndTime from TrackingUPH where PartNo='" + cbbModel.SelectedValue.ToString() + "' and LocationID='" + cbbLocation.SelectedValue.ToString() + "' order by StartTime Desc) update cte set EndTime =getdate()");

                pictureBox1.Enabled = false;
                offType = "Break";
                btnoff.BackColor = Color.Lime;
                btnon.BackColor = SystemColors.Control;
                btnon.Enabled = true;
                btnoff.Enabled = false;
                txtScan.Enabled = false;
            }
        }

        private void cbbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Label> listAccessory = new List<Label>();
            listAccessory.Add(lbAccessory1);
            listAccessory.Add(lbAccessory2);
            listAccessory.Add(lbAccessory3);
            listAccessory.Add(lbAccessory4);
            listAccessory.Add(lbAccessory5);

            if(cbbModel.SelectedValue!=null)
            {
                DataTable dtAccessory = connect.readdata("select Accessory from Accessory where PartNo='" + cbbModel.SelectedValue.ToString() + "'");
                if (dtAccessory.Rows.Count > 0)
                {
                    for (int i = 0; i < dtAccessory.Rows.Count; i++)
                    {
                        listAccessory[i].Text = dtAccessory.Rows[i]["Accessory"].ToString();
                    }
                }
                DataTable dtplan = connect.readdata("select productionplan,WOCode,ID from productionplan where partno='" + cbbModel.Text + "' and idlocation='" + cbbLocation.SelectedValue.ToString() + "' and productiondate=convert(date,getdate())");
                if (dtplan!=null)
                {
                    if (dtplan.Rows.Count > 0)
                    {
                        txtPlan.Text = dtplan.Rows[0]["productionplan"].ToString();
                        txtPlanID.Text = dtplan.Rows[0]["ID"].ToString();
                        txtworkorder.Text = dtplan.Rows[0]["WOCode"].ToString();

                    }
                    else
                    {
                        txtPlan.Text = "0";
                    }
                }
                
            }
            
        }
        private void GrabTextChange(string str)
        {
            if (txtPackID.Text.Length >= 14)
            {
                DataTable packqty = connect.readdata("select partno,quantity from packinginfo where idpack='" + txtPackID.Text + "'");
                DataTable dt = connect.readdata("select * from packingstandard where partno='" + cbbModel.SelectedValue.ToString() + "' and idpacking like '" + txtPackID.Text.Substring(0, 3) + "'");
                //check phuong thuc dong goi
                if (dt.Rows.Count == 0 || dt.Rows[0]["quantity"].ToString() == "0")
                {
                    MessageBox.Show("Phương thức đóng gói không hợp lệ !");
                    txtPackID.Text = "";
                }
                else
                {
                    //package da ton tai
                    if (packqty.Rows.Count != 0)
                    {
                        //check partno -if other
                        if (packqty.Rows[0]["partno"].ToString() != cbbModel.SelectedValue.ToString())
                        {
                            MessageBox.Show("Box này đã được sử dụng cho mã hàng khác !");
                            txtPackID.Text = "";
                            txtPackID.Focus();
                        }
                        else
                        {
                            if (packqty.Rows[0]["quantity"].ToString() == dt.Rows[0]["quantity"].ToString())
                            {
                                MessageBox.Show("Box fulled !");
                                txtPackID.Text = "";
                                txtPackID.Focus();
                            }
                            else
                            {
                                txtMaxPack.Text = dt.Rows[0]["quantity"].ToString();
                                lbCurrentQtyPack.Text = packqty.Rows[0]["quantity"].ToString();
                                txtScan.Enabled = true;
                                txtScan.Focus();
                                txtPackID.Enabled = false;
                            }
                        }

                    }
                    //package moi
                    else
                    {
                        txtMaxPack.Text = dt.Rows[0]["quantity"].ToString();
                        lbCurrentQtyPack.Text = "0";
                        txtScan.Enabled = true;
                        txtScan.Focus();
                        txtPackID.Enabled = false;
                    }
                }
            }
        }
        private void txtPackID_TextChanged(object sender, EventArgs e)
        {

            GrabTextChange(txtPackID.Text);


        }

        private void txtScan_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                if (txtScan.Text.Length > 0)
                {
                    if (txtScan.Text.Length > 16)
                    {
                        txtScan.Text = txtScan.Text.Substring(0, 12).ToUpper();
                    }
                    if (txtScan.Text.Substring(0, 3) == "BOX" && txtScan.Text.Length >= 14 || txtScan.Text.Substring(0, 3) == "CRT" && txtScan.Text.Length >= 14 || txtScan.Text.Substring(0, 3) == "BAG" && txtScan.Text.Length >= 14 || txtScan.Text.Substring(0, 3) == "PAL" && txtScan.Text.Length >= 14)
                    {
                        txtPackID.Text = txtScan.Text;
                        GrabTextChange(txtScan.Text);
                        txtScan.Text = "";
                    }
                    else
                    {
                        if (Judge(txtScan.Text.ToUpper()))
                        {
                            List<Label> listAccessory = new List<Label>();
                            listAccessory.Add(lbAccessory1);
                            listAccessory.Add(lbAccessory2);
                            listAccessory.Add(lbAccessory3);
                            listAccessory.Add(lbAccessory4);
                            listAccessory.Add(lbAccessory5);
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       

                            List<Label> listJudge = new List<Label>();
                            listJudge.Add(lbJudge1);
                            listJudge.Add(lbJudge2);
                            listJudge.Add(lbJudge3);
                            listJudge.Add(lbJudge4);
                            listJudge.Add(lbJudge5);

                            for (int i = 0; i < listAccessory.Count; i++)
                            {
                                if (listAccessory[i].Text != "" && listJudge[i].Text == "")
                                {
                                    if (txtScan.Text == listAccessory[i].Text)
                                    {
                                        listJudge[i].Text = "OK";
                                        listJudge[i].ForeColor = Color.Lime;
                                        
                                    }
                                }
                            }
                            txtScan.Text = "";
                            if (CheckJudgeStatus())
                            {
                                Task.Delay(20).Wait();
                                lbJudge.Text = "OK";
                                lbJudge.ForeColor = Color.Lime;
                                //Task.Delay(2).Wait();
                                dataGridView1.Rows.Insert(0, cbbModel.SelectedValue.ToString(), "OK", DateTime.Now);
                                //    //quanli packing
                                if (connect.countdata("select count(idpack) from packinginfo where idpack='" + txtPackID.Text + "'") == 0)
                                {
                                    connect.exedata("exec spInsertPackingInfo @idpack= '" + txtPackID.Text + "',@partno='" + cbbModel.SelectedValue.ToString().ToUpper() + "',@idlocation='" + cbbLocation.SelectedValue.ToString() + "',@idwarehouse='WH001'");
                                }
                                else
                                {
                                    connect.exedata("exec spUpdatePackingInfo_Increase @idpack='" + txtPackID.Text + "'");
                                }
                                DataTable qtypack = connect.readdata("select quantity from packinginfo where idpack='" + txtPackID.Text + "'");
                                lbCurrentQtyPack.Text = qtypack.Rows[0]["quantity"].ToString();
                                //them lich su

                                //connect.exedata("update runingstatus set partno=@partno where idlocation='" + cblocation.SelectedValue.ToString() + "'");
                                connect.exedata("insert into productionhistory (idwarehouse,partno,productiontime,qty,idlocation,idpack,WO,PlanID) values('WH001','" + cbbModel.SelectedValue.ToString() + "',GETDATE(),1,'" + cbbLocation.SelectedValue.ToString() + "','" + txtPackID.Text + "','" + txtworkorder.Text + "','"+txtPlanID.Text+"')");
                                //connect.exedata("insert into productionhistory (idwarehouse,partno,productiontime,qty,idlocation,idpack) values('WH001','" + cbbModel.SelectedValue.ToString() + "',getdate(),1,'" + cbbLocation.SelectedValue.ToString() + "','" + txtPackID.Text + "')");
                                DataTable dtsumqty = connect.readdata("select sum(qty) as pro from productionhistory where partno='" + cbbModel.SelectedValue.ToString() + "' and idlocation='" + cbbLocation.SelectedValue.ToString() + "' and convert(date,productiontime)=convert(date,getdate())");
                                lbProductivity.Text = dtsumqty.Rows[0]["pro"].ToString();
                                ClearJudge();
                            }
                        }
                        else
                        {
                            lbJudge.Text = "NG";
                            lbJudge.ForeColor = Color.Red;
                            dataGridView1.Rows.Insert(0, cbbModel.SelectedValue.ToString(), "NG", DateTime.Now);
                            txtScan.Text = "";
                            ClearJudge();
                        }
                        
                        //if (CheckJudgeExisted())
                        //{
                        //    if (Judge(txtScan.Text.ToUpper()))
                        //    {

                        //        txtScan.Text = "";
                        //    }
                        //    else
                        //    {
                        //        lbJudge.Text = "NG";
                        //        lbJudge.ForeColor = Color.Red;
                        //        dataGridView1.Rows.Insert(0, cbbModel.SelectedValue.ToString(), "NG", DateTime.Now);

                        //        ClearJudge();

                        //        txtScan.Text = "";
                        //    }
                        //}

                        //else
                        //{
                        //    if (Judge(txtScan.Text.ToUpper()))
                        //    {

                        //        txtScan.Text = "";
                        //    }
                        //}

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
            List<Label> listAccessory = new List<Label>();
            listAccessory.Add(lbAccessory1);
            listAccessory.Add(lbAccessory2);
            listAccessory.Add(lbAccessory3);
            listAccessory.Add(lbAccessory4);
            listAccessory.Add(lbAccessory5);

            List<Label> listJudge = new List<Label>();
            listJudge.Add(lbJudge1);
            listJudge.Add(lbJudge2);
            listJudge.Add(lbJudge3);
            listJudge.Add(lbJudge4);
            listJudge.Add(lbJudge5);

            for (int i = 0; i < listAccessory.Count; i++)
            {
                if (listAccessory[i].Text != "")
                {
                    if (listJudge[i].Text != "OK")
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private bool Judge(string accessory)
        {
            List<Label> listAccessory = new List<Label>();
            listAccessory.Add(lbAccessory1);
            listAccessory.Add(lbAccessory2);
            listAccessory.Add(lbAccessory3);
            listAccessory.Add(lbAccessory4);
            listAccessory.Add(lbAccessory5);


            List<Label> listJudge = new List<Label>();
            listJudge.Add(lbJudge1);
            listJudge.Add(lbJudge2);
            listJudge.Add(lbJudge3);
            listJudge.Add(lbJudge4);
            listJudge.Add(lbJudge5);
            if(accessory.Length>=16)
            {
                for (int i = 0; i < listAccessory.Count; i++)
                {
                    if (listAccessory[i].Text != "" && listJudge[i].Text == "")
                    {
                        if (accessory.Substring(0,12)== listAccessory[i].Text)
                        {
                            //listJudge[i].Text = "OK";
                            //listJudge[i].ForeColor = Color.Lime;
                            //Task.Delay(1).Wait();
                            //if (CheckJudgeStatus())
                            //{
                            //    lbJudge.Text = "OK";
                            //    lbJudge.ForeColor = Color.Lime;
                            //    Task.Delay(2).Wait();
                            //    dataGridView1.Rows.Insert(0, cbbModel.SelectedValue.ToString(), "OK", DateTime.Now);

                            //    //quanli packing
                            //    if (connect.countdata("select count(idpack) from packinginfo where idpack='" + txtPackID.Text + "'") == 0)
                            //    {
                            //        connect.exedata("exec spInsertPackingInfo @idpack= '" + txtPackID.Text + "',@partno='" + cbbModel.SelectedValue.ToString().ToUpper() + "',@idlocation='" + cbbLocation.SelectedValue.ToString() + "',@idwarehouse='WH001'");
                            //    }
                            //    else
                            //    {
                            //        connect.exedata("exec spUpdatePackingInfo_Increase @idpack='" + txtPackID.Text + "'");
                            //    }
                            //    DataTable qtypack = connect.readdata("select quantity from packinginfo where idpack='" + txtPackID.Text + "'");
                            //    lbCurrentQtyPack.Text = qtypack.Rows[0]["quantity"].ToString();
                            //    //them lich su
                            //    connect.exedata("insert into productionhistory (idwarehouse,partno,productiontime,qty,idlocation,idpack) values('WH001','" + cbbModel.SelectedValue.ToString() + "',getdate(),1,'" + cbbLocation.SelectedValue.ToString() + "','" + txtPackID.Text + "')");
                            //    DataTable dtsumqty = connect.readdata("select sum(qty) as pro from productionhistory where partno='" + cbbModel.SelectedValue.ToString() + "' and idlocation='" + cbbLocation.SelectedValue.ToString() + "' and convert(date,productiontime)=convert(date,getdate())");
                            //    lbProductivity.Text = dtsumqty.Rows[0]["pro"].ToString();
                            //    ClearJudge();


                            //}
                            return true;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < listAccessory.Count; i++)
                {
                    if (listAccessory[i].Text != "" && listJudge[i].Text == "")
                    {
                        if (accessory == listAccessory[i].Text)
                        {
                            //listJudge[i].Text = "OK";
                            //listJudge[i].ForeColor = Color.Lime;
                            //Task.Delay(1).Wait();
                            //if (CheckJudgeStatus())
                            //{
                            //    lbJudge.Text = "OK";
                            //    lbJudge.ForeColor = Color.Lime;
                            //    Task.Delay(2).Wait();
                            //    dataGridView1.Rows.Insert(0, cbbModel.SelectedValue.ToString(), "OK", DateTime.Now);

                            //    //quanli packing
                            //    if (connect.countdata("select count(idpack) from packinginfo where idpack='" + txtPackID.Text + "'") == 0)
                            //    {
                            //        connect.exedata("exec spInsertPackingInfo @idpack= '" + txtPackID.Text + "',@partno='" + cbbModel.SelectedValue.ToString().ToUpper() + "',@idlocation='" + cbbLocation.SelectedValue.ToString() + "',@idwarehouse='WH001'");
                            //    }
                            //    else
                            //    {
                            //        connect.exedata("exec spUpdatePackingInfo_Increase @idpack='" + txtPackID.Text + "'");
                            //    }
                            //    DataTable qtypack = connect.readdata("select quantity from packinginfo where idpack='" + txtPackID.Text + "'");
                            //    lbCurrentQtyPack.Text = qtypack.Rows[0]["quantity"].ToString();
                            //    //them lich su
                            //    connect.exedata("insert into productionhistory (idwarehouse,partno,productiontime,qty,idlocation,idpack) values('WH001','" + cbbModel.SelectedValue.ToString() + "',getdate(),1,'" + cbbLocation.SelectedValue.ToString() + "','" + txtPackID.Text + "')");
                            //    DataTable dtsumqty = connect.readdata("select sum(qty) as pro from productionhistory where partno='" + cbbModel.SelectedValue.ToString() + "' and idlocation='" + cbbLocation.SelectedValue.ToString() + "' and convert(date,productiontime)=convert(date,getdate())");
                            //    lbProductivity.Text = dtsumqty.Rows[0]["pro"].ToString();
                            //    ClearJudge();


                            //}
                            return true;
                        }
                    }
                }
            }
            

            return false;
        }
        private void ClearJudge()
        {
            Task.Delay(2000).Wait();
            lbJudge1.Text = "";
            lbJudge2.Text = "";
            lbJudge3.Text = "";
            lbJudge4.Text = "";
            lbJudge5.Text = "";
            lbJudge.Text = "";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            IssueReport fr = new IssueReport();
            fr.lbLocation.Text = cbbLocation.SelectedValue.ToString();
            fr.lbModel.Text = cbbModel.SelectedValue.ToString();
            fr.ShowDialog();
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

        private void btnselectWO_Click(object sender, EventArgs e)
        {
            using (SelectWorkOrder frm = new SelectWorkOrder())
            {
                DataTable dtLocation = connect.readdata("select namelocation1 from location where idlocation ='" + cbbLocation.SelectedValue.ToString() + "'");
                SelectWorkOrder fr = new SelectWorkOrder();
                fr.lbline.Text = dtLocation.Rows[0]["namelocation1"].ToString();
                fr.dataGridView1.AutoGenerateColumns = false;
                DataTable dtwo = connect.readdata("select a.* ,ROW_NUMBER() over (order by a.PST asc) as r from (select distinct  a.PartNo,p.WOCode as WorkOrder,p.ID as PlanID,c.partname,c.Color,c.Market,p.PST,p.productionplan   from Accessory a inner join cargo c on a.PartNo=c.partno inner join productionplan p on a.PartNo=p.partno left join WorkOrder w on w.ID=p.WorkOrderID where p.idlocation ='"+cbbLocation.SelectedValue.ToString()+"' and (p.Status is null or p.Status<> 0 )   and  (convert(date,p.PST)=CONVERT(date,getdate()) or CONVERT(date,p.productiondate)=CONVERT(date,getdate()))) a"); 
                fr.dataGridView1.DataSource = dtwo;
                fr.ShowDialog();
                txtworkorder.Text = fr.SendData();
                txtmodel.Text = fr.sendDataModel();
                txtPlanID.Text = fr.SendPlanID();
                cbbModel.Text = fr.sendDataModel();
                //DataTable dt = connect.readdata("select currenttarget from updatestatus where partno='" + txtmodel.Text.ToUpper() + "' and idlocation='" + cbbLocation.SelectedValue.ToString() + "' and productiondate=convert(date,getdate())");
                //if (dt.Rows.Count > 0)
                //{
                //    if (dt.Rows[0]["currenttarget"].ToString() != "")
                //    {
                //        txttarget.Text = dt.Rows[0]["currenttarget"].ToString();
                //    }
                //    else
                //    {
                //        txttarget.Text = "0";
                //    }
                //}
                //else
                //{
                //    txttarget.Text = "0";
                //}
                DataTable dt1 = connect.readdata("select productionplan from productionplan where partno='" + cbbModel.Text.ToUpper() + "' and idlocation='" + cbbLocation.SelectedValue.ToString() + "' and productiondate=convert(date,getdate())");
                if (dt1.Rows.Count > 0)
                {

                    txtPlan.Text = dt1.Rows[0]["productionplan"].ToString();
                }
                else
                {
                    txtPlan.Text = "0";
                }
                txtPackID.Text = "";
                lbCurrentQtyPack.Text = "0";
                lbProductivity.Text = "0";
                txtPackID.Enabled = true; ;
                //lbsearch.Visible = false;

            }

        }
    }
}
