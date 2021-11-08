using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }
        public override string ToString()
        {
            return $"Dog [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                this.FoodEaten += 1 * food.Quantity;
                this.Weight += 0.30 * food.Quantity;
            }
            else if (food is Seeds)
            {
                Console.WriteLine($"Dogs does not eat seeds");
            }
            else if (food is Fruit)
            {
                Console.WriteLine("Dogs does not eat fruits");
            }
            else
            {
                Console.WriteLine("Dogs does not eat vegetables");
            }
        }

        public override void ProduceASound()
        {
            Console.WriteLine("Woof!"); ;
        }
    }
}
