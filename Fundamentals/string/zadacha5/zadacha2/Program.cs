using System;

namespace zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            long multiplier = long.Parse(Console.ReadLine());

            long answear = num * multiplier;
            Console.WriteLine(answear);
        }
    }
}
