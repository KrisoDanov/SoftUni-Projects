using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                list.Add(input);
            }
            string[] comand = Console.ReadLine().Split();
            int firstIndex = int.Parse(comand[0]);
            int secondIndex = int.Parse(comand[1]);
            Box<int> box = new Box<int>(list);

            box.Swap(firstIndex, secondIndex);
            Console.WriteLine(box);
        }
    }
}
