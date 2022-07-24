using System.Collections.Generic;

namespace Task5.Model
{
    public static class DataInitializer
    {
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product() { Id = 1, Name = "product1", Price = 10.1M });
            products.Add(new Product() { Id = 2, Name = "product2", Price = 100.1M });
            products.Add(new Product() { Id = 3, Name = "product3", Price = 1000.1M });
            products.Add(new Product() { Id = 4, Name = "product4", Price = 10000.1M });
            products.Add(new Product() { Id = 5, Name = "product5", Price = 100000.1M });
            return products;
        }
    }
}
