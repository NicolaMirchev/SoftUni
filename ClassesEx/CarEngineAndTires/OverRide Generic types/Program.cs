using System;

namespace GenericBoxOfString
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int dataLength = int.Parse(Console.ReadLine());

            var newClass = new Box<string>();

            for (int i = 0; i < dataLength; i++)
            {
                newClass.Add(Console.ReadLine());
            }

            Console.WriteLine(newClass);

        }
    }
}
