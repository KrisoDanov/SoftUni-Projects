using System;
using System.Diagnostics.CodeAnalysis;

namespace hotelroom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double days = double.Parse(Console.ReadLine());

            double costapp = 0.00;
            double coststud = 0.00;
            if (month == "May" || month ==  "October")
            {
                coststud = days * 50;
                costapp = days * 65;
                if (days > 7 && days <= 14)
                {
                    coststud *= 0.95;

                }
                else if (days > 14) ;
                {
                    coststud *= 0.70;
                    costapp = (days * 75.20) * 0.10;
                }


            }
          else if (month == "June" || month == "September")
            {
                coststud = days * 75.20;
                costapp = days * 68.70;
                if (days > 14)
                {
                    coststud *= 0.8;
                }
            }
           else if (month == "July" || month == "August")
            {
               
                

                    coststud = days * 76;
                    costapp = days * 77;
                
               
            }
            if (days > 14)
            {
                costapp *= 0.9;
            }
             Console.WriteLine($"Apartment: {costapp:f2} lv.");
            Console.WriteLine($"Studio: {coststud:f2} lv.");

        }
    }
}
