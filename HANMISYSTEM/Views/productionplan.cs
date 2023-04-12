using HANMISYSTEM.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM
{
    public partial class productionplan : Form
    {
        BackgroundWorker bw = new BackgroundWorker
        {
            WorkerReportsProgress = true,
            WorkerSupportsCancellation = true
        };


        private delegate void dlgAddItem();
        string lineID;
        private int count;
        private int counttrue;
        static private string _path;
        const string searchField = " p.idlocation ,p.id,p.partno,c.partname,p.productionplan,p.pst,p.status ";
        public productionplan()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();

        private void InsertExcelRecord()
        {
            string constr = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0 Xml;HDR=YES;""", _path);
            OleDbConnection Econ = new OleDbConnection(constr);
            string Query = string.Format("Select [Partno],[Idwarehouse],[Productiondate],[Idlocation],[Productionplan] FROM [{0}]", "Sheet1$");
            OleDbCommand Ecom = new OleDbCommand(Query, Econ);
            Econ.Open();

            DataSet ds = new DataSet();
            OleDbDataAdapter oda = new OleDbDataAdapter(Query, Econ);

            oda.Fill(ds);
            DataTable Exceldt = ds.Tables[0];
            count = 0;
            counttrue = 0;
            for (int i = 0; i < Exceldt.Rows.Count; i++)
            {

                if (Exceldt.Rows[i]["Partno"] != DBNull.Value && Exceldt.Rows[i]["Idwarehouse"] != DBNull.Value && Exceldt.Rows[i]["Productiondate"] != DBNull.Value && Exceldt.Rows[i]["Idlocation"] != DBNull.Value && Exceldt.Rows[i]["Productionplan"] != DBNull.Value)
                {
                    if (Exceldt.Rows[i]["Idwarehouse"].ToString() == "WH001")
                    {
                        if (Exceldt.Rows[i]["Idlocation"].ToString() == "L1" || Exceldt.Rows[i]["Idlocation"].ToString() == "L2" || Exceldt.Rows[i]["Idlocation"].ToString() == "L3" || Exceldt.Rows[i]["Idlocation"].ToString() == "L4" || Exceldt.Rows[i]["Idlocation"].ToString() == "L5" || Exceldt.Rows[i]["Idlocation"].ToString() == "L6")
                        {


                            if (connect.countdata("select count (partno) from productionplan where partno='" + Exceldt.Rows[i]["Partno"] + "' and idwarehouse='" + Exceldt.Rows[i]["Idwarehouse"] + "' and productiondate='" + Exceldt.Rows[i]["Productiondate"] + "' and idlocation='" + Exceldt.Rows[i]["Idlocation"] + "'") == 0)
                            {
                                counttrue = counttrue + 1;
                            }
                            else
                            {
                                try
                                {

                                    OleDbCommand cmd = new OleDbCommand();
                                    cmd.Connection = Econ;
                                    cmd.CommandText = @"Update  [Sheet1$] set status='Existed' where [Partno] ='" + Exceldt.Rows[i]["Partno"] + "' and [Idwarehouse]='" + Exceldt.Rows[i]["Idwarehouse"] + "' and [Productiondate] ='" + Exceldt.Rows[i]["Productiondate"] + "' and [Idlocation]='" + Exceldt.Rows[i]["Idlocation"] + "'";
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("" + ex.ToString());
                                }

                                count = count + 1;
                                Exceldt.Rows[i].Delete();
                                Exceldt.AcceptChanges();

                            }
                        }
                        else
                        {
                            try
                            {

                                OleDbCommand cmd = new OleDbCommand();
                                cmd.Connection = Econ;
                                cmd.CommandText = @"Update  [Sheet1$] set status='vi tri khong hop le' where [Partno] ='" + Exceldt.Rows[i]["Partno"] + "' and [Idwarehouse]='" + Exceldt.Rows[i]["Idwarehouse"] + "' and [Productiondate] ='" + Exceldt.Rows[i]["Productiondate"] + "' and [Idlocation]='" + Exceldt.Rows[i]["Idlocation"] + "';";
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("" + ex.ToString());
                            }

                            count = count + 1;
                            Exceldt.Rows[i].Delete();
                            Exceldt.AcceptChanges();
                        }
                    }
                    else
                    {
                        try
                        {

                            OleDbCommand cmd = new OleDbCommand();
                            cmd.Connection = Econ;
                            cmd.CommandText = @"Update  [Sheet1$] set status='ID warehouse not invalid ,it must be like WH001' where [Partno] ='" + Exceldt.Rows[i]["Partno"] + "'and [Idwarehouse]='" + Exceldt.Rows[i]["Idwarehouse"] + "' and [Productiondate] ='" + Exceldt.Rows[i]["Productiondate"] + "' and [Idlocation]='" + Exceldt.Rows[i]["Idlocation"] + "';";
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("" + ex.ToString());
                        }

                        count = count + 1;
                        Exceldt.Rows[i].Delete();
                        Exceldt.AcceptChanges();
                    }
                }
                else
                {
                    try
                    {

                        OleDbCommand cmd = new OleDbCommand();
                        cmd.Connection = Econ;
                        cmd.CommandText = @"Update  [Sheet1$] set status='line empty' where [Partno] ='" + Exceldt.Rows[i]["Partno"] + "'and [Idwarehouse]='" + Exceldt.Rows[i]["Idwarehouse"] + "' and [Productiondate] ='" + Exceldt.Rows[i]["Productiondate"] + "' and [Idlocation]='" + Exceldt.Rows[i]["Idlcation"] + "';";
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex.ToString());
                    }

                    count = count + 1;
                    Exceldt.Rows[i].Delete();
                    Exceldt.AcceptChanges();

                }
            }

            //creating object of SqlBulkCopy      
            SqlBulkCopy objbulk = new SqlBulkCopy(connect.con);
            //assigning Destination table name      
            objbulk.DestinationTableName = "productionplan";
            //Mapping Table column    
            objbulk.ColumnMappings.Add("[Partno]", "partno");
            objbulk.ColumnMappings.Add("[Idwarehouse]", "idwarehouse");
            objbulk.ColumnMappings.Add("[Productiondate]", "productiondate");
            objbulk.ColumnMappings.Add("[Idlocation]", "idlocation");
            objbulk.ColumnMappings.Add("[Productionplan]", "productionplan");

            //inserting Datatable Records to DataBase   
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "server = '" + HANMISYSTEM.Properties.Settings.Default.servername + "'; database = HANMI; User ID = '" + HANMISYSTEM.Properties.Settings.Default.uid + "'; Password = '" + HANMISYSTEM.Properties.Settings.Default.pwd + "'"; //Connection Details    
            connect.con.Open();
            objbulk.WriteToServer(Exceldt);

            MessageBox.Show("Data has been Imported done with : " + counttrue + " success and " + count + " fails", "Imported", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Thread loadThread = new Thread(new ThreadStart(loadplan));
            loadThread.Start();

            Econ.Close();
            Econ.Dispose();
            connect.con.Close();
            /*}
            catch (Exception ex)
            {
                MessageBox.Show(count+" fails  +Data has not been Imported due to " + ex.ToString(), "Not Imported", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  */
        }
        private void loadplan()
        {
            if (dgvplan.InvokeRequired)
            {
                dgvplan.Invoke(new dlgAddItem(loadplan));
            }
            else
            {
                DataTable dt = connect.readdata("select * from productionplan");
                if (dt != null)
                {
                    dgvplan.DataSource = dt;
                }
            }

        }

        private void productionplan_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt2;
                DataTable dt = connect.readdata("select idwarehouse,namewarehouse from warehouse where idwarehouse='WH001'");
                if (dt != null)
                {
                    cbwarehouse.DataSource = dt;
                    cbwarehouse.ValueMember = "idwarehouse";
                    cbwarehouse.DisplayMember = "namewarehouse";
                }
                DataTable dt3 = connect.readdata("select * from tbl_user where username='" + HANMISYSTEM.Properties.Settings.Default.username + "'");
                if (dt3.Rows[0]["location"].ToString() == "all")
                {
                    dt2 = connect.readdata("select * from location where idwarehouse='" + cbwarehouse.SelectedValue + "'");
                    lineID = "L1";
                }
                else
                {
                    lineID = dt3.Rows[0]["location"].ToString();
                    dt2 = connect.readdata("select * from location where idwarehouse='" + cbwarehouse.SelectedValue + "' and idlocation='" + dt3.Rows[0]["location"].ToString() + "'");
                }

                if (dt2 != null)
                {
                    cblocation.DataSource = dt2;
                    cblocation.ValueMember = "idlocation";
                    cblocation.DisplayMember = "namelocation1";

                    cbline.DataSource = dt2;
                    cbline.DisplayMember = "namelocation1";
                    cbline.ValueMember = "idlocation";
                    string cmd = "select " + searchField + " from productionplan p inner join cargo c on p.partno =c.partno left join WorkOrder w on w.ID=p.WorkOrderID where idlocation='" + dt2.Rows[0]["idlocation"].ToString() + "' and p.productiondate =CONVERT(date,getdate()) ";
                   loaddata(cmd);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        private string GetTeamCode1(int id)
        {
            try
            {
                DataTable dtTeam = connect.readdata("select Code1 from Team where ID ='" + id + "'");
                return dtTeam.Rows[0]["Code1"].ToString();
            }
            catch
            {
                return "H01";
            }
        }
        //private String GenerateWO()
        //{

        //}
        private void loaddata(string cmd)
        {
            try
            {
                DataTable dt = connect.readdata(cmd);
                if (dt != null)
                {
                    dgvplan.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        Isnumber _isnumber = new Isnumber();
        private bool checkWOExisted(string WO)
        {
            if (WO != "")
            {
                if (connect.countdata("select count(id) from productionplan where WOCode='" + WO + "'") != 0)
                {
                    return true;
                }
                else
                { return false; }
            }
            return false;
        }
        private void btnadd_Click(object sender, EventArgs e)
        {

            if (txtpartno.Text == "" || txtplan.Text == "" || Regex.Replace(txtplan.Text, " ", string.Empty) == "0" || _isnumber.IsNumber(txtplan.Text) == false || _isnumber.IsPositive(txtplan.Text) == false)
            {
                MessageBox.Show("Giá trị nhập không hợp lệ");
            }
            else
            {
                if (connect.countdata("select count(partno) from cargo where partno ='" + txtpartno.Text + "'") == 0 || checkWOExisted(txtwo.Text) == true)
                {
                    MessageBox.Show("Mã hàng không tồn tại ");
                    txtpartno.Text = "";
                    txtpartno.Focus();
                }
                else
                {
                    if (connect.exedata("insert into productionplan (partno,idwarehouse,pst,productiondate,idlocation,productionplan,WOCode) values('" + txtpartno.Text + "','" + cbwarehouse.SelectedValue + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:00") + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + cblocation.SelectedValue + "','" + txtplan.Text + "','" + txtwo.Text + "')") == true)
                    {
                        MessageBox.Show("Thành công! ." + dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                        loaddata("SELECT "+searchField+" FROM productionplan p inner join cargo c on  p.partno=c.partno where idlocation ='" + cbline.SelectedValue.ToString() + "' and productiondate='" + dtpdateplan.Text + "' order by productiondate desc");
                        txtpartno.Text = "";
                        txtplan.Text = "";
                        lbsearch.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Kế hoạch này đã tồn tại");
                    }
                }

            }
        }

        private void dgvplan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    txtPlanID.Text = dgvplan.Rows[e.RowIndex].Cells["ID_col"].Value.ToString();
                    txtpartno.Text = dgvplan.Rows[e.RowIndex].Cells["partno"].Value.ToString();
                    lbsearch.Visible = false;
                    txtplan.Text = dgvplan.Rows[e.RowIndex].Cells["quantity"].Value.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
  
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (!string.IsNullOrEmpty(txtPlanID.Text))
                {
                    if (txtpartno.Text == "" || txtplan.Text == "" || Regex.Replace(txtplan.Text, " ", string.Empty) == "0" || _isnumber.IsNumber(txtplan.Text) == false || _isnumber.IsPositive(txtplan.Text) == false)
                    {
                        MessageBox.Show("Giá trị nhập không hợp lệ");
                    }
                    else
                    {
                        if (connect.exedata("update productionplan set productionplan='" + txtplan.Text + "' where ID ='"+txtPlanID.Text+"'"))
                        {
                            MessageBox.Show("Thành công!");
                            loaddata("SELECT "+searchField+" FROM productionplan p inner join cargo c on p.partno=c.partno where idlocation ='" + cbline.SelectedValue.ToString() + "' and productiondate='" + dtpdateplan.Text + "' order by productiondate desc");
                            txtPlanID.Text = "";
                            txtpartno.Text = "";
                            lbsearch.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Failed");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kế hoạch không có sẵn để sửa !!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           


        }

        private void btnbrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Excell|*.xls;*.xlsx;";
            od.FileName = "plandata.xlsx";
            DialogResult dr = od.ShowDialog();
            if (dr == DialogResult.Abort)
                return;
            if (dr == DialogResult.Cancel)
                return;
            txtpath.Text = od.FileName.ToString();
            btnimport.Visible = true;
            _path = txtpath.Text;
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            btnimport.Visible = false;
            _path = txtpath.Text;
            if (txtpath.Text == "" || !txtpath.Text.Contains("plandata.xlsx"))
            {
                MessageBox.Show("Please Browse plandata.xlsx to upload", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtpath.Text = "";
                btnimport.Visible = false;
                return;
            }
            if (bw.IsBusy)
            {
                return;
            }

            System.Diagnostics.Stopwatch sWatch = new System.Diagnostics.Stopwatch();
            bw.DoWork += (bwSender, bwArg) =>
            {
                //what happens here must not touch the form  
                //as it's in a different thread          
                sWatch.Start();
                InsertExcelRecord();
            };

            bw.ProgressChanged += (bwSender, bwArg) =>
            {
                //update progress bars here  
            };

            bw.RunWorkerCompleted += (bwSender, bwArg) =>
            {
                //now you're back in the UI thread you can update the form  
                //remember to dispose of bw now                 

                sWatch.Stop();
                //work is done, no need for the stop button now...  

                txtpath.Text = "";
                btnbrowser.Enabled = true;
                bw.Dispose();

            };

            //lets allow the user to click stop  

            MessageBox.Show("Uploading has been started !");

            btnbrowser.Enabled = false;

            //Starts the actual work - triggerrs the "DoWork" event  
            bw.RunWorkerAsync();

            //InsertExcelRecords();           
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            ExportToExcel _excel = new ExportToExcel();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DataTable dtplan = connect.readdata("select * from productionplan");
                _excel.ExportToExcelFunction(dtplan, saveFileDialog1.FileName.ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExportToExcel _excel = new ExportToExcel();
            saveFileDialog1.FileName = "plandata";
            saveFileDialog1.Filter = "Text Files | *.xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DataTable dtplan = connect.readdata("select Partno,Idwarehouse,Productiondate,Idlocation,Productionplan,'' as status from productionplan where partno ='deo co'");
                _excel.ExportToExcelFunction(dtplan, saveFileDialog1.FileName.ToString());
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkdate_CheckedChanged(object sender, EventArgs e)
        {


        }
        private int id;
        private void dgvplan_MouseClick(object sender, MouseEventArgs e)
        {
            ContextMenu ctx = new ContextMenu();
            MenuItem mItem = new MenuItem();
            mItem.Text = "Xóa kế hoạch";
            mItem.Click += new System.EventHandler(this.menuItem1_Click);
            ctx.MenuItems.Add(mItem);
            id = dgvplan.HitTest(e.X, e.Y).RowIndex;

            if (e.Button == MouseButtons.Right)
            {
                Point pt = new Point(e.X, e.Y);
                ctx.Show(dgvplan, pt);
            }
        }
        private void menuItem1_Click(object sender, System.EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa kế hoạch không.", "COnfirm", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                connect.exedata("delete from productionplan where partno='" + dgvplan.Rows[id].Cells[0].Value.ToString() + "'");
                loaddata("SELECT row_number() over (order by pst asc) as r,p.idlocation ,id,p.partname,c.partname,p.productionplan,p.pst,p.status FROM productionplan p inner join cargo c on p.partno=c.partno where idlocation ='" + cbline.SelectedValue.ToString() + "' and productiondate='" + dtpdateplan.Text + "' order by productiondate desc");
            }
        }

        private void lbsearch_Click(object sender, EventArgs e)
        {
            if (lbsearch.SelectedItem != null)
            {
                txtpartno.Text = lbsearch.SelectedItem.ToString();
                lbsearch.Visible = false;
                txtplan.Focus();
            }
        }

        private void txtpartno_TextChanged(object sender, EventArgs e)
        {
            lbsearch.Visible = true;
            lbsearch.Items.Clear();
            DataTable dtsearch = connect.readdata("select top 15 partno from cargo where partno like '%" + txtpartno.Text + "%' or partname like '%" + txtpartno.Text + "%'");
            for (int i = 0; i < dtsearch.Rows.Count; i++)
            {
                lbsearch.Items.Add(dtsearch.Rows[i]["partno"].ToString());
            }
        }

        private void lbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string searchTerm;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox3.Text))
            {
                searchTerm = " and p.partno like '%"+textBox3.Text+"%'";
            }
            else
            {
                searchTerm = " ";
            }    
            loaddata("SELECT p.idlocation ,id,p.partno,c.partname,p.productionplan,p.pst,p.status FROM productionplan p inner join cargo c on p.partno=c.partno where idlocation ='" + cbline.SelectedValue.ToString() + "' and productiondate='" + dtpdateplan.Value.ToString("yyyy-MM-dd") + "' "+searchTerm+" order by productiondate desc");
        }
    }
}
