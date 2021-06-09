using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            int income = 0;
            if (type == "Premiere")
            {
                income = (int)(rows * colums * 12.00);
            }
            else if (type == "Normal")
            {
                income = (int)(rows * colums * 7.50);
            }
            else if (type == "Discount")
            {
                income = (int)(rows * colums * 5.00);
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
