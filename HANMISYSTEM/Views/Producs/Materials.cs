using HANMISYSTEM.Views.Production;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.Producs
{
    public partial class Materials : Form
    {
        public Materials()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private void txtPartno_TextChanged(object sender, EventArgs e)
        {
            txtPartName.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPartno.Text))
            {
                using (Searching frm = new Searching())
                {
                    frm.ShowInTaskbar = false;
                    frm.StartPosition = FormStartPosition.CenterParent ;
                    //MessageBox.Show("X" + txtPartno.Location.X.ToString() + "-----Y:" + txtPartno.Location.Y.ToString());
                    frm.searchTerm = txtPartno.Text;
                    frm.ShowDialog();
                    txtPartno.Text = frm.PartNo();
                    txtPartName.Text = frm.PartName();
                    LoadMaterials();
                }
            }
        }
        private void addClick(object sender,EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtPartName.Text))
            {
                AddMaterial addMaterial = new AddMaterial();
                addMaterial.ShowInTaskbar = false;
                addMaterial.StartPosition = FormStartPosition.CenterParent;
                addMaterial.parrent_partno = txtPartno.Text;
                addMaterial.ShowDialog();
                LoadMaterials();
            }
        }

        private void LoadMaterials()
        {
            pnMaterials.Controls.Clear();
            DataTable dtAccessory = connect.readdata($"select a.Accessory from Accessory a inner join cargo c on a.Accessory= c.partno where A.partno='{txtPartno.Text}'");
            if(dtAccessory.Rows.Count > 0)
            {
                for(int i =0;i<dtAccessory.Rows.Count;i++)
                {
                    Panel panel = new Panel();
                    Panel pnPic = new Panel();
                    Panel pnCode=new Panel();
                    Panel pnButton = new Panel();
                    pnPic.Dock = DockStyle.Fill;
                    pnPic.Size = new Size(150, 50);
                    pnPic.Padding=new Padding(5,5,5,5);
                    //pnPic.BackColor = Color.Red;
                    PictureBox pictureBox = new PictureBox();
                    //pictureBox.Size = new Size(150, 50);
                    try
                    {
                        pictureBox.Image = connect.GetImage(dtAccessory.Rows[i]["Accessory"].ToString());
                    }
                    catch(Exception ex)
                    {
                    }
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pnPic.Controls.Add(pictureBox);
                    pictureBox.Dock = DockStyle.Fill;
                    pictureBox.BorderStyle = BorderStyle.FixedSingle;
                    Label code = new Label();
                    pnCode.BorderStyle = BorderStyle.FixedSingle;
                    code.TextAlign=ContentAlignment.MiddleCenter;
                    code.AutoSize = false;
                    code.Dock = DockStyle.Fill;
                    code.Text = dtAccessory.Rows[i]["Accessory"].ToString();
                    pnCode.Controls.Add(code);
                    pnButton.Size = new Size(150, 30);
                    pnCode.Size = new Size(150, 30);
                    Button del =new Button();
                    del.Text = "Xoá";
                    del.Click += delClick;
                    del.Name= dtAccessory.Rows[i]["Accessory"].ToString();
                    //del.Size = new Size(30, 100);
                    del.Dock = DockStyle.Fill;
                    pnButton.Controls.Add(del);
                   
                    panel.Size = new Size(150, 200);
                    panel.BorderStyle = BorderStyle.FixedSingle;
                    panel.Controls.Add(pnPic);
                    panel.Controls.Add(pnCode);
                    panel.Controls.Add(pnButton);
                    pnButton.Dock = DockStyle.Bottom;
                    pnCode.Dock = DockStyle.Bottom;
                    pnPic.Dock = DockStyle.Fill;
                    pnMaterials.Controls.Add(panel);
                }    
   
            }
            LoadAddButton();
        }
        private void delClick(object sender,EventArgs e)
        {
            try
            {
                if (connect.exedata($"delete from Accessory where Partno ='{txtPartno.Text}' and Accessory ='{((Button)sender).Name}' "))
                {
                    MessageBox.Show("Xoá thành công");
                    LoadMaterials();
                }
            }
           catch(Exception ex)
            {
                MessageBox.Show("Xoá không thành công: " + ex.Message);
            }
        }
        private void LoadAddButton()
        {
            Panel panel = new Panel();
            panel.Size = new Size(150, 200);
            panel.Padding = new Padding(40);
            panel.BorderStyle = BorderStyle.FixedSingle;
            pnMaterials.Controls.Add(panel);
            //panel.Dock = DockStyle.Left;
            PictureBox pictureBox = new PictureBox();
            pictureBox.Cursor = Cursors.Hand;
            pictureBox.Click += addClick;
            panel.Controls.Add(pictureBox);
            pictureBox.Image = HANMISYSTEM.Properties.Resources.add1;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            //pictureBox.Size = new Size(50,80);

            pictureBox.Dock = DockStyle.Fill;

        }
        private void Materials_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            CheckMaterials frm = new CheckMaterials();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }
    }
}
