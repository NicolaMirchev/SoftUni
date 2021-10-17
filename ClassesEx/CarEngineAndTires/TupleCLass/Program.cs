using System;

namespace TupleCLass
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] firstLine = Console.ReadLine().Split(' ');
            var name = new Tuple<string, string>(firstLine[0] + " "+ firstLine[1], firstLine[2]);

            Console.WriteLine(name.FirstItem + " -> " + name.SecondItem);

            string[] secondLine = Console.ReadLine().Split(' ');
            var secondTuple = new Tuple<string, int>(secondLine[0], int.Parse(secondLine[1]));

            Console.WriteLine(secondTuple.FirstItem + " -> " + secondTuple.SecondItem);

            string[] thirdLine = Console.ReadLine().Split(' ');
            int firstItem = int.Parse(thirdLine[0]);
            double secondItem = double.Parse(thirdLine[1]);
            var thirdTuple = new Tuple<int, double>(firstItem, secondItem);
            Console.WriteLine(thirdTuple.FirstItem + " -> " + thirdTuple.SecondItem);


        }
    }
}
