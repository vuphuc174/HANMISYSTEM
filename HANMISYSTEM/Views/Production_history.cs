using System;
using System.Collections.Generic;
using System.ComponentModel;
using tbl=System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.Data;

namespace HANMISYSTEM
{
    public partial class Production_history : Form
    {
        //int PageSize = 20;

        public Production_history()
        {
            InitializeComponent();
        }
        private string str;
        Dbconnect connect = new Dbconnect();
        public class Page
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public bool Selected { get; set; }
        }
        static string sn = HANMISYSTEM.Properties.Settings.Default.servername;
        static string uid = HANMISYSTEM.Properties.Settings.Default.uid;
        static string pwd = HANMISYSTEM.Properties.Settings.Default.pwd;
        
        
        
        public void ExportToExcel(tbl.DataTable dataTable, string ExcelFilePath)
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
        private void loaddata(string cmd)
        {
            tbl.DataTable dt = connect.readdata(cmd);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }
        private void Production_history_Load(object sender, EventArgs e)
        {
            tbl.DataTable dt = connect.readdata("select * from warehouse");
            if(dt.Rows.Count>0)
            {
                cbwarehouse.DataSource = dt;
                cbwarehouse.ValueMember = "idwarehouse";
                cbwarehouse.DisplayMember = "namewarehouse";
            }
            tbl.DataTable dtlocation = connect.readdata("select * from location");
            cblocation.DataSource = dtlocation;
            cblocation.DisplayMember = "namelocation1";
            cblocation.ValueMember = "idlocation";
            cblocation.SelectedValue="L1";
            loaddata("select top 100  namewarehouse,cargo.partno,partname,productiontime,stoptime,remark,qty,idlocation from productionhistory inner join cargo on productionhistory.partno=cargo.partno inner join warehouse on productionhistory.idwarehouse=warehouse.idwarehouse where warehouse.idwarehouse ='WH001' and idlocation ='L1'");
           
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if(txtsearch.Text!="")
            {
                str = "select namewarehouse,cargo.partno,partname,productiontime,stoptime,remark,qty,idlocation from productionhistory inner join cargo on productionhistory.partno=cargo.partno inner join warehouse on productionhistory.idwarehouse=warehouse.idwarehouse where namewarehouse like '%" + txtsearch.Text + "%' or cargo.partno like '%" + txtsearch.Text + "%' or partname like '%" + txtsearch.Text + "%' and warehouse.idwarehouse='"+cbwarehouse.SelectedValue+"'";
                tbl.DataTable dt=connect.readdata(str);
                dataGridView1.DataSource = dt;
            }
            else
            {

            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if(txtsearch.Text=="")
            {
                str = "select namewarehouse,cargo.partno,partname,productiontime,stoptime,remark,qty,idlocation from productionhistory inner join cargo on productionhistory.partno=cargo.partno inner join warehouse on productionhistory.idwarehouse=warehouse.idwarehouse where productiontime between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' and warehouse.idwarehouse='" + cbwarehouse.SelectedValue + "'  and idlocation='" + cblocation.SelectedValue.ToString() + "'";
            }
            else
            {
                str = "select namewarehouse,cargo.partno,partname,productiontime,stoptime,remark,qty,idlocation from productionhistory inner join cargo on productionhistory.partno=cargo.partno inner join warehouse on productionhistory.idwarehouse=warehouse.idwarehouse where namewarehouse like '%" + txtsearch.Text + "%' or cargo.partno like '%" + txtsearch.Text + "%' or partname like '%" + txtsearch.Text + "%' and productiontime between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' and warehouse.idwarehouse='" + cbwarehouse.SelectedValue + "' and idlocation ='" + cblocation.SelectedValue.ToString() + "'";
            }
            tbl.DataTable dt = connect.readdata(str);
            dataGridView1.DataSource = dt;
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(txtsearch.Text=="")
                {
                    str="select namewarehouse,cargo.partno,partname,productiontime,stoptime,remark,qty,idlocation from productionhistory inner join cargo on productionhistory.partno=cargo.partno inner join warehouse on productionhistory.idwarehouse=warehouse.idwarehouse where warehouse.idwarehouse='"+cbwarehouse.SelectedValue+"'";
                    tbl.DataTable dt = connect.readdata(str);
                    ExportToExcel(dt, saveFileDialog1.FileName.ToString());
                }
                else
                {
                    tbl.DataTable dt = connect.readdata(str);
                    ExportToExcel(dt, saveFileDialog1.FileName.ToString());
                }
                
            }
        }

        private void cbwarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddata("select top 100  namewarehouse,cargo.partno,partname,productiontime,stoptime,remark,qty,idlocation from productionhistory inner join cargo on productionhistory.partno=cargo.partno inner join warehouse on productionhistory.idwarehouse=warehouse.idwarehouse where warehouse.idwarehouse ='"+cbwarehouse.SelectedValue.ToString()+"' and idlocation ='L1'");        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void btndata_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {

                workbook.SaveAs(saveFileDialog2.FileName.ToString(), Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            // save the application  

            // Exit from the application  
            app.Quit();  
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cblocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddata("select top 100  namewarehouse,cargo.partno,partname,productiontime,stoptime,remark,qty,idlocation from productionhistory inner join cargo on productionhistory.partno=cargo.partno inner join warehouse on productionhistory.idwarehouse=warehouse.idwarehouse where warehouse.idwarehouse ='"+cbwarehouse.SelectedValue.ToString()+"' and idlocation ='"+cblocation.SelectedValue.ToString()+"'");
        }
    }
}
