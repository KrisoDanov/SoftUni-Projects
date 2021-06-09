using System;
using System.Collections.Generic;
using System.Linq;

namespace dom6
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").ToArray();
            Queue<string> songs = new Queue<string>(input);
            var comands = Console.ReadLine();
            while (songs.Count > 0)
            {
                if (comands.Contains("Play"))
                {
                    songs.Dequeue();
                }
                if (comands.Contains("Add"))
                {
                    var add = comands.Split("Add ");
                    if (!songs.Contains(add[1]))
                    {

                        songs.Enqueue(add[1]);
                    }
                    else
                    {
                        Console.WriteLine($"{add[1]} is already contained!");
                    }
                }
                if (comands.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
                comands = Console.ReadLine();
                
            }
            Console.WriteLine("No more songs!");
        }
    }
}
