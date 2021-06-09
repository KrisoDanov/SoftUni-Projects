using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Cars.Contracts
{
    class SportsCar : Car
    {

        public const int MinHorsePpower = 250;
        public const int MaxHorsePpower = 450;
        public const double CubicCentimeters = 3000;

        public SportsCar(string model, int horsePower) 
            : base(model, horsePower, CubicCentimeters, MinHorsePpower, MaxHorsePpower)
        {

        }
    }
}
