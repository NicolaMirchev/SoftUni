using System;
using System.Collections.Generic;
using System.Linq;

namespace DivisibleByN
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            Predicate<int> isTrue = x => x % number != 0;

            var result = new List<int>();

            foreach (var item in data)
            {
                if (item % number != 0)
                {
                    result.Add(item);
                }
            }

            result.Reverse();
            Console.WriteLine(string.Join(' ', result));
            

            
        }
    }
}
