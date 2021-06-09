using System;
using System.Collections.Generic;

namespace purva
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string countries = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Travel")
            {
                string[] split = input.Split(":");
                if (input.Contains("Add"))
                {
                    if ((countries.Length - int.Parse(split[1]) >= split[2].Length))
                    {
                        countries = countries.Insert(int.Parse(split[1]), split[2]);
                        Console.WriteLine(countries);
                    }
                        
                    
                }
                if (input.Contains("Remove"))
                {
                    int distance = int.Parse(split[2]) - int.Parse(split[1]);
                    if (countries.Length > int.Parse(split[1])
                        && countries.Length > int.Parse(split[2]))
                    {
                        countries = countries.Remove(int.Parse(split[1]), (distance + 1));
                        Console.WriteLine(countries);
                    }
                   

                }
                if (input.Contains("Switch"))
                {
                    countries = countries.Replace(split[1], split[2]);
                    Console.WriteLine(countries);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {countries}");

        }
    }
}
