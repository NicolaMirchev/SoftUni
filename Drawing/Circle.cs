using System;
using System.Collections.Generic;
using System.Text;

namespace Drawing
{
    class Circle : IDrawoble
    {
        public Circle(int radius)
        {
            Radius = radius;
        }
        public int Radius { get; private set; }

        public void Draw()
        {
            Console.WriteLine("I should draw circle with radius" + Radius);
        }
    }
}
