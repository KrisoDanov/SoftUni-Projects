using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class Car
    {
        public Car(string manufacture, string model, int year)
        {
            this.Manufacture = manufacture;
            this.Model = model;
            this.Year = year;
        }
        public string Manufacture { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return $"{Manufacture} {Model} ({Year})";

        }
    }
    
}
