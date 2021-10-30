using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var people = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                string[] personData = Console.ReadLine().Split();
                var newPerson = new Person(personData[0], personData[1],
                                int.Parse(personData[2]), decimal.Parse(personData[3]));

                people.Add(newPerson);
            }

            int percentage = int.Parse(Console.ReadLine());
            foreach (var person in people)
            {
                person.IncreaseSalary(percentage);
            }
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
