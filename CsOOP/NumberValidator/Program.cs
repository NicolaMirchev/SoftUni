using System;

namespace NumberValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 5;
            int end = 20;
            try
            {
                ReadNumber(int.Parse("neshtosi"), start);
            }
            catch (FormatException)
            {
                Console.WriteLine("Input should be valid integer!");
            }
            finally
            {
                Console.Beep(500, 1);
                Console.Beep(400, 5);
                Console.Beep(300, 1);
                Console.Beep(200, 5);
                Console.Beep(100, 10);
            }
        }

             public static void ReadNumber(int start, int end)
            {
                int i = start;
                try
                {
                    while (i != end)
                    {
                        Console.WriteLine(i);
                        i++;
                    }

                }
                catch (Exception)
                {

                    throw;
                }
            
        }
    }
}
