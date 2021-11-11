using System;
using System.Collections.Generic;
using System.Text;

namespace NumberValidator
{
    class Student : Person
    {
        private string name;

        public Student(string name, string lastName, int age) : base(name, lastName, age)
        {
            this.Name = name;
        }

        public new string Name { get => name;
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsDigit(value[i]) || char.IsSymbol(value[i]))
                    {
                        throw new InvalidPersonNameExeption();
                    }
                }
                Name = value; 
            } 
        }
    }
}
