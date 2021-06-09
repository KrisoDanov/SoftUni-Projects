using EasterRaces.Models.Drivers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Models.Races.Contracts
{
    public class Race : IRace
    {
        private string name;
        private readonly List<IDriver> drivers;

        public Race(string name, int laps)
        {
            this.Name = name;
            Laps = laps;
            drivers = new List<IDriver>();
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


        private int laps;

        public int Laps
        {
            get { return laps; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Laps cannot be less than 1.");
                }
                laps = value;
            }
        }


        public IReadOnlyCollection<IDriver> Drivers
            => this.drivers;

        public void AddDriver(IDriver driver)
        {
           
            if (driver == null)
            {
                throw new ArgumentException("Driver cannot be null.");
            }
            if (driver.CanParticipate)
            {
                throw new ArgumentException($"Driver {driver.Name} could not participate in race.");
            }
            if (drivers.Any(x => x.Name == driver.Name))
            {
                throw new ArgumentException($"Driver {driver.Name} is already added in {this.Name} race.");
            }
            drivers.Add(driver);
        }
    }
}
