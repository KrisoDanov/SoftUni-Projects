using System;
using System.Linq;

namespace diff_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number1 = Console
     .ReadLine()
     .Split()
     .Select(int.Parse)
     .ToArray();

            int[] number2 = Console
     .ReadLine()
     .Split()
     .Select(int.Parse)
     .ToArray();
            //int temp1 = 0;
            //int temp2 = 0;

            int i = 0;
            while (i < number1.Length && i < number2.Length)
            {
                if (number1[i] == number2[i])
                {
                    Console.WriteLine($"+ {number1[i]} {number2[i]}");
                }
                else
                {
                    Console.WriteLine($"- {number1[i]} { number2[i]}");
                }

                i++;
            }
            if (number1.Length == i)
            {
                for (int j = i; j < number2.Length; j++)
                {
                    Console.WriteLine($"- {number2[i]} x");
                }
            }
            else if (number2.Length == i)
            {
                for (int j = i; j < number1.Length; j++)
                {
                    Console.WriteLine($"- {number1[i]} x");
                }
            }
        }
    
        
    }
}
