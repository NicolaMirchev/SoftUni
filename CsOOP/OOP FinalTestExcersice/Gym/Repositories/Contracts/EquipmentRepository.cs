using Gym.Models.Equipment.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Repositories.Contracts
{
    public class EquipmentRepository : IRepository<IEquipment>
    {
        private List<IEquipment> models;
        public EquipmentRepository()
        {
            models = new List<IEquipment>();
        }
        public IReadOnlyCollection<IEquipment> Models { get => models; }

        public void Add(IEquipment model)
        {
            models.Add(model);
        }

        public IEquipment FindByType(string type)
        {
            return models.Find(m => m.GetType().Name == type);
        }

        public bool Remove(IEquipment model)
        {
            return models.Remove(model);
        }
    }
}
