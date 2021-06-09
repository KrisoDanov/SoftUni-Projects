using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                string model = carInfo[0];

                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);

                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Tire[] tires = new Tire[4];
                int c = 0;

                for (int j = 5; j < carInfo.Length; j += 2)
                {
                    double tire1Pressure = double.Parse(carInfo[j]);
                    int tire1Age = int.Parse(carInfo[j + 1]);

                    Tire tire = new Tire(tire1Pressure, tire1Age);
                    tires[c++] = tire;

                }

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }
                string command = Console.ReadLine();

                if (command == "fragile")
                {

                   var frigales = cars.Where(x => x.Cargo.CargoType == "fragile").Where(x => x.Tires.Any(p => p.TirePressure < 1));
                    foreach (var item in frigales)
                    {
                        Console.WriteLine($"{item.Model}");
                    }
                }
                if (command == "flamable")
                {

                    var frigales = cars.Where(x => x.Cargo.CargoType == "flamable").Where(x => x.Engine.EnginePower > 250);
                    foreach (var item in frigales)
                    {
                        Console.WriteLine($"{item.Model}");
                    }
                }
            
        }
    }
}
