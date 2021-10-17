using System;
using System.Collections.Generic;
using System.Text;

namespace TupleCLass
{
    class Tuple<T1 , T2>
    {

        public Tuple(T1 firstI, T2 secondI)
        {
            FirstItem = firstI;
            SecondItem = secondI;
        }
        public T1 FirstItem { get; set; }

        public T2 SecondItem { get; set; }
    }
}
