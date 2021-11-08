using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }
        public override string ToString()
        {
            return $"Cat [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
        public override void ProduceASound()
        {
            Console.WriteLine("Meow"); ;
        }
        public override void Eat(Food food)
        {
            if (food is Vegetable || food is Meat)
            {
                this.FoodEaten += 1 * food.Quantity;
                this.Weight += 0.30 * food.Quantity;
            }
            else if (food is Seeds)
            {
                Console.WriteLine($"Cat does not eat Seeds!");
            }
            else if (food is Fruit)
            {
                Console.WriteLine("Cat does not eat Fruit!");
            }
        }
    }
}
