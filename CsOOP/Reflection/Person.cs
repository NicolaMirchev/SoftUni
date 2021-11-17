using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Sleep()
        {
            Console.WriteLine("Sleeping..");
        }
    }
}
