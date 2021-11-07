using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Truck : IVehicle
    {
        public Truck(double quantity, double consumption)
        {
            FuelQuantity = quantity;
            FuelConsumption = consumption;
        }
        public double FuelQuantity { get; protected set; }

        public double FuelConsumption { get; protected set; }

        public void Drive(int kilometers)
        {
            if (FuelConsumption * kilometers * 1.6 <= FuelQuantity)
            {
                FuelQuantity -= FuelConsumption * kilometers * 1.6;
                Console.WriteLine($"Truck travelled {kilometers} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public void Refuel(double quantity)
        {
            this.FuelQuantity += quantity;
        }


    }
}
