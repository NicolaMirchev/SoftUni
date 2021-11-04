using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    class Human : IMember
    {
        public Human(string name, string ID, int age)
        {
            Name = name;
            this.ID = ID;
            Age = age;
        }
        public int  Age { get; set; }
        public string Name { get; private set; }
        public string ID { get ; set; }
    }
}
