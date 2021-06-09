using System;

namespace ConsoleApp4
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split();
            string[] input2 = Console.ReadLine().Split();
            string[] input3 = Console.ReadLine().Split();



            Vehicle car = new Car(double.Parse(input1[1]), double.Parse(input1[2]), double.Parse(input1[3]));
            Vehicle truck = new Truck(double.Parse(input2[1]), double.Parse(input2[2]), double.Parse(input2[3]));
            Vehicle bus = new Bus(double.Parse(input3[1]), double.Parse(input3[2]), double.Parse(input3[3]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "Drive")
                {
                    if (command[1] == "Car")
                    {
                        car.Drive(double.Parse(command[2]));
                    }
                    else if (command[1] == "Bus")
                    {
                        
                        bus.Drive(double.Parse(command[2]));
                    }
                    else
                    {
                        truck.Drive(double.Parse(command[2]));
                    }
                }
               else if (command[0] == "DriveEmpty")
                {
                    bus.DriveEmpty(double.Parse(command[2]));
                }
                if (command[0] == "Refuel")
                {
                    if (command[1] == "Car")
                    {
                        car.Refueling(double.Parse(command[2]));
                    }
                   else if (command[1] == "Bus")
                    {
                        bus.Refueling(double.Parse(command[2]));
                    }
                    else
                    {
                        truck.Refueling(double.Parse(command[2]));
                    }
                }
            }
            Console.WriteLine($"Car: {car.Quantity:f2}");
            Console.WriteLine($"Truck: {truck.Quantity:f2}");
            Console.WriteLine($"Bus: {bus.Quantity:f2}");
        }
    }
}
