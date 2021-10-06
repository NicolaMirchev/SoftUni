using System;

namespace ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ");
            Action<string[]> returnName = x => Console.WriteLine(string.Join(Environment.NewLine, x));

            returnName.Invoke(names);


            

        }
    }
}
