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
            List<Product> products = new List<Product>();
            string queryString = "SELECT Id from dbo.Prods";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}", reader[0]);
                        products.Add((Product)reader[0]);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }

            return products;
        }
    }
}
