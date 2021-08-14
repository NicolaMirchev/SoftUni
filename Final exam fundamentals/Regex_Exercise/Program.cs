using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesOfCodeAndLogic
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            string command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                string[] data = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (data[0].ToLower() == "translate")
                {
                    string oldChar = data[1];
                    string newChar = data[2];

                    text =  text.Replace(oldChar, newChar);
                    Console.WriteLine(text);

                }
                else if (data[0].ToLower() == "includes")
                {
                    string value = data[1];
                    if (text.Contains(value))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }

                }
                else if (data[0].ToLower() == "start")
                {
                    string value = data[1];
                    if (text.StartsWith(value))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }

                }
                else if (data[0].ToLower() == "lowercase")
                {
                    text = text.ToLower();
                    Console.WriteLine(text);
                }
                else if (data[0].ToLower() == "findindex")
                {
                    string value = data[1];

                    int index = text.LastIndexOf(value);
                    Console.WriteLine(index);

                }
                else if (data[0].ToLower() == "remove")
                {
                    int startIndex = int.Parse(data[1]);
                    int count = int.Parse(data[2]);

                  text =  text.Remove(startIndex, count);
                    Console.WriteLine(text);
                }


                command = Console.ReadLine();

            }


        }


    }
}


