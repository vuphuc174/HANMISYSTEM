using HANMISYSTEM.Common;
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

namespace HANMISYSTEM.Views.Production
{
    public partial class CheckMaterials : Form
    {
        public CheckMaterials()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        List<GroupBox> accessoryGroup = new List<GroupBox>();
        List<Label> lbJudge = new List<Label>();
        List<Label> lbAccessory = new List<Label>();
        List<PictureBox> labelPics = new List<PictureBox>();
        public string partno;
        public string lineID;
        private void CheckMaterials_Load(object sender, EventArgs e)
        {
            //partno = "ACQ86642259";
            txtPartno.Text = partno;
            DataTable dtProduct = connect.readdata("select partname from cargo where partno ='" + partno + "'");
            if (dtProduct.Rows.Count > 0)
            {
                txtPartname.Text = dtProduct.Rows[0]["partname"].ToString();
            }

            LoadMaterials();
        }
        private void LoadMaterials()
        {

            DataTable dtAccessorys = connect.readdata("select Accessory from Accessory where partno ='" + partno + "'");
            for (int i = 0; i < dtAccessorys.Rows.Count; i++)
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                groupBox.Text = "Accessory" + (i + 1).ToString();
                groupBox.Size = new Size(150, 200);
                Panel pnCode = new Panel();
                pnCode.Size = new Size(150, 30);
                pnCode.Dock = DockStyle.Bottom;
                Label lblCode = new Label();
                lblCode.Text = dtAccessorys.Rows[i]["Accessory"].ToString();
                lblCode.TextAlign = ContentAlignment.MiddleCenter;
                lblCode.AutoSize = false;
                lbAccessory.Add(lblCode);
                lblCode.Dock = Dock = DockStyle.Fill;
                pnCode.Controls.Add(lblCode);
                Panel pnPic = new Panel();
                pnPic.Size = new Size(150, 50);
                pnPic.BorderStyle = BorderStyle.FixedSingle;
                pnPic.Dock = DockStyle.Bottom;
                PictureBox pictureBox = new PictureBox();
                try
                {
                    pictureBox.Image = connect.GetImage(dtAccessorys.Rows[i]["Accessory"].ToString());
                }
                catch
                {

                }
                Panel pnJudge = new Panel();
                groupBox.Controls.Add(pnJudge);
                pnJudge.Dock = DockStyle.Fill;
                Label lblJudge = new Label();
                lblJudge.AutoSize = false;
                lblJudge.Dock = DockStyle.Fill;
                lblJudge.BackColor = Color.Black;
                lblJudge.TextAlign=ContentAlignment.MiddleCenter;
                lblJudge.Font = new Font("Arial", 30, FontStyle.Bold);
                lbJudge.Add(lblJudge); 
                pnJudge.Controls.Add(lblJudge);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Fill;
                pnPic.Controls.Add(pictureBox);
                groupBox.Controls.Add(pnCode);
                groupBox.Controls.Add(pnPic);
                
                pnMaterials.Controls.Add(groupBox);

            }
        }
        private string GetLabelCode(string data)
        {
            string[] parts = data.Split('/');
            if (parts.Length >= 2)
            {
                return parts[1];
            }
            return "";
        }
        private void txtScan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                
                DoCheckAccessory(txtScan.Text);
                txtScan.Text = "";
            }
        }
        private bool Judge(string accessory)
        {
            for (int i = 0; i < lbAccessory.Count; i++)
            {
                if (lbAccessory[i].Text != "")
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
        private void ClearJudge()
        {
            Task.Delay(500).Wait();
            foreach(Label label in lbJudge)
            {
                ThreadHelperClass.SetText(this, label, "");
            }    
            //ThreadHelperClass.SetText(this, lbFinalJudge, "");
        }
        private string GetRemark()
        {
            return "";
        }
        private async void DoCheckAccessory(string d)
        {
            string data = GetLabelCode(d);
            if (Judge(data))
            {
                if (CheckJudgeStatus())
                {
                    lbFinalJudge.Text = "OK";
                    lbFinalJudge.ForeColor = Color.Lime;
                    dataGridView1.Rows.Insert(0, dataGridView1.Rows.Count, txtPartno.Text, "OK", DateTime.Now);
                    //save to CheckLabelHistory
                    try
                    {
                        await connect.ExeDataAsync($"Insert into CheckLabelHistory(Partno,Judge,JudgeTime,LineID) values('{partno}',1,getdate(),'{lineID}')");
                    }catch
                    {

                    }
                    //await Task.Run(() => ClearJudge());
                    txtScan.Enabled=false;
                    //Thread.Sleep(510);
                }
            }
            else
            {
                //if (CheckJudgeExisted())
                //{
                lbFinalJudge.Text = "NG";
                lbFinalJudge.ForeColor = Color.Red;
                dataGridView1.Rows.Insert(0, dataGridView1.Rows.Count, txtPartno.Text, "NG", DateTime.Now);
                //save to CheckLabelHistory
                try
                {
                    await connect.ExeDataAsync($"Insert into CheckLabelHistory(Partno,Judge,JudgeTime,Remark,LineID) values('{partno}',0,getdate(),'{d}','{lineID}')");
                }
                catch
                {

                }
                using (Notify frm = new Notify())
                {
                    frm.content = data;
                    frm.ShowDialog();
                }
                await Task.Run(() => ClearJudge());
                //}


            }

        }
    }
}
