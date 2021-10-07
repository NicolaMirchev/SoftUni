using System;
using System.Linq;

namespace PartyPeolpe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] guests = Console.ReadLine().Split(' ');

            string command = Console.ReadLine();

            while (command.ToLower() != "Party!")
            {
                string[] data = command.Split(' ') ;
                if (data[0].ToLower() == "remove")
                {
                    if (true)
                    {

                    }

                }
                else if (data[0].ToLower() == "double")
                {

                }



                command = Console.ReadLine();
            }
        }
    }
}
