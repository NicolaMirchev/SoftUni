using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(5, 6);

            Console.WriteLine(rectangle.Draw());
        }
    }
}
