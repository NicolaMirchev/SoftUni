using System;

namespace CustomQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var myQueue = new Queue();

            myQueue.Enqueue(12);
            myQueue.Enqueue(13);
            myQueue.Enqueue(14);

            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Peek());

            myQueue.Clear();

            myQueue.Enqueue(1);
            myQueue.Enqueue(2);

            Action<int> action = x => x += x * 2;

            myQueue.Foreach(action);

        }
        
    }
}
