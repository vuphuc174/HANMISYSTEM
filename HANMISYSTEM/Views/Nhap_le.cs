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

namespace HANMISYSTEM
{
    public partial class Nhap_le : Form
    {
        public Nhap_le()
        {
            InitializeComponent();
        }
        Dbconnect connect=new Dbconnect();
        private void Nhap_le_Load(object sender, EventArgs e)
        {
            DataTable dtstock = connect.readdata("select * from view_stock_warehouse where idwarehouse ='WH002'");
            try
            {
                dgv1.DataSource = dtstock;
            }
            catch
            { }
            DataTable dtwarehouse = connect.readdata("select t.idwarehouse,namewarehouse from tbl_user_permission t inner join warehouse w on t.idwarehouse=w.idwarehouse where username ='"+HANMISYSTEM.Properties.Settings.Default.username+"'");
            cbiwarehouse.DataSource = dtwarehouse;
            cbiwarehouse.ValueMember = "idwarehouse";
            cbiwarehouse.DisplayMember = "namewarehouse";
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dtstock = connect.readdata("select * from view_stock_warehouse where idwarehouse ='" + cbiwarehouse.SelectedValue.ToString() + "' and   partno like '%" + txtsearch.Text + "%' or idwarehouse ='" + cbiwarehouse.SelectedValue.ToString() + "' and partname like '%" + txtsearch.Text + "%'");
                try
                {
                    dgv1.DataSource = dtstock;
                }
                catch
                { }
        }

        private void txtidpack_TextChanged(object sender, EventArgs e)
        {
            if(txtidpack.Text.Length>=14)
            {
                if(connect.countdata("select count(idpack) from packinginfo where idpack='"+txtidpack.Text+"'")==0)
                {
                    MessageBox.Show("Mã thùng không tồn tại ");
                }
                else
                {
                    DataTable dtpack = connect.readdata("select p.partno,partname,quantity,p.idwarehouse from packinginfo p inner join cargo c on p.partno=c.partno where idpack='"+txtidpack.Text+"'");
                    txtpartno.Text=dtpack.Rows[0]["partno"].ToString();
                    txtpartname.Text = dtpack.Rows[0]["partname"].ToString();
                    txtcurrentqty.Text = dtpack.Rows[0]["quantity"].ToString();
                    cbiwarehouse.SelectedValue = dtpack.Rows[0]["idwarehouse"].ToString();
                    DataTable dtcheck = connect.readdata("select quantity from packingstandard where partno='"+txtpartno.Text+"' and idpacking='"+txtidpack.Text.Substring(0,3)+"'");
                    lbnotify.Text="Bạn có thể thêm tối đa " +(Convert.ToDouble(dtcheck.Rows[0]["quantity"].ToString())-Convert.ToDouble(txtcurrentqty.Text)).ToString();
                    if((Convert.ToDouble(dtcheck.Rows[0]["quantity"].ToString())-Convert.ToDouble(txtcurrentqty.Text))<=0)
                    {
                        MessageBox.Show("BOX nay da day");
                        txtidpack.Text = "";
                        txtpartno.Text = "";
                        txtpartname.Text = "";
                        txtcurrentqty.Text = "";
                        lbnotify.Text = "...";
                    }
                }
            }
        }
        Isnumber _isnumber = new Isnumber();
        private void btnsave_Click(object sender, EventArgs e)
        {
            if(txtpartno.Text!="" || txtaddqty.Text!="")
            {
                
                if(_isnumber.IsNumber(txtaddqty.Text))
                {
                    if(txtinvoice.Text=="")
                    {
                        MessageBox.Show("Chon kho nhập và kho xuất");
                    }
                    else
                    {
                        if (connect.countdata("select count(idslipout) from slipout where idslipout='" + txtinvoice.Text + "'") == 1)
                        {
                            DataTable dtcategory = connect.readdata("select idcategory from warehouse where idwarehouse='" + cbewarehouse.SelectedValue.ToString() + "'");
                            if (dtcategory.Rows[0]["idcategory"].ToString() == "W2")
                            {
                                DataTable dtbom = connect.readdata("select * from bom where partno ='" + txtpartno.Text + "'");
                                if (dtbom.Rows.Count != 0)
                                {
                                    for (int j = 0; j < dtbom.Rows.Count; j++)
                                    {
                                        if (connect.countdata("select count (partno) from stock where partno ='" + dtbom.Rows[j]["rawpartno"].ToString() + "' and idwarehouse='" + cbewarehouse.SelectedValue.ToString() + "'") == 0)
                                        {
                                            connect.exedata("insert into stock(idwarehouse,partno,quantity) valuse ('" + cbewarehouse.SelectedValue.ToString() + "','" + dtbom.Rows[j]["rawpartno"].ToString() + "','" + (0 - (Convert.ToDouble(txtaddqty.Text) * Convert.ToDouble(dtbom.Rows[j]["quantity"].ToString()))) + "')");
                                        }
                                        else
                                        {
                                            connect.exedata("update stock set quantity=quantity-'" + (Convert.ToDouble(txtaddqty.Text) * Convert.ToDouble(dtbom.Rows[j]["quantity"].ToString())) + "' where idwarehouse='" + cbewarehouse.SelectedValue.ToString() + "' and partno ='" + dtbom.Rows[j]["rawpartno"].ToString() + "'");
                                        }
                                    }
                                }        
                            }
                            string str = mahoa(cbewarehouse.SelectedValue.ToString()) + mahoa(cbiwarehouse.SelectedValue.ToString());
                            int a = connect.countdata("select count (*) from slipout where idslipout like'" + str + "%' ") + 1;
                            txtinvoice.Text = str + DateTime.Now.ToString("yyyyMM") + a.ToString("0000");
                            connect.exedata("insert into slipout (idslipout,dateout,idwarehouse,idcustomer) values ('" + txtinvoice.Text + "','" + DateTime.Now.ToString() + "','" + cbewarehouse.SelectedValue.ToString() + "','" + cbiwarehouse.SelectedValue.ToString() + "')");
                            connect.exedata("insert into slipoutinfo (idslipout,idpack,quantity,remark,carnumber,partno,packingdate) values ('" + txtinvoice.Text + "','" + txtidpack.Text + "','" + txtaddqty.Text + "','','','" + txtpartno.Text + "','" + DateTime.Now.ToString() + "')");
                            if (connect.exedata("update packinginfo set quantity =quantity+ " + Convert.ToDouble(txtaddqty.Text) + " where idpack='" + txtidpack.Text + "'") == true)
                            {
                                MessageBox.Show("Thanh cong");
                                
                                txtidpack.Text = "";
                                txtpartname.Text = "";
                                txtpartno.Text = "";
                                txtcurrentqty.Text = "";
                                txtinvoice.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("That bai");
                            }
                        }
                        else
                        {
                            connect.exedata("insert into slipout (idslipout,dateout,idwarehouse,idcustomer) values ('" + txtinvoice.Text + "','" + DateTime.Now.ToString() + "','" + cbewarehouse.SelectedValue.ToString() + "','" + cbiwarehouse.SelectedValue.ToString() + "')");
                            connect.exedata("insert into slipoutinfo (idslipout,idpack,quantity,remark,carnumber,partno,packingdate) values ('" + txtinvoice.Text + "','" + txtidpack.Text + "','" + txtaddqty.Text + "','','','" + txtpartno.Text + "','" + DateTime.Now.ToString() + "')");
                            if (connect.exedata("update packinginfo set quantity =quantity+ " + Convert.ToDouble(txtaddqty.Text) + " where idpack='" + txtidpack.Text + "'") == true)
                            {
                                MessageBox.Show("Thanh cong");
                                DataTable dtstock = connect.readdata("select * from view_stock_warehouse where idwarehouse ='" + cbiwarehouse.SelectedValue.ToString() + "'");
                                dgv1.DataSource = dtstock;
                                txtidpack.Text = "";
                                txtpartname.Text = "";
                                txtpartno.Text = "";
                                txtcurrentqty.Text = "";
                                txtinvoice.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("That bai");
                            }
                        }
                    }
                    
                    
                }

                else
                {
                    MessageBox.Show("Nhap vao mot so");
                }
            }
        }
        private string r;
        private string mahoa(string str)
        {

            DataTable dtsign = connect.readdata("select sign from warehouse where idwarehouse='"+str+"' ");
            if(dtsign.Rows.Count>0)
            {
                r=dtsign.Rows[0]["sign"].ToString();
            }
            return r;
        }
        private void cbewarehouse_Click(object sender, EventArgs e)
        {
            DataTable dtwarehouse = connect.readdata("select * from warehouse where idwarehouse <> '"+cbiwarehouse.SelectedValue.ToString()+"'");
            cbewarehouse.DataSource = dtwarehouse;
            cbewarehouse.ValueMember = "idwarehouse";
            cbewarehouse.DisplayMember = "namewarehouse";
        }

