using SpaceStation.Models.Planets.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Repositories.Contracts
{
   public class PlanetRepository : IRepository<Planet>
    {
        public IReadOnlyCollection<Planet> Models => throw new NotImplementedException();

        public void Add(Planet model)
        {
            throw new NotImplementedException();
        }

        public Planet FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Planet model)
        {
            throw new NotImplementedException();
        }
    }
}
