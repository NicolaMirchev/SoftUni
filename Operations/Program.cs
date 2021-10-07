using System;
using System.Collections.Generic;
using System.Linq;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();

            Func<int, int> add = x => x + 1;
            Func<int, int> subtract = x => x - 1;
            Func<int, int> multiply = x => x * 2;
            Action<List<int>> print = x => Console.WriteLine(string.Join(" ", x));

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                      list =  list.Select(add).ToList();
                        break;

                    case "subtract":
                        list = list.Select(subtract).ToList();
                        break;

                    case "multiply":
                      list =  list.Select(multiply).ToList();
                        break;

                    case "print":
                        print(list);
                        break;

                    default:
                        break;
                }





                command = Console.ReadLine();
            }
            
        }
    }
}
