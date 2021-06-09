using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;
        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            bag = new List<Product>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        

        public decimal Money
        {
            get { return money; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }
        public string BuyProduct(Product product)
        {
            if (this.Money < product.Price)
            {
                return $"{this.name} can't afford {product.ProductName}";
            }
            this.Money -= product.Price;
            this.bag.Add(product);

            return $"{this.name} bought {product}";
        }
        public override string ToString()
        {
            string productsOutput = this.bag.Count > 0 ? String.Join
                (", ", this.bag) : "Nothing bought";
            return $"{this.name} - {productsOutput}";
        }
    }
}
