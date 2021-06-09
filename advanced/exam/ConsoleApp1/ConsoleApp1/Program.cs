using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Queue<int> bombEfeect = new Queue<int>(input1);
            Stack<int> bombCasing = new Stack<int>(input2);
            int cherrybomb = 0;
            int daturaBomb = 0;
            int smokeDecoy = 0;
            int current = bombCasing.Peek();
            int current2 = bombEfeect.Peek();
            

            while (bombCasing.Count > 0 ||(cherrybomb <= 3 && daturaBomb <= 3 && smokeDecoy <= 3))
            {

                
                if (current2 + current == 40)
                {
                    daturaBomb++;
                    bombEfeect.Dequeue();
                    bombCasing.Pop();
                    try
                    {
                        current = bombCasing.Peek();
                        current2 = bombEfeect.Peek();
                    }
                    catch (Exception)
                    {

                        break; ;
                    }
                }
                else if (current2 + current == 60)
                {
                    cherrybomb++;
                    bombEfeect.Dequeue();
                    bombCasing.Pop();
                    try
                    {
                        current = bombCasing.Peek();
                        current2 = bombEfeect.Peek();
                    }
                    catch (Exception)
                    {

                        break; ;
                    }
                }
                else if (current2 + current == 120)
                {
                    smokeDecoy++;
                    bombEfeect.Dequeue();
                    bombCasing.Pop();
                    try
                    {
                        current = bombCasing.Peek();
                        current2 = bombEfeect.Peek();
                    }
                    catch (Exception)
                    {

                        break; ;
                    }
                   
                }
                else
                {
                   current -= 5;
                }
                
            }
            if (smokeDecoy >= 3 && cherrybomb >= 3 && daturaBomb >= 3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            if (bombEfeect.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                foreach (var item in bombEfeect)
                {
                    Console.WriteLine(string.Join(", ", $"Bomb Effects: {item}"));
                }
            }
            if (bombCasing.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                foreach (var item in bombCasing)
                {
                    Console.WriteLine(string.Join(", ", $"Bomb Cassing: {item}"));
                }
            }

            Console.WriteLine($"Cherry Bombs: {cherrybomb}");
            Console.WriteLine($"Datura Bombs: {daturaBomb}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoy}");
        }
    }
}
