using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.Producs
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            ApplyShadow();
        }
        Dbconnect connect = new Dbconnect();
        public string action;
        #region design
        // Import the necessary Windows API functions
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(
            IntPtr hwnd,
            int attr,
            ref int attrValue,
            int attrSize
        );

        private const int DWMWA_NCRENDERING_ENABLED = 1;
        private const int DWMWA_EXTENDED_FRAME_BOUNDS = 9;
        private void ApplyShadow()
        {
            // Create a rounded rectangle region for the form
            const int cornerRadius = 10;
            Region = Region.FromHrgn(CreateRoundRectRgn(
                0,
                0,
                Width,
                Height,
                cornerRadius,
                cornerRadius
            ));

            // Enable non-client area rendering
            int dwmEnabled = 1;
            DwmSetWindowAttribute(Handle, DWMWA_NCRENDERING_ENABLED, ref dwmEnabled, sizeof(int));

            // Extend the window frame into the client area to draw the shadow
            int margin = -1;
            DwmSetWindowAttribute(Handle, DWMWA_EXTENDED_FRAME_BOUNDS, ref margin, sizeof(int));
        }
        #endregion
        private void myButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            DataTable dt = connect.readdata("select * from category");
            cbcategory.DataSource = dt;
            cbcategory.ValueMember = "idcategory";
            cbcategory.DisplayMember = "namecategory";
            DataTable dt1 = connect.readdata("select * from unit");
            cbunit.DataSource = dt1;
            cbunit.ValueMember = "idunit";
            cbunit.DisplayMember = "nameunit";
            cbpacking.SelectedIndex = 0;

            DataTable dtProductKind = connect.readdata("select ID,Name from ProductKind");
            cbProductKind.DataSource = dtProductKind;
            cbProductKind.DisplayMember = "Name";
            cbProductKind.ValueMember = "ID";

            DataTable dtprocess = connect.readdata("select ID,Name from BomProcess");
            cbprocess.DataSource = dtprocess;
            cbprocess.DisplayMember = "Name";
            cbprocess.ValueMember = "ID";
        }
        private bool CheckExist(string pn)
        {
            DataTable dt = connect.readdata("select partno from cargo where partno ='" + pn + "'");
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        private int CheckValidState()
        {
            if (cbunit.Text == "" || txtpartno.Text == "" || txtpartname.Text == "" || cbcategory.Text == "")
            {
                return 1;
            }
            if (txtpartno.Text.Contains(" ") == true)
            {
                return 2;
            }
            if (CheckExist(txtpartno.Text))
            {
                return 3;
            }
            return 0;
        }
        private void myButton1_Click(object sender, EventArgs e)
        {
            if (CheckValidState() == 1)
            {
                MessageBox.Show("Không được bỏ trống *");
            }
            else if (CheckValidState() == 2)
            {
                MessageBox.Show("Mã hàng không được chứa khoảng trắng ");
            }

            else
            {
                if (action == "EDIT")
                {
                    if (connect.exedata("update cargo set partname='" + txtpartname.Text + "',productivity ='" + txtproductivity.Text + "',specificationinfo='" + txtinfo.Text + "',othername='" + txtothername.Text + "',process='" + cbprocess.Text + "',idcategory='" + cbcategory.SelectedValue.ToString() + "',idunit='" + cbunit.SelectedValue.ToString() + "',ProductionKindID='" + cbProductKind.SelectedValue.ToString() + "',ProcessID='" + cbprocess.SelectedValue.ToString() + "' where partno ='" + txtpartno.Text + "'") == true)
                    {
                        connect.exedata("delete from packingstandard where partno ='" + txtpartno.Text + "' and idpacking ='" + cbpacking.Text + "'");
                        if (connect.exedata("insert into packingstandard  (partno,idpacking,quantity) values ('" + txtpartno.Text + "','" + cbpacking.Text + "','" + txtquantity.Text + "')") == false)
                        {
                            packingnotify fr = new packingnotify();
                            fr.lbidpacking.Text = cbpacking.Text;
                            fr.lbpartno.Text = txtpartno.Text;
                            fr.ShowDialog();
                        }
                        MessageBox.Show("Thanh cong");
                        txtquantity.Text = "";
                    }
                    else
                        MessageBox.Show("That bai");
                }
                else
                {
                    if (CheckValidState() == 3)
                    {
                        MessageBox.Show("Partno đã tồn tại");
                    }
                    else
                    {
                        if (connect.exedata("insert into cargo (partno,partname,idcategory,specificationinfo,productivity,idunit,process,ProductionKindID,ProcessID)  values('" + txtpartno.Text.ToUpper() + "','" + txtpartname.Text + "','" + cbcategory.SelectedValue + "','" + txtinfo.Text + "','" + txtproductivity.Text + "','" + cbunit.SelectedValue + "','" + cbprocess.Text + "','" + cbProductKind.SelectedValue.ToString() + "','" + cbprocess.SelectedValue.ToString() + "')"))
                        {
                            if (connect.exedata("insert into packingstandard  (partno,idpacking,quantity) values ('" + txtpartno.Text.ToUpper() + "','" + cbpacking.Text + "','" + txtquantity.Text + "')") == false)
                            {
                                packingnotify fr = new packingnotify();
                                fr.lbpartno.Text = txtpartno.Text;
                                fr.lbidpacking.Text = cbpacking.Text;
                                fr.ShowDialog();
                            }
                            MessageBox.Show("success");
                            //loaddata("select partno,partname,category.namecategory,specificationinfo,productivity,unit.nameunit,process,tradingpartnumber,othername,(select name from ProductKind where ID=cargo.ProductionKindID) as ProductionKindID from cargo inner join unit  on cargo.idunit=unit.idunit inner join category on cargo.idcategory=category.idcategory");
                            txtpartno.Text = "";
                            txtpartname.Text = "";
                            txtquantity.Text = "";
                            txtinfo.Text = "";
                            txtproductivity.Text = "";
                        }
                    }

                }

            }
        }
    }
}
