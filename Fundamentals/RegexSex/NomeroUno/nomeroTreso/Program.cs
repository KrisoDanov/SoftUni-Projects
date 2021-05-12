using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace nomeroTreso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<string> product = new List<string>();
            List<double> price = new List<double>();
            double totalForProduct = 0;


            string input = Console.ReadLine();
            string pattern = @"%(?<name>\w+)%<(?<product>\w+)>\|(?<quantity>\d+)\|(?<price>\d+\.?\d+)\$";

            while (input != "end of shift")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {



                    string name = match.Groups["name"].Value;
                    if (name != "InvalidName")
                    {
                        names.Add(name);
                    }
                    string productType = match.Groups["product"].Value;
                    product.Add(productType);
                    double products = double.Parse(match.Groups["quantity"].Value);
                    double quantity = double.Parse(match.Groups["price"].Value);
                    totalForProduct += products * quantity;
                    price.Add(totalForProduct);
                    

                    
                    totalForProduct = 0;
                }

                input = Console.ReadLine();
            }
            int i = 0;
            foreach (var item in names)
            {
                Console.WriteLine($"{item}: {product[i]} - {price[i]:f2}");
                i++;
            }
            Console.Write($"Total income: {price.Sum(x => x):f2}");
        }
    }
}
