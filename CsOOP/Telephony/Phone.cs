using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    class Phone : StationaryPhone
    {

        public void Browse(string URL)
        {
            foreach (var item in URL)
            {
                if (char.IsDigit(item))
                {
                    Console.WriteLine("Invalid URL!");
                    return;
                }
            }
            Console.WriteLine($"Browsing: {URL}!");
        }
    }
}
