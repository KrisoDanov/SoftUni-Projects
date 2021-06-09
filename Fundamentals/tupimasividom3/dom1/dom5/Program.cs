using System;
using System.Linq;

namespace dom5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

            for (int i = 0; i < number.Length - 1; i++)
            {
               int temp = number[i];
                bool isTopInt = true;
                for (int j = i+ 1; j < number.Length; j++)
                {
                    int othernum = number[j];
                    if (temp > othernum)
                    {
                        isTopInt = false;
                        break;
                    }
                }

                if (isTopInt)
                {
                    Console.WriteLine(temp + " ");
                }
            }
            Console.WriteLine(number[number.Length - 1]);
        }
    }
}
