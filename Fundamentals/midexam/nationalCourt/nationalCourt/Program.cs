using System;

namespace nationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int people1 = int.Parse(Console.ReadLine());
            int people2 = int.Parse(Console.ReadLine());
            int people3 = int.Parse(Console.ReadLine());
            int maxPower = people1 + people2 + people3;
            int totalPeople = int.Parse(Console.ReadLine());
            int time = 0;

            while (totalPeople > 0)
            {
                time++;
                if (time % 4 == 0)
                {
                    continue;
                }
               

                totalPeople -= maxPower;


            }
            Console.WriteLine($"Time needed: {time}h.");
        }
    }
}
