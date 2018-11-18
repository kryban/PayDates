using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PayDates.Models;

namespace PayDates.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
