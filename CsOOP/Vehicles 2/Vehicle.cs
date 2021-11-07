using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    abstract class Vehicle
    {
        public Vehicle(double quantity, double consumption, int tank)
        {
            FuelQuantity = quantity;
            FuelConsumption = consumption;
            if (quantity < tank)
            {
                FuelTank = 0;
            }
            else
            {
                FuelTank = tank;
            }
        }


        public double FuelQuantity { get; protected set; }
        public double FuelConsumption { get; protected set; }
        public int FuelTank { get; protected set; }

        public virtual void Drive(int kilometers)
        {
            if (FuelConsumption * kilometers <= FuelQuantity)
            {
            FuelQuantity -= kilometers * FuelConsumption;
            }
            else
            {
                Console.WriteLine("Vehicle needs refuel");
            }
        }
        public void Refuel(double quantity)
        {
            if (quantity <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }
            if (quantity + this.FuelQuantity > this.FuelTank)
            {
                Console.WriteLine($"Cannot fit {quantity} fuel in the tank");
            }
            else
            {
            FuelQuantity += quantity; 
            }
        }
        
    }
        
}
