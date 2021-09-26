using System;
using System.Collections;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int queueCap = data[0];
            int elementToDequeue = data[1];
            int elementToSeek = data[2];

            Queue queue = new Queue(Console.ReadLine()
                     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToArray());

            for (int i = 0; i < elementToDequeue; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count > 0)
            {
                if (queue.Contains(elementToSeek))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    int smallestNum = int.MaxValue;
                    while (queue.Count > 0)
                    {
                        int currentNum = (int)queue.Dequeue();
                        if (currentNum < smallestNum)
                        {
                            smallestNum = currentNum;
                        }
                    }
                    Console.WriteLine(smallestNum);
                }
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
