using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
   public class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public Product(string productName, decimal price)
        {
            this.ProductName = productName;
            this.Price = price;
        }
        public override string ToString()
        {
            return this.ProductName;
        }
    }
}
