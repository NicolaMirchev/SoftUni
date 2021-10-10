using System;
using System.Collections.Generic;
using System.Text;
using CarEngineAndTires;

namespace CarEngineAndTires
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tires[]> setsOfTires = new List<Tires[]>();

            string command = Console.ReadLine();
            while (command != "No more tires")
            {
                string[] dataAboutTiers = command.Split(' ');
                var currentTireSet = new Tires[4];
                int counter = 0;

                for (int i = 0; i < dataAboutTiers.Length; i += 2)
                {
                    int year = int.Parse(dataAboutTiers[i]);
                    double pressure = double.Parse(dataAboutTiers[i + 1]);

                    var tire = new Tires(year, pressure);

                    currentTireSet[counter] = tire;
                    if (counter >= 4)
                    {
                        Console.WriteLine("Error");
                    }
                    counter++;
                }

                setsOfTires.Add(currentTireSet);
                              
                command = Console.ReadLine();
            }


            var engines = new List<Engine>();

            command = Console.ReadLine();
            while (command != "Engines done")
            {
                string[] data = command.Split(' ');
                int HP = int.Parse(data[0]);
                double cubics = double.Parse(data[1]);

                var currentEngine = new Engine(HP, cubics);
                engines.Add(currentEngine);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            List<Car> specialCars = new List<Car>();

            while (command != "Show special")
            {
                string[] data = command.Split(' ');
                string make = data[0];
                string model = data[1];
                int year = int.Parse(data[2]);
                var fuelQuantiry = double.Parse(data[3]);                            
                var fuelConsumtion = double.Parse(data[4]);

                var engineIndex = int.Parse(data[5]);
                var tiresIndex = int.Parse(data[6]);

                var currentCar = new Car(make, model, year, fuelQuantiry, fuelConsumtion);
                currentCar.TireSet = setsOfTires[tiresIndex];
                currentCar.Engine = engines[engineIndex];

                if (currentCar.Year >= 2017)
                {
                    if (currentCar.Engine.HorsePower > 330)
                    {
                        if (IsRightPressure(currentCar.TireSet))
                        {
                            specialCars.Add(currentCar);
                        }
                    }

                }

                command = Console.ReadLine();
            }

            foreach (var car in specialCars)
            {
                car.Drive(20);
                var stringBuilder = new StringBuilder();
                stringBuilder.AppendLine($"Make: {car.Make}");
                stringBuilder.AppendLine($"Model: {car.Model}");
                stringBuilder.AppendLine($"Year: {car.Year}");
                stringBuilder.AppendLine($"HorsePowers: {car.Engine.HorsePower}");
                stringBuilder.AppendLine($"FuelQuantity: {car.FuelQuantity}");
                Console.WriteLine(stringBuilder);
            }

            static bool IsRightPressure(Tires[] tireSet)
            {
                    double allTiresPressure = 0;
                    foreach (var tire in tireSet)
                    {
                        allTiresPressure += tire.Pressure;
                    }
                    if (allTiresPressure > 9 && allTiresPressure < 10)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                   
            }
        }
    }
}
