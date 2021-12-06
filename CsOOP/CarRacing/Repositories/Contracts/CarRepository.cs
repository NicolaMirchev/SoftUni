using CarRacing.Models.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRacing.Repositories.Contracts
{
   public class CarRepository : IRepository<Car>
    {
        private readonly List<Car> cars;
        public CarRepository()
        {
            cars = new List<Car>();
        }
        public IReadOnlyCollection<Car> Models {
            get => cars;
        }
        public ICar Where { get; internal set; }

        public void Add(Car model)
        {
            if (model == null)
            {
                throw new ArgumentException("Cannot add null in Car Repository");
            }
            cars.Add(model);
        }

        public Car FindBy(string property)
        {
            return cars.Where(c => c.VIN == property).FirstOrDefault();
        }

        public bool Remove(Car model)
        {
            return cars.Remove(model);
        }
    }
}
