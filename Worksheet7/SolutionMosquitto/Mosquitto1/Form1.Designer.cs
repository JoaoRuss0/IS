
namespace Mosquitto1
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
            this.buttonPublish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTopics = new System.Windows.Forms.ComboBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonUnsubscribeFromAllTopics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPublish
            // 
            this.buttonPublish.BackColor = System.Drawing.Color.LightGreen;
            this.buttonPublish.ForeColor = System.Drawing.Color.Green;
            this.buttonPublish.Location = new System.Drawing.Point(250, 34);
            this.buttonPublish.Name = "buttonPublish";
            this.buttonPublish.Size = new System.Drawing.Size(75, 23);
            this.buttonPublish.TabIndex = 0;
            this.buttonPublish.Text = "Publish";
            this.buttonPublish.UseVisualStyleBackColor = false;
            this.buttonPublish.Click += new System.EventHandler(this.publish);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Topic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message";
            // 
            // comboBoxTopics
            // 
            this.comboBoxTopics.FormattingEnabled = true;
            this.comboBoxTopics.Location = new System.Drawing.Point(65, 36);
            this.comboBoxTopics.Name = "comboBoxTopics";
            this.comboBoxTopics.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTopics.TabIndex = 3;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(65, 87);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(260, 84);
            this.textBoxMessage.TabIndex = 4;
            // 
            // buttonUnsubscribeFromAllTopics
            // 
            this.buttonUnsubscribeFromAllTopics.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonUnsubscribeFromAllTopics.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonUnsubscribeFromAllTopics.Location = new System.Drawing.Point(65, 188);
            this.buttonUnsubscribeFromAllTopics.Name = "buttonUnsubscribeFromAllTopics";
            this.buttonUnsubscribeFromAllTopics.Size = new System.Drawing.Size(260, 23);
            this.buttonUnsubscribeFromAllTopics.TabIndex = 5;
            this.buttonUnsubscribeFromAllTopics.Text = "Unsubscribe from all topics";
            this.buttonUnsubscribeFromAllTopics.UseVisualStyleBackColor = false;
            this.buttonUnsubscribeFromAllTopics.Click += new System.EventHandler(this.buttonUnsubscribeFromAllTopics_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 223);
            this.Controls.Add(this.buttonUnsubscribeFromAllTopics);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.comboBoxTopics);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPublish);
            this.Name = "Form1";
            this.Text = "Mosquitto1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPublish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTopics;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonUnsubscribeFromAllTopics;
    }
}

