using System;

namespace birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());

            double cake = rent * 0.2;
            double drinks = cake - (cake * 0.45);
            double animator = rent / 3;

            double moneyneed = rent + cake + drinks + animator;

            Console.WriteLine(moneyneed);

        }
    }
}
