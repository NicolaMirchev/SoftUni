using CarRacing.Models.Racers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRacing.Repositories.Contracts
{
   public class RacerRepository : IRepository<Racer>
    {
        private readonly List<Racer> racers;
        public RacerRepository()
        {
            racers = new List<Racer>();
        }
        public IReadOnlyCollection<Racer> Models { get => racers; }

        public void Add(Racer model)
        {
            if (model == null)
            {
                throw new ArgumentException("Cannot add null in Car Repository");
            }
            racers.Add(model);
        }

        public Racer FindBy(string property)
        {
            return racers.Where(r => r.Username == property).FirstOrDefault();
        }

        public bool Remove(Racer model)
        {
            return racers.Remove(model);
        }
    }
}
