using SpaceStation.Models.Astronauts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Repositories.Contracts
{
    public class AstronautRepository : IRepository<Astronaut>
    {
        public IReadOnlyCollection<Astronaut> Models => throw new NotImplementedException();

        public void Add(Astronaut model)    
        {
            throw new NotImplementedException();
        }

        public Astronaut FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Astronaut model)
        {
            throw new NotImplementedException();
        }
    }
}
