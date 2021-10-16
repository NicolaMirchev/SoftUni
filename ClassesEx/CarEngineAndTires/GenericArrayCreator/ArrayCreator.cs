using System;
using System.Collections.Generic;
using System.Text;

namespace GenericArrayCreator
{
    class ArrayCreator<T>
    {
        public ArrayCreator()
        {

        }
        public static T[] Create(int length, T data)
        {
            var array = new T[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = data;
            }

            return array;
        }
    }
}
