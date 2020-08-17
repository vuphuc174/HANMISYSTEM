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

    public partial class Statistics : Form
    {
        BackgroundWorker bw = new BackgroundWorker
        {
            WorkerReportsProgress = true,
            WorkerSupportsCancellation = true
        };
        public Statistics()
        {
            InitializeComponent();
        }
        public int cur_month;
        private void Statistics_Load(object sender, EventArgs e)
        {
            
        }
        Dbconnect connect = new Dbconnect();
        public int _result;
        private int getdate(int month)
        {
            int _year = Convert.ToInt32(DateTime.Now.Year.ToString());
            if (month >= 1 && month <= 12)
            {
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12: _result = 31; break;
                    case 4:
                    case 6:
                    case 9:
                    case 11: _result = 30; break;

                    case 2:
                        if (_year % 400 == 0 || (_year % 4 == 0 && _year % 100 != 0))    // nam nhuan
                            _result = 29;
                        else
                            _result = 28;
                        break;
                }
            }
            else
                MessageBox.Show("=> Thang khong hop le!\n");
            return _result;
        }
        private void llpre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            int _year = Convert.ToInt32(DateTime.Now.Year.ToString());
            if (cur_month > 1 && cur_month < 12)
            {
                dataGridView1.Rows.Clear();
                cur_month = Convert.ToInt32(lbmonth.Text) - 1;
                lbmonth.Text = cur_month.ToString();
                for (int i = 1; i <= getdate(cur_month); i++)
                {
                    dataGridView1.Rows.Add("" + i);
                }

                for (int i = 0; i < getdate(cur_month); i++)
                {
                    dataGridView1.Rows[i].Cells["actualok"].Value = connect.countdata("select COUNT(qty) from productionhistory where DAY(productiontime)='" + (i + 1).ToString() + "' and partno='" + lbpartno.Text + "' and idwarehouse='" + lbwarehouse.Text + "' and MONTH(productiontime)='" + cur_month + "' and year(productiontime)='" + _year + "'");
                }

                for (int i = 0; i < getdate(cur_month); i++)
                {
                    dataGridView1.Rows[i].Cells["actualng"].Value = connect.countdata("select COUNT(quantity) from tbl_nghistory where DAY(productiontime)='" + (i + 1).ToString() + "' and partno='" + lbpartno.Text + "' and idwarehouse='" + lbwarehouse.Text+ "' and MONTH(productiontime)='" + cur_month + "' and year(productiontime)='" + _year + "'");
                }
                //box
                for (int i = 0; i < getdate(cur_month); i++)
                {
                    dataGridView1.Rows[i].Cells["boxqty"].Value = connect.countdata("select COUNT(idpack) from packinginfo where DAY(packingdate)='" + (i + 1).ToString() + "' and partno='" + lbpartno.Text + "' and idwarehouse='" + lbwarehouse.Text + "' and MONTH(packingdate)='" + cur_month + "' and left(idpack,3)='BOX' and year(packingdate)='" + _year + "'");
                }
                //bag
                for (int i = 0; i < getdate(cur_month); i++)
                {
                    dataGridView1.Rows[i].Cells["bagqty"].Value = connect.countdata("select COUNT(idpack) from packinginfo where DAY(packingdate)='" + (i + 1).ToString() + "' and partno='" + lbpartno.Text + "' and idwarehouse='" + lbwarehouse.Text + "' and MONTH(packingdate)='" + cur_month + "' and left(idpack,3)='BAG' and year(packingdate)='" + _year + "'");
                }
                //cart
                for (int i = 0; i < getdate(cur_month); i++)
                {
                    dataGridView1.Rows[i].Cells["crtqty"].Value = connect.countdata("select COUNT(idpack) from packinginfo where DAY(packingdate)='" + (i + 1).ToString() + "' and partno='" + lbpartno.Text + "' and idwarehouse='" + lbwarehouse.Text + "' and MONTH(packingdate)='" +cur_month + "' and left(idpack,3)='CRT' and year(packingdate)='" + _year + "'");
                }
            }
            else
            {
            }
                //if (bw.IsBusy)
                //{
                //    return;
                //}
                //System.Diagnostics.Stopwatch sWatch = new System.Diagnostics.Stopwatch();
                //bw.DoWork += (bwSender, bwArg) =>
                //{
                //    //what happens here must not touch the form  
                //    //as it's in a different thread          
                //    sWatch.Start();
                //};

                //bw.ProgressChanged += (bwSender, bwArg) =>
                //{
                //    //update progress bars here  
                //};

                //bw.RunWorkerCompleted += (bwSender, bwArg) =>
                //{
                //    //now you're back in the UI thread you can update the form  
                //    //remember to dispose of bw now                 

                //    sWatch.Stop();
                //    //work is done, no need for the stop button now...  
                //    pictureBox1.Visible = false;
                //    bw.Dispose();

                //};
                ////lets allow the user to click stop  
                //pictureBox1.Visible = true;
                ////Starts the actual work - triggerrs the "DoWork" event  
                //bw.RunWorkerAsync();
            
            
            

           
        }

        private void llnext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            int _year = Convert.ToInt32(DateTime.Now.Year.ToString());
            if (cur_month > 1 && cur_month < 12)
            {
                dataGridView1.Rows.Clear();
                cur_month = Convert.ToInt32(lbmonth.Text) + 1;
                lbmonth.Text = cur_month.ToString();
                for (int i = 1; i <= getdate(cur_month); i++)
                {
                    dataGridView1.Rows.Add("" + i);
                }

                for (int i = 0; i < getdate(cur_month); i++)
                {
                    dataGridView1.Rows[i].Cells["actualok"].Value = connect.countdata("select COUNT(qty) from productionhistory where DAY(productiontime)='" + (i + 1).ToString() + "' and partno='" + lbpartno.Text + "' and idwarehouse='" + lbwarehouse.Text + "' and MONTH(productiontime)='" + cur_month + "' and year(productiontime)='" + _year + "'");
                }

                for (int i = 0; i < getdate(cur_month); i++)
                {
                    dataGridView1.Rows[i].Cells["actualng"].Value = connect.countdata("select COUNT(quantity) from tbl_nghistory where DAY(productiontime)='" + (i + 1).ToString() + "' and partno='" + lbpartno.Text + "' and idwarehouse='" + lbwarehouse.Text + "' and MONTH(productiontime)='" + cur_month + "' and year(productiontime)='" + _year + "'");
                }
                //box
                for (int i = 0; i < getdate(cur_month); i++)
                {
                    dataGridView1.Rows[i].Cells["boxqty"].Value = connect.countdata("select COUNT(idpack) from packinginfo where DAY(packingdate)='" + (i + 1).ToString() + "' and partno='" + lbpartno.Text + "' and idwarehouse='" + lbwarehouse.Text + "' and MONTH(packingdate)='" + cur_month + "' and left(idpack,3)='BOX' and year(packingdate)='" + _year + "'");
                }
                //bag
                for (int i = 0; i < getdate(cur_month); i++)
                {
                    dataGridView1.Rows[i].Cells["bagqty"].Value = connect.countdata("select COUNT(idpack) from packinginfo where DAY(packingdate)='" + (i + 1).ToString() + "' and partno='" + lbpartno.Text + "' and idwarehouse='" + lbwarehouse.Text + "' and MONTH(packingdate)='" + cur_month + "' and left(idpack,3)='BAG' and year(packingdate)='" + _year + "'");
                }
                //cart
                for (int i = 0; i < getdate(cur_month); i++)
                {
                    dataGridView1.Rows[i].Cells["crtqty"].Value = connect.countdata("select COUNT(idpack) from packinginfo where DAY(packingdate)='" + (i + 1).ToString() + "' and partno='" + lbpartno.Text + "' and idwarehouse='" + lbwarehouse.Text + "' and MONTH(packingdate)='" + cur_month + "' and left(idpack,3)='CRT' and year(packingdate)='" + _year + "'");
                }
            }
            else
            {
            }
        }
    }
}
