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
        double sumprod;
        double sumwt;
        private void TrackingUPH_Load(object sender, EventArgs e)
        {
            sumprod = 0;
            sumwt = 0;
            DataTable dtlocation = connect.readdata("select idlocation,namelocation1 from location");
            cbbLocation.DataSource = dtlocation;
            cbbLocation.DisplayMember = "namelocation1";
            cbbLocation.ValueMember = "idlocation";
            DataTable dtproduct = connect.readdata("select distinct partno from trackinguph where locationid='"+cbbLocation.SelectedValue.ToString()+"' and convert(date,StartTime)=convert(date,getdate())");
            dtproduct.Rows.Add("ALL");
            cbbModel.DataSource = dtproduct;
            cbbModel.DisplayMember = "partno";
            cbbModel.ValueMember = "partno";
            cbbModel.SelectedValue = "ALL";
        }
        
        private void btnFilter_Click(object sender, EventArgs e)
        {
            sumprod = 0;
            sumwt = 0;
        
            if (cbbModel.Text == "ALL")
            {
                DataTable dtTracking = connect.readdata("select  partno,starttime,endtime,workingtime,isnull(productivity,0) as productivity,remark from View_TrackingUPH where  LocationID='" + cbbLocation.SelectedValue.ToString() + "' and convert(date,Starttime)='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'");
                dataGridView1.DataSource = dtTracking;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    sumprod += Convert.ToDouble(row.Cells["productivity"].Value.ToString());
                    sumwt += Convert.ToDouble(row.Cells["workingtime"].Value.ToString());
                    row.Cells["uph"].Value = (Convert.ToDouble(row.Cells["productivity"].Value.ToString()) / Convert.ToDouble(row.Cells["workingtime"].Value.ToString())).ToString("0.00");
                }
            }
            else
            {
                if (cbbModel.Text == "" || connect.countdata("select count(partno) from cargo where partno='" + cbbModel.Text + "'") == 0)
                {
                    MessageBox.Show("Mã hàng không hợp lệ");
                }
                else
                {
                    DataTable dtTracking = connect.readdata("select  partno,starttime,endtime,workingtime,isnull(productivity,0) as productivity,remark from View_TrackingUPH where partno='" + cbbModel.Text + "' and LocationID='" + cbbLocation.SelectedValue.ToString() + "' and convert(date,Starttime)='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'");
                    dataGridView1.DataSource = dtTracking;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        sumprod += Convert.ToDouble(row.Cells["productivity"].Value.ToString());
                        sumwt += Convert.ToDouble(row.Cells["workingtime"].Value.ToString());
                        row.Cells["uph"].Value = (Convert.ToDouble(row.Cells["productivity"].Value.ToString()) / Convert.ToDouble(row.Cells["workingtime"].Value.ToString())).ToString("0.00");
                    }

                }
            }
            lbuph.Text = (sumprod / sumwt).ToString("0.00");
            label6.Text = sumwt.ToString("0.00");
        }

        private void cbbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtproduct = connect.readdata("select distinct partno from trackinguph where locationid='" + cbbLocation.SelectedValue.ToString() + "' and convert(date,StartTime)='"+dateTimePicker1.Value.ToString("yyyy-MM-dd")+"'");
            dtproduct.Rows.Add("ALL");
            cbbModel.DataSource = dtproduct;
            cbbModel.DisplayMember = "partno";
            cbbModel.ValueMember = "partno";
            cbbModel.SelectedValue = "ALL";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            DataTable dtproduct = connect.readdata("select distinct partno from trackinguph where locationid='" + cbbLocation.SelectedValue.ToString() + "' and convert(date,StartTime)='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'");
            dtproduct.Rows.Add("ALL");
            cbbModel.DataSource = dtproduct;
            cbbModel.DisplayMember = "partno";
            cbbModel.ValueMember = "partno";
            cbbModel.SelectedValue = "ALL";
        }
    }
}
