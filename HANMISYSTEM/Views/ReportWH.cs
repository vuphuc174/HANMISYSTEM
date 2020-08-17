using HANMISYSTEM.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;

namespace HANMISYSTEM
{
    public partial class ReportWH : Form
    {
        public ReportWH()
        {
            InitializeComponent();

        }
        Dbconnect connect = new Dbconnect();
        private const int pagesize = 20;
        public int pagenumber = 1;
        private void ReportWH_Load(object sender, EventArgs e)
        {





        }
        private string monthdesc()
        {
            int m = Convert.ToInt32(DateTime.Now.Month.ToString());
            int y = Convert.ToInt32(DateTime.Now.Year.ToString());
            if (m == 1)
            {
                y = y - 1;
                m = 12;
            }
            else
            {
                m = m - 1;
            }
            if (m >= 10)
            {
                return y + "-" + m;
            }
            else
            {
                return y + "-" + m.ToString("00");
            }

        }
        private string replacenull(string e)
        {
            if (string.IsNullOrEmpty(e))
            {
                e = "0";
            }

            return e;
        }
        private DataTable dt;
        private void cbwarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            txtsearch.Text = "";
            pagenumber = 1;
            txtpagenumber.Text = pagenumber.ToString();
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing; //or even better .DisableResizing. Most time consumption enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            dataGridView1.RowHeadersVisible = false;
            //dataGridView1.Rows.Clear();
            DataTable dt = (DataTable)dataGridView1.DataSource;
            if (dt != null)
                dt.Clear();
            if (cbwarehouse.SelectedValue.ToString() == "WH001")
            {
                dt = connect.readdata("select * from view_report_production");
                dataGridView1.DataSource = dt;
            }
            if (cbwarehouse.SelectedValue.ToString() == "WH002")
            {

                dt = connect.readdata("select a.* from(select ROW_NUMBER() over (order by partno asc) as r, partno,stocklastmonth,inother,outother,inventory,ng,lost from view_report_" + mahoa(cbwarehouse.SelectedValue.ToString()) + ") a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1) ");
                dataGridView1.DataSource = dt;


            }
            if (cbwarehouse.SelectedValue.ToString() == "WH003")
            {
                dt = connect.readdata("select a.* from(select ROW_NUMBER() over (order by partno asc) as r, partno,stocklastmonth,inother,outother,inventory,ng,lost from view_report_" + mahoa(cbwarehouse.SelectedValue.ToString()) + ") a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1) ");
                dataGridView1.DataSource = dt;
            }
            if (cbwarehouse.SelectedValue.ToString() == "WH005")
            {
                dt = connect.readdata("select a.* from(select ROW_NUMBER() over (order by partno asc) as r, partno,stocklastmonth,inother,outother,inventory,ng,lost from view_report_" + mahoa(cbwarehouse.SelectedValue.ToString()) + ") a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1) ");
                dataGridView1.DataSource = dt;
            }
            if (cbwarehouse.SelectedValue.ToString() == "WH006")
            {
                dt = connect.readdata("select * from view_report_delivery");
                dataGridView1.DataSource = dt;
            }
            if (cbwarehouse.SelectedValue.ToString() == "WH011")
            {
                dt = connect.readdata("select a.* from(select ROW_NUMBER() over (order by partno asc) as r, partno,stocklastmonth,inother,outother,inventory,ng,lost from view_report_" + mahoa(cbwarehouse.SelectedValue.ToString()) + ") a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1) ");
                dataGridView1.DataSource = dt;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                DataTable dtidcategory = connect.readdata("select idcategory from cargo where partno='" + dataGridView1.Rows[i].Cells["partno"].Value + "'");

                if (cbwarehouse.SelectedValue.ToString() != "WH002" && cbwarehouse.SelectedValue.ToString() != "WH003" && cbwarehouse.SelectedValue.ToString() != "WH005" && cbwarehouse.SelectedValue.ToString() != "WH011")
                {
                    if (dtidcategory.Rows[0]["idcategory"].ToString() == "3")
                    {
                        dataGridView1.Rows[i].Cells["totaloutproduction"].Value = "0";
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells["totaloutproduction"].Value = Convert.ToDouble(replacenull(dataGridView1.Rows[i].Cells["ng"].Value.ToString())) + Convert.ToDouble(replacenull(dataGridView1.Rows[i].Cells["outproduction"].Value.ToString()));
                    }
                }


                //production
                if (cbwarehouse.SelectedValue.ToString() == "WH001")
                {
                    if (dtidcategory.Rows[0]["idcategory"].ToString() == "3")
                    {
                        if (string.IsNullOrEmpty(dataGridView1.Rows[i].Cells["inproduction"].Value.ToString()) || dataGridView1.Rows[i].Cells["inproduction"].Value.ToString() == "0")
                        {
                            dataGridView1.Rows[i].Cells["ngrate"].Value = "0";
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells["ngrate"].Value = string.Format("{0:0.00}", Convert.ToDouble(replacenull(dataGridView1.Rows[i].Cells["ng"].Value.ToString())) / Convert.ToDouble(dataGridView1.Rows[i].Cells["inproduction"].Value.ToString()) * 100);
                        }
                        //lost rate finished good production

                        if (string.IsNullOrEmpty(dataGridView1.Rows[i].Cells["inproduction"].Value.ToString()) || dataGridView1.Rows[i].Cells["inproduction"].Value.ToString() == "0")
                        {
                            dataGridView1.Rows[i].Cells["lossrate"].Value = "0";
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells["lossrate"].Value = string.Format("{0:0.00}", Convert.ToDouble(replacenull(dataGridView1.Rows[i].Cells["lost"].Value.ToString())) / Convert.ToDouble(dataGridView1.Rows[i].Cells["inproduction"].Value.ToString()) * 100);
                        }


                    }
                    else
                    {
                        if (string.IsNullOrEmpty(dataGridView1.Rows[i].Cells["totaloutproduction"].Value.ToString()) || dataGridView1.Rows[i].Cells["totaloutproduction"].Value.ToString() == "0")
                        {
                            dataGridView1.Rows[i].Cells["ngrate"].Value = "0";
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells["ngrate"].Value = string.Format("{0:0.00}", Convert.ToDouble(replacenull(dataGridView1.Rows[i].Cells["ng"].Value.ToString())) / Convert.ToDouble(dataGridView1.Rows[i].Cells["totaloutproduction"].Value.ToString()) * 100);
                        }
                        //lost rate single part produciton
                        if (string.IsNullOrEmpty(dataGridView1.Rows[i].Cells["inproduction"].Value.ToString()) || dataGridView1.Rows[i].Cells["inproduction"].Value.ToString() == "0")
                        {
                            dataGridView1.Rows[i].Cells["lossrate"].Value = "0";
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells["lossrate"].Value = string.Format("{0:0.00}", Convert.ToDouble(replacenull(dataGridView1.Rows[i].Cells["lost"].Value.ToString())) / Convert.ToDouble(dataGridView1.Rows[i].Cells["inother"].Value.ToString()) * 100);
                        }

                    }

                }
                // WAREhouse


                if (cbwarehouse.SelectedValue.ToString() == "WH002" || cbwarehouse.SelectedValue.ToString() == "WH003" || cbwarehouse.SelectedValue.ToString() == "WH005" || cbwarehouse.SelectedValue.ToString() == "WH011")
                {
                    //NG
                    if (string.IsNullOrEmpty(dataGridView1.Rows[i].Cells["outother"].Value.ToString()) || dataGridView1.Rows[i].Cells["outother"].Value.ToString() == "0")
                    {
                        dataGridView1.Rows[i].Cells["ngrate"].Value = "0";
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells["ngrate"].Value = string.Format("{0:0.00}", Convert.ToDouble(replacenull(dataGridView1.Rows[i].Cells["ng"].Value.ToString())) / Convert.ToDouble(dataGridView1.Rows[i].Cells["outother"].Value.ToString()) * 100);
                    }
                    //lost rate 

                    if (string.IsNullOrEmpty(dataGridView1.Rows[i].Cells["outother"].Value.ToString()) || dataGridView1.Rows[i].Cells["outother"].Value.ToString() == "0")
                    {
                        dataGridView1.Rows[i].Cells["lossrate"].Value = "0";
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells["lossrate"].Value = string.Format("{0:0.00}", Convert.ToDouble(replacenull(dataGridView1.Rows[i].Cells["lost"].Value.ToString())) / Convert.ToDouble(dataGridView1.Rows[i].Cells["outother"].Value.ToString()) * 100);
                    }



                }


            }
            
        }

