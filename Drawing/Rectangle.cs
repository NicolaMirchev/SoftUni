using System;
using System.Collections.Generic;
using System.Text;

namespace Drawing
{
    class Rectangle : IDrawoble
    {

        public Rectangle(int width, int high)
        {
            Width = width;
            High = high;
        }
        public int Width { get; private set; }
        public int High { get; private set; }
        public void Draw()
        {
            for (int i = 0; i < Width; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
            for (int i = 1; i < High - 1; i++)
            {
                Console.Write('*');
                Console.SetCursorPosition(Width - 1, i);
                Console.WriteLine('*');
            }
            for (int i = 0; i < Width; i++)
            {
            Console.Write('*');
            }
        }
    }
}
