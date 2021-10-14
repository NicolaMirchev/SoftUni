using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class ListClass
    {
        public ListClass()
        {
            Array = new int[2];
            Indexer = -1;
        }
        private int[] Array { get; set; }

        public int Indexer { get; private set; }

        public int Count {

            get
            {
                return Indexer + 1;
            }


        
        }


        public void Add(int element)
        {
            Indexer++;
            if (Indexer + 1 > Array.Length)
            {
                int[] newArray = new int[Array.Length * 2];
                for (int i = 0; i < Array.Length; i++)
                {
                    newArray[i] = Array[i];
                }

                Array = newArray;

                Array[Indexer] = element;
            }
            else
            {
                Array[Indexer] = element;
            }

        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > Indexer)
            {
                throw new IndexOutOfRangeException();
            }

            Array[index] = 0;

            for (int i = index; i < Indexer; i++)
            {
                Array[i] = Array[i + 1];
            }
            Array[Indexer--] = 0;
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < Indexer; i++)
            {
                if (Array[i] == element)
                {
                    return true;                    
                }
            }
            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (firstIndex < 0 || firstIndex > Indexer || secondIndex < 0 || secondIndex > Indexer)
            {
                throw new IndexOutOfRangeException();
            }

            int savedValue = Array[secondIndex];            //Saved value from second index
            Array[secondIndex] = Array[firstIndex];
            Array[firstIndex] = savedValue;
        }
    }


}
