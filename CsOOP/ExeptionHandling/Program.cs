using System;

namespace ExeptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Satarday",
                "Sunday"
            };

            for (int i = 0; i <= weekDays.Length ; i++)
            {
                try
                {
                    Console.WriteLine(weekDays[i]);
                }
                catch (IndexOutOfRangeException exeption)
                {
                    
                    Console.WriteLine("Loop is bigger than the array!"
                        + $"\n {exeption.Source}");
                }
                catch (Exception)
                {
                    Console.WriteLine("Error");
                }
            }
            Console.ReadLine();

        }
    }
}
