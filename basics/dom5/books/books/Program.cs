using System;
using System.Diagnostics.CodeAnalysis;

namespace books
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            int countbooks = 0;
            string lookBook = Console.ReadLine();
            bool isbookFound = false;
            while (lookBook != "No More Books")
            {
                
                if (favoriteBook == lookBook)
                {
                    isbookFound = true;
                    break;

                }
                countbooks++;
               
            }
            if (isbookFound)
            {
                Console.WriteLine($"You cheked {countbooks} books and found it");
            }
            else
            {
                Console.WriteLine("The book you search is not here");
                Console.WriteLine($"You cheked {countbooks} books");
            }
        }
    }
}
