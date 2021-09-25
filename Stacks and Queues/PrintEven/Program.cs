using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PrintEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> list = new List<int>();

            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    list.Add(item);
                }
            }

            Console.WriteLine(string.Join(", ", list));
        
        }
    }
}
