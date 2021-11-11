using System;
using System.Collections.Generic;
using System.Text;

namespace NumberValidator
{
    class Person
    {
        private string name;
        private int age;
        private string lastName;
            
        public Person(string name, string lastName, int age)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
        }
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name is null or empty");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int Age
        {
            get => age;
            set
            {
                if (value <= 0 || value > 120)
                {
                    throw new IndexOutOfRangeException("Invalid age value");
                }
                else
                {
                    age = value;
                }
            }
        }
        public string LastName { get => lastName;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name is null or empty");
                }
                else
                {
                    lastName = value;
                }

            }                    
        }
        public override string ToString()
        {
            return $"I am {Name} {LastName} - {Age} years old.";
        }
    }
}
