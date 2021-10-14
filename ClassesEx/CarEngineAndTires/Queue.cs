using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomQueue
{
    class Queue
    {
        public Queue()
        {

        }
        public QueueItem FirstItem { get; set; }

        public QueueItem LastItem { get; set; }

        public void Enqueue(int item)
        {
            if (FirstItem == null)
            {
                var newItem = new QueueItem(item);
                FirstItem = newItem;
                LastItem = newItem;
            }
            else
            {
                var newItem = new QueueItem(item);
                LastItem.NextItem = newItem;
                LastItem = newItem;
            }        
        }

        public int Dequeue()
        {
            if (FirstItem == null)
            {
                throw new InvalidOperationException("Queue is empty!");
            }

            int firstItemValue = FirstItem.Value;

            FirstItem = FirstItem.NextItem;
            return firstItemValue;
        }

        public int Peek()
        {
            return FirstItem.Value;
        }

        public void Clear()
        {
            FirstItem = null;
            LastItem = null;
        }

        public void Foreach(Action<int> action)
        {
            var currentItem = FirstItem;

            while (currentItem != null)
            {

               action(currentItem.Value);
               currentItem = currentItem.NextItem;

            }
        }
        
    }
}
