using System;
using System.Collections.Generic;
using System.Linq;

namespace Bourique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            int rackCapacity = int.Parse(Console.ReadLine());

            int sumOfCurrentRack = 0;
            int numOfRacks = 1;
            while (stack.Count > 0)
            {
                if (stack.Peek() + sumOfCurrentRack <= rackCapacity)
                {
                    sumOfCurrentRack += stack.Pop();
                }
                else
                {
                    numOfRacks++;
                    sumOfCurrentRack = 0;
                    sumOfCurrentRack += stack.Pop();
                }

            }
            Console.WriteLine(numOfRacks);
        }
    }
}
