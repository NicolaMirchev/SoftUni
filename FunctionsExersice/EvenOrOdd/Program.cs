using System;
using System.Linq;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            Predicate<int> isEven = x => x % 2 == 0;

            for (int i = range[0]; i <= range[1]; i++)
            {
                if (command == "even")
                {
                    if (isEven(i))
                    {
                        Console.Write($"{i} ");
                    }
                }
                else if (command == "odd")
                {
                    if (!isEven(i))
                    {
                        Console.WriteLine($"{i} ");
                    }

                }
                
                

                

            }
        }
    }
}
