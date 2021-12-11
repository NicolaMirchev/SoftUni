using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Models.Athletes.Contracts
{

    public abstract class Athlete : IAthlete
    {
        private string fullName;
        private string motivation;
        private int numberOfMedals;
        private int stamina;
        public Athlete(string fullName, string motivation, int numberOfMedals, int stamina)
        {
            FullName = fullName;
            Motivation = motivation;
            NumberOfMedals = numberOfMedals;
            Stamina = stamina;
        }
        public string FullName
        {
            get => fullName;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Athlete name cannot be null or empty.");
                }
                fullName = value;
            }

        }

        public string Motivation
        {
            get => motivation;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The motivation cannot be null or empty.");
                }
                motivation = value;
            }
        }

        public int Stamina 
        {
            get => stamina;
            set
            {
                if (value > 100)
                {
                    stamina = 100;
                    throw new ArgumentException("Stamina cannot exceed 100 points.");
                }
                stamina = value;
            }
        
        }

        public int NumberOfMedals
        {
            get => numberOfMedals;
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("The motivation cannot be null or empty.");
                }
                numberOfMedals = value;
            }
        }

        public abstract void Exercise();

        public override string ToString()
        {
            return this.FullName;
        }

    }
}
