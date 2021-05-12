using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace nomeroDos
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> winners = new Dictionary<string, double>();

            string[] players = Console.ReadLine().
                Split(", ");

            foreach (string player in players)
            {
                if (!winners.ContainsKey(player))
                {
                    winners[player] = 0;
                }
            }
                string input = Console.ReadLine();
                while (input != "end of race")
                {
                    string name = string.Empty;
                    double distance = 0;

                    Regex pattern = new Regex(@"[A-Za-z]");
                    MatchCollection matches = pattern.Matches(input);
                    foreach (Match item in matches)
                    {
                        name += item.Value;
                    }
                    if (winners.ContainsKey(name))
                    {
                        MatchCollection distanceSum = Regex.Matches(input, @"[0-9]");
                        foreach (Match item in distanceSum)
                        {
                            distance += double.Parse(item.Value);
                        }
                        winners[name] += distance;
                    }

                    input = Console.ReadLine();
                }

            winners = winners.OrderByDescending(x => x.Value)
                 .ToDictionary(x => x.Key, y => y.Value);

            int counter = 1;

            foreach (var kvp in winners)
            {
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {kvp.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {kvp.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {kvp.Key}");
                }
                else
                {
                    break;
                }
                counter++;
            }
        }
    }
}
