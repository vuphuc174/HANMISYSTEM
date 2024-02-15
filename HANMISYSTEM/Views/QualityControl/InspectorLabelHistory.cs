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

namespace HANMISYSTEM.Views.QualityControl
{
    public partial class InspectorLabelHistory : Form
    {
        private class Judge
        {
            public string Display { get; set; }
            public string Value { get; set; }
        }
        List<Judge> judges ;
        DAO_Department dAO_Department = new DAO_Department();
        public InspectorLabelHistory()
        {
            judges = new List<Judge>()
            {
                new Judge{Display="ALL",Value="2"},
                new Judge{Display="OK",Value="1"},
                new Judge{Display="NG",Value="0"},
            };
            InitializeComponent();
        }
        DAO_Inspector_MAC_Address dAO_Inspector_MAC_Address = new DAO_Inspector_MAC_Address();
        static string CountOkRecords(DataTable dataTable)
        {
            try
            {
                int okCount = dataTable.AsEnumerable().Count(row => row.Field<bool>("Judge") == true);
                return okCount.ToString();
            }
            catch
            {
                return "0";
            }
        }
        static string CountNGRecords(DataTable dataTable)
        {
            try
            {
                int okCount = dataTable.AsEnumerable().Count(row => row.Field<bool>("Judge") == false);
                return okCount.ToString();
            }
            catch
            {
                return "0";
            }
        }
        private async void btnFilter_Click(object sender, EventArgs e)
        {
            DataTable dt = await dAO_Inspector_MAC_Address.Filter(cbbDepartment.SelectedValue.ToString(), txtSearchTerm.Text, cbbJudge.SelectedValue.ToString(), (Convert.ToBoolean(chkTime.Checked)), fromDate.Value, toDate.Value);
            dataGridView1.DataSource = dt;
            lbRowCount.Text = dt.Rows.Count.ToString();
            lbOKCount.Text = CountOkRecords(dt);
            lbNGCount.Text = CountNGRecords(dt);
        }
        List<string> departmentCodes = new List<string> { "Assy", "QC" };
        private async void InspectorLabelHistory_Load(object sender, EventArgs e)
        {
            //set data for Judge
            cbbJudge.DataSource = judges;
            cbbJudge.DisplayMember = "Display";
            cbbJudge.ValueMember = "Value";
            //
            cbbDepartment.DataSource = await dAO_Department.GetDeptByCodeArr(departmentCodes);
            cbbDepartment.DisplayMember = "Name";
            cbbDepartment.ValueMember = "ID";
        }
    }
}
