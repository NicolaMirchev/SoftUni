using System;
using System.Collections.Generic;
using System.Text;

namespace CarEngineAndTires
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

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {

            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;

        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tires[] tireSet)
            :this(make,model,year,fuelQuantity,fuelConsumption)
        {
            engine = Engine;
            TireSet = new Tires[4];                               
            
        }
        public Tires[] TireSet { get; set; }
        public Engine Engine { get; set; }
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

     public class Engine
    {
        public Engine(int hp, double cubicCap)
        {
            HorsePower = hp;
            CubicCapacity = cubicCap;
        }

        public int HorsePower { get; set; }

        public double CubicCapacity { get; set; }
    }

    public class Tires
    {
        public Tires(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }

        public int Year { get; set; }
        public double Pressure { get; set; }

    }
}

