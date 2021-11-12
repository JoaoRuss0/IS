
namespace MosquittoA____Subscriber
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBrokerDomain = new System.Windows.Forms.TextBox();
            this.buttonConnectAndSubscribe = new System.Windows.Forms.Button();
            this.buttonUnsubscribeAllTopics = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxMessages = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broker Domain:";
            // 
            // textBoxBrokerDomain
            // 
            this.textBoxBrokerDomain.Location = new System.Drawing.Point(98, 29);
            this.textBoxBrokerDomain.Name = "textBoxBrokerDomain";
            this.textBoxBrokerDomain.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrokerDomain.TabIndex = 1;
            this.textBoxBrokerDomain.Text = "127.0.0.1";
            // 
            // buttonConnectAndSubscribe
            // 
            this.buttonConnectAndSubscribe.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonConnectAndSubscribe.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonConnectAndSubscribe.Location = new System.Drawing.Point(12, 65);
            this.buttonConnectAndSubscribe.Name = "buttonConnectAndSubscribe";
            this.buttonConnectAndSubscribe.Size = new System.Drawing.Size(176, 23);
            this.buttonConnectAndSubscribe.TabIndex = 2;
            this.buttonConnectAndSubscribe.Text = "Connect and Subscribe";
            this.buttonConnectAndSubscribe.UseVisualStyleBackColor = false;
            this.buttonConnectAndSubscribe.Click += new System.EventHandler(this.buttonConnectAndSubscribe_Click);
            // 
            // buttonUnsubscribeAllTopics
            // 
            this.buttonUnsubscribeAllTopics.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonUnsubscribeAllTopics.ForeColor = System.Drawing.Color.Maroon;
            this.buttonUnsubscribeAllTopics.Location = new System.Drawing.Point(191, 65);
            this.buttonUnsubscribeAllTopics.Name = "buttonUnsubscribeAllTopics";
            this.buttonUnsubscribeAllTopics.Size = new System.Drawing.Size(176, 23);
            this.buttonUnsubscribeAllTopics.TabIndex = 3;
            this.buttonUnsubscribeAllTopics.Text = "Unsubscribe all topics";
            this.buttonUnsubscribeAllTopics.UseVisualStyleBackColor = false;
            this.buttonUnsubscribeAllTopics.Click += new System.EventHandler(this.buttonUnsubscribeAllTopics_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Messages";
            // 
            // richTextBoxMessages
            // 
            this.richTextBoxMessages.Enabled = false;
            this.richTextBoxMessages.Location = new System.Drawing.Point(12, 118);
            this.richTextBoxMessages.Name = "richTextBoxMessages";
            this.richTextBoxMessages.Size = new System.Drawing.Size(355, 320);
            this.richTextBoxMessages.TabIndex = 5;
            this.richTextBoxMessages.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.richTextBoxMessages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonUnsubscribeAllTopics);
            this.Controls.Add(this.buttonConnectAndSubscribe);
            this.Controls.Add(this.textBoxBrokerDomain);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MosquittoA - Subscriber";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBrokerDomain;
        private System.Windows.Forms.Button buttonConnectAndSubscribe;
        private System.Windows.Forms.Button buttonUnsubscribeAllTopics;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxMessages;
    }
}

