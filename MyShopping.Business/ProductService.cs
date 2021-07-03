using MyShopping.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopping.Business
{
    public class ProductService
    {
        public List<Product> GetAllProducts()
        {
            List<Product> allProducts = new List<Product>();
            Product product = new Product() { ID = 1, Name = "HP", Category = "Laptop", Price = 1500m, StockQuantity = 10, Description = "iyi laptop" };
            allProducts.Add(product);

            Product product2 = new Product() { ID = 2, Name = "Asus", Category = "Gaming Laptop", Price = 1600m, StockQuantity = 15, Description = "Çalıştırmadığı oyun yok" };
            allProducts.Add(product2);

            return allProducts;
        }
    }

   
}
