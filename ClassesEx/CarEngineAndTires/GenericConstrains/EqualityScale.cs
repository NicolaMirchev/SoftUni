using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
   public class EqualityScale<T>
        where T : class
    {
        public EqualityScale(T Left, T Right)
        {
            this.Left = Left;
            this.Right = Right;
        }

        private T Left { get; set; }

        private T Right { get; set; }

        public bool AreEqual()
        {
            return Left.Equals(Right); 
        }
    }
}
