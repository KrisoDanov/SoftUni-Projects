using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    class Car
    {
        public Car(string model, double fuelAmount, double fuelConsuptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsuptionPerKilometer = fuelConsuptionPerKilometer;
            TravelledDistance = 0;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsuptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public void Drive(int amountOfKm)
        {
            if (FuelAmount -(FuelConsuptionPerKilometer * amountOfKm) >= 0)
            {
                FuelAmount -= (FuelConsuptionPerKilometer * amountOfKm);
                TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
    
}
