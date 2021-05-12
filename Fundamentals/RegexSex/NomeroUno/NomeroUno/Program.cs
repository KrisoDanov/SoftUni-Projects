using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NomeroUno
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> furniture = new List<string>();

            string pattern = @">>(?<furniture>\w+)<<(?<price>\d+\.?\d+)!(?<quantity>\d+)";

            string input = Console.ReadLine();
            double totalPrice = 0;

            while (input != "Purchase")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string name = match.Groups["furniture"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    furniture.Add(name);
                    totalPrice += price * quantity;
                }
                
                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in furniture)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total money spend: {totalPrice}");
        }
    }
}
