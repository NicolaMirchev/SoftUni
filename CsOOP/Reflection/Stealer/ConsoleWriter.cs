using System;
using System.Collections.Generic;
using System.Text;

namespace Stealer
{
    class ConsoleWriter : IWriter
    {
        public void Write(string data)
        {
            Console.WriteLine(data);
        }
    }
}
