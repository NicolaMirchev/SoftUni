using System;

namespace NumberValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            string firstName = data[0];
            string lastName = data[1];
            int age = 0;
            bool inValid = true;
            while (inValid)
            {
                try
                {
                    age = int.Parse(Console.ReadLine());
                    inValid = false;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message + "Reenter the age");
                }



            }


            Person person = null;
            bool validPersonIsCreated = false;
            while (!validPersonIsCreated)
            {

                try
                {
                    person = new Person(firstName, lastName, age);
                    validPersonIsCreated = true;
                }
                catch (IndexOutOfRangeException exeption)
                {
                    Console.WriteLine(exeption.Message );
                    Console.WriteLine("Reenter the age.");
                    age = int.Parse(Console.ReadLine());
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Reenger the name");
                    if (string.IsNullOrEmpty(firstName))
                    {
                    firstName = Console.ReadLine();
                    }
                    else
                    {
                        lastName = Console.ReadLine();
                    }
                }
            }

            Console.WriteLine(person);
        }
    }
}
