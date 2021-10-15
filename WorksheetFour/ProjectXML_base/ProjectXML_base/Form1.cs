﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ProjectXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEx5_Click(object sender, EventArgs e)
        {
            CreateXML();
        }

        public string CreateXML()
        {
            XmlDocument doc = new XmlDocument();
            // Create the XML Declaration, and append it to XML document
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);
            doc.AppendChild(dec);
            // Create the root element
            XmlElement root = doc.CreateElement("bookstore");
            doc.AppendChild(root);
            // Create Books
            // Note that to set the text inside the element,
            // you use .InnerText
            // You use SetAttribute to set attribute
            root.AppendChild(createBook(doc, "CHILDREN", "Harry Poter", "J K. Rowling", "2005", "29.99"));
            root.AppendChild(createBook(doc, "WEB", "Learning XML", "Erik t. Ray", "2003", "39.95"));

            doc.Save(@"sample.xml");
            //string xmlOutput = doc.OuterXml;
            return doc.OuterXml;
            //return doc.InnerXml;
        }

        public XmlElement createBook(XmlDocument doc, string cat, string t, string au, string y, string p)
        {
            XmlElement book = doc.CreateElement("book");
            book.SetAttribute("category", cat);
            XmlElement title = doc.CreateElement("title");
            title.InnerText = t;
            XmlElement author = doc.CreateElement("author");
            author.InnerText = au;
            XmlElement year = doc.CreateElement("year");
            year.InnerText = y;
            XmlElement price = doc.CreateElement("price");
            price.InnerText = p;
            book.AppendChild(title);
            book.AppendChild(author);
            book.AppendChild(year);
            book.AppendChild(price);
            return book;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "xml files (*.xml)|*.xml";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxXmlFile.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Schema files (*.xsd)|*.xsd";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxXsdFile.Text = openFileDialog1.FileName;
            }
        }

        private void buttonEx6_Click(object sender, EventArgs e)
        {
            HandlerXML handler = new HandlerXML(textBoxXmlFile.Text, textBoxXsdFile.Text);
            bool valid = handler.ValidateXML();

            if(valid)
            {
                MessageBox.Show("Valid!" + Environment.NewLine + handler.ValidationMessage);
            }
            else
            {
                MessageBox.Show("Invalid." + Environment.NewLine + handler.ValidationMessage);
            }
        }

        private void buttonEx7_Click(object sender, EventArgs e)
        {
            HandlerXML handler = new HandlerXML(textBoxXmlFile.Text, textBoxXsdFile.Text);
            listBoxBookTitles.DataSource = handler.GetTitles();
        }

        private void listBoxBookTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSelectedTitle.Text = listBoxBookTitles.SelectedItem.ToString();
        }

        private void buttonEx8_Click(object sender, EventArgs e)
        {
            HandlerXML handler = new HandlerXML(textBoxXmlFile.Text, textBoxXsdFile.Text);

            string newAuthorName = textBoxNewAuthorName.Text;
            string title = labelSelectedTitle.Text;
            if (newAuthorName != "" && title != "<Selected book title>")
            {

                if(handler.UpdateAuthorByTitle(title, newAuthorName))
                {
                    MessageBox.Show("Updated!");
                }
                else
                {
                    MessageBox.Show($"Could not find book where title = {title}.");
                }
            }
            else
            {
                MessageBox.Show("No new author name or book title selected!");
            }
        }
    }
}
