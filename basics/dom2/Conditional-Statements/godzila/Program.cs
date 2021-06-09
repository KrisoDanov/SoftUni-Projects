using System;
using System.Xml.XPath;

namespace godzila
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int people =  int.Parse(Console.ReadLine());
            double clothes = double.Parse(Console.ReadLine());

           
            double decorPrice = budget * 0.10;
            double totalClothingPrice = people * clothes ;

            if (people > 150)
            {
                totalClothingPrice = clothes - (0.10 * clothes);
            }
            double result = totalClothingPrice + decorPrice;
            double moneyleft = budget - result;

            if (result <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyleft:f2} leva left.");
            }
            else 
            {
                Console.WriteLine("Not enough money!");
               Console.WriteLine ($"Wingard needs {moneyleft:f2} leva more");

            }
        }
    }
}
