using System;

namespace worldrecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double cel = distance * time;
            double zabavqne = (distance / 15) * 12.5;
            double result = cel + zabavqne;

            double vreme = result - record;
           
            
            if (record > result)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {vreme:f2} seconds.");
            }

            else if (record < result)
            {
                Console.WriteLine($"No, he failed! He was {vreme:f2} seconds slower.");
            }
        }
    }
}
