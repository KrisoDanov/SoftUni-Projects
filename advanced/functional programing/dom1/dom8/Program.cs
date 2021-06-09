using System;
using System.Collections.Generic;
using System.Linq;

namespace dom8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(nums, (x, y) =>
            {
                int compare = 0;
                if (x % 2 == 0 && y % 2 !=0)
                {
                    compare = -1;
                }
               
               else if (x % 2 != 0 && y % 2 == 0)
                {
                    compare = 1;
                }
                else
                {
                    compare = x - y;
                }
                return compare;
            });
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
