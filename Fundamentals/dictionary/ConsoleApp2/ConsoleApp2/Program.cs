using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charsInString = 
                new Dictionary<char, int>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char split = input[i];

                if (split!= ' ')
                {

                    if (!charsInString.ContainsKey(split))
                    {
                        // charsInString[split] = 0;
                        charsInString.Add(split, 0);
                    }
                    charsInString[split]++;
                }

            }
            foreach (var letter in charsInString)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
