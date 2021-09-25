using System;
using System.Collections;

namespace Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            Queue queue = new Queue(people);

            while (queue.Count > 1)
            {
                for (int i = 1; i < n; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                var Name = queue.Dequeue();
                Console.WriteLine($"Removed {Name}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
        
    }
}
