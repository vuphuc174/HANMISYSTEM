using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tbl = System.Data;
using System.IO;

namespace HANMISYSTEM.Module
{
    class ExportToExcel
    {
        public void ExportToExcelFunction(tbl.DataTable dataTable, string ExcelFilePath)
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
                if (ExcelFilePath != null && ExcelFilePath != "" && File.Exists(ExcelFilePath)==false && Directory.Exists(ExcelFilePath)==false )
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

        internal void ExportToExcelFunction(tbl.DataTable dt, string[] p)
        {
            throw new NotImplementedException();
        }

        internal void ExportToExcelFunction()
        {
            throw new NotImplementedException();
        }
    }
}
