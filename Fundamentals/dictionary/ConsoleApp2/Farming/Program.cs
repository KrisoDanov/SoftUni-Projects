using System;
using System.Collections.Generic;
using System.Linq;

namespace Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> itemsLoot =
 new Dictionary<string, int>();

            Dictionary<string, int> junk =
new Dictionary<string, int>();

            string items = Console.ReadLine();

            int Shadowmourne = 250;
            int Valanyr = 250;
            int Dragonwrath = 250;


            while (true)
            {

                List<string> splitted = items.Split(' ').ToList();
                for (int i = 0; i < splitted.Count; i += 2)
                {
                    int qty = int.Parse(splitted[i]);
                    string material = splitted[i + 1].ToLower();
                    if (material == "Shards")
                    {
                        if (itemsLoot.ContainsKey(material))
                        {
                            itemsLoot[material] += qty;
                            Shadowmourne -= qty;
                        }
                    }
                        if (material == "Fragments")
                        {
                      
                            if (itemsLoot.ContainsKey(material))
                            {
                                itemsLoot[material] += qty;
                                Valanyr -= qty;
                            }
                        }
                        if (material == "Motes")
                        {
                           
                            if (itemsLoot.ContainsKey(material))
                            {
                                itemsLoot[material] += qty;
                                Dragonwrath -= qty;
                            }
                        }
                    if (splitted[i] == "Shards" || splitted[i] != "Fragments" || splitted[i] != "Motes")
                    {
                        junk.Add(material, qty);
                    }
                        if (Shadowmourne == 0 || Valanyr == 0 || Dragonwrath == 0 )
                        {
                        Console.WriteLine("item obtained");
                        break;
                        }

                        items = Console.ReadLine();
                    
                }
                foreach (var item in itemsLoot)
                {
                    Console.WriteLine($"{itemsLoot.Keys} : {itemsLoot.Values}");
                }
            }

        }
    }
}
