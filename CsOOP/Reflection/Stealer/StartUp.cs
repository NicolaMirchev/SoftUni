using System;

namespace Stealer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Hacker hacker = new Hacker();

            Console.WriteLine(hacker.Password);
        }
    }
}
