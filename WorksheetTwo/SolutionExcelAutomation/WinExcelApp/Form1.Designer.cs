
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
            this.NewChartButton = new System.Windows.Forms.Button();
            this.ReadNByMButton = new System.Windows.Forms.Button();
            this.ReadXWorksheetButton = new System.Windows.Forms.Button();
            this.NumericUpDownWorksheetIndex = new System.Windows.Forms.NumericUpDown();
            this.TextBoxData = new System.Windows.Forms.TextBox();
            this.WriteDataToWorkbookButton = new System.Windows.Forms.Button();
            this.CountUsedLinesButton = new System.Windows.Forms.Button();
            this.TestBoxStringToFind = new System.Windows.Forms.TextBox();
            this.FindStringButton = new System.Windows.Forms.Button();
            this.TextBoxFilename = new System.Windows.Forms.TextBox();
            this.NumericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.LabelHeight = new System.Windows.Forms.Label();
            this.LabelWidth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownWorksheetIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // NewExcelButton
            // 
            this.NewExcelButton.AccessibleDescription = "";
            this.NewExcelButton.AccessibleName = "NewExcelButton";
            this.NewExcelButton.Location = new System.Drawing.Point(330, 45);
            this.NewExcelButton.Name = "NewExcelButton";
            this.NewExcelButton.Size = new System.Drawing.Size(126, 25);
            this.NewExcelButton.TabIndex = 0;
            this.NewExcelButton.Text = "New Excel";
            this.NewExcelButton.UseVisualStyleBackColor = true;
            this.NewExcelButton.Click += new System.EventHandler(this.NewExcelButton_Click);
            // 
            // TextBoxDisabled
            // 
            this.TextBoxDisabled.AccessibleName = "TextBoxDisabled";
            this.TextBoxDisabled.Enabled = false;
            this.TextBoxDisabled.Location = new System.Drawing.Point(12, 12);
            this.TextBoxDisabled.Multiline = true;
            this.TextBoxDisabled.Name = "TextBoxDisabled";
            this.TextBoxDisabled.Size = new System.Drawing.Size(300, 333);
            this.TextBoxDisabled.TabIndex = 2;
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(330, 164);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(126, 25);
            this.ReadButton.TabIndex = 3;
            this.ReadButton.Text = "Read";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // WriteButton
            // 
            this.WriteButton.Location = new System.Drawing.Point(330, 133);
            this.WriteButton.Name = "WriteButton";
            this.WriteButton.Size = new System.Drawing.Size(126, 25);
            this.WriteButton.TabIndex = 4;
            this.WriteButton.Text = "Write";
            this.WriteButton.UseVisualStyleBackColor = true;
            this.WriteButton.Click += new System.EventHandler(this.WriteButton_Click);
            // 
            // NewChartButton
            // 
            this.NewChartButton.Location = new System.Drawing.Point(330, 195);
            this.NewChartButton.Name = "NewChartButton";
            this.NewChartButton.Size = new System.Drawing.Size(126, 25);
            this.NewChartButton.TabIndex = 5;
            this.NewChartButton.Text = "New Chart";
            this.NewChartButton.UseVisualStyleBackColor = true;
            this.NewChartButton.Click += new System.EventHandler(this.NewChartButton_Click);
            // 
            // ReadNByMButton
            // 
            this.ReadNByMButton.Location = new System.Drawing.Point(494, 226);
            this.ReadNByMButton.Name = "ReadNByMButton";
            this.ReadNByMButton.Size = new System.Drawing.Size(126, 25);
            this.ReadNByMButton.TabIndex = 6;
            this.ReadNByMButton.Text = "Read NxM";
            this.ReadNByMButton.UseVisualStyleBackColor = true;
            this.ReadNByMButton.Click += new System.EventHandler(this.ReadNByMButton_Click);
            // 
            // ReadXWorksheetButton
            // 
            this.ReadXWorksheetButton.Location = new System.Drawing.Point(494, 45);
            this.ReadXWorksheetButton.Name = "ReadXWorksheetButton";
            this.ReadXWorksheetButton.Size = new System.Drawing.Size(126, 25);
            this.ReadXWorksheetButton.TabIndex = 7;
            this.ReadXWorksheetButton.Text = "Read Worksheet";
            this.ReadXWorksheetButton.UseVisualStyleBackColor = true;
            this.ReadXWorksheetButton.Click += new System.EventHandler(this.ReadXWorksheetButton_Click);
            // 
            // NumericUpDownWorksheetIndex
            // 
            this.NumericUpDownWorksheetIndex.Location = new System.Drawing.Point(494, 13);
            this.NumericUpDownWorksheetIndex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownWorksheetIndex.Name = "NumericUpDownWorksheetIndex";
            this.NumericUpDownWorksheetIndex.Size = new System.Drawing.Size(126, 20);
            this.NumericUpDownWorksheetIndex.TabIndex = 9;
            this.NumericUpDownWorksheetIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TextBoxData
            // 
            this.TextBoxData.Location = new System.Drawing.Point(492, 100);
            this.TextBoxData.Multiline = true;
            this.TextBoxData.Name = "TextBoxData";
            this.TextBoxData.Size = new System.Drawing.Size(126, 27);
            this.TextBoxData.TabIndex = 10;
            // 
            // WriteDataToWorkbookButton
            // 
            this.WriteDataToWorkbookButton.Location = new System.Drawing.Point(492, 133);
            this.WriteDataToWorkbookButton.Name = "WriteDataToWorkbookButton";
            this.WriteDataToWorkbookButton.Size = new System.Drawing.Size(126, 25);
            this.WriteDataToWorkbookButton.TabIndex = 11;
            this.WriteDataToWorkbookButton.Text = "Write to Workbook";
            this.WriteDataToWorkbookButton.UseVisualStyleBackColor = true;
            this.WriteDataToWorkbookButton.Click += new System.EventHandler(this.WriteDataToWorkbookButton_Click);
            // 
            // CountUsedLinesButton
            // 
            this.CountUsedLinesButton.Location = new System.Drawing.Point(330, 226);
            this.CountUsedLinesButton.Name = "CountUsedLinesButton";
            this.CountUsedLinesButton.Size = new System.Drawing.Size(126, 25);
            this.CountUsedLinesButton.TabIndex = 12;
            this.CountUsedLinesButton.Text = "Count Used Lines";
            this.CountUsedLinesButton.UseVisualStyleBackColor = true;
            this.CountUsedLinesButton.Click += new System.EventHandler(this.CountUsedLinesButton_Click);
            // 
            // TestBoxStringToFind
            // 
            this.TestBoxStringToFind.Location = new System.Drawing.Point(494, 287);
            this.TestBoxStringToFind.Multiline = true;
            this.TestBoxStringToFind.Name = "TestBoxStringToFind";
            this.TestBoxStringToFind.Size = new System.Drawing.Size(126, 27);
            this.TestBoxStringToFind.TabIndex = 13;
            // 
            // FindStringButton
            // 
            this.FindStringButton.Location = new System.Drawing.Point(494, 320);
            this.FindStringButton.Name = "FindStringButton";
            this.FindStringButton.Size = new System.Drawing.Size(126, 25);
            this.FindStringButton.TabIndex = 14;
            this.FindStringButton.Text = "Find in Worksheet";
            this.FindStringButton.UseVisualStyleBackColor = true;
            this.FindStringButton.Click += new System.EventHandler(this.FindStringButton_Click);
            // 
            // TextBoxFilename
            // 
            this.TextBoxFilename.Location = new System.Drawing.Point(330, 12);
            this.TextBoxFilename.Multiline = true;
            this.TextBoxFilename.Name = "TextBoxFilename";
            this.TextBoxFilename.Size = new System.Drawing.Size(126, 27);
            this.TextBoxFilename.TabIndex = 15;
            this.TextBoxFilename.Text = "NewExcelFile";
            // 
            // NumericUpDownHeight
            // 
            this.NumericUpDownHeight.Location = new System.Drawing.Point(494, 200);
            this.NumericUpDownHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownHeight.Name = "NumericUpDownHeight";
            this.NumericUpDownHeight.Size = new System.Drawing.Size(58, 20);
            this.NumericUpDownHeight.TabIndex = 16;
            this.NumericUpDownHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericUpDownWidth
            // 
            this.NumericUpDownWidth.Location = new System.Drawing.Point(562, 200);
            this.NumericUpDownWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownWidth.Name = "NumericUpDownWidth";
            this.NumericUpDownWidth.Size = new System.Drawing.Size(58, 20);
            this.NumericUpDownWidth.TabIndex = 17;
            this.NumericUpDownWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LabelHeight
            // 
            this.LabelHeight.AutoSize = true;
            this.LabelHeight.Location = new System.Drawing.Point(491, 184);
            this.LabelHeight.Name = "LabelHeight";
            this.LabelHeight.Size = new System.Drawing.Size(41, 13);
            this.LabelHeight.TabIndex = 18;
            this.LabelHeight.Text = "Height:";
            // 
            // LabelWidth
            // 
            this.LabelWidth.AutoSize = true;
            this.LabelWidth.Location = new System.Drawing.Point(559, 184);
            this.LabelWidth.Name = "LabelWidth";
            this.LabelWidth.Size = new System.Drawing.Size(38, 13);
            this.LabelWidth.TabIndex = 19;
            this.LabelWidth.Text = "Width:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 357);
            this.Controls.Add(this.LabelWidth);
            this.Controls.Add(this.LabelHeight);
            this.Controls.Add(this.NumericUpDownWidth);
            this.Controls.Add(this.NumericUpDownHeight);
            this.Controls.Add(this.TextBoxFilename);
            this.Controls.Add(this.FindStringButton);
            this.Controls.Add(this.TestBoxStringToFind);
            this.Controls.Add(this.CountUsedLinesButton);
            this.Controls.Add(this.WriteDataToWorkbookButton);
            this.Controls.Add(this.TextBoxData);
            this.Controls.Add(this.NumericUpDownWorksheetIndex);
            this.Controls.Add(this.ReadXWorksheetButton);
            this.Controls.Add(this.ReadNByMButton);
            this.Controls.Add(this.NewChartButton);
            this.Controls.Add(this.WriteButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.TextBoxDisabled);
            this.Controls.Add(this.NewExcelButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownWorksheetIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewExcelButton;
        private System.Windows.Forms.TextBox TextBoxDisabled;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button WriteButton;
        private System.Windows.Forms.Button NewChartButton;
        private System.Windows.Forms.Button ReadNByMButton;
        private System.Windows.Forms.Button ReadXWorksheetButton;
        private System.Windows.Forms.NumericUpDown NumericUpDownWorksheetIndex;
        private System.Windows.Forms.TextBox TextBoxData;
        private System.Windows.Forms.Button WriteDataToWorkbookButton;
        private System.Windows.Forms.Button CountUsedLinesButton;
        private System.Windows.Forms.TextBox TestBoxStringToFind;
        private System.Windows.Forms.Button FindStringButton;
        private System.Windows.Forms.TextBox TextBoxFilename;
        private System.Windows.Forms.NumericUpDown NumericUpDownHeight;
        private System.Windows.Forms.NumericUpDown NumericUpDownWidth;
        private System.Windows.Forms.Label LabelHeight;
        private System.Windows.Forms.Label LabelWidth;
    }
}

