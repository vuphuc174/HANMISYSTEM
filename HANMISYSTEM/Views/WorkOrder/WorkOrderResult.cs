using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.WorkOrder
{
    public partial class WorkOrderResult : Form
    {
        Dbconnect dbconnect = new Dbconnect();
        public WorkOrderResult()
        {
            InitializeComponent();
        }
        string sql;
        void Filter()
        {
            //sql = "select * from productionplan p inner join cargo c on p.partno =c.partno where (p.productiondate between '" + dateTimePicker1.Value.ToString() + "' and '" + dateTimePicker2.Value.ToString() + "' or p.PST between '" + dateTimePicker1.Value.ToString() + "' and '" + dateTimePicker2.Value.ToString() + "' ) ";
            //if (txtsearch.Text.Length > 0)
            //{
            //    sql += " and  (c.partno like '%" + txtsearch.Text + "%' or c.partname like '%" + txtsearch.Text + "% or p.WOCode like '%" + txtsearch.Text + "%'') ";
            //}
            //if (cbbLocation.SelectedValue.ToString() != "ALL")
            //{
            //    sql += " and p.idlocation ='" + cbbLocation.SelectedValue.ToString() + "'";
            //}
            //dataGridView1.DataSource = dbconnect.readdata(sql);
            //Thread.Sleep(5000);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            sql = "select p.ID,p.WOCode,p.partno,c.partname,p.productionplan,c.productivity,p.pst,isnull((select sum(qty) as actual from productionhistory where PlanID =p.ID),0) as actual from productionplan p inner join cargo c on p.partno =c.partno where (p.productiondate between '" + dateTimePicker1.Value.ToString() + "' and '" + dateTimePicker2.Value.ToString() + "' or p.PST between '" + dateTimePicker1.Value.ToString() + "' and '" + dateTimePicker2.Value.ToString() + "' ) ";
            if (txtsearch.Text.Length > 0)
            {
                sql += " and  (c.partno like '%" + txtsearch.Text + "%' or c.partname like '%" + txtsearch.Text + "% or p.WOCode like '%" + txtsearch.Text + "%'') ";
            }
            if (cbbLocation.SelectedValue.ToString() != "ALL")
            {
                sql += " and p.idlocation ='" + cbbLocation.SelectedValue.ToString() + "'";
            }
            dataGridView1.DataSource = dbconnect.readdata(sql);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                double wt = (Convert.ToDouble(dataGridView1.Rows[i].Cells["Quantity"].Value.ToString()) / Convert.ToDouble(dataGridView1.Rows[i].Cells["productivity"].Value.ToString()));
                dataGridView1.Rows[i].Cells["EstimateTime"].Value = wt.ToString("0.00");

                if (dataGridView1.Rows[i].Cells["PST"].Value.ToString() != "")
                {
                    DateTime pst = Convert.ToDateTime(dataGridView1.Rows[i].Cells["PST"].Value.ToString());
                    DateTime ft = pst.AddHours(wt);
                    dataGridView1.Rows[i].Cells["FinishTime"].Value = ft.ToString();
                    if (Convert.ToDateTime(dataGridView1.Rows[i].Cells["FinishTime"].Value.ToString()) > DateTime.UtcNow)
                    {
                        if(Convert.ToInt64(dataGridView1.Rows[i].Cells["Quantity"].Value.ToString()) > Convert.ToInt64(dataGridView1.Rows[i].Cells["Actual"].Value.ToString()))
                        {
                            dataGridView1.Rows[i].Cells["Status"].Value = "Failed";
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells["Status"].Value = "OK";
                        }    
                    }
                    //double wt = (Convert.ToDouble(dataGridView1.Rows[i].Cells["productionplan"].Value.ToString()) / Convert.ToDouble(dataGridView1.Rows[i].Cells["productivity"].Value.ToString()));
                    //dataGridView1.Rows[i].Cells["Status"].Value = wt.ToString("N0");
                    //if(Convert.ToDateTime(dataGridView1.Rows[i].Cells["PST"].Value.ToString())<)
                }
            }
            //using (WaitingLoadFrm frm =new WaitingLoadFrm(Filter))
            //{
            //    frm.ShowDialog();
            //}
        }

        private void WorkOrderResult_Load(object sender, EventArgs e)
        {
            DataTable dtLocation = dbconnect.readdata("select idlocation, namelocation1 from location where idlocation <> 'L12'");
            dtLocation.Rows.Add("ALL", "ALL");
            cbbLocation.DataSource = dtLocation;
            cbbLocation.DisplayMember = "namelocation1";
            cbbLocation.ValueMember = "idlocation";
        }
    }
}
