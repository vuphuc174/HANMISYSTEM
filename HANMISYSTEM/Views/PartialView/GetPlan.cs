using HANMISYSTEM.DAO;
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
    public partial class GetPlan : Form
    {
        public GetPlan()
        {
            InitializeComponent();
        }
        public string lineID;
        public string workorder;
        string bravo_Line;
        string model;
        string planID;
        string plan;
        DAO_ProductionPlan dAO_ProductionPlan = new DAO_ProductionPlan();
        DAO_Line dAO_Line = new DAO_Line();
        DAO_Product dAO_Product = new DAO_Product();
        private async Task GetResultByPlan()
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["result_col"].Value = await dAO_ProductionPlan.GetResult(row.Cells["PlanID_col"].Value.ToString(), row.Cells["PartNo_col"].Value.ToString());
            }
        }
        private async void GetPlan_Load(object sender, EventArgs e)
        {
            lbdate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            bravo_Line = await dAO_Line.GetBravoLineIDByLineID(lineID);
            dataGridView1.DataSource = await dAO_ProductionPlan.GetBravoPlan(bravo_Line,DateTime.Now);
            await GetResultByPlan();
            CheckItemValid();

        }
        private async void btnFilter_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            bravo_Line = await dAO_Line.GetBravoLineIDByLineID(lineID);
            dataGridView1.DataSource = await dAO_ProductionPlan.GetBravoPlan(bravo_Line,dateTimePicker1.Value);
            await GetResultByPlan();
            CheckItemValid();
        }
        async void CheckItemValid()
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Index >= 0)
                {
                    bool check = await dAO_Product.CheckExisted(row.Cells["Partno_col"].Value.ToString());
                    if (!check) { row.Cells["selectcol"].ReadOnly = true;
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }
        public string SendData()
        {
            return workorder;
        }
        public string sendDataModel()
        {
            return model;
        }
        public string SendPlanID()
        {
            return planID;
        }
        public string SendPlan()
        {
            return plan;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
        e.RowIndex >= 0)
            {

                workorder = dataGridView1.Rows[e.RowIndex].Cells["WorkOrder_col"].Value.ToString();
                model = dataGridView1.Rows[e.RowIndex].Cells["Partno_col"].Value.ToString();
                planID = dataGridView1.Rows[e.RowIndex].Cells["PlanID_col"].Value.ToString();
                plan = dataGridView1.Rows[e.RowIndex].Cells["Quantity_col"].Value.ToString();

                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

    
    }

}
