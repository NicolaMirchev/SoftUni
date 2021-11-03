using System;

namespace Telephony
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] URLs = Console.ReadLine().Split(' ');

            foreach (var number in phoneNumbers)
            {
                var phone = new Phone();
                phone.CallPhone(number);
            }
            foreach (var URL in URLs)
            {
                var phone = new Phone();
                phone.Browse(URL);
            }
        }
    }
}
