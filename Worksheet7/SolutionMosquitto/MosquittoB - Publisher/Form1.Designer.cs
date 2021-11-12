
namespace MosquittoB___Publisher
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
            this.buttonPublish = new System.Windows.Forms.Button();
            this.textBoxTopic = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.textBoxBrokerDomain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Topic";
            // 
            // buttonPublish
            // 
            this.buttonPublish.BackColor = System.Drawing.Color.Gold;
            this.buttonPublish.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonPublish.Location = new System.Drawing.Point(204, 54);
            this.buttonPublish.Name = "buttonPublish";
            this.buttonPublish.Size = new System.Drawing.Size(163, 23);
            this.buttonPublish.TabIndex = 2;
            this.buttonPublish.Text = "Publish";
            this.buttonPublish.UseVisualStyleBackColor = false;
            this.buttonPublish.Click += new System.EventHandler(this.buttonPublish_Click);
            // 
            // textBoxTopic
            // 
            this.textBoxTopic.Location = new System.Drawing.Point(98, 57);
            this.textBoxTopic.Name = "textBoxTopic";
            this.textBoxTopic.Size = new System.Drawing.Size(100, 20);
            this.textBoxTopic.TabIndex = 4;
            this.textBoxTopic.Text = "news";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(12, 115);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(355, 191);
            this.textBoxMessage.TabIndex = 5;
            // 
            // textBoxBrokerDomain
            // 
            this.textBoxBrokerDomain.Location = new System.Drawing.Point(98, 27);
            this.textBoxBrokerDomain.Name = "textBoxBrokerDomain";
            this.textBoxBrokerDomain.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrokerDomain.TabIndex = 7;
            this.textBoxBrokerDomain.Text = "127.0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Broker Domain:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Message";
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonConnect.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonConnect.Location = new System.Drawing.Point(204, 25);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(163, 23);
            this.buttonConnect.TabIndex = 9;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 318);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBrokerDomain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBoxTopic);
            this.Controls.Add(this.buttonPublish);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MosquittoB - Publisher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPublish;
        private System.Windows.Forms.TextBox textBoxTopic;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.TextBox textBoxBrokerDomain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConnect;
    }
}

