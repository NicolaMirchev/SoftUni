using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Models.Equipment.Contracts
{
    public abstract class Equipment : IEquipment
    {
        public Equipment(double weight, decimal price)
        {
            Weight = weight;
            Price = price;
        }
        public double Weight { get; set; }

        public decimal Price { get; set; }
    }
}
