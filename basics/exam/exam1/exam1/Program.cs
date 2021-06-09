using System;

namespace exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            double pencils = double.Parse(Console.ReadLine());
            double markers = double.Parse(Console.ReadLine());
            double paper = double.Parse(Console.ReadLine());
            double notebook = double.Parse(Console.ReadLine());

            double price = (pencils * 4.75) + (markers * 1.80) + (paper * 6.50) + (notebook * 2.50);

            double totalPrice = (price - 0.05 * price);
            Console.WriteLine($"Your total is {totalPrice:F2}");


        }
    }
}
