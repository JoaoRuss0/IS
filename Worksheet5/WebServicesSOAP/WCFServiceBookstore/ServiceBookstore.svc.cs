using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace WCFServiceBookstore
{
    public class ServiceBookstore : IServiceBookstore
    {
        string FILEPATH = AppDomain.CurrentDomain.BaseDirectory + @"App_data\bookstore.xml";

        public XmlElement createBook(XmlDocument doc, Book newBook)
        {
            XmlElement book = doc.CreateElement("book");
            book.SetAttribute("category", newBook.Category.ToString());

            XmlElement title = doc.CreateElement("title");
            title.InnerText = newBook.Title;

            XmlElement author = doc.CreateElement("author");
            author.InnerText = newBook.Author;

            XmlElement year = doc.CreateElement("year");
            year.InnerText = newBook.Year.ToString();

            XmlElement price = doc.CreateElement("price");
            price.InnerText = newBook.Price.ToString();

            book.AppendChild(title);
            book.AppendChild(author);
            book.AppendChild(year);
            book.AppendChild(price);

            return book;
        }
        
        public void AddBook(Book newBook)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);

            XmlNode node = doc.SelectSingleNode("/bookstore");

            node.AppendChild(createBook(doc, newBook));

            doc.Save(FILEPATH);
        }

        public bool DeleteBook(string title)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);

            XmlNode root = doc.SelectSingleNode("/bookstore");
            XmlNode node = doc.SelectSingleNode($"/bookstore/book[title='{title}']");

            if(node != null)
            {
                root.RemoveChild(node);
                doc.Save(FILEPATH);
                
                return true;
            }
            return false;
        }

        public Book GetBookByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBooks()
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBooksByCategory(BookCategory category)
        {
            throw new NotImplementedException();
        }
    }
}
