using CarRacing.Core.Contracts;
using CarRacing.Models.Cars.Contracts;
using CarRacing.Models.Maps.Contracts;
using CarRacing.Models.Racers.Contracts;
using CarRacing.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRacing.Core
{
   public class Controller : IController
    {

        private CarRepository cars;
        private RacerRepository racers;
        private IMap map;
        public Controller()
        {
            cars = new CarRepository();
            racers = new RacerRepository();
            map = new Map();
        }

        public string AddCar(string type, string make, string model, string VIN, int horsePower)
        {
            if (type == "SuperCar")
            {
                cars.Add(new SuperCar(make, model, VIN, horsePower));
                return $"Successfully added car {make} {model} ({VIN}).";
            }
            else if (type == "TunedCar")
            {
                cars.Add(new TunedCar(make, model, VIN, horsePower));
                return $"Successfully added car {make} {model} ({VIN}).";
            }
            else
            {
                throw new ArgumentException("Invalid car type!");
            }

        }

        public string AddRacer(string type, string username, string carVIN)
        {
            if (type == "StreetRacer")
            {
                ICar car = cars.Models.Where(c => c.VIN == carVIN).FirstOrDefault();
                if (car == null)
                {
                    throw new ArgumentException("Car cannot be found!");
                }
                racers.Add(new StreetRacer(username, car));

                return $"Successfully added racer {username}.";
            }
            else if (type == "ProfessionalRacer")
            {
                ICar car = cars.Models.Where(c => c.VIN == carVIN).FirstOrDefault();
                if (car == null)
                {
                    throw new ArgumentException("Car cannot be found!");
                }
                racers.Add(new ProfessionalRacer(username, car));
                return $"Successfully added racer {username}.";
            }
            else
            {
                return "Invalid racer type!";
            }
        }

        public string BeginRace(string racerOneUsername, string racerTwoUsername)
        {
            if (!racers.Models.Any(r => r.Username == racerOneUsername))
            {
                throw new ArgumentException($"Racer {racerOneUsername} cannot be found!");
            }
            else if (!racers.Models.Any(r => r.Username == racerTwoUsername))
            {
                throw new ArgumentException($"Racer {racerTwoUsername} cannot be found!");
            }
            else
            {
              return map.StartRace(racers.Models.Where(r => r.Username == racerOneUsername).FirstOrDefault(),
                    racers.Models.Where(r => r.Username == racerTwoUsername).FirstOrDefault());
            }
        }

        public string Report()
        {
            var sb = new StringBuilder();
            var orderedRacers = racers.Models.OrderByDescending(r => r.DrivingExperience).ThenBy(r => r.Username);
            foreach (var racer in orderedRacers)
            {
                sb.AppendLine(racer.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
