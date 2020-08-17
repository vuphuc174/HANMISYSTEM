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
    public partial class Report_Detail : Form
    {

        Dbconnect connect = new Dbconnect();
        public Report_Detail()
        {
            InitializeComponent();
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
            if(id!=-1)
            {
                ioform fr = new ioform();
                fr.cbwarehouse.Text = lbwarehouse.Text;
                fr.dataGridView1.DataSource = connect.readdata("select idslipout,idpack,partno,quantity,fromwarehouse,towarehouse,dateout,carnumber from ioview where fromwarehouse='" + lbwarehouse.Text + "' and day(dateout)='" + dataGridView1.Rows[id].Cells["date"].Value.ToString() + "' and month(dateout) ='" + lbmonth.Text + "' or towarehouse='" + lbwarehouse.Text + "' and day(dateout)='" + dataGridView1.Rows[id].Cells["date"].Value.ToString() + "' and month(dateout) ='" + lbmonth.Text + "' ");
                fr.FormBorderStyle = FormBorderStyle.Sizable;
                fr.ShowDialog();
            }
        }
        string result;
        private string replacenull(string s)
        {
            if(string.IsNullOrEmpty(s)==true)
            {
                result = "0";
            }
            return result;
        }
        private void btnexcel_Click(object sender, EventArgs e)
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
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                workbook.SaveAs(saveFileDialog1.FileName.ToString(), Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            // save the application  

            // Exit from the application  
            app.Quit();  
        }

    }
}
