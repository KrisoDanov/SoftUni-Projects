using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace nomeroDos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> emoji = new List<string>();
            List<int> numbers = new List<int>();

            string input = Console.ReadLine();
            string patern = @"([:]{2}|[*]{2})(?<name>[A-Z][a-z]{2,})\1|(?<number>\d+)";

            Match match = Regex.Match(input, patern);
            if (match.Success)
            {
                string emojii = match.Groups["name"].Value;
                emoji.Add(emojii);
                int number = int.Parse(match.Groups["number"].Value);
                numbers.Add(number);
                
                for (int i = emoji.Count - 1; i >= 0; i--)
                {
                    
                }
            }
            foreach (var item in emoji)
            {
                Console.WriteLine(item);
            }
        }
    }
}
