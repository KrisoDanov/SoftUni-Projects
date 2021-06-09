using System;
using System.Collections.Generic;
using System.Linq;

namespace dom6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cars> listCars = new List<Cars>();
            List<Truck> listTrucks = new List<Truck>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "End")
                {
                    while (true)
                    {

                        string models = Console.ReadLine();
                        if (models == "Close the Catalogue")
                        {

                            int truckcount = listTrucks.Count();
                            int carscount = listCars.Count();
                            double carshorsepower = listCars.Sum(x => x.HorsePower);
                            double truchorsepower = listCars.Sum(x => x.HorsePower);
                            Console.WriteLine($"Cars have average horsepower of {carshorsepower / carscount:F2}.");
                            Console.WriteLine($"Trucks have average horsepower of {truchorsepower/ truckcount:F2}.");
                            break;

                        }
                        Cars car = listCars.FirstOrDefault(x => x.Model == models);
                        
                        Truck truck = listTrucks.FirstOrDefault(x => x.Model == models);
                        if (car != null)
                        {
                            Console.WriteLine($"{car.TypeOfVohicle}");
                            Console.WriteLine($"{car.Model}");
                            Console.WriteLine($"{car.ColorOfVehicle}");
                            Console.WriteLine($"{car.HorsePower}");
                        }

                        if (truck != null)
                        {
                            Console.WriteLine($"{truck.TypeOfVohicle}");
                            Console.WriteLine($"{truck.Model}");
                            Console.WriteLine($"{truck.ColorOfVehicle}");
                            Console.WriteLine($"{truck.HorsePower}");
                        }

                    }
                    
                }
                if (input[0] == "Car")
                {
                    Cars separate = new Cars(input[0], input[1], input[2], double.Parse(input[3]));
                    listCars.Add(separate);
                   

                }
                if (input[0] == "Truck")
                {
                    Truck separate = new Truck(input[0], input[1], input[2], double.Parse(input[3]));
                    listTrucks.Add(separate);
                   
                }

            }

        }
    }
    class Cars
    {
        public Cars(string typeOfVohicle, string model, string colorOfVehicle, double horsePower)
        {
            this.TypeOfVohicle = typeOfVohicle;
            this.Model = model;
            this.ColorOfVehicle = colorOfVehicle;
            this.HorsePower = horsePower;
        }
        public string TypeOfVohicle { get; set; }
        public string Model { get; set; }
        public string ColorOfVehicle { get; set; }
        public double HorsePower { get; set; }

    }
    class Truck
    {
        public Truck(string typeOfVohicle, string model, string colorOfVehicle, double horsePower)
        {
            this.TypeOfVohicle = typeOfVohicle;
            this.Model = model;
            this.ColorOfVehicle = colorOfVehicle;
            this.HorsePower = horsePower;
        }
        public string TypeOfVohicle { get; set; }
        public string Model { get; set; }
        public string ColorOfVehicle { get; set; }
        public double HorsePower { get; set; }
    }
}