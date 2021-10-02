using System;
using System.Collections.Generic;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < lines; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (dict.ContainsKey(input))
                {
                    dict[input]++;
                }
                else
                {
                    dict.Add(input, 1);
                }
            }

            foreach (var number in dict)
            {
                if (number.Value % 2 == 0)
                {
                    Console.WriteLine(number.Key);
                }
            }
        }
    }
}
