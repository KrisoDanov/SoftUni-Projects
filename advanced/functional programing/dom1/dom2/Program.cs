using System;
using System.Collections.Generic;
using System.Linq;

namespace dom2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            names = names.Select(n => $"Sir {n}").ToList();
            Action<List<string>> namesSir = x => Console.WriteLine(string.Join(Environment.NewLine, x));
            namesSir(names);
        }
    }
}
