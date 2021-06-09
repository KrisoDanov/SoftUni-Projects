using System;
using System.Linq;

namespace dom7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console
                 .ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int temp = 0;
            int add = 1;
            string common = "";


            for (int i = 0; i < number.Length; i++)
            {
                temp = number[i];
                for (int j = temp + 1; j < number.Length; j++)
                {
                    if (temp == number[j])
                    {
                        add++;

                    }
                    else
                    {
                        add = 1;
                    }

                }
            }
            Console.WriteLine(add);

            //int temp1 = 0;
            //int temp2 = 0;

            //for (int i = 0; i < number2.Length; i++)
            //{
            //    temp1 = number1[i];

            //        temp2 = number2[i];
            //        if (number1[i] == number2[i])
            //        {
            //            Console.WriteLine($"+{temp1} {temp2}");
            //        }
            //    else
            //    {
            //        Console.WriteLine($"-{temp1} {temp2}");
            //    }
            //    if (number2 ==)
            //    {

            //    }

        }
    }
}
