using System;
using System.Collections.Generic;
using System.Linq;

namespace dom5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            int comand = int.Parse(Console.ReadLine());
            nums.Reverse();
            nums = nums.Where(x => x % comand != 0).ToList();
            
            Console.WriteLine(string.Join(" ", nums));

        }
    }
}
