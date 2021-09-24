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
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void NewExcelButton_Click(object sender, EventArgs e)
        {
            ExcelHandler.CreateNewExcelFile(TextBoxFilename.Text.ToString());

            MessageBox.Show($"New excel file '{TextBoxFilename.Text}' was created.");
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            ExcelHandler.WriteToExcelFile(TextBoxFilename.Text.ToString());

            MessageBox.Show($"Wrote to '{TextBoxFilename.Text}'.");
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            TextBoxDisabled.Text = ExcelHandler.ReadFromExcelFile(TextBoxFilename.Text.ToString());
        }

        private void NewChartButton_Click(object sender, EventArgs e)
        {
            ExcelHandler.CreateExcelChart(TextBoxFilename.Text.ToString());
        }

        private void ReadNByMButton_Click(object sender, EventArgs e)
        {
            int height = Convert.ToInt32(NumericUpDownHeight.Value);
            int width = Convert.ToInt32(NumericUpDownWidth.Value);

            string[,] readCells = ExcelHandler.ReadNByMcells(height, width, TextBoxFilename.Text.ToString());

            TextBoxDisabled.Text = "";

            for (int i = 1; i <= height; i++)
            {
                TextBoxDisabled.Text += "| ";

                for (int j = 1; j <= width; j++)
                {
                    TextBoxDisabled.Text += readCells[i - 1, j - 1] + " | ";
                }

                TextBoxDisabled.Text += Environment.NewLine;
            }
        }

        private void ReadXWorksheetButton_Click(object sender, EventArgs e)
        {
            TextBoxDisabled.Text = ExcelHandler.ReadFromXWorksheet(TextBoxFilename.Text.ToString(), Convert.ToInt32(NumericUpDownWorksheetIndex.Value));
        }

        private void WriteDataToWorkbookButton_Click(object sender, EventArgs e)
        {
            ExcelHandler.WriteDataToWorkbook(TextBoxFilename.Text.ToString(), TextBoxData.Text);
        }

        private void CountUsedLinesButton_Click(object sender, EventArgs e)
        {
            TextBoxDisabled.Text =  "Lines being used: " + ExcelHandler.CountLinesWithData(TextBoxFilename.Text.ToString()).ToString();
        }

        private void FindStringButton_Click(object sender, EventArgs e)
        {
            TextBoxDisabled.Text = "String '"
                + TestBoxStringToFind.Text
                + "' was found "
                + ExcelHandler.CountOccurencesInWorksheet(TextBoxFilename.Text.ToString(), TestBoxStringToFind.Text)
                + " times.";
        }

        private void ButtonReadRange_Click(object sender, EventArgs e)
        {
            string[,] readCells = ExcelHandler.ReadRange(TextBoxFilename.Text.ToString(), TextBoxStart.Text, TextBoxEnd.Text);

            int height = readCells.GetLength(0);
            int width = readCells.GetLength(1);

            TextBoxDisabled.Text = "";

            for (int i = 1; i <= height; i++)
            {
                TextBoxDisabled.Text += "| ";

                for (int j = 1; j <= width; j++)
                {
                    TextBoxDisabled.Text += readCells[i - 1, j - 1] + " | ";
                }

                TextBoxDisabled.Text += Environment.NewLine;
            }
        }
    }
}
