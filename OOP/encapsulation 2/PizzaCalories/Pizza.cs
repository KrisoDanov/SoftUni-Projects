using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {

        private string name;
        private readonly List<Topping> toppings;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value) && value.Length < 1 && value.Length > 15 )
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value; 
            }
        }


        
        public int CountOfToppings => this.toppings.Count;
        


        public Pizza(string name)
        {
            this.Name = name;
            toppings = new List<Topping>();

        }
        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count < 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            this.toppings.Add(topping);
        }
        
    }
}
