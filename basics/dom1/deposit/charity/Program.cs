using System;

namespace charity
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberdays = int.Parse(Console.ReadLine());
            int numberchef = int.Parse(Console.ReadLine());
            int cakenumber = int.Parse(Console.ReadLine());
            int pancakenumber = int.Parse(Console.ReadLine());
            int palachinkinumber = int.Parse(Console.ReadLine());

            double cake1day = cakenumber * 45;
            double pancakes1day = pancakenumber * 5.8;
            double palachinki1day = palachinkinumber * 3.2;
            double all1day = (cake1day + pancakes1day + palachinki1day) * numberchef;
            double allforall = all1day * numberdays;
            double expenses = 1 / 8.0;
            double allend = allforall - (allforall * expenses);
            Console.WriteLine(allend);

        }
    }
}
