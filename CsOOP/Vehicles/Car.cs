using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Car : IVehicle
    {
        public Car(double quantity, double consumption)
        {
            FuelQuantity = quantity;
            FuelConsumption = consumption;
        }
        public double FuelQuantity { get; protected set; }

        public double FuelConsumption { get; protected set; }

        public void Drive(int kilometers)
        {
            if (kilometers * (FuelConsumption + 0.9) <= FuelQuantity)
            {
                Console.WriteLine($"Car travelled {kilometers} km");
                this.FuelQuantity -= kilometers * FuelConsumption * 0.9;            
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }

        public void Refuel(double quantity)
        {
            this.FuelQuantity += quantity;

        }
    }
}
