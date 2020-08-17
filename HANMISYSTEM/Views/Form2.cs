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
    public partial class productionline2 : Form
    {
        public productionline2()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private void loaddata(string cmd)
        {
            DataTable dt = connect.readdata(cmd);
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void productionline2_Load(object sender, EventArgs e)
        {
            DataTable dt2;
            DataTable dtcargo  = connect.readdata("select * from cargo where idcategory like '3' order by partno desc");
            loaddata("select * from view_stock_production");
            DataTable dt = connect.readdata("select * from warehouse where idwarehouse='WH001'");
            DataTable dt3 = connect.readdata("select * from tbl_user where username='" + HANMISYSTEM.Properties.Settings.Default.username + "'");

            if (dtcargo  != null)
            {
                try
                {
                    cbpartno.DataSource = dtcargo;
                    cbpartno.DisplayMember = "partno";
                    cbpartno.ValueMember = "partno";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection faile", ex.ToString());
                }
            }
            if(dt.Rows.Count>0)
            {
                cbwarehouse.DataSource = dt;
                cbwarehouse.DisplayMember = "namewarehouse";
                cbwarehouse.ValueMember = "idwarehouse";
            }
            if (dt3.Rows[0]["location"].ToString() == "all")
            {
                dt2 = connect.readdata("select * from location where idwarehouse='" + cbwarehouse.SelectedValue + "'");
            }
            else
            {
                dt2 = connect.readdata("select * from location where idwarehouse='" + cbwarehouse.SelectedValue + "' and idlocation='" + dt3.Rows[0]["location"].ToString() + "'");
            }
            if (dt2 != null)
            {
                try
                {
                    cblocation.DataSource = dt2;
                    cblocation.DisplayMember = "namelocation";
                    cblocation.ValueMember = "idlocation";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kết nối thất bại", ex.ToString());
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnpower_Click(object sender, EventArgs e)
        {
            if (btnpower.Text == "Stop line")
            {
                btnpower.Text = "CONTINUE";
                checkBox1.Enabled = true;
                HANMISYSTEM.Properties.Settings.Default.status = "CONTINUE";
                Properties.Settings.Default.Save();
                cbpartno.Enabled = false;
                cbwarehouse.Enabled = false;
                cblocation.Enabled = false;
                DataTable dt = connect.readdata("select * from productionstatus where partno='" + cbpartno.Text.ToUpper() + "' and productiondate='" + DateTime.Now.ToString("yyyy-MM-dd") + "' and idlocation='" + cblocation.SelectedValue + "'");
                if (dt.Rows.Count > 0)
                {
                    connect.exedata("update productionstatus set continuetime='" + DateTime.Now + "' where idlocation='" + cblocation.SelectedValue + "' and partno='" + cbpartno.Text.ToUpper() + "' and productiondate='" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
                }
                else
                {
                    connect.exedata("insert into productionstatus (partno,idwarehouse,idlocation,productiondate,starttime) values('" + cbpartno.Text.ToUpper() + "','" + cbwarehouse.SelectedValue + "','" + cblocation.SelectedValue + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + DateTime.Now + "')");
                }
                timer1.Start();
            }
            else
            {
                btnpower.Text = "Stop line";
                checkBox1.Enabled = false;
                HANMISYSTEM.Properties.Settings.Default.status = "Stop line";
                Properties.Settings.Default.Save();
                cbpartno.Enabled = true;
                cbwarehouse.Enabled = true;
                cblocation.Enabled = true;
                timer1.Stop();
                DialogResult dlr;
                dlr = MessageBox.Show("Stop working day/Break time? (Yes/No) ", "Notice", MessageBoxButtons.YesNoCancel);
                if (dlr == DialogResult.Yes)
                {
                    connect.exedata("update runingstatus set partno='' where idwarehouse='WH001' and idlocation='" + cblocation.SelectedValue + "'");
                    connect.exedata("insert into productionhistory (idwarehouse,partno,idlocation,stoptime,remark) values ('" + cbwarehouse.SelectedValue + "','" + cbpartno.Text.ToUpper() + "','" + cblocation.SelectedValue + "','" + DateTime.Now + "','Stop working day')");
                    connect.exedata("update productionstatus set stoptime='" + DateTime.Now + "',lastesttarget='0' where idlocation='" + cblocation.SelectedValue + "' and partno='" + cbpartno.Text.ToUpper() + "'and productiondate='" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
                    txttarget.Text = "0";
                    txtboxno.Text = "";
                    txtqty.Text = "0";
                    

                }
                else if (dlr == DialogResult.No)
                {

                    connect.exedata("insert into productionhistory (idwarehouse,partno,idlocation,stoptime,remark) values ('" + cbwarehouse.SelectedValue + "','" + cbpartno.SelectedValue.ToString() + "','" + cblocation.SelectedValue + "','" + DateTime.Now + "','Break time')");
                    connect.exedata("update productionstatus set stoptime='" + DateTime.Now + "',lastesttarget='" + txttarget.Text + "' where idlocation='" + cblocation.SelectedValue + "' and partno='" + cbpartno.Text.ToUpper() + "' and productiondate='" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
                }
                else
                {
                    btnpower.Text = "CONTINUE";
                    cbpartno.Enabled = false;
                    timer1.Start();
                }
            }
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
