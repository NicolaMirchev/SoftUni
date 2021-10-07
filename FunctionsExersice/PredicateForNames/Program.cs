using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var evenNum = new List<int>();
            var oddNum = new List<int>();

            foreach (var number in list)
            {
                if (number % 2 == 0)
                {
                    evenNum.Add(number);
                }
                else
                {
                    oddNum.Add(number);
                }
            }

            list.Clear();
            list = evenNum.OrderBy(x => x).ToList();
            oddNum = oddNum.OrderBy(x => x).ToList();

            foreach (var num in oddNum)
            {
                list.Add(num);
            }

            Console.WriteLine(string.Join(' ', list));

            
        }
      
    }
}
