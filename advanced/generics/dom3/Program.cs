using System;
using System.Collections.Generic;

namespace dom3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
             
                string input = Console.ReadLine();
                list.Add(input);
            }
            string comparison = Console.ReadLine();
            Box<string> box = new Box<string>(list);
           int counter = box.Compare(comparison);
            Console.WriteLine(counter);
        }
    }
}
