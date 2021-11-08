using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }
        public override string ToString()
        {
            return $"Owl [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
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
                Console.WriteLine($"Owls does not eat seeds");
            }
            else if (food is Fruit)
            {
                Console.WriteLine("Owls does not eat fruits");
            }
            else
            {
                Console.WriteLine("Owls does not eat vegetables");
            }
        }

        public override void ProduceASound()
        {
            Console.WriteLine("Hoot Hoot");
        }
    }
}

