using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using ExcelDataReader;
using System.IO;
using System.Threading;
using System.Configuration;
using Excel = Microsoft.Office.Interop.Excel;
using HANMISYSTEM.Module;
using HANMISYSTEM.Views.Producs;

namespace HANMISYSTEM
{
    public partial class GoodsMgt : Form
    {
        BackgroundWorker bw = new BackgroundWorker
        {
            WorkerReportsProgress = true,
            WorkerSupportsCancellation = true
        };
        List<Button> buttons = new List<Button>();
        const int pageSize = 20;
        int totalPage;
        public int SetTotalPage
        {
            get { return totalPage; }
            set
            {
                totalPage = value;
                UpdateLabels();
                UpdatePageList();
            }
        }
        int curPage;
        int SetPage
        {
            get { return curPage; }
            set
            {
                curPage = value;
                UpdateLabels();
                LoadMorePage();
                GoLastPage();
                ShowLessPage();
                UpdatePageList();
                CheckGoPageButton();
                GetData(curPage, pageSize, txtsearch.Text, cbbCategory.SelectedValue.ToString(), cbbProcess.SelectedValue.ToString());
            }
        }
        private void CheckGoPageButton()
        {
            if (Convert.ToInt32(p6.Text) < totalPage)
            {
                p7.Visible = true;
            }
            else
            {
                p7.Visible = false;
            }
        }
        private void GoLastPage()
        {
            if (curPage == totalPage)
            {
                int num;
                num = totalPage % 6;
                for (int i = 0; i < num; i++)
                {
                    buttons[i].Text = (totalPage - num + 1 + i).ToString();
                    buttons[i].Visible = true;
                }
            }
        }
        private void ShowLessPage()
        {
            if (curPage.ToString() == p1.Text && curPage >= 4)
            {
                foreach (Button button in buttons)
                {
                    if (button.Text != "...")
                        button.Text = (Convert.ToInt32(button.Text) - 3).ToString();
                }
            }
        }
        private void LoadMorePage()
        {
            if (curPage.ToString() == p6.Text && curPage < totalPage)
            {
                foreach (Button button in buttons)
                {
                    if (button.Text != "...")
                        button.Text = (Convert.ToInt32(button.Text) + 3).ToString();
                }
            }
        }
        private void SetActivePage()
        {
            foreach (Button button in buttons)
            {
                if (button.Text == curPage.ToString())
                {
                    button.BackColor = Color.FromArgb(30, 140, 240);
                    button.ForeColor = Color.White;
                }
            }
        }
        private void SetPageListVisible()
        {
            foreach (Button button in buttons)
            {
                button.Visible = false;
            }
        }
        private void RemoveActive()
        {
            foreach (Button button in buttons)
            {
                button.BackColor = SystemColors.Control;
                button.ForeColor = Color.Black;
            }
        }
        private void HideAllPageNotExist()
        {
            foreach (Button button in buttons)
            {
                if (button.Text != "...")
                {
                    if (Convert.ToInt32(button.Text) > totalPage)
                    {
                        button.Visible = false;
                        p7.Visible = false;
                    }
                }

            }
        }
        private void UpdatePageList()
        {
            try
            {
                SetPageListVisible();

                if (totalPage > 0)
                {
                    RemoveActive();
                    //show page list
                    //if page is last
                    if (curPage == totalPage)
                    {
                        int num;
                        num = totalPage % 6;
                        if (num > 0)
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                buttons[i].Text = (totalPage - num + 1 + i).ToString();
                                if (Convert.ToInt32(buttons[i].Text) <= totalPage)
                                    buttons[i].Visible = true;
                            }
                        }
                        else
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                buttons[i].Text = (totalPage - 6 + 1 + i).ToString();
                                if (Convert.ToInt32(buttons[i].Text) <= totalPage)
                                    buttons[i].Visible = true;
                            }
                        }
                    }
                    else
                    {
                        //go page not inside current page list
                        if (!CheckContain(curPage.ToString()))
                        {
                            int num = (curPage / 6);
                            if (curPage % 6 == 0)
                            {
                                for (int i = 0; i < 6; i++)
                                {
                                    buttons[i].Text = (num * 6 - 5 + i).ToString();
                                    if (Convert.ToInt32(buttons[i].Text) <= totalPage || buttons[i].Text == "...")
                                        buttons[i].Visible = true;
                                }

                            }
                            else
                            {
                                for (int i = 0; i < 6; i++)
                                {

                                    buttons[i].Text = ((num + 1) * 6 - 5 + i).ToString();
                                    if (Convert.ToInt32(buttons[i].Text) <= totalPage || buttons[i].Text == "...")
                                        buttons[i].Visible = true;


                                }
                            }


                        }
                        else
                        {
                            for (int i = 0; i <= ((totalPage >= 6) ? 6 : totalPage - 1); i++)
                            {
                                if (buttons[i].Text != "..." && curPage == 1)
                                {
                                    buttons[i].Text = (i + 1).ToString();
                                }
                                buttons[i].Visible = true;
                            }
                        }

                    }
                    SetActivePage();
                    HideAllPageNotExist();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private bool CheckContain(string page)
        {
            foreach (Button button in buttons)
            {
                if (button.Text == page)
                    return true;
            }
            return false;
        }
        private void UpdateLabels()
        {
            lbCurrentPage.Text = curPage.ToString();
            lbTotalPage.Text = totalPage.ToString();
        }
        private void btnGoLast_Click(object sender, EventArgs e)
        {
            SetPage = GetTotalPage(txtsearch.Text, cbbCategory.SelectedValue.ToString(), cbbProcess.SelectedValue.ToString());
        }
        private void btnGoFirst_Click(object sender, EventArgs e)
        {
            SetPage = 1;
        }
        private void loaddata(string cmd)
        {
            try
            {
                DataTable dt = connect.readdata(cmd);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                throw;
            }
        }
        private int GetTotalPage(string searchTearm, string catID, string processID)
        {
            DataTable dataTable;
            string sql;
            sql = "select count(*) as row from cargo inner join unit  on cargo.idunit=unit.idunit inner join category on cargo.idcategory=category.idcategory where cargo.partno like '%" + searchTearm + "%' " + ((catID == "ALL")? " " : "and category.idcategory ='"+catID+"'") +((processID=="0")?" ": " and cargo.ProcessID ='" + processID + "'") ;
            dataTable = connect.readdata(sql);


            if (dataTable.Rows.Count > 0)
            {
                if (Convert.ToInt32(dataTable.Rows[0]["row"].ToString()) % pageSize == 0)
                {
                    return Convert.ToInt32(dataTable.Rows[0]["row"].ToString()) / pageSize;
                }
                else
                {
                    return Convert.ToInt32(dataTable.Rows[0]["row"].ToString()) / pageSize + 1;
                }
            }

            return 0;
        }
        private void GetData(int page, int pageSize, string searchTearm, string catID, string processID)
        {
            string sql;
            try
            {
                string checkCate = ((catID == "ALL") ? " " : "and category.idcategory ='" + catID + "'");
                string checkProcess = (processID == "0") ? " " : " and cargo.ProcessID ='"+processID+"'";
                sql = "with temp as  (select ROW_NUMBER() over (order by cargo.partno desc) as row, partno,partname,category.namecategory,specificationinfo,productivity,unit.nameunit,process,tradingpartnumber,othername,(select name from ProductKind where ID=cargo.ProductionKindID) as ProductionKindID  from cargo inner join unit  on cargo.idunit=unit.idunit inner join category on cargo.idcategory=category.idcategory  where cargo.partno like '%" + searchTearm + "%' " + checkCate +checkProcess+") select *  from temp  where row >=" + ((page * pageSize - pageSize) + 1) + " and row <= " + (page * pageSize) + " order by row asc";
                loaddata(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void btn_gopage(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SetPage = Convert.ToInt32(btn.Text);
            GetData(curPage, pageSize, txtsearch.Text, cbbCategory.SelectedValue.ToString(), cbbProcess.SelectedValue.ToString());
        }
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

        // fill the data from database to datagridview

        private void GoodsMgt_Load(object sender, EventArgs e)
        {

            DataTable dt = connect.readdata("select * from category");
            dt.Rows.Add("ALL", "ALL");
            cbbCategory.DataSource = dt;
            
            cbbCategory.ValueMember = "idcategory";
            cbbCategory.DisplayMember = "namecategory";
            cbbCategory.Text = "ALL";
            DataTable dt1 = connect.readdata("select * from unit");

            DataTable dtprocess = connect.readdata("select ID,Name from BomProcess");
            dtprocess.Rows.Add(0, "ALL");
            cbbProcess.DataSource = dtprocess;
            cbbProcess.DisplayMember = "Name";
            cbbProcess.ValueMember = "ID";
            cbbProcess.SelectedValue = 0;
            buttons.Add(p1);
            buttons.Add(p2);
            buttons.Add(p3);
            buttons.Add(p4);
            buttons.Add(p5);
            buttons.Add(p6);
            buttons.Add(p7);
            foreach (Button button in buttons)
            {
                if (button.Text != "...")
                {
                    button.Click += btn_gopage;
                }
            }
            SetPage = 1;
            //GetData(1, pageSize, "");
            SetTotalPage = GetTotalPage(txtsearch.Text, cbbCategory.SelectedValue.ToString(), cbbProcess.SelectedValue.ToString());

            //pagelist
            UpdatePageList();
            //loaddata("select partno,partname,category.namecategory,specificationinfo,productivity,unit.nameunit,process,tradingpartnumber,othername,(select name from ProductKind where ID=cargo.ProductionKindID) as ProductionKindID from cargo inner join unit  on cargo.idunit=unit.idunit inner join category on cargo.idcategory=category.idcategory");
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
           // loaddata("select partno,partname,category.namecategory,specificationinfo,productivity,unit.nameunit,process,tradingpartnumber,othername,(select name from ProductKind where ID=cargo.ProductionKindID) as ProductionKindID from cargo inner join unit  on cargo.idunit=unit.idunit inner join category on cargo.idcategory=category.idcategory where cargo.partno like '%" + txtsearch.Text + "%' or partname like '%" + txtsearch.Text + "%'");
        }



        //private void btnsave_Click(object sender, EventArgs e)
        //{
        //    if (cbunit.Text == "" || txtpartno.Text == "" || txtpartname.Text == "" || cbcategory.Text == "")
        //    {
        //        MessageBox.Show("Không được bỏ trống trường nào");
        //    }
        //    else
        //    {
        //        if (connect.countdata("select count(partno) from cargo where partno ='" + txtpartno.Text + "'") == 0)
        //        {
        //            MessageBox.Show("Mã hàng chưa có,hãy thêm mới vào");
        //        }
        //        else
        //        {
        //            if (connect.exedata("update cargo set partname='" + txtpartname.Text + "',productivity ='" + txtproductivity.Text + "',specificationinfo='" + txtinfo.Text + "',othername='" + txtothername.Text + "',process='" + cbprocess.Text + "',idcategory='" + cbcategory.SelectedValue.ToString() + "',idunit='" + cbunit.SelectedValue.ToString() + "',ProductionKindID='" + cbProductKind.SelectedValue.ToString() + "',ProcessID='" + cbprocess.SelectedValue.ToString() + "' where partno ='" + txtpartno.Text + "'") == true)
        //            {
        //                connect.exedata("delete from packingstandard where partno ='" + txtpartno.Text + "' and idpacking ='" + cbpacking.Text + "'");
        //                if (connect.exedata("insert into packingstandard  (partno,idpacking,quantity) values ('" + txtpartno.Text + "','" + cbpacking.Text + "','" + txtquantity.Text + "')") == false)
        //                {
        //                    packingnotify fr = new packingnotify();
        //                    fr.lbidpacking.Text = cbpacking.Text;
        //                    fr.lbpartno.Text = txtpartno.Text;
        //                    fr.ShowDialog();
        //                }
        //                MessageBox.Show("Thanh cong");
        //                loaddata("select partno,partname,category.namecategory,specificationinfo,productivity,unit.nameunit,process,tradingpartnumber,othername,(select name from ProductKind where ID=cargo.ProductionKindID) as ProductionKindID from cargo inner join unit  on cargo.idunit=unit.idunit inner join category on cargo.idcategory=category.idcategory where cargo.partno like '%" + txtsearch.Text + "%' or partname like '%" + txtsearch.Text + "%'");
        //                txtquantity.Text = "";
        //            }
        //            else
        //                MessageBox.Show("That bai");
        //        }

        //    }
        //}

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            using (AddProduct frm =new AddProduct())
            {
                frm.action = "ADD";
                frm.ShowDialog();
            }
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Check if the cell contains an image
                if (cell is DataGridViewImageCell)
                {
                    dataGridView1.Cursor = Cursors.Hand;
                }
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell is DataGridViewImageCell)
                {
                    dataGridView1.Cursor = Cursors.Default;
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(curPage>1)
            {
                SetPage = curPage - 1;
            }
            
        }

        private void btnGoFirst_Click_1(object sender, EventArgs e)
        {
            SetPage = 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(curPage<totalPage)
            {
                SetPage = curPage + 1;
            }
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            SetPage = 1;
            SetTotalPage = GetTotalPage(txtsearch.Text, cbbCategory.SelectedValue.ToString(), cbbProcess.SelectedValue.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var clickedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

            // Check if the clicked cell belongs to the image column
            if (clickedCell.OwningColumn.Name == "Action_col" && e.RowIndex >= 0)
            {
                using (AddProduct frm =new AddProduct())
                {
                    try
                    {
                        frm.action = "EDIT";
                        frm.lbAction.Text = "Sửa";
                        frm.txtpartno.Text = dataGridView1.Rows[e.RowIndex].Cells["partno"].Value.ToString();
                        frm.txtpartname.Text = dataGridView1.Rows[e.RowIndex].Cells["partname"].Value.ToString();
                        frm.txtproductivity.Text = dataGridView1.Rows[e.RowIndex].Cells["productivity"].Value.ToString();
                        frm.txtinfo.Text = dataGridView1.Rows[e.RowIndex].Cells["specificationinfo"].Value.ToString();
                        frm.cbprocess.Text = dataGridView1.Rows[e.RowIndex].Cells["process"].Value.ToString();
                        frm.cbcategory.Text = dataGridView1.Rows[e.RowIndex].Cells["category"].Value.ToString();
                        frm.cbunit.Text = dataGridView1.Rows[e.RowIndex].Cells["unit"].Value.ToString();
                        frm.cbProductKind.Text = dataGridView1.Rows[e.RowIndex].Cells["ProductKind"].Value.ToString();
                        frm.txttradingpartnumber.Text = dataGridView1.Rows[e.RowIndex].Cells["tradingpartnumber"].Value.ToString();
                        frm.txtothername.Text = dataGridView1.Rows[e.RowIndex].Cells["othername"].Value.ToString();
                        frm.ShowDialog();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
          
                }
            }
            else if (clickedCell.OwningColumn.Name == "ActionCopy_col" && e.RowIndex >= 0)
            {
                using (AddProduct frm = new AddProduct())
                {
                    try
                    {
                        frm.action = "COPY";
                        frm.lbAction.Text = "Sao chép";
                        frm.txtpartno.Text = dataGridView1.Rows[e.RowIndex].Cells["partno"].Value.ToString()+"COPY";
                        frm.txtpartname.Text = dataGridView1.Rows[e.RowIndex].Cells["partname"].Value.ToString();
                        frm.txtproductivity.Text = dataGridView1.Rows[e.RowIndex].Cells["productivity"].Value.ToString();
                        frm.txtinfo.Text = dataGridView1.Rows[e.RowIndex].Cells["specificationinfo"].Value.ToString();
                        frm.cbprocess.Text = dataGridView1.Rows[e.RowIndex].Cells["process"].Value.ToString();
                        frm.cbcategory.Text = dataGridView1.Rows[e.RowIndex].Cells["category"].Value.ToString();
                        frm.cbunit.Text = dataGridView1.Rows[e.RowIndex].Cells["unit"].Value.ToString();
                        frm.cbProductKind.Text = dataGridView1.Rows[e.RowIndex].Cells["ProductKind"].Value.ToString();
                        frm.txttradingpartnumber.Text = dataGridView1.Rows[e.RowIndex].Cells["tradingpartnumber"].Value.ToString();
                        frm.txtothername.Text = dataGridView1.Rows[e.RowIndex].Cells["othername"].Value.ToString();
                        frm.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }   
            else if(clickedCell.OwningColumn.Name == "ActionDelete_col" && e.RowIndex >= 0){

            }
            SetPage = curPage;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

        }
    }
}
