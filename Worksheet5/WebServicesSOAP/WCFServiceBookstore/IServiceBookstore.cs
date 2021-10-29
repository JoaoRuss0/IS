using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServiceBookstore
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceBookstore
    {
        [OperationContract]
        void AddBook(Book newBook);

        [OperationContract]
        List<Book> GetBooks();

        [OperationContract]
        List<Book> GetBooksByCategory(BookCategory category);

        [OperationContract]
        Book GetBookByTitle(String title);

        [OperationContract]
        List<Book> GetBooksByTitle(String title);

        [OperationContract]
        bool DeleteBook(String title);
    }

    public enum BookCategory
    {
        WEB,
        CHILDREN,
        SCIENCE,
        ROMANCE,
        BIOGRAPHIES,
        OTHER
    }

    [DataContract]
    public class Book
    {
        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Author { get; set; }

        [DataMember]
        public int Year { get; set; }

        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public BookCategory Category { get; set; }
    }

    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
