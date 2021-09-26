using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodSuply = int.Parse(Console.ReadLine());

            Queue<int> orders = new Queue<int>(Console.ReadLine()
                                                      .Split()
                                                      .Select(int.Parse)
                                                      .ToArray());

            int[] arr = orders.ToArray();

            int biggestOrder = int.MinValue;
            foreach (var item in arr)
            {
                if (item > biggestOrder)
                {
                    biggestOrder = item;
                }
            }
            Console.WriteLine(biggestOrder);

            while (orders.Count > 0)
            {
                
                if (orders.Peek() <= foodSuply)
                {                         
                    foodSuply -= orders.Peek();
                    orders.Dequeue();
                }                
                else
                {
                    break;
                }

            }
            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                int[] finalAnswer = orders.ToArray();
                Console.Write("Orders left: ");
                Console.WriteLine(string.Join(' ', finalAnswer));
            }
        }
    }
}
