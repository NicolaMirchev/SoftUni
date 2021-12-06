using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Cars.Contracts
{
    public class TunedCar : Car
    {
        public TunedCar(string make, string model, string VIN, int horsePower)
            : base(make, model, VIN, horsePower, 65, 7.5)
        {
        }

        public override void Drive()
        {
            this.FuelAvailable -= this.FuelConsumptionPerRace;

            this.HorsePower =(int) Math.Round((decimal)this.HorsePower - (decimal)this.HorsePower * 3 / 100);
        }
    }
}
