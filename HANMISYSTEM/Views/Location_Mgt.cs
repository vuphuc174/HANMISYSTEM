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
    public partial class Location_Mgt : Form
    {
        public Location_Mgt()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private string _result;
        private string mahoa(string str)
        {
            DataTable dtsign = connect.readdata("select sign from warehouse where idwarehouse ='"+str+"'");
            if(dtsign.Rows.Count>0)
            {
                _result=dtsign.Rows[0]["sign"].ToString();
            }
            return _result;
        }
        private void Location_Mgt_Load(object sender, EventArgs e)
        {
            //cbwarehouse
            DataTable dtwarehouse = connect.readdata("select idwarehouse,namewarehouse from warehouse where idcategory='W1'");
            cbwarehouse.DataSource = dtwarehouse;
            cbwarehouse.DisplayMember = "namewarehouse";
            cbwarehouse.ValueMember = "idwarehouse";
            cbwarehouse.SelectedValue = "WH002";
            txtwh.Text = "WH";
            // list vi tri
            lbposition.Items.Clear();
            DataTable dtpositon = connect.readdata("select idposition from position where idwarehouse ='"+cbwarehouse.SelectedValue+"'");
            for(int i = 0 ;i< dtpositon.Rows.Count ;i++)
            {
                lbposition.Items.Add(dtpositon.Rows[i]["idposition"].ToString());
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(connect.exedata("delete from position where idposition='"+txtwh.Text+"-"+txtposition.Text+"' and idwarehouse='"+cbwarehouse.SelectedValue+"'")==true)
            {
                MessageBox.Show("Xóa thành công !!!");
                lbposition.Items.Clear();
                DataTable dtpositon = connect.readdata("select idposition from position where idwarehouse ='" + cbwarehouse.SelectedValue + "'");
                for (int i = 0; i < dtpositon.Rows.Count; i++)
                {
                    lbposition.Items.Add(dtpositon.Rows[i]["idposition"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Xóa không thành công !!!");
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            lbnotify.Text="";
            if (txtposition.Text == "")
            {
                MessageBox.Show("Không thành công !!!");
                lbnotify.Text = "Vị trí không hợp lệ";
            }
            else
            {
                if(connect.countdata("select count(idposition) from position where idposition ='"+txtwh.Text+"-"+txtposition.Text+"' and idwarehouse='"+cbwarehouse.SelectedValue+"'")!=0)
                {
                    MessageBox.Show("Không thành công!!!");
                    lbnotify.Text = "Vị trí đã tồn tại ";
                }
                else
                {
                    connect.exedata("insert into position (idposition,idwarehouse) values('"+txtwh.Text+"-"+txtposition.Text+"','"+cbwarehouse.SelectedValue+"')");
                    MessageBox.Show("Thêm thành công ");
                    lbposition.Items.Clear();
                    DataTable dtpositon = connect.readdata("select idposition from position where idwarehouse ='" + cbwarehouse.SelectedValue + "'");
                    for (int i = 0; i < dtpositon.Rows.Count; i++)
                    {
                        lbposition.Items.Add(dtpositon.Rows[i]["idposition"].ToString());
                    }
                }
            }
        }

        private void lbposition_Click(object sender, EventArgs e)
        {
            if(lbposition.SelectedIndex!=-1)
            {
                txtposition.Text = lbposition.SelectedItem.ToString().Substring(3, lbposition.SelectedItem.ToString().Length - 3);
                txtwh.Text = mahoa(cbwarehouse.SelectedValue.ToString());
            }
           
        }

        private void cbwarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbposition.Items.Clear();
            txtwh.Text = mahoa(cbwarehouse.SelectedValue.ToString());
            DataTable dtpositon = connect.readdata("select idposition from position where idwarehouse ='" + cbwarehouse.SelectedValue + "'");
            for (int i = 0; i < dtpositon.Rows.Count; i++)
            {
                lbposition.Items.Add(dtpositon.Rows[i]["idposition"].ToString());
            }
        }
    }
}
