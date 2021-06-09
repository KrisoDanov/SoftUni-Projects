using System;
using System.Collections.Generic;
using System.Linq;

namespace dom2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];

            HashSet<int> nums = new HashSet<int>();
            HashSet<int> nums2 = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int add = int.Parse(Console.ReadLine());
                nums.Add(add);
            }
            for (int i = 0; i < m; i++)
            {
                int add = int.Parse(Console.ReadLine());
                nums2.Add(add);
            }
            var answear = nums.Intersect(nums2);

            Console.WriteLine(String.Join(" ", answear));
        }
    }
}
