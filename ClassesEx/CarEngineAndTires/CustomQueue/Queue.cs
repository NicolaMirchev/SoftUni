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

        public void Enqueue(int item)
        {
            if (FirstItem == null)
            {
                var newItem = new QueueItem(item);
                FirstItem = newItem;
            }
            else
            {
                var newItem = new QueueItem(item);
                newItem.NextItem = FirstItem;
                FirstItem = newItem;
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
    }
}
