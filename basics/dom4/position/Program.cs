using System;

namespace position
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double oddSum = 0.00;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;

            double evenSum = 0.00;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            if (n == 0)
            {
                Console.WriteLine(" OddSum = 0.00,");
                Console.WriteLine("OddMin = No,");
                Console.WriteLine("OddMax = No,");
                Console.WriteLine("EvenSum = 0.00,");
                Console.WriteLine("EvenMin = No,");
                Console.WriteLine("EvenMax = No");

            }

            else
            {
                for (int i = 1; i <= n; i++)
                {
                    double curentNum = double.Parse(Console.ReadLine());

                    if (i % 2 == 0)
                    {
                        evenSum += curentNum;
                        if (curentNum > evenMax)
                        {
                            evenMax = curentNum;
                        }
                        if (curentNum < evenMin)
                        {
                            evenMin = curentNum;
                        }
                    }
                    else
                    {
                        oddSum += curentNum;
                        if (curentNum > oddMax)
                        {
                            oddMax = curentNum;
                        }
                        if (curentNum < oddMin)
                        {
                            oddMin = curentNum;
                        }
                    }
                    
                }

            }
            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddSum ==0)
            {
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
         
            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (evenSum == 0)
            {
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }



        }  
    }
}
