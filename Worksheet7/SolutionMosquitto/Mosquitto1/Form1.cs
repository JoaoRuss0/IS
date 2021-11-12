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
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Mosquitto1
{
    public partial class Form1 : Form
    {
        MqttClient client = new MqttClient("127.0.0.1");
        string[] topics = { "news", "complaints" };

        public Form1()
        {
            InitializeComponent();

            comboBoxTopics.DataSource = topics;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client.Connect(Guid.NewGuid().ToString());

            if(!client.IsConnected)
            {
                MessageBox.Show("Message Broker not available.");
                return;
            }

            client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;

            byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE };

            client.Subscribe(topics, qosLevels);
        }

        private void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            MessageBox.Show($"'{e.Topic}': {Encoding.UTF8.GetString(e.Message)}");
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            if(client.IsConnected)
            {
                client.Unsubscribe(topics);
                client.Disconnect();
            }
        }

        private void publish(object sender, EventArgs e)
        {
            if(client.IsConnected)
            {
                client.Publish(comboBoxTopics.SelectedItem.ToString(), Encoding.UTF8.GetBytes(textBoxMessage.Text));
            }
        }

        private void buttonUnsubscribeFromAllTopics_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                client.Unsubscribe(topics);
            }
        }
    }
}
