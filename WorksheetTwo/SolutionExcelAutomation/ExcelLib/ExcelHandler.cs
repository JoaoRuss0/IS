using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelLib
{
    public class ExcelHandler
    {
        private static String _basePath = "o:\\Classes\\IS\\Practical\\WorksheetTwo\\";

        public static void CreateNewExcelFile(string filename)
        {
            var application = new Excel.Application();
            
            //Simply shows the excel window, not really needed.
            //excelApplication.Visible = true;

            var workbook = application.Workbooks.Add();

            workbook.SaveAs(_basePath + filename, AccessMode: Excel.XlSaveAsAccessMode.xlNoChange);
            workbook.Close();
            application.Quit();

            ReleaseCOMObjects(application, workbook);
        }

        public static void ReleaseCOMObjects(Excel.Application application, Excel.Workbook workbook)
        {
            application = null;
            workbook = null;

            GC.Collect();
        }

        public static void WriteToExcelFile(string filename)
        {
            Excel.Application application = new Excel.Application();
            //application.Visible = true;

            Excel.Workbook workbook = application.Workbooks.Open(_basePath + filename);
            Excel.Worksheet worksheet1 = workbook.Worksheets.get_Item(1);

            worksheet1.Cells[1, 1].Value = "Worksheet";
            worksheet1.Cells[1, 2].Value = "one!";

            Excel.Worksheet worksheet2;

            try
            {
                worksheet2 = workbook.Worksheets.get_Item(2);
            }
            catch
            {
                worksheet2 = workbook.Worksheets.Add(After: worksheet1);
            }

            worksheet2.Cells[1, 1].Value = "Worksheet";
            worksheet2.Cells[1, 2].Value = "two!";

            workbook.Save();
            workbook.Close();
            application.Quit();

            ReleaseCOMObjects(application, workbook);
        }

        public static string ReadFromExcelFile(string filename)
        {
            var application = new Excel.Application();
            //application.Visible = true;

            var workbook = application.Workbooks.Open(_basePath + filename);
            var worksheet = (Excel.Worksheet) workbook.ActiveSheet;

            string content = "";

            try
            {
                int i = 1;

                while(true)
                {
                    worksheet = workbook.Worksheets.get_Item(i);

                    content += worksheet.Cells[1, 1].Value;
                    content += " " + (worksheet.Cells[1, 2] as Excel.Range).Text;
                    content += Environment.NewLine;

                    i++;
                }
            }
            catch { }

            workbook.Close();
            application.Quit();

            ReleaseCOMObjects(application, workbook);

            return content;
        }
    }
}
