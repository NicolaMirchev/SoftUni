using System;
using System.Collections.Generic;

namespace GenericArrayCreator
{
    class StartUp
    {
        static void Main(string[] args)
        {

            var newArray = ArrayCreator<string>.Create(12, "I Am The Programmer");

            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }

            var check = new ArrayCreator<int>();

            var checl = ArrayCreator<List<int>>.Create(4, new List<int>() { 12, 15 });

            foreach (var item in checl)
            {
                foreach (var Item in item)
                {
                    Console.WriteLine(Item);
                }
            }
        }
    }
}
