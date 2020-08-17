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

namespace HANMISYSTEM.Views
{
    public partial class ChangeBoxQty : Form
    {
        public ChangeBoxQty()
        {
            InitializeComponent();
        }
        Dbconnect conenct = new Dbconnect();

        private void ChangeBoxQty_Load(object sender, EventArgs e)
        {
        }
        DataTable dt;
        private void txtidpack_TextChanged(object sender, EventArgs e)
        {
            if (txtidpack.Text.Length >= 14)
            {
                dt = conenct.readdata("select pi.idpack,pi.packingdate,pi.partno,c.partname,pi.idwarehouse,pi.quantity,pi.idlocation from packinginfo pi inner join cargo c on pi.partno=c.partno where idpack='" + txtidpack.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    txtwarehouse.Text = dt.Rows[0]["idwarehouse"].ToString();
                    txtpartno.Text = dt.Rows[0]["partno"].ToString();
                    txtpartname.Text = dt.Rows[0]["partname"].ToString();
                    txtquantity.Text = dt.Rows[0]["quantity"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã đóng gói !");
                }
            }
        }
        Isnumber isnumber = new Isnumber();
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtquantity.Text == "")
            {
                MessageBox.Show("Không được bỏ trống");
            }
            else
            {
                if (isnumber.IsNumber(txtquantity.Text))
                {
                    
                    if (conenct.exedata("insert into productionhistory (idwarehouse,partno,productiontime,qty,idlocation) values ('" + txtwarehouse.Text + "','" + txtpartno.Text + "','"+dt.Rows[0]["packingdate"].ToString()+"','" + (Convert.ToDouble(txtquantity.Text) - Convert.ToDouble(dt.Rows[0]["quantity"].ToString())) + "','" + dt.Rows[0]["idlocation"].ToString() + "')") == true)
                    {
                        if(txtquantity.Text=="0")
                        {
                            conenct.exedata("exec spDeletePackingInfo @idpack='"+dt.Rows[0]["idpack"].ToString()+"'");
                        }
                        else
                        {
                            conenct.exedata("update packinginfo set quantity ='" + txtquantity.Text + "' where idpack ='" + dt.Rows[0]["idpack"].ToString() + "'");
                        }
                        
                        MessageBox.Show("Thành công");
                        txtidpack.Text = "";
                        txtwarehouse.Text = "";
                        txtpartno.Text = "";
                        txtpartname.Text = "";
                        txtquantity.Text = "";
                        txtidpack.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Không thành công xin hãy thử lại ");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập vào một số !");
                    txtquantity.Text = dt.Rows[0]["quantity"].ToString();
                }
            }
        }
    }
}
