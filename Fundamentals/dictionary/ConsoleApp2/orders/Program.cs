using System;
using System.Collections.Generic;
using System.Linq;

namespace orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> priceOfOrders =
                new Dictionary<string, double>();
            Dictionary<string, double> quantityOfOrders =
                new Dictionary<string, double>();

            string input = Console.ReadLine();

            while (input!= "buy")
            {
                List<string> splitted = input.Split(" ").ToList();
                double price = double.Parse(splitted[1]);
                double quantity = double.Parse(splitted[2]);
                if (!priceOfOrders.ContainsKey(splitted[0]))
                {
                    priceOfOrders.Add(splitted[0], price);
                }
                else
                {
                    priceOfOrders[splitted[0]] = price;
                        
                }
                if (!quantityOfOrders.ContainsKey(splitted[0]))
                {
                    quantityOfOrders.Add(splitted[0], quantity);
                }
                else
                {
                    quantityOfOrders[splitted[0]] += quantity;
                    

                }
                input = Console.ReadLine();
            }
            
            foreach (var kvp in priceOfOrders)
            {
                string name = kvp.Key;
                double price = kvp.Value;
                double qty = quantityOfOrders[name];
                double totalprice = price * qty;
                Console.WriteLine($"{name} -> {totalprice:F2}");
            }
        }
    }
}
