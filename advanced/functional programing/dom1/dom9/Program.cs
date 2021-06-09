using System;
using System.Collections.Generic;
using System.Linq;

namespace dom9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> nums2 = new List<int>();
            for (int i = 0; i < n; i++)
            {
                
                nums2.Add(i);
            }
                Func<List<int>, int, bool> anwear = x =>
                {

                }
            foreach (var item in nums2)
            {
                Console.WriteLine(item);
            }

        }
    }
}
