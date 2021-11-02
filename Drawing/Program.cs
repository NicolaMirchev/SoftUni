using System;

namespace Drawing
{
    class Program
    {
        static void Main(string[] args)
        {

            var cirle = new Circle(6);
            IDrawoble rectangle = new Rectangle(10, 5);

            rectangle.Draw();         
        }
    }
}
