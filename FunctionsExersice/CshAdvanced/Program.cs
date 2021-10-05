using System;
using System.Collections.Generic;
using System.Linq;

namespace CshAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            var people = new Dictionary<string, int>();

            for (int i = 0; i < lines; i++)
            {
                string[] data = Console.ReadLine().Split(", ");

                people.Add(data[0], int.Parse(data[1]));
            }

            string command = Console.ReadLine();
            int numberToCompare = int.Parse(Console.ReadLine());

            Func<KeyValuePair<string, int>, bool> comparer = null;
            if (command == "older")
            {
                comparer = x => x.Value >= numberToCompare;
            }
            else
            {
                comparer = x => x.Value < numberToCompare;
            }

            people = people.Where(comparer).ToDictionary(x => x.Key, x => x.Value);

            string[] format = Console.ReadLine().Split();

            if (format[0] == "age")
            {
                foreach (var item in people)
                {
                    Console.WriteLine(item.Value);
                }
            }
            else if (format.Length > 1 )
            {
                foreach (var item in people)
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }
            }
            else
            {
                foreach (var item in people)
                {
                    Console.WriteLine(item.Key);
                }
            }


        }
    }
}
