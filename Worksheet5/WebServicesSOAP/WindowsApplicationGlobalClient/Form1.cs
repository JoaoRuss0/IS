using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApplicationGlobalClient.ServiceReferenceHolidays;

namespace WindowsApplicationGlobalClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDownYear.Value = DateTime.Today.Year;
        }

        private void buttonGetService_Click(object sender, EventArgs e)
        {
            HolidaySoapClient service = new HolidaySoapClient();

            Holiday[] holidays = service.GetAllHolidays(Convert.ToInt32(numericUpDownYear.Value));

            foreach(Holiday h in holidays)
            {
                string info = $"{h.Date.ToShortDateString()} : {h.Name}\t{h.Type}";
                listBox.Items.Add(info);
            }
        }
    }
}
