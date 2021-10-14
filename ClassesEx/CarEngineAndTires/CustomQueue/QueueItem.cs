using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomQueue
{
    class QueueItem
    {

        public QueueItem(int value)
        {
            Value = value;
        }
        public QueueItem PreviousItem { get; set; }

        public QueueItem NextItem { get; set; }

        public int Value { get; set; }

    }
}
