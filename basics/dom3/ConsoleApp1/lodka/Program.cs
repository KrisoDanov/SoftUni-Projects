using System;

namespace lodka
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double fishMan = double.Parse(Console.ReadLine());

            double shipPrice = 0.00;

            if (season == "Spring")
            {
                shipPrice = 3000;
                if (fishMan <= 6)
                {
                    shipPrice = 3000 * 0.10;
                }
                else if (fishMan >= 7 && fishMan <= 11)
                {
                    shipPrice = 3000 * 0.15;
                }
                else if (fishMan > 11)
                {
                    shipPrice = 3000 * 0.25;
                }
            }

            else if (season == "Summer")
            {
                shipPrice = 4200;
                if (fishMan <= 6)
                {
                    shipPrice = 4200 * 0.10;
                }
                else if (fishMan >= 7 && fishMan <= 11)
                {
                    shipPrice = 42000 * 0.15;
                }
                else if (fishMan > 11)
                {
                    shipPrice = 4200 * 0.25;
                }

            }
            else if (season == "Autumn")
            {
                shipPrice = 4200;

                if (fishMan <= 6)
                {
                    shipPrice = 4200 * 0.10;
                }
                else if (fishMan >= 7 && fishMan <= 11)
                {
                    shipPrice = 4200 * 0.15;
                }
                else if (fishMan > 11)
                {
                    shipPrice = 4200 * 0.25;

                }

            }
            else if (season == "Winter")
            {
                shipPrice = 2600;
                if (fishMan <= 6)
                {
                    shipPrice = 2600 * 0.10;
                }
                else if (fishMan >= 7 && fishMan <= 11)
                {
                    shipPrice = 2600 * 0.15;
                }
                else if (fishMan > 11)
                {
                    shipPrice = 2600 * 0.25;
                }

            }

            double moneyLeft = shipPrice - buget;

                if (buget > shipPrice)
                 {
                    Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                 }
            else
            {
                    Console.WriteLine($"Not enough money!You need {Math.Abs(moneyLeft):f2} leva.");
            }

        }

    }
}
