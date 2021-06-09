using System;

namespace mmsmm
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string vhod = Console.ReadLine();
            string izhod = Console.ReadLine();

            double result = 0;

            if (vhod == "mm" && izhod == "cm")
            {
                result = number / 10; ;
            }

            else if (vhod == "mm" && izhod == "m")
            {
                result = number / 1000;
            }
            else if (vhod == "m" && izhod == "mm")
            {
                result = number * 1000;
            }
            else if (vhod == "m" && izhod == "cm")
            {
                result = number * 100;
            }
            else if (vhod == "cm" && izhod == "m")
            {
                result = number / 100;
            }
            else if (vhod == "cm" && izhod == "mm")
            {
                result = number * 10;
            }
            Console.WriteLine($"{result:f3}");

        }
    }
}
