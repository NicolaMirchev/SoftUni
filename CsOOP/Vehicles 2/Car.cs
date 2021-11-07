using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Car : Vehicle
    {
        public Car(double quantity, double consumption, int tank) : base(quantity, consumption, tank)
        {
        }

        public override void Drive(int kilometers)
        {
            if (kilometers * (FuelConsumption + 0.9) <= FuelQuantity)
            {
                Console.WriteLine($"Car travelled {kilometers} km");
                this.FuelQuantity -= kilometers * (FuelConsumption + 0.9);
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }
    }
}

    

