using ExpanderApp;
using HANMISYSTEM.Module;
using HANMISYSTEM.Views;
using HANMISYSTEM.Views.Accessory;
using HANMISYSTEM.Views.Spray;
using HANMISYSTEM.Views.UPH;
using HANMISYSTEM.Views.Warehouse;
using HANMISYSTEM.Views.WorkOrder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM
{
    public partial class MainFrm : Form
    {
        public int request;

        private Rectangle myTabRect;
        private Rectangle myInsideRect;
        private Rectangle myOutsideRect;
        public MainFrm()
        {
            DataTable dtwarehouse = dbconnect.readdata("select t.idwarehouse,w.namewarehouse from tbl_user t inner join warehouse w on t.idwarehouse=w.idwarehouse where username='" + HANMISYSTEM.Properties.Settings.Default.username + "'");
            if (dtwarehouse.Rows.Count > 0)
            {
                request = dbconnect.countdata("select count(idslipout) from slipout where idcustomer='" + dtwarehouse.Rows[0]["idwarehouse"].ToString() + "' and status ='Pending'");

            }
            InitializeComponent();
            CreateAccordion();
            TimeUpdater();

        }
  
        
        Dbconnect dbconnect = new Dbconnect();
        async void TimeUpdater()
        {
            while (true)
            {
                lbcurdate.Text = DateTime.Now.ToString();
                await Task.Delay(1000);
            }
        }
        int expanderWidth = 250;
        SerialPort serialPort = new SerialPort(HANMISYSTEM.Properties.Settings.Default.comport, Convert.ToInt32(HANMISYSTEM.Properties.Settings.Default.baudrate));
        private void MainFrm_Load(object sender, EventArgs e)
        {
            //User name
            toolStripDropDownButton3.Text = HANMISYSTEM.Properties.Settings.Default.username;
            //server name
            lbServerName.Text= HANMISYSTEM.Properties.Settings.Default.servername;
            //off relay 
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                }
                //serialPort.WriteLine('\n' + "@R0" + '\r');
                //Thread.Sleep(10);
                //serialPort.WriteLine('\n' + "@Y0" + '\r');
                //Thread.Sleep(10);
                //serialPort.WriteLine('\n' + "@G1" + '\r');
                //Thread.Sleep(10);
                //serialPort.WriteLine('\n' + "@B0" + '\r');
                //var chanel1 = new byte[] { 0x55, 0x56, 0x00, 0x00, 0x00, 0x01, 0x02, 0xAE };
                //serialPort.Write(chanel1, 0, chanel1.Length);
              
                    var chanel1 = new byte[] { 0x55, 0x56, 0x00, 0x00, 0x00, 0x01, 0x02, 0xAE };
                    serialPort.Write(chanel1, 0, chanel1.Length);
             
                    var chanel2 = new byte[] { 0x55, 0x56, 0x00, 0x00, 0x00, 0x02, 0x02, 0xAF };
                    serialPort.Write(chanel2, 0, chanel2.Length);
              

                serialPort.Close();
            }
            catch
            {
            }
        }

        static int checkexist(TabControl tabcontrolname, string tabname)
        {
            int temp = -1;
            for (int i = 0; i < tabcontrolname.TabPages.Count; i++)
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

                myTabRect = tabcontrol1.GetTabRect(0);
                
                //myInsideRect = new Rectangle(tabcontrol1.DisplayRectangle.X - 1, tabcontrol1.DisplayRectangle.Y - 1, tabcontrol1.DisplayRectangle.Width + 1, tabcontrol1.DisplayRectangle.Height + 1);
                //myOutsideRect = tabcontrol1.ClientRectangle;
                //myOutsideRect.Width--;
                //myOutsideRect.Height--;
                //tabcontrol1.DrawItem += new DrawItemEventHandler(OnDrawItem);
                Form.TopLevel = false;

                Form.Parent = TabPage;
                Form.Show();
                Form.Dock = DockStyle.Fill;

            }
        }
        private void OnDrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw your tab graphics here
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Blue);
            g.DrawRectangle(p, myTabRect);

            ////border of the tabpage
            //p = new Pen(Color.Yellow);
            //g.DrawRectangle(p, myInsideRect);

            ////border outside of the tabpage
            //p = new Pen(Color.Red);
            //g.DrawRectangle(p, myOutsideRect);

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
                        if (HANMISYSTEM.Properties.Settings.Default.status == "CONTINUE")
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
        public void CreateAccordion()
        {
            PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            Font fontHeader = new Font("Arial", 13, FontStyle.Bold);

            Accordion accordion = new Accordion();

            accordion.Size = new Size(270, 100);
            accordion.Dock = DockStyle.Left;
            //header 1
            Expander expander1 = new Expander();
            expander1.BorderStyle = BorderStyle.FixedSingle;
            ExpanderHelper.CreateLabelHeader(expander1, Color.White, "Delivery", Color.FromArgb(128, 128, 255), HANMISYSTEM.Properties.Resources.Collapse1, HANMISYSTEM.Properties.Resources.Expand, 40, fontHeader);
            DeliveryLabelContent(expander1);
            accordion.Add(expander1);


            Expander expander2 = new Expander();
            expander2.BorderStyle = BorderStyle.FixedSingle;
            ExpanderHelper.CreateLabelHeader(expander2, Color.White, "Production MGT", Color.FromArgb(128, 128, 255), HANMISYSTEM.Properties.Resources.Collapse1, HANMISYSTEM.Properties.Resources.Expand, 40, fontHeader);
            ProductionContentLabel(expander2);
            accordion.Add(expander2);

            Expander expander3 = new Expander();
            expander3.BorderStyle = BorderStyle.FixedSingle;
            ExpanderHelper.CreateLabelHeader(expander3, Color.White, "Spray MGT", Color.FromArgb(128, 128, 255), HANMISYSTEM.Properties.Resources.Collapse1, HANMISYSTEM.Properties.Resources.Expand, 40, fontHeader);
            SprayContentLabel(expander3);
            accordion.Add(expander3);

            Expander expander4 = new Expander();
            expander4.BorderStyle = BorderStyle.FixedSingle;
            ExpanderHelper.CreateLabelHeader(expander4, Color.White, "Quản lý kho", Color.FromArgb(128, 128, 255), HANMISYSTEM.Properties.Resources.Collapse1, HANMISYSTEM.Properties.Resources.Expand, 40, fontHeader);
            MaterialContentLabel(expander4);
            accordion.Add(expander4);

            Expander expander5 = new Expander();
            expander5.BorderStyle = BorderStyle.FixedSingle;
            ExpanderHelper.CreateLabelHeader(expander5, Color.White, "Cài đặt", Color.FromArgb(128, 128, 255), HANMISYSTEM.Properties.Resources.Collapse1, HANMISYSTEM.Properties.Resources.Expand, 40, fontHeader);
            ConfigurationLabelContent(expander5);
            accordion.Add(expander5);

            this.Controls.Add(accordion);
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

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Deliverygoods fr = new Deliverygoods();
            TabCreating(tabcontrol1, "Delivery goods", fr);
        }
        public System.Windows.Forms.TabControl MainTabControl
        {
            get
            {
                return tabcontrol1;
            }
        }
        public void DoCreateTab(string title,Form form)
        {
            TabCreating(tabcontrol1, title, form);
        }
        private void DeliveryLabelContent(Expander expander)
        {
            Font fontContent = new Font("Arial", 11);
            Panel panel = new Panel();
            MyButton btnStock = new MyButton();
            MyButton btnInput = new MyButton();
            MyButton btnOutput = new MyButton();
            //
            //input
            btnInput.Text = "Nhập kho NVL";
            btnInput.Font = fontContent;
            btnInput.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnInput.Click += new EventHandler(btnInput_Click);
            panel.Controls.Add(btnInput);
            //output
            btnOutput.Text = "Xuất kho";
            btnOutput.Font = fontContent;
            btnOutput.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnOutput.Click += new EventHandler(btnOutput_Click);
            btnOutput.Top = 30;
            panel.Controls.Add(btnOutput);

            //Stock
            btnStock.Text = "Tồn kho";
            btnStock.Font = fontContent;
            btnStock.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnStock.Click += new EventHandler(btnStock_Click);
            btnStock.Top = 60;
            panel.Controls.Add(btnStock);
            //
            panel.Size = new System.Drawing.Size(expanderWidth - 10, 300);
            panel.Left = 10;
            expander.Content = panel;
        }
        private void ConfigurationLabelContent(Expander expander)
        {
            Font fontContent = new Font("Arial", 11);
            Panel panel = new Panel();

            //
            MyButton btnProduct = new MyButton();
            MyButton btnWarehouse = new MyButton();
            MyButton btnRegisterAccessory = new MyButton();
            MyButton btnUsermgt = new MyButton();

            //product
            btnProduct.Text = "Quản lí mặt hàng";
            btnProduct.Font = fontContent;
            btnProduct.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnProduct.Click += new EventHandler(btnProduct_Click);
            panel.Controls.Add(btnProduct);
            //warehouse
            btnWarehouse.Text = "Quản lí kho";
            btnWarehouse.Font = fontContent;
            btnWarehouse.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnWarehouse.Click += new EventHandler(btnWarehouse_Click);
            btnWarehouse.Top = 30;
            panel.Controls.Add(btnWarehouse);


            //warehouse
            btnRegisterAccessory.Text = "Dang ky accessory";
            btnRegisterAccessory.Font = fontContent;
            btnRegisterAccessory.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnRegisterAccessory.Click += new EventHandler(btnRegisterAccessory_Click);
            btnRegisterAccessory.Top = 60;
            panel.Controls.Add(btnRegisterAccessory);

            //User mgt
            btnUsermgt.Text = "Quản lý User";
            btnUsermgt.Font = fontContent;
            btnUsermgt.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnUsermgt.Click += new EventHandler(btnUsermgt_Click);
            btnUsermgt.Top = 90;
            panel.Controls.Add(btnUsermgt);
            //
            panel.Size = new System.Drawing.Size(expanderWidth - 10, 300);
            panel.Left = 10;
            expander.Content = panel;
        }
        public void MaterialContentLabel(Expander expander)
        {
            Font fontContent = new Font("Arial", 11);
            Panel panel = new Panel();
            
            MyButton btnStock = new MyButton();
            MyButton btnInput = new MyButton();
            MyButton btnOutput = new MyButton();
            MyButton btnStockBaseOnLocation = new MyButton();
            MyButton btnReceiveAndReleaseHistory = new MyButton();
            MyButton btnIofrom = new MyButton();
            MyButton btnApproval = new MyButton();
            //input
            btnInput.Text = "Nhập kho NVL";
            btnInput.Font = fontContent;
            btnInput.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnInput.Click += new EventHandler(btnInput_Click);
            panel.Controls.Add(btnInput);
            //output
            btnOutput.Text = "Xuất kho";
            btnOutput.Font = fontContent;
            btnOutput.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnOutput.Click += new EventHandler(btnOutput_Click);
            btnOutput.Top = 30;
            panel.Controls.Add(btnOutput);

            //Stock
            btnStock.Text = "Tồn kho";
            btnStock.Font = fontContent;
            btnStock.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnStock.Click += new EventHandler(btnStock_Click);
            btnStock.Top = 60;
            panel.Controls.Add(btnStock);
            


            //Stock base on location
            btnStockBaseOnLocation.Text = "Tồn kho theo vị trí";
            btnStockBaseOnLocation.Font = fontContent;
            btnStockBaseOnLocation.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnStockBaseOnLocation.Click += new EventHandler(btnStockBaseOnLocation_Click);
            btnStockBaseOnLocation.Top = 90;
            panel.Controls.Add(btnStockBaseOnLocation);
         

            //Receive and Release History
            btnReceiveAndReleaseHistory.Text = "In phiếu nhập xuất";
            btnReceiveAndReleaseHistory.Font = fontContent;
            btnReceiveAndReleaseHistory.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnReceiveAndReleaseHistory.Click += new EventHandler(btnReceiveAndReleaseHistory_Click);
            btnReceiveAndReleaseHistory.Top = 120;
            panel.Controls.Add(btnReceiveAndReleaseHistory);

            //IOForm 
            btnIofrom.Text = "Lịch sử xuất nhập";
            btnIofrom.Font = fontContent;
            btnIofrom.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnIofrom.Click += new EventHandler(btnIofrom_Click);
            btnIofrom.Top = 150;
            panel.Controls.Add(btnIofrom);

            //Approval
            btnApproval.Text = "Yêu cầu xác nhận (" + request + ")" ;
            btnApproval.Font = fontContent;
            btnApproval.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnApproval.Click += new EventHandler(btnApproval_Click);
            btnApproval.Top = 180;
            panel.Controls.Add(btnApproval);

            panel.Size = new System.Drawing.Size(expanderWidth - 10, 300);
            panel.Left = 10;
            expander.Content = panel;
        }
        private void SprayContentLabel(Expander expander)
        {
            Font fontContent = new Font("Arial", 11);
            Panel panel = new Panel();
            MyButton btnStock = new MyButton();
            MyButton btnInput = new MyButton();
            MyButton btnOutput = new MyButton();
            MyButton btnS_FactoryFrm = new MyButton();
            MyButton btnSprayPlan = new MyButton();

            //input
            btnInput.Text = "Nhập kho NVL";
            btnInput.Font = fontContent;
            btnInput.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnInput.Click += new EventHandler(btnInput_Click);
            //btnStock.Top = 90;
            panel.Controls.Add(btnInput);

            //output
            btnOutput.Text = "Xuất kho";
            btnOutput.Font = fontContent;
            btnOutput.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnOutput.Click += new EventHandler(btnOutput_Click);
            btnOutput.Top = 30;
            panel.Controls.Add(btnOutput);

            //Stock
            btnStock.Text = "Tồn kho";
            btnStock.Font = fontContent;
            btnStock.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnStock.Click += new EventHandler(btnStock_Click);
            btnStock.Top = 60;
            panel.Controls.Add(btnStock);
            panel.Size = new System.Drawing.Size(expanderWidth - 10, 300);

            //Spray produre 
            btnS_FactoryFrm.Text = "Nhập thành phẩm sơn";
            btnS_FactoryFrm.Font = fontContent;
            btnS_FactoryFrm.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnS_FactoryFrm.Click += new EventHandler(btnS_FactoryFrm_Click);
            btnS_FactoryFrm.Top = 90;
            panel.Controls.Add(btnS_FactoryFrm);
            panel.Size = new System.Drawing.Size(expanderWidth - 10, 300);

            //Spray plan 
            btnSprayPlan.Text = "Kế hoạch";
            btnSprayPlan.Font = fontContent;
            btnSprayPlan.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnSprayPlan.Click += new EventHandler(btnSprayPlan_Click);
            btnSprayPlan.Top = 120;
            panel.Controls.Add(btnSprayPlan);
            panel.Size = new System.Drawing.Size(expanderWidth - 10, 300);

            panel.Left = 10;
            expander.Content = panel;
        }
        private void ProductionContentLabel(Expander expander)
        {
            Font fontContent = new Font("Arial", 11);
            Panel panel = new Panel();
           

            MyButton btnForm1 = new MyButton();
            MyButton btnProductionPlan = new MyButton();
            MyButton btnProductionHistory = new MyButton();
            MyButton btnStock = new MyButton();
            MyButton btnPacking = new MyButton();
            MyButton btnWorkOrderResult = new MyButton();
            MyButton btnCheckAccessory = new MyButton();


            //styles
            btnForm1.Text = "Lắp ráp";
            btnForm1.Font = fontContent;
            btnForm1.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnForm1.Click += new EventHandler(btnForm1_Click);
            panel.Controls.Add(btnForm1);

            //Production plan
            btnProductionPlan.Text = "Kế hoạch";
            btnProductionPlan.Font = fontContent;
            btnProductionPlan.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnProductionPlan.Click += new EventHandler(btnProductionPlan_Click);
            btnProductionPlan.Top = 30;
            panel.Controls.Add(btnProductionPlan);

            //Production History
            btnProductionHistory.Text = "Lịch sử sản xuất";
            btnProductionHistory.Font = fontContent;
            btnProductionHistory.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnProductionHistory.Click += new EventHandler(btnProduction_history_Click);
            btnProductionHistory.Top = 60;
            panel.Controls.Add(btnProductionHistory);
            //Stock
            btnStock.Text = "Tồn kho";
            btnStock.Font = fontContent;
            btnStock.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnStock.Click += new EventHandler(btnStock_Click);
            btnStock.Top = 90;
            panel.Controls.Add(btnStock);

            //packing mgt
            btnPacking.Text = "Quản lý đóng gói";
            btnPacking.Font = fontContent;
            btnPacking.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnPacking.Click += new EventHandler(btnPacking_Click);
            btnPacking.Top = 120;
            panel.Controls.Add(btnPacking);

            //WorkOrder Result 
            btnWorkOrderResult.Text = "Quản lý W/O";
            btnWorkOrderResult.Font = fontContent;
            btnWorkOrderResult.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnWorkOrderResult.Click += new EventHandler(btnWorkOrderResult_Click);
            btnWorkOrderResult.Top = 150;
            panel.Controls.Add(btnWorkOrderResult);

            //Check Acessory
            btnCheckAccessory.Text = "Kiểm tra Accessory";
            btnCheckAccessory.Font = fontContent;
            btnCheckAccessory.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnCheckAccessory.Click += new EventHandler(btnCheckAccessory_Click);
            btnCheckAccessory.Top = 180;
            panel.Controls.Add(btnCheckAccessory);

            panel.Size = new System.Drawing.Size(expanderWidth - 10, 300);
            panel.Left = 10;
            expander.Content = panel;
        }
        
        private void CreateContentLabel(Expander expander)
        {
            Font fontContent = new Font("Arial", 11);
            Panel panel = new Panel();
            MyButton buttonContent = new MyButton();
            Button buttonContent1 = new Button();

            //styles
            buttonContent.Text = "Xuất kho";
            buttonContent.Font = fontContent;
            buttonContent.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            buttonContent.Click += new EventHandler(buttonContent_Click);
            panel.Controls.Add(buttonContent);

            //button 2
            buttonContent1.FlatStyle = FlatStyle.Flat;
            buttonContent1.Top = 30;
            buttonContent1.FlatAppearance.BorderSize = 0;
            buttonContent1.TextAlign = ContentAlignment.MiddleLeft;
            buttonContent1.Text = "Xuất kho";
            buttonContent1.ForeColor = Color.FromArgb(166, 166, 166);
            buttonContent1.Font = fontContent;
            buttonContent1.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            buttonContent1.Click += new EventHandler(buttonContent1_Click);
            panel.Controls.Add(buttonContent1);
            //buttonContent1.Text = "Tồn kho";
            //buttonContent1.Top = 30;
            //buttonContent1.Size = new System.Drawing.Size(expanderWidth-10, 30);
            //panel.Controls.Add(buttonContent1);

            panel.Size = new System.Drawing.Size(expanderWidth - 10, 300);
            panel.Left = 10;
            expander.Content = panel;

        }


        //button enven click
        private void btnUsermgt_Click(object sender,EventArgs e)
        {
            Usermgt fr = new Usermgt();
            TabCreating(tabcontrol1, "Quản lý User", fr);
        }
        private void btnApproval_Click(object sender,EventArgs e)
        {
            ApprovalFrm fr = new ApprovalFrm();
            TabCreating(tabcontrol1, "Yêu cầu xác nhận", fr);
        }
        private void btnIofrom_Click(object sender,EventArgs e)
        {
            ioform fr = new ioform();
            TabCreating(tabcontrol1, "Lịch sử xuất nhập", fr);
        }
        private void btnRegisterAccessory_Click(object sender, EventArgs e)
        {
            RegisterAccessory fr = new RegisterAccessory();
            TabCreating(tabcontrol1, "Đăng ký Accessory", fr);
        }
        private void btnCheckAccessory_Click(object sender, EventArgs e)
        {
            CheckAccessory fr = new CheckAccessory();
            fr.Show();
            //TabCreating(tabcontrol1, "Kiem tra Accessory", fr);
        }
        private void btnWorkOrderResult_Click(object sender,EventArgs e)
        {
            WorkOrderResult fr = new WorkOrderResult();
            TabCreating(tabcontrol1, "Ket qua Sx", fr);
        }
        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            Warehousemgt fr = new Warehousemgt();
            TabCreating(tabcontrol1, "Quản lý kho", fr);
        }

        private void btnProduct_Click(object sender ,EventArgs e)
        {
            GoodsMgt fr = new GoodsMgt();
            TabCreating(tabcontrol1, "Quản lý mặt hàng", fr);
        }
        private void btnReceiveAndReleaseHistory_Click(object sender,EventArgs e)
        {
            ReleaseAndReceiveHistory fr = new ReleaseAndReceiveHistory();
            TabCreating(tabcontrol1, "Lịch sử xuất nhập", fr);
        }
        private void btnStockBaseOnLocation_Click(object sender ,EventArgs e)
        {
            StockFollowLoction fr = new StockFollowLoction();
            TabCreating(tabcontrol1, "Tồn kho theo vị trí", fr);
        }
        private void btnSprayPlan_Click(object sender,EventArgs e)
        {
            SprayPlan fr = new SprayPlan();
            TabCreating(tabcontrol1, "Spray Plan", fr);
        }
        private void btnS_FactoryFrm_Click(object sender,EventArgs e )
        {
            S_FactoryFrm fr = new S_FactoryFrm();
            TabCreating(tabcontrol1, "Spray Factory", fr);
        }
        private void btnInput_Click(object sender,EventArgs e)
        {
            inproduction fr = new inproduction();
            TabCreating(tabcontrol1, "Input material mgt", fr);
        }
        private void btnOutput_Click(object sender, EventArgs e)
        {
            Deliverygoods fr = new Deliverygoods();
            TabCreating(tabcontrol1, "Out material mgt", fr);
        }
        private void btnPacking_Click(object sender, EventArgs e)
        {
            Packing_standard fr = new Packing_standard();
            TabCreating(tabcontrol1, "Packing mgt", fr);
        }
        private void btnStock_Click(object sender ,EventArgs e)
        {
            Warehouse_dashboard fr = new Warehouse_dashboard();
            fr.MainFormRef = this;
            TabCreating(tabcontrol1, "Inventory", fr);
        }
        private void btnProduction_history_Click(object sender, EventArgs e)
        {
            Production_history fr = new Production_history();
            TabCreating(tabcontrol1, "Production history", fr);
        }
        private void btnForm1_Click(object sender,EventArgs e)
        {
            frmprod fr = new frmprod();
            TabCreating(tabcontrol1, "Production", fr);
        }
        private void btnProductionPlan_Click(object sender, EventArgs e)
        {
            productionplan fr = new productionplan();
            TabCreating(tabcontrol1, "Production Plan", fr);
        }
        private void btnProductionHistory_Click(object sender, EventArgs e)
        {
            Production_history fr = new Production_history();
            TabCreating(tabcontrol1, "Production History", fr);
        }
        private void buttonContent_Click(object sender, EventArgs e)
        {
            Deliverygoods fr = new Deliverygoods();
            TabCreating(tabcontrol1, "Delivery goods", fr);
        }
        private void buttonContent1_Click(object sender, EventArgs e)
        {
            ioform fr = new ioform();
            TabCreating(tabcontrol1, "aaaa", fr);
        }

        private void logoutToolTip_Click(object sender, EventArgs e)
        {
            this.Close();
            login fr = new login();
            fr.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void kếtQuảSảnXuấtTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductionResultByDate fr = new ProductionResultByDate();
            TabCreating(tabcontrol1, "Kết quả sản xuất theo ngày", fr);
        }

        private void xuấtNhậpTồnChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportWH fr = new ReportWH();
            TabCreating(tabcontrol1, "Xuất nhập tồn chi tiết", fr);
        }

        private void kếtQuảSảnXuấtTheoNgàyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductionResultByDate fr = new ProductionResultByDate();
            TabCreating(tabcontrol1, "Kết quả sản xuất theo ngày", fr);
        }

        private void trackingUPHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrackingUPH fr = new TrackingUPH();
            TabCreating(tabcontrol1, "Theo dõi UPH", fr);
        }

        private void sửaSốLượngĐóngGóiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeBoxQty fr = new ChangeBoxQty();
            TabCreating(tabcontrol1, "Sửa số lượng đóng gói", fr);
        }
    }
}
