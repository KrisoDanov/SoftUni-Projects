using System;
using System.Dynamic;

namespace elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            
            for (int i = 0; i < n; i++)

            {
                int numbers = int.Parse(Console.ReadLine());
                sum += max;
                if (numbers > max) 
                {
                    max = numbers;
                }
            }
            int sumWithMax = sum + max;
            if (max == sumWithMax)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum " + max);
            }
            else
            {
                int diff = Math.Abs(max - sumWithMax);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }

        }
    }
}
