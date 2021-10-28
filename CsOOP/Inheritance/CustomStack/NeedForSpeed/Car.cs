using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    class Car : Vehicle
    {
        public Car(int hp, double fuel) :base(hp, fuel)
        {
            DefautFuelConsumption = 3;
            FuelConsumption = 3;
        }

        public override void Drive(int kilometers)
        {
            this.Fuel -= (this.FuelConsumption / 100) * kilometers;
        }
    }
}
