using Gym.Core.Contracts;
using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms.Contracts;
using Gym.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym.Core
{
    public class Controller : IController
    {
        private EquipmentRepository equipment;
        private List<IGym> gyms;
        public Controller()
        {
            equipment = new EquipmentRepository();
            gyms = new List<IGym>();
        }
        public string AddAthlete(string gymName, string athleteType, string athleteName, string motivation, int numberOfMedals)
        {
            var gym = gyms.Find(g => g.Name == gymName);
            if (athleteType == "Boxer")
            {
                var athlete = new Boxer(athleteName, motivation, numberOfMedals);
                if (gym.GetType().Name == "BoxingGym")
                {
                    gym.AddAthlete(athlete);
                }
                else return "The gym is not appropriate.";
            }
            else if (athleteType == "Weightlifter")
            {
                var athlete = new Weightlifter(athleteName, motivation, numberOfMedals);
                if (gym.GetType().Name == "WeightliftingGym")
                {
                    gym.AddAthlete(athlete);
                }
                else return "The gym is not appropriate.";
            }
            else
            {
                throw new InvalidOperationException("Invalid athlete type.");
            }

            return $"Successfully added {athleteType} to {gymName}.";
        }

        public string AddEquipment(string equipmentType)
        {
            if (equipmentType == "BoxingGloves")
            {
                var eqipment = new BoxingGloves();
                equipment.Add(eqipment);
            }
            else if (equipmentType == "Kettlebell")
            {
                var eqipment = new Kettlebell();
                equipment.Add(eqipment);
            }
            else
            {
                throw new InvalidOperationException("Invalid equipment type.");
            }
            return $"Successfully added {equipmentType}.";
        }

        public string AddGym(string gymType, string gymName)
        {
            if (gymType == "BoxingGym")
            {
                var gym = new BoxingGym(gymName);
                gyms.Add(gym);
            }
            else if (gymType == "WeightliftingGym")
            {
                var gym = new WeightliftingGym(gymName);
                gyms.Add(gym);
            }
            else
            {
                throw new InvalidOperationException("Invalid gym type.");
            }
            return $"Successfully added {gymType}.";
        }

        public string EquipmentWeight(string gymName)
        {
            var gym = gyms.Find(g => g.Name == gymName);

            double weight = gym.EquipmentWeight;
            return $"The total weight of the equipment in the gym {gymName} is {weight:f2} grams.";
        }

        public string InsertEquipment(string gymName, string equipmentType)
        {
            if (equipment.FindByType(equipmentType) != null)
            {
                var equipment = this.equipment.FindByType(equipmentType);
                var gym = gyms.Find(g => g.Name == gymName);

                gym.Equipment.Add(equipment);
                this.equipment.Remove(equipment);
            }
            else
            {
                throw new InvalidOperationException($"There isn’t equipment of type {equipmentType}.");
            }
            return $"Successfully added {equipmentType} to {gymName}.";
        }

        public string Report()
        {
            var sb = new StringBuilder();
            foreach (var gym in gyms)
            {
                sb.AppendLine(gym.GymInfo().TrimEnd());
            }
            return sb.ToString().TrimEnd();
        }

        public string TrainAthletes(string gymName)
        {
            var gym = gyms.Find(g => g.Name == gymName);

            gym.Exercise();
            return $"Exercise athletes: {gym.Athletes.Count}.";
        }
    }
}
