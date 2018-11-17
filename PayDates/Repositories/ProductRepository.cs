using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PayDates.Models;

namespace PayDates.Repositories
{
    public class ProductRepository
    {
        public List<Product> GetAllProducts()
        {
            return new List<Product>();
        }

        public Product GetProductById(int id)
        {
            return new Product();
        }

        public void UpdateProduct(Product product)
        {
        }

        public void DeleteProduct(int d)
        {
        }
    }
}
