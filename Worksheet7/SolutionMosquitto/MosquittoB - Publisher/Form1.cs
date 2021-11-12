using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;

namespace MosquittoB___Publisher
{
    public partial class Form1 : Form
    {
        MqttClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            client = new MqttClient(textBoxBrokerDomain.Text);
            client.Connect(Guid.NewGuid().ToString());

            if (!client.IsConnected)
            {
                MessageBox.Show("Broker unavailable.");
                return;
            }

            buttonConnect.Enabled = false;
        }

        private void buttonPublish_Click(object sender, EventArgs e)
        {
            client.Publish(textBoxTopic.Text, Encoding.UTF8.GetBytes(textBoxMessage.Text));
        }

        private void Form1_closing(object sender, FormClosingEventArgs e)
        {
            if(client.IsConnected)
            {
                client.Disconnect();
            }
        }
    }
}
