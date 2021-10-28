using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Animal
    {
        public Animal(string name, string gender, int age)
        {
            Name = name;
            Gender = gender;
            if (age <=0 )
            {
                throw new InvalidOperationException("Invalid input!");
            }
            Age = age;
        }
        public string  Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string  Type { get; set; }

        public virtual string ProduceSound()
        {
            return null;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(this.Type);
            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            sb.AppendLine(this.ProduceSound());
            return sb.ToString();
        }
    }
}
