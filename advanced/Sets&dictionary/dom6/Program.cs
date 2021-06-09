using System;
using System.Collections.Generic;
using System.Linq;

namespace dom6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary< string, int>> ();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                var cloth = input[1].Split(",").ToArray();
                if (!wardrobe.ContainsKey(input[0]))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                for (int j = 0; j < cloth.Length; j++)
                {
                    if (!wardrobe[color].ContainsKey(cloth[j]))
                    {
                        wardrobe[color].Add(cloth[j], 0);
                    }
                    wardrobe[color][cloth[j]]++;
                }
            }
            var todaysDress = Console.ReadLine().Split().ToArray();
            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var cloth in item.Value)
                {
                    Console.Write($"* {cloth.Key} - {cloth.Value}");
                    if (item.Key == todaysDress[0] && cloth.Key == todaysDress[1])
                    {
                        Console.WriteLine(" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
