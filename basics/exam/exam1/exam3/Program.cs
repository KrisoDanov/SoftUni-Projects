using System;

namespace exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string labs = Console.ReadLine();
            string fanCadrd = Console.ReadLine();
            string cardType = Console.ReadLine();

            double cost = 0.00;

            if (labs == "five")
            {

                
                    if (cardType == "Child")
                    {
                        cost = 7;
                    }
                    if (cardType == "Junior")
                    {
                        cost = 9;
                    }
                    if (cardType == "Adult")
                    {
                        cost = 12;
                    }
                    if (cardType == "Profi")
                    {
                        cost = 18;
                    }

                if (fanCadrd == "yes")
                {
                    cost = cost - 0.20 * cost;
                }
            }
            if (labs == "ten")
            {
                if (cardType == "Child")
                {
                    cost = 11;
                }
                if (cardType == "Junior")
                {
                    cost = 16;
                }
                if (cardType == "Adult")
                {
                    cost = 21;
                }
                if (cardType == "Profi")
                {
                    cost = 32;
                }
                if (fanCadrd == "yes")
                {
                    cost = cost - 0.20 * cost;
                }

            }
            double finalPrice = buget - cost;

            if (buget >= cost)
            {
                Console.WriteLine($"You bought {cardType} ticket for {labs} laps. Your change is {finalPrice:F2}lv.");

            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need {Math.Abs(finalPrice):F2}lv more.");
            }

        }
    }
}
