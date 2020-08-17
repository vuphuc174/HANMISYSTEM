using ExpanderApp;
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


        }
        int expanderWidth = 250;
        private void MainFrm_Load(object sender, EventArgs e)
        {
            
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
            Font fontHeader = new Font("Arial",13,FontStyle.Bold);
            
            Accordion accordion = new Accordion();
            accordion.Size = new Size(250, 100);
            accordion.Dock = DockStyle.Left;
            //header 1
            Expander expander1 = new Expander();
            expander1.BorderStyle = BorderStyle.FixedSingle;
            ExpanderHelper.CreateLabelHeader(expander1, "Delivery", Color.White,HANMISYSTEM.Properties.Resources.Collapse1, HANMISYSTEM.Properties.Resources.Expand,40,fontHeader);
            CreateContentLabel(expander1);
            accordion.Add(expander1);


            Expander expander2 = new Expander();
            expander2.BorderStyle = BorderStyle.FixedSingle;
            ExpanderHelper.CreateLabelHeader(expander2, "Calendar", SystemColors.ActiveBorder, HANMISYSTEM.Properties.Resources.Collapse1, HANMISYSTEM.Properties.Resources.Expand);
            CreateContentLabel(expander2);
            accordion.Add(expander2);

            Expander expander3 = new Expander();
            expander3.BorderStyle = BorderStyle.FixedSingle;
            ExpanderHelper.CreateLabelHeader(expander3, "Contacts", SystemColors.ActiveBorder, HANMISYSTEM.Properties.Resources.Collapse1, HANMISYSTEM.Properties.Resources.Expand);
            CreateContentLabel(expander3);
            accordion.Add(expander3);

            this.Controls.Add(accordion);
        }

        private void CreateContentLabel(Expander expander)
        {
            Font fontContent = new Font("Arial", 11);
            Panel panel = new Panel();
            Button buttonContent = new Button();
            Button buttonContent1 = new Button();

            //styles
            buttonContent.FlatStyle = FlatStyle.Flat;
            buttonContent.FlatAppearance.BorderSize = 0;
            buttonContent.TextAlign = ContentAlignment.MiddleLeft;
            buttonContent.Text = "Xuất kho";
            buttonContent.ForeColor = Color.FromArgb(166, 166, 166);
            buttonContent.Font = fontContent;
            buttonContent.Size = new System.Drawing.Size(expanderWidth - 10, 30);
            buttonContent.Click += new EventHandler(buttonContent_Click);
            panel.Controls.Add(buttonContent);

            buttonContent1.Text = "Tồn kho";
            buttonContent1.Top = 30;
            buttonContent1.Size = new System.Drawing.Size(expanderWidth-10, 30);
            panel.Controls.Add(buttonContent1);

            panel.Size = new System.Drawing.Size(expanderWidth-10, 300);
            panel.Left = 10;
            expander.Content = panel;

        }
        private void buttonContent_Click(object sender, EventArgs e)
        {
                Deliverygoods fr = new Deliverygoods();
                TabCreating(tabcontrol1, "Delivery goods", fr);
        }

    }
}
