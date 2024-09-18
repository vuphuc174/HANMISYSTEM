using HANMISYSTEM.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.Line
{
    public partial class Mapping : Form
    {
        public Mapping()
        {
            InitializeComponent();
        }
        DAO_Line dAO_Line = new DAO_Line();
        private async void Mapping_Load(object sender, EventArgs e)
        {
            DataTable dtLines = await dAO_Line.GetLines();
            DataTable dtMappingLines = await dAO_Line.GetMappingLine();
            if (dtLines.Rows.Count > 0)
            {
                for (int i = 0; i < dtLines.Rows.Count; i++)
                {
                    Panel panel = new Panel();
                    panel.BorderStyle = BorderStyle.FixedSingle;
                    panel.Size = new Size(450, 60);
                    panel.Padding = new Padding(5, 15, 5, 15);
                    flpLine.Controls.Add(panel);

                    FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                    flowLayoutPanel.Size = new Size(300, 35);
                    flowLayoutPanel.Dock = DockStyle.Fill;
                    panel.Controls.Add(flowLayoutPanel);

                    TextBox txtLineID = new TextBox();
                    txtLineID.BorderStyle = BorderStyle.FixedSingle;
                    txtLineID.Size = new Size(50, 50);
                    txtLineID.Text = dtLines.Rows[i]["idlocation"].ToString();
                    txtLineID.Enabled = false;
                    txtLineID.Dock = DockStyle.Left;

                    TextBox txtLineName = new TextBox();
                    txtLineName.BorderStyle = BorderStyle.FixedSingle;
                    txtLineName.Size = new Size(120, 50);
                    txtLineName.Text = dtLines.Rows[i]["namelocation1"].ToString();
                    txtLineName.Enabled = false;
                    txtLineID.Dock = DockStyle.Left;


                    TextBox txtLineID_Bravo = new TextBox();
                    txtLineID_Bravo.Name = "cbb" + i.ToString();
                    txtLineID_Bravo.Text = await dAO_Line.GetBravoLineIDByLineID(dtLines.Rows[i]["idlocation"].ToString());
                    txtLineID_Bravo.DoubleClick += new EventHandler(txtLineID_Bravo_DoubleClick);


                    Button btnSave = new Button();
                    btnSave.Text = "Save";
                    btnSave.Size = new Size(80, 30);


                    flowLayoutPanel.Controls.Add(txtLineID);
                    flowLayoutPanel.Controls.Add(txtLineName);
                    flowLayoutPanel.Controls.Add(txtLineID_Bravo);
                    flowLayoutPanel.Controls.Add(btnSave);

                }
                
            }
            
        }
        void txtLineID_Bravo_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("double click");
        }
    }
}
