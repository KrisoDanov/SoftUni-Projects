using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    class Tire
    {
        public Tire(double tirePressure , int tireAge)
        {
            TireAge = tireAge;
            TirePressure = tirePressure;
        }

        public double TirePressure { get; set; }
        public int TireAge { get; set; }
    }
}
