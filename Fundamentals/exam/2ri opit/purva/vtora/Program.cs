using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace vtora
{
    class Program
    {
        private static object rexeg;

        static void Main(string[] args)
        {
            Regex regex =
                new Regex(@"(={1}|\/{1})(?<name>[A-Z][a-z]{3,})\1");

            string places = Console.ReadLine();
            List<string> destination = new List<string>();
            MatchCollection match = regex.Matches(places);
            int counter = 0;
            if (match.Count > 0)
            {
                foreach (Match item in match)
                {
                    destination.Add(item.Groups["name"].Value);
                    counter += item.Groups["name"].Length;
                    
                }
                if (counter >= 1)
                {
                    Console.WriteLine($"Destinations: {string.Join(", ", destination)}");
                    Console.WriteLine($"Travel Points: {counter}");
                }
                if (counter == 0)
                {
                    Console.WriteLine($"Destinations:");
                    Console.WriteLine($"Travel Points: 0");
                }
               
            }
        }
    }
}
