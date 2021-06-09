using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EasterRaces.Core.Contracts
{
    class ChampionshipController : IChampionshipController
    {
        private readonly IRepository<IDriver> driverRepository;
        private readonly IRepository<ICar> carRepository;
        private readonly IRepository<IRace> raceRepository;
        public ChampionshipController()
        {
            driverRepository = new DriverRepository();
            carRepository = new CarRepository();
            raceRepository = new RaceRepository();
        }
        public string AddCarToDriver(string driverName, string carModel)
        {
            var car = carRepository.GetByName(carModel);
            var driver = driverRepository.GetByName(driverName);
            if (car == null)
            {
                throw new InvalidOperationException($"Car {carModel} could not be found.");
            }
            if (driver == null)
            {
                throw new InvalidOperationException($"Driver {driverName} could not be found.");
            }
            else
            {
                driver.AddCar(car);
                carRepository.Remove(car);
                return $"Driver {driver.Name} received car {car.Model}.";
            }
        }

        public string AddDriverToRace(string raceName, string driverName)
        {
            var driver = driverRepository.GetByName(driverName);
            var race = raceRepository.GetByName(raceName);
            if (race == null)
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }
            if (driver == null)
            {
                throw new InvalidOperationException($"Driver {driverName} could not be found.");
            }
            else
            {
                race.AddDriver(driver);
                return $"Driver {driverName} added in {raceName}.";
            }
        }

        public string CreateCar(string type, string model, int horsePower)
        {
            if (type == "Muscle")
            {
                if (carRepository.GetByName(model) == null)
                {
                    var car = new MuscleCar(model, horsePower);
                    carRepository.Add(car);
                    return $"MusleCar {model} is created.";
                }
                else
                {
                    throw new ArgumentException($"Car {model} is already created.");
                }
            }
            if (type == "Sports")
            {
                if (carRepository.GetByName(model) == null)
                {
                    var car = new SportsCar(model, horsePower);
                    carRepository.Add(car);
                    return $"Sports {model} is created.";
                }
                else
                {
                    throw new ArgumentException($"Car {model} is already created.");
                }
            }
            else
            {
                throw new ArgumentException($"Car {model} is already created.");
            }
        }

        public string CreateDriver(string driverName)
        {
            if (driverRepository.GetByName(driverName) == null)
            {
                var driver = new Driver(driverName);
                driverRepository.Add(driver);
                return $"Driver {driverName} is created.";
            }
            else
            {
                throw new ArgumentException($"Driver {driverName} is already created.");
            }
        }

        public string CreateRace(string name, int laps)
        {
            if (raceRepository.GetByName(name) == null)
            {
                var race = new Race(name, laps);
                raceRepository.Add(race);
                return $"Race {name} is created.";
            }
            else
            {
                throw new ArgumentException($"Race {name} is already created.");
            }
        }

        public string StartRace(string raceName)
        {
            var race = raceRepository.GetByName(raceName);
            if (raceRepository.GetByName(raceName) == null)
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }
            if (driverRepository.GetAll().Count < 3)
            {
                throw new InvalidOperationException($"Race {raceName} cannot start with less than 3 participants.");
            }

            var finalResult = race.Drivers
                .OrderByDescending(x => x.Car.CalculateRacePoints(race.Laps))
                .Take(3)
                .ToList();

            var first = finalResult[0];
            var second= finalResult[1];
            var third = finalResult[2];

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Driver {first.Name} wins {raceName} race.");
            sb.AppendLine($" Driver {second.Name} is second in {raceName} race.");
            sb.AppendLine($"Driver {third.Name} is third in {raceName} race.");

            var result = sb.ToString().TrimEnd();

            return result;

        }
    }
}
 