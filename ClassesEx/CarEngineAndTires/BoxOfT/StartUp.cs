using System;

namespace BoxOfT
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var newBox = new Box<int>();
            var boxOfStrings = new Box<string>();

            newBox.Add(5);
            newBox.Add(6);
            newBox.Add(7);

            Console.WriteLine(newBox.Remove());

            Console.WriteLine(newBox.Count);
        }
    }
}
