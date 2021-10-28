using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string line = Console.ReadLine();

            var list = new List<Animal>();

            while (line != "Beast!")
            {
                string[] data = Console.ReadLine().Split(' ');
                string name = data[0];
                int age = int.Parse(data[1]);
                string gender = data[2];

                if (line.ToLower() == "cat")
                {
                    var cat = new Cat(name, gender, age);
                    cat.Type = "Cat";
                    list.Add(cat);
                }
                else if (line.ToLower() == "dog")
                {
                    var dog = new Dog(name, gender, age);
                    dog.Type = "Dog";
                    list.Add(dog);
                }
                else if (line.ToLower() == "frog")
                {
                    var frog = new Frog(name, gender, age);
                    frog.Type = "Frog";
                    list.Add(frog);
                }
                else if (line.ToLower() == "tomcat")
                {
                    var tomcat = new Tomcat(name, "Male", age);
                    tomcat.Type = "Tomcat";
                    list.Add(tomcat);
                }
                else if (line.ToLower() == "kittens")
                {
                    var kittens = new Kitten(name, "Female", age);
                    kittens.Type = "Kittens";
                    list.Add(kittens);
                }

                line = Console.ReadLine();
            }


            foreach (var item in list)
            {
                Console.Write(item);
            }

        }
    }
}
