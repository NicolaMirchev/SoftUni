using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Circle : IShape
    {
        public Circle(int radius)
        {
            Radius = radius;
        }
        public int Radius { get; private set; }
        public double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public double CalculateParameter()
        {
            return Radius * 2 * Math.PI;
        }

        public string Draw()
        {
            throw new NotImplementedException();
        }
    }
}
