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
    public partial class Overviewv2 : Form
    {
        public Overviewv2()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private const int pagesize = 25;
        public int pagenumber = 1;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string result;
        private string mahoa(string s)
        {
            switch (s)
            {
                case "CONTROL PANEL":
                    result = "L1";
                    break;
                case "KV":
                    result = "L2";
                    break;
                case "NOZZLE 92":
                    result = "L3";
                    break;
                case "DRAWER":
                    result = "L4";
                    break;
                case "PIPE SUCTION":
                    result = "L5";
                    break;
                case "NOZZLE 62":
                    result = "L6";
                    break;
                case "HOSE,DRAIN":
                    result = "L7";
                    break;
                case "STATION":
                    result = "L8";
                    break;
                case "HANDLE":
                    result = "L9";
                    break;
            }
            return result;
        }
        private void Overviewv2_Load(object sender, EventArgs e)
        {
            btnpre.Enabled = false;
            dataGridView1.Rows.Clear();
            DataTable dtplan = connect.readdata("select  idlocation,namelocation1,partno,productionplan,inventory,actual,ng from overview where r>(((" + pagenumber + "-1)*" + pagesize + ")) and r<(" + pagenumber + " * " + pagesize + "+1)");
            dataGridView1.DataSource = dtplan;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["progress"].Value = (Convert.ToInt32(Convert.ToDouble(dataGridView1.Rows[i].Cells["actual"].Value) / Convert.ToDouble(dataGridView1.Rows[i].Cells["plan"].Value) * 100)).ToString() + "%";
            }
            timer1.Start();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void txtpagenumber_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtpagenumber.Text) == 1)
            {
                btnpre.Enabled = false;
            }
            else
            {
                btnpre.Enabled = true;
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            pagenumber = Convert.ToInt16(txtpagenumber.Text) + 1;
            txtpagenumber.Text = pagenumber.ToString();
            DataTable dtplan = connect.readdata("select  idlocation,namelocation1,partno,productionplan,inventory,actual,ng from overview where r>(((" + pagenumber + "-1)*" + pagesize + ")) and r<(" + pagenumber + " * " + pagesize + "+1)");
            dataGridView1.DataSource = dtplan;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["progress"].Value = (Convert.ToInt32(Convert.ToDouble(dataGridView1.Rows[i].Cells["actual"].Value) / Convert.ToDouble(dataGridView1.Rows[i].Cells["plan"].Value) * 100)).ToString() + "%";
            }
        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtpagenumber.Text) > 1)
            {
                pagenumber = Convert.ToInt16(txtpagenumber.Text) - 1;
                txtpagenumber.Text = pagenumber.ToString();
                DataTable dtplan = connect.readdata("select  idlocation,namelocation1,partno,productionplan,inventory,actual,ng from overview where r>(((" + pagenumber + "-1)*" + pagesize + ")) and r<(" + pagenumber + " * " + pagesize + "+1)");
                dataGridView1.DataSource = dtplan;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["progress"].Value = (Convert.ToInt32(Convert.ToDouble(dataGridView1.Rows[i].Cells["actual"].Value) / Convert.ToDouble(dataGridView1.Rows[i].Cells["plan"].Value) * 100)).ToString() + "%";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //dem row plan
            int _row = connect.countdata("select count(partno) from productionplan where productiondate ='" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
            if (_row > 25)
            {
                timer2.Start();
            }
            else
            {
                timer2.Stop();
            }
            //cap nhat data
            DataTable dtplan = connect.readdata("select  idlocation,namelocation1,partno,productionplan,inventory,actual,ng from overview where r>(((" + pagenumber + "-1)*" + pagesize + ")) and r<(" + pagenumber + " * " + pagesize + "+1) order by idlocation");
            dataGridView1.DataSource = dtplan;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["progress"].Value = (Convert.ToInt32(Convert.ToDouble(dataGridView1.Rows[i].Cells["actual"].Value) / Convert.ToDouble(dataGridView1.Rows[i].Cells["plan"].Value) * 100)).ToString() + "%";
            }
            //cap nhat color
            DataTable dtstatus = connect.readdata("select * from runingstatus");
            for (int i = 0; i < dtstatus.Rows.Count; i++)
            {
                if (dtstatus.Rows[i]["status"].ToString() == "CONTINUE")
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (dtstatus.Rows[i]["partno"].ToString() == row.Cells["partno"].Value.ToString() && dtstatus.Rows[i]["idlocation"].ToString() == mahoa(row.Cells["linename"].Value.ToString()))
                        {
                            row.DefaultCellStyle.BackColor = Color.Green;

                        }
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (dtstatus.Rows[i]["partno"].ToString() == row.Cells["partno"].Value.ToString() && dtstatus.Rows[i]["idlocation"].ToString() == mahoa(row.Cells["linename"].Value.ToString()))
                        {
                            row.DefaultCellStyle.BackColor = Color.Red;

                        }
                    }
                }
            }



        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (txtpagenumber.Text == "1")
            {
                pagenumber = 2;
                txtpagenumber.Text = "2";
                DataTable dtplan = connect.readdata("select  idlocation,namelocation1,partno,productionplan,inventory,actual,ng from overview where r>(((" + pagenumber + "-1)*" + pagesize + ")) and r<(" + pagenumber + " * " + pagesize + "+1)");
                dataGridView1.DataSource = dtplan;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["progress"].Value = (Convert.ToInt32(Convert.ToDouble(dataGridView1.Rows[i].Cells["actual"].Value) / Convert.ToDouble(dataGridView1.Rows[i].Cells["plan"].Value) * 100)).ToString() + "%";
                }
            }
            else
            {
                txtpagenumber.Text = "1";
                pagenumber = 1;
                DataTable dtplan = connect.readdata("select  idlocation,namelocation1,partno,productionplan,inventory,actual,ng from overview where r>(((" + pagenumber + "-1)*" + pagesize + ")) and r<(" + pagenumber + " * " + pagesize + "+1)");
                dataGridView1.DataSource = dtplan;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["progress"].Value = (Convert.ToInt32(Convert.ToDouble(dataGridView1.Rows[i].Cells["actual"].Value) / Convert.ToDouble(dataGridView1.Rows[i].Cells["plan"].Value) * 100)).ToString() + "%";
                }
            }
        }
    }
}
