using System;
using System.Numerics;

namespace _5amaNanovo
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger first = BigInteger.Parse(Console.ReadLine());
            int second =int.Parse(Console.ReadLine());

            BigInteger done = first * second;
            Console.WriteLine(done);
        }
    }
}
