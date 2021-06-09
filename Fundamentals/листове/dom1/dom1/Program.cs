using System;
using System.Linq;
using System.Collections.Generic;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagonsWithPassengers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int index = 0;

            while (input != "end")
            {
                string phr = "";
                string numToParse = "";
                int numberToFit = 0;

                if (input.Contains("Add "))
                {
                    phr = "Add";
                    numToParse = input.Remove(0, 3);
                    numberToFit = int.Parse(numToParse);
                }
                else
                {
                    numberToFit = int.Parse(input);
                }

                if (phr == "Add")
                {
                    wagonsWithPassengers.Add(numberToFit);
                }
                else
                {

                    if (wagonsWithPassengers[index] < maxCapacity && wagonsWithPassengers[index] + numberToFit <= maxCapacity)
                    {
                        wagonsWithPassengers[index] += numberToFit;
                    }
                    else
                    {
                        wagonsWithPassengers[index + 1] += numberToFit;
                    }

                }

                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", wagonsWithPassengers));
        }
    }
}