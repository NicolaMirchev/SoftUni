using System;

namespace CryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {


            string input = Console.ReadLine();

            string result = Encrypting.Encrypt(input);
            Console.WriteLine(result);

            Console.WriteLine(Encrypting.Decrypt(result));
        }
    }
}
