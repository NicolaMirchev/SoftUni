using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] inputData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                                   .Select(double.Parse).ToArray();
            Dictionary<double, int> dict = new Dictionary<double, int>();
            
            foreach (var num in inputData)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict.Add(num, 1);
                }

            }


            foreach (var num in dict)
            {
                
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}
