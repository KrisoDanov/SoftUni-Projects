using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int smallBottles = int.Parse(Console.ReadLine());
            int bigBottles = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int smallBottlesCount = 1 * smallBottles;

            int calculation = (smallBottles * 1) + (bigBottles * 5) - capacity;
            if (calculation < 0)
            {
                Console.WriteLine(calculation);
            }
            else
            {
                Console.WriteLine(smallBottlesCount);
            }
            
        }
    }
}
