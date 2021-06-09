using System;
using System.Linq;

namespace dom3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
     .Split()
     .ToArray();

            string[] words2 = Console.ReadLine()
    .Split()
    .ToArray();

            string common = "";
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words2.Length; j++)
                {
                    if (words[i] == words2[j])
                    {
                        common += words[i] + " ";
                    }
                }
            }
            Console.WriteLine(common);
        }
    }
}
