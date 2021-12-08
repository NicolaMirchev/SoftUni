using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Planets.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Models.Mission.Contracts
{
    public class Mission : IMission
    {
        public void Explore(IPlanet planet, ICollection<IAstronaut> astronauts)
        {
            List<string> list = planet.Items.ToList();
            foreach (var astronaut in astronauts)
            {
                while (astronaut.CanBreath)
                {
                    if (planet.Items.Count == 0)
                    {
                        break;
                    }

                    astronaut.Bag.Items.Add(list[0]);                    
                    planet.Items.Remove(list[0]);
                    list.RemoveAt(0);
                    astronaut.Breath();
                }
                if (!astronaut.CanBreath)
                {
                    astronauts.Remove(astronaut);
                }
                if (planet.Items.Count == 0)
                {
                    break;
                }
            }                                   
        }
    }
}
