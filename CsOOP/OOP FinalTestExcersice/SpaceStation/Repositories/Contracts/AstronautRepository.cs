using SpaceStation.Models.Astronauts.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Repositories.Contracts
{
    public class AstronautRepository : IRepository<Astronaut>
    {
        public AstronautRepository()
        {
            models = new List<Astronaut>();
        }
        private List<Astronaut> models;
        public IReadOnlyCollection<Astronaut> Models { get => models; set { } }

        public bool Any { get; internal set; }

        public void Add(Astronaut model)    
        {
            models.Add(model);
        }

        public Astronaut FindByName(string name)
        {
            if (models.Any(m => m.Name == name))
            {
                return models.Find(m => m.Name == name);
            }
            else return null;
        }

        public bool Remove(Astronaut model)
        {
           return models.Remove(model);
        }
    }
}
