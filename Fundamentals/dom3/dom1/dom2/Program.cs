using System;

namespace dom2
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            word=word.ToLower();


            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                
                if (VowelsLetters(word[i]))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        static bool VowelsLetters(char letter)
        {
            return letter == 'a' || letter == 'e'
                || letter == 'i' || letter == 'o'
                || letter == 'u';
        }
    }
}
