using System;
using System.Collections.Generic;
using System.Linq;

namespace dom5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            Stack<int> clothes = new Stack<int>(n);
            int space = int.Parse(Console.ReadLine());
            int shelf = 0;
            int counter = 1;
            while (clothes.Count > 0)
            {
                var current= clothes.Peek();
                if (shelf + current > space)
                {
                    shelf = 0;
                    counter++;
                }
                else
                {
                    shelf += clothes.Pop();
                }
            }
            Console.WriteLine(counter);
        }
    }
}
