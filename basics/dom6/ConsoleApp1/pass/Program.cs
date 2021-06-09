using System;

namespace pass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int x1 = 0; x1 < 10; x1++)
            {
                for (int x2 = 0; x2 < 10; x2++)
                {
                    for (int x3 = 0; x3 < 10; x3++)
                    {
                        for (int x4 = 0; x4 < 10; x4++)
                        {
                           
                                if (n % x1 == 0 &&
                                    n % x2 == 0 &&
                                    n % x3 == 0 &&
                                    n % x4 == 0)
                                {
                                    Console.WriteLine($"{x1}{x2}{x3}{x4}");
                                }
                           
                        }
                    }
                }
            }
        }
    }
}
