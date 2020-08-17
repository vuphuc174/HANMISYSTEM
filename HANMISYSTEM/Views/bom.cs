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
using System.Data.OleDb;
using System.Threading;
using Excel= Microsoft.Office.Interop.Excel ;


namespace HANMISYSTEM
{
    public partial class bom : Form
    {
        BackgroundWorker bw = new BackgroundWorker
        {
            WorkerReportsProgress = true,
            WorkerSupportsCancellation = true
        };
       
         
        private delegate void dlgAddItem();
        private int count;
        private int counttrue;
        private void InsertExcelRecord()
        {
            //try
           // {

                //  ExcelConn(_path);  
                string constr = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0 Xml;HDR=YES;""", _path);
                OleDbConnection Econ = new OleDbConnection(constr);
                string Query = string.Format("Select [Finnished goods part],[Raw partno],[Quantity] FROM [{0}]", "Sheet1$");
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
                    
                    if (Exceldt.Rows[i]["Finnished goods part"] != DBNull.Value && Exceldt.Rows[i]["Raw partno"] != DBNull.Value && Exceldt.Rows[i]["Quantity"] != DBNull.Value)
                    {
                        if (connect.countdata("select count (*) from bom where partno='" + Exceldt.Rows[i]["Finnished goods part"] + "' and rawpartno='" + Exceldt.Rows[i]["Raw partno"] + "'") == 0)
                        {
                            if (connect.countdata("select count(*) from cargo where partno='" + Exceldt.Rows[i]["Finnished goods part"] + "'") != 0 && connect.countdata("select count(*) from cargo where partno='" + Exceldt.Rows[i]["Raw partno"] + "'") != 0)
                            {
                                counttrue = counttrue + 1;
                            }
                            else
                            {
                                try
                                {
                                   
                                    OleDbCommand cmd = new OleDbCommand();
                                    cmd.Connection = Econ;
                                    cmd.CommandText = @"Update  [Sheet1$] set status='Part no not exist' where [Finnished goods part] ='" + Exceldt.Rows[i]["Finnished goods part"] + "' and [Raw partno] ='" + Exceldt.Rows[i]["Raw partno"] + "'  ;";
                                    cmd.ExecuteNonQuery();
                                }
                                catch(Exception ex)
                                {
                                    MessageBox.Show("" + ex.ToString());
                                }
                              
                                count = count + 1;
                                //worksheet.get_Range("D" + i).Value = "part ko dung";
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
                                cmd.CommandText = @"Update  [Sheet1$] set status='Existed' where [Finnished goods part] ='" + Exceldt.Rows[i]["Finnished goods part"] + "' and [Raw partno] ='" + Exceldt.Rows[i]["Raw partno"] + "'  ;";
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
                            cmd.CommandText = @"Update  [Sheet1$] set status='line empty' where [Finnished goods part] ='" + Exceldt.Rows[i]["Finnished goods part"] + "' and [Raw partno] ='" + Exceldt.Rows[i]["Raw partno"] + "'  ;";
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
                objbulk.DestinationTableName = "bom";
                //Mapping Table column    
                objbulk.ColumnMappings.Add("[Finnished goods part]", "partno");
                objbulk.ColumnMappings.Add("Raw partno", "rawpartno");
                objbulk.ColumnMappings.Add("Quantity", "quantity");

                //inserting Datatable Records to DataBase   
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = "server = '" + HANMISYSTEM.Properties.Settings.Default.servername + "'; database = HANMI; User ID = '" + HANMISYSTEM.Properties.Settings.Default.uid + "'; Password = '" + HANMISYSTEM.Properties.Settings.Default.pwd + "'"; //Connection Details    
                connect.con.Open();
                objbulk.WriteToServer(Exceldt);
                connect.con.Close();
                MessageBox.Show("Data has been Imported done with : " + counttrue + " success and " + count + " fails", "Imported", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread loadThread =new Thread(new ThreadStart(loadbom));
                loadThread.Start();
                

            /*}
            catch (Exception ex)
            {
                MessageBox.Show(count+" fails  +Data has not been Imported due to " + ex.ToString(), "Not Imported", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  */
        }
        private void loadbom()
        {
            if(dataGridView1.InvokeRequired)
            {
                dataGridView1.Invoke(new dlgAddItem(loadbom));
            }
            else
            {
                DataTable dt = connect.readdata("select distinct cargo.partno,cargo.partname,(select COUNT (*) from bom where bom.partno=cargo.partno)as qty  from cargo inner join bom on cargo.partno=bom.partno");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
            }
            
        }

        public bom()
        {
            InitializeComponent();
        }
        //private bool check = true;
        private bool checkqty = true;
        Dbconnect connect = new Dbconnect();
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Loaddata(string cmd)
        {
            DataTable dt = connect.readdata(cmd);
            if(dt!=null)
            {
                dataGridView1.DataSource = dt;
            }
        }
        private void btnselect_Click(object sender, EventArgs e)
        {
            DataTable dt = connect.readdata("select * from cargo where partno like '"+txtpartno.Text+"' and idcategory <>'1'");
            if(dt.Rows.Count>0)
            {
                txtpartname.Text=dt.Rows[0]["partname"].ToString();
            }
            else
            {
                MessageBox.Show("Part no not found or not invalid");
            }
        }

        private void txtpartno_TextChanged(object sender, EventArgs e)
        {
            txtpartname.Text = "";
        }

        private void bom_Load(object sender, EventArgs e)
        {
            Loaddata("select distinct cargo.partno,cargo.partname,(select COUNT (*) from bom where bom.partno=cargo.partno)as qty  from cargo inner join bom on cargo.partno=bom.partno");
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < dataGridView2.Rows.Count;j++ )
            {
                if (dataGridView2.Rows[j].Cells["Qty"].Value == null || dataGridView2.Rows[j].Cells["rawname"].Value == null || dataGridView2.Rows[j].Cells["rawpartno"].Value == null)
                {
                    checkqty=false;
                }
            }
            if (checkqty == true)
            {
                if (txtpartname.Text != "")
                {
                    if (connect.countdata("select count (*) from bom where partno='" + txtpartno.Text + "'") > 0)
                    {
                        DialogResult dlr;
                        dlr=MessageBox.Show("partno " + txtpartno.Text + " has bom ,do you want change this ","Notice",MessageBoxButtons.OKCancel);
                        if(dlr==DialogResult.OK)
                        {
                            connect.exedata("delete from bom where partno ='"+txtpartno.Text+"'");
                            for (int k = 0; k < dataGridView2.Rows.Count; k++)
                            {
                                connect.exedata("insert into bom values('" + txtpartno.Text + "','" + dataGridView2.Rows[k].Cells["rawpartno"].Value + "','" + dataGridView2.Rows[k].Cells["Qty"].Value + "')");
                               
                            }
                            MessageBox.Show("success");
                            checkqty = true;
                            txtpartno.Text = "";
                            dataGridView2.Rows.Clear();
                            Loaddata("select distinct cargo.partno,cargo.partname,(select COUNT (*) from bom where bom.partno=cargo.partno)as qty  from cargo inner join bom on cargo.partno=bom.partno");
                        }
                    }
                    else
                    {
                        for (int i = 0; i < dataGridView2.Rows.Count; i++)
                        {
                            if (connect.exedata("insert into bom values('" + txtpartno.Text + "','" + dataGridView2.Rows[i].Cells["rawpartno"].Value + "','" + dataGridView2.Rows[i].Cells["Qty"].Value + "')"))
                            {
                                MessageBox.Show("success");
                                checkqty = true;
                                txtpartno.Text = "";
                                Loaddata("select distinct cargo.partno,cargo.partname,(select COUNT (*) from bom where bom.partno=cargo.partno)as qty  from cargo inner join bom on cargo.partno=bom.partno");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Dont empty field *");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView2.Columns[e.ColumnIndex].Name == "rawpartno")
            //{
            //    if(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value==null)
            //    {
            //        dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
            //    }
            //    else
            //    {
            //        DataTable dt = connect.readdata("select * from cargo where partno='" + dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + "' and idcategory <> '3'");
            //        if (dt.Rows.Count > 0)
            //        {
            //            if (dataGridView2.Rows.Count>2)
            //            {
            //                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            //                {
            //                    if (dataGridView2.Rows[e.RowIndex].Cells["rawpartno"].Value == dataGridView2.Rows[i].Cells["rawpartno"].Value)
            //                    {
            //                        check = false;
            //                    }
            //                }
            //            }
                        
            //            if (check == true)
            //            {
            //                dataGridView2.Rows[e.RowIndex].Cells["rawname"].Value = dt.Rows[0]["partname"];
            //            }
            //            else
            //            {
            //                MessageBox.Show("Some error occur when you import the raw: Conflict raw");
            //                dataGridView2.Rows[e.RowIndex].Cells["rawpartno"].Value = "";
            //                check = true;
            //            }

            //        }
            //        else
            //        {
            //            MessageBox.Show("Raw not found or not invalid");
            //            dataGridView2.Rows[e.RowIndex].Cells["rawpartno"].Value = "";
            //        }
            //    }
                
            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt;
            DataTable dt1;
            if(e.RowIndex>-1)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["partno"].Value != null)
                {
                    dataGridView2.Rows.Clear();
                    txtpartno.Text = dataGridView1.Rows[e.RowIndex].Cells["partno"].Value.ToString();
                    dt = connect.readdata("select * from cargo where partno ='" + txtpartno.Text + "'");
                    txtpartname.Text = dt.Rows[0]["partname"].ToString();
                    dt1 = connect.readdata("select rawpartno,cargo.partname,quantity from bom inner join cargo on bom.rawpartno=cargo.partno where bom.partno='" + dataGridView1.Rows[e.RowIndex].Cells["partno"].Value.ToString() + "'");
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {

                        dataGridView2.Rows.Add(dt1.Rows[i]["rawpartno"].ToString(), dt1.Rows[i]["partname"].ToString(), dt1.Rows[i]["quantity"].ToString());
                        //dataGridView2.Rows.Add(dt1.Rows[i]["partno"].ToString(), dt1.Rows[i]["partname"].ToString, Convert.ToInt32(dt1.Rows[i]["quantity"].ToString()));
                    }
                }
            }
            
            

        }
        static private string _path;
        private void btnbrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Excell|*.xls;*.xlsx;";
            od.FileName = "bomdata.xlsx";
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
            if (txtpath.Text == "" || !txtpath.Text.Contains("bomdata.xlsx"))
            {
                MessageBox.Show("Please Browse bomdata.xlsx to upload", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                label3.Visible = false;
                bw.Dispose();
                
            };

            //lets allow the user to click stop  
            pictureBox1.Visible = true;
            label3.Visible = true;
            MessageBox.Show("Uploading has been started !");

            btnbrowser.Enabled = false;

            //Starts the actual work - triggerrs the "DoWork" event  
            bw.RunWorkerAsync();

            //InsertExcelRecords();           
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
            {
                
                    if (connect.exedata("delete from bom where partno='" + txtpartno.Text + "' and rawpartno='" + dataGridView2.Rows[item.Index].Cells["rawpartno"].Value + "'"))
                    {
                        dataGridView2.Rows.RemoveAt(item.Index);
                        Loaddata("select distinct cargo.partno,cargo.partname,(select COUNT (*) from bom where bom.partno=cargo.partno)as qty  from cargo inner join bom on cargo.partno=bom.partno");
                        MessageBox.Show("Success");

                    }
                
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Columns.Contains("rawpartno"))
            {
                DataTable dtcargo = connect.readdata("select partname from cargo where partno ='"+dataGridView1.Rows[e.RowIndex].Cells["rawpartno"].Value+"'");
                if(dtcargo.Rows.Count>0)
                {
                    dataGridView1.Rows[e.RowIndex].Cells["rawname"].Value=dtcargo.Rows[0]["partname"].ToString();
                }
            }
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
        BomDetails fr = new BomDetails();
        
     
        private void menuItem1_Click(object sender, System.EventArgs e)
        {
           
            if(id!=-1)
            {
                fr.treeView1.Nodes.Clear();
                //lbpartno
                DataTable dtbom = connect.readdata("select * from bom where partno='"+dataGridView1.Rows[id].Cells["partno"].Value.ToString()+"'");
                fr.lbpartno.Text=dtbom.Rows[0]["partno"].ToString();

                //lbpartname
                DataTable dtcargo = connect.readdata("select partno,partname from cargo where partno='"+fr.lbpartno.Text+"'");
                try
                {
                    fr.lbpartname.Text=dtcargo.Rows[0]["partname"].ToString();
                }
                catch
                {

                }
                //lbrawqty
                fr.lbrawqty.Text = connect.countdata("select count(partno) from bom where partno='"+fr.lbpartno.Text+"'").ToString();
                TreeNode parent = new TreeNode();
                parent.Text = fr.lbpartno.Text;
                fr.treeView1.Nodes.Add(parent);
                GetAllNodes(ref parent, dtbom.Rows[0]["partno"].ToString());
                fr.ShowDialog();
            }
            

        }
        private void GetAllNodes(ref TreeNode parent, string strparent)
        {
            DataTable dtbomnode = connect.readdata("select bom.partno,rawpartno,partname,quantity from bom inner join cargo on bom.partno=cargo.partno where bom.partno='" + strparent + "'");
            if (dtbomnode.Rows.Count != 0)
            {
                for (int i = 0; i < dtbomnode.Rows.Count; i++)
                {
                    TreeNode child = new TreeNode();
                    
                    child.Tag = dtbomnode.Rows[i]["rawpartno"].ToString() + "/" + dtbomnode.Rows[0]["partname"].ToString()  + "/" + dtbomnode.Rows[i]["quantity"].ToString();
                    child.Text = child.Tag.ToString(); //dtbomnode.Rows[i]["rawpartno"].ToString();
                    parent.Nodes.Add(child);
                    GetAllNodes(ref child, dtbomnode.Rows[i]["rawpartno"].ToString());
                }


            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //if(txtsearch.Text!="")
            //{
                Loaddata("select distinct cargo.partno,cargo.partname,(select COUNT (*) from bom where bom.partno=cargo.partno)as qty  from cargo inner join bom on cargo.partno=bom.partno where cargo.partno like '%" + txtsearch.Text + "%' or partname like '%" + txtsearch.Text + "%'");
           // }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("","","");
        }

        
    }
}
