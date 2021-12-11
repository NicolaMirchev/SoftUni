using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Models.Gyms.Contracts
{
    public class Gym : IGym
    {
        private string name;
        public Gym(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Equipment = new List<IEquipment>();
            Athletes = new List<IAthlete>();
        }
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Gym name cannot be null or empty.");
                }
                name = value;
            }
        }

        public int Capacity { get; set; }

        public double EquipmentWeight
        {
            get
            {
                double result = 0;
                foreach (var item in Equipment)
                {
                    result += item.Weight;
                }
                return result;
            }
        }

        public ICollection<IEquipment> Equipment { get; set; }

        public ICollection<IAthlete> Athletes { get; set; }

        public void AddAthlete(IAthlete athlete)
        {
            if (Athletes.Count + 1 > Capacity)
            {
                throw new InvalidOperationException("Not enough space in the gym.");
            }
            else
            {
                Athletes.Add(athlete);
            }
        }

        public void AddEquipment(IEquipment equipment)
        {
            Equipment.Add(equipment);
        }

        public void Exercise()
        {
            foreach (var athlete in Athletes)
            {
                athlete.Exercise();     
            }
        }

        public string GymInfo()
        {
            var sb = new StringBuilder();



            sb.AppendLine($"{Name} is a {this.GetType().Name}:"); //IDK
            if (Athletes.Count == 0)
            {
                sb.AppendLine($"Athletes: No athletes");
            }
            else
            {
                sb.AppendLine($"Athletes: {string.Join(", ", Athletes)}"); 
            }
            sb.AppendLine($"Equipment total count: {Equipment.Count}");
            sb.AppendLine($"Equipment total weight: {EquipmentWeight:f2} grams");

            return sb.ToString().TrimEnd();
        }

        public bool RemoveAthlete(IAthlete athlete)
        {
            return Athletes.Remove(athlete);
        }
    }
}
