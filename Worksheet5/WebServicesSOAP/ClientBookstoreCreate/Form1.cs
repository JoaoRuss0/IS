using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientBookstoreCreate.ServiceReferenceBookstore;

namespace ClientBookstoreCreate
{
    public partial class Form1 : Form
    {
        List<Book> books = new List<Book>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxCategory.DataSource = Enum.GetValues(typeof(BookCategory));
            comboBoxFilterCategory.DataSource = Enum.GetValues(typeof(BookCategory));
        }

        private void buttonGetBooks_Click(object sender, EventArgs e)
        {
            using (ServiceBookstoreClient service = new ServiceBookstoreClient())
            {
                books = service.GetBooks().ToList();
            }

            listBoxBooks.DataSource = books;
            listBoxBooks.DisplayMember = "Title";
            listBoxBooks.ValueMember = "Title";
        }

        private void buttonFilterCategory_Click(object sender, EventArgs e)
        {
            using(ServiceBookstoreClient service = new ServiceBookstoreClient())
            {
                books = service.GetBooksByCategory((BookCategory)comboBoxFilterCategory.SelectedItem).ToList();
            }

            listBoxBooks.DataSource = books;
        }

        private void buttonFilterTitle_Click(object sender, EventArgs e)
        {
            using (ServiceBookstoreClient service = new ServiceBookstoreClient())
            {
                books = service.GetBooksByTitle(textBoxFilterTitle.Text).ToList();
            }

            listBoxBooks.DataSource = books;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "";
            textBoxAuthor.Text = "";
            numericUpDownPrice.Value = numericUpDownPrice.Minimum;
            numericUpDownYear.Value = numericUpDownYear.Minimum;
            comboBoxCategory.SelectedIndex = 0;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            using (ServiceBookstoreClient service = new ServiceBookstoreClient())
            {
                service.DeleteBook(textBoxTitle.Text);
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            Book book = new Book
            {
                Title = textBoxTitle.Text,
                Author = textBoxAuthor.Text,
                Price = Convert.ToDouble(numericUpDownPrice.Value),
                Year = Convert.ToInt32(numericUpDownYear.Value),
                Category = (BookCategory)comboBoxCategory.SelectedItem
            };

            using (ServiceBookstoreClient service = new ServiceBookstoreClient())
            {
                service.AddBook(book);
            }
        }
    }
}
