using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> evenInt = Console.ReadLine().Split('@').Select(int.Parse).ToList();

            string input = Console.ReadLine();
            int moves = 0;
            int fails = 0;
            while (input != "Love!")
            {
                List<string> splitted = input.Split().ToList();

                moves = int.Parse(splitted[1]);

                if (evenInt.Count <= moves)
                {
                    //moves = -evenInt.Count;
                    //if (moves > 0)
                    //{
                    //    moves *= -1;
                    //}
                    moves = 0;
                }
                for (int i = 0; i < evenInt.Count; i++)
                {
                    if (i == moves)
                    {
                        if (evenInt[i] == 0)
                        {
                            Console.WriteLine($"Place {i} already had Valentine's day.");
                            continue;
                        }
                        evenInt[i] -= 2;
                        if (evenInt[i] == 0)
                        {

                            Console.WriteLine($"Place {i} has Valentine's day.");
                            if (evenInt[i] > 0)
                            {
                                fails ++;
                                if (fails > 0)
                                {
                                    Console.WriteLine($"Cupid has failed {fails} places.");
                                }
                                else
                                {
                                    Console.WriteLine($"Cupid has failed {fails} places.");
                                }
                            }
                        }
                    }

                }
                input = Console.ReadLine();
                
            }

            //Cupid's last position was 1.
            //Cupid has failed 1 places.
            Console.WriteLine($"Cupid's last position was ");
            
        }
    }
}
