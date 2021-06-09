using System;

namespace exam66
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceStrawberry = 3.50;
            double priceBlueberry = 5.00;

            double rows = double.Parse(Console.ReadLine());
            double columns = double.Parse(Console.ReadLine());

            double countStrawberry = 0;
            double countBlueberry = 0;

            for (double row = 1; row <= rows; row++)
            {
                if (row % 2 != 0)
                {
                    countStrawberry += columns;
                    continue;
                }

                for (double col = 1; col <= columns; col++)
                {
                    if (col % 3 != 0)
                    {
                        countBlueberry++;
                    }
                }
            }

            double profit = (countStrawberry * priceStrawberry + countBlueberry * priceBlueberry) * 0.8;

            Console.WriteLine($"Total: ${profit:F2}");
        }
    }
}
