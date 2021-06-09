using System;
using System.Linq;

namespace shamuebakaikata
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());

            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());

            int product1 = (num1 / 100) * ((num1 % 100) / 10) * ((num1 % 100) % 10);
            int product2 = (num2 / 100) * ((num2 % 100) / 10) * ((num2 % 100) % 10);
            int product3 = (num3 / 100) * ((num3 % 100) / 10) * ((num3 % 100) % 10);
            int product4 = (num4 / 100) * ((num4 % 100) / 10) * ((num4 % 100) % 10);
            int product5 = (num5 / 100) * ((num5 % 100) / 10) * ((num5 % 100) % 10);

            int num11 = 0;
            int num12 = 0;
            int num13 = 0;
            int num14 = 0;
            int num15 = 0;


            for (int i = 0; i < 3; i++)
            {

            }
            int readyNum1 = 0;
            int readyNum2 = 0;
            int readyNum3 = 0;
            int readyNum4 = 0;
            int readyNum5 = 0;


            if (num11 < 10)
            {
                readyNum1 = product1 % 10;
            }
            if (num12 < 10)
            {
                readyNum2 = product2 % 10;
            }
            if (num13 < 10)
            {
                readyNum3 = product3 % 10;
            }
            if (num14 < 10)
            {
                readyNum4 = product4 % 10;
            }
            if (num15 < 10)
            {
                readyNum5 = product5 % 10;
            }
            
            Console.WriteLine($"{readyNum1}{readyNum2}{readyNum3}{readyNum4}{readyNum5}");
        }
    }
}
