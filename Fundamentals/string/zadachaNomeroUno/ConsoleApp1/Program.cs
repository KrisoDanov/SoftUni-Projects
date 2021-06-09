using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string word = "";
            int counter = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                counter++;
                char charecter = input[i];
                
                if (charecter != input[i +1])
                {
                    word += charecter;
                }
                
            }
            word += input[counter];
            Console.WriteLine(word);
        }
    }
}
