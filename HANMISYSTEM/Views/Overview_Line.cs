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
    public partial class Overview_Line : Form
    {
        public Overview_Line()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private void Overview_Line_Load(object sender, EventArgs e)
        {

            
            timer1.Start();

        }
        public List<Label> labels = new List<Label>();

        private void timer1_Tick(object sender, EventArgs e)
        {
            labels.Add(lbline1);
            labels.Add(lbline2);
            labels.Add(lbline3);
            labels.Add(lbline4);
            labels.Add(lbline5);
            labels.Add(lbline6);
            labels.Add(lbline7);
            DataTable dtstatus = connect.readdata("select status from runingstatus");
            
            try
            {
                for(int i=0;i<dtstatus.Rows.Count;i++)
                {
                    if(dtstatus.Rows[i]["status"].ToString()!="CONTINUE")
                    {
                        labels[i].BackColor = Color.Red; 
                    }
                    else
                    {
                        labels[i].BackColor = Color.Black;
                    }
                }
            }
            catch
            {

            }
            DataTable dt111 = connect.readdata("select * from runingstatus");
            try
            {
                lbpartno1.Text = dt111.Rows[0]["partno"].ToString();
                lbpartno2.Text = dt111.Rows[1]["partno"].ToString();
                lbpartno3.Text = dt111.Rows[2]["partno"].ToString();
                lbpartno4.Text = dt111.Rows[3]["partno"].ToString();
                lbpartno5.Text = dt111.Rows[4]["partno"].ToString();
                lbpartno6.Text = dt111.Rows[5]["partno"].ToString();
                lbpartno7.Text = dt111.Rows[6]["partno"].ToString();
            }
            catch
            {

            }
            if(lbpartno1.Text=="")
            {
                lbinventory1.Text = "0";
                lbplan1.Text = "0";
                lbactual1.Text = "0";
                lbng1.Text = "0";
                
            }
            else
            {
                DataTable dtplan1 = connect.readdata("select * from productionplan where idwarehouse='WH001' and idlocation ='L1' and partno='" + lbpartno1.Text + "' and productiondate='" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
                if (dtplan1.Rows.Count > 0)
                {
                    lbplan1.Text = dtplan1.Rows[0]["productionplan"].ToString();
                }
                DataTable dt7 = connect.readdata("select * from view_stock_production where partno='" + lbpartno1.Text + "'");
                if (dt7.Rows.Count > 0)
                {
                    lbinventory1.Text = dt7.Rows[0]["qty"].ToString();
                }
                DataTable dtactual1 = connect.readdata("select sum(qty) as sl from productionhistory where idwarehouse='WH001' and idlocation ='L1' and partno ='" + lbpartno1.Text + "' and CONVERT(date,productiontime) ='" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
                if(dtactual1.Rows.Count>0)
                {
                    lbactual1.Text = dtactual1.Rows[0]["sl"].ToString();
                }
                lbng1.Text = connect.countdata("select COUNT(quantity) from tbl_nghistory where idwarehouse='WH001' and idlocation ='L1' and partno ='" + lbpartno1.Text + "' and CONVERT(date,productiontime) ='" + DateTime.Now.ToString("yyyy-MM-dd") + "'").ToString();
                DataTable dt1 = connect.readdata("select * from updatestatus where partno='" + lbpartno1.Text + "' and productiondate='" + DateTime.Now.ToString("yyyy-MM-dd") + "' and idlocation ='L1'");
               
            }

            if (lbpartno2.Text == "")
            {
                lbinventory2.Text = "0";
                lbplan2.Text = "0";
                lbactual2.Text = "0";
                lbng2.Text = "0";
               
            }
            else
            {
                DataTable dtplan2 = connect.readdata("select * from productionplan where idwarehouse='WH001' and idlocation ='L2' and partno='" + lbpartno2.Text + "' and productiondate='" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
                if (dtplan2.Rows.Count > 0)
                {
                    lbplan2.Text = dtplan2.Rows[0]["productionplan"].ToString();
                }
                DataTable dt8 = connect.readdata("select * from view_stock_production where partno='" + lbpartno2.Text + "'");
                if (dt8.Rows.Count > 0)
                {
                    lbinventory2.Text = dt8.Rows[0]["qty"].ToString();
                }
                DataTable dtactual2 = connect.readdata("select sum(qty) as sl from productionhistory where idwarehouse='WH001' and idlocation ='L2' and partno ='" + lbpartno2.Text + "' and CONVERT(date,productiontime) ='" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
                if (dtactual2.Rows.Count > 0)
                {
                    lbactual2.Text = dtactual2.Rows[0]["sl"].ToString();
                }
                lbng2.Text = connect.countdata("select COUNT(quantity) from tbl_nghistory where idwarehouse='WH001' and idlocation ='L2' and partno ='" + lbpartno2.Text + "' and CONVERT(date,productiontime) ='" + DateTime.Now.ToString("yyyy-MM-dd") + "'").ToString();
               
            }
            if (lbpartno3.Text == "")
            {
                lbinventory3.Text = "0";
                lbplan3.Text = "0";
                lbactual3.Text = "0";
                lbng3.Text = "0";
                
            }
            else
            {
                DataTable dtplan3 = connect.readdata("select * from productionplan where idwarehouse='WH001' and idlocation ='L3' and partno='" + lbpartno3.Text + "' and productiondate='" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
                if (dtplan3.Rows.Count > 0)
                {
                    lbplan3.Text = dtplan3.Rows[0]["productionplan"].ToString();
                }
                DataTable dt9 = connect.readdata("select * from view_stock_production where partno='" + lbpartno3.Text + "'");
                if (dt9.Rows.Count > 0)
                {
                    lbinventory3.Text = dt9.Rows[0]["qty"].ToString();
                }
                DataTable dtactual3 = connect.readdata("select sum(qty) as sl from productionhistory where idwarehouse='WH001' and idlocation ='L3' and partno ='" + lbpartno3.Text + "' and CONVERT(date,productiontime) ='" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
                if (dtactual3.Rows.Count > 0)
                {
                    lbactual3.Text = dtactual3.Rows[0]["sl"].ToString();
                }
                lbng3.Text = connect.countdata("select COUNT(quantity) from tbl_nghistory where idwarehouse='WH001' and idlocation ='L3' and partno ='" + lbpartno3.Text + "' and CONVERT(date,productiontime) ='" + DateTime.Now.ToString("yyyy-MM-dd") + "'").ToString();
                
            }
            if (lbpartno4.Text == "")
            {
                lbinventory4.Text = "0";
                lbplan4.Text = "0";
                lbactual4.Text = "0";
                lbng4.Text = "0";
               
            }
            else
            {
                DataTable dtplan4 = connect.readdata("select * from productionplan where idwarehouse='WH001' and idlocation ='L4' and partno='" + lbpartno4.Text + "' and productiondate='" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
                if (dtplan4.Rows.Count > 0)
                {
                    lbplan4.Text = dtplan4.Rows[0]["productionplan"].ToString();
                }
                DataTable dt10 = connect.readdata("select * from view_stock_production where partno='" + lbpartno4.Text + "'");
                if (dt10.Rows.Count > 0)
                {
                    lbinventory4.Text = dt10.Rows[0]["qty"].ToString();
                }
                DataTable dtactual4 = connect.readdata("select sum(qty) as sl from productionhistory where idwarehouse='WH001' and idlocation ='L4' and partno ='" + lbpartno4.Text + "' and CONVERT(date,productiontime) ='" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
                if (dtactual4.Rows.Count > 0)
                {
                    lbactual4.Text = dtactual4.Rows[0]["sl"].ToString();
                }
                lbng4.Text = connect.countdata("select COUNT(quantity) from tbl_nghistory where idwarehouse='WH001' and idlocation ='L4' and partno ='" + lbpartno4.Text + "' and CONVERT(date,productiontime) ='" + DateTime.Now.ToString("yyyy-MM-dd") + "'").ToString();
                
            }
            if (lbpartno5.Text == "")
            {
                lbinventory5.Text = "0";
                lbplan5.Text = "0";
                lbactual5.Text = "0";
                lbng5.Text = "0";
                
            }
            else
            {
                DataTable dtplan5 = connect.readdata("select * from productionplan where idwarehouse='WH001' and idlocation ='L5' and partno='" + lbpartno5.Text + "'and productiondate='" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
                if (dtplan5.Rows.Count > 0)
                {
                    lbplan5.Text = dtplan5.Rows[0]["productionplan"].ToString();
                }
                DataTable dt11 = connect.readdata("select * from view_stock_production where partno='" + lbpartno5.Text + "'");
                if (dt11.Rows.Count > 0)
                {
                    lbinventory5.Text = dt11.Rows[0]["qty"].ToString();
                }
                DataTable dtactual5 = connect.readdata("select sum(qty) as sl from productionhistory where idwarehouse='WH001' and idlocation ='L5' and partno ='" + lbpartno5.Text + "' and CONVERT(date,productiontime) ='" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
                if (dtactual5.Rows.Count > 0)
                {
                    lbactual5.Text = dtactual5.Rows[0]["sl"].ToString();
                }

                lbng5.Text = connect.countdata("select COUNT(quantity) from tbl_nghistory where idwarehouse='WH001' and idlocation ='L5' and partno ='" + lbpartno5.Text + "' and CONVERT(date,productiontime) ='" + DateTime.Now.ToString("yyyy-MM-dd") + "'").ToString();
                
            }
            if (lbpartno6.Text == "")
            {
                lbinventory6.Text = "0";
                lbplan6.Text = "0";
                lbactual6.Text = "0";
                lbng6.Text = "0";
                
            }
            else
            {
                DataTable dtplan6 = connect.readdata("select * from productionplan where idwarehouse='WH001' and idlocation ='L6' and partno='" + lbpartno6.Text + "'and productiondate='" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
                if (dtplan6.Rows.Count > 0)
                {
                    lbplan6.Text = dtplan6.Rows[0]["productionplan"].ToString();
                }
                DataTable dt12 = connect.readdata("select * from view_stock_production where partno='" + lbpartno6.Text + "'");
                if (dt12.Rows.Count > 0)
                {
                    lbinventory6.Text = dt12.Rows[0]["qty"].ToString();
                }
                lbng6.Text = connect.countdata("select COUNT(quantity) from tbl_nghistory where idwarehouse='WH001' and idlocation ='L6' and partno ='" + lbpartno6.Text + "' and CONVERT(date,productiontime) ='" + DateTime.Now.ToString("yyyy-MM-dd") + "'").ToString();
                DataTable dtactual6 = connect.readdata("select sum(qty) as sl from productionhistory where idwarehouse='WH001' and idlocation ='L6' and partno ='" + lbpartno6.Text + "' and CONVERT(date,productiontime) ='" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
                if (dtactual6.Rows.Count > 0)
                {
                    lbactual6.Text = dtactual6.Rows[0]["sl"].ToString();
                }
               
            }
            if (lbpartno7.Text == "")
            {
                lbinventory7.Text = "0";
                lbplan7.Text = "0";
                lbactual7.Text = "0";
                lbng7.Text = "0";
                
            }
            else
            {
                DataTable dtplan7 = connect.readdata("select * from productionplan where idwarehouse='WH001' and idlocation ='L7' and partno='" + lbpartno7.Text + "'and productiondate='" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
                if (dtplan7.Rows.Count > 0)
                {
                    lbplan7.Text = dtplan7.Rows[0]["productionplan"].ToString();
                }
                // inventory

                DataTable dt13 = connect.readdata("select * from view_stock_production where partno='" + lbpartno7.Text + "'");

                if (dt13.Rows.Count > 0)
                {
                    lbinventory7.Text = dt13.Rows[0]["qty"].ToString();
                }

                // actual quantity

                DataTable dtactual7 = connect.readdata("select sum(qty) as sl from productionhistory where idwarehouse='WH001' and idlocation ='L7' and partno ='" + lbpartno7.Text + "' and CONVERT(date,productiontime) ='" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
                if (dtactual7.Rows.Count > 0)
                {
                    lbactual7.Text = dtactual7.Rows[0]["sl"].ToString();
                }

                // ng quantity


                lbng7.Text = connect.countdata("select COUNT(quantity) from tbl_nghistory where idwarehouse='WH001' and idlocation ='L7' and partno ='" + lbpartno7.Text + "' and CONVERT(date,productiontime) ='" + DateTime.Now.ToString("yyyy-MM-dd") + "'").ToString();

                //target 

              

                
            }
            //plan
            
        }

        private void lbactual1_TextChanged(object sender, EventArgs e)
        {

            if (lbplan1.Text == "0")
            {
                lbprogress1.Text = "0";
            }
            else
            {
                lbprogress1.Text =string.Format("{0:0}",(Convert.ToDouble(lbactual1.Text) / Convert.ToDouble(lbplan1.Text) * 100));
            }
            
        }

        private void lbactual2_TextChanged(object sender, EventArgs e)
        {
            if (lbplan2.Text == "0")
            {
                lbprogress2.Text = "0";
            }
            else
            {
                lbprogress2.Text = string.Format("{0:0}",(Convert.ToDouble(lbactual2.Text) / Convert.ToDouble(lbplan2.Text)*100));
            }
        }

        private void lbactual3_TextChanged(object sender, EventArgs e)
        {
            if (lbplan3.Text == "0")
            {
                lbprogress3.Text = "0";
            }
            else
            {
                lbprogress3.Text = string.Format("{0:0}",(Convert.ToDouble(lbactual3.Text) / Convert.ToDouble(lbplan3.Text)*100));
            }
        }

        private void lbactual4_TextChanged(object sender, EventArgs e)
        {
            if (lbplan4.Text == "0")
            {
                lbprogress4.Text = "0";
            }
            else
            {
                lbprogress4.Text = string.Format("{0:0}",(Convert.ToDouble(lbactual4.Text) / Convert.ToDouble(lbplan4.Text)*100));
            }
        }

       

        private void lbactual6_TextChanged(object sender, EventArgs e)
        {
            if (lbplan6.Text == "0")
            {
                lbprogress6.Text = "0";
            }
            else
            {
                lbprogress6.Text = string.Format("{0:0}",(Convert.ToDouble(lbactual6.Text) / Convert.ToDouble(lbplan6.Text)*100));
            }
        }

        private void lbactual5_TextChanged(object sender, EventArgs e)
        {
            if (lbplan5.Text == "0")
            {
                lbprogress5.Text = "0";
            }
            else
            {
                lbprogress5.Text = string.Format("{0:0}",(Convert.ToDouble(lbactual5.Text) / Convert.ToDouble(lbplan5.Text)*100));
            }
        }
        private void lbactual7_TextChanged(object sender, EventArgs e)
        {
            if (lbplan7.Text == "0")
            {
                lbprogress7.Text = "0";
            }
            else
            {
                lbprogress7.Text = string.Format("{0:0}", (Convert.ToDouble(lbactual7.Text) / Convert.ToDouble(lbplan7.Text) * 100));
            }
        }

        private void lbplan1_Click(object sender, EventArgs e)
        {

        }

        private void lbachieve1_Click(object sender, EventArgs e)
        {

        }

        

       

       

       
       
        
        

        private void label9_Click(object sender, EventArgs e)
        {

        }

     

        private void lbactual7_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void Overview_Line_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

       

        
    }
}
