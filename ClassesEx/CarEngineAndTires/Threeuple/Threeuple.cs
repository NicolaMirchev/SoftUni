using System;
using System.Collections.Generic;
using System.Text;

namespace TupleCLass
{
    class Threeuple<T1, T2, T3>
    {

        public Threeuple(T1 firstI, T2 secondI, T3 third)
        {
            FirstItem = firstI;
            SecondItem = secondI;
            ThirdItem = third;
        }
        public T1 FirstItem { get; set; }

        public T2 SecondItem { get; set; }

        public T3 ThirdItem { get; set; }

        public void ConsoleWritline()
        {

            Console.WriteLine(FirstItem + " -> " + SecondItem + " -> " + ThirdItem );
        }
    }
}
