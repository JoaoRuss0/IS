using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public static void CreateExcelChart(string filename)
        {
            Excel.Application application = new Excel.Application();
            Excel.Workbook workbook = application.Workbooks.Open(_basePath + filename);
            Excel.Worksheet worksheet = workbook.Worksheets.get_Item(1);

            Excel.Chart chart = null;
            Excel.ChartObjects charts = worksheet.ChartObjects();
            Excel.ChartObject chartObject = charts.Add(50, 50, 300, 300);
            chart = chartObject.Chart;

            Excel.Range range = worksheet.get_Range("B1:B4");
            chart.SetSourceData(range);

            chart.ChartType = Excel.XlChartType.xlLine;
            chart.ChartWizard(
                Source: range,
                Title: "Graph Title",
                CategoryTitle: "Title of X axis",
                ValueTitle: "Title of Y axis"
                );

            workbook.Save();
            workbook.Close();
            application.Quit();

            ReleaseCOMObjects(application, workbook);
        }

        public static string[,] ReadNByMcells(int height, int width, string filename)
        {
            Excel.Application application = new Excel.Application();
            Excel.Workbook workbook = application.Workbooks.Open(_basePath + filename);
            Excel.Worksheet worksheet = workbook.Worksheets.get_Item(1);

            string[,] readCells = new string[height, width];

            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= height; j++)
                {
                    readCells[i - 1, j - 1] = worksheet.Cells[i, j].Value;
                }
            }

            workbook.Close();
            application.Quit();

            ReleaseCOMObjects(application, workbook);
            
            return readCells;
        }

        public static string ReadFromXWorksheet(string filename, int worksheetIndex)
        {
            Excel.Application application = new Excel.Application();
            Excel.Workbook workbook = application.Workbooks.Open(_basePath + filename);

            string content = "";

            try
            {
                Excel.Worksheet worksheet = workbook.Worksheets.get_Item(worksheetIndex);

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        content += worksheet.Cells[i + 1, j + 1].value + " ";
                    }

                    content += Environment.NewLine;
                }
            }
            catch
            {
                content = "Could not open worksheet " + worksheetIndex + "!";
            }

            workbook.Close();
            application.Quit();

            ReleaseCOMObjects(application, workbook);

            return content;
        }

        public static void WriteDataToWorkbook(string filename, string data)
        {
            Excel.Application application = new Excel.Application();
            Excel.Workbook workbook = application.Workbooks.Open(_basePath + filename);
            Excel.Worksheet worksheet = (Excel.Worksheet) workbook.ActiveSheet;

            worksheet.Cells[1, 1] = data;

            workbook.Save();
            workbook.Close();
            application.Quit();

            ReleaseCOMObjects(application, workbook);
        }

        public static int CountLinesWithData(string filename)
        {
            Excel.Application application = new Excel.Application();
            Excel.Workbook workbook = application.Workbooks.Open(_basePath + filename);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;

            // https://stackoverflow.com/a/22152292
            // Detect Last used Row - Ignore cells that contains formulas that result in blank values
            int row = worksheet.Cells.Find(
                            "*",
                            System.Reflection.Missing.Value,
                            Excel.XlFindLookIn.xlValues,
                            Excel.XlLookAt.xlWhole,
                            Excel.XlSearchOrder.xlByRows,
                            Excel.XlSearchDirection.xlPrevious,
                            false,
                            System.Reflection.Missing.Value,
                            System.Reflection.Missing.Value).Row;

            // Detect Last Used Column  - Ignore cells that contains formulas that result in blank values
            int col = worksheet.Cells.Find(
                            "*",
                            System.Reflection.Missing.Value,
                            System.Reflection.Missing.Value,
                            System.Reflection.Missing.Value,
                            Excel.XlSearchOrder.xlByColumns,
                            Excel.XlSearchDirection.xlPrevious,
                            false,
                            System.Reflection.Missing.Value,
                            System.Reflection.Missing.Value).Column;

            int count = 0;

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    if(worksheet.Cells[i, j].Value != null)
                    {
                        count++;
                        break;
                    }
                }
            }

            workbook.Close();
            application.Quit();

            ReleaseCOMObjects(application, workbook);

            return count;
        }

        public static int CountOccurencesInWorksheet(string filename, string stringToFind)
        {
            Excel.Application application = new Excel.Application();
            Excel.Workbook workbook = application.Workbooks.Open(_basePath + filename);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;

            int row = worksheet.Cells.Find(
                            "*",
                            System.Reflection.Missing.Value,
                            Excel.XlFindLookIn.xlValues,
                            Excel.XlLookAt.xlWhole,
                            Excel.XlSearchOrder.xlByRows,
                            Excel.XlSearchDirection.xlPrevious,
                            false,
                            System.Reflection.Missing.Value,
                            System.Reflection.Missing.Value).Row;

            int col = worksheet.Cells.Find(
                            "*",
                            System.Reflection.Missing.Value,
                            System.Reflection.Missing.Value,
                            System.Reflection.Missing.Value,
                            Excel.XlSearchOrder.xlByColumns,
                            Excel.XlSearchDirection.xlPrevious,
                            false,
                            System.Reflection.Missing.Value,
                            System.Reflection.Missing.Value).Column;

            int count = 0;

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    var value = worksheet.Cells[i, j].Value;

                    if (value != null && value.ToString().Contains(stringToFind))
                    {
                        count += new Regex(Regex.Escape(stringToFind)).Matches(value.ToString()).Count;
                        break;
                    }
                }
            }

            workbook.Close();
            application.Quit();

            ReleaseCOMObjects(application, workbook);

            return count;
        }
    }
}
