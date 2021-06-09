using System;
using System.Collections.Generic;
using System.Linq;

namespace dom3
{
    class Program
    {
        static void Main(string[] args)
        {
           List<string> input = Console.ReadLine().Split("\\").ToList();
            for (int i = 0; i < input.Count; i++)
            {

                if (input[i].Contains("."))
                {
                    List<string> splitted = input[i].Split(".").ToList();
                    string place = splitted[0];
                    string type = splitted[1];
                    Console.WriteLine($"File name: {place}");
                    Console.WriteLine($"File extension: {type}"); 
                }

            }
            
        }
    }
}
