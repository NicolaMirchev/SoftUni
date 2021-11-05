using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Rectangle : IShape
    {
        public Rectangle(int Hight, int Width)
        {
            this.Hight = Hight;
            this.Width= Width;
        }
        public int Hight { get; private set; }

        public int Width { get; private set; }

        public double CalculateArea()
        {
            return Hight * Width;
        }

        public double CalculateParameter()
        {
            return Width * 2 + Hight * 2;
        }

        public string Draw()
        {
            var sb = new StringBuilder();
            sb.AppendLine(new string('*', Width));
            for (int i = 1; i < Hight - 1; i++)
            {
                sb.AppendLine('*' + new string(' ', Width - 2) + '*');
            }
            sb.AppendLine(new string('*', Width));

            return sb.ToString();
        }
    }
}
