using System;

namespace dom5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            SumTheNumbers(num1, num2, num3);
        }
        static void SumTheNumbers(int num1, int num2, int num3)
        {
            int temp = (num1 + num2) - num3;
            Console.WriteLine(temp);
        }
    }
}
