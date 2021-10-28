using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Kitten : Cat
    {
        public Kitten(string name, string gender, int age) : base(name, gender, age)
        {

        }

        public override string ProduceSound()
        {
            return "Meow";
        }

    }
}
