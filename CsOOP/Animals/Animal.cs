using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        public Animal(string name, string favouriteFood)
        {
            this.name = name;
            this.favouriteFood = favouriteFood;
        }

        private string name;
        private string favouriteFood;

        public virtual string ExplainSelf()
        {
            return $"I am {name} and my favourite food is {favouriteFood}";
        }
    }
}
