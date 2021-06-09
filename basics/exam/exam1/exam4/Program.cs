using System;

namespace exam4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            for (int i = m; m >= n; m--)
            {
                if (s == m)
                {
                    break;
                }
                if (m % 2 == 0 &&
                    m % 3 == 0)
                {
                    Console.Write($"{m} ");
                }
            }
        }
    }
}
