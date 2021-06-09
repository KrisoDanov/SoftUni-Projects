using System;
using System.Collections.Generic;
using System.Linq;

namespace nomerttri
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> cars = new Dictionary<string, int[]>();
            int n = int.Parse(Console.ReadLine());
            string models = "";
            int km = 0;
            int fuel = 0;
            string[] splitModels;
            for (int i = 0; i < n; i++)
            {
                models = Console.ReadLine();
                splitModels = models.Split("|");
                km = int.Parse(splitModels[1]);
                fuel = int.Parse(splitModels[2]);
                if (!cars.ContainsKey(splitModels[0]))
                {
                    cars.Add(splitModels[0], new int[2] {km, fuel});
                    
                }
            }


            string input = Console.ReadLine();
            while (input != "Stop")
            {
                splitModels = models.Split("|");
                string[] splitComads = input.Split(" : ");
                if (splitComads.Contains("Drive") )
                {
                    if (fuel >= int.Parse(splitComads[3]))
                    {
                        cars[0]][km] += int.Parse(splitComads[2]);
                        cars[splitComads[0]][fuel] -= int.Parse(splitComads[3]);
                        Console.WriteLine($"{splitComads[0]} driven for {km} kilometers. {fuel} liters of fuel consumed.");
                    }
                    if (fuel < int.Parse(splitComads[3]))
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    if (cars[splitComads[1]][km] > 100000)
                    {
                        cars.Remove(splitComads[0]);
                        Console.WriteLine($"Time to sell the {splitComads[0]}!");
                    }
                   
                }
                if (splitComads.Contains("Refuel"))
                {
                    cars[splitComads[0]][fuel] += int.Parse(splitComads[2]);
                    if (cars[splitComads[0]][fuel] > 75)
                    {
                        cars[splitComads[0]][fuel] = 75;
                    }
                    Console.WriteLine($"{splitComads[0]} mileage decreased by {int.Parse(splitComads[2])} kilometers");
                }
                input = Console.ReadLine();
            }
            cars = cars.OrderByDescending(f => f.Value[fuel])
                .ThenBy(f => f.Key)
                .ToDictionary(f => f.Key, f => f.Value);
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value[0]} kms, Fuel in the tank: {item.Value[1]} lt.");
            }
        }
    }
}
