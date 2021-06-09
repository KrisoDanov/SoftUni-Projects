using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private const double meatCal = 1.2;
        private const double veggieCal = 0.8;
        private const double cheeseCal = 1.1;
        private const double sauseCal = 0.9;

        private string toppings;

        public string Toppings
        {
            get { return toppings; }
            set 
            {
                if (value != "meat" && value != "veggies" &&
                    value != "cheese" && value != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                toppings = value;
            }
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value < 0 || value > 50)
                {
                    throw new ArgumentException($"{toppings} weight should be in the range[1..50].");
                }
                weight = value; 
            }
        }



        public Topping(string topping, double weight)
        {
            this.Toppings = topping;
            this.Weight = weight;
        }

        public double getToppingCal()
        {
            if (toppings == "meat")
            {
                return 2 * meatCal * weight;
            }
            if (toppings == "veggies")
            {
                return 2 * veggieCal * weight;
            }
            if (toppings == "cheese")
            {
                return 2 * cheeseCal * weight;
            }
            if (toppings == "sauce")
            {
                return 2 * sauseCal * weight;
            }
            return 0;
        }
    }
}
