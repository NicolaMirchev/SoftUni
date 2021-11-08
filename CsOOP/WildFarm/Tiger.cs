using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override string ToString()
        {
            return $"Tiger [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
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
                Console.WriteLine($"Tigers does not eat seeds");
            }
            else if (food is Fruit)
            {
                Console.WriteLine("Tigers does not eat fruits");
            }
            else
            {
                Console.WriteLine("Tigers does not eat vegetables");
            }
        
    }

        public override void ProduceASound()
        {
            Console.WriteLine("ROAR!!!");
        }
    }
}
