using System;
using System.Dynamic;
using System.Linq.Expressions;

namespace numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            double result = 0.00;
            if (symbol == '+')
            {
                result = N1 + N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} + {N2} = {result} - even");
                }
                else if (result % 2 != 0)
                {
                    Console.WriteLine($"{N1} + {N2} = {result} - odd");
                }

            }
            else if (symbol == '-')
            {
                result = N1 - N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} - {N2} = {result} - even");
                }
                else if (result % 2 != 0)
                {
                    Console.WriteLine($"{N1} - {N2} = {result} - odd");
                }

            }
            else if (symbol == '*')
            {
                result = N1 * N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} * {N2} = {result} - even");
                }
                else if (result % 2 != 0)
                {
                    Console.WriteLine($"{N1} * {N2} = {result} - odd");
                }

            }
            else if (symbol == '/')
            {
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }

                else
                {
                    result = N1 / N2;

                    Console.WriteLine($"{N1} / {N2} = {result:f2}");
                }
            }
            else if (symbol == '%')
            {
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
               else     
                    {
                    result = N1 % N2;
                    Console.WriteLine($"{N1} % {N2} = {result} ");
                    }

            }
            


        }
    }
}
