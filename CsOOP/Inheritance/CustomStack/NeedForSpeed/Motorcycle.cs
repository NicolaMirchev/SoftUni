using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    class Motorcycle : Vehicle
    {
        public Motorcycle(int hp, double fuel) : base(hp, fuel)
        {
            FuelConsumption = base.DefautFuelConsumption;
        }

        public override void Drive(int kilometers)
        {
            this.Fuel -= (this.FuelConsumption / 100) * kilometers;
        }
    }
}
