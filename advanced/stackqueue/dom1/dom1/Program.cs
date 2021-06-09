using System;
using System.Collections.Generic;
using System.Linq;

namespace dom1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[1];
            int s = input[2];

            Stack<int> nums = new Stack<int>(numbers);

            for (int i = 0; i < n; i++)
            {
                nums.Pop();
            }

            if (nums.Contains(s))
            {
                Console.WriteLine("true");
            }
            else if(nums.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(nums.Min());
            }
        }
    }
}
