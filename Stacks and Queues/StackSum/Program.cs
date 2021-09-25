using System;
using System.Collections;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            Stack stack = new Stack(numbers);

            while (command.ToLower() != "end")
            {
                string[] data = command.Split();

                if (data[0].ToLower() == "add")
                {

                    stack.Push(int.Parse(data[1]));
                    stack.Push(int.Parse(data[2]));
                }
                else if (data[0].ToLower() == "remove")
                {
                    if (stack.Count >= int.Parse(data[1]))
                    {
                        for (int i = 0; i < int.Parse(data[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine();
            }
            int sum = 0;
            foreach (var item in stack)
            {
                sum += (int)item;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
