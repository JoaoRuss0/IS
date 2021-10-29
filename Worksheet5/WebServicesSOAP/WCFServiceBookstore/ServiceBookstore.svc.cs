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

            XmlNode node = doc.SelectSingleNode($"/bookstore/book[title='{title}']");

            if(node != null)
            {
                node.ParentNode.RemoveChild(node);
                doc.Save(FILEPATH);
                
                return true;
            }
            return false;
        }

        public Book GetBookByTitle(string title)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);

            XmlNode node = doc.SelectSingleNode($"/bookstore/book[title='{title}']");

            if(node == null)
            {
                return null;
            }
            return new Book
            {
                Title = node["title"].InnerText,
                Author = node["author"].InnerText,
                Price = Convert.ToDouble(node["price"].InnerText, System.Globalization.NumberFormatInfo.InvariantInfo),
                Year = Convert.ToInt32(node["year"].InnerText),
                Category = (BookCategory)Enum.Parse(typeof(BookCategory), node.Attributes["category"].Value)
            };
        }

        public List<Book> GetBooks()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);

            XmlNodeList booksXml = doc.SelectNodes("/bookstore/book");
            List<Book> books = new List<Book>();

            foreach(XmlNode bookXml in booksXml)
            {
                Book book = new Book
                {
                    Title = bookXml["title"].InnerText,
                    Author = bookXml["author"].InnerText,
                    Price = Convert.ToDouble(bookXml["price"].InnerText, System.Globalization.NumberFormatInfo.InvariantInfo),
                    Year = Convert.ToInt32(bookXml["year"].InnerText),
                    Category = (BookCategory)Enum.Parse(typeof(BookCategory), bookXml.Attributes["category"].Value)
                };
                
                books.Add(book);
            }

            return books;
        }

        public List<Book> GetBooksByCategory(BookCategory category)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);

            XmlNodeList booksXml = doc.SelectNodes($"/bookstore/book[@category='{category}']");
            List<Book> books = new List<Book>();

            foreach (XmlNode bookXml in booksXml)
            {
                Book book = new Book
                {
                    Title = bookXml["title"].InnerText,
                    Author = bookXml["author"].InnerText,
                    Price = Convert.ToDouble(bookXml["price"].InnerText, System.Globalization.NumberFormatInfo.InvariantInfo),
                    Year = Convert.ToInt32(bookXml["year"].InnerText),
                    Category = (BookCategory)Enum.Parse(typeof(BookCategory), bookXml.Attributes["category"].Value)
                };

                books.Add(book);
            }

            return books;
        }

        public List<Book> GetBooksByTitle(string title)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);

            XmlNodeList booksXml = doc.SelectNodes($"/bookstore/book[contains(title,'{title}')]");
            List<Book> books = new List<Book>();

            foreach (XmlNode bookXml in booksXml)
            {
                Book book = new Book
                {
                    Title = bookXml["title"].InnerText,
                    Author = bookXml["author"].InnerText,
                    Price = Convert.ToDouble(bookXml["price"].InnerText, System.Globalization.NumberFormatInfo.InvariantInfo),
                    Year = Convert.ToInt32(bookXml["year"].InnerText),
                    Category = (BookCategory)Enum.Parse(typeof(BookCategory), bookXml.Attributes["category"].Value)
                };

                books.Add(book);
            }

            return books;   
        }
    }
}
