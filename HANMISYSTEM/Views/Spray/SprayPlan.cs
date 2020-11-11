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
    public partial class SprayPlan : Form
    {
        public SprayPlan()
        {
            InitializeComponent();
        }
        Dbconnect dbconnect = new Dbconnect();
        string cmdResult;
        private void SprayPlan_Load(object sender, EventArgs e)
        {
            DataTable dtLine = dbconnect.readdata("select * from SprayLine");
            cbbLine.DataSource = dtLine;
            cbbLine.DisplayMember = "Name";
            cbbLine.ValueMember = "ID";
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            cmdResult = "Select Row_number() over (order by s.PST asc) as r,s.WO,s.PartNo,c.partname,s.pst,s.quantity,s.status from SprayPlan s inner join cargo c on s.PartNo=c.partno where s.LineID='" + cbbLine.SelectedValue.ToString() + "'";
            if( txtsearch.Text.Trim()=="")
            {
                cmdResult += " and s.PartNo like '%"+txtsearch.Text+"%' ";
            }
            if(checkBox1.Checked)
            {
                cmdResult += " and Convert(date,s.PST) = '"+dateTimePicker1.Value.ToString("yyyy-MM-dd")+"'";
            }
            else
            {
                cmdResult += " and Convert(date,s.PST) =convert(date,getdate())";
            }
            DataTable dt = dbconnect.readdata(cmdResult);
            dataGridView1.DataSource = dt;
        }
    }
}
