using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    class Car
    {

        public Car()
        { 
        }
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)  : this(make, model, year)
        {

            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            if (FuelQuantity - distance * (FuelConsumption / 100) >= 0)
            {
                FuelQuantity -= distance * (FuelConsumption / 100);
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}\n" +
                $"Model {this.Model}\n" +
                $"Year {this.Year}\n" +
                $"Fuel: {this.FuelQuantity:f2}";
        }

    }
}
