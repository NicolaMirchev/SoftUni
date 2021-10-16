using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    class Box<T>
    {
        public Box()
        {
            IternalStorage = new List<T>();
        }
        public int Count { get => IternalStorage.Count; }      

        private List<T> IternalStorage { get; set; }

        public void Add(T item)
        {
            IternalStorage.Add(item);
        }

        public T Remove()
        {
            var itemToReturn = IternalStorage[IternalStorage.Count - 1];
            IternalStorage.RemoveAt(IternalStorage.Count - 1);

            return itemToReturn;
        }

}
}
