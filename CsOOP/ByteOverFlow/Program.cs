using System;

namespace ExeptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            byte result;

            firstNumber = 30;
            secondNumber = 60;
            try
            {
                result = Convert.ToByte(firstNumber * secondNumber);
                Console.WriteLine(result);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Type byte can be fewer than " + byte.MaxValue);
            }

        }
    }
}
