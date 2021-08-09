using System;
using System.Collections.Generic;
using System.Linq;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLines = Console.ReadLine();
            List<City> cities = new List<City>();

            while (firstLines.ToLower() != "sail")
            {
                string[] data = firstLines.Split("||");
                string cityName = data[0];
                int population = int.Parse(data[1]);
                int goldAmount = int.Parse(data[2]);

                City newCity = new City(cityName, population, goldAmount);
                cities.Add(newCity);

                firstLines = Console.ReadLine();
            }

            string secondLines = Console.ReadLine();

            while (secondLines.ToLower() != "end")
            {
                string[] data = secondLines.Split("=>");

                if (data[0].ToLower() =="plunder" )
                {
                    string cityName = data[1];
                    int people = int.Parse(data[2]);
                    int gold = int.Parse(data[3]);

                    Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {people} citizens killed.");
                    int index = cities.FindIndex(n => n.Name == cityName);
                    cities[index].Gold -= gold;
                    cities[index].Population -= people;

                    if (cities[index].Population <= 0 || cities[index].Gold <= 0)
                    {
                        Console.WriteLine($"{cities[index].Name} has been wiped off the map!");
                        cities.RemoveAt(index);
                    }
                }
                else if (data[0].ToLower() == "prosper")
                {
                    string cityName = data[1];
                    int gold = int.Parse(data[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        int index = cities.FindIndex(n => n.Name == cityName);

                        cities[index].Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {cityName}" +
                            $" now has {cities[index].Gold} gold.");

                    }
                }

                secondLines = Console.ReadLine();
            }

            cities = cities.OrderByDescending(n => n.Gold).ThenBy(n => n.Name).ToList();
            if (cities.Count > 0)
            {


                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (var city in cities)
                {
                    Console.WriteLine($"{city.Name} -> Population: {city.Population} citizens, Gold: {city.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }

        }
    }

    class City
    {
        public City(string name, int population, int gold)
        {
            Name = name;
            Population = population;
            Gold = gold;
        }

        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
    
}
