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
    }
}
