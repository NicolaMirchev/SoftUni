using System;

namespace TupleCLass
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] firstLine = Console.ReadLine().Split(' ');
            string name = firstLine[0] + " " + firstLine[1];

            var T1 = new Threeuple<string, string, string>(name, firstLine[2], firstLine[3]);
            T1.ConsoleWritline();


            string[] secondLine = Console.ReadLine().Split(' ');
            bool drunk = true;

            if (secondLine[1] == "drunk")
            {
                drunk = true;
            }
            else
            {
                drunk = false;
            }

            var T2 = new Threeuple<string, int, bool>(secondLine[0], int.Parse(secondLine[1]), drunk);
            T2.ConsoleWritline();

            string[] thirdLine = Console.ReadLine().Split(' ');
            var T3 = new Threeuple<string, double, string>(thirdLine[0], double.Parse(thirdLine[1]), thirdLine[2]);
            T3.ConsoleWritline();

        }
    }
}
