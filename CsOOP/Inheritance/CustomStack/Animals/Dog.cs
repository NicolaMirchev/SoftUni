using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Dog : Animal
    {
        public Dog(string name, string gender, int age) : base(name, gender, age)
        {

        }

        public override string ProduceSound()
        {
            return "Woof!";
        }

    }
}
