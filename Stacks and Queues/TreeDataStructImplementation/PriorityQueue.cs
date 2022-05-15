using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraAlgorithm
{
    class PriorityQueue  
    {

        private int[] elementsArray;

        private int capacity;

        public int currentElementsCount { get; private set; }
        
        public PriorityQueue(int capacity)
        {
            this.capacity = capacity;
            elementsArray = new int[capacity];
        }


        public void PrintCurrentQueueOrder()
        {
            for (int i = 0; i < currentElementsCount; i++)
            {
                Console.WriteLine(elementsArray[i]);
            }
        }
        public void Enqueue(int element)
        {

            if (currentElementsCount + 1 > capacity)
            {
                Console.WriteLine("Queue is full!!");
                return;
            }

            elementsArray[currentElementsCount] = element;
            currentElementsCount++;

            if (currentElementsCount > 1)
            {
                BalanceNewElement(element, currentElementsCount - 1);                
            }


        }
        
        public int Dequeue()
        {
            int valueToReturn = elementsArray[0];



            elementsArray[0] = elementsArray[currentElementsCount - 1];
            currentElementsCount--;

            Heapify(0);


            return valueToReturn;
        }


        private void Heapify(int index)
        {
            int l = Left(index);
            int r = Right(index);

            int smallest = index;

            if (l < currentElementsCount && elementsArray[l] < elementsArray[smallest])
            {
                smallest = l;
            }
            if (r < currentElementsCount && elementsArray[r] < elementsArray[smallest])
            {
                smallest = r;
            }

            if (smallest != index)
            {
                int temp = elementsArray[index];
                elementsArray[index] = elementsArray[smallest];
                elementsArray[smallest] = temp;

                Heapify(smallest);
            }

                
        }
        private void BalanceNewElement(int element, int index)
        {

            int parentElementIndex = (index - 1) / 2;


            while (elementsArray[parentElementIndex] > element )
            {
                elementsArray[index] = elementsArray[parentElementIndex];
                elementsArray[parentElementIndex] = element;

                index = parentElementIndex;
                parentElementIndex = (index - 1) / 2;

                if (index == 0)
                {
                    return;
                }
            }

        }

        private int Left(int key)
        {
            return (key * 2) + 1;
        }
        private int Right(int key)
        {
            return (key * 2) + 2;
        }

    }
}
