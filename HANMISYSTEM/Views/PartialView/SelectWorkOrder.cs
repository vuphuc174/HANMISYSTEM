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
        //public DataTable dt;
        public  string workorder;
        string model;
        string planID;
        private void SelectWorkOrder_Load(object sender, EventArgs e)
        {
            lbdate.Text = DateTime.Now.ToString("yyyy-MM-dd");
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

                workorder = dataGridView1.Rows[e.RowIndex].Cells["WorkOrder"].Value.ToString();
                model= dataGridView1.Rows[e.RowIndex].Cells["Model"].Value.ToString();
                planID= dataGridView1.Rows[e.RowIndex].Cells["PlanID"].Value.ToString();

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
    }
}
