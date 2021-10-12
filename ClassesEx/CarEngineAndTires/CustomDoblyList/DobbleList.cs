using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDoblyList
{
    class DobbleList
    {

        public ListItem First { get; set; }

        public ListItem Last { get; set; }

        public int Count
        {
            get
            {
                var counter = 0;
                var currentItem = First;
                while (currentItem != null)
                {
                    counter++;
                    currentItem = currentItem.Next;
                }
                return counter;
            }
        }

        public void AddFirst(int element)
        {
            if (First == null)
            {
                First = new ListItem(element);
                Last = First;
            }
            else
            {
                var newItem = new ListItem(element);
                First.Previous = newItem;
                newItem.Next = First;

                First = newItem;
            }            
        }

        public void AddLast(int element) 
        {
            if (Last == null)
            {
                First = new ListItem(element);
                Last = First;
            }
            else
            {
                var newElement = new ListItem(element); // new last

                Last.Next = newElement;     // making current last - previous to the new last
                newElement.Previous = Last;

                Last = newElement;
            }
        
        }

        public int RemoveFirts()
        {
            if (First == null)
            {
                throw new InvalidOperationException("List is empty");
            }

            int valueToReturn = First.Value;
            if (First == Last)
            {
                First = null;
                Last = null;
            }
            else
            {
                First = First.Next;
                First.Previous = null;
            }

            return valueToReturn;

        }

        public int RemoveLast()
        {
            if (Last == null)
            {
                throw new InvalidOperationException("List is empty");
            }

            int valueToReturn = Last.Value;

            if (First == Last)
            {
                First = null;       // Because last item is also the first item
                Last = null;
            }
            else
            {
                Last = Last.Previous;
                Last.Next = null;
            }

            return valueToReturn;
        }

        public void ForEach(Action<int> action)
        {
            var currentElement = First;
            while (currentElement != null)
            {
                action(currentElement.Value);

                currentElement = currentElement.Next;
            }
        }

        public int[] ToArray()
        {
            if (First == null)
            {
                throw new Exception("List is empty!");
            }

            var array = new int[Count];
            var currentItem = First;
            var index = 0;

            while (currentItem != null)
            {
                array[index] = currentItem.Value;

                currentItem = currentItem.Next;
                index++;
            }

            return array;
        }
    }
}