        private void cbwarehouse_Click(object sender, EventArgs e)
        {


            DataTable dtwarehouse = connect.readdata("select * from warehouse where idwarehouse='WH002' or idwarehouse ='WH003' or idwarehouse ='WH005' or idwarehouse ='WH011'");
            cbwarehouse.DataSource = dtwarehouse;
            cbwarehouse.ValueMember = "idwarehouse";
            cbwarehouse.DisplayMember = "namewarehouse";
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if(cbwarehouse.Text!="")
            {
                pagenumber = 1;
                txtpagenumber.Text = pagenumber.ToString();
                dt = connect.readdata("select a.* from(select ROW_NUMBER() over (order by partno asc) as r, partno,stocklastmonth,inother,outother,inventory,ng,lost from view_report_" + mahoa(cbwarehouse.SelectedValue.ToString()) + " where partno like '%" + txtsearch.Text + "%') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1) ");
                dataGridView1.DataSource = dt;
            }
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        private string a;
        private string replacespace(string s)
        {

            if (string.IsNullOrEmpty(s))
            {
                a = "0";
            }
            else
            {
                a = s;
            }
            return a;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private int id;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            ContextMenu ctx = new ContextMenu();
            MenuItem mItem = new MenuItem();
            mItem.Text = "View details";
            mItem.Click += new System.EventHandler(this.menuItem1_Click);
            ctx.MenuItems.Add(mItem);
            id = dataGridView1.HitTest(e.X, e.Y).RowIndex;

            if (e.Button == MouseButtons.Right)
            {
                Point pt = new Point(e.X, e.Y);
                ctx.Show(dataGridView1, pt);
            }


        }
        
        private void menuItem1_Click(object sender, System.EventArgs e)
        {
            if (id != -1)
            {


                Report_Detail fr = new Report_Detail();
                fr.lbpartno.Text = dataGridView1.Rows[id].Cells["partno"].Value.ToString();
                DataTable dtwarehouse = connect.readdata("select namewarehouse from warehouse where idwarehouse='" + cbwarehouse.SelectedValue + "'");
                fr.lbwarehouse.Text = dtwarehouse.Rows[0]["namewarehouse"].ToString();
                fr.lbmonth.Text = DateTime.Now.ToString("MM");
                for (int i = 1; i <= Convert.ToInt32(DateTime.Now.ToString("dd")); i++)
                {

                    //row.Cells[0].Value = i + 1;
                    fr.dataGridView1.Rows.Add("" + i);
                }
                //abcxz

                //stock last month
                DataTable dtlastmonthinventory = connect.readdata("select quantity from stocklastmonth where partno='" + dataGridView1.Rows[id].Cells["partno"].Value.ToString() + "' and idwarehouse='" + cbwarehouse.SelectedValue + "' and yearmonth='" + monthdesc() + "'");
                if (dtlastmonthinventory.Rows.Count > 0)
                {
                    fr.dataGridView1.Rows[0].Cells["lastmonthinventory"].Value =Convert.ToDouble(dtlastmonthinventory.Rows[0]["quantity"].ToString());
                }
                else
                {
                    fr.dataGridView1.Rows[0].Cells["lastmonthinventory"].Value = "0";
                }
                for (int i = 1; i <= Convert.ToInt32(DateTime.Now.ToString("dd")); i++)
                {


                    //in other 

                    DataTable dtinother = connect.readdata("select sum(quantity) as inother from slipoutinfo inner join slipout on slipoutinfo.idslipout=slipout.idslipout where partno='" + dataGridView1.Rows[id].Cells["partno"].Value.ToString() + "' and idcustomer='" + cbwarehouse.SelectedValue + "' and CONVERT(date,dateout,121)='" + DateTime.Now.ToString("yyyy-MM") + "-" + i.ToString() + "'");
                    if (dtinother.Rows.Count > 0)
                    {
                        fr.dataGridView1.Rows[i - 1].Cells["inother"].Value =Convert.ToDouble((replacenull(dtinother.Rows[0]["inother"].ToString())));
                    }
                    else
                    {
                        fr.dataGridView1.Rows[i - 1].Cells["inother"].Value = 0;
                    }
                    
                    //in production

                    DataTable dtinproduction = connect.readdata("select sum(qty) as inproduction from productionhistory where partno='" + dataGridView1.Rows[id].Cells["partno"].Value.ToString() + "' and idwarehouse='" + cbwarehouse.SelectedValue + "' and convert(date,productiontime,121)='" + DateTime.Now.ToString("yyyy-MM") + "-" + i.ToString() + "'");
                    if (dtinproduction.Rows.Count > 0)
                    {
                        fr.dataGridView1.Rows[i - 1].Cells["inproduction"].Value = replacenull(dtinproduction.Rows[0]["inproduction"].ToString());
                    }
                    else
                    {
                        fr.dataGridView1.Rows[i - 1].Cells["inproduction"].Value = "0";
                    }

                    // out other
                    DataTable dtoutother = connect.readdata("select sum(quantity) as outother from slipoutinfo inner join slipout on slipoutinfo.idslipout=slipout.idslipout where partno='" + dataGridView1.Rows[id].Cells["partno"].Value.ToString() + "' and idwarehouse='" + cbwarehouse.SelectedValue + "' and CONVERT(date,dateout,121)='" + DateTime.Now.ToString("yyyy-MM") + "-" + i.ToString() + "'");
                    if (dtoutother.Rows.Count > 0)
                    {
                        fr.dataGridView1.Rows[i - 1].Cells["outother"].Value =Convert.ToDouble(replacenull(dtoutother.Rows[0]["outother"].ToString()));
                    }
                    else
                    {
                        fr.dataGridView1.Rows[i - 1].Cells["outother"].Value = "0";
                    }
                    //ng
                    DataTable dtng = connect.readdata("select sum(quantity) as ng from tbl_nghistory where partno='" + dataGridView1.Rows[id].Cells["partno"].Value.ToString() + "' and idwarehouse='" + cbwarehouse.SelectedValue + "' and convert(date,productiontime,121)='" + DateTime.Now.ToString("yyyy-MM") + "-" + i.ToString() + "'");
                    if (dtng.Rows.Count > 0)
                    {
                        fr.dataGridView1.Rows[i - 1].Cells["ng"].Value = replacenull(dtng.Rows[0]["ng"].ToString());
                    }
                    else
                    {
                        fr.dataGridView1.Rows[i - 1].Cells["ng"].Value = "0";
                    }

                    // loss

                    DataTable dtloss = connect.readdata("select sum(quantity) as loss from tbl_lost where partno='" + dataGridView1.Rows[id].Cells["partno"].Value.ToString() + "' and idwarehouse='" + cbwarehouse.SelectedValue + "' and convert(date,losttime,121)='" + DateTime.Now.ToString("yyyy-MM") + "-" + i.ToString() + "'");
                    if (dtloss != null)
                    {
                        fr.dataGridView1.Rows[i - 1].Cells["loss"].Value = replacenull(dtloss.Rows[0]["loss"].ToString());
                    }
                    else
                    {
                        fr.dataGridView1.Rows[i - 1].Cells["loss"].Value = "0";
                    }



                    if (cbwarehouse.SelectedValue.ToString() == "WH001")
                    {
                        // out production
                        DataTable dtcategory = connect.readdata("select idcategory from cargo where partno='" + dataGridView1.Rows[id].Cells["partno"].Value.ToString() + "'");
                        if (dtcategory.Rows[0]["idcategory"].ToString() != "3")
                        {
                            DataTable dtsl = connect.readdata("select quantity*tmp.sl as outproduction from bom inner join  (select partno,SUM(qty) as sl from productionhistory where idwarehouse='WH001' and MONTH(productiontime)=MONTH(GETDATE()) and YEAR(productiontime)=YEAR(GETDATE()) and day(productiontime)='" + i.ToString() + "' group by productionhistory.partno) as tmp on bom.partno=tmp.partno where rawpartno ='" + fr.lbpartno.Text + "'");
                            if (dtsl.Rows.Count > 0)
                            {
                                fr.dataGridView1.Rows[i - 1].Cells["outproduction"].Value = dtsl.Rows[0]["outproduction"].ToString();
                            }
                            else
                            {
                                fr.dataGridView1.Rows[i - 1].Cells["outproduction"].Value = "0";
                            }
                            //ngrate
                            //singleppart 
                            if (string.IsNullOrEmpty(fr.dataGridView1.Rows[i - 1].Cells["inother"].Value.ToString()) || fr.dataGridView1.Rows[i - 1].Cells["inother"].Value.ToString() == "0" || string.IsNullOrEmpty(fr.dataGridView1.Rows[i - 1].Cells["ng"].Value.ToString()))
                            {
                                fr.dataGridView1.Rows[i - 1].Cells["ngrate"].Value = "0";
                            }
                            else
                            {
                                fr.dataGridView1.Rows[i - 1].Cells["ngrate"].Value = string.Format("{0:0.00}", Convert.ToDouble(replacenull(fr.dataGridView1.Rows[i - 1].Cells["ng"].Value.ToString())) / Convert.ToDouble(fr.dataGridView1.Rows[i - 1].Cells["inother"].Value.ToString()) * 100);
                            }
                            //lossrate single part
                            if (string.IsNullOrEmpty(fr.dataGridView1.Rows[i - 1].Cells["inother"].Value.ToString()) || fr.dataGridView1.Rows[i - 1].Cells["inother"].Value.ToString() == "0" || string.IsNullOrEmpty(fr.dataGridView1.Rows[i - 1].Cells["loss"].Value.ToString()))
                            {
                                fr.dataGridView1.Rows[i - 1].Cells["lossrate"].Value = "0";
                            }
                            else
                            {
                                fr.dataGridView1.Rows[i - 1].Cells["lossrate"].Value = string.Format("{0:0.00}", Convert.ToDouble(replacenull(fr.dataGridView1.Rows[i - 1].Cells["loss"].Value.ToString())) / Convert.ToDouble(fr.dataGridView1.Rows[i - 1].Cells["inother"].Value.ToString()) * 100);
                            }


                        }
                        else
                        {
                            try
                            {
                                // Finished goods part
                                if (string.IsNullOrEmpty(fr.dataGridView1.Rows[i - 1].Cells["inproduction"].Value.ToString()) || fr.dataGridView1.Rows[i - 1].Cells["inproduction"].Value.ToString() == "0" || string.IsNullOrEmpty(fr.dataGridView1.Rows[i - 1].Cells["ng"].Value.ToString()))
                                {
                                    fr.dataGridView1.Rows[i - 1].Cells["ngrate"].Value = "0";
                                }
                                else
                                {
                                    fr.dataGridView1.Rows[i - 1].Cells["ngrate"].Value = string.Format("{0:0.00}", Convert.ToDouble(replacenull(fr.dataGridView1.Rows[i - 1].Cells["ng"].Value.ToString())) / Convert.ToDouble(fr.dataGridView1.Rows[i - 1].Cells["inproduction"].Value.ToString()) * 100);
                                }
                                //lossrate single part
                                if (string.IsNullOrEmpty(fr.dataGridView1.Rows[i - 1].Cells["inproduction"].Value.ToString()) || fr.dataGridView1.Rows[i - 1].Cells["inproduction"].Value.ToString() == "0" || string.IsNullOrEmpty(fr.dataGridView1.Rows[i - 1].Cells["loss"].Value.ToString()))
                                {
                                    fr.dataGridView1.Rows[i - 1].Cells["lossrate"].Value = "0";
                                }
                                else
                                {
                                    fr.dataGridView1.Rows[i - 1].Cells["lossrate"].Value = string.Format("{0:0.00}", Convert.ToDouble(replacenull(fr.dataGridView1.Rows[i - 1].Cells["loss"].Value.ToString())) / Convert.ToDouble(fr.dataGridView1.Rows[i - 1].Cells["inproduction"].Value.ToString()) * 100);
                                }
                            }
                            catch
                            {

                            }

                        }
                        //total out production
                        DataTable dtcategory1 = connect.readdata("select idcategory from cargo where partno='" + fr.lbpartno.Text + "'");
                        if (dtcategory1.Rows[0]["idcategory"].ToString() != "3")
                        {
                            fr.dataGridView1.Rows[i - 1].Cells["totaloutproduction"].Value = Convert.ToDouble(replacenull(fr.dataGridView1.Rows[i - 1].Cells["outproduction"].Value.ToString())) + Convert.ToDouble(replacenull(fr.dataGridView1.Rows[i - 1].Cells["ng"].Value.ToString()));
                        }
                        else
                        {
                            fr.dataGridView1.Rows[i - 1].Cells["totaloutproduction"].Value = "0";
                        }



                    }
                    if (cbwarehouse.SelectedValue.ToString() == "WH002" || cbwarehouse.SelectedValue.ToString() == "WH003" || cbwarehouse.SelectedValue.ToString() == "WH005"|| cbwarehouse.SelectedValue.ToString() == "WH011")
                    {
                        //out production
                        fr.dataGridView1.Rows[i - 1].Cells["outproduction"].Value = "0";
                        fr.dataGridView1.Rows[i - 1].Cells["totaloutproduction"].Value = "0";
                        try
                        {
                            if (string.IsNullOrEmpty(fr.dataGridView1.Rows[i - 1].Cells["outother"].Value.ToString()) || fr.dataGridView1.Rows[i - 1].Cells["outother"].Value.ToString() == "0" || string.IsNullOrEmpty(fr.dataGridView1.Rows[i - 1].Cells["ng"].Value.ToString()))
                            {
                                fr.dataGridView1.Rows[i - 1].Cells["ngrate"].Value = "0";
                            }
                            else
                            {
                                fr.dataGridView1.Rows[i - 1].Cells["ngrate"].Value = string.Format("{0:0.00}", Convert.ToDouble(replacenull(fr.dataGridView1.Rows[i - 1].Cells["ng"].Value.ToString())) / Convert.ToDouble(fr.dataGridView1.Rows[i - 1].Cells["outother"].Value.ToString()) * 100);
                            }
                            //lossrate single part
                            if (string.IsNullOrEmpty(fr.dataGridView1.Rows[i - 1].Cells["outother"].Value.ToString()) || fr.dataGridView1.Rows[i - 1].Cells["outother"].Value.ToString() == "0")
                            {
                                fr.dataGridView1.Rows[i - 1].Cells["lossrate"].Value = "0";
                            }
                            else
                            {
                                fr.dataGridView1.Rows[i].Cells["lossrate"].Value = string.Format("{0:0.00}", Convert.ToDouble((fr.dataGridView1.Rows[i].Cells["loss"].Value.ToString())) / Convert.ToDouble(fr.dataGridView1.Rows[i].Cells["outother"].Value.ToString()) * 100);
                            }
                        }
                        catch
                        {

                        }

                    }
                    //CURRENT INVENTORY 
                    if (i == 1)
                    {
                        fr.dataGridView1.Rows[0].Cells["currentinventory"].Value = Convert.ToDouble(replacespace(fr.dataGridView1.Rows[0].Cells["lastmonthinventory"].Value.ToString())) + Convert.ToDouble(replacespace(fr.dataGridView1.Rows[0].Cells["inother"].Value.ToString())) + Convert.ToDouble(replacespace(fr.dataGridView1.Rows[0].Cells["inproduction"].Value.ToString())) - Convert.ToDouble(replacespace(fr.dataGridView1.Rows[0].Cells["outother"].Value.ToString())) - Convert.ToDouble(replacespace(fr.dataGridView1.Rows[0].Cells["totaloutproduction"].Value.ToString())) - Convert.ToDouble(replacespace(fr.dataGridView1.Rows[0].Cells["ng"].Value.ToString())) - Convert.ToDouble(replacespace(fr.dataGridView1.Rows[0].Cells["loss"].Value.ToString()));
                    }
                    else
                    {
                        fr.dataGridView1.Rows[i - 1].Cells["currentinventory"].Value = Convert.ToDouble(replacespace(fr.dataGridView1.Rows[i - 2].Cells["currentinventory"].Value.ToString())) + Convert.ToDouble(replacespace(fr.dataGridView1.Rows[i - 1].Cells["inother"].Value.ToString())) + Convert.ToDouble(replacespace(fr.dataGridView1.Rows[i - 1].Cells["inproduction"].Value.ToString())) - Convert.ToDouble(replacespace(fr.dataGridView1.Rows[i - 1].Cells["outother"].Value.ToString())) - Convert.ToDouble(replacespace(fr.dataGridView1.Rows[i - 1].Cells["totaloutproduction"].Value.ToString())) - Convert.ToDouble(replacespace(fr.dataGridView1.Rows[i - 1].Cells["ng"].Value.ToString())) - Convert.ToDouble(replacespace(fr.dataGridView1.Rows[i - 1].Cells["loss"].Value.ToString()));
                    }

                }

                fr.ShowDialog();
            }
        }
        string result;
        private string mahoa(string s)
        {
            switch (s)
            {
                case "WH001":
                    result = "production";
                    break;
                case "WH002":
                    result = "warehouse";
                    break;
                case "WH003":
                    result = "injection";
                    break;
                case "WH004":
                    result = "spray";
                    break;
                case "WH005":
                    result = "printing";
                    break;
                case "WH006":
                    result = "delivery";
                    break;
                case "WH011":
                    result = "resin";
                    break;
            }

            return result;
        }
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            pagenumber = Convert.ToInt32(txtpagenumber.Text) + 1;
            txtpagenumber.Text = pagenumber.ToString();
            if (txtsearch.Text != "")
            {
                dt = connect.readdata("select a.* from(select ROW_NUMBER() over (order by partno asc) as r,partno,stocklastmonth,inother,outother,inventory,ng,lost from view_report_" + mahoa(cbwarehouse.SelectedValue.ToString()) + " where partno like '%" + txtsearch.Text + "%') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1) ");
                dataGridView1.DataSource = dt;
            }
            else
            {
                dt = connect.readdata("select a.* from(select ROW_NUMBER() over (order by partno asc) as r,partno,stocklastmonth,inother,outother,inventory,ng,lost from view_report_" + mahoa(cbwarehouse.SelectedValue.ToString()) + ") a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1) ");
                dataGridView1.DataSource = dt;
            }

        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            pagenumber = Convert.ToInt32(txtpagenumber.Text) - 1;
            txtpagenumber.Text = pagenumber.ToString();
            if (txtsearch.Text != "")
            {
                dt = connect.readdata("select a.* from(select ROW_NUMBER() over (order by partno asc) as r,partno,stocklastmonth,inother,outother,inventory,ng,lost from view_report_" + mahoa(cbwarehouse.SelectedValue.ToString()) + " where partno like '%" + txtsearch.Text + "%') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1) ");
                dataGridView1.DataSource = dt;
            }
            else
            {
                dt = connect.readdata("select a.* from(select ROW_NUMBER() over (order by partno asc) as r,partno,stocklastmonth,inother,outother,inventory,ng,lost from view_report_" + mahoa(cbwarehouse.SelectedValue.ToString()) + ") a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1) ");
                dataGridView1.DataSource = dt;
            }
        }
        int qty;
        private void btnfirst_Click(object sender, EventArgs e)
        {
            pagenumber = 1;
            txtpagenumber.Text = pagenumber.ToString();
            if (txtsearch.Text != "")
            {
                dt = connect.readdata("select a.* from(select ROW_NUMBER() over (order by partno asc) as r,partno,stocklastmonth,inother,outother,inventory,ng,lost from view_report_" + mahoa(cbwarehouse.SelectedValue.ToString()) + " where partno like '%" + txtsearch.Text + "%') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1) ");
                dataGridView1.DataSource = dt;
            }
            else
            {
                dt = connect.readdata("select a.* from(select ROW_NUMBER() over (order by partno asc) as r,partno,stocklastmonth,inother,outother,inventory,ng,lost from view_report_" + mahoa(cbwarehouse.SelectedValue.ToString()) + ") a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1) ");
                dataGridView1.DataSource = dt;
            }
        }

