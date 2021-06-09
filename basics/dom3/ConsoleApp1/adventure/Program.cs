using System;

namespace adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string place = "";
            string sleepPlace = "";
            if (budget <= 100)
            {
                place = "Bulgaria";
                if (season == "summer")
                {
                    budget = budget * 0.30;
                    sleepPlace = "Camp";
                }
                else if (season == "winter")
                    
                {
                    budget = budget * 0.70;
                    sleepPlace = "Hotel";

                }
            }

            else if (budget > 100 && budget <= 1000)
            {
                place = "Balkans";
                if (season == "summer")
                    
                {
                    budget = budget * 0.40;
                    sleepPlace = "Camp";
                }
                else if (season == "winter")
                {
                    budget = budget * 0.80;
                    sleepPlace = "Hotel";
                }
            }

            else if (budget > 1000)
            {
                place = "Europe";
                if (season == "summer")
                {
                    budget = budget * 0.90;
                    sleepPlace = "Hotel";
                }
                else if (season == "winter")
                {
                    budget = budget * 0.90;
                    sleepPlace = "Hotel";
                }
            }

            Console.WriteLine($"Somewhere in {place}");
            Console.WriteLine($"{sleepPlace} - {budget:f2}");


        }

    }
}
