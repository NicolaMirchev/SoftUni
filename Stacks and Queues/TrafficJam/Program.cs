using System;
using System.Collections;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            Queue queue = new Queue();
            int counter = 0;
            string command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < capacity; i++)
                    {
                        if (queue.Count >= 1)
                        {


                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            counter++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(command);
                    
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
