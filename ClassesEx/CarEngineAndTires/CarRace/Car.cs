using System;
using System.Collections.Generic;
using System.Text;

namespace CarRace
{
    class Car
    {
        public Car(string model, double fuelAmount, double fuelCons, double travelledDistance)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelCons;
            TravelledDistance = travelledDistance;
        }
        public string  Model { get; set; }
        public double FuelAmount { get; set; }
        public double  FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

       public void Drive(double distance)
        {
            if (FuelAmount >= distance * FuelConsumptionPerKilometer)
            {
                FuelAmount -= distance * FuelConsumptionPerKilometer;
                TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

        }

    }
}
