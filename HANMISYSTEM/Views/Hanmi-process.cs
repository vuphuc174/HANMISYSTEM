using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HANMISYSTEM.Properties;
using Excel = Microsoft.Office.Interop.Excel;
using System.Globalization;
using System.Resources;
using HANMISYSTEM.Views;
using HANMISYSTEM.Views.RawMgt;
using HANMISYSTEM.Views.ReportViewer;
using HANMISYSTEM.Views.Accessory;
using HANMISYSTEM.Views.UPH;

namespace HANMISYSTEM
{
    public partial class Hanmi_process : Form
    {
        public Hanmi_process()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        CultureInfo culture;
        private void Hanmi_process_Load(object sender, EventArgs e)
        {
            lbuser.Text = HANMISYSTEM.Properties.Settings.Default.username;
        }


        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
            ResourceManager("HANMISYSTEM.lang.MyResource", typeof(Hanmi_process).Assembly);

            llimport.Text = rm.GetString("import", culture);
            llexport.Text = rm.GetString("export", culture);
            llstock.Text = rm.GetString("stock", culture);
            llstockfollowlocation.Text = rm.GetString("stockfollowlocation", culture);
            llreport.Text = rm.GetString("report", culture);
            llng.Text = rm.GetString("ngsinglepart", culture);
            lllost.Text = rm.GetString("lostmanagement", culture);
            lllocationmgt.Text = rm.GetString("locationmanagement", culture);

            llgoodsmgt.Text = rm.GetString("cargomanagement", culture);
            llpackingstandard.Text = rm.GetString("packingstandard", culture);
            llretail.Text = rm.GetString("retailimport", culture);
            llio.Text = rm.GetString("deliveryhistory", culture);

            llproduction.Text = rm.GetString("production", culture);
            llproductionplan.Text = rm.GetString("productionplan", culture);
            llstatus.Text = rm.GetString("status", culture);
            llproductionhistory.Text = rm.GetString("productionhistory", culture);

            lloverviewv1.Text = rm.GetString("overview", culture);
            lloverviewv2.Text = rm.GetString("overviewline", culture);
            lliohistory.Text = rm.GetString("deliveryhistory", culture);
            llbom.Text = rm.GetString("bom", culture);

            llstockproduction.Text = rm.GetString("stock", culture);
            llpackingproduction.Text = rm.GetString("packingstandard", culture);
            llngproduction.Text = rm.GetString("ngsinglepart", culture);
            llexportproduction.Text = rm.GetString("export", culture);
            lloverviewv3.Text = rm.GetString("overviewv2", culture);
            llcheckstock.Text = rm.GetString("checkinventory", culture);
            llproductionresult.Text = rm.GetString("productionresult",culture);
        }

       
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;
            Font drawFont = new Font("Arial", 9);
            g.FillRectangle(new SolidBrush(Color.Silver), e.Bounds);
            e.Graphics.DrawString("X", drawFont, Brushes.Red, e.Bounds.Right - 12, e.Bounds.Top + 4);

            e.Graphics.DrawString(this.tabcontrol1.TabPages[e.Index].Text, e.Font, Brushes.White, e.Bounds.Left + 1, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }
        static int checkexist(TabControl tabcontrolname,string tabname)
        {
            int temp = -1;
            for (int i = 0; i <  tabcontrolname.TabPages.Count; i++)
            {
                if (tabcontrolname.TabPages[i].Text == tabname)
                {
                    temp = i;
                    break;
                }
            }
            return temp;
        }

