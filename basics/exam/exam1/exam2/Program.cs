using System;

namespace exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tickets = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double priceTicket = double.Parse(Console.ReadLine());

            double priceForAll = tickets * priceTicket;
            double change = budget - priceForAll;

            if (budget >= priceForAll)
            {
                Console.WriteLine($"You can sell your client {tickets} tickets for the price of {priceForAll}$!");
                Console.WriteLine($"Your client should become a change of {change}!");
            }
            else
            {
                Console.WriteLine($"The budget of {budget} is not enough. Your client can't buy {tickets} tickets with this budget!");
            }
        }
    }
}
