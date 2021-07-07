using System;
using System.Collections.Generic;

namespace ProductAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }

    public class ProductsDb : List<Product>
    {
        public ProductsDb()
        {
            Add(new Product() {ProductId=101,ProductName="P1" });
            Add(new Product() { ProductId = 102, ProductName = "P2" });
        }

    }
}
