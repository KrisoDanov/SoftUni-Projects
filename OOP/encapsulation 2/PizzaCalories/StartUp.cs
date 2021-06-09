using System;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            
            string[] pizzaname = Console.ReadLine().Split();
           
            string[] input1 = Console.ReadLine().Split();
            
            Dough dough = new Dough(input1[1].ToLower(), input1[2].ToLower(), double.Parse(input1[3]));
            
            var resultat = dough.GetCalories();

            double allToppingCal = 0;
            int counter = 0;
            string[] input2 = Console.ReadLine().Split();
            while (input2[0] != "END")
            {
                double calll = double.Parse(input2[2]);
            Topping toping = new Topping(input2[1].ToLower(), double.Parse(input2[2]));
            var result2 = toping.getToppingCal();

                allToppingCal += result2;
                input2 = Console.ReadLine().Split();

                counter++;
                if (counter == 10)
                {
                    Console.WriteLine("Number of toppings should be in range [0..10].");
                    break;
                }
            }
            if (counter < 10)
            {
            double final = allToppingCal + resultat;
            Console.WriteLine($"{pizzaname[1]} - {final:f2} Calories.");

            }
        }
    }
}
