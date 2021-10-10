using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRace
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            var allCars = new List<Car>(lines);

            for (int i = 0; i < lines; i++)
            {
                string[] data = Console.ReadLine().Split(' ');
                string model = data[0];
                double fuelAm = double.Parse(data[1]);
                double fuelCons = double.Parse(data[2]);

                Car car = new Car(model, fuelAm, fuelCons, 0);
                allCars.Add(car);
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] data = command.Split(' ');
                string model = data[1];
                double distance = double.Parse(data[2]);

                if (data[0].ToLower() == "drive")
                {
                     allCars.Where(car => car.Model == model).FirstOrDefault().Drive(distance);                  
                }


                command = Console.ReadLine();
            }

            foreach (var car in allCars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
