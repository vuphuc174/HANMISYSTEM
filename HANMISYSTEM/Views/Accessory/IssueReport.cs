using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.Accessory
{
    public partial class IssueReport : Form
    {
        public IssueReport()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            
            if(richTextBox1.Text.Length>0)
            {
                connect.exedata("with cte as (select top 1 Remark from TrackingUPH where PartNo='" + lbModel.Text + "' and LocationID='" + lbLocation.Text + "' order by StartTime Desc) update cte set Remark =Remark +' | ' +  '"+richTextBox1.Text+"' ");   
            }
            else
            {
                MessageBox.Show("Xin ghi vao nội dung submit");
            }
        }
    }
}
