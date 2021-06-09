using System;

namespace dom3
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp1 = Console.ReadLine();
            string temp2 = Console.ReadLine();
            char start = temp1[0];

            char finish =temp2[0];


            getLetter(start, finish);

        }
        static void getLetter(char start, char finish)
        {
            
            while (start != finish - 1)
            {
               start = (char)(start + 1);

                Console.Write(start + " ");
            }

        }
        
    }
}
