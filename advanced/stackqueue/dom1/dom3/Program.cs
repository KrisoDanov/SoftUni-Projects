using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace dom3
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            int n = 1;
            
            while (n != times)
            {
               
                if (input[0] == 1)
                {
                    stack.Push(input[1]);
                }
                if (input[0] == 2)
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    } 
                }
                if (input[0] == 3)
                {
                    {
                        Console.WriteLine(stack.Max());
                    }  
                }
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (input[0] == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
                n++;
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
