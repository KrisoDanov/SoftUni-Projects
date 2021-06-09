using System;
using System.Linq;

namespace dom6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            names = names.Where(x => x.Length <= n).ToArray();
            Console.WriteLine(string.Join(" ",names));
        }
    }
}
