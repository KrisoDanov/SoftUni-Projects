using System;
using System.Collections.Generic;
using System.Linq;

namespace dom4
{
    class Program
    {
        static void Main(string[] args)
        {
            int qunatity = int.Parse(Console.ReadLine());
            var order = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> clients = new Queue<int>(order);
            int biggest = clients.Max();
            while (clients.Count > 0)
            {
                var food = clients.Peek();
                if (qunatity >= food)
                {
                    qunatity -= clients.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (clients.Count > 0)
            {
                Console.WriteLine(biggest);
                Console.WriteLine($"Orders left: " + string.Join(" ", clients));
            }
            else
            {
                Console.WriteLine(biggest);
                Console.WriteLine("Orders complete");
            }
        }
    }
}
