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

namespace HANMISYSTEM.Views.Warehouse
{
    public partial class SlipoutDetails : Form
    {
        public SlipoutDetails()
        {
            InitializeComponent();
        }
        DAO_Slipout dAO_Slipout = new DAO_Slipout();
        public string _slipoutID;

        private async void SlipoutDetails_Load(object sender, EventArgs e)
        {
            lbHeader.Text="Chi tiết <"+_slipoutID+">";
            DataTable dt = await dAO_Slipout.GetSlipoutDetails(_slipoutID);
            dataGridView1.DataSource = dt;
            lbPackageCount.Text = dt.Rows.Count.ToString();
            double sum=0;
            for(int i=0;i<dt.Rows.Count;i++)
            {
                sum += Convert.ToDouble(dt.Rows[i]["quantity"].ToString());
            }
            lbProductCount.Text = sum.ToString("N0");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
