using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; //Stream
using System.Linq;
using System.Net; //HttpWebRequest
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

//JavaScriptSerializer --> necessário criar referencia para System.Web.Extensions caso pretendam usar para serializar objetos em JSON

namespace ClientProductsApp
{
    public partial class FormMain : Form
    {
        string baseURI = @"http://localhost:55561/";

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonGetAll_Click(object sender, EventArgs e)
        {
            var client = new RestSharp.RestClient(baseURI);
            var request = new RestSharp.RestRequest("api/products", RestSharp.Method.GET);
            var products = client.Execute<List<Product>>(request).Data;

            richTextBoxShowProducts.Clear();
            foreach (Product product in products)
            {
                richTextBoxShowProducts.AppendText($"Id: {product.Id}\tName: {product.Name}\tPrice: {product.Price}" + Environment.NewLine);
            }
        }

        private void buttonGetProductById_Click(object sender, EventArgs e)
        {
            var client = new RestSharp.RestClient(baseURI);
            var request = new RestSharp.RestRequest("api/products/{id}", RestSharp.Method.GET);
            request.AddUrlSegment("id", textBoxFilterById.Text);
            var product = client.Execute<Product>(request).Data;

            if(product == null)
            {
                return;
            }

            textBoxOutput.Clear();
            textBoxOutput.Text = $"Id: {product.Id}\tName: {product.Name}\tPrice: {product.Price}" + Environment.NewLine;
            textBoxID.Text = product.Id.ToString();
            textBoxName.Text = product.Name;
            textBoxCategory.Text = product.Category;
            textBoxPrice.Text = product.Price.ToString();
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = Convert.ToInt32(textBoxID.Text),
                Name = textBoxName.Text,
                Category = textBoxCategory.Text,
                Price = Convert.ToDecimal(textBoxPrice.Text)
            };

            var client = new RestSharp.RestClient(baseURI);
            var request = new RestSharp.RestRequest("api/products", RestSharp.Method.POST);
            request.AddJsonBody(product);
            RestSharp.IRestResponse response = client.Execute(request);

            MessageBox.Show(response.StatusCode + " " + response.ResponseStatus);
        }

        private void buttonPut_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = Convert.ToInt32(textBoxID.Text),
                Name = textBoxName.Text,
                Category = textBoxCategory.Text,
                Price = Convert.ToDecimal(textBoxPrice.Text)
            };

            var client = new RestSharp.RestClient(baseURI);
            var request = new RestSharp.RestRequest("api/products/{id}", RestSharp.Method.PUT);
            request.AddUrlSegment("id", product.Id);
            request.AddJsonBody(product);
            RestSharp.IRestResponse response = client.Execute(request);

            MessageBox.Show(response.StatusCode + " " + response.ResponseStatus);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var client = new RestSharp.RestClient(baseURI);
            var request = new RestSharp.RestRequest("api/products/{id}", RestSharp.Method.DELETE);
            request.AddUrlSegment("id", textBoxID.Text);
            RestSharp.IRestResponse response = client.Execute(request);

            MessageBox.Show(response.StatusCode + " " + response.ResponseStatus);
        }
    }
}
