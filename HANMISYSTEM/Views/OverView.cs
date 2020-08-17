using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views
{
    public partial class OverView : Form
    {
        public OverView()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private void OverView_Load(object sender, EventArgs e)
        {
            DataTable dt = connect.readdata("select * from view_overview order by idlocation asc");
            dataGridView1.DataSource = dt;
            timer1.Start();
            DataTable dtstatus = connect.readdata("select * from runingstatus");
            for (int i = 0; i < dtstatus.Rows.Count; i++)
            {
                if (dtstatus.Rows[i]["status"].ToString() == "CONTINUE")
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (dtstatus.Rows[i]["idlocation"].ToString() == row.Cells["id"].Value.ToString())
                        {
                            row.DefaultCellStyle.BackColor = Color.Green;

                        }
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (dtstatus.Rows[i]["idlocation"].ToString() == row.Cells["id"].Value.ToString())
                        {
                            row.DefaultCellStyle.BackColor = Color.Red;

                        }
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataTable dt = connect.readdata("select * from view_overview order by  cast(substring(idlocation,2,LEN(idlocation))as int) asc");
            dataGridView1.DataSource = dt;
            //cap nhat color
            DataTable dtstatus = connect.readdata("select * from runingstatus");
            for (int i = 0; i < dtstatus.Rows.Count; i++)
            {
                if (dtstatus.Rows[i]["status"].ToString() == "CONTINUE")
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (dtstatus.Rows[i]["idlocation"].ToString() == row.Cells["id"].Value.ToString())
                        {
                            row.DefaultCellStyle.BackColor = Color.Green;

                        }
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (dtstatus.Rows[i]["idlocation"].ToString() == row.Cells["id"].Value.ToString())
                        {
                            row.DefaultCellStyle.BackColor = Color.Red;

                        }
                    }
                }
            }
        }
    }
}
