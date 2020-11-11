using HANMISYSTEM.Module;
using HANMISYSTEM.Views.PartialView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.Spray
{
    public partial class AddSprayPlan : Form
    {
        public AddSprayPlan()
        {
            InitializeComponent();
        }
        Dbconnect dbconnect = new Dbconnect();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddSprayPlan_Load(object sender, EventArgs e)
        {
            DataTable dtLine = dbconnect.readdata("select * from SprayLine");
            cbbLine.DataSource = dtLine;
            cbbLine.DisplayMember = "Name";
            cbbLine.ValueMember = "ID";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SearchProductFrm frm=new SearchProductFrm())
            {
                frm.ShowDialog();
                txtPartNo.Text = frm.sendDataModel();
                
            }
        }
        Isnumber Isnumber = new Isnumber();
        public bool CheckNumer(string s)
        {
            if (Isnumber.IsNumber(s))
                return true;
            return false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtWO.Text!="" && txtPartNo.Text!="" && CheckNumer(txtQuantity.Text))
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count,cbbLine.SelectedValue.ToString(),txtWO.Text,txtPartNo.Text,txtQuantity.Text,dateTimePicker1.Value.ToString());
            }else
            {
                MessageBox.Show("Xin hãy điền đủ thông tin ");
            }
        }
    }
}
