using System;
using System.Collections.Generic;
using System.Linq;

namespace dom8
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            Queue<char> second = new Queue<char>();
            Stack<char> first = new Stack<char>();
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input.Length % 2 == 1)
                {
                    Console.WriteLine("NO");
                    break;
                }
                if (true)
                {

                }
            }
        }
    }
}
