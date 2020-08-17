using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace HANMISYSTEM
{
    public partial class Printing_Slipout : Form
    {
        public Printing_Slipout()
        {
            InitializeComponent();
        }

        private PrintDocument printdoc1 = new PrintDocument();
        PrintPreviewDialog previewdlg = new PrintPreviewDialog();
        Panel pannel = null;

        Bitmap MemoryImage;
        public void GetPrintArea(Panel pnl)
        {
            printdoc1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new System.Drawing.Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (MemoryImage != null)
            {
                e.Graphics.DrawImage(MemoryImage, 0, 0);
                base.OnPaint(e);
            }
        }
        void printdoc1_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
        }
        public void Print(Panel pnl)
        {
            pannel = pnl;
            GetPrintArea(pnl);
            previewdlg.Document = printdoc1;
            previewdlg.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lbiwarehouse.Text!="LGE")
            {
                int count = 1;
                string tempPath = System.IO.Path.GetTempFileName();

                System.IO.File.WriteAllBytes(tempPath, Properties.Resources.deliveryorder);

                Microsoft.Office.Interop.Excel.Application excelApplication = new Microsoft.Office.Interop.Excel.Application();
                Workbook excelWorkbook;
                Worksheet xlWorkSheet;
                excelWorkbook = excelApplication.Workbooks.Open(tempPath);
                xlWorkSheet = excelWorkbook.Worksheets["VC"];
                xlWorkSheet.Cells[10, 1] = "Số xe (Car Number) :" + lbcarnumber.Text;
                xlWorkSheet.Cells[10, 4] = "Tên lái xe (Driver's name) :" + lbdriver.Text;
                xlWorkSheet.Cells[5, 3] = lbewarehouse.Text;
                xlWorkSheet.Cells[6, 3] = lbiwarehouse.Text;

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    xlWorkSheet.Cells[i + 12, 1] = count;
                    xlWorkSheet.Cells[i + 12, 2] = dataGridView1.Rows[i].Cells["partname"].Value.ToString();
                    xlWorkSheet.Cells[i + 12, 3] = dataGridView1.Rows[i].Cells["partno"].Value.ToString();
                    xlWorkSheet.Cells[i + 12, 4] = (dataGridView1.Rows[i].Cells["dvt"].Value == null) ? "EA" : dataGridView1.Rows[i].Cells["dvt"].Value.ToString();
                    xlWorkSheet.Cells[i + 12, 5] = dataGridView1.Rows[i].Cells["qty"].Value.ToString();
                    xlWorkSheet.Cells[i + 12, 6] = (dataGridView1.Rows[i].Cells["remark"].Value == null) ? "" : dataGridView1.Rows[i].Cells["remark"].Value.ToString();
                    count++;
                }
                excelApplication.Visible = true; // true will open Excel
                excelWorkbook.PrintPreview();
                excelApplication.Visible = false; // hides excel file when user closes preview
            }
            else
            {
                int count = 1;
                string tempPath = System.IO.Path.GetTempFileName();

                System.IO.File.WriteAllBytes(tempPath, Properties.Resources.deliveryform);

                Microsoft.Office.Interop.Excel.Application excelApplication = new Microsoft.Office.Interop.Excel.Application();
                Workbook excelWorkbook;
                Worksheet xlWorkSheet;
                excelWorkbook = excelApplication.Workbooks.Open(tempPath);
                xlWorkSheet = excelWorkbook.Worksheets["VC"];
                xlWorkSheet.Cells[10, 1] = "Số xe (Car Number) :" + lbcarnumber.Text;
                xlWorkSheet.Cells[10, 4] = "Tên lái xe (Driver's name) :" + lbdriver.Text;


                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    xlWorkSheet.Cells[i + 12, 1] = count;
                    xlWorkSheet.Cells[i + 12, 2] = dataGridView1.Rows[i].Cells["partname"].Value.ToString();
                    xlWorkSheet.Cells[i + 12, 3] = dataGridView1.Rows[i].Cells["partno"].Value.ToString();
                    xlWorkSheet.Cells[i + 12, 4] = (dataGridView1.Rows[i].Cells["dvt"].Value == null) ? "EA" : dataGridView1.Rows[i].Cells["dvt"].Value.ToString();
                    xlWorkSheet.Cells[i + 12, 5] = dataGridView1.Rows[i].Cells["qty"].Value.ToString();
                    xlWorkSheet.Cells[i + 12, 6] = (dataGridView1.Rows[i].Cells["remark"].Value == null) ? "" : dataGridView1.Rows[i].Cells["remark"].Value.ToString();
                    count++;
                }
                excelApplication.Visible = true; // true will open Excel
                excelWorkbook.PrintPreview();
                excelApplication.Visible = false; // hides excel file when user closes preview
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}