using System;

namespace dom1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Action<string[]> printNames = x => Console.WriteLine(string.Join(Environment.NewLine, x));
            printNames(names);
        }
    }
}
