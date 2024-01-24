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
    public partial class SelectWorkOrder : Form
    {
        public SelectWorkOrder()
        {
            InitializeComponent();
        }
        public string lineID;
        public  string workorder;
        string model;
        string planID;
        string plan;
        DAO_ProductionPlan dAO_ProductionPlan = new DAO_ProductionPlan();
        private async void SelectWorkOrder_Load(object sender, EventArgs e)
        {
            lbdate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dataGridView1.DataSource = await dAO_ProductionPlan.GetProductionPlan(lineID);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)13)
            //{
            //    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("partno = '{0}'", txtSearch.Text);  
            //}
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
        e.RowIndex >= 0)
            {

                workorder = dataGridView1.Rows[e.RowIndex].Cells["WorkOrder_col"].Value.ToString();
                model= dataGridView1.Rows[e.RowIndex].Cells["Partno_col"].Value.ToString();
                planID= dataGridView1.Rows[e.RowIndex].Cells["PlanID_col"].Value.ToString();
                plan= dataGridView1.Rows[e.RowIndex].Cells["Quantity_col"].Value.ToString();

                this.Close();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