        public void TabCreating(TabControl TabControl, string Text, Form Form)
        {

            int Index = checkexist(TabControl, Text);

            if (Index >= 0)
            {

                TabControl.SelectedTab = TabControl.TabPages[Index];

                TabControl.SelectedTab.Text = Text;



            }

            else
            {

                TabPage TabPage = new TabPage { Text = Text };

                TabControl.TabPages.Add(TabPage);

                TabControl.SelectedTab = TabPage;



                Form.TopLevel = false;

                Form.Parent = TabPage;

                //  Form.MdiParent = this;

                Form.Show();

                Form.Dock = DockStyle.Fill;

            }

        }
        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.tabcontrol1.TabPages.Count; i++)
            {
                Rectangle r = tabcontrol1.GetTabRect(i);
                Rectangle closeButton = new Rectangle(r.Right - 12, r.Top + 4, 9, 7);
                if (closeButton.Contains(e.Location))

                {
                    if (tabcontrol1.TabPages[i].Text == "Production line")
                    {
                        if(HANMISYSTEM.Properties.Settings.Default.status=="CONTINUE")
                        {
                            MessageBox.Show("Stop line firstly");
                            break;
                        }
                        else
                        {
                            if (MessageBox.Show("Would you like to Close this Tab?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {

                                this.tabcontrol1.TabPages.RemoveAt(i);

                                break;

                            }
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Would you like to Close this Tab?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            this.tabcontrol1.TabPages.RemoveAt(i);

                            break;

                        }
                    }

                }
            }
        }

        private void Hanmi_process_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            login fr = new login();
            fr.Close();
            e.Cancel = true;
            frmprod fr1 = new frmprod();
            if (HANMISYSTEM.Properties.Settings.Default.status == "CONTINUE")
            {
                MessageBox.Show("Stop working firstly");
                fr1.btnpower.Text = "Stop line";
                fr1.timer1.Stop();
                connect.exedata("insert into productionhistory (idwarehouse,partno,idlocation,stoptime,remark) values ('" + fr1.cbwarehouse.SelectedValue + "','" + fr1.txtpartno.Text + "','" + fr1.cblocation.SelectedValue + "','" + DateTime.Now + "','Break time')");
                connect.exedata("update productionstatus set stoptime='" + DateTime.Now + "',lastesttarget='" + fr1.txttarget.Text + "' where idlocation='" + fr1.cblocation.SelectedValue + "' and partno='" + fr1.txtmodel.Text + "' and productiondate='" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
             
        }

        private void Hanmi_process_FormClosed(object sender, FormClosedEventArgs e)
        {
        }




   
      
      
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           //DataTable dt = connect.readdata("select * from tbl_user where username='" + lbuser.Text + "'");
           //if (dt.Rows[0]["idposition"].ToString() == "P1" || dt.Rows[0]["idposition"].ToString() == "P2" || dt.Rows[0]["location"].ToString() == "mat")
          // {
               panelwarehouse.Visible = true;
               panelproduction.Visible = false;
               panelsystem.Visible = false;
               paneldelivery.Visible = false;
               panelwarehouse.BringToFront();
          // }
//else
          // {
             //  MessageBox.Show("Ban khong co quyen vao day");
          // }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelproduction.Visible = true;
            panelwarehouse.Visible = false;
            panelsystem.Visible = false;
            paneldelivery.Visible = false;
        }

     

     
        private void Tabcontrol1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataTable dtuser = connect.readdata("select idposition from tbl_user where username ='"+lbuser.Text+"'");
            if (dtuser.Rows[0]["idposition"].ToString() == "P1" || dtuser.Rows[0]["idposition"].ToString() == "P2")
            {
                panelsystem.Visible = true;
                panelwarehouse.Visible = false;
                panelproduction.Visible = false;
                paneldelivery.Visible = false;
            }
            else
            {
                MessageBox.Show("Ban khong co quyen truy cap vao day!!!");
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelsystem.Visible = false;
            panelwarehouse.Visible = false;
            panelproduction.Visible = false;
            paneldelivery.Visible = true;
        }

        private void panelwarehouse_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelproduction_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbuser_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnoverviewline_Click(object sender, EventArgs e)
        {
            Overview_Line fr = new Overview_Line();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Overviewv2 fr = new Overviewv2();
            fr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ioform fr = new ioform();
            TabCreating(tabcontrol1, " Released/Received History", fr);
        }

        private void lblanguage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(lblanguage.Text=="vi-VN")
            {
                lblanguage.Text = "en-US";
                SetLanguage("en-US");
            }
            else
            {
                lblanguage.Text = "vi-VN";
                SetLanguage("vi-VN");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            checkinventory fr = new checkinventory();
            TabCreating(tabcontrol1, "Check Inventory", fr);
        }

        private void btnproductionresult_Click(object sender, EventArgs e)
        {
            ProductionResult fr = new ProductionResult();
            TabCreating(tabcontrol1, "Production result ", fr);
        }



        private void lllogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (HANMISYSTEM.Properties.Settings.Default.status == "CONTINUE")
            {
                MessageBox.Show("Stop working firstly");
            }
            else
            {
                this.Close();
                login fr = new login();
                fr.ShowDialog();
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            checkinventory fr = new checkinventory();
            TabCreating(tabcontrol1, "Check Inventory", fr);
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeliveryResultDetail fr = new DeliveryResultDetail();
            TabCreating(tabcontrol1, "Kết quả giao hàng chi tiết ", fr);
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Nhap_le fr = new Nhap_le();
            TabCreating(tabcontrol1, "Nhập lẻ ", fr);
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Packing_standard fr = new Packing_standard();
            TabCreating(tabcontrol1, "Packing Management", fr);
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GoodsMgt fr = new GoodsMgt();
            TabCreating(tabcontrol1, "Goods mgt", fr);
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Location_Mgt fr = new Location_Mgt();
            TabCreating(tabcontrol1, "Quản lý vị trí", fr);
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Lost_Management fr = new Lost_Management();
            TabCreating(tabcontrol1, "Lost management", fr);
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NG_Singlepart fr = new NG_Singlepart();
            TabCreating(tabcontrol1, "NG single part", fr);
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReportWH fr = new ReportWH();
            TabCreating(tabcontrol1, "Report WH", fr);
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StockFollowLoction fr = new StockFollowLoction();
            TabCreating(tabcontrol1, "Tồn kho theo vị trí ", fr);
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StockMgt fr = new StockMgt();
            TabCreating(tabcontrol1, "Stock management", fr);
        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Deliverygoods fr = new Deliverygoods();
            TabCreating(tabcontrol1, "Delivery goods", fr);
        }

        private void linkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inproduction fr = new inproduction();
            TabCreating(tabcontrol1, "In warehouse", fr);
        }

        private void llbomv2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bomv2 fr = new bomv2();
            TabCreating(tabcontrol1, "Định mức nguên vật liệu", fr);
        }

        private void llbomdb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bomdaiban fr = new bomdaiban();
            TabCreating(tabcontrol1, "Định mức nguên vật liệu", fr);
        }

        private void llwarehousemgt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Warehousemgt fr = new Warehousemgt();
            TabCreating(tabcontrol1, "Warehouse management", fr);
        }

        private void llusermgt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Usermgt fr = new Usermgt();
            TabCreating(tabcontrol1, "USer permission", fr);
        }

        private void llproduction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataTable dt = connect.readdata("select * from tbl_user where username='" + lbuser.Text + "'");
            if (dt.Rows[0]["permission"].ToString() == "1" || dt.Rows[0]["permission"].ToString() == "2" && dt.Rows[0]["location"].ToString() != "mat")
            {
                frmprod fr = new frmprod();
                TabCreating(tabcontrol1, "Production line", fr);
            }
            else
            {
                MessageBox.Show("You dont have permission ");
            }
        }

        private void llproductionplan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataTable dt = connect.readdata("select * from tbl_user where username='" + lbuser.Text + "'");
            if (dt.Rows[0]["permission"].ToString() == "1" || dt.Rows[0]["permission"].ToString() == "2")
            {
                productionplan fr = new productionplan();
                TabCreating(tabcontrol1, "Production Plan", fr);
            }
            else
            {
                MessageBox.Show("You dont have permission ");
            }
        }

        private void llstatus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            productionstatus fr = new productionstatus();
            fr.Show();
        }

        private void llproductionhistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Production_history fr = new Production_history();
            TabCreating(tabcontrol1, "Production_history", fr);
        }

        private void lloverview2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Overview_Line fr = new Overview_Line();
            fr.Show();
        }

        private void lloverviewv1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Overview1 fr = new Overview1();
            fr.Show();
        }

        private void lliohistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ioform fr = new ioform();
            TabCreating(tabcontrol1, " Released/Received History", fr);
        }

        private void llbom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bom fr = new bom();
            TabCreating(tabcontrol1, "BOM mgt", fr);
        }

        private void llstockproduction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StockMgt fr = new StockMgt();
            TabCreating(tabcontrol1, "Stock management", fr);
        }

        private void llpackingproduction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Packing_standard fr = new Packing_standard();
            TabCreating(tabcontrol1, "Packing Management", fr);
        }

        private void llngproduciton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NG_Singlepart fr = new NG_Singlepart();
            TabCreating(tabcontrol1, "NG single part", fr);
        }

        private void llexportproduction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataTable dt = connect.readdata("select * from tbl_user where username='" + lbuser.Text + "'");
            if (dt.Rows[0]["permission"].ToString() == "1" || dt.Rows[0]["permission"].ToString() == "2")
            {
                Deliverygoods fr = new Deliverygoods();
                TabCreating(tabcontrol1, "Delivery goods", fr);
            }
            else
            {
                MessageBox.Show("You dont have permission ");
            }
        }

        private void lloverviewv3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Overviewv2 fr = new Overviewv2();
            fr.Show();
        }

        private void llproductionresult_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductionResult fr = new ProductionResult();
            TabCreating(tabcontrol1, "Production result ", fr);
        }

        private void kêtQuảSảnXuấtTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductionResultByDate fr = new ProductionResultByDate();
            TabCreating(tabcontrol1, "Kết quả sản xuất theo ngày ", fr);
        }

        private void llDeliveryPlan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeliveryPlanForm fr = new DeliveryPlanForm();
            TabCreating(tabcontrol1, "Kế hoạch giao hành ", fr);
        }

        private void llDeliveryIOStatus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeliveryResultForm fr = new DeliveryResultForm();
            fr.Show();
        }

        private void llio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ioform fr = new ioform();
            TabCreating(tabcontrol1, "Lịch sử xuất nhập", fr);
        }

        private void sửaSốLượngĐóngGóiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeBoxQty fr = new ChangeBoxQty();
            TabCreating(tabcontrol1, "Sửa số lượng đóng gói ",fr);
        }

        private void linkLabel5_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BOMList fr = new BOMList();
            TabCreating(tabcontrol1, "Thiết kế BOM", fr);
        }

        private void llreturnsupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReturnSupplier fr = new ReturnSupplier();
            TabCreating(tabcontrol1, "Xử lý hàng lỗi", fr);
        }

        private void qCKiểmTraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QCCheck fr = new QCCheck();
            TabCreating(tabcontrol1, "Kiểm tra chất lượng", fr);
        }

        private void xửLíHàngLỗiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnSupplier fr = new ReturnSupplier();
            TabCreating(tabcontrol1, "Xử lý hàng lỗi", fr);
        }

        private void xuấtNhậpTồnChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IOReport fr = new IOReport();
            TabCreating(tabcontrol1, "Xử lý hàng lỗi", fr);
        }

        private void kiểmTraTrạngTháiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OverView fr = new OverView();
            fr.Show();
        }

        private void đăngKýLáiXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriverMgt fr = new DriverMgt();
            fr.Show();
        }

        private void máyTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator fr = new Calculator();
            fr.Show();
        }

        private void checkAccessoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckAccessory fr = new CheckAccessory();
            fr.Show();
        }

        private void đăngKýAccessoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterAccessory fr = new RegisterAccessory();
            fr.Show();
        }

        private void trackingUPHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrackingUPH fr = new TrackingUPH();
            TabCreating(tabcontrol1, "Tracking UPH", fr);
        }

        private void lịchSửXuấtNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseAndReceiveHistory fr = new ReleaseAndReceiveHistory();
            TabCreating(tabcontrol1, "ReleaseAndReceiveHistory", fr);
        }
    }
}
