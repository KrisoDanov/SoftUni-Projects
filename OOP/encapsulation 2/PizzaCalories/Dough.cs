using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {

        private const double whiteDough = 1.5;
        private const double wholegrainDough = 1.0;
        private const double crispyTech = 0.9;
        private const double chewyTech = 1.1;
        private const double hommadeTech = 1.0;

        private string type;
        private string bakingTech;
        private double grams;

        public string Type
        {
            get { return type; }
            set
            {
                if (value != "white" && value != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                type = value;
            }
        }


        public string BakingTech
        {

            get { return bakingTech; }
            set
            {
                if (value != "crispy" && value != "chewy" && value != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");

                }
                bakingTech = value;
            }
        }


        public double Grams
        {
            get { return grams; }
            set 
            {
                if (value <= 0 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                grams = value;
            }
        }

        public Dough(string type, string bakingTech, double grams)
        {
            this.Type = type;
            this.BakingTech = bakingTech;
            this.Grams = grams;
        }

        public double GetCalories()
        {
            if (this.Type == "white")
            {
                if (this.BakingTech == "crispy")
                {
                    return (2 * this.grams) * whiteDough * crispyTech;
                }
                if (this.BakingTech == "chewy")
                {
                    return (2 * this.grams) * whiteDough * chewyTech;
                }
                if (this.BakingTech == "homemade")
                {
                    return (2 * this.grams) * whiteDough * hommadeTech;
                }

            }
            else if (this.Type == "wholegrain")
            {
                if (this.BakingTech == "crispy")
                {
                    return (2 * this.grams) * wholegrainDough * crispyTech;
                }
                if (this.BakingTech == "chewy")
                {
                    return (2 * this.grams) * wholegrainDough * chewyTech;
                }
                if (this.BakingTech == "homemade")
                {
                    return (2 * this.grams) * wholegrainDough * hommadeTech;
                }

            }
            return 0;

        }
    }
}
