using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
   public class Vehicle
    {
        public Vehicle(int Hp, double fuel)
        {
            HorsePower = Hp;
            Fuel = fuel;
            DefautFuelConsumption = 1.25;
        }

        public double DefautFuelConsumption { get; set; }
        public virtual double FuelConsumption{ get; set; }        
        public double Fuel{ get; set; }
        public int HorsePower{ get; set; }

      public virtual void Drive(int kilometers)
        {
            this.Fuel -= (this.FuelConsumption / 100) * kilometers;
        }
    }
}
