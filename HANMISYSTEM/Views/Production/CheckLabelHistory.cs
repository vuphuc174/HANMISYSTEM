using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.Production
{
    public partial class CheckLabelHistory : Form
    {
        public CheckLabelHistory()
        {
            InitializeComponent();
        }
        Dbconnect connect =new Dbconnect();
        private void CheckLabelHistory_Load(object sender, EventArgs e)
        {
            DataTable dtLine = connect.readdata("select idlocation,namelocation1 from location where idlocation <> 'L12'");
            cbbLine.DataSource = dtLine;
            cbbLine.ValueMember = "idlocation";
            cbbLine.DisplayMember = "namelocation1";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtPartno.Text))
            {
                DataTable dtHistory = connect.readdata($"select clh.id,clh.partno,c.partname,clh.judge,clh.judgetime,clh.remark,l.namelocation1 from CheckLabelHistory clh inner join cargo c on clh.partno=c.partno inner join location l on clh.lineID =l.idlocation where clh.lineID ={cbbLine.SelectedValue.ToString()} and convert(date,clh.JudgeTime) between '{dtpStartDate.Value.ToString("yyyy-MM-dd")}' and '{dtpEndDate.Value.ToString("yyyy-MM-dd")}'");
                dataGridView1.DataSource = dtHistory;
            }
            else
            {
                DataTable dtHistory = connect.readdata($"select clh.id,clh.partno,c.partname,clh.judge,clh.judgetime,clh.remark,l.namelocation1 from CheckLabelHistory clh inner join cargo c on clh.partno=c.partno inner join location l on clh.lineID =l.idlocation where clh.partno like '%{txtPartno.Text}%' and clh.lineID ={cbbLine.SelectedValue.ToString()} and convert(date,clh.JudgeTime) between '{dtpStartDate.Value.ToString("yyyy-MM-dd")}' and '{dtpEndDate.Value.ToString("yyyy-MM-dd")}'");
                dataGridView1.DataSource = dtHistory;
            }
        }
    }
}
