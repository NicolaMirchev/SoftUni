using SpaceStation.Models.Planets.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Repositories.Contracts
{
   public class PlanetRepository : IRepository<Planet>
    {
        private List<Planet> models;
        public PlanetRepository()
        {
            Models = new List<Planet>();
        }
        public IReadOnlyCollection<Planet> Models { get => models; set { } }

        public void Add(Planet model)
        {
            models.Add(model);
        }

        public Planet FindByName(string name)
        {
            if (Models.Any(p => p.Name == name))
            {
            return models.Find(p => p.Name == name);
            }
            else
            {
            return null;
            }
        }

        public bool Remove(Planet model)
        {
            return models.Remove(model);
        }
    }
}
