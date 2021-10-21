using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreetRacing
{
    class Race
    {
        //        Name: string
        // Type: string
        // Laps: int
        // Capacity: int - the maximum allowed number of participants in the race
        // MaxHorsePower: int - the maximum allowed Horse Power of a Car in the Race

        public Race(string name, string type, int laps, int capacity, int maxHP)
        {
            Name = name;
            Type = type;
            Laps = laps;
            Capacity = capacity;
            MaxHorsePower = maxHP;
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Laps { get; set; }
        public int Capacity{ get; set; }
        public int MaxHorsePower { get; set; }

        public List<Car> Participants { get; set; }

        public int Count { get { return Participants.Count; } }

        public void Add(Car newcar)
        {
            if (newcar.HorsePower <= MaxHorsePower)
            {
                if (Capacity <= Participants.Count)
                {

                }
                else
                {
                    if (!Participants.Any(p => p.LicensePlate == newcar.LicensePlate))
                    {
                    Participants.Add(newcar);
                    }
                }


            }
        
        }

        public bool Remove(string licPlate)
        {
            if (Participants.Any(p => p.LicensePlate == licPlate))
            {
                int index = Participants.FindIndex(p => p.LicensePlate == licPlate);
                Participants.RemoveAt(index);
                return true;
            }
            return false;
        }

        public Car FindParticipant(string licPlate)
        {
            if (Participants.Any(p => p.LicensePlate == licPlate))
            {
                int index = Participants.FindIndex(p => p.LicensePlate == licPlate);
                var finded = Participants[index];
                return finded;
            }
            else return null;
        }

        public Car GetMostPowerfulCar()
        {
           
            Car powerest = Participants[0];
            if (Participants[0] == null)
            {
                return null;
            }
            else
            {
                int biggestPower = Participants[0].HorsePower;
                foreach (var car in Participants)
                {
                    if (car.HorsePower > biggestPower)
                    {
                        powerest = car;
                    }
                }
                return powerest;
            }
        }

        public void Report()
        {
            Console.WriteLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");
            foreach (var car in Participants)
            {
                Console.WriteLine(car);
            }
        }
    }
}
