using EasterRaces.Models.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Drivers.Contracts
{
    class Driver : IDriver
    {
        private string name;
        private int numberOfWins;
        private bool canParticipate;
        private readonly List<ICar> cars;

        public Driver(string name)
        {
            Name = name;
            cars = new List<ICar>();
        }

        public string Name
        {
            get { return name; }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException($"Name {name} cannot be less than 5 symbols.");
                }
                name = value;
            }
        }


        public ICar Car { get; set; }

        public int NumberOfWins
        {
            get { return numberOfWins; }
            set { value = 0; }
        }

        public bool CanParticipate
            => Car != null;

        public void AddCar(ICar car)
        {

            if (car == null)
            {
                throw new ArgumentException("Car cannot be null.");
            }
            cars.Add(car);
        }

        public void WinRace()
        {
            NumberOfWins++;
        }
    }
}
