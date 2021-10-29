
namespace ClientBookstoreCreate
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
            this.buttonGetBooks = new System.Windows.Forms.Button();
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxFilterCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonFilterCategory = new System.Windows.Forms.Button();
            this.textBoxFilterTitle = new System.Windows.Forms.TextBox();
            this.buttonFilterTitle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGetBooks
            // 
            this.buttonGetBooks.Location = new System.Drawing.Point(12, 12);
            this.buttonGetBooks.Name = "buttonGetBooks";
            this.buttonGetBooks.Size = new System.Drawing.Size(75, 23);
            this.buttonGetBooks.TabIndex = 0;
            this.buttonGetBooks.Text = "Get Books";
            this.buttonGetBooks.UseVisualStyleBackColor = true;
            this.buttonGetBooks.Click += new System.EventHandler(this.buttonGetBooks_Click);
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.Location = new System.Drawing.Point(12, 41);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(439, 212);
            this.listBoxBooks.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCategory);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDownPrice);
            this.groupBox1.Controls.Add(this.numericUpDownYear);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonAddBook);
            this.groupBox1.Controls.Add(this.textBoxAuthor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxTitle);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Location = new System.Drawing.Point(13, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 178);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book info";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(394, 135);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(132, 21);
            this.comboBoxCategory.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Category";
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Location = new System.Drawing.Point(227, 138);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownPrice.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(81, 20);
            this.numericUpDownPrice.TabIndex = 16;
            this.numericUpDownPrice.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(80, 138);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(81, 20);
            this.numericUpDownYear.TabIndex = 15;
            this.numericUpDownYear.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Author";
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(587, 135);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(75, 23);
            this.buttonAddBook.TabIndex = 9;
            this.buttonAddBook.Text = "Add Book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(80, 88);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(446, 20);
            this.textBoxAuthor.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(80, 39);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(446, 20);
            this.textBoxTitle.TabIndex = 3;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(587, 86);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(587, 37);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxFilterCategory);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.buttonFilterCategory);
            this.groupBox2.Controls.Add(this.textBoxFilterTitle);
            this.groupBox2.Controls.Add(this.buttonFilterTitle);
            this.groupBox2.Location = new System.Drawing.Point(457, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 213);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // comboBoxFilterCategory
            // 
            this.comboBoxFilterCategory.FormattingEnabled = true;
            this.comboBoxFilterCategory.Location = new System.Drawing.Point(22, 65);
            this.comboBoxFilterCategory.Name = "comboBoxFilterCategory";
            this.comboBoxFilterCategory.Size = new System.Drawing.Size(124, 21);
            this.comboBoxFilterCategory.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Category";
            // 
            // buttonFilterCategory
            // 
            this.buttonFilterCategory.Location = new System.Drawing.Point(152, 64);
            this.buttonFilterCategory.Name = "buttonFilterCategory";
            this.buttonFilterCategory.Size = new System.Drawing.Size(75, 23);
            this.buttonFilterCategory.TabIndex = 2;
            this.buttonFilterCategory.Text = "Filter";
            this.buttonFilterCategory.UseVisualStyleBackColor = true;
            this.buttonFilterCategory.Click += new System.EventHandler(this.buttonFilterCategory_Click);
            // 
            // textBoxFilterTitle
            // 
            this.textBoxFilterTitle.Location = new System.Drawing.Point(22, 139);
            this.textBoxFilterTitle.Name = "textBoxFilterTitle";
            this.textBoxFilterTitle.Size = new System.Drawing.Size(124, 20);
            this.textBoxFilterTitle.TabIndex = 1;
            // 
            // buttonFilterTitle
            // 
            this.buttonFilterTitle.Location = new System.Drawing.Point(152, 137);
            this.buttonFilterTitle.Name = "buttonFilterTitle";
            this.buttonFilterTitle.Size = new System.Drawing.Size(75, 23);
            this.buttonFilterTitle.TabIndex = 0;
            this.buttonFilterTitle.Text = "Filter";
            this.buttonFilterTitle.UseVisualStyleBackColor = true;
            this.buttonFilterTitle.Click += new System.EventHandler(this.buttonFilterTitle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxBooks);
            this.Controls.Add(this.buttonGetBooks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGetBooks;
        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonFilterCategory;
        private System.Windows.Forms.TextBox textBoxFilterTitle;
        private System.Windows.Forms.Button buttonFilterTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxFilterCategory;
    }
}