        private void btnend_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text != "")
            {
                qty = connect.countdata("select COUNT(partno)  from  view_stock_warehouse");
            }
            else
            {
                qty = connect.countdata("select COUNT(partno)  from  view_stock_warehouse where partno like '%" + txtsearch.Text + "%'");

            }
            if (Convert.ToDouble(qty % pagesize) > 0)
            {
                pagenumber = qty / pagesize + 1;
            }
            else
            {
                pagenumber = qty / pagesize;
            }
            txtpagenumber.Text = pagenumber.ToString();
            if (txtsearch.Text != "")
            {
                dt = connect.readdata("select a.* from(select ROW_NUMBER() over (order by partno asc) as r,partno,stocklastmonth,inother,outother,inventory,ng,lost from view_report_" + mahoa(cbwarehouse.SelectedValue.ToString()) + " where partno like '%" + txtsearch.Text + "%') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1) ");
                dataGridView1.DataSource = dt;
            }
            else
            {
                dt = connect.readdata("select a.* from(select ROW_NUMBER() over (order by partno asc) as r,partno,stocklastmonth,inother,outother,inventory,ng,lost from view_report_" + mahoa(cbwarehouse.SelectedValue.ToString()) + ") a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1) ");
                dataGridView1.DataSource = dt;
            }
        }
        Isnumber _isnumber = new Isnumber();
        private void txtsearch_Validated(object sender, EventArgs e)
        {
            
        }

        private void txtpagenumber_TextChanged(object sender, EventArgs e)
        {
            if (_isnumber.IsNumber(txtpagenumber.Text) == true)
            {

                if (Convert.ToInt32(txtpagenumber.Text) <= 0)
                {
                    txtpagenumber.Text = "1";
                    dt = connect.readdata("select a.* from(select ROW_NUMBER() over (order by partno asc) as r,partno,stocklastmonth,inother,outother,inventory,ng,lost from view_report_" + mahoa(cbwarehouse.SelectedValue.ToString()) + ") a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1) ");
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void txtpagenumber_Validated(object sender, EventArgs e)
        {
            if (txtpagenumber.Text == "" || _isnumber.IsNumber(txtpagenumber.Text) == false)
            {
                txtpagenumber.Text = "1";
            }
            else
            {
                if (Convert.ToInt32(txtpagenumber.Text) <= 0)
                {
                    txtpagenumber.Text = "1";
                }
            }
        }
        public void ExportToExcel(DataTable dataTable, string ExcelFilePath)
        {
            try
            {
                int ColumnsCount;

                if (dataTable == null || (ColumnsCount = dataTable.Columns.Count) == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                // create a new workbook
                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Excel.Workbooks.Add(System.Reflection.Missing.Value);

                object misValue = System.Reflection.Missing.Value;

                // single worksheet
                Microsoft.Office.Interop.Excel._Worksheet Worksheet = (Microsoft.Office.Interop.Excel._Worksheet)Excel.ActiveSheet;

                object[] Header = new object[ColumnsCount];

                // column headings
                for (int i = 0; i < ColumnsCount; i++)
                    Header[i] = dataTable.Columns[i].ColumnName;

                Microsoft.Office.Interop.Excel.Range HeaderRange = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, ColumnsCount]));
                HeaderRange.Value2 = Header;
                HeaderRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                HeaderRange.Font.Bold = true;

                // DataCells
                int RowsCount = dataTable.Rows.Count;
                object[,] Cells = new object[RowsCount, ColumnsCount];

                for (int j = 0; j < RowsCount; j++)
                    for (int i = 0; i < ColumnsCount; i++)
                        Cells[j, i] = dataTable.Rows[j][i];

                Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[2, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[RowsCount + 1, ColumnsCount])).Value2 = Cells;

                // check fielpath
                if (ExcelFilePath != null && ExcelFilePath != "")
                {
                    try
                    {
                        Worksheet.SaveAs(ExcelFilePath, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);

                        Excel.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n" + ex.Message);
                    }
                }
                else // no filepath is given
                {
                    Excel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
        }
        private void btnexcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                DataTable dt = connect.readdata("select * from view_report_warehouse");
                ExportToExcel(dt, saveFileDialog1.FileName.ToString());
            }
        }
    }
}
