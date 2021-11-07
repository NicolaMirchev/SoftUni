using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    interface IVehicle
    {
        double FuelQuantity { get;  }
        double FuelConsumption { get; }

        void Drive(int kilometers);
        void Refuel(double quantity);
        
    }
        
}
