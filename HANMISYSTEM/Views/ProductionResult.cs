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
    public partial class ProductionResult : Form
    {
        public ProductionResult()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private void ProductionResult_Load(object sender, EventArgs e)
        {
            DataTable dtwarehouse = connect.readdata("select * from warehouse");
            cbwarehouse.DataSource = dtwarehouse;
            cbwarehouse.DisplayMember = "namewarehouse";
            cbwarehouse.ValueMember = "idwarehouse";
            DataTable dtlocation = connect.readdata("select * from location where idwarehouse ='WH001'");
            cblocation.DataSource = dtlocation;
            cblocation.DisplayMember = "namelocation1";
            cblocation.ValueMember = "idlocation";

        }
        private void btncheck_Click(object sender, EventArgs e)
        {
            if(txtpartno.Text=="")
            {
                DataTable dtresult = connect.readdata("select SUM(qty) as result from productionhistory where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' and idlocation ='" + cblocation.SelectedValue.ToString() + "' and productiontime between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'");
                if(dtresult.Rows.Count>0)
                {
                    txtresult.Text=dtresult.Rows[0]["result"].ToString();
                }
                else
                {
                    txtresult.Text = "0";
                }
            }
            else
            {
                DataTable dtresult = connect.readdata("select SUM(qty) as result from productionhistory where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' and idlocation ='" + cblocation.SelectedValue.ToString() + "' and productiontime between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' and partno like '%" + txtpartno.Text + "%'");
                if (dtresult.Rows.Count > 0)
                {
                    txtresult.Text = dtresult.Rows[0]["result"].ToString();
                }
                else
                {
                    txtresult.Text = "0";
                }
            }
        }

        private void txtpartno_TextChanged(object sender, EventArgs e)
        {
            if(txtpartno.Text.Length>0)
            {
                lbsearch.Visible = true;
                lbsearch.Items.Clear();
                DataTable dtsearch = connect.readdata("select top 10 partno from cargo where partno like '%" + txtpartno.Text + "%' or partname like '%" + txtpartno.Text + "%'");
                for (int i = 0; i < dtsearch.Rows.Count; i++)
                {
                    lbsearch.Items.Add(dtsearch.Rows[i]["partno"].ToString());
                }
            }
            else
            {
                lbsearch.Visible = false;
            }
            
        }

        private void lbsearch_Click(object sender, EventArgs e)
        {
            if (lbsearch.SelectedItem != null)
            {
                txtpartno.Text = lbsearch.SelectedItem.ToString();
                lbsearch.Visible = false;
            }    
        }

        private void btncheckall_Click(object sender, EventArgs e)
        {
            if (txtpartno.Text == "")
            {
                DataTable dtresult = connect.readdata("select SUM(qty) as result from productionhistory where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "'  and productiontime between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'");
                if (dtresult.Rows.Count > 0)
                {
                    txtresult.Text = dtresult.Rows[0]["result"].ToString();
                }
                else
                {
                    txtresult.Text = "0";
                }
            }
            else
            {
                DataTable dtresult = connect.readdata("select SUM(qty) as result from productionhistory where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' and productiontime between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' and partno like '%" + txtpartno.Text + "%'");
                if (dtresult.Rows.Count > 0)
                {
                    txtresult.Text = dtresult.Rows[0]["result"].ToString();
                }
                else
                {
                    txtresult.Text = "0";
                }
            }
        }
    }
}
