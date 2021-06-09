using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            double numberFlowers = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double price = 0.00;

            if (flowers == "Roses")
            {
                price = numberFlowers * 5 ;
                if (numberFlowers >= 80)
                {
                    double discount = price * 0.15;
                    price = numberFlowers - discount ;
                }

            }
            else if (flowers == "Dahlias")
            {
                price = numberFlowers * 3.80 ;
                if (numberFlowers >= 90)
                {
                    double discount = price * 0.15;

                    price = price - discount ;
                }



            }
           else if (flowers == "Tulips")
            {
                price = numberFlowers * 2.80 ;
                if (numberFlowers >= 80)
                {
                    double discount = price * 0.15;
                    price = price -  discount ;
                }


            }
            else if (flowers == "Narcissus")
            {
                price = numberFlowers * 3 ;
                if (numberFlowers < 120)
                {
                    double discount = price * 1.15;
                    price = price * 1.15  ;
                }

            }

            else if (flowers == "Gladiolus")
            {
                price = numberFlowers * 2.50 ;
                if (numberFlowers >= 80)
                {
                    double discount = price * 1.25;
                    price = numberFlowers - discount ;
                }
              

            }

           
            if (price > budget)
            {
                double moneyleft = price - budget;
                Console.WriteLine($"Not enough money, you need {Math.Abs(moneyleft):f3} leva more.");
            }
            else
            {
                double moneyleft = budget - price;
                Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {flowers} and {moneyleft:f2} leva left.");
            }
        }
    }
}
