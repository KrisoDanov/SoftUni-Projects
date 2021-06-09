using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            while (input != "Craft!")
            {
                List<string> separate = input.Split(" - ").ToList();

               
                if (separate[0] == "Collect")
                {
                        if (!items.Contains(separate[1]))
                        {
                            items.Add(separate[1]);
                        }
                }
                if (separate[0] == "Drop")
                {
                    items.Remove(separate[1]);
                }
                if (separate[0] == "Combine Items")
                {
                    for (int i = 0; i < items.Count; i++)
                    {

                            List<string> separatee = separate[1].Split(":").ToList();

                            if (items[i].Contains(separatee[0]))
                            {
                                items.Insert(i + 1, separatee[1]);
                            }
                        
                    }

                }
                if (separate[0] == "Renew")
                {
                    items.Remove(separate[1]);
                    items.Add(separate[1]);
                }
                input = Console.ReadLine();
            }

                Console.Write(String.Join(", ", items));

            

        }
    }
}
