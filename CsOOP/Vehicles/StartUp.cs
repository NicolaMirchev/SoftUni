using System;

namespace Vehicles
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carData = Console.ReadLine().Split(' ');
            var car = new Car(double.Parse(carData[1]), double.Parse(carData[2]));

            string[] truckData = Console.ReadLine().Split(' ');
            var truck = new Truck(double.Parse(truckData[1]), double.Parse(truckData[2]));

            int commands = int.Parse(Console.ReadLine());
            for (int i = 0; i < commands; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                if (command[0] == "Refuel")
                {
                    if (command[1] == "Car")
                    {
                        car.Refuel(double.Parse(command[2]));
                    }
                    else
                    {
                        truck.Refuel(double.Parse(command[2]));
                    }
                }
                else
                {
                    if (command[1] == "Truck")
                    {
                        truck.Drive(int.Parse(command[2]));
                    }
                    else
                    {
                        car.Drive(int.Parse(command[2]));
                    }
                }

            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}
