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
    public partial class StockFollowLoction : Form
    {
        public StockFollowLoction()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private void StockFollowLoction_Load(object sender, EventArgs e)
        {
            DataTable dtstock = connect.readdata("select position,idpack,partno,partname,quantity from view_stock_warehouse_location where idwarehouse ='WH002' order by position asc");
            try
            {
                dataGridView1.DataSource = dtstock;
            }
            catch
            {

            }
            DataTable dtwarehouse = connect.readdata("select * from warehouse where  idcategory ='W1'");
            cbwarehouse.DataSource = dtwarehouse;
            cbwarehouse.ValueMember = "idwarehouse";
            cbwarehouse.DisplayMember = "namewarehouse";

            DataTable dtlocation = connect.readdata("select idposition from position where idwarehouse='WH002'");
            cblocation.DataSource = dtlocation;
            cblocation.DisplayMember = "idposition";
            cblocation.ValueMember = "idposition";
            cbsearch.DataSource = dtlocation;
            cbsearch.DisplayMember = "idposition";
            cbsearch.ValueMember = "idposition";
            cbsearch.SelectedIndex = -1;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if(chkposition.Checked==true)
            {
                DataTable dtsearch = connect.readdata("select position,idpack,partno,partname,quantity from view_stock_warehouse_location where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' and position = '" + cbsearch.SelectedValue.ToString() + "' and partno like '%" + txtsearch.Text + "%' or idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' and position = '" + cbsearch.SelectedValue.ToString() + "' and partname like '%" + txtsearch.Text + "%' or idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' and position = '" + cbsearch.SelectedValue.ToString() + "' and idpack like '%" + txtsearch.Text + "%' ");
                        try
                        {
                            dataGridView1.DataSource = dtsearch;
                        }
                        catch
                        {

                        }
                
            }
            else
            {
                DataTable dtsearch = connect.readdata("select position,idpack,partno,partname,quantity from view_stock_warehouse_location where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' and  partno like '%" + txtsearch.Text + "%' or idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' and partname like '%" + txtsearch.Text + "%' or idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' and idpack like '%" + txtsearch.Text + "%' order by position asc");
                try
                {
                    dataGridView1.DataSource = dtsearch;
                }
                catch
                {

                }    
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                txtcurrentposition.Text=dataGridView1.Rows[e.RowIndex].Cells["position"].Value.ToString();
                txtidpack.Text = dataGridView1.Rows[e.RowIndex].Cells["idpack"].Value.ToString();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(txtcurrentposition.Text=="" || txtidpack.Text=="")
            {
                MessageBox.Show("Điền đầy đủ các trường ");
            }
            else
            {
                if (cblocation.Text == txtcurrentposition.Text)
                {
                    MessageBox.Show("Vị trí cần chuyển phải khác vị trí hiện tại");
                }
                else
                {
                    if (connect.countdata("select count(idpack) from packinginfo where idwarehouse='"+cbwarehouse.SelectedValue.ToString()+"' and idpack='" + txtidpack.Text + "' and position ='" + txtcurrentposition.Text + "'") != 0)
                    {
                        if (connect.exedata("update packinginfo set position ='" + cblocation.Text + "' where idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "' and idpack='" + txtidpack.Text + "'") == true)
                        {
                            MessageBox.Show("Thanh co^ng");
                            DataTable dtstock = connect.readdata("select position,idpack,partno,partname,quantity from view_stock_warehouse_location where idwarehouse ='"+cbwarehouse.SelectedValue.ToString()+"' order by position asc");
                            try
                            {
                                dataGridView1.DataSource = dtstock;
                            }
                            catch
                            {

                            }
                            txtcurrentposition.Text = "";
                            txtidpack.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Thất bại ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Box không còn tồn tại tai vị trí");
                    }
                }
            }
            
        }

        private void txtidpack_TextChanged(object sender, EventArgs e)
        {
            if(txtidpack.Text.Length>=14)
            {
                if (connect.countdata("select count(idpack) from packinginfo where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' and idpack='" + txtidpack.Text + "' ") == 0)
              {
                  MessageBox.Show("Mã thùng không có trong kho");
                  txtidpack.Text = "";
                  txtidpack.Focus();
              }
              else
              {
                  DataTable dt = connect.readdata("select position from packinginfo  where idpack='" + txtidpack.Text + "' and idwarehouse='" + cbwarehouse.SelectedValue.ToString() + "'");
                  txtcurrentposition.Text=dt.Rows[0]["position"].ToString();
              }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(chkposition.Checked==true)
            {
                if(cbsearch.SelectedIndex!=-1)
                {
                    DataTable dtstock = connect.readdata("select  position,idpack,partno,partname,quantity from view_stock_warehouse_location where idwarehouse ='"+cbwarehouse.SelectedValue.ToString()+"' and position='" + cbsearch.SelectedValue.ToString() + "'");
                    try
                    {
                        dataGridView1.DataSource = dtstock;
                    }
                    catch
                    {

                    }
                }
            }
        }
        double sumqty;
        //su kien thay doi so dong trong datagridview
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            sumqty=0;
            for(int i=0;i<dataGridView1.Rows.Count;i++)
            {
                sumqty = sumqty + Convert.ToDouble(dataGridView1.Rows[i].Cells["quantity"].Value.ToString());
            }
            txtsumqty.Text = sumqty.ToString();
        }

        private void chkposition_CheckedChanged(object sender, EventArgs e)
        {
            if(chkposition.Checked==false)
            {
                DataTable dtstock = connect.readdata("select position,idpack,partno,partname,quantity from view_stock_warehouse_location where idwarehouse ='"+cbwarehouse.SelectedValue.ToString()+"' order by position asc");
                try
                {
                    dataGridView1.DataSource = dtstock;
                }
                catch
                {

                }
            }
        }

        private void cbwarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtstock = connect.readdata("select  position,idpack,partno,partname,quantity from view_stock_warehouse_location where idwarehouse ='"+cbwarehouse.SelectedValue.ToString()+"' order by position asc");
            dataGridView1.DataSource = dtstock;
            DataTable dtlocation = connect.readdata("select * from position where idwarehouse ='"+cbwarehouse.SelectedValue.ToString()+"'");
            cblocation.DataSource = dtlocation;
            cblocation.ValueMember = "idposition";
            cblocation.DisplayMember = "idposition";
            cbsearch.DataSource = dtlocation;
            cbsearch.ValueMember = "idposition";
            cbsearch.DisplayMember = "idposition";
        }
    }
}
