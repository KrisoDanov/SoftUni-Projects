using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public abstract class Product
    {

        public Product(string name, string brand, decimal price)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price= price;
            
        }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }

    }
}
