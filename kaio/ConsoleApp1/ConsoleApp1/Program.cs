using System;
using System.Collections.Generic;
using System.Diagnostics;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            Chronometer chronometer = new Chronometer();
            string command = Console.ReadLine();
            List<string> laps = new List<string>();
            int n = 0;
            while (command != "exit")
            {
                if (command == "start")
                {
                    chronometer.Start(timer);
                }

                if (command == "stop")
                {
                    chronometer.Stop(timer);
                }

                if (command == "lap")
                {
                    chronometer.Lap(timer, laps);
                }

                if (command == "reset")
                {
                    chronometer.Reset(timer);
                }

                if (command == "laps")
                {
                    foreach (var item in laps)
                    {
                        
                        Console.WriteLine($"{n} {item}");
                        n++;
                    }
                }


                command = Console.ReadLine();
            }
        }

    }
}
