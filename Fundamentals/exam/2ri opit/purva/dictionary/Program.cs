using System;
using System.Collections.Generic;
using System.Linq;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, int> plantsRarity = new Dictionary<string, int>();
            Dictionary<string, int> plantsRating = new Dictionary<string, int>();
            string input = Console.ReadLine();
            string[] split = input.Split("<->");
            for (int i = 0; i < num; i++)
            {
                string[] splite = input.Split("<->");
                plantsRarity.Add(splite[0], int.Parse(splite[1]));
                plantsRating.Add(splite[0], 0);
                input = Console.ReadLine();
            }
            
            while (input != "Exhibition")
            {
                string[] splitRate = input.Split("-");
                string[] splitReset = input.Split(":");
                if (input.Contains("Rate"))
                {
                    if (plantsRating.ContainsKey(split[0]))
                    {
                        plantsRating[split[0]] += int.Parse(splitRate[1]);
                    }

                }
                if (input.Contains("Update"))
                {
                    plantsRarity.Remove(split[1]);
                    plantsRarity[split[0]] += int.Parse(splitRate[1]);
                }
                if (input.Contains("Reset"))
                {
                    if (input.Contains(splitReset[0]))
                    {
                        plantsRating.Remove(split[1]);
                    }
                    
                }

                input = Console.ReadLine();
            }
           
            foreach (var item in plantsRarity)
            {
                foreach (var rating in plantsRating)
                {
                    Console.WriteLine($"-{item.Key}; Rarity: {item.Value}; Rating: {rating.Value:f2}");

                }
            }
            
        }
    }
}
