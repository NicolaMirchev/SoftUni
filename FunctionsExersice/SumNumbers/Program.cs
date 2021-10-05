using System;
using System.Collections.Generic;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = Parser;
            string[] input = Console.ReadLine().Split(", ");
            var result = Select2(input, parser);

            Console.WriteLine(result.Count); 
            Console.WriteLine(Sum(result)); 
                          
             
        }
        static int Sum(IEnumerable<int> list)
        {
            int sum = 0;
            foreach (var item in list)
            {
                sum += item;
            }
            return sum;
        }
        static int Parser(string input)
        {
            int number = 0;
            foreach (var symbol in input)
            {
                number *= 10;
                number += (symbol - '0');
            }
            return number;
        }

        static List<int> Select2 (IEnumerable<string> list, Func<string, int> selector)
        {
            var newList = new List<int>();

            foreach (var item in list)
            {
               newList.Add(selector(item));
            }

            return newList;
        }
    }
}
