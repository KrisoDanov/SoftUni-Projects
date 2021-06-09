using System;
using System.Linq;

namespace dom4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =  int.Parse(Console.ReadLine());

            string roll1 = "";
            string roll2 = "";

            for (int i = 0; i < n; i++)
            {
               int[] newarr = (Console.ReadLine())
                .Split()
                .Select(int.Parse)
                .ToArray();

                for (int j = 0; j < newarr.Length; j++)
                {

                    if (i % 2 == 0)
                    {
                        roll1 += newarr[0] + " ";
                        roll2 += newarr[1] + " ";
                    }
                    if (i % 2 == 1)
                    {
                        roll2 += newarr[0] + " ";
                        roll1 += newarr[1] + " ";
                    }
                    break;



                }
            }
            Console.WriteLine(roll1);
            Console.WriteLine(roll2);
        }

    }
}
