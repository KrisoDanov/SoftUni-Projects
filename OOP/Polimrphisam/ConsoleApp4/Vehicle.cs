using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public abstract class Vehicle : IVehicles
    {
        private double consumption;
        private double tankCpacity;

        public Vehicle(double quantity, double consumption, double tankCpacity)
        {
            if (quantity > tankCpacity)
            {
                TankCapacity = quantity;
                Quantity = quantity; 
            }
            else
            {
                Quantity = quantity;
                TankCapacity = tankCpacity;
            }
            FuelConsuption = consumption;

        }

        public double Quantity { get; set; }
        public double FuelConsuption { get; set; }
        public double TankCapacity { get; set; }

        public abstract void Drive(double distance);
        public abstract void Refueling(double liters);
        public abstract void DriveEmpty(double distance);


    }
}
