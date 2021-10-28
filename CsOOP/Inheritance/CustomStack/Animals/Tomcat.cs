using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Tomcat : Cat
    {
        public Tomcat(string name, string gender, int age) : base(name, gender, age)
        {

        }

        public override string ProduceSound()
        {
            return "MEOW";
        }

    }
}
