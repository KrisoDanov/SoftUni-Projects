using System;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int product1 = (n / 100) + ((n % 100) / 10) + ((n % 100) % 10);


            int looo = ((n % 100) % 100); ;
            int loo = ((n % 100) % 10);
            int lo = ((n % 100) / 10);
            int l = (n / 100);

            if (l % 2 ==0)
            {
                if (lo % 2 == 0)
                {
                    Console.WriteLine($"{l + lo} energy drinks");
                    if (loo % 2 == 0)
                    {
                        Console.WriteLine($"{l + lo + loo} energy drinks");
                    }
                }
            }
            else if (l % 2 == 1)
            {
                Console.WriteLine($"{l} cups of coffee");
                if (lo % 2 == 1)
                {
                    Console.WriteLine($"{l + lo} cups of coffee");
                    if (loo % 2 == 1)
                    {
                        Console.WriteLine($"{ l + lo + loo} cups of coffee");
                    }
                    else
                    {
                        Console.WriteLine($"{l}of both");
                    }
                }
            } 
        }
    }
}
