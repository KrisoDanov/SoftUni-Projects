using System;
using System.Xml.Schema;

namespace exam6
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());


            for (int rows = 1; rows <= row; rows++)
            {
                double sum = 0.00;
                double sum2 = 0.00;
                for (int positions = 1; positions <= position; positions++)
                {
                    if (rows % 2 == 0 && positions % 3 != 0)
                    {
                        sum =rows * 5.00;
                    }
                    else
                    {
                        sum2 = rows * 3.50;
                    }
                }
                double total = (sum + sum2) * 0.2;
                Console.WriteLine($"Total: {total} lv.");
            }



            
        }
    }
}
