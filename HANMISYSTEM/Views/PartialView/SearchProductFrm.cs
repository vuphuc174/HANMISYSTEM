using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.PartialView
{
    public partial class SearchProductFrm : Form
    {
        public SearchProductFrm()
        {
            InitializeComponent();
        }
        string partno;
        Dbconnect dbconnect = new Dbconnect();
        private void SearchProductFrm_Load(object sender, EventArgs e)
        {
            DataTable dtProduct = dbconnect.readdata("Select row_number() over (order by partno) as r, Partno,partname,specificationinfo as specification,color,market from cargo");
            dataGridView1.DataSource = dtProduct;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string sendDataModel()
        {
            return partno;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
        e.RowIndex >= 0)
            {
                partno = dataGridView1.Rows[e.RowIndex].Cells["PartNo"].Value.ToString();

                this.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "Select row_number() over (order by partno) as r, Partno,partname,specificationinfo as specification,color,market from cargo ";
            string cond = "";
            if (chkPartNo.Checked)
            {
                if (cond == "")
                {
                    cond = " where partno like '%" + txtSearch.Text + "%'";
                }
                else
                {
                    cond += " or partno like '%" + txtSearch.Text + "%'";
                }

            }
            if (chkPartName.Checked)
            {
                if (cond == "")
                {
                    cond = " where partname like '%" + txtSearch.Text + "%'";
                }
                else
                {
                    cond += " or partname like '%" + txtSearch.Text + "%'";
                }

            }
            if (chkSpecs.Checked)
            {
                if (cond == "")
                {
                    cond = " where specificationinfo like '%" + txtSearch.Text + "%'";
                }
                else
                {
                    cond += " or specificationinfo like '%" + txtSearch.Text + "%'";
                }
                
            }
            if (chkColor.Checked)
            {
                if (cond == "")
                {
                    cond = " where Color like '%" + txtSearch.Text + "%'";
                }
                else
                {
                    cond += " or Color like '%" + txtSearch.Text + "%'";
                }
                
            }
            if (chkMarket.Checked)
            {
                if (cond == "")
                {
                    cond = " where Market like '%" + txtSearch.Text + "%'";
                }
                else
                {
                    cond += " or Market like '%" + txtSearch.Text + "%'";
                }
                
            }
            
            dataGridView1.DataSource = dbconnect.readdata(sql+cond);
        }
    }
}
