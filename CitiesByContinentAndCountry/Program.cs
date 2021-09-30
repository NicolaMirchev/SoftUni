using System;
using System.Collections.Generic;

namespace CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var places = new Dictionary<string, Dictionary<string, List<string>>>();


            for (int i = 0; i < lines; i++)
            {
                string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string continent = data[0];
                string country = data[1];
                string city = data[2];

                if (places.ContainsKey(continent))
                {

                    if (places[continent].ContainsKey(country))
                    {
                        places[continent][country].Add(city);
                        
                    }
                    else
                    {
                        places[continent].Add(country, new List<string>() { city });
                    }

                }
                else
                {
                    
                    places.Add(continent, new Dictionary<string, List<string>>());
                    places[continent].Add(country, new List<string>() { city });

                }

            }

            foreach (var continent in places)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.Write($"{country.Key} -> ");
                    Console.WriteLine($"{string.Join(", ", country.Value)}");
                }

            }
        }
    }
}
