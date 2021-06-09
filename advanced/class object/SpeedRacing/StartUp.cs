using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] inputt = Console.ReadLine().Split();
                string model = inputt[0];
                double fuelAmount = double.Parse(inputt[1]);
                double fuelConsump1Km = double.Parse(inputt[2]);
                Car car = new Car(model, fuelAmount, fuelConsump1Km);
                cars.Add(car);
            }
            var input = Console.ReadLine();
            while (input != "End")
            {
                string[] data = input.Split();
                string model = data[1];
                int ammaountOfkm = int.Parse(data[2]);
                Car car = cars.FirstOrDefault(x => x.Model == model);

                car.Drive(ammaountOfkm);

                input = Console.ReadLine();

            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
