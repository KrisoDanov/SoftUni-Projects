using System;
using System.Collections.Generic;
using System.Linq;

namespace Dungeons
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rooms = Console.ReadLine().Split('|').ToList();
            int health = 100;
            int bitcoins = 0;
            int roomsNum = 0;
            while (true)
            {
                for (int i = 0; i <= rooms.Count; i++)
                {
                   
                    List<string> splitted = rooms[i].Split().ToList();

                    if (splitted[0] == "potion")
                    {
                        health += int.Parse(splitted[1]);
                        if (health > 100)
                        {
                            health = 100;
                        }
                        Console.WriteLine($"You healed for {splitted[1]} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                        roomsNum++;
                    }
                    else if (splitted[0] == "chest")
                    {
                        bitcoins += int.Parse(splitted[1]);
                        Console.WriteLine($"You found {bitcoins} bitcoins.");
                        roomsNum++;
                    }
                    else
                    {
                        health -= int.Parse(splitted[1]);
                        if (health > 0)
                        {
                            Console.WriteLine($"You slayed {splitted[0]}.");
                        }
                        if (health <= 0)
                        {
                            Console.WriteLine($"You died! Killed by {splitted[0]}.");
                            Console.WriteLine($"Best room: {roomsNum + 1}.");
                            
                        }
                        roomsNum++;
                    }
                    if (rooms.Count - 1 == i && health > 0)
                    {
                        Console.WriteLine($"You've made it!,");
                        Console.WriteLine($"Bitcoins: {bitcoins},");
                        Console.WriteLine($"Health: {health}");
                    }
                    
                }
                break;
            }

        }
    }
}
