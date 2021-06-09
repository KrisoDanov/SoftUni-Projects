using System;

namespace FoodStorage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            
            while (input[0] != "End")
            {

                Citizen citizen = new Citizen(input[0]);
                Console.WriteLine(((IPerosn)citizen).GetName());
                Console.WriteLine(((IResident)citizen).GetName());
                input = Console.ReadLine().Split();
            }
        }
    }
}
