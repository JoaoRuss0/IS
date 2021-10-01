using ProductsDatabaseAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Http;

namespace ProductsDatabaseAPI.Controllers
{
    public class ProductController : ApiController
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ProductsDatabaseAPI.Properties.Settings.ConnStr"].ConnectionString;

        [Route("api/products")]
        public IEnumerable<Product> GetAllProducts()
        {
            SqlConnection connection = null;
            List<Product> products = new List<Product>();
            string queryString = "SELECT * FROM Prods";

            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    Product product = new Product
                    {
                        Id =        (int)     reader["Id"],
                        Name =      (string)  reader["Name"],
                        Category =  ((reader["Category"] == DBNull.Value) ? "" : (string) reader["Category"]),
                        Price =     ((reader["Price"]    == DBNull.Value) ? 0  : Convert.ToDecimal(reader["Price"]))
                    };

                    products.Add(product);
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return products;
        }

        [Route("api/products/{id:int}")]
        public IHttpActionResult GetProduct(int id)
        {
            SqlConnection connection = null;
            Product product = null;
            string queryString = "SELECT * FROM Prods WHERE Id = @Id";

            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    product = new Product
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        Category = ((reader["Category"] == DBNull.Value) ? "" : (string)reader["Category"]),
                        Price = ((reader["Price"] == DBNull.Value) ? 0 : Convert.ToDecimal(reader["Price"]))
                    };
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }

                return InternalServerError();
            }

            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [Route("api/products/{category}")]
        public IEnumerable<Product> GetProductsCategory(string category)
        {
            SqlConnection connection = null;
            List<Product> products = new List<Product>();
            string queryString = "SELECT * FROM Prods WHERE Category LIKE @Category";

            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@Category", category);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        Category = ((reader["Category"] == DBNull.Value) ? "" : (string)reader["Category"]),
                        Price = ((reader["Price"] == DBNull.Value) ? 0 : Convert.ToDecimal(reader["Price"]))
                    };

                    products.Add(product);
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return products;
        }

        public IHttpActionResult PostProduct(Product product)
        {
            SqlConnection connection = null;
            string queryString = "INSERT Prods(Id, Name, Category, Price) VALUES(@Id, @Name, @Category, @Price})";
            
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@Id", product.Id);
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@Category", product.Category);
                command.Parameters.AddWithValue("@Price", product.Price);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            
            return Ok();
        }
        /*
        public IHttpActionResult PutProduct(int id, Product p)
        {
            
        }
        
        public IHttpActionResult DeleteProduct(int id)
        {
            
        }
        */
    }
}
