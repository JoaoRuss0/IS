using ProductsAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ProductsAPI.Controllers
{
    public class ProductsController : ApiController
    {
        //Probably a database in a real scenario...
        List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        [Route("api/products/{id:int}")]
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product); //Respecting HTTP errors (200 OK)
        }

        [Route("api/products/{category}")]
        public IEnumerable<Product> GetProductByCategory(string category)
        {
            return products.Where((product) => product.Category.Equals(category));
        }
    }
}
