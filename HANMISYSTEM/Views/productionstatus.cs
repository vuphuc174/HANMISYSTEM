using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HANMISYSTEM
{
    public partial class productionstatus : Form
    {
        public productionstatus()
        {
            
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private void timer1_Tick(object sender, EventArgs e)
        {
            string a;
            //partno
            DataTable dt2 = connect.readdata("select * from runingstatus where idlocation='" + cblocation.SelectedValue + "' ");
            if (cblocation.Text == "")
            {
                timer1.Stop();
            }
            else
            {
                lbpartno.Text=dt2.Rows[0]["partno"].ToString();
            }
            DataTable dtupph = connect.readdata("select productivity from cargo where partno ='"+lbpartno.Text+"'");
            if(dtupph.Rows.Count>0)
            {
                lbupph.Text=dtupph.Rows[0]["productivity"].ToString();
            }
            DataTable dtplan = connect.readdata("select * from productionplan where idlocation='" + cblocation.SelectedValue + "' and productiondate='" + DateTime.Now.ToString("yyyy-MM-dd") + "' and partno='" + lbpartno.Text + "'");
            if (dtplan.Rows.Count > 0)
            {
                lbplan.Text = dtplan.Rows[0]["productionplan"].ToString();
            }
            else
            {
                lbplan.Text = "0";
                lbprogress.Text = "0";

            }


            DataTable dttarget = connect.readdata("select * from updatestatus where productiondate='"+DateTime.Now.ToString("yyyy-MM-dd")+"' and idlocation='"+cblocation.SelectedValue+"' and partno='"+lbpartno.Text+"'");
            if(dttarget.Rows.Count>0)
            {

                a=  dttarget.Rows[0]["currenttarget"].ToString();
                label3.Text = string.Format("{0:0.00}",Convert.ToDouble(a));
            }
            lbng.Text = connect.countdata("select count(quantity) from tbl_nghistory where partno='" + lbpartno.Text + "' and idlocation='" + cblocation.SelectedValue + "' and convert(date,productiontime)='" + DateTime.Now.ToString("yyyy-MM-dd") + "'").ToString();
            DataTable dtactual=connect.readdata("select sum(qty) as sl from productionhistory where partno='"+lbpartno.Text+"' and idlocation='"+cblocation.SelectedValue+"' and convert(date,productiontime)='"+DateTime.Now.ToString("yyyy-MM-dd")+"'");
            if (string.IsNullOrEmpty(dtactual.Rows[0]["sl"].ToString()))
            {
                lbactualqty.Text = "0";
                
            }
            else
            {
                lbactualqty.Text = dtactual.Rows[0]["sl"].ToString();
            }
                
            double achieve;
            achieve = Convert.ToDouble(lbactualqty.Text) / Convert.ToDouble(label3.Text) * 100;
            lbachieve.Text = string.Format("{0:0}", Convert.ToDouble(achieve));

        }
        
        private void productionstatus_Load(object sender, EventArgs e)
        {
            DataTable dt = connect.readdata("select * from tbl_user where username='" + HANMISYSTEM.Properties.Settings.Default.username + "'");
            string l = dt.Rows[0]["location"].ToString();

            if (l == "all")
            {
                DataTable dt1 = connect.readdata("select * from location where idwarehouse='WH001'");
                cblocation.DataSource = dt1;
                cblocation.DisplayMember = "namelocation";
                cblocation.ValueMember = "idlocation";

            }
            else
            {
                DataTable dt1 = connect.readdata("select * from location where idwarehouse='WH001' and idlocation='" + l + "'");
                cblocation.DataSource = dt1;
                cblocation.DisplayMember = "namelocation";
                cblocation.ValueMember = "idlocation";
                cblocation.SelectedValue = l;
            }
            timer1.Start();
            
        }


        private void cblocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = "0";
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cbpartno_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = connect.readdata("select * from productionplan where productiondate ='" + DateTime.Now.ToString("yyyy-MM-dd") + "' and partno='" + lbpartno.Text + "'");
            DataTable dt4 = connect.readdata("select * from updatestatus where productiondate ='" + DateTime.Now.ToString("yyyy-MM-dd") + "' and partno='" + lbpartno.Text + "'");
            if (dt2.Rows.Count > 0)
            {
                lbplan.Text = dt2.Rows[0]["productionplan"].ToString();
                DataTable dt3 = connect.readdata("select * from cargo where partno='" + lbpartno.Text + "'");
                lbpartname.Text = dt3.Rows[0]["partname"].ToString();

            }
            else
            {
                lbplan.Text = "0";
            }
            if(dt4.Rows.Count>0)
            {
                lbpartno.Text = dt4.Rows[0]["partno"].ToString();
            }
            
            label3.Text = "0";
        }

        private void cblocation_Click(object sender, EventArgs e)
        {
            
            
        }

        private void cbpartno_Click(object sender, EventArgs e)
        {
            
            
        }

        private void lbactualqty_TextChanged(object sender, EventArgs e)
        {
            double progress;
            
            if(lbactualqty.Text!="0")
            {
                 progress=Convert.ToDouble(lbactualqty.Text) / Convert.ToDouble(lbplan.Text) *100 ;

                 lbprogress.Text = string.Format("{0:0}", Convert.ToDouble(progress));
            }
            else
            {
                progress = 0;

                lbprogress.Text = string.Format("{0:0}", Convert.ToDouble(progress));
            }
            
        }

        private void label3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbpartno_TextChanged(object sender, EventArgs e)
        {
            DataTable dtcargo = connect.readdata("select * from cargo where partno ='"+lbpartno.Text+"'");
            if(dtcargo.Rows.Count>0)
            {
                lbpartname.Text=dtcargo.Rows[0]["partname"].ToString();
            }
            else
            {
                lbpartname.Text = "";
            }
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void lbachieve_TextChanged(object sender, EventArgs e)
        {
            if(Convert.ToDouble(lbachieve.Text)>=100)
            {
                lbtarget.BackColor = Color.Green;
            }
            else
            {
                lbtarget.BackColor = Color.Red;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
