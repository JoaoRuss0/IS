
namespace WinExcelApp
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
            this.NewExcelButton = new System.Windows.Forms.Button();
            this.TextBoxDisabled = new System.Windows.Forms.TextBox();
            this.ReadButton = new System.Windows.Forms.Button();
            this.WriteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewExcelButton
            // 
            this.NewExcelButton.AccessibleDescription = "";
            this.NewExcelButton.AccessibleName = "NewExcelButton";
            this.NewExcelButton.Location = new System.Drawing.Point(204, 12);
            this.NewExcelButton.Name = "NewExcelButton";
            this.NewExcelButton.Size = new System.Drawing.Size(75, 33);
            this.NewExcelButton.TabIndex = 0;
            this.NewExcelButton.Text = "New Excel";
            this.NewExcelButton.UseVisualStyleBackColor = true;
            this.NewExcelButton.Click += new System.EventHandler(this.NewExcelButton_Click);
            // 
            // TextBoxDisabled
            // 
            this.TextBoxDisabled.AccessibleName = "TextBoxDisabled";
            this.TextBoxDisabled.Enabled = false;
            this.TextBoxDisabled.Location = new System.Drawing.Point(3, 12);
            this.TextBoxDisabled.Multiline = true;
            this.TextBoxDisabled.Name = "TextBoxDisabled";
            this.TextBoxDisabled.Size = new System.Drawing.Size(195, 113);
            this.TextBoxDisabled.TabIndex = 2;
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(204, 92);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(75, 33);
            this.ReadButton.TabIndex = 3;
            this.ReadButton.Text = "Read";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // WriteButton
            // 
            this.WriteButton.Location = new System.Drawing.Point(204, 51);
            this.WriteButton.Name = "WriteButton";
            this.WriteButton.Size = new System.Drawing.Size(75, 35);
            this.WriteButton.TabIndex = 4;
            this.WriteButton.Text = "Write";
            this.WriteButton.UseVisualStyleBackColor = true;
            this.WriteButton.Click += new System.EventHandler(this.WriteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 137);
            this.Controls.Add(this.WriteButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.TextBoxDisabled);
            this.Controls.Add(this.NewExcelButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewExcelButton;
        private System.Windows.Forms.TextBox TextBoxDisabled;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button WriteButton;
    }
}