        private void cbiwarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtstock = connect.readdata("select * from view_stock_warehouse where idwarehouse ='"+cbiwarehouse.SelectedValue.ToString()+"'");
            dgv1.DataSource = dtstock;
            if(cbewarehouse.Text!="")
            {
                if(cbiwarehouse.SelectedValue.ToString()==cbewarehouse.SelectedValue.ToString())
                {
                    cbewarehouse.SelectedIndex = -1;
                    txtinvoice.Text = "";
                }
                else
                {
                    
                }
            }
            if (cbewarehouse.Text != "" && cbiwarehouse.Text != "")
            {
                if (cbewarehouse.Text == "" || cbiwarehouse.Text == "")
                {
                    MessageBox.Show("Make sure selected both from WH and to WH");
                }
                else
                {
                    string str = mahoa(cbewarehouse.SelectedValue.ToString()) + mahoa(cbiwarehouse.SelectedValue.ToString());
                    int a = connect.countdata("select count (*) from slipout where idslipout like'" + str + "%' ") + 1;
                    txtinvoice.Text = str + DateTime.Now.ToString("yyyyMM") + a.ToString("0000");
                }
            }
        }

        private void cbewarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbewarehouse.Text!="" && cbiwarehouse .Text!="")
            {
                if(cbewarehouse.Text=="" || cbiwarehouse.Text=="")
                {
                    MessageBox.Show("Make sure selected both from WH and to WH");
                }
                else
                {
                    string str = mahoa(cbewarehouse.SelectedValue.ToString()) + mahoa(cbiwarehouse.SelectedValue.ToString());
                    int a = connect.countdata("select count (*) from slipout where idslipout like'"+str+"%' ") +1;
                    txtinvoice.Text = str + DateTime.Now.ToString("yyyyMM")+a.ToString("0000");
                }
            }
            else
            {
                txtinvoice.Text = "";
            }
        }
    }
}
