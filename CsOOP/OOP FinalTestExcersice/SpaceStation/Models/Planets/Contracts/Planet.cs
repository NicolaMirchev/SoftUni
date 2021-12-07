using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Planets.Contracts
{
    public class Planet : IPlanet
    {
        public Planet(string name)
        {
            Items = new List<string>();
        }
        public ICollection<string> Items { get; }

        public string Name => throw new NotImplementedException();
    }
}
