using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Truck : Vehicle
    {

        private const double IncreasedTruckFuelConsuption = 1.6;
        public Truck(double quantity, double consumption, double tankCpacity) 
            : base(quantity, consumption, tankCpacity)
        {
        }


        public override void Drive(double distance)
        {
            if (Quantity < distance * (FuelConsuption + IncreasedTruckFuelConsuption))
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
            else
            {
                Quantity -= distance * (FuelConsuption + IncreasedTruckFuelConsuption);
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
                    Quantity += liters * 0.95;
                }
            }
            
        }
    }
}
