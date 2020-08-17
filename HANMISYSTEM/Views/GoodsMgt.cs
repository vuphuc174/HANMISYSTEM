using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using ExcelDataReader;
using System.IO;
using System.Threading;
using System.Configuration;
using Excel = Microsoft.Office.Interop.Excel;
using HANMISYSTEM.Module;

namespace HANMISYSTEM
{
    public partial class GoodsMgt : Form
    {
        BackgroundWorker bw = new BackgroundWorker
        {
            WorkerReportsProgress = true,
            WorkerSupportsCancellation = true
        };


        private delegate void dlgAddItem();
        private int count;
        private int counttrue;
        Dbconnect connect = new Dbconnect();
        Isnumber _isnumber = new Isnumber();
        private void InsertExcelRecord()
        {
            //try
            // {

            //  ExcelConn(_path);  
            string constr = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0 Xml;HDR=YES;""", _path);
            OleDbConnection Econ = new OleDbConnection(constr);
            string Query = string.Format("Select [Partno],[Partname],[Idcategory],[Specificationinfo],[Productivity],[Idunit] FROM [{0}]", "Sheet1$");
            OleDbCommand Ecom = new OleDbCommand(Query, Econ);
            Econ.Open();

            DataSet ds = new DataSet();
            OleDbDataAdapter oda = new OleDbDataAdapter(Query, Econ);

            oda.Fill(ds);
            DataTable Exceldt = ds.Tables[0];
            count = 0;
            counttrue = 0;
            for (int i = Exceldt.Rows.Count - 1; i >= 0; i--)
            {

                if (Exceldt.Rows[i]["Partno"] != DBNull.Value && Exceldt.Rows[i]["Partname"] != DBNull.Value && Exceldt.Rows[i]["Idcategory"] != DBNull.Value && Exceldt.Rows[i]["Idunit"] != DBNull.Value)
                {
                    if (connect.countdata("select count (*) from cargo where partno='" + Exceldt.Rows[i]["Partno"] + "'") == 0)
                    {
                        counttrue = counttrue + 1;
                    }
                    else
                    {
                        try
                        {

                            OleDbCommand cmd = new OleDbCommand();
                            cmd.Connection = Econ;
                            cmd.CommandText = @"Update  [Sheet1$] set status='Existed' where [Partno] ='" + Exceldt.Rows[i]["Partno"] + "';";
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("" + ex.ToString());
                        }

                        count = count + 1;
                        //worksheet.get_Range("D" + i).Value = "da ton tai";
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
                        cmd.CommandText = @"Update  [Sheet1$] set status='line empty' where [Partno] ='" + Exceldt.Rows[i]["Partno"] + "';";
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex.ToString());
                    }

                    count = count + 1;
                    //worksheet.get_Range("D" + i).Value = "dong trong";
                    Exceldt.Rows[i].Delete();
                    Exceldt.AcceptChanges();

                }
            }
            Econ.Close();
            Econ.Dispose();
            //creating object of SqlBulkCopy      
            SqlBulkCopy objbulk = new SqlBulkCopy(connect.con);
            //assigning Destination table name      
            objbulk.DestinationTableName = "cargo";
            //Mapping Table column    
            objbulk.ColumnMappings.Add("[Partno]", "partno");
            objbulk.ColumnMappings.Add("Partname", "partname");
            objbulk.ColumnMappings.Add("Idcategory", "idcategory");
            objbulk.ColumnMappings.Add("Specificationinfo", "specificationinfo");
            objbulk.ColumnMappings.Add("Productivity", "productivity");
            objbulk.ColumnMappings.Add("Idunit", "idunit");

            //inserting Datatable Records to DataBase   
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "server = '" + HANMISYSTEM.Properties.Settings.Default.servername + "'; database = HANMI; User ID = '" + HANMISYSTEM.Properties.Settings.Default.uid + "'; Password = '" + HANMISYSTEM.Properties.Settings.Default.pwd + "'"; //Connection Details    
            connect.con.Open();
            objbulk.WriteToServer(Exceldt);
            connect.con.Close();
            MessageBox.Show("Data has been Imported done with : " + counttrue + " success and " + count + " fails", "Imported", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Thread loadThread = new Thread(new ThreadStart(loadcargo));
            loadThread.Start();


            /*}
            catch (Exception ex)
            {
                MessageBox.Show(count+" fails  +Data has not been Imported due to " + ex.ToString(), "Not Imported", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  */
        }
        private void loadcargo()
        {
            if (dataGridView1.InvokeRequired)
            {
                dataGridView1.Invoke(new dlgAddItem(loadcargo));
            }
            else
            {
                DataTable dt = connect.readdata("select partno,partname,category.namecategory,specificationinfo,productivity,unit.nameunit from cargo inner join unit  on cargo.idunit=unit.idunit inner join category on cargo.idcategory=category.idcategory");
                if (dt != null)
                {
                    dataGridView1.DataSource = dt;
                }
            }

        }
        public GoodsMgt()
        {
            InitializeComponent();
        }
        private void loaddata(string cmd)
        {
            DataTable dt = connect.readdata(cmd);
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }


        // fill the data from database to datagridview

        private void GoodsMgt_Load(object sender, EventArgs e)
        {
            loaddata("select partno,partname,category.namecategory,specificationinfo,productivity,unit.nameunit,process,tradingpartnumber,othername,(select name from ProductKind where ID=cargo.ProductionKindID) as ProductionKindID from cargo inner join unit  on cargo.idunit=unit.idunit inner join category on cargo.idcategory=category.idcategory");
            DataTable dt = connect.readdata("select * from category");
            cbcategory.DataSource = dt;
            cbcategory.ValueMember = "idcategory";
            cbcategory.DisplayMember = "namecategory";
            DataTable dt1 = connect.readdata("select * from unit");
            cbunit.DataSource = dt1;
            cbunit.ValueMember = "idunit";
            cbunit.DisplayMember = "nameunit";
            cbpacking.SelectedIndex = 0;

            DataTable dtProductKind = connect.readdata("select ID,Name from ProductKind");
            cbProductKind.DataSource = dtProductKind;
            cbProductKind.DisplayMember = "Name";
            cbProductKind.ValueMember = "ID";

            DataTable dtprocess = connect.readdata("select ID,Name from BomProcess");
            cbprocess.DataSource = dtprocess;
            cbprocess.DisplayMember = "Name";
            cbprocess.ValueMember = "ID";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (cbunit.Text == "" || txtpartno.Text == "" || txtpartname.Text == "" || cbcategory.Text == "")
            {
                MessageBox.Show("Không được bỏ trống *");
            }
            else
            {
                if (connect.countdata("select count(*) from cargo where partno='" + txtpartno.Text + "'") > 0)
                {
                    MessageBox.Show("Partno đã tồn tại");
                }
                else
                {
                    if(txtpartno.Text.Contains(" ")!=true)
                    {
                        if (connect.exedata("insert into cargo (partno,partname,idcategory,specificationinfo,productivity,idunit,process,ProductionKindID,ProcessID)  values('" + txtpartno.Text.ToUpper() + "','" + txtpartname.Text + "','" + cbcategory.SelectedValue + "','" + txtinfo.Text + "','" + txtproductivity.Text + "','" + cbunit.SelectedValue + "','" + cbprocess.Text + "','" + cbProductKind.SelectedValue.ToString() + "','" + cbprocess.SelectedValue.ToString() + "')"))
                        {
                            if (connect.exedata("insert into packingstandard  (partno,idpacking,quantity) values ('" + txtpartno.Text + "','" + cbpacking.Text + "','" + txtquantity.Text + "')") == false)
                            {
                                packingnotify fr = new packingnotify();
                                fr.lbpartno.Text = txtpartno.Text;
                                fr.lbidpacking.Text = cbpacking.Text;
                                fr.ShowDialog();
                            }
                            MessageBox.Show("success");
                            loaddata("select partno,partname,category.namecategory,specificationinfo,productivity,unit.nameunit,process,tradingpartnumber,othername,(select name from ProductKind where ID=cargo.ProductionKindID) as ProductionKindID from cargo inner join unit  on cargo.idunit=unit.idunit inner join category on cargo.idcategory=category.idcategory");
                            txtpartno.Text = "";
                            txtpartname.Text = "";
                            txtquantity.Text = "";
                            txtinfo.Text = "";
                            txtproductivity.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã hàng không được chứa khoảng trắng ");
                    }
                    
                }

            }
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            btnimport.Visible = false;
            _path = txtpath.Text;
            if (txtpath.Text == "" || !txtpath.Text.Contains("cargodata.xlsx"))
            {
                MessageBox.Show("Please Browse cargodata.xlsx to upload", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                label7.Visible = false;
                bw.Dispose();

            };

            //lets allow the user to click stop  
            pictureBox1.Visible = true;
            label7.Visible = true;
            MessageBox.Show("Uploading has been started !");

            btnbrowser.Enabled = false;

            //Starts the actual work - triggerrs the "DoWork" event  
            bw.RunWorkerAsync();

            //InsertExcelRecords();           
        }
        static private string _path;
        private void btnbrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Excell|*.xls;*.xlsx;";
            od.FileName = "cargodata.xlsx";
            DialogResult dr = od.ShowDialog();
            if (dr == DialogResult.Abort)
                return;
            if (dr == DialogResult.Cancel)
                return;
            txtpath.Text = od.FileName.ToString();
            btnimport.Visible = true;
            _path = txtpath.Text;

        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel excel = new ExportToExcel();
                DataTable dt = connect.readdata("select * from cargo");
                excel.ExportToExcelFunction(dt, saveFileDialog1.FileName.ToString());
            }

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            loaddata("select partno,partname,category.namecategory,specificationinfo,productivity,unit.nameunit,process,tradingpartnumber,othername,(select name from ProductKind where ID=cargo.ProductionKindID) as ProductionKindID from cargo inner join unit  on cargo.idunit=unit.idunit inner join category on cargo.idcategory=category.idcategory where cargo.partno like '%" + txtsearch.Text + "%' or partname like '%" + txtsearch.Text + "%'");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataTable dtpacking = connect.readdata("select * from packingstandard where partno ='" + dataGridView1.Rows[e.RowIndex].Cells["partno"].Value.ToString() + "'");
                txtpartno.Text = dataGridView1.Rows[e.RowIndex].Cells["partno"].Value.ToString();
                txtpartname.Text = dataGridView1.Rows[e.RowIndex].Cells["partname"].Value.ToString();
                txtproductivity.Text = dataGridView1.Rows[e.RowIndex].Cells["productivity"].Value.ToString();
                txtinfo.Text = dataGridView1.Rows[e.RowIndex].Cells["specificationinfo"].Value.ToString();
                cbprocess.Text = dataGridView1.Rows[e.RowIndex].Cells["process"].Value.ToString();
                cbcategory.Text = dataGridView1.Rows[e.RowIndex].Cells["category"].Value.ToString();
                cbunit.Text = dataGridView1.Rows[e.RowIndex].Cells["unit"].Value.ToString();
                txttradingpartnumber.Text = dataGridView1.Rows[e.RowIndex].Cells["tradingpartnumber"].Value.ToString();
                txtothername.Text = dataGridView1.Rows[e.RowIndex].Cells["othername"].Value.ToString();
                cbProductKind.Text = dataGridView1.Rows[e.RowIndex].Cells["ProductKind"].Value.ToString();
                if (dtpacking.Rows.Count > 0)
                {
                    cbpacking.Text = dtpacking.Rows[0]["idpacking"].ToString();
                    txtquantity.Text = dtpacking.Rows[0]["quantity"].ToString();
                }

            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (cbunit.Text == "" || txtpartno.Text == "" || txtpartname.Text == "" || cbcategory.Text == "")
            {
                MessageBox.Show("Không được bỏ trống trường nào");
            }
            else
            {
                if (connect.countdata("select count(partno) from cargo where partno ='" + txtpartno.Text + "'") == 0)
                {
                    MessageBox.Show("Mã hàng chưa có,hãy thêm mới vào");
                }
                else
                {
                    if (connect.exedata("update cargo set partname='" + txtpartname.Text + "',productivity ='" + txtproductivity.Text + "',specificationinfo='" + txtinfo.Text + "',othername='" + txtothername.Text + "',process='" + cbprocess.Text + "',idcategory='" + cbcategory.SelectedValue.ToString() + "',idunit='" + cbunit.SelectedValue.ToString() + "',ProductionKindID='" + cbProductKind.SelectedValue.ToString() + "',ProcessID='" + cbprocess.SelectedValue.ToString() + "' where partno ='" + txtpartno.Text + "'") == true)
                    {
                        connect.exedata("delete from packingstandard where partno ='" + txtpartno.Text + "' and idpacking ='" + cbpacking.Text + "'");
                        if (connect.exedata("insert into packingstandard  (partno,idpacking,quantity) values ('" + txtpartno.Text + "','" + cbpacking.Text + "','" + txtquantity.Text + "')") == false)
                        {
                            packingnotify fr = new packingnotify();
                            fr.lbidpacking.Text = cbpacking.Text;
                            fr.lbpartno.Text = txtpartno.Text;
                            fr.ShowDialog();
                        }
                        MessageBox.Show("Thanh cong");
                        loaddata("select partno,partname,category.namecategory,specificationinfo,productivity,unit.nameunit,process,tradingpartnumber,othername,(select name from ProductKind where ID=cargo.ProductionKindID) as ProductionKindID from cargo inner join unit  on cargo.idunit=unit.idunit inner join category on cargo.idcategory=category.idcategory where cargo.partno like '%" + txtsearch.Text + "%' or partname like '%" + txtsearch.Text + "%'");
                        txtquantity.Text = "";
                    }
                    else
                        MessageBox.Show("That bai");
                }

            }
        }

        private void cbpacking_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtpartno.Text != "")
            {
                DataTable dtpacking = connect.readdata("select quantity from packingstandard where partno ='" + txtpartno.Text + "' and idpacking='" + cbpacking.Text + "'");
                if (dtpacking.Rows.Count > 0)
                {
                    txtquantity.Text = dtpacking.Rows[0]["quantity"].ToString();
                }

            }
        }

        private void txtpartno_TextChanged(object sender, EventArgs e)
        {
            txtquantity.Text = "";
        }


    }
}
