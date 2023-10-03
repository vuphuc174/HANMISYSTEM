using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Common
{
    internal class ExcelHelper
    {
        public static void ExportDataTableToExcel(DataTable dataTable)
        {
            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                // Write the column names to the worksheet
                int columnIndex = 1;
                foreach (DataColumn column in dataTable.Columns)
                {
                    worksheet.Cells[1, columnIndex].Value = column.ColumnName;
                    columnIndex++;
                }

                // Write the data rows to the worksheet
                int rowIndex = 2;
                foreach (DataRow row in dataTable.Rows)
                {
                    columnIndex = 1;
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        worksheet.Cells[rowIndex, columnIndex].Value = row[column];
                        columnIndex++;
                    }
                    rowIndex++;
                }

                // Save the Excel package to a memorystream
                using (MemoryStream stream = new MemoryStream())
                {
                    package.SaveAs(stream);
                    stream.Position = 0;

                    // Prompt the user to save the file
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Save Excel File";
                    saveFileDialog.FileName = "DataExport.xlsx";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                        {
                            stream.WriteTo(fileStream);
                        }
                    }
                }
            }
        }
    }
}
