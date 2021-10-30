using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var people = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                string[] personData = Console.ReadLine().Split();
                var newPerson = new Person(personData[0], personData[1], int.Parse(personData[2]));

                people.Add(newPerson);
            }
            people = people.OrderBy(p => p.FirstName).ThenBy(p => p.Age).ToList();
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
