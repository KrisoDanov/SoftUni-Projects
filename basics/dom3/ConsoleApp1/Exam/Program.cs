using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());

            TimeSpan exam = new TimeSpan(examHour, examMin, 0);
            TimeSpan arrival = new TimeSpan(arrivalHour, arrivalMin, 0);
            TimeSpan result = new TimeSpan();

            if (arrival > exam)
            {
                Console.WriteLine("Late");
                result = arrival - exam;
                if (result.TotalMinutes < 60)
                {
                    Console.WriteLine("{0} minutes after the start", result.TotalMinutes);
                }
                else
                {
                    Console.WriteLine("{0} hours after the start", result.ToString(@"h\:mm"));
                }
            }
            else if (arrival == exam || (exam - arrival).TotalMinutes <= 30)
            {
                Console.WriteLine("On time");
                if (arrival != exam)
                {
                    result = exam - arrival;
                    Console.WriteLine("{0} minutes before the start", result.TotalMinutes);
                }
            }
            else if (exam > arrival)
            {
                Console.WriteLine("Early");
                result = exam - arrival;
                if (result.TotalMinutes < 60)
                {
                    Console.WriteLine("{0} minutes before the start", result.TotalMinutes);
                }
                else if (result.TotalMinutes >= 60)
                {
                    Console.WriteLine("{0} hours before the start", result.ToString(@"h\:mm"));
                }
            }

        }

    }
}