using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public interface IVehicles
    {
        public double Quantity { get; set; }
        public double FuelConsuption { get; set; }
        public double TankCapacity { get; set; }
        public virtual void DriveEmpty(double distance)
        {

        }
    }
}
