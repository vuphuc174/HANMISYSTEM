using ExpanderApp;
using HANMISYSTEM.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
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
        private void MainFrm_Load(object sender, EventArgs e)
        {

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
        private void CreateAccordion()
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
            CreateContentLabel(expander1);
            accordion.Add(expander1);


            Expander expander2 = new Expander();
            expander2.BorderStyle = BorderStyle.FixedSingle;
            ExpanderHelper.CreateLabelHeader(expander2, Color.White, "Production Mgt", Color.FromArgb(128, 128, 255), HANMISYSTEM.Properties.Resources.Collapse1, HANMISYSTEM.Properties.Resources.Expand, 40, fontHeader);
            ProductionContentLabel(expander2);
            accordion.Add(expander2);

            Expander expander3 = new Expander();
            expander3.BorderStyle = BorderStyle.FixedSingle;
            ExpanderHelper.CreateLabelHeader(expander3, Color.White, "Spray Mgt", Color.FromArgb(128, 128, 255), HANMISYSTEM.Properties.Resources.Collapse1, HANMISYSTEM.Properties.Resources.Expand, 40, fontHeader);
            SprayContentLabel(expander3);
            accordion.Add(expander3);

            Expander expander4 = new Expander();
            expander4.BorderStyle = BorderStyle.FixedSingle;
            ExpanderHelper.CreateLabelHeader(expander4, Color.White, "Contacts", Color.FromArgb(128, 128, 255), HANMISYSTEM.Properties.Resources.Collapse1, HANMISYSTEM.Properties.Resources.Expand, 40, fontHeader);
            CreateContentLabel(expander4);
            accordion.Add(expander4);

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
        private void SprayContentLabel(Expander expander)
        {
            Font fontContent = new Font("Arial", 11);
            Panel panel = new Panel();
            MyButton btnStock = new MyButton();
            MyButton btnInput = new MyButton();
            MyButton btnOutput = new MyButton();

            //input
            btnInput.Text = "Input material warehouse";
            btnInput.Font = fontContent;
            btnInput.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnInput.Click += new EventHandler(btnInput_Click);
            //btnStock.Top = 90;
            panel.Controls.Add(btnInput);

            //output
            btnOutput.Text = "Output material warehouse";
            btnOutput.Font = fontContent;
            btnOutput.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnOutput.Click += new EventHandler(btnOutput_Click);
            btnOutput.Top = 30;
            panel.Controls.Add(btnOutput);

            //Stock
            btnStock.Text = "Inventory";
            btnStock.Font = fontContent;
            btnStock.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnStock.Click += new EventHandler(btnStock_Click);
            btnStock.Top = 60;
            panel.Controls.Add(btnStock);
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



            //styles
            btnForm1.Text = "Production";
            btnForm1.Font = fontContent;
            btnForm1.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnForm1.Click += new EventHandler(btnForm1_Click);
            panel.Controls.Add(btnForm1);

            //Production plan
            btnProductionPlan.Text = "Production Plan";
            btnProductionPlan.Font = fontContent;
            btnProductionPlan.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnProductionPlan.Click += new EventHandler(btnProductionPlan_Click);
            btnProductionPlan.Top = 30;
            panel.Controls.Add(btnProductionPlan);

            //Production History
            btnProductionHistory.Text = "Production History";
            btnProductionHistory.Font = fontContent;
            btnProductionHistory.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnProductionHistory.Click += new EventHandler(btnProduction_history_Click);
            btnProductionHistory.Top = 60;
            panel.Controls.Add(btnProductionHistory);
            //Stock
            btnStock.Text = "Inventory";
            btnStock.Font = fontContent;
            btnStock.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnStock.Click += new EventHandler(btnStock_Click);
            btnStock.Top = 90;
            panel.Controls.Add(btnStock);

            //packing mgt
            btnPacking.Text = "Packing Mgt";
            btnPacking.Font = fontContent;
            btnPacking.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            btnPacking.Click += new EventHandler(btnPacking_Click);
            btnPacking.Top = 120;
            panel.Controls.Add(btnPacking);

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
            StockMgt fr = new StockMgt();
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

    }
}
