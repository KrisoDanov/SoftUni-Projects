using System;
using System.Collections.Generic;

namespace ednoo
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string kriso = word;
            string input = Console.ReadLine();
            while (input != "Decode")
            {
                string[] split = input.Split("|");
                if (split[0] == "Move")
                {
                    kriso.Remove(0, int.Parse(split[1]));
                    string reverse = "";
                    int n = word.Length - int.Parse(split[1]);
                    for (int i = word.Length - 1; i >= n; i--)
                    {
                        reverse += word[i];

                    }
                    for (int i = 0; i < n; i++)
                    {
                        reverse += word[i];

                    }
                    word = reverse;
                }
                if (split[0] == "Insert")
                {
                    word = word.Insert(int.Parse(split[1]), split[2]);
                }
                if (split[0] == "ChangeAll")
                {
                    word = word.Replace(split[1], split[2]);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {word}");
        }
    }
}
