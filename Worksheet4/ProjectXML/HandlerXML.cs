using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace ProjectXML
{
    class HandlerXML
    {
        public HandlerXML(string xmlFile)
        {
            XmlFilePath = xmlFile;
        }

        public HandlerXML(string xmlFile, string xsdFile)
        {
            XmlFilePath = xmlFile;
            XsdFilePath = xsdFile;
        }

        public string XmlFilePath { get; set; }
        public string XsdFilePath { get; set; }

        private bool isValid = true;
        private string validationMessage;
        public string ValidationMessage
        {
            get { return validationMessage; }
        }

        //**********************************************
        // Ex. 7
        //**********************************************
        public List<string> GetTitles()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XmlFilePath);

            List<String> titles = new List<string>();

            XmlNodeList nodeList = doc.SelectNodes("/bookstore/book/title");

            foreach (XmlNode node in nodeList)
            {
                titles.Add(node.InnerText);
            }

            return titles;
        }
        //**********************************************
        // Ex. 8
        //**********************************************       
        public bool UpdateAuthorByTitle(string title, string author)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XmlFilePath);

            XmlNode node = doc.SelectSingleNode($"/bookstore/book[title='{title}']/author");
            if (node != null)
            {
                node.InnerText = author;
                doc.Save(XmlFilePath);

                return true;
            }
            return false;
        }

        //**********************************************
        // Ex. 9
        //**********************************************  
        public void AddRateToBook(string title, string rate)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XmlFilePath);

            XmlNode node = doc.SelectSingleNode($"/bookstore/book[title='{title}']");

            if(node["rate"] == null)
            {
                XmlElement tagRate = doc.CreateElement("rate");
                tagRate.InnerText = rate;
                node.AppendChild(tagRate);
            }
            else
            {
                node["rate"].InnerText = rate;
            }

            doc.Save(XmlFilePath);
        }
        //**********************************************
        // Ex. 10 Add Attribute
        //**********************************************  
        public void AddAttributeISBNToBook(string title, string isbn)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XmlFilePath);

            XmlNode node = doc.SelectSingleNode($"/bookstore/book[title='{title}']");
            XmlAttribute attribute = doc.CreateAttribute("ISBN");

            attribute.Value = isbn;
            node.Attributes.Append(attribute);
            doc.Save(XmlFilePath);
        }

        #region Ex. 6 - Validate XML with XML Schema (xsd)
        public bool ValidateXML()
        {
            isValid = true;
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(XmlFilePath);
                ValidationEventHandler eventHandler = new ValidationEventHandler(MyValidateMethod);
                doc.Schemas.Add(null, XsdFilePath);
                doc.Validate(eventHandler);
            }
            catch (XmlException ex)
            {
                isValid = false;
                validationMessage = string.Format("ERROR: {0}", ex.ToString());
            }
            return isValid;
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
        #endregion
    }
}
