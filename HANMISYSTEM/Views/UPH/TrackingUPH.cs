using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.UPH
{
    public partial class TrackingUPH : Form
    {
        public TrackingUPH()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private void TrackingUPH_Load(object sender, EventArgs e)
        {
            DataTable dtlocation = connect.readdata("select idlocation,namelocation1 from location");
            cbbLocation.DataSource = dtlocation;
            cbbLocation.DisplayMember = "namelocation1";
            cbbLocation.ValueMember = "idlocation";
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (txtModel.Text == "" || connect.countdata("select count(partno) from cargo where partno='" + txtModel.Text + "'") == 0)
            {
                MessageBox.Show("Mã hàng không hợp lệ");
            }
            else
            {

                DataTable dtTracking = connect.readdata("select partno,starttime,endtime,workingtime,productivity,remark from View_TrackingUPH where partno='" + txtModel.Text + "' and LocationID='" + cbbLocation.SelectedValue.ToString() + "' and convert(date,Starttime)='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'");

                dataGridView1.DataSource = dtTracking;

            }
        }
    }
}
