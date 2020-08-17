using HANMISYSTEM.Module;
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
            listAccessory.Add(lbAccessory6);
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
            listAccessory.Add(lbAccessory6);
            DataTable dtAccessory = connect.readdata("select Accessory from Accessory where PartNo='" + cbbModel.SelectedValue.ToString() + "'");
            if (dtAccessory.Rows.Count > 0)
            {
                for (int i = 0; i < dtAccessory.Rows.Count; i++)
                {
                    listAccessory[i].Text = dtAccessory.Rows[i]["Accessory"].ToString();
                }
            }
            DataTable dtplan = connect.readdata("select productionplan from productionplan where partno='" + cbbModel.Text + "' and idlocation='" + cbbLocation.SelectedValue.ToString() + "' and productiondate=convert(date,getdate())");
            if (dtplan.Rows.Count > 0)
            {
                txtPlan.Text = dtplan.Rows[0]["productionplan"].ToString();
            }
            else
            {
                txtPlan.Text = "0";
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
                if(txtScan.Text.Length>0)
                {
                    if(txtScan.Text.Length>16)
                    {
                        txtScan.Text = txtScan.Text.Substring(0, 11);
                    }
                    if (txtScan.Text.Substring(0, 3) == "BOX" && txtScan.Text.Length >= 14 || txtScan.Text.Substring(0, 3) == "CRT" && txtScan.Text.Length >= 14 || txtScan.Text.Substring(0, 3) == "BAG" && txtScan.Text.Length >= 14 || txtScan.Text.Substring(0, 3) == "PAL" && txtScan.Text.Length >= 14)
                    {
                        txtPackID.Text = txtScan.Text;
                        GrabTextChange(txtScan.Text);
                        txtScan.Text = "";
                    }

                    else
                    {

                        if (lbJudge.Text != "")
                        {
                            ClearJudge();
                        }
                        if (Judge(txtScan.Text.ToUpper()))
                        {
                            if (CheckJudgeStatus())
                            {
                                lbJudge.Text = "OK";
                                lbJudge.ForeColor = Color.Lime;
                                dataGridView1.Rows.Insert(0, cbbModel.SelectedValue.ToString(), "OK", DateTime.Now);

                                //quanli packing
                                if (connect.countdata("select count(idpack) from packinginfo where idpack='" + txtPackID.Text + "'") == 0)
                                {
                                    connect.exedata("exec spInsertPackingInfo @idpack='" + txtPackID.Text + "',@partno='" + cbbModel.SelectedValue.ToString().ToUpper() + "',@idlocation='" + cbbLocation.SelectedValue.ToString() + "',@idwarehouse='WH001'");
                                }
                                else
                                {
                                    connect.exedata("exec spUpdatePackingInfo_Increase @idpack='" + txtPackID.Text + "'");
                                }
                                DataTable qtypack = connect.readdata("select quantity from packinginfo where idpack='" + txtPackID.Text + "'");
                                lbCurrentQtyPack.Text = qtypack.Rows[0]["quantity"].ToString();
                                //them lich su
                                connect.exedata("insert into productionhistory (idwarehouse,partno,productiontime,qty,idlocation,idpack) values('WH001','" + cbbModel.SelectedValue.ToString() + "',getdate(),1,'" + cbbLocation.SelectedValue.ToString() + "','" + txtPackID.Text + "')");
                                DataTable dtsumqty = connect.readdata("select sum(qty) as pro from productionhistory where partno='" + cbbModel.SelectedValue.ToString() + "' and idlocation='" + cbbLocation.SelectedValue.ToString() + "' and convert(date,productiontime)=convert(date,getdate())");
                                lbProductivity.Text = dtsumqty.Rows[0]["pro"].ToString();
                                //ClearJudge();
                            }
                            txtScan.Text = "";
                        }
                        else
                        {
                            if (CheckJudgeExisted())
                            {
                                lbJudge.Text = "NG";
                                lbJudge.ForeColor = Color.Red;
                                dataGridView1.Rows.Insert(0, cbbModel.SelectedValue.ToString(), "NG", DateTime.Now);
                                //ClearJudge();
                            }
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
            listJudge.Add(lbJudge6);
            for (int i = 0; i < listJudge.Count; i++)
            {
                if (listJudge[i].Text == "OK")
                {
                    return true;
                }
            }
            return false;
        }
        private bool Judge(string accessory)
        {
            List<Label> listAccessory = new List<Label>();
            listAccessory.Add(lbAccessory1);
            listAccessory.Add(lbAccessory2);
            listAccessory.Add(lbAccessory3);
            listAccessory.Add(lbAccessory4);
            listAccessory.Add(lbAccessory5);
            listAccessory.Add(lbAccessory6);

            List<Label> listJudge = new List<Label>();
            listJudge.Add(lbJudge1);
            listJudge.Add(lbJudge2);
            listJudge.Add(lbJudge3);
            listJudge.Add(lbJudge4);
            listJudge.Add(lbJudge5);
            listJudge.Add(lbJudge6);
            for (int i = 0; i < listAccessory.Count; i++)
            {
                if (listAccessory[i].Text != "")
                {
                    if (accessory == listAccessory[i].Text)
                    {
                        listJudge[i].Text = "OK";
                        listJudge[i].ForeColor = Color.Lime;
                        return true;
                    }
                }
            }
            return false;
        }
        private void ClearJudge()
        {
            lbJudge1.Text = "";
            lbJudge2.Text = "";
            lbJudge3.Text = "";
            lbJudge4.Text = "";
            lbJudge5.Text = "";
            lbJudge6.Text = "";
            lbJudge.Text = "";
        }
        private bool CheckJudgeStatus()
        {
            List<Label> listAccessory = new List<Label>();
            listAccessory.Add(lbAccessory1);
            listAccessory.Add(lbAccessory2);
            listAccessory.Add(lbAccessory3);
            listAccessory.Add(lbAccessory4);
            listAccessory.Add(lbAccessory5);
            listAccessory.Add(lbAccessory6);
            int aCount = connect.countdata("select count(partno) from Accessory where partno ='" + cbbModel.SelectedValue.ToString() + "'");
            List<Label> listJudge = new List<Label>();
            listJudge.Add(lbJudge1);
            listJudge.Add(lbJudge2);
            listJudge.Add(lbJudge3);
            listJudge.Add(lbJudge4);
            listJudge.Add(lbJudge5);
            listJudge.Add(lbJudge6);
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
    }
}
