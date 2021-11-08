using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Hen : Bird
    {
        public Hen(string name, double weight,  double wingSize) : base(name, weight, wingSize)
        {
        }

        public override string ToString()
        {
            return $"Hen [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
        public override void Eat(Food food)
        {
                this.FoodEaten += 1 * food.Quantity;
                this.Weight += 0.30 * food.Quantity;       
        }
        public override void ProduceASound()
        {
            Console.WriteLine("Cluck");
        }
    }
}
