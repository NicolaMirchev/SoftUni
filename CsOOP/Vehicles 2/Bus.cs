using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Bus : Vehicle
    {
        public Bus(double quantity, double consumption, int tank) : base(quantity, consumption, tank)
        {
        }

        public void Drive(int kilometers, bool empty)
        {
            if (empty == false)
            {

            if (FuelQuantity >= FuelConsumption * (kilometers + 1.4))
            {
                Console.WriteLine($"Bus travelled {kilometers}");
            }
            else
            {
                Console.WriteLine("Bus needs refuel");
            }
            }
        }
    }
}
