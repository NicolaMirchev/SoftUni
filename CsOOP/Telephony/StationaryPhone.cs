using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    abstract class StationaryPhone
    {
        public void CallPhone(string phone)
        {
            foreach (var charr in phone)
            {
                if (!char.IsDigit(charr))
                {
                    Console.WriteLine("Invalid number!");
                    return;
                }
            }
            if (phone.Length == 10)
            {
                Console.WriteLine($"Calling... {phone}");
            }
            else
            {
                Console.WriteLine($"Dialing... {phone}");
            }

        }
    }
}
