using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopList = Console.ReadLine().Split('!').ToList();

            string input = Console.ReadLine();
            while (input != "Go Shopping!")
            {
                List<string> splitted = input.Split().ToList();
                if (splitted[0] == "Urgent")
                {

                    if (!shopList.Contains(splitted[1]))
                    {
                        shopList.Insert(0, splitted[1]); ;
                    }
                }
                if (splitted[0] == "Unnecessary")
                {
                    shopList.Remove(splitted[1]);
                }
                if (splitted[0] == "Correct")
                {

                    for (int i = 0; i < shopList.Count; i++)
                    {
                        if (shopList[i] == splitted[1])
                        {
                            shopList.Remove(shopList[i]);
                            shopList.Insert(i, splitted[2]);
                        }
                    }
                }
                if (splitted[0] == "Rearrange")
                {
                    for (int i = 0; i < shopList.Count; i++)
                    {
                        if (shopList[i] == splitted[1])
                        {
                            shopList.Remove(shopList[i]);
                            shopList.Add(splitted[2]);

                        }
                    }
                    //shopList.Remove(splitted[1]);
                    //for (int i = 0; i < shopList.Count; i++)
                    //{
                    //    shopList.Insert(shopList.Count, splitted[2]);
                    //}

                }
                input = Console.ReadLine();

            }


            Console.Write(string.Join(", ", shopList));
            
            
        }
    }
}
