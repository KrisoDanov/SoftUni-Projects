using System;
using System.Collections.Generic;
using System.Linq;

namespace Parking_Batkooo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> registredPerson =
                new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                List<string> splitted = input.Split(" ").ToList();

                if (registredPerson.ContainsKey(splitted[1]) && splitted[0] == "register")
                {
                    Console.WriteLine($"ERROR: already registered with plate number {splitted[2]}");
                }
                if (!registredPerson.ContainsKey(splitted[1]))
                {
                    if (splitted[0] == "register")
                    {
                        registredPerson.Add(splitted[1], splitted[2]);
                        Console.WriteLine($"{splitted[1]} registered {splitted[2]} successfully");
                    }
                }
                if (splitted[0] == "unregister")
                {
                    if (!registredPerson.ContainsKey(splitted[1]))
                    {
                        Console.WriteLine($"ERROR: user {splitted[1]} not found");
                    }
                    if (registredPerson.ContainsKey(splitted[1]))
                    {
                        Console.WriteLine($"{splitted[1]} unregistered successfully");
                        registredPerson.Remove(splitted[1]);
                    }
                }
            }
            foreach (var item in registredPerson)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
