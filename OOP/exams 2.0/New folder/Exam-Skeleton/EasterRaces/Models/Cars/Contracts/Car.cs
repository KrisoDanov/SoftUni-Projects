using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Cars.Contracts
{
    public class Car : ICar
    {
        private string model;
        private int minHorsePower;
        private int maxHorsePower;


        public Car(string model, int horsePower, double cubicCentimeters, int minHorsePower, 
            int maxHorsePower)
        {
            Model = model;
            HorsePower = horsePower;
            CubicCentimeters = cubicCentimeters;

            this.minHorsePower = minHorsePower;
            this.maxHorsePower = maxHorsePower;
        }
        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 4)
                {
                    throw new ArgumentException("Model {model} cannot be less than 4 symbols.");
                }
                model = value;
            }
        }


        private int horsePower;

        public int HorsePower
        {
            get { return horsePower; }
            set 
            {
                if (true)
                {
                    horsePower = value;
                }
                else
                {
                    throw new ArgumentException($"Invalid horse power: {horsePower}.");
                }
               
            }
        }


        public double CubicCentimeters { get; set; }
        public double CalculateRacePoints(int laps)
        {
            double racePoints = CubicCentimeters / HorsePower * laps;
            return racePoints;
        }
    }
}
