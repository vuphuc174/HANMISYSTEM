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

namespace HANMISYSTEM.Views.RawMgt
{
    public partial class QCCheck : Form
    {
        public QCCheck()
        {
            InitializeComponent();
        }
        Dbconnect dbconnect = new Dbconnect();
        private void txtidpack_TextChanged(object sender, EventArgs e)
        {
            lbpartno.Text = ".";
            lbpartname.Text = ".";
            lbquantity.Text = ".";
            lbpackingdate.Text = ".";
            lbwarehouse.Text = ".";
            if (txtidpack.Text.Length>=14)
            {
                DataTable dtpackage = dbconnect.readdata("select pf.partno,(select partname from  cargo where partno =pf.partno) as partname,(select namewarehouse from warehouse where idwarehouse =pf.idwarehouse) as warehouse,pf.quantity,pf.packingdate from packinginfo pf where idpack='"+txtidpack.Text+"'");
                if(dtpackage.Rows.Count>0)
                {
                    lbpartno.Text = dtpackage.Rows[0]["partno"].ToString();
                    lbpartname.Text = dtpackage.Rows[0]["partname"].ToString();
                    lbquantity.Text = dtpackage.Rows[0]["quantity"].ToString();
                    lbpackingdate.Text = dtpackage.Rows[0]["packingdate"].ToString();
                    lbwarehouse.Text= dtpackage.Rows[0]["warehouse"].ToString();
                    txtquantity.Focus();
                }
                else
                {
                    MessageBox.Show("Mã đóng gói không tồn tại ");
                    txtidpack.Text = "";
                }
            }
        }
        Isnumber isnumber = new Isnumber();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtidpack.Text == "" || isnumber.IsNumber(txtquantity.Text) == false || isnumber.IsPositive(txtquantity.Text) == false )
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ");
            }
            else
            {
                DialogResult result1 = MessageBox.Show("Bạn có chắc chắn ? ", "Xác nhận", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    if (dbconnect.exedata("update packinginfo set quantity=quantity-"+txtquantity.Text+" where idpack='"+txtidpack.Text+"'") == true)
                    {
                        DataTable dtbom = dbconnect.readdata("select rawpartno,quantity from bom where partno ='"+lbpartno.Text+"'");
                        if(dtbom.Rows.Count>0)
                        {
                            foreach (DataRow row in dtbom.Rows)
                            {
                                if (dbconnect.countdata("select count(partno) from stock where partno='" + row["rawpartno"].ToString() + "' and idwarehouse='WH014'") != 0)
                                {
                                    dbconnect.exedata("update stock set quantity =quantity+" + (Convert.ToDouble(txtquantity.Text)*Convert.ToDouble(row["quantity"].ToString())) + " where idwarehouse='WH014' and partno='" + row["rawpartno"].ToString() + "'");
                                }
                                else
                                {
                                    dbconnect.exedata("insert into stock (idwarehouse,partno,quantity) values ('WH014','" + row["rawpartno"].ToString() + "','" + (Convert.ToDouble(txtquantity.Text) * Convert.ToDouble(row["quantity"].ToString())) + "')");
                                }
                            }
                        }
                        txtidpack.Text = "";
                        txtidpack.Focus();
                    }
                }
            }
        }
    }
}
