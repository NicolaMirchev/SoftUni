using System;
using System.Collections.Generic;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            var table = new SortedSet<string>();

            for (int i = 0; i < length; i++)
            {
                string[] chemicalElements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (var element in chemicalElements)
                {
                    table.Add(element);
                }
            }

            Console.WriteLine(string.Join(' ',table));
        }
    }
}
