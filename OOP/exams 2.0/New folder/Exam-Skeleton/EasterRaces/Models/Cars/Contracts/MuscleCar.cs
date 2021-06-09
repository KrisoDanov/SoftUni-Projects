using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Cars.Contracts
{

    
    class MuscleCar : Car
    {
        public const int MinHorsePpower = 400;
        public const int MaxHorsePpower = 600;
        public const double CubicCentimeters = 5000;

        public MuscleCar(string model, int horsePower)
            : base(model, horsePower, CubicCentimeters, MinHorsePpower, MaxHorsePpower)
        {
        }
    }
}
