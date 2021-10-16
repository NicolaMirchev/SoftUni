
using System;
using System.Linq;

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

            int[] indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            newClass.Swap(indexes[0], indexes[1]);


            Console.WriteLine(newClass);

        }
    }
}