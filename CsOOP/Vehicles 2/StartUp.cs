using System;

namespace Vehicles
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            string[] vehicleData = Console.ReadLine().Split(' ');
            
                double quantity = double.Parse(vehicleData[1]);
                double consumption = double.Parse(vehicleData[2]);
                int tank = int.Parse(vehicleData[3]);

                var car = new Car(quantity, consumption, tank);

            string[] truckInfo = Console.ReadLine().Split(' ');

                double qquantity = double.Parse(truckInfo[1]);
                double cconsumption = double.Parse(truckInfo[2]);
                int ttank = int.Parse(truckInfo[3]);

                var truck = new Truck(qquantity, cconsumption, ttank);

            string[] busInfo = Console.ReadLine().Split(' ');
                double qqquantity = double.Parse(busInfo[1]);
                double ccconsumption = double.Parse(busInfo[2]);
                int tttank = int.Parse(busInfo[3]);

                var bus = new Bus(qqquantity, ccconsumption, tttank);
            


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
                    else if (command[1] == "Bus")
                    {
                        bus.Refuel(double.Parse(command[2]));
                    }
                    else
                    {
                        truck.Refuel(double.Parse(command[2]));
                    }
                }
                else if (command[0] == "Drive")
                {
                    if (command[1] == "Truck")
                    {
                        truck.Drive(int.Parse(command[2]));
                    }
                    else if (command[1] == "Car")
                    {
                        car.Drive(int.Parse(command[2]));
                    }
                    else
                    {
                        bus.Drive(int.Parse(command[2]));
                    }
                }
                else
                {
                    bus.Drive(int.Parse(command[2]), false);
                }

            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}
