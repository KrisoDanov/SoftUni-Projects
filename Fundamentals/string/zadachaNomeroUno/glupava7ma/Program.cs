using System;
using System.Collections.Generic;
using System.Linq;

namespace glupava7ma
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           
            string empty = "";
            
            for (int i = 0; i < input.Length; i++)
            {
                char word = input[i];
                    if (char.IsDigit(word))
                    {
                    int place = input[i];
                    int boom = input[i];
                    input.Remove(place, boom);
                    }
                    empty += word;

            }
            Console.WriteLine(empty);
        }
    }
}
