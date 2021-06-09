using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Car : Vehicle
    {
        private const double IncreasedCarFuelConsuption = 0.9;
        public Car(double quantity, double consumption, double tankCpacity) : 
            base(quantity, consumption, tankCpacity)
        {
        }

       
        public override void Drive(double distance)
        {
            if (Quantity < distance * (FuelConsuption + IncreasedCarFuelConsuption))
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
            else
            {
                Quantity -= distance * (FuelConsuption + IncreasedCarFuelConsuption);
                Console.WriteLine($"{GetType().Name} travelled {distance} km");
            }

        }

        public override void DriveEmpty(double distance)
        {
            
        }

        public override void Refueling(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                if (TankCapacity < liters + Quantity)
                {
                    Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                }
                else
                {
                    Quantity += liters;
                    
                }
            }
           
        }
    }
}
