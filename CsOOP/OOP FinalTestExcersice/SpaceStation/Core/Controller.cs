using SpaceStation.Core.Contracts;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Core
{
    class Controller : IController
    {
        private AstronautRepository astronautRepository;
        private PlanetRepository planetRepository;

        private int planetsExplored = 0;
        public Controller()
        {
            astronautRepository = new AstronautRepository();
            planetRepository = new PlanetRepository();
        }
        public string AddAstronaut(string type, string astronautName)
        {
            Astronaut astronaut = null;
            if (type == "Biologist")
            {
                astronaut = new Biologist(astronautName);
            }
            else if (type == "Geodesist")
            {
                astronaut = new Geodesist(astronautName);
            }
            else if (type == "Meteorologist")
            {
                astronaut = new Meteorologist(astronautName);
            }
            else
            {
                throw new ArgumentException(Utilities.Messages.ExceptionMessages.InvalidAstronautType);
            }
            astronautRepository.Add(astronaut);

            return $"Successfully added {type}: {astronautName}"; 
        }

        public string AddPlanet(string planetName, params string[] items)
        {
            var planet = new Planet(planetName);
            foreach (var item in items)
            {
                planet.Items.Add(item);
            }
            return $"Successfully added Planet: {planetName}!";
        }

        public string ExplorePlanet(string planetName)
        {

            List<IAstronaut> suitableAstronauts = new List<IAstronaut>();
            foreach (var model in astronautRepository.Models.Where(m => m.Oxygen > 60))
            {
                suitableAstronauts.Add(model);
            }

            if (suitableAstronauts.Count < 0)
            {
                throw new InvalidOperationException(Utilities.Messages.ExceptionMessages.InvalidAstronautCount);
            }
            else
            {
                var mission = new Mission();
                int startingAstronauts = suitableAstronauts.Count;

                mission.Explore(planetRepository.FindByName(planetName), suitableAstronauts);
                planetsExplored++;

                return $"Planet: {planetName} was explored! Exploration finished with " +
                    $"{startingAstronauts - suitableAstronauts.Count} dead astronauts!";
            }
        }

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{planetsExplored} planets were explored!");
            sb.AppendLine("Astronauts info:");
            foreach (var astronaut in astronautRepository.Models)
            {
                sb.AppendLine(astronaut.ToString().TrimEnd());
            }
            return sb.ToString().TrimEnd();
        }

        public string RetireAstronaut(string astronautName)
        {
            if (astronautRepository.FindByName(astronautName) != null)
            {

                var astronaut = astronautRepository.FindByName(astronautName);
                astronautRepository.Remove(astronaut);
                return $"Astronaut {astronautName} was retired!";
            }
            else
            {
                throw new InvalidOperationException(Utilities.Messages.ExceptionMessages.InvalidRetiredAstronaut);
            }
        }
    }
}
