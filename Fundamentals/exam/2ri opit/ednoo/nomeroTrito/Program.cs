using System;
using System.Collections.Generic;
using System.Linq;

namespace nomeroTrito
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> cities = new Dictionary<string, List<int>>();
            string input = Console.ReadLine();
            while (input != "Sail")
            {
                string[] split = input.Split("||");
                string city = split[0];
                int population = int.Parse(split[1]);
                int gold = int.Parse(split[2]);
                if (!cities.ContainsKey(split[0]))
                {
                    cities.Add(city, new List<int>());
                    cities[city].Add(population);
                    cities[city].Add(gold);
                }
                else
                {
                    cities[city][1] += gold;
                    cities[city][0] += population;
                }
                input = Console.ReadLine();
            }
            string comands = Console.ReadLine();
            while (comands != "End")
            {
                string[] splitComands = comands.Split("=>");

                if (comands.Contains("Plunder"))
                {
                    string town = splitComands[1];
                    int population = int.Parse(splitComands[2]);
                    int gold = int.Parse(splitComands[3]);
                    cities[town][0] -= population;
                    cities[town][1] -= gold;
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {population} citizens killed.");
                    if (cities[town][0] <= 0 || cities[town][1] <= 0)
                    {
                        cities.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                else
                {
                    string town = splitComands[1];
                    int gold = int.Parse(splitComands[2]);
                    if (gold <= 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                    else
                    {
                        cities[town][1] += gold;
                        Console.WriteLine($"{town} now has {cities[town][1]} gold.");
                    }
                }

                comands = Console.ReadLine();
            }
            cities = cities.OrderByDescending(x => x.Value[1]).
                ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var item in cities)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }

        }
    }
}
