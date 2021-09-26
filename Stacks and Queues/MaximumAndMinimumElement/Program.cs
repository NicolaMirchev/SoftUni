using System;
using System.Collections;
using System.Collections.Generic;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                string[] querie = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (querie[0] == "1")
                {

                    int valueToStack = int.Parse(querie[1]);
                    stack.Push(valueToStack);

                }
                if (querie[0] == "2")
                {
                    if (stack.Count>0)
                    {
                    stack.Pop();
                    }

                }
                if (querie[0] == "3")
                {

                    int[] arr = stack.ToArray();
                    int maxValue = int.MinValue;
                    foreach (var item in arr)
                    {
                        if (item > maxValue)
                        {
                            maxValue = item;
                        }                       
                    }
                    Console.WriteLine(maxValue);

                }
                if (querie[0] == "4")
                {

                    int[] arr = stack.ToArray();
                    int minValue = int.MaxValue;
                    foreach (var item in arr)
                    {
                        if (item < minValue)
                        {
                            minValue = item;
                        }
                    }

                    Console.WriteLine(minValue);
                }


            }
            int[] finalState = stack.ToArray();
            Console.WriteLine(string.Join(", ",finalState));
        }
    }
}
