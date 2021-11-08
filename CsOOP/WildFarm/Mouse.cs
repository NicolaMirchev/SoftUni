using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override string ToString()
        {
            return $"Mouse [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
        public override void Eat(Food food)
        {
            if (food is Fruit || food is Vegetable)
            {
                this.FoodEaten += 1 * food.Quantity;
                this.Weight += 0.30 * food.Quantity;
            }
            else if (food is Seeds)
            {
                Console.WriteLine($"Dogs does not eat seeds");
            }
            else if (food is Meat)
            {
                Console.WriteLine("Mice does not eat meat");
            }

        }

        public override void ProduceASound()
        {
            Console.WriteLine("Squeak");
        }
    }
}
