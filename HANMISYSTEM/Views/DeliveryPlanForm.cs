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

namespace HANMISYSTEM.Views
{
    public partial class DeliveryPlanForm : Form
    {
        BackgroundWorker bw = new BackgroundWorker
        {
            WorkerReportsProgress = true,
            WorkerSupportsCancellation = true
        };


        private delegate void dlgAddItem();
        private int count;
        private int counttrue;
        static private string _path;
        public DeliveryPlanForm()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        DataTable dtplan;

        private void InsertExcelRecord()
        {
            //try
            // {

            //  ExcelConn(_path);  
            string constr = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0 Xml;HDR=YES;""", _path);
            OleDbConnection Econ = new OleDbConnection(constr);
            string Query = string.Format("Select [PartNo],[IdWarehouse],[ProductionDate],[Quantity] FROM [{0}]", "Sheet1$");
            OleDbCommand Ecom = new OleDbCommand(Query, Econ);
            MessageBox.Show("cho chut");
            Econ.Open();
            
            DataSet ds = new DataSet();
            
            OleDbDataAdapter oda = new OleDbDataAdapter(Query, Econ);
            oda.Fill(ds);
            DataTable Exceldt = ds.Tables[0];
            count = 0;
            counttrue = 0;
            for (int i = Exceldt.Rows.Count - 1; i >= 0; i--)
            {
                //check null
                if (Exceldt.Rows[i]["Partno"] != DBNull.Value && Exceldt.Rows[i]["Idwarehouse"] != DBNull.Value && Exceldt.Rows[i]["Productiondate"] != DBNull.Value && Exceldt.Rows[i]["Quantity"] != DBNull.Value)
                {
                    //check warehouse
                    if (Exceldt.Rows[i]["Idwarehouse"].ToString() == "WH007")
                    {
                        //check ton tai
                        if (connect.countdata("select count (*) from DeliveryPlan where PartNo='" + Exceldt.Rows[i]["Partno"] + "' and IdWarehouse='" + Exceldt.Rows[i]["Idwarehouse"] + "' and ProductionDate='" + Exceldt.Rows[i]["Productiondate"] + "'") == 0)
                        {
                            counttrue = counttrue + 1;
                        }
                            //neu ton tai roi
                        else
                        {
                            try
                            {

                                OleDbCommand cmd = new OleDbCommand();
                                cmd.Connection = Econ;
                                cmd.CommandText = @"Update  [Sheet1$] set status='Existed' where [Partno] ='" + Exceldt.Rows[i]["Partno"] + "' and [Idwarehouse]='" + Exceldt.Rows[i]["Idwarehouse"] + "' and [Productiondate] ='" + Exceldt.Rows[i]["Productiondate"] + "';";
                                cmd.ExecuteNonQuery();
                            }
                            catch
                            {
                            }

                            count = count + 1;
                            Exceldt.Rows[i].Delete();
                            Exceldt.AcceptChanges();

                        }
                    }
                        //khac warehouse
                    else
                    {
                        try
                        {

                            OleDbCommand cmd = new OleDbCommand();
                            cmd.Connection = Econ;
                            cmd.CommandText = @"Update  [Sheet1$] set status='ID warehouse not invalid ,it must be like WH007' where [Partno] ='" + Exceldt.Rows[i]["Partno"] + "'and [Idwarehouse]='" + Exceldt.Rows[i]["Idwarehouse"] + "' and [Productiondate] ='" + Exceldt.Rows[i]["Productiondate"] + "';";
                            cmd.ExecuteNonQuery();
                        }
                        catch
                        {
                        }

                        count = count + 1;
                        Exceldt.Rows[i].Delete();
                        Exceldt.AcceptChanges();
                    }
                }
                //null
                else
                {
                    count = count + 1;
                    Exceldt.Rows[i].Delete();
                    Exceldt.AcceptChanges();
                }
            }
            Econ.Close();
            Econ.Dispose();
            //creating object of SqlBulkCopy      
            SqlBulkCopy objbulk = new SqlBulkCopy(connect.con);
            //assigning Destination table name      
            objbulk.DestinationTableName = "DeliveryPlan";
            //Mapping Table column    
            objbulk.ColumnMappings.Add("[Partno]", "Partno");
            objbulk.ColumnMappings.Add("[Idwarehouse]", "IdWarehouse");
            objbulk.ColumnMappings.Add("[Productiondate]", "Productiondate");
            objbulk.ColumnMappings.Add("[Quantity]", "Quantity");

            //inserting Datatable Records to DataBase   
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "server = '" + HANMISYSTEM.Properties.Settings.Default.servername + "'; database = HANMI; User ID = '" + HANMISYSTEM.Properties.Settings.Default.uid + "'; Password = '" + HANMISYSTEM.Properties.Settings.Default.pwd + "'"; //Connection Details    
            connect.con.Open();
            objbulk.WriteToServer(Exceldt);
            connect.con.Close();
            MessageBox.Show("Data has been Imported done with : " + counttrue + " success and " + count + " fails", "Imported", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Thread loadThread = new Thread(new ThreadStart(loadplan));
            loadThread.Start();


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
                dtplan = connect.readdata("select PartNo,ProductionDate,Quantity,UploadDate from DeliveryPlan p where (select idcategory from warehouse w where w.IdWarehouse=p.IdWarehouse )='W3'");
                dgvplan.DataSource = dtplan;
            }

        }
        private void DeliveryPlanForm_Load(object sender, EventArgs e)
        {
            dtplan = connect.readdata("select PartNo,ProductionDate,Quantity,UploadDate from DeliveryPlan p where (select idcategory from warehouse w where w.IdWarehouse=p.IdWarehouse )='W3'");
            dgvplan.DataSource = dtplan;
            DataTable dtwarehouse = connect.readdata("select * from warehouse where idcategory='W3'");
            cbwarehouse.DataSource = dtwarehouse;
            cbwarehouse.ValueMember = "idwarehouse";
            cbwarehouse.DisplayMember = "namewarehouse";
        }

        private void txtpartno_TextChanged(object sender, EventArgs e)
        {
            lbsearch.Visible = true;
            lbsearch.Items.Clear();
            DataTable dtsearch = connect.readdata("select top 15 PartNo from cargo where ( PartNo like '%" + txtpartno.Text + "%' or partname like '%" + txtpartno.Text + "%') and idcategory='3' ");
            for (int i = 0; i < dtsearch.Rows.Count; i++)
            {
                lbsearch.Items.Add(dtsearch.Rows[i]["PartNo"].ToString());
            }
        }

        private void lbsearch_Click(object sender, EventArgs e)
        {
            if (lbsearch.SelectedItem != null)
            {
                txtpartno.Text = lbsearch.SelectedItem.ToString();
                lbsearch.Visible = false;
            }
        }
        Isnumber _isnumber = new Isnumber();
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtpartno.Text == "" || txtplan.Text == "" || Regex.Replace(txtplan.Text, " ", string.Empty) == "0" || _isnumber.IsNumber(txtplan.Text) == false || _isnumber.IsPositive(txtplan.Text) == false)
            {
                MessageBox.Show("Giá trị nhập không hợp lệ");
            }
            else
            {
                if (connect.countdata("select count(PartNo) from cargo where PartNo ='" + txtpartno.Text + "'") == 0)
                {
                    MessageBox.Show("Mã hàng không tồn tại ");
                    txtpartno.Text = "";
                    txtpartno.Focus();
                }
                else
                {
                    if (connect.exedata("insert into DeliveryPlan (PartNo,IdWarehouse,ProductionDate,Quantity) values('" + txtpartno.Text + "','" + cbwarehouse.SelectedValue.ToString() + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + txtplan.Text + "')") == true)
                    {
                        MessageBox.Show("Thành công!" + dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                        if (chkdate.Checked == true)
                        {
                            dtplan = connect.readdata("select PartNo,ProductionDate,Quantity,UploadDate from DeliveryPlan p where (select idcategory from warehouse w where w.IdWarehouse=p.IdWarehouse )='W3'");
                            dgvplan.DataSource = dtplan;
                        }
                        else
                        {
                            dtplan = connect.readdata("select PartNo,ProductionDate,Quantity,UploadDate from DeliveryPlan p where (select idcategory from warehouse w where w.IdWarehouse=p.IdWarehouse )='W3'");
                            dgvplan.DataSource = dtplan;
                        }

                        txtpartno.Text = "";
                        txtplan.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                }

            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DataTable dtquantity = connect.readdata("select Quantity from DeliveryPlan where PartNo ='" + txtpartno.Text + "' and IdWarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' and ProductionDate='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'");
            if (dtquantity.Rows.Count > 0)
            {
                if (txtpartno.Text == "" || txtplan.Text == "" || Regex.Replace(txtplan.Text, " ", string.Empty) == "0" || _isnumber.IsNumber(txtplan.Text) == false || _isnumber.IsPositive(txtplan.Text) == false)
                {
                    MessageBox.Show("Giá trị nhập không hợp lệ");
                }
                else
                {
                    if (connect.exedata("update DeliveryPlan set Quantity='" + txtplan.Text + "' where IdWarehouse='" + cbwarehouse.SelectedValue + "' and PartNo='" + txtpartno.Text + "' and ProductionDate='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'"))
                    {
                        MessageBox.Show("Thành công!");
                        lbsearch.Visible = false;
                        if (chkdate.Checked == true)
                        {
                            dtplan = connect.readdata("select PartNo,ProductionDate,Quantity,UploadDate from DeliveryPlan p where (select idcategory from warehouse w where w.IdWarehouse=p.IdWarehouse )='W3'");
                            dgvplan.DataSource = dtplan;
                        }
                        else
                        {
                            dtplan = connect.readdata("select PartNo,ProductionDate,Quantity,UploadDate from DeliveryPlan p where (select idcategory from warehouse w where w.IdWarehouse=p.IdWarehouse )='W3'");
                            dgvplan.DataSource = dtplan;
                        }
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

        private void dgvplan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtpartno.Text = dgvplan.Rows[e.RowIndex].Cells["partno"].Value.ToString();
                lbsearch.Visible = false;
                txtplan.Text = dgvplan.Rows[e.RowIndex].Cells["plan"].Value.ToString();
            }
        }

        private void chkdate_CheckedChanged(object sender, EventArgs e)
        {
            if(chkdate.Checked==true)
            {
                dtplan = connect.readdata("select PartNo,ProductionDate,Quantity,UploadDate from DeliveryPlan where ProductionDate ='" + dtpdateplan.Value.ToString("yyyy-MM-dd") + "'");
                dgvplan.DataSource = dtplan;
            }
            else
            {
                dtplan = connect.readdata("select PartNo,ProductionDate,Quantity,UploadDate from DeliveryPlan");
                dgvplan.DataSource = dtplan;
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dtplan = connect.readdata("select PartNo,ProductionDate,Quantity,UploadDate from DeliveryPlan where PartNo like ='%" + txtsearch.Text + "%'");
            dgvplan.DataSource = dtplan;
        }

        private void dtpdateplan_ValueChanged(object sender, EventArgs e)
        {
            if (chkdate.Checked == true)
            {
                dtplan = connect.readdata("select PartNo,ProductionDate,Quantity,UploadDate from DeliveryPlan where ProductionDate ='" + dtpdateplan.Value.ToString("yyyy-MM-dd") + "'");
                dgvplan.DataSource = dtplan;
            }
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            ExportToExcel _excel = new ExportToExcel();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _excel.ExportToExcelFunction(dtplan, saveFileDialog1.FileName.ToString());
            }
        }
        //dowload template
        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dttemplate = connect.readdata("select PartNo,IdWarehouse,ProductionDate,Quantity from DeliveryPlan where Partno is null ");
            ExportToExcel _excel = new ExportToExcel();
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                _excel.ExportToExcelFunction(dttemplate, saveFileDialog2.FileName.ToString());
            }
        }

        private void btnbrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Excell|*.xls;*.xlsx;";
            od.FileName = "deliveryplan.xlsx";
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
            if (txtpath.Text == "" || !txtpath.Text.Contains("deliveryplan.xlsx"))
            {
                MessageBox.Show("Please Browse deliveryplan.xlsx to upload", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                pictureBox1.Visible = false;
                txtpath.Text = "";
                btnbrowser.Enabled = true;
                bw.Dispose();

            };

            //lets allow the user to click stop  
            pictureBox1.Visible = true;
            MessageBox.Show("Uploading has been started !");

            btnbrowser.Enabled = false;

            //Starts the actual work - triggerrs the "DoWork" event  
            bw.RunWorkerAsync();

        }

    }
}
