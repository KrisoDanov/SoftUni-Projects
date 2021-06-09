using System;
using System.Collections.Generic;
using System.Linq;

namespace dom4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.
                RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmArgs = command
                   .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();

                string cmType = cmArgs[0];
                if (cmType == "Add ")
                {
                    int numberToAppend = int.Parse
                }
                else if (cmType == "Insert ")
                {

                }
                else if (cmType == "Remove ")
                {

                }
                else if (cmType == "Shift ")
                {

                }
            }
        }
    }
}
