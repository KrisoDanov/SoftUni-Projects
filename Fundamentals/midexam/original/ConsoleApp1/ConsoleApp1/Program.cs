using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double students = int.Parse(Console.ReadLine());
            double lectures = int.Parse(Console.ReadLine());
            double bonus = int.Parse(Console.ReadLine());
            double bestStudent = 0;
            double totalBonus = 0;
            double maxTotalBonus = 0;
            for (int i = 0; i < students; i++)
            {
                double attedances = int.Parse(Console.ReadLine());
                if (bestStudent < attedances)
                {
                    bestStudent = attedances;

                }
                totalBonus = attedances / lectures * (5 + bonus);
                if (totalBonus > maxTotalBonus)
                {
                    maxTotalBonus = totalBonus;
                }
                
            }
            Console.WriteLine($"Max Bonus: {Math.Round(maxTotalBonus)}.");
            Console.WriteLine($"The student has attended {bestStudent} lectures.");
        }
    }
}
