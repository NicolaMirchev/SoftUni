﻿using SpaceStation.Models.Bags.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Astronauts.Contracts
{
    public abstract class Astronaut : IAstronaut
    {
        public Astronaut(string name, double oxygen)
        {

        }
        public string Name => throw new NotImplementedException();

        public double Oxygen => throw new NotImplementedException();

        public bool CanBreath => throw new NotImplementedException();

        public IBag Bag => throw new NotImplementedException();

        public virtual void Breath()
        {
            throw new NotImplementedException();
        }
    }
}
