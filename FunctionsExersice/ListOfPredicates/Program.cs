using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Func<int, int, bool> isDivisible = (x, y) => x % y == 0;

            var result = new List<int>();

            for (int i = 1; i <= range; i++)
            {
                for (int j = 0; j < list.Count(); j++)
                {
                    if (i % list[j] != 0)
                    {
    
                        break;
                    }
                    else if (j == list.Count() - 1)
                    {
                        result.Add(i);
                    }

                }
              
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
