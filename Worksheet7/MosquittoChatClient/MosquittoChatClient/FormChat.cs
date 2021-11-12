﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Xml;
using System.Xml.Schema;

namespace MosquittoChatClient
{
    public partial class FormChat : Form
    {
        private bool isValid = true;
        private string validationMessage;
        private string XsdFilePath = "chat.xsd";

        const String STR_CHANNEL_NAME = "users";

        //MqttClient m_cClient = new MqttClient(IPAddress.Parse("192.168.237.155"));
        MqttClient m_cClient = new MqttClient("127.0.0.1");
        string[] m_strTopicsInfo = { STR_CHANNEL_NAME };

        public FormChat()
        {
            InitializeComponent();
        }

        //Remember that this method/callback is called by thread from (mosquitto client middleware). It is not the GUI thread!
        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            //Console.WriteLine("Received = " + Encoding.UTF8.GetString(e.Message) + " on topic " + e.Topic);            
            //EXTRACT FIELDS
            String strTemp = Encoding.UTF8.GetString(e.Message);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(strTemp);

            try
            {
                ValidationEventHandler eventHandler = new ValidationEventHandler(MyValidateMethod);
                doc.Schemas.Add(null, XsdFilePath);
                doc.Validate(eventHandler);
            }
            catch (XmlException ex)
            {
                isValid = false;
                validationMessage = string.Format("ERROR: {0}", ex.ToString());
            }

            if (!isValid)
            {
                MessageBox.Show("Invalid!");
                return;
            }

            XmlNode node = doc.SelectSingleNode("/chat/avatar");

            //RECOVER AVATAR IMG
            Bitmap btmAvatar = ImageHandler.Base64StringToImage(node.InnerText);
            
            //PACK INFO
            string[] arr = new string[4];
            ListViewItem itm;
            arr[0] = node.InnerText; //avatar
            arr[1] = doc.SelectSingleNode("/chat/nickname").InnerText; //nickname
            arr[2] = doc.SelectSingleNode("/chat/classroom").InnerText; //Classroom
            arr[3] = doc.SelectSingleNode("/chat/message").InnerText; //Message
            itm = new ListViewItem(arr);

            //INSERT INTO DATALISTVIEW
            dataGridView.BeginInvoke((MethodInvoker)delegate { dataGridView.Rows.Add(btmAvatar, arr[1], arr[2], arr[3]); }); 
        }

        private void MyValidateMethod(object sender, ValidationEventArgs args)
        {
            isValid = false;
            switch (args.Severity)
            {
                case XmlSeverityType.Error:
                    validationMessage = string.Format("ERROR: {0}", args.Message);
                    break;
                case XmlSeverityType.Warning:
                    validationMessage = string.Format("WARNING: {0}", args.Message);
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView.Columns.Clear();
            
            //First column is bitmap type!            
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn(); imgCol.Name = "nic"; imgCol.HeaderText = "Avatar";
            dataGridView.Columns.Add(imgCol);
            //Next columns are text type
            dataGridView.Columns.Add("nic", "Nickname");
            dataGridView.Columns.Add("cl", "Classroom");
            dataGridView.Columns.Add("msg", "Message");

            //Just to...
            textBoxNickName.Text = "user1";
            textBoxClassRoom.Text = "ESTG-LSI";
            textBoxAvatarLoc.Text = Application.StartupPath +  @"\icon_blue.png";
            
            m_cClient.Connect(Guid.NewGuid().ToString());
            if (!m_cClient.IsConnected)
            {
                MessageBox.Show("Error connecting to message broker...");
                return;
            }

            //Subscribe chat channel
            m_cClient.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

            byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE};//QoS
            m_cClient.Subscribe(m_strTopicsInfo, qosLevels);

            if (m_cClient.IsConnected)
                lblStatus.Text = "Connected";
            else
                lblStatus.Text = "Disconnected";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_cClient.IsConnected)
            {
                m_cClient.Unsubscribe(m_strTopicsInfo); //Put this in a button to see notif!
                m_cClient.Disconnect(); //Free process and process's resources
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!m_cClient.IsConnected)
            {
                MessageBox.Show("Application is disconnected");
                return;
            }

            if (!ValidateUserInfo())
            {
                MessageBox.Show("Invalid User Info");
                return;
            }

            String strNickName = textBoxNickName.Text;
            String strClassRoom = textBoxClassRoom.Text;
            String strAvatar = ImageHandler.ImageToBase64String(textBoxAvatarLoc.Text);

            String strMsg = textBoxMsgToSend.Text;
            if (strMsg.Trim().Length <= 0)
            {
                MessageBox.Show("Invalid message");
                return;
            }

            String strMsgToSend = createXMLString(strNickName, strClassRoom, strAvatar, strMsg);

            m_cClient.Publish(STR_CHANNEL_NAME, Encoding.UTF8.GetBytes(strMsgToSend));

            textBoxMsgToSend.Text="";
            textBoxMsgToSend.Focus();
        }

        private String createXMLString(String strNickName, String strClassRoom, String strAvatar, String strMsg)
        {
            XmlDocument doc = new XmlDocument();

            XmlElement root = doc.CreateElement("chat");
            doc.AppendChild(root);

            XmlElement nickname = doc.CreateElement("nickname");
            nickname.InnerText = strNickName;

            XmlElement classroom = doc.CreateElement("classroom");
            classroom.InnerText = strClassRoom;

            XmlElement avatar = doc.CreateElement("avatar");
            avatar.InnerText = strAvatar;

            XmlElement message = doc.CreateElement("message");
            message.InnerText = strMsg;

            root.AppendChild(nickname);
            root.AppendChild(classroom);
            root.AppendChild(avatar);
            root.AppendChild(message);

            return doc.OuterXml;
        }

        private Boolean ValidateUserInfo()
        {
            String strTemp = textBoxNickName.Text;
            if (strTemp.Trim().Length <= 0)
            {
                return false;
            }
            strTemp = textBoxClassRoom.Text;
            if (strTemp.Trim().Length <= 0)
            {
                return false;
            }
            strTemp = textBoxAvatarLoc.Text;
            if (strTemp.Trim().Length <= 0)
            {
                return false;
            }
            if (!File.Exists(strTemp))
            {
                return false;
            }
            
            return true;
        }
    }
}
