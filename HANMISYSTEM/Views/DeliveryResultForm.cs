using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM
{
    public partial class DeliveryResultForm : Form
    {
        Dbconnect connect = new Dbconnect();
        public DeliveryResultForm()
        {
            InitializeComponent();
        }

        private void DeliveryResultForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataTable dtdeliveryresult = connect.readdata("select model,Quantity,Delivered, CONVERT(varchar(12), ISNULL(Delivered, 0) / Quantity * 100) + '%' AS DeliveryRate,ProductionResult,CONVERT(varchar(12),(ProductionResult/Quantity*100))+'%' as ProductionRate from view_delivery_overview");
            dataGridView1.DataSource = dtdeliveryresult;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToDouble(row.Cells["lgplan"].Value.ToString()) == Convert.ToDouble(row.Cells["deliveryresult"].Value.ToString()))
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
