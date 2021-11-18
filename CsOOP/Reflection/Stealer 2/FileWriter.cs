using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Stealer
{
    class FileWriter : IWriter
    {
        public void Write(string data)
        {
            using StreamWriter sw = new StreamWriter("result.txt");
            sw.WriteLine(data);
            
        }
    }
}
