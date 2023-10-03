using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.Producs
{
    public partial class CheckProductInv_POPUP : Form
    {
        public CheckProductInv_POPUP()
        {
            InitializeComponent();
        }
        public string partno;
        Dbconnect connect = new Dbconnect();
        private void CheckProductInv_POPUP_Load(object sender, EventArgs e)
        {
            lbPartno.Text = partno;
            DataTable dtPackingMethod = connect.readdata("select count(*) as row from packingstandard where partno ='"+partno+"'");
            try
            {
                AddPanel("Phương thức đóng gói hiện có :", dtPackingMethod.Rows[0]["row"].ToString());

            }
            catch
            {

            }
            DataTable dtBom = connect.readdata("select count(*) as row from bom where partno ='"+partno+"' or rawpartno ='"+partno+"'");
 
            try
            {
                AddPanel("Liên kết BOM :", dtBom.Rows[0]["row"].ToString());

            }
            catch
            {

            }
        }
        private void AddPanel(string text,string qty)
        {
            Panel panel=new Panel();
            Label label = new Label();
            label.Text = text+" "+qty;
            label.AutoSize = false;
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.Dock = DockStyle.Fill;
            panel.Dock = DockStyle.Top;
            panel.Height = 50;
            panel.Controls.Add(label);
            pnCheckCondition.Controls.Add(panel);
            
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirm_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                //delete packing method 
                connect.exedata("delete from packingstandard where partno ='" + partno + "'");
                //delete bom 
                connect.exedata("delete from bom where partno='"+partno+"' or rawpartno='"+partno+"'");
                if (connect.exedata("delete from cargo where partno ='" + partno + "'"))
                {
                    MessageBox.Show("Xoá thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thao tác xoá không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
