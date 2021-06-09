using System;
using System.Collections.Generic;

namespace dom4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<int> nums = new HashSet<int>();
            int haveIt = 0;
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                
                if (nums.Contains(input))
                {
                    haveIt = input;
                }
                nums.Add(input);
            }
            Console.WriteLine(haveIt);
        }
    }
}
