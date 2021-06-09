using System;

namespace secs
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstitme = int.Parse(Console.ReadLine());
            int secondtime = int.Parse(Console.ReadLine());
            int thirdtime = int.Parse(Console.ReadLine());

            int totaltime = firstitme + secondtime + thirdtime;

            int minutes = totaltime / 60;
            int seconds = totaltime % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
