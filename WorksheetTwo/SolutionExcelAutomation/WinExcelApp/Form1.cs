using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelLib;

namespace WinExcelApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NewExcelButton_Click(object sender, EventArgs e)
        {
            ExcelHandler.CreateNewExcelFile("NewExcelFile");
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            ExcelHandler.WriteToExcelFile("NewExcelFile");
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            TextBoxDisabled.Text = ExcelHandler.ReadFromExcelFile("NewExcelFile");
        }

        private void NewChartButton_Click(object sender, EventArgs e)
        {
            ExcelHandler.CreateExcelChart("NewExcelFile");
        }

        private void ReadNByMButton_Click(object sender, EventArgs e)
        {
            string[,] readCells = ExcelHandler.ReadNByMcells(20, 20, "NewExcelFile");

            for (int i = 1; i <= 20; i++)
            {
                TextBoxDisabled.Text += "| ";

                for (int j = 1; j <= 20; j++)
                {
                    TextBoxDisabled.Text += readCells[i - 1, j - 1] + " | ";
                }

                TextBoxDisabled.Text += Environment.NewLine;
            }
        }

        private void ReadXWorksheetButton_Click(object sender, EventArgs e)
        {
            TextBoxDisabled.Text = ExcelHandler.ReadFromXWorksheet("NewExcelFile", Convert.ToInt32(NumericUpDownWorksheetIndex.Value));
        }

        private void WriteDataToWorkbookButton_Click(object sender, EventArgs e)
        {
            ExcelHandler.WriteDataToWorkbook("NewExcelFile", TextBoxData.Text);
        }

        private void CountUsedLinesButton_Click(object sender, EventArgs e)
        {
            TextBoxDisabled.Text =  "Lines being used: " + ExcelHandler.CountLinesWithData("NewExcelFile").ToString();
        }

        private void FindStringButton_Click(object sender, EventArgs e)
        {
            TextBoxDisabled.Text = "String '"
                + TestBoxStringToFind.Text
                + "' was found "
                + ExcelHandler.CountOccurencesInWorksheet("NewExcelFile", TestBoxStringToFind.Text)
                + " times.";
        } 
    }
}
