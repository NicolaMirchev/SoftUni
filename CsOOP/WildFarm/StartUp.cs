using System;
using System.Collections.Generic;

namespace WildFarm
{
    class StartUp
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine();
                List<Animal> animals = new List<Animal>();

            while (command != "End")
            {
                string[] data = command.Split(' ');
                string animalType = data[0];

                Animal[] animal = new Animal[1];

                if (animalType == "Cat")
                {                
                    animal[0] = new Cat(data[1], double.Parse(data[2]), data[3], data[4]);
                    animal[0].ProduceASound();

                    animals.Add(animal[0]);
                }
                else if (animalType == "Tiger")
                {
                    animal[0] = new Tiger(data[1], double.Parse(data[2]), data[3], data[4]);
                    animal[0].ProduceASound();

                    animals.Add(animal[0]);
                }
                else if (animalType == "Dog")
                {
                    animal[0] = new Dog(data[1], double.Parse(data[2]), data[3]);
                    animal[0].ProduceASound();

                    animals.Add(animal[0]);
                }
                else if (animalType == "Hen")
                {
                    animal[0] = new Hen(data[1], double.Parse(data[2]), double.Parse(data[3]));
                    animal[0].ProduceASound();

                    animals.Add(animal[0]);
                }
                else if (animalType == "Mouse")
                {
                    animal[0] = new Mouse(data[1], double.Parse(data[2]), data[3]);
                    animal[0].ProduceASound();

                    animals.Add(animal[0]);
                }
                else if (animalType == "Owl")
                {
                    animal[0] = new Owl(data[1], double.Parse(data[2]), double.Parse(data[3]));
                    animal[0].ProduceASound();

                    animals.Add(animal[0]);

                }

                string[] food = Console.ReadLine().Split(' ');
                if (food[0] == "Meat")
                {
                    var meat = new Meat(int.Parse(food[1]));
                    animal[0].Eat(meat);
                }
                else if (food[0] == "Fruit")
                {
                    var fruit= new Fruit(int.Parse(food[1]));
                    animal[0].Eat(fruit);
                }
                else if (food[0] == "Vegetable")
                {
                    var vegetables= new Vegetable(int.Parse(food[1]));
                    animal[0].Eat(vegetables);
                }
                else if (food[0] == "Seeds")
                {
                    var seeds = new Seeds(int.Parse(food[1]));
                    animal[0].Eat(seeds);
                }


                command = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

        }
    }
}
