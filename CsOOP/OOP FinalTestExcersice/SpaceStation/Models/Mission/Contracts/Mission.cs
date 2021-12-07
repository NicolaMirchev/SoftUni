using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Planets.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Mission.Contracts
{
    public class Mission : IMission
    {
        public void Explore(IPlanet planet, ICollection<IAstronaut> astronauts)
        {
            throw new NotImplementedException();
        }
    }
}
