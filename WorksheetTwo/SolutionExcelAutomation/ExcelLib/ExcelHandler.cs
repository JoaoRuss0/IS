using System;
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelLib
{
    public class ExcelHandler
    {
        private static String _basePath = "C:\\Users\\r0u6s\\Documents\\Classes\\IS\\Practical\\WorksheetTwo\\";

        public static void CreateNewExcelFile(string filename)
        {
            var application = new Excel.Application();
            
            //Simply shows the excel window, not really needed.
            //excelApplication.Visible = true;

            var workbook = application.Workbooks.Add();

            workbook.SaveAs(_basePath + filename, AccessMode: Excel.XlSaveAsAccessMode.xlNoChange);
            workbook.Close();
            application.Quit();

            MyReleaseCOMObjects(application);
            MyReleaseCOMObjects(workbook);

            GC.Collect();
        }

        private static void MyReleaseCOMObjects(Object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception e)
            {

            }
        }

        public static void WriteToExcelFile(string filename)
        {
            Excel.Application application = new Excel.Application();
            //application.Visible = true;

            Excel.Workbook workbook = application.Workbooks.Open(_basePath + filename);
            Excel.Worksheet worksheet = workbook.Worksheets.get_Item(1);

            worksheet.Cells[1, 1].Value = "Worksheet";
            worksheet.Cells[1, 2].Value = "one!";

            try
            {
                worksheet = workbook.Worksheets.get_Item(2);
            }
            catch
            {
                worksheet = workbook.Worksheets.Add(After: worksheet);
            }

            worksheet.Cells[1, 1].Value = "Worksheet";
            worksheet.Cells[1, 2].Value = "two!";

            workbook.Save();
            workbook.Close();
            application.Quit();

            MyReleaseCOMObjects(application);
            MyReleaseCOMObjects(workbook);
            MyReleaseCOMObjects(worksheet);

            GC.Collect();
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

            MyReleaseCOMObjects(application);
            MyReleaseCOMObjects(workbook);
            MyReleaseCOMObjects(worksheet);

            GC.Collect();

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

            for (int i = 1; i <= 4; i++)
            {
                worksheet.Cells[i, 2].Value = 10 * i;
            }

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
            
            MyReleaseCOMObjects(application);
            MyReleaseCOMObjects(workbook);
            MyReleaseCOMObjects(worksheet);
            MyReleaseCOMObjects(range);
            MyReleaseCOMObjects(chart);
            MyReleaseCOMObjects(charts);
            MyReleaseCOMObjects(chartObject);

            GC.Collect();
        }

        public static string[,] ReadNByMcells(int height, int width, string filename)
        {
            Excel.Application application = new Excel.Application();
            Excel.Workbook workbook = application.Workbooks.Open(_basePath + filename);
            Excel.Worksheet worksheet = workbook.Worksheets.get_Item(1);

            string[,] readCells = new string[height, width];

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    readCells[i - 1, j - 1] = (worksheet.Cells[i, j].Value != null) ? worksheet.Cells[i, j].Value.ToString() : "";
                }
            }

            workbook.Close();
            application.Quit();

            MyReleaseCOMObjects(application);
            MyReleaseCOMObjects(workbook);
            MyReleaseCOMObjects(worksheet);

            GC.Collect();

            return readCells;
        }

        public static string[,] ReadRange(string filename, string start, string end)
        {
            Excel.Application application = new Excel.Application();
            Excel.Workbook workbook = application.Workbooks.Open(_basePath + filename);
            Excel.Worksheet worksheet = workbook.Worksheets.get_Item(1);

            //https://stackoverflow.com/a/2627368
            Excel.Range range = worksheet.get_Range(start, end);
            System.Array values = range.Cells.Value;
            string[,] stringValues = ConvertRangeValuesToString(values);

            workbook.Close();
            application.Quit();

            MyReleaseCOMObjects(application);
            MyReleaseCOMObjects(workbook);
            MyReleaseCOMObjects(worksheet);
            MyReleaseCOMObjects(range);

            GC.Collect();

            return stringValues;
        }

        private static string[,] ConvertRangeValuesToString(System.Array values)
        {
            int height = values.GetLength(0);
            int width = values.GetLength(1);

            string[,] stringValues = new string[height, width];

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    var value = values.GetValue(i, j);

                    if (value == null)
                    {
                        stringValues[i - 1, j - 1] = "";
                        continue;
                    }

                    stringValues[i - 1, j - 1] = value.ToString();
                }
            }

            return stringValues;
        }

        public static string ReadFromXWorksheet(string filename, int worksheetIndex)
        {
            Excel.Application application = new Excel.Application();
            Excel.Workbook workbook = application.Workbooks.Open(_basePath + filename);
            Excel.Worksheet worksheet = null;

            string content = "";

            try
            {
                worksheet = workbook.Worksheets.get_Item(worksheetIndex);

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

                for (int i = 0; i < row; i++)
                {
                    content += "| ";

                    for (int j = 0; j < col; j++)
                    {
                        content += worksheet.Cells[i + 1, j + 1].value + " | ";
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

            MyReleaseCOMObjects(application);
            MyReleaseCOMObjects(workbook);
            MyReleaseCOMObjects(worksheet);

            GC.Collect();

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

            MyReleaseCOMObjects(application);
            MyReleaseCOMObjects(workbook);
            MyReleaseCOMObjects(worksheet);

            GC.Collect();
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

            MyReleaseCOMObjects(application);
            MyReleaseCOMObjects(workbook);
            MyReleaseCOMObjects(worksheet);

            GC.Collect();

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

            MyReleaseCOMObjects(application);
            MyReleaseCOMObjects(workbook);
            MyReleaseCOMObjects(worksheet);

            GC.Collect();

            return count;
        }
    }
}
