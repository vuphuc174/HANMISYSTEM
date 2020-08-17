using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using tbl= System.Data;
using HANMISYSTEM.Module;

namespace HANMISYSTEM
{
    public partial class ioform : Form
    {
        public ioform()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private const int pagesize = 20;
        public int pagenumber=1;
        string sql;
        private void ioform_Load(object sender, EventArgs e)
        {
           /* tbl.DataTable dt = connect.readdata("select idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber from ioview");
            try
            {
                dataGridView1.DataSource = dt;
            }
            catch
            {

            }
            cbfilter.SelectedIndex = 0;
            * */

        }
        private void loaddata(string sql)
        {
            tbl.DataTable dt = connect.readdata(sql);
            try
            {
                dataGridView1.DataSource = dt;
            }
            catch(Exception e)
            {
                MessageBox.Show(""+e.ToString());
            }
        }
        private void cbwarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbwarehouse.Text != "")
            {
                panel1.Visible = true;
                cbfilter.Enabled = true;
                txtidpack.Text = "";
                txtpagenumber.Text = "1";
                sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='"+cbwarehouse.SelectedValue.ToString()+"' or idcustomer ='"+cbwarehouse.SelectedValue.ToString()+"') a where r>=1 and r<=20";
                loaddata(sql);
            }
        }

        private void cbwarehouse_Click(object sender, EventArgs e)
        {
            tbl.DataTable dt = connect.readdata("select * from warehouse");
            if (dt != null)
            {
                cbwarehouse.DataSource = dt;
                cbwarehouse.DisplayMember = "namewarehouse";
                cbwarehouse.ValueMember = "idwarehouse";
            }
        }

        private void txtidpack_TextChanged(object sender, EventArgs e)
        {
            txtpagenumber.Text = "1";
            if (txtidpack.Text == "")
            {
                switch (cbfilter.Text)
                {
                    case "ALL":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";
                        break;
                    case "IN":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";
                        break;
                    case "OUT":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";
                        break;
                    default:
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";

                        break;
                }
            }
            else
            {
                switch (cbfilter.Text)
                {
                    case "ALL":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";
                        break;
                    case "IN":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";
                        break;
                    case "OUT":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";
                        break;
                    default:
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";

                        break;
                }
            }
            loaddata(sql);
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
               
                tbl.DataTable dt = connect.readdata("select * from ioview");
                ExportToExcel(dt,saveFileDialog1.FileName.ToString());
            }
            
        }
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
            throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"+ ex.Message);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditInvoice fr = new EditInvoice();
            if (e.RowIndex > -1 && e.ColumnIndex != 0)
            {
                fr.lbinvoice.Text= dataGridView1.Rows[e.RowIndex].Cells["idinvoice"].Value.ToString();
                fr.txtcarno.Text = dataGridView1.Rows[e.RowIndex].Cells["carnumber"].Value.ToString();
                
                tbl.DataTable dt = connect.readdata("select distinct idpack,partno,quantity from ioview where idslipout='"+dataGridView1.Rows[e.RowIndex].Cells["idinvoice"].Value.ToString()+"'");
                fr.dataGridView1.DataSource=dt;
                
                fr.ShowDialog();
            }
            else
            {

            }
        }

        private void cbfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbwarehouse.SelectedIndex==-1 || cbwarehouse.SelectedItem==null)
            {
                sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "') a where r>=1 and r<=20";
                loaddata(sql);
            }
            else
            {
                txtpagenumber.Text = "1";
                if(cbfilter.Text=="ALL")
                {
                   if(txtidpack.Text=="")
                   {
                       sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "') a where r>=1 and r<=20";
                       loaddata(sql);
                   }
                   else
                   {
                       sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a where r>=1 and r<20";
                       loaddata(sql);
                   } 
                }
                else if(cbfilter.Text=="IN")
                {
                    if(txtidpack.Text=="")
                    {
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "') a where r>=1 and r<20";
                        loaddata(sql);
                    }
                    else
                    {
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where  idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "' and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a where r>=1 and r<=20";
                        loaddata(sql);
                    }
                    
                }
                else
                {
                    if (txtidpack.Text == "")
                    {
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "') a where r>=1 and r<=20";
                        loaddata(sql);
                    }
                    else
                    {
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a where r>=1 and r<=20";
                        loaddata(sql);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            pagenumber = Convert.ToInt32(txtpagenumber.Text) + 1;
            txtpagenumber.Text = pagenumber.ToString();
            if (txtidpack.Text == "")
            {
                switch (cbfilter.Text)
                {
                    case "ALL":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";
                        break;
                    case "IN":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";
                        break;
                    case "OUT":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";
                        break;
                    default:
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";

                        break;
                }
            }
            else
            {
                switch (cbfilter.Text)
                {
                    case "ALL":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "'   and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";
                        break;
                    case "IN":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";
                        break;
                    case "OUT":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";
                        break;
                    default:
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "'   and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a where r>=(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";

                        break;
                }
            }
            loaddata(sql);
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            pagenumber = 1;
            txtpagenumber.Text = pagenumber.ToString();
            if(txtidpack.Text=="")
            {
                switch(cbfilter.Text)
                {
                    case "ALL" :
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' or idcustomer='" + cbwarehouse.SelectedValue.ToString() + "') a where r>=1 and r<=20";
                        loaddata(sql);
                        break;
                    case "IN" :
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "') a where r>=1 and r<20";
                        loaddata(sql);
                        break;
                    case "OUT" :
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "') a where r>=1 and r<20";
                        loaddata(sql);
                        break;
                    default:
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' or idcustomer='" + cbwarehouse.SelectedValue.ToString() + "') a where r>=1 and r<=20";
                        loaddata(sql);
                        break;
                }
            }
            else
            {
                switch (cbfilter.Text)
                {
                    case "ALL":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a where r>=1 and r<20";
                        loaddata(sql);
                        break;
                    case "IN":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "'   and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a where r>=1 and r<=20";
                        loaddata(sql);
                        break;
                    case "OUT":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "'   and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a where r>=1 and r<=20";
                        loaddata(sql);
                        break;
                    default:
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a where r>=1 and r<20";
                        loaddata(sql);
                        break;
                }
            }
            
        }
        string cmd;
        private void btnend_Click(object sender, EventArgs e)
        {
            
            if (txtidpack.Text == "")
            {
                switch (cbfilter.Text)
                {
                    case "ALL":
                        cmd = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "') a order by r desc";
                        break;
                    case "IN":
                        cmd = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where  idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "') a order by r desc";
                        break;
                    case "OUT":
                        cmd = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' ) a order by r desc";
                        break;
                    default:
                        cmd = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "') a order by r desc";

                        break;
                }
            }
            else
            {
                switch (cbfilter.Text)
                {
                    case "ALL":
                        cmd = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a order by r desc";
                        break;
                    case "IN":
                        cmd = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where  idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a order by r desc";
                        break;
                    case "OUT":
                        cmd = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a order by r desc";
                        break;
                    default:
                        cmd = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a order by r desc";
                        break;
                }
            }
            tbl.DataTable dtcheckmaxpage = connect.readdata(cmd);
            if(dtcheckmaxpage.Rows.Count>0)
            {
                if (Convert.ToDouble(Convert.ToInt32(dtcheckmaxpage.Rows[0]["r"].ToString()) % pagesize)>0)
                {
                    pagenumber = Convert.ToInt32(dtcheckmaxpage.Rows[0]["r"].ToString()) / pagesize + 1;
                }
                else
                {
                    pagenumber = Convert.ToInt32(dtcheckmaxpage.Rows[0]["r"].ToString()) / pagesize;
                }
            }
            txtpagenumber.Text=pagenumber.ToString();
            if (txtidpack.Text == "")
            {
                switch (cbfilter.Text)
                {
                    case "ALL":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "') a where r>(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";
                        break;
                    case "IN":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "') a where r>(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";
                        break;
                    case "OUT":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "') a where r>(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";
                        break;
                    default:
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "') a where r>(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";
                        
                        break;
                }
            }
            else
            {
                switch (cbfilter.Text)
                {
                    case "ALL":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "'   and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a where r>(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";
                        break;
                    case "IN":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a where r>(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";
                        break;
                    case "OUT":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a where r>(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";
                        break;
                    default:
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "'   and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a where r>(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";

                        break;
                }
            }
            loaddata(sql);
        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            pagenumber = Convert.ToInt32(txtpagenumber.Text) - 1;
            txtpagenumber.Text = pagenumber.ToString();
            if (txtidpack.Text == "")
            {
                switch (cbfilter.Text)
                {
                    case "ALL":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "') a where r>(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";
                        break;
                    case "IN":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "') a where r>(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";
                        break;
                    case "OUT":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "') a where r>(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";
                        break;
                    default:
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "') a where r>(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";

                        break;
                }
            }
            else
            {
                switch (cbfilter.Text)
                {
                    case "ALL":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a where r>(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";
                        break;
                    case "IN":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a where r>(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";
                        break;
                    case "OUT":
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a where r>(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";
                        break;
                    default:
                        sql = "select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "'  and idpack like '%" + txtidpack.Text + "%' or partno like '%" + txtidpack.Text + "%') a where r>(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)";

                        break;
                }
            }
            loaddata(sql);
        }
        Isnumber _isnumber = new Isnumber();
        private void txtpagenumber_Validated(object sender, EventArgs e)
        {
            if (txtpagenumber.Text == "" ||  _isnumber.IsNumber(txtpagenumber.Text) == false)
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

        private void txtpagenumber_TextChanged(object sender, EventArgs e)
        {
            if (_isnumber.IsNumber(txtpagenumber.Text) == true)
            {

                if (Convert.ToInt32(txtpagenumber.Text) <= 0)
                {
                    txtpagenumber.Text = "1";
                    loaddata("select a.* from (select ROW_NUMBER() over(order by dateout desc) as r,idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber   from ioview where idwarehouse ='" + cbwarehouse.SelectedValue.ToString() + "' or idcustomer ='" + cbwarehouse.SelectedValue.ToString() + "') a where r>(((" + pagenumber + "-1)*" + pagesize + ") +1) and r<(" + pagenumber + " * " + pagesize + "+1)");
                }
            }
        }
    }     
}
