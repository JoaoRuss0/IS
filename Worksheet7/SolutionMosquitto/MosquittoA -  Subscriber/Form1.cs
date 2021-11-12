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

namespace MosquittoA____Subscriber
{
    public partial class Form1 : Form
    {
        MqttClient client = null;
        String[] topics = { "news", "complaints"};
        byte[] qos = { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonConnectAndSubscribe_Click(object sender, EventArgs e)
        {
            client = new MqttClient(textBoxBrokerDomain.Text);
            client.Connect(Guid.NewGuid().ToString());
            client.Subscribe(topics, qos);

            client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
        }

        private void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                richTextBoxMessages.AppendText($"'{e.Topic}': " + Encoding.UTF8.GetString(e.Message) + Environment.NewLine);
            });
        }

        private void buttonUnsubscribeAllTopics_Click(object sender, EventArgs e)
        {
            if(client.IsConnected)
            {
                client.Unsubscribe(topics);
            }
        }

        private void Form1_closing(object sender, FormClosingEventArgs e)
        {
            if(client.IsConnected)
            {
                client.Unsubscribe(topics);
                client.Disconnect();
            }
        }
    }
}
