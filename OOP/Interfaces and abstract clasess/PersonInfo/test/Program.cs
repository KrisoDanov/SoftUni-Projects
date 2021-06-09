using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<int> array = new List<int>();
            int s = 0;
            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    s = n / 2;
                    array.Add(2);
                }
                else if (n % 3 == 0)
                {
                    s = n / 3;
                    array.Add(3);
                }
                else if (n % 5 == 0)
                {
                    s = n / 5;
                    array.Add(5);
                }
                n = s;
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
