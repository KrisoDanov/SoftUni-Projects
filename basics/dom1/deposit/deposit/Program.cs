using System;

namespace deposit
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            double anualinterest = double.Parse(Console.ReadLine());

            double sum = (deposit * anualinterest) / 100;

            double interes = sum / 12;

            double result = deposit + (time * interes);

            Console.WriteLine(result);
        }
    }
}
