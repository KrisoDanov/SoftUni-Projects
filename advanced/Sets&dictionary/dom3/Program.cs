using System;
using System.Collections.Generic;
using System.Linq;

namespace dom3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> table = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                for (int j = 0; j < input.Length; j++)
                {
                    table.Add(input[j]);
                }
            }
            Console.WriteLine(String.Join(" ", table));
        }
    }
}
