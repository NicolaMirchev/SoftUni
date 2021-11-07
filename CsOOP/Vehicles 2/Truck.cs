using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Truck : Vehicle
    {
        public Truck(double quantity, double consumption, int tank) : base(quantity, consumption, tank)
        {
        }

        public override void Drive(int kilometers)
        {
            if (FuelConsumption * (kilometers + 1.6) <= FuelQuantity)
            {
                FuelQuantity -= FuelConsumption * (kilometers + 1.6);
                Console.WriteLine($"Truck travelled {kilometers} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }
    }

}