using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Planets.Contracts
{
    public class Planet : IPlanet
    {
        private string name;
        public Planet(string name)
        {
            Items = new List<string>();
            Name = name;
        }
        public ICollection<string> Items { get; }       

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(Utilities.Messages.ExceptionMessages.InvalidPlanetName);
                }
                name = value;
            }
        }
    }
}
